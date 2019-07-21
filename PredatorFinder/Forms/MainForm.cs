using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using PredatorFinder.Classes;
using System.Diagnostics;
using System.IO;
using System.Net;
using PredatorFinder.Forms;

namespace PredatorFinder
{
    public partial class MainForm : Form
    {
        
        public Checker Check = new Checker();
        private decimal _fromNumber;
        private decimal _toNumber;
        private string _pattern = ".xsph.ru/login";
        public MainForm()
        {
            Icon = Properties.Resources.icon;
            InitializeComponent();
            
        }

        private async void GenerateSource()
        {
            Globals.Source.Clear();
            _fromNumber = Convert.ToDecimal(generateFromTxt.Text);
            _toNumber = Convert.ToDecimal(generateToTxt.Text);
            await Task.Run(() =>
            {
                for (decimal i = _fromNumber; i <= _toNumber; i++)
                {
                    Globals.Source.Add($"http://{letterTxtBox.Text}0{i.ToString()}{_pattern}");
                }
            });
            SetSourceTxt((Globals.Source.Count).ToString());
        }

        public delegate void MethodInvoker(object arg);
        public void UpdateUI(object arg)
        {
            try
            {
                if (InvokeRequired)
                {
                    //вызываем себя в главный поток
                    Invoke(new MethodInvoker(UpdateUI), arg);
                    return;
                }
                //Присвоение всегда будет происходить только в главном потоке, независимот от того
                //в каком потоке мы вызываем метод
                logTxtBox.Text = arg + logTxtBox.Text;
            }
            catch { }
            
        }

        public void SetSourceTxt(string count)
        {
            lblSourceCount.Text = count;
        }

        private void WtfLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new InfoForm().ShowDialog();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!Check.IsWork)
            {
                Globals.StarTime = DateTime.Now;
                Globals.PossiblyDomainListTemp.Clear(); //Чистим временно хранилище возможных доменов
                if (!string.IsNullOrEmpty(proxyTextBox.Text))
                    Globals.Proxy = proxyTextBox.Text;
                if (Globals.Source.Count == 0)
                {
                    MessageBox.Show("Please, generate domain", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Globals.BadDomain = 0;
                Globals.GoodDomain = 0;
                Globals.Threads = (int)threadNumeric.Value;
                try
                {
                    Globals.TimeOut = int.Parse(timeoutTextBox.Text);
                }
                catch (Exception exception)
                {
                    Globals.WorkStatus = string.Format("TimeOut: {0}", exception.Message);
                }
                Check.CreateThreads();

                startButton.Text = "Stop..";
                sourceGrp.Enabled = false;
                settingsGrp.Enabled = false;
                logTxtBox.Clear();
            }
            else
            {
                MessageBox.Show("Wait for the threads to stop", "Wait", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Check.StopThreads();
                startButton.Text = "Start";
                sourceGrp.Enabled = true;
                settingsGrp.Enabled = true;
                 
            }
        }

        private void ThreadNumeric_ValueChanged(object sender, EventArgs e)
        {
            Globals.Threads = (int) threadNumeric.Value;
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (!Check.IsWork)
            {
                startButton.Text = "Start";
                sourceGrp.Enabled = true;
                settingsGrp.Enabled = true;
                lblLeftCount.Text = "0";
            }

            lblGoodCount.Text = Globals.GoodDomain.ToString();
            timeoutCountLbl.Text = Globals.ProxyNeed.ToString();
            lblBadCount.Text = Globals.BadDomain.ToString();
            lblLeftCount.Text = (Globals.Source.Count - (Globals.GoodDomain + Globals.BadDomain + Globals.ProxyNeed)).ToString();
        }

        private void ShowStatisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trayNotify.BalloonTipIcon = ToolTipIcon.Info;
            trayNotify.BalloonTipTitle = "Statistic";
            trayNotify.BalloonTipText = Helper.Statistic();
            trayNotify.ShowBalloonTip(5000);
        }

        private void ShowProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void TrayNotify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                trayNotify.Visible = true;
            }
        }

        private void GenerateSourceButton_Click(object sender, EventArgs e)
        {
            var stop = new Stopwatch();
            stop.Start();
            GenerateSource();
            stop.Stop();
            MessageBox.Show($"{stop.Elapsed}");
        }

        private void GenerateFromTxt_TextChanged_1(object sender, EventArgs e)
        { 
            try
            {
                //Non informative comment
                //Почти 3 часа убил на эти три строчки. Просто захотелось узнать Kappa
                var s = double.Parse(generateFromTxt.Text);
                generateFromTxt.SelectionStart = generateFromTxt.Text.Length;
                generateFromTxt.Text = s.ToString("#,#");
            }
            catch (Exception exception)
            {
                
            }
            
        }

        private void GenerateFromTxt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void GenerateToTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void GenerateToTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var s = double.Parse(generateToTxt.Text);
                generateToTxt.SelectionStart = generateToTxt.Text.Length;
                generateToTxt.Text = s.ToString("#,#");
            }
            catch { }
        }

        private void LetterTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RecheckChooseButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Loaded last check possibly domain?", "Loaded", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Globals.Source.Clear();
                Globals.Source.AddRange(Globals.PossiblyDomainListTemp);
                MessageBox.Show($"Loaded {Globals.Source.Count.ToString()} domains");
                SetSourceTxt(Globals.Source.Count.ToString());
                SetZeroText();
                tabControl1.SelectedTab = tabPage1;
            }
            else
            {
                Globals.Source = Helper.LoadData(Helper.OpenDialog());
                SetSourceTxt(Globals.Source.Count.ToString());
                MessageBox.Show($@"Loaded {Globals.Source.Count.ToString()} domains");
                SetZeroText();
                tabControl1.SelectedTab = tabPage1;
            }
            

        }

        private void InfoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Set HTTP Proxy address and set timeout > 150000", "TimeOut Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetZeroText()
        {
            Globals.GoodDomain = 0;
            Globals.BadDomain = 0;
            Globals.ProxyNeed = 0;
        }
    }
}
