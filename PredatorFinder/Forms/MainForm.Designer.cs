namespace PredatorFinder
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sourceGrp = new System.Windows.Forms.GroupBox();
            this.generateFromTxt = new System.Windows.Forms.MaskedTextBox();
            this.letterTxtBox = new System.Windows.Forms.TextBox();
            this.letterLbl = new System.Windows.Forms.Label();
            this.wtfLinkLabel = new System.Windows.Forms.LinkLabel();
            this.generateToTxt = new System.Windows.Forms.TextBox();
            this.toLbl = new System.Windows.Forms.Label();
            this.fromLbl = new System.Windows.Forms.Label();
            this.generateSourceButton = new System.Windows.Forms.Button();
            this.settingsGrp = new System.Windows.Forms.GroupBox();
            this.proxyTextBox = new System.Windows.Forms.TextBox();
            this.timeoutTextBox = new System.Windows.Forms.TextBox();
            this.proxyLbl = new System.Windows.Forms.Label();
            this.threadNumeric = new System.Windows.Forms.NumericUpDown();
            this.timeoutLbl = new System.Windows.Forms.Label();
            this.threadsLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblLeftCount = new System.Windows.Forms.Label();
            this.lblBadCount = new System.Windows.Forms.Label();
            this.lblGoodCount = new System.Windows.Forms.Label();
            this.lblSourceCount = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblBad = new System.Windows.Forms.Label();
            this.lblGood = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.logTxtBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.trayNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayStatistic = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showStatisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timeoutCountLbl = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.recheckChooseButton = new System.Windows.Forms.Button();
            this.sourceGrp.SuspendLayout();
            this.settingsGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadNumeric)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.trayStatistic.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceGrp
            // 
            this.sourceGrp.Controls.Add(this.generateFromTxt);
            this.sourceGrp.Controls.Add(this.letterTxtBox);
            this.sourceGrp.Controls.Add(this.letterLbl);
            this.sourceGrp.Controls.Add(this.wtfLinkLabel);
            this.sourceGrp.Controls.Add(this.generateToTxt);
            this.sourceGrp.Controls.Add(this.toLbl);
            this.sourceGrp.Controls.Add(this.fromLbl);
            this.sourceGrp.Controls.Add(this.generateSourceButton);
            this.sourceGrp.Location = new System.Drawing.Point(12, 1);
            this.sourceGrp.Name = "sourceGrp";
            this.sourceGrp.Size = new System.Drawing.Size(128, 127);
            this.sourceGrp.TabIndex = 0;
            this.sourceGrp.TabStop = false;
            // 
            // generateFromTxt
            // 
            this.generateFromTxt.Culture = new System.Globalization.CultureInfo("en-US");
            this.generateFromTxt.Location = new System.Drawing.Point(46, 13);
            this.generateFromTxt.Name = "generateFromTxt";
            this.generateFromTxt.Size = new System.Drawing.Size(74, 20);
            this.generateFromTxt.TabIndex = 1;
            this.generateFromTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.generateFromTxt.ValidatingType = typeof(int);
            this.generateFromTxt.TextChanged += new System.EventHandler(this.GenerateFromTxt_TextChanged_1);
            this.generateFromTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GenerateFromTxt_KeyPress_1);
            // 
            // letterTxtBox
            // 
            this.letterTxtBox.Location = new System.Drawing.Point(47, 58);
            this.letterTxtBox.Name = "letterTxtBox";
            this.letterTxtBox.Size = new System.Drawing.Size(73, 20);
            this.letterTxtBox.TabIndex = 3;
            this.letterTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.letterTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LetterTxtBox_KeyPress);
            // 
            // letterLbl
            // 
            this.letterLbl.AutoSize = true;
            this.letterLbl.Location = new System.Drawing.Point(7, 61);
            this.letterLbl.Name = "letterLbl";
            this.letterLbl.Size = new System.Drawing.Size(37, 13);
            this.letterLbl.TabIndex = 6;
            this.letterLbl.Text = "Letter:";
            // 
            // wtfLinkLabel
            // 
            this.wtfLinkLabel.AutoSize = true;
            this.wtfLinkLabel.Location = new System.Drawing.Point(6, 109);
            this.wtfLinkLabel.Name = "wtfLinkLabel";
            this.wtfLinkLabel.Size = new System.Drawing.Size(111, 13);
            this.wtfLinkLabel.TabIndex = 3;
            this.wtfLinkLabel.TabStop = true;
            this.wtfLinkLabel.Text = "What the hell is this??";
            this.wtfLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WtfLinkLabel_LinkClicked);
            // 
            // generateToTxt
            // 
            this.generateToTxt.Location = new System.Drawing.Point(46, 35);
            this.generateToTxt.Name = "generateToTxt";
            this.generateToTxt.Size = new System.Drawing.Size(74, 20);
            this.generateToTxt.TabIndex = 2;
            this.generateToTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.generateToTxt.TextChanged += new System.EventHandler(this.GenerateToTxt_TextChanged);
            this.generateToTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GenerateToTxt_KeyPress);
            // 
            // toLbl
            // 
            this.toLbl.AutoSize = true;
            this.toLbl.Location = new System.Drawing.Point(7, 38);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(23, 13);
            this.toLbl.TabIndex = 3;
            this.toLbl.Text = "To:";
            // 
            // fromLbl
            // 
            this.fromLbl.AutoSize = true;
            this.fromLbl.Location = new System.Drawing.Point(7, 16);
            this.fromLbl.Name = "fromLbl";
            this.fromLbl.Size = new System.Drawing.Size(33, 13);
            this.fromLbl.TabIndex = 2;
            this.fromLbl.Text = "From:";
            // 
            // generateSourceButton
            // 
            this.generateSourceButton.Location = new System.Drawing.Point(7, 83);
            this.generateSourceButton.Name = "generateSourceButton";
            this.generateSourceButton.Size = new System.Drawing.Size(111, 23);
            this.generateSourceButton.TabIndex = 7;
            this.generateSourceButton.Text = "Generator";
            this.generateSourceButton.UseVisualStyleBackColor = true;
            this.generateSourceButton.Click += new System.EventHandler(this.GenerateSourceButton_Click);
            // 
            // settingsGrp
            // 
            this.settingsGrp.Controls.Add(this.proxyTextBox);
            this.settingsGrp.Controls.Add(this.timeoutTextBox);
            this.settingsGrp.Controls.Add(this.proxyLbl);
            this.settingsGrp.Controls.Add(this.threadNumeric);
            this.settingsGrp.Controls.Add(this.timeoutLbl);
            this.settingsGrp.Controls.Add(this.threadsLabel);
            this.settingsGrp.Location = new System.Drawing.Point(12, 126);
            this.settingsGrp.Name = "settingsGrp";
            this.settingsGrp.Size = new System.Drawing.Size(128, 98);
            this.settingsGrp.TabIndex = 1;
            this.settingsGrp.TabStop = false;
            // 
            // proxyTextBox
            // 
            this.proxyTextBox.Location = new System.Drawing.Point(41, 65);
            this.proxyTextBox.Name = "proxyTextBox";
            this.proxyTextBox.Size = new System.Drawing.Size(81, 20);
            this.proxyTextBox.TabIndex = 6;
            // 
            // timeoutTextBox
            // 
            this.timeoutTextBox.Location = new System.Drawing.Point(59, 40);
            this.timeoutTextBox.Name = "timeoutTextBox";
            this.timeoutTextBox.Size = new System.Drawing.Size(63, 20);
            this.timeoutTextBox.TabIndex = 5;
            this.timeoutTextBox.Text = "7000";
            // 
            // proxyLbl
            // 
            this.proxyLbl.AutoSize = true;
            this.proxyLbl.Location = new System.Drawing.Point(6, 68);
            this.proxyLbl.Name = "proxyLbl";
            this.proxyLbl.Size = new System.Drawing.Size(36, 13);
            this.proxyLbl.TabIndex = 4;
            this.proxyLbl.Text = "Proxy:";
            // 
            // threadNumeric
            // 
            this.threadNumeric.Location = new System.Drawing.Point(59, 14);
            this.threadNumeric.Name = "threadNumeric";
            this.threadNumeric.Size = new System.Drawing.Size(63, 20);
            this.threadNumeric.TabIndex = 4;
            this.threadNumeric.ValueChanged += new System.EventHandler(this.ThreadNumeric_ValueChanged);
            // 
            // timeoutLbl
            // 
            this.timeoutLbl.AutoSize = true;
            this.timeoutLbl.Location = new System.Drawing.Point(6, 43);
            this.timeoutLbl.Name = "timeoutLbl";
            this.timeoutLbl.Size = new System.Drawing.Size(50, 13);
            this.timeoutLbl.TabIndex = 3;
            this.timeoutLbl.Text = "TimeOut:";
            // 
            // threadsLabel
            // 
            this.threadsLabel.AutoSize = true;
            this.threadsLabel.Location = new System.Drawing.Point(6, 16);
            this.threadsLabel.Name = "threadsLabel";
            this.threadsLabel.Size = new System.Drawing.Size(49, 13);
            this.threadsLabel.TabIndex = 2;
            this.threadsLabel.Text = "Threads:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(146, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(165, 183);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.timeoutCountLbl);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblLeftCount);
            this.tabPage1.Controls.Add(this.lblBadCount);
            this.tabPage1.Controls.Add(this.lblGoodCount);
            this.tabPage1.Controls.Add(this.lblSourceCount);
            this.tabPage1.Controls.Add(this.lblLeft);
            this.tabPage1.Controls.Add(this.lblBad);
            this.tabPage1.Controls.Add(this.lblGood);
            this.tabPage1.Controls.Add(this.lblSource);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(157, 157);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Staticstic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblLeftCount
            // 
            this.lblLeftCount.AutoSize = true;
            this.lblLeftCount.Location = new System.Drawing.Point(71, 117);
            this.lblLeftCount.Name = "lblLeftCount";
            this.lblLeftCount.Size = new System.Drawing.Size(13, 13);
            this.lblLeftCount.TabIndex = 7;
            this.lblLeftCount.Text = "0";
            // 
            // lblBadCount
            // 
            this.lblBadCount.AutoSize = true;
            this.lblBadCount.Location = new System.Drawing.Point(71, 66);
            this.lblBadCount.Name = "lblBadCount";
            this.lblBadCount.Size = new System.Drawing.Size(13, 13);
            this.lblBadCount.TabIndex = 6;
            this.lblBadCount.Text = "0";
            // 
            // lblGoodCount
            // 
            this.lblGoodCount.AutoSize = true;
            this.lblGoodCount.Location = new System.Drawing.Point(71, 36);
            this.lblGoodCount.Name = "lblGoodCount";
            this.lblGoodCount.Size = new System.Drawing.Size(13, 13);
            this.lblGoodCount.TabIndex = 5;
            this.lblGoodCount.Text = "0";
            // 
            // lblSourceCount
            // 
            this.lblSourceCount.AutoSize = true;
            this.lblSourceCount.Location = new System.Drawing.Point(71, 7);
            this.lblSourceCount.Name = "lblSourceCount";
            this.lblSourceCount.Size = new System.Drawing.Size(13, 13);
            this.lblSourceCount.TabIndex = 4;
            this.lblSourceCount.Text = "0";
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(6, 117);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(28, 13);
            this.lblLeft.TabIndex = 3;
            this.lblLeft.Text = "Left:";
            // 
            // lblBad
            // 
            this.lblBad.AutoSize = true;
            this.lblBad.Location = new System.Drawing.Point(6, 66);
            this.lblBad.Name = "lblBad";
            this.lblBad.Size = new System.Drawing.Size(29, 13);
            this.lblBad.TabIndex = 2;
            this.lblBad.Text = "Bad:";
            // 
            // lblGood
            // 
            this.lblGood.AutoSize = true;
            this.lblGood.Location = new System.Drawing.Point(6, 36);
            this.lblGood.Name = "lblGood";
            this.lblGood.Size = new System.Drawing.Size(36, 13);
            this.lblGood.TabIndex = 1;
            this.lblGood.Text = "Good:";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(6, 7);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(44, 13);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.logTxtBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(157, 157);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // logTxtBox
            // 
            this.logTxtBox.Location = new System.Drawing.Point(0, 0);
            this.logTxtBox.Multiline = true;
            this.logTxtBox.Name = "logTxtBox";
            this.logTxtBox.ReadOnly = true;
            this.logTxtBox.Size = new System.Drawing.Size(157, 154);
            this.logTxtBox.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(146, 188);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(165, 32);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 1000;
            this.updateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // trayNotify
            // 
            this.trayNotify.ContextMenuStrip = this.trayStatistic;
            this.trayNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("trayNotify.Icon")));
            this.trayNotify.Text = "PredatorFinder";
            this.trayNotify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayNotify_MouseDoubleClick);
            // 
            // trayStatistic
            // 
            this.trayStatistic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showStatisticToolStripMenuItem,
            this.showProgramToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.trayStatistic.Name = "trayStatistic";
            this.trayStatistic.Size = new System.Drawing.Size(153, 70);
            // 
            // showStatisticToolStripMenuItem
            // 
            this.showStatisticToolStripMenuItem.Name = "showStatisticToolStripMenuItem";
            this.showStatisticToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showStatisticToolStripMenuItem.Text = "Show Statistic";
            this.showStatisticToolStripMenuItem.Click += new System.EventHandler(this.ShowStatisticToolStripMenuItem_Click);
            // 
            // showProgramToolStripMenuItem
            // 
            this.showProgramToolStripMenuItem.Name = "showProgramToolStripMenuItem";
            this.showProgramToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showProgramToolStripMenuItem.Text = "Show Program";
            this.showProgramToolStripMenuItem.Click += new System.EventHandler(this.ShowProgramToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "TimeOut:";
            // 
            // timeoutCountLbl
            // 
            this.timeoutCountLbl.AutoSize = true;
            this.timeoutCountLbl.Location = new System.Drawing.Point(71, 92);
            this.timeoutCountLbl.Name = "timeoutCountLbl";
            this.timeoutCountLbl.Size = new System.Drawing.Size(13, 13);
            this.timeoutCountLbl.TabIndex = 9;
            this.timeoutCountLbl.Text = "0";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.recheckChooseButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(157, 157);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Re-Check";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // recheckChooseButton
            // 
            this.recheckChooseButton.Location = new System.Drawing.Point(6, 6);
            this.recheckChooseButton.Name = "recheckChooseButton";
            this.recheckChooseButton.Size = new System.Drawing.Size(145, 23);
            this.recheckChooseButton.TabIndex = 0;
            this.recheckChooseButton.Text = "Choose possibly";
            this.recheckChooseButton.UseVisualStyleBackColor = true;
            this.recheckChooseButton.Click += new System.EventHandler(this.RecheckChooseButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 232);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.settingsGrp);
            this.Controls.Add(this.sourceGrp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PredatorFinder";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.sourceGrp.ResumeLayout(false);
            this.sourceGrp.PerformLayout();
            this.settingsGrp.ResumeLayout(false);
            this.settingsGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadNumeric)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.trayStatistic.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sourceGrp;
        private System.Windows.Forms.Button generateSourceButton;
        private System.Windows.Forms.GroupBox settingsGrp;
        private System.Windows.Forms.TextBox proxyTextBox;
        private System.Windows.Forms.TextBox timeoutTextBox;
        private System.Windows.Forms.Label proxyLbl;
        private System.Windows.Forms.NumericUpDown threadNumeric;
        private System.Windows.Forms.Label timeoutLbl;
        private System.Windows.Forms.Label threadsLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblSourceCount;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblBad;
        private System.Windows.Forms.Label lblGood;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblLeftCount;
        private System.Windows.Forms.Label lblBadCount;
        private System.Windows.Forms.Label lblGoodCount;
        private System.Windows.Forms.TextBox logTxtBox;
        private System.Windows.Forms.LinkLabel wtfLinkLabel;
        private System.Windows.Forms.TextBox generateToTxt;
        private System.Windows.Forms.Label toLbl;
        private System.Windows.Forms.Label fromLbl;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.NotifyIcon trayNotify;
        private System.Windows.Forms.ContextMenuStrip trayStatistic;
        private System.Windows.Forms.ToolStripMenuItem showStatisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox letterTxtBox;
        private System.Windows.Forms.Label letterLbl;
        private System.Windows.Forms.MaskedTextBox generateFromTxt;
        private System.Windows.Forms.Label timeoutCountLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button recheckChooseButton;
    }
}

