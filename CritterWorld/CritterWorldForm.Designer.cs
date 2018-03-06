namespace CritterWorld
{
    partial class CritterWorldForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CritterWorldForm));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.worldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.startCampaignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopCampaignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabStats = new System.Windows.Forms.TabControl();
            this.tabPageRunning = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridViewRunning = new System.Windows.Forms.DataGridView();
            this.RunningPicture = new System.Windows.Forms.DataGridViewImageColumn();
            this.RunningCritterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunningEnergyDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunningAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunningTimeToGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridViewFinished = new System.Windows.Forms.DataGridView();
            this.FinishedPicture = new System.Windows.Forms.DataGridViewImageColumn();
            this.FinishedCritterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishedTimeToGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishedAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishedEnergyDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dataGridViewDied = new System.Windows.Forms.DataGridView();
            this.DiedPicture = new System.Windows.Forms.DataGridViewImageColumn();
            this.DiedCritterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiedEnergyDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiedAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiedTimeToGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewWaiting = new System.Windows.Forms.DataGridView();
            this.WaitingPicture = new System.Windows.Forms.DataGridViewImageColumn();
            this.WaitingCritterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaitingEnergyDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaitingAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaitingTimeToGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageLeaderboard = new System.Windows.Forms.TabPage();
            this.dataGridViewLeaderboard = new System.Windows.Forms.DataGridView();
            this.LeaderboardCritterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaderboardCreator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaderboardFinishes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaderboardAverageTimeToGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTimeToGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.marqueeLabel1 = new CritterWorld.MarqueeLabel();
            this.arena = new CritterWorld.WorldPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewRunningDiedFinished = new System.Windows.Forms.DataGridView();
            this.critterWrapperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.critterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energyDisplayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeToGoalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuMain.SuspendLayout();
            this.tabStats.SuspendLayout();
            this.tabPageRunning.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRunning)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinished)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDied)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWaiting)).BeginInit();
            this.tabPageLeaderboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaderboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRunningDiedFinished)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.critterWrapperBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.worldToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuMain.Size = new System.Drawing.Size(2802, 44);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // worldToolStripMenuItem
            // 
            this.worldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWorldToolStripMenuItem,
            this.stopWorldToolStripMenuItem,
            this.toolStripSeparator2,
            this.startCampaignToolStripMenuItem,
            this.stopCampaignToolStripMenuItem,
            this.nextLevelToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.worldToolStripMenuItem.Name = "worldToolStripMenuItem";
            this.worldToolStripMenuItem.Size = new System.Drawing.Size(90, 36);
            this.worldToolStripMenuItem.Text = "World";
            // 
            // newWorldToolStripMenuItem
            // 
            this.newWorldToolStripMenuItem.Name = "newWorldToolStripMenuItem";
            this.newWorldToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.newWorldToolStripMenuItem.Text = "Start World";
            this.newWorldToolStripMenuItem.Click += new System.EventHandler(this.newWorldToolStripMenuItem_Click);
            // 
            // stopWorldToolStripMenuItem
            // 
            this.stopWorldToolStripMenuItem.Name = "stopWorldToolStripMenuItem";
            this.stopWorldToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.stopWorldToolStripMenuItem.Text = "Stop World";
            this.stopWorldToolStripMenuItem.Click += new System.EventHandler(this.stopWorldToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(274, 6);
            // 
            // startCampaignToolStripMenuItem
            // 
            this.startCampaignToolStripMenuItem.Name = "startCampaignToolStripMenuItem";
            this.startCampaignToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.startCampaignToolStripMenuItem.Text = "Start Campaign";
            this.startCampaignToolStripMenuItem.Click += new System.EventHandler(this.startCampaignToolStripMenuItem_Click);
            // 
            // stopCampaignToolStripMenuItem
            // 
            this.stopCampaignToolStripMenuItem.Name = "stopCampaignToolStripMenuItem";
            this.stopCampaignToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.stopCampaignToolStripMenuItem.Text = "Stop Campaign";
            this.stopCampaignToolStripMenuItem.Click += new System.EventHandler(this.stopCampaignToolStripMenuItem_Click);
            // 
            // nextLevelToolStripMenuItem
            // 
            this.nextLevelToolStripMenuItem.Name = "nextLevelToolStripMenuItem";
            this.nextLevelToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.nextLevelToolStripMenuItem.Text = "Next level";
            this.nextLevelToolStripMenuItem.Click += new System.EventHandler(this.nextLevelToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(274, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectBackgroundToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // selectBackgroundToolStripMenuItem
            // 
            this.selectBackgroundToolStripMenuItem.Name = "selectBackgroundToolStripMenuItem";
            this.selectBackgroundToolStripMenuItem.Size = new System.Drawing.Size(323, 38);
            this.selectBackgroundToolStripMenuItem.Text = "Edit Configuration...";
            this.selectBackgroundToolStripMenuItem.Click += new System.EventHandler(this.editConfigurationToolStripMenuItem_Click);
            // 
            // tabStats
            // 
            this.tabStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabStats.Controls.Add(this.tabPageRunning);
            this.tabStats.Controls.Add(this.tabPageLeaderboard);
            this.tabStats.Location = new System.Drawing.Point(24, 52);
            this.tabStats.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabStats.Name = "tabStats";
            this.tabStats.SelectedIndex = 0;
            this.tabStats.Size = new System.Drawing.Size(1464, 1323);
            this.tabStats.TabIndex = 4;
            // 
            // tabPageRunning
            // 
            this.tabPageRunning.Controls.Add(this.flowLayoutPanel1);
            this.tabPageRunning.Location = new System.Drawing.Point(8, 39);
            this.tabPageRunning.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageRunning.Name = "tabPageRunning";
            this.tabPageRunning.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageRunning.Size = new System.Drawing.Size(1448, 1276);
            this.tabPageRunning.TabIndex = 0;
            this.tabPageRunning.Text = "Running";
            this.tabPageRunning.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1442, 1277);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(4, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 1538);
            this.panel5.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.dataGridViewRunning);
            this.panel6.Location = new System.Drawing.Point(0, 29);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(500, 1538);
            this.panel6.TabIndex = 1;
            // 
            // dataGridViewRunning
            // 
            this.dataGridViewRunning.AllowUserToAddRows = false;
            this.dataGridViewRunning.AllowUserToDeleteRows = false;
            this.dataGridViewRunning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRunning.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RunningPicture,
            this.RunningCritterName,
            this.RunningEnergyDisplay,
            this.RunningAge,
            this.RunningTimeToGoal});
            this.dataGridViewRunning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRunning.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRunning.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridViewRunning.Name = "dataGridViewRunning";
            this.dataGridViewRunning.ReadOnly = true;
            this.dataGridViewRunning.Size = new System.Drawing.Size(500, 1538);
            this.dataGridViewRunning.TabIndex = 2;
            // 
            // RunningPicture
            // 
            this.RunningPicture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RunningPicture.DataPropertyName = "Picture";
            this.RunningPicture.HeaderText = "";
            this.RunningPicture.MinimumWidth = 18;
            this.RunningPicture.Name = "RunningPicture";
            this.RunningPicture.ReadOnly = true;
            this.RunningPicture.Width = 18;
            // 
            // RunningCritterName
            // 
            this.RunningCritterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.RunningCritterName.DataPropertyName = "CritterName";
            this.RunningCritterName.HeaderText = "Name";
            this.RunningCritterName.Name = "RunningCritterName";
            this.RunningCritterName.ReadOnly = true;
            this.RunningCritterName.Width = 5;
            // 
            // RunningEnergyDisplay
            // 
            this.RunningEnergyDisplay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RunningEnergyDisplay.DataPropertyName = "EnergyDisplay";
            this.RunningEnergyDisplay.HeaderText = "Energy";
            this.RunningEnergyDisplay.Name = "RunningEnergyDisplay";
            this.RunningEnergyDisplay.ReadOnly = true;
            // 
            // RunningAge
            // 
            this.RunningAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RunningAge.DataPropertyName = "Age";
            this.RunningAge.HeaderText = "Age";
            this.RunningAge.Name = "RunningAge";
            this.RunningAge.ReadOnly = true;
            this.RunningAge.Width = 95;
            // 
            // RunningTimeToGoal
            // 
            this.RunningTimeToGoal.DataPropertyName = "TimeToGoal";
            this.RunningTimeToGoal.HeaderText = "Time to Goal";
            this.RunningTimeToGoal.Name = "RunningTimeToGoal";
            this.RunningTimeToGoal.ReadOnly = true;
            this.RunningTimeToGoal.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Running";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(512, 4);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(500, 1538);
            this.panel7.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.dataGridViewRunningDiedFinished);
            this.panel8.Controls.Add(this.dataGridViewFinished);
            this.panel8.Location = new System.Drawing.Point(0, 29);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(500, 1508);
            this.panel8.TabIndex = 1;
            // 
            // dataGridViewFinished
            // 
            this.dataGridViewFinished.AllowUserToAddRows = false;
            this.dataGridViewFinished.AllowUserToDeleteRows = false;
            this.dataGridViewFinished.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewFinished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFinished.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FinishedPicture,
            this.FinishedCritterName,
            this.FinishedTimeToGoal,
            this.FinishedAge,
            this.FinishedEnergyDisplay});
            this.dataGridViewFinished.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFinished.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridViewFinished.Name = "dataGridViewFinished";
            this.dataGridViewFinished.ReadOnly = true;
            this.dataGridViewFinished.Size = new System.Drawing.Size(500, 1508);
            this.dataGridViewFinished.TabIndex = 2;
            // 
            // FinishedPicture
            // 
            this.FinishedPicture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FinishedPicture.DataPropertyName = "Picture";
            this.FinishedPicture.HeaderText = "";
            this.FinishedPicture.MinimumWidth = 18;
            this.FinishedPicture.Name = "FinishedPicture";
            this.FinishedPicture.ReadOnly = true;
            this.FinishedPicture.Width = 18;
            // 
            // FinishedCritterName
            // 
            this.FinishedCritterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FinishedCritterName.DataPropertyName = "CritterName";
            this.FinishedCritterName.HeaderText = "Name";
            this.FinishedCritterName.Name = "FinishedCritterName";
            this.FinishedCritterName.ReadOnly = true;
            this.FinishedCritterName.Width = 113;
            // 
            // FinishedTimeToGoal
            // 
            this.FinishedTimeToGoal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FinishedTimeToGoal.DataPropertyName = "TimeToGoal";
            this.FinishedTimeToGoal.HeaderText = "Time to Goal";
            this.FinishedTimeToGoal.Name = "FinishedTimeToGoal";
            this.FinishedTimeToGoal.ReadOnly = true;
            this.FinishedTimeToGoal.Width = 179;
            // 
            // FinishedAge
            // 
            this.FinishedAge.DataPropertyName = "Age";
            this.FinishedAge.HeaderText = "Age";
            this.FinishedAge.Name = "FinishedAge";
            this.FinishedAge.ReadOnly = true;
            this.FinishedAge.Visible = false;
            // 
            // FinishedEnergyDisplay
            // 
            this.FinishedEnergyDisplay.DataPropertyName = "EnergyDisplay";
            this.FinishedEnergyDisplay.HeaderText = "Energy";
            this.FinishedEnergyDisplay.Name = "FinishedEnergyDisplay";
            this.FinishedEnergyDisplay.ReadOnly = true;
            this.FinishedEnergyDisplay.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Finished";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(4, 1550);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 1538);
            this.panel1.TabIndex = 11;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.dataGridViewDied);
            this.panel9.Location = new System.Drawing.Point(0, 31);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(500, 1504);
            this.panel9.TabIndex = 1;
            // 
            // dataGridViewDied
            // 
            this.dataGridViewDied.AllowUserToAddRows = false;
            this.dataGridViewDied.AllowUserToDeleteRows = false;
            this.dataGridViewDied.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDied.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiedPicture,
            this.DiedCritterName,
            this.DiedEnergyDisplay,
            this.DiedAge,
            this.DiedTimeToGoal});
            this.dataGridViewDied.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDied.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDied.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridViewDied.Name = "dataGridViewDied";
            this.dataGridViewDied.ReadOnly = true;
            this.dataGridViewDied.Size = new System.Drawing.Size(500, 1504);
            this.dataGridViewDied.TabIndex = 2;
            // 
            // DiedPicture
            // 
            this.DiedPicture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DiedPicture.DataPropertyName = "Picture";
            this.DiedPicture.HeaderText = "";
            this.DiedPicture.MinimumWidth = 18;
            this.DiedPicture.Name = "DiedPicture";
            this.DiedPicture.ReadOnly = true;
            this.DiedPicture.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DiedPicture.Width = 18;
            // 
            // DiedCritterName
            // 
            this.DiedCritterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DiedCritterName.DataPropertyName = "CritterName";
            this.DiedCritterName.FillWeight = 25F;
            this.DiedCritterName.HeaderText = "Name";
            this.DiedCritterName.Name = "DiedCritterName";
            this.DiedCritterName.ReadOnly = true;
            this.DiedCritterName.Width = 113;
            // 
            // DiedEnergyDisplay
            // 
            this.DiedEnergyDisplay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DiedEnergyDisplay.DataPropertyName = "EnergyDisplay";
            this.DiedEnergyDisplay.FillWeight = 75F;
            this.DiedEnergyDisplay.HeaderText = "Reason";
            this.DiedEnergyDisplay.Name = "DiedEnergyDisplay";
            this.DiedEnergyDisplay.ReadOnly = true;
            this.DiedEnergyDisplay.Width = 131;
            // 
            // DiedAge
            // 
            this.DiedAge.DataPropertyName = "Age";
            this.DiedAge.HeaderText = "Age";
            this.DiedAge.Name = "DiedAge";
            this.DiedAge.ReadOnly = true;
            this.DiedAge.Visible = false;
            // 
            // DiedTimeToGoal
            // 
            this.DiedTimeToGoal.DataPropertyName = "TimeToGoal";
            this.DiedTimeToGoal.HeaderText = "Time to Goal";
            this.DiedTimeToGoal.Name = "DiedTimeToGoal";
            this.DiedTimeToGoal.ReadOnly = true;
            this.DiedTimeToGoal.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Died";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(512, 1550);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 1538);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dataGridViewWaiting);
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(498, 1506);
            this.panel3.TabIndex = 1;
            // 
            // dataGridViewWaiting
            // 
            this.dataGridViewWaiting.AllowUserToAddRows = false;
            this.dataGridViewWaiting.AllowUserToDeleteRows = false;
            this.dataGridViewWaiting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWaiting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WaitingPicture,
            this.WaitingCritterName,
            this.WaitingEnergyDisplay,
            this.WaitingAge,
            this.WaitingTimeToGoal});
            this.dataGridViewWaiting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWaiting.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewWaiting.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridViewWaiting.Name = "dataGridViewWaiting";
            this.dataGridViewWaiting.ReadOnly = true;
            this.dataGridViewWaiting.Size = new System.Drawing.Size(498, 1506);
            this.dataGridViewWaiting.TabIndex = 2;
            // 
            // WaitingPicture
            // 
            this.WaitingPicture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.WaitingPicture.DataPropertyName = "Picture";
            this.WaitingPicture.HeaderText = "";
            this.WaitingPicture.MinimumWidth = 18;
            this.WaitingPicture.Name = "WaitingPicture";
            this.WaitingPicture.ReadOnly = true;
            this.WaitingPicture.Width = 18;
            // 
            // WaitingCritterName
            // 
            this.WaitingCritterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WaitingCritterName.DataPropertyName = "CritterName";
            this.WaitingCritterName.HeaderText = "Name";
            this.WaitingCritterName.Name = "WaitingCritterName";
            this.WaitingCritterName.ReadOnly = true;
            // 
            // WaitingEnergyDisplay
            // 
            this.WaitingEnergyDisplay.DataPropertyName = "EnergyDisplay";
            this.WaitingEnergyDisplay.HeaderText = "Energy";
            this.WaitingEnergyDisplay.Name = "WaitingEnergyDisplay";
            this.WaitingEnergyDisplay.ReadOnly = true;
            this.WaitingEnergyDisplay.Visible = false;
            // 
            // WaitingAge
            // 
            this.WaitingAge.DataPropertyName = "Age";
            this.WaitingAge.HeaderText = "Age";
            this.WaitingAge.Name = "WaitingAge";
            this.WaitingAge.ReadOnly = true;
            this.WaitingAge.Visible = false;
            // 
            // WaitingTimeToGoal
            // 
            this.WaitingTimeToGoal.DataPropertyName = "TimeToGoal";
            this.WaitingTimeToGoal.HeaderText = "Time to Goal";
            this.WaitingTimeToGoal.Name = "WaitingTimeToGoal";
            this.WaitingTimeToGoal.ReadOnly = true;
            this.WaitingTimeToGoal.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-4, -2);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Waiting";
            // 
            // tabPageLeaderboard
            // 
            this.tabPageLeaderboard.Controls.Add(this.dataGridViewLeaderboard);
            this.tabPageLeaderboard.Location = new System.Drawing.Point(8, 39);
            this.tabPageLeaderboard.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageLeaderboard.Name = "tabPageLeaderboard";
            this.tabPageLeaderboard.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageLeaderboard.Size = new System.Drawing.Size(1448, 1276);
            this.tabPageLeaderboard.TabIndex = 2;
            this.tabPageLeaderboard.Text = "Leaderboard";
            this.tabPageLeaderboard.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLeaderboard
            // 
            this.dataGridViewLeaderboard.AllowUserToAddRows = false;
            this.dataGridViewLeaderboard.AllowUserToDeleteRows = false;
            this.dataGridViewLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeaderboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LeaderboardCritterName,
            this.LeaderboardCreator,
            this.LeaderboardFinishes,
            this.LeaderboardAverageTimeToGoal,
            this.TotalTimeToGoal});
            this.dataGridViewLeaderboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLeaderboard.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewLeaderboard.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridViewLeaderboard.Name = "dataGridViewLeaderboard";
            this.dataGridViewLeaderboard.ReadOnly = true;
            this.dataGridViewLeaderboard.Size = new System.Drawing.Size(1436, 1264);
            this.dataGridViewLeaderboard.TabIndex = 0;
            // 
            // LeaderboardCritterName
            // 
            this.LeaderboardCritterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LeaderboardCritterName.DataPropertyName = "CritterName";
            this.LeaderboardCritterName.HeaderText = "Name";
            this.LeaderboardCritterName.Name = "LeaderboardCritterName";
            this.LeaderboardCritterName.ReadOnly = true;
            this.LeaderboardCritterName.Width = 113;
            // 
            // LeaderboardCreator
            // 
            this.LeaderboardCreator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LeaderboardCreator.DataPropertyName = "Creator";
            this.LeaderboardCreator.HeaderText = "Creator";
            this.LeaderboardCreator.Name = "LeaderboardCreator";
            this.LeaderboardCreator.ReadOnly = true;
            this.LeaderboardCreator.Width = 128;
            // 
            // LeaderboardFinishes
            // 
            this.LeaderboardFinishes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LeaderboardFinishes.DataPropertyName = "Finishes";
            this.LeaderboardFinishes.HeaderText = "Finishes";
            this.LeaderboardFinishes.Name = "LeaderboardFinishes";
            this.LeaderboardFinishes.ReadOnly = true;
            this.LeaderboardFinishes.Width = 138;
            // 
            // LeaderboardAverageTimeToGoal
            // 
            this.LeaderboardAverageTimeToGoal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LeaderboardAverageTimeToGoal.DataPropertyName = "AverageTimeToGoalDisplay";
            this.LeaderboardAverageTimeToGoal.HeaderText = "Average Time to Goal (Rank)";
            this.LeaderboardAverageTimeToGoal.Name = "LeaderboardAverageTimeToGoal";
            this.LeaderboardAverageTimeToGoal.ReadOnly = true;
            this.LeaderboardAverageTimeToGoal.Width = 202;
            // 
            // TotalTimeToGoal
            // 
            this.TotalTimeToGoal.DataPropertyName = "TotalTimeToGoal";
            this.TotalTimeToGoal.HeaderText = "TotalTimeToGoal";
            this.TotalTimeToGoal.Name = "TotalTimeToGoal";
            this.TotalTimeToGoal.ReadOnly = true;
            this.TotalTimeToGoal.Visible = false;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLog.Location = new System.Drawing.Point(1504, 1025);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(1272, 339);
            this.textBoxLog.TabIndex = 5;
            // 
            // marqueeLabel1
            // 
            this.marqueeLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marqueeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marqueeLabel1.Location = new System.Drawing.Point(0, 1388);
            this.marqueeLabel1.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.marqueeLabel1.Name = "marqueeLabel1";
            this.marqueeLabel1.ScrollingEnabled = true;
            this.marqueeLabel1.ScrollPixelAmount = 3;
            this.marqueeLabel1.ScrollTimerInterval = 5;
            this.marqueeLabel1.Size = new System.Drawing.Size(2802, 79);
            this.marqueeLabel1.TabIndex = 3;
            // 
            // arena
            // 
            this.arena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arena.BackColor = System.Drawing.SystemColors.Window;
            this.arena.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arena.BackgroundImage")));
            this.arena.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.arena.Location = new System.Drawing.Point(1500, 94);
            this.arena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.arena.MaximumSize = new System.Drawing.Size(1276, 919);
            this.arena.MinimumSize = new System.Drawing.Size(1276, 919);
            this.arena.Name = "arena";
            this.arena.Size = new System.Drawing.Size(1276, 919);
            this.arena.TabIndex = 2;
            this.arena.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1019, 1549);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(1080, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(830, 100);
            this.panel4.TabIndex = 11;
            // 
            // dataGridViewRunningDiedFinished
            // 
            this.dataGridViewRunningDiedFinished.AllowUserToAddRows = false;
            this.dataGridViewRunningDiedFinished.AllowUserToDeleteRows = false;
            this.dataGridViewRunningDiedFinished.AutoGenerateColumns = false;
            this.dataGridViewRunningDiedFinished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRunningDiedFinished.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pictureDataGridViewImageColumn,
            this.critterNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.energyDisplayDataGridViewTextBoxColumn,
            this.timeToGoalDataGridViewTextBoxColumn,
            this.Status});
            this.dataGridViewRunningDiedFinished.DataSource = this.critterWrapperBindingSource;
            this.dataGridViewRunningDiedFinished.Location = new System.Drawing.Point(47, 50);
            this.dataGridViewRunningDiedFinished.Name = "dataGridViewRunningDiedFinished";
            this.dataGridViewRunningDiedFinished.ReadOnly = true;
            this.dataGridViewRunningDiedFinished.RowTemplate.Height = 33;
            this.dataGridViewRunningDiedFinished.Size = new System.Drawing.Size(824, 643);
            this.dataGridViewRunningDiedFinished.TabIndex = 0;
            // 
            // critterWrapperBindingSource
            // 
            this.critterWrapperBindingSource.DataSource = typeof(CritterWorld.CritterWrapper);
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.ReadOnly = true;
            // 
            // critterNameDataGridViewTextBoxColumn
            // 
            this.critterNameDataGridViewTextBoxColumn.DataPropertyName = "CritterName";
            this.critterNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.critterNameDataGridViewTextBoxColumn.Name = "critterNameDataGridViewTextBoxColumn";
            this.critterNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // energyDisplayDataGridViewTextBoxColumn
            // 
            this.energyDisplayDataGridViewTextBoxColumn.DataPropertyName = "EnergyDisplay";
            this.energyDisplayDataGridViewTextBoxColumn.HeaderText = "Energy";
            this.energyDisplayDataGridViewTextBoxColumn.Name = "energyDisplayDataGridViewTextBoxColumn";
            this.energyDisplayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeToGoalDataGridViewTextBoxColumn
            // 
            this.timeToGoalDataGridViewTextBoxColumn.DataPropertyName = "TimeToGoal";
            this.timeToGoalDataGridViewTextBoxColumn.HeaderText = "Time to Goal";
            this.timeToGoalDataGridViewTextBoxColumn.Name = "timeToGoalDataGridViewTextBoxColumn";
            this.timeToGoalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // CritterWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2802, 1463);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.tabStats);
            this.Controls.Add(this.marqueeLabel1);
            this.Controls.Add(this.arena);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CritterWorldForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorldForm_FormClosed);
            this.Load += new System.EventHandler(this.WorldForm_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.tabStats.ResumeLayout(false);
            this.tabPageRunning.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRunning)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinished)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDied)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWaiting)).EndInit();
            this.tabPageLeaderboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaderboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRunningDiedFinished)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.critterWrapperBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem worldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private WorldPanel arena;
        private System.Windows.Forms.ToolStripMenuItem newWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem startCampaignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopCampaignToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem nextLevelToolStripMenuItem;
        private MarqueeLabel marqueeLabel1;
        private System.Windows.Forms.TabControl tabStats;
        private System.Windows.Forms.TabPage tabPageRunning;
        private System.Windows.Forms.TabPage tabPageLeaderboard;
        private System.Windows.Forms.DataGridView dataGridViewLeaderboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaderboardCritterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaderboardCreator;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaderboardFinishes;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaderboardAverageTimeToGoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTimeToGoal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridViewRunning;
        private System.Windows.Forms.DataGridViewImageColumn RunningPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunningCritterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunningEnergyDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunningAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunningTimeToGoal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dataGridViewFinished;
        private System.Windows.Forms.DataGridViewImageColumn FinishedPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishedCritterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishedTimeToGoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishedAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishedEnergyDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dataGridViewDied;
        private System.Windows.Forms.DataGridViewImageColumn DiedPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiedCritterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiedEnergyDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiedAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiedTimeToGoal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewWaiting;
        private System.Windows.Forms.DataGridViewImageColumn WaitingPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaitingCritterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaitingEnergyDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaitingAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaitingTimeToGoal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.DataGridView dataGridViewRunningDiedFinished;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn critterNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn energyDisplayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeToGoalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.BindingSource critterWrapperBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
    }
}

