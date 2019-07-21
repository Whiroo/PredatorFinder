using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace PredatorFinder.Classes
{
    public class Checker
    {
        private Thread[] _threads;
        private static int _domainIndex = -1;
        public bool IsWork = false;
        public object SyncIndex = new object();
        public object SyncFiles = new object();
        public void CreateThreads()
        {
            _domainIndex = -1;
            IsWork = true;
            _threads = new Thread[1000];

            for (int i = 0; i < Globals.Threads; i++)
            {
                if (i > Globals.Source.Count)
                    break;
                _threads[i] = new Thread(Checking);
                _threads[i].IsBackground = true;
                _threads[i].Start();
            }
        }

        public static string Check(string domain)
        {
            try
            {
                
                var request = (HttpWebRequest)WebRequest.Create(domain);//WebRequest.Create(domain);
                HttpWebResponse response;
                string strResponse;
                if(Globals.Proxy != String.Empty)
                    request.Proxy = new WebProxy(Globals.Proxy);
                request.Method = "POST";
                request.AllowAutoRedirect = false;
                request.ContentType = "";
                request.Timeout = Globals.TimeOut;
                response = (HttpWebResponse) request.GetResponse();
                strResponse = response.StatusDescription;
                
                if (!strResponse.Contains("Moved") && response.Server == "openresty") 
                {
                    return "Good";
                }
                else
                {
                    return "Bad";
                }
            }
            catch (Exception e)
            {
                return e.Message.Contains("истекло") ? "handWork" : "Bad";
            }
        }

        public void StopThreads()
        {
            IsWork = false;
        }

        private void Checking()
        {
            while (IsWork)
            {
                string response = "";
                string currentDomain;

                int localDomainIndex;
                lock (SyncIndex)
                {
                    _domainIndex++;
                    localDomainIndex = _domainIndex;
                }

                if (localDomainIndex > Globals.Source.Count - 1)
                {
                    IsWork = false;
                    break;
                }

                try
                {
                    currentDomain = Globals.Source[localDomainIndex];
                }
                catch (Exception e)
                {
                    MessageBox.Show("Wrong domain");
                    IsWork = false;
                    return;
                }

                
                try
                {
                    response = Check(currentDomain);
                }
                catch
                {
                }

                lock (SyncFiles)
                {
                    if (response.Contains("Good"))
                    {
                        Helper.SaveText(string.Format("good-{0:HH.mm.ss-dd-MM-yyyy}.txt",Globals.StarTime),currentDomain);
                        Globals.GoodDomain++;
                        Program.mFrom.UpdateUI(Globals.Source[localDomainIndex] + Environment.NewLine);
                    }
                    else if(response.Contains("Bad"))
                    {
                        Helper.SaveText(string.Format("bad-{0:HH.mm.ss-dd-MM-yyyy}.txt", Globals.StarTime), currentDomain);
                        Globals.BadDomain++;
                    }
                    else if(response.Contains("handWork"))
                    {
                        Helper.SaveText(string.Format("possibly-{0:HH.mm.ss-dd-MM-yyyy}.txt", Globals.StarTime), currentDomain);
                        Globals.ProxyNeed++;
                    }
                }
                Thread.Sleep(600);
            }
        }
    }
}
