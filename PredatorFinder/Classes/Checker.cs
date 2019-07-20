using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredatorFinder.Classes
{
    class Checker
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
                _threads[i] = new Thread(this.Checking);
                _threads[i].IsBackground = true;
                _threads[i].Start();
            }
        }

        public static string Check(string domain)
        {
            try
            {
                var request = WebRequest.Create(domain);//WebRequest.Create(domain);
                WebResponse response;
                string strResponse;

                request.Method = "POST";
                request.ContentType = "";
                request.Timeout = Globals.TimeOut;
                response = request.GetResponse();
                strResponse = response.ToString();
                if (strResponse.Contains(""))
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
                return "Bad";
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
                    currentDomain = Globals.Source[localDomainIndex].ToString();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Wrong domain");
                    IsWork = false;
                    return;
                }

                while (IsWork)
                {
                    try
                    {
                        Check(currentDomain);
                    }
                    catch { }
                    
                }

                lock (SyncFiles)
                {
                    if (response.Contains("Good"))
                    {
                        Helper.SaveText(string.Format($"good-{0:g}.txt",DateTime.Now),currentDomain);
                        Globals.GoodDomain++;
                    }
                    else
                    {
                        Helper.SaveText(string.Format($"bad-{0:g}.txt", DateTime.Now), currentDomain);
                        Globals.BadDomain++;
                    }
                }
                Thread.Sleep(600);
            }
        }
    }
}
