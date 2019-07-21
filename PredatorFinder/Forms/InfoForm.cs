using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredatorFinder.Forms
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            DownloadInfo();
        }

        private async void DownloadInfo()
        {
            if (!File.Exists("info.pf"))
            {
                await Task.Run(() =>
                {
                    var wc = new WebClient();
                    wc.DownloadFile("https://pastebin.com/raw/ZyLkRv7i", "info.pf");
                });
                infoTxtBox.Text = File.ReadAllText("info.pf");
            }

            infoTxtBox.Text = File.ReadAllText("info.pf");
        }

    }
}
