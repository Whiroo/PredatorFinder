using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;

namespace PredatorFinder.Classes
{
    /// <summary>
    /// Constain global variables
    /// </summary>
    class Globals
    {
        public static string WorkStatus = "";
        public static int Threads = 0;
        public static List<string> Source = new List<string>();
        public static int TimeOut = 7000;
        public static int GoodDomain = 0;
        public static int BadDomain = 0;
        public static string StrProxy = string.Empty;
        public static int ProxyNeed = 0;
        public static string AppPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public static List<string> PossiblyDomainListTemp = new List<string>();
        public static bool ValidProxy = true;
        public static WebProxy Proxy = new WebProxy();
        public static DateTime StarTime;

    }
}
