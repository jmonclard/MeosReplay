namespace MeOSReplay
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.xmlOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileGroupBox = new System.Windows.Forms.GroupBox();
            this.xmlTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ftrRandomNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ftrNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rttRandomNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.rttNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.commandsGroupBox = new System.Windows.Forms.GroupBox();
            this.currentTextBox = new System.Windows.Forms.TextBox();
            this.stopTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.startTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.speedFactorLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.speedFactorTrackBar = new System.Windows.Forms.TrackBar();
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.radioListGroupBox = new System.Windows.Forms.GroupBox();
            this.radioCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.senderBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.nextButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.logTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.logFullTextBox = new System.Windows.Forms.TextBox();
            this.fileGroupBox.SuspendLayout();
            this.settingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ftrRandomNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftrNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rttRandomNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rttNumericUpDown)).BeginInit();
            this.commandsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedFactorTrackBar)).BeginInit();
            this.logGroupBox.SuspendLayout();
            this.radioListGroupBox.SuspendLayout();
            this.logTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // xmlOpenFileDialog
            // 
            this.xmlOpenFileDialog.FileName = "ExempleRelais.xml";
            this.xmlOpenFileDialog.Filter = "MeOS XML file|*.xml";
            // 
            // fileGroupBox
            // 
            this.fileGroupBox.Controls.Add(this.xmlTextBox);
            this.fileGroupBox.Controls.Add(this.browseButton);
            this.fileGroupBox.Location = new System.Drawing.Point(7, 12);
            this.fileGroupBox.Name = "fileGroupBox";
            this.fileGroupBox.Size = new System.Drawing.Size(568, 79);
            this.fileGroupBox.TabIndex = 0;
            this.fileGroupBox.TabStop = false;
            this.fileGroupBox.Text = "Input file";
            // 
            // xmlTextBox
            // 
            this.xmlTextBox.Location = new System.Drawing.Point(6, 48);
            this.xmlTextBox.Name = "xmlTextBox";
            this.xmlTextBox.ReadOnly = true;
            this.xmlTextBox.Size = new System.Drawing.Size(556, 20);
            this.xmlTextBox.TabIndex = 1;
            this.xmlTextBox.Text = "Click browse to select an input file";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(6, 19);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.label6);
            this.settingsGroupBox.Controls.Add(this.ftrRandomNumericUpDown);
            this.settingsGroupBox.Controls.Add(this.label7);
            this.settingsGroupBox.Controls.Add(this.ftrNumericUpDown);
            this.settingsGroupBox.Controls.Add(this.label8);
            this.settingsGroupBox.Controls.Add(this.label5);
            this.settingsGroupBox.Controls.Add(this.rttRandomNumericUpDown);
            this.settingsGroupBox.Controls.Add(this.label4);
            this.settingsGroupBox.Controls.Add(this.rttNumericUpDown);
            this.settingsGroupBox.Controls.Add(this.label3);
            this.settingsGroupBox.Controls.Add(this.portTextBox);
            this.settingsGroupBox.Controls.Add(this.label2);
            this.settingsGroupBox.Controls.Add(this.ipTextBox);
            this.settingsGroupBox.Controls.Add(this.label1);
            this.settingsGroupBox.Location = new System.Drawing.Point(7, 97);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(362, 90);
            this.settingsGroupBox.TabIndex = 1;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "s (random)";
            // 
            // ftrRandomNumericUpDown
            // 
            this.ftrRandomNumericUpDown.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftrRandomNumericUpDown.Location = new System.Drawing.Point(200, 61);
            this.ftrRandomNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ftrRandomNumericUpDown.Name = "ftrRandomNumericUpDown";
            this.ftrRandomNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.ftrRandomNumericUpDown.TabIndex = 12;
            this.ftrRandomNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ftrRandomNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ftrRandomNumericUpDown.ValueChanged += new System.EventHandler(this.ftrrandomNumericUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "s +";
            // 
            // ftrNumericUpDown
            // 
            this.ftrNumericUpDown.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftrNumericUpDown.Location = new System.Drawing.Point(108, 61);
            this.ftrNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ftrNumericUpDown.Name = "ftrNumericUpDown";
            this.ftrNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.ftrNumericUpDown.TabIndex = 10;
            this.ftrNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ftrNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ftrNumericUpDown.ValueChanged += new System.EventHandler(this.ftrNumericUpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Finish to readout";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "s (random)";
            // 
            // rttRandomNumericUpDown
            // 
            this.rttRandomNumericUpDown.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rttRandomNumericUpDown.Location = new System.Drawing.Point(200, 37);
            this.rttRandomNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.rttRandomNumericUpDown.Name = "rttRandomNumericUpDown";
            this.rttRandomNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.rttRandomNumericUpDown.TabIndex = 7;
            this.rttRandomNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rttRandomNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rttRandomNumericUpDown.ValueChanged += new System.EventHandler(this.rttrandomNumericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "s +";
            // 
            // rttNumericUpDown
            // 
            this.rttNumericUpDown.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rttNumericUpDown.Location = new System.Drawing.Point(108, 37);
            this.rttNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.rttNumericUpDown.Name = "rttNumericUpDown";
            this.rttNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.rttNumericUpDown.TabIndex = 5;
            this.rttNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rttNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.rttNumericUpDown.ValueChanged += new System.EventHandler(this.rttNumericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Radio transmit time";
            // 
            // portTextBox
            // 
            this.portTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portTextBox.Location = new System.Drawing.Point(261, 13);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(58, 20);
            this.portTextBox.TabIndex = 3;
            this.portTextBox.Text = "10000";
            this.portTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "port";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipTextBox.Location = new System.Drawing.Point(100, 13);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(124, 20);
            this.ipTextBox.TabIndex = 1;
            this.ipTextBox.Text = "127.0.0.1";
            this.ipTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send punches to";
            // 
            // commandsGroupBox
            // 
            this.commandsGroupBox.Controls.Add(this.nextButton);
            this.commandsGroupBox.Controls.Add(this.stopButton);
            this.commandsGroupBox.Controls.Add(this.pauseButton);
            this.commandsGroupBox.Controls.Add(this.playButton);
            this.commandsGroupBox.Controls.Add(this.currentTextBox);
            this.commandsGroupBox.Controls.Add(this.stopTextBox);
            this.commandsGroupBox.Controls.Add(this.label11);
            this.commandsGroupBox.Controls.Add(this.startTextBox);
            this.commandsGroupBox.Controls.Add(this.label10);
            this.commandsGroupBox.Controls.Add(this.speedFactorLabel);
            this.commandsGroupBox.Controls.Add(this.label9);
            this.commandsGroupBox.Controls.Add(this.speedFactorTrackBar);
            this.commandsGroupBox.Location = new System.Drawing.Point(7, 193);
            this.commandsGroupBox.Name = "commandsGroupBox";
            this.commandsGroupBox.Size = new System.Drawing.Size(362, 100);
            this.commandsGroupBox.TabIndex = 2;
            this.commandsGroupBox.TabStop = false;
            this.commandsGroupBox.Text = "Commands";
            // 
            // currentTextBox
            // 
            this.currentTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTextBox.Location = new System.Drawing.Point(139, 73);
            this.currentTextBox.Name = "currentTextBox";
            this.currentTextBox.Size = new System.Drawing.Size(85, 20);
            this.currentTextBox.TabIndex = 10;
            this.currentTextBox.Text = "10:30:27";
            this.currentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stopTextBox
            // 
            this.stopTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopTextBox.Location = new System.Drawing.Point(265, 74);
            this.stopTextBox.Name = "stopTextBox";
            this.stopTextBox.Size = new System.Drawing.Size(85, 20);
            this.stopTextBox.TabIndex = 6;
            this.stopTextBox.Text = "10:30:27";
            this.stopTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(265, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Stop";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startTextBox
            // 
            this.startTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTextBox.Location = new System.Drawing.Point(8, 74);
            this.startTextBox.Name = "startTextBox";
            this.startTextBox.Size = new System.Drawing.Size(85, 20);
            this.startTextBox.TabIndex = 4;
            this.startTextBox.Text = "10:30:27";
            this.startTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(9, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Start";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedFactorLabel
            // 
            this.speedFactorLabel.AutoSize = true;
            this.speedFactorLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedFactorLabel.Location = new System.Drawing.Point(210, 18);
            this.speedFactorLabel.Name = "speedFactorLabel";
            this.speedFactorLabel.Size = new System.Drawing.Size(42, 14);
            this.speedFactorLabel.TabIndex = 2;
            this.speedFactorLabel.Text = "(* 1)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Speed factor";
            // 
            // speedFactorTrackBar
            // 
            this.speedFactorTrackBar.LargeChange = 1;
            this.speedFactorTrackBar.Location = new System.Drawing.Point(100, 10);
            this.speedFactorTrackBar.Maximum = 7;
            this.speedFactorTrackBar.Minimum = 1;
            this.speedFactorTrackBar.Name = "speedFactorTrackBar";
            this.speedFactorTrackBar.Size = new System.Drawing.Size(104, 45);
            this.speedFactorTrackBar.TabIndex = 0;
            this.speedFactorTrackBar.Value = 1;
            this.speedFactorTrackBar.Scroll += new System.EventHandler(this.speedFactorTrackBar_Scroll);
            // 
            // logGroupBox
            // 
            this.logGroupBox.Controls.Add(this.logTabControl);
            this.logGroupBox.Location = new System.Drawing.Point(7, 299);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Size = new System.Drawing.Size(362, 261);
            this.logGroupBox.TabIndex = 3;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Logs";
            // 
            // logTextBox
            // 
            this.logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTextBox.Font = new System.Drawing.Font("Consolas", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTextBox.Location = new System.Drawing.Point(3, 3);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(342, 210);
            this.logTextBox.TabIndex = 0;
            // 
            // radioListGroupBox
            // 
            this.radioListGroupBox.Controls.Add(this.radioCheckedListBox);
            this.radioListGroupBox.Location = new System.Drawing.Point(375, 97);
            this.radioListGroupBox.Name = "radioListGroupBox";
            this.radioListGroupBox.Size = new System.Drawing.Size(200, 463);
            this.radioListGroupBox.TabIndex = 4;
            this.radioListGroupBox.TabStop = false;
            this.radioListGroupBox.Text = "Radio list";
            // 
            // radioCheckedListBox
            // 
            this.radioCheckedListBox.CheckOnClick = true;
            this.radioCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioCheckedListBox.FormattingEnabled = true;
            this.radioCheckedListBox.Location = new System.Drawing.Point(3, 16);
            this.radioCheckedListBox.Name = "radioCheckedListBox";
            this.radioCheckedListBox.Size = new System.Drawing.Size(194, 444);
            this.radioCheckedListBox.TabIndex = 0;
            this.radioCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.radioCheckedListBox_ItemCheck);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 50;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // senderBackgroundWorker
            // 
            this.senderBackgroundWorker.WorkerReportsProgress = true;
            this.senderBackgroundWorker.WorkerSupportsCancellation = true;
            this.senderBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.senderBackgroundWorker_DoWork);
            this.senderBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.senderBackgroundWorker_ProgressChanged);
            // 
            // nextButton
            // 
            this.nextButton.Image = global::MeOSReplay.Properties.Resources._2rightarrow;
            this.nextButton.Location = new System.Drawing.Point(329, 9);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(30, 23);
            this.nextButton.TabIndex = 14;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Image = global::MeOSReplay.Properties.Resources.player_stop1;
            this.stopButton.Location = new System.Drawing.Point(227, 41);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(33, 28);
            this.stopButton.TabIndex = 13;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Image = global::MeOSReplay.Properties.Resources.player_pause1;
            this.pauseButton.Location = new System.Drawing.Point(164, 41);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(33, 28);
            this.pauseButton.TabIndex = 12;
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // playButton
            // 
            this.playButton.Image = global::MeOSReplay.Properties.Resources.player_play1;
            this.playButton.Location = new System.Drawing.Point(101, 41);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(33, 28);
            this.playButton.TabIndex = 11;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // logTabControl
            // 
            this.logTabControl.Controls.Add(this.tabPage1);
            this.logTabControl.Controls.Add(this.tabPage2);
            this.logTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTabControl.Location = new System.Drawing.Point(3, 16);
            this.logTabControl.Name = "logTabControl";
            this.logTabControl.SelectedIndex = 0;
            this.logTabControl.Size = new System.Drawing.Size(356, 242);
            this.logTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.logTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(348, 216);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.logFullTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(348, 216);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Full log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // logFullTextBox
            // 
            this.logFullTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logFullTextBox.Font = new System.Drawing.Font("Consolas", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logFullTextBox.Location = new System.Drawing.Point(3, 3);
            this.logFullTextBox.Multiline = true;
            this.logFullTextBox.Name = "logFullTextBox";
            this.logFullTextBox.ReadOnly = true;
            this.logFullTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logFullTextBox.Size = new System.Drawing.Size(342, 210);
            this.logFullTextBox.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 564);
            this.Controls.Add(this.radioListGroupBox);
            this.Controls.Add(this.logGroupBox);
            this.Controls.Add(this.commandsGroupBox);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.fileGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MeOS Replay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.fileGroupBox.ResumeLayout(false);
            this.fileGroupBox.PerformLayout();
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ftrRandomNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftrNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rttRandomNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rttNumericUpDown)).EndInit();
            this.commandsGroupBox.ResumeLayout(false);
            this.commandsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedFactorTrackBar)).EndInit();
            this.logGroupBox.ResumeLayout(false);
            this.radioListGroupBox.ResumeLayout(false);
            this.logTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog xmlOpenFileDialog;
        private System.Windows.Forms.GroupBox fileGroupBox;
        private System.Windows.Forms.TextBox xmlTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ftrRandomNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ftrNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown rttRandomNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown rttNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox commandsGroupBox;
        private System.Windows.Forms.GroupBox logGroupBox;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.GroupBox radioListGroupBox;
        private System.Windows.Forms.CheckedListBox radioCheckedListBox;
        private System.Windows.Forms.TextBox stopTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox startTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label speedFactorLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar speedFactorTrackBar;
        private System.Windows.Forms.TextBox currentTextBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Timer mainTimer;
        private System.ComponentModel.BackgroundWorker senderBackgroundWorker;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TabControl logTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox logFullTextBox;
    }
}

