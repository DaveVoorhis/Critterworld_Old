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
            this.loggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabStats = new System.Windows.Forms.TabControl();
            this.tabPageRunning = new System.Windows.Forms.TabPage();
            this.dataGridViewRunning = new System.Windows.Forms.DataGridView();
            this.RunningPicture = new System.Windows.Forms.DataGridViewImageColumn();
            this.RunningCritterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunningEnergyDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunningAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunningTimeToGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageFinished = new System.Windows.Forms.TabPage();
            this.dataGridViewFinished = new System.Windows.Forms.DataGridView();
            this.FinishedPicture = new System.Windows.Forms.DataGridViewImageColumn();
            this.FinishedCritterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishedTimeToGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishedAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishedEnergyDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageDied = new System.Windows.Forms.TabPage();
            this.dataGridViewDied = new System.Windows.Forms.DataGridView();
            this.DiedPicture = new System.Windows.Forms.DataGridViewImageColumn();
            this.DiedCritterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiedEnergyDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiedAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiedTimeToGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageWaiting = new System.Windows.Forms.TabPage();
            this.dataGridViewWaiting = new System.Windows.Forms.DataGridView();
            this.WaitingPicture = new System.Windows.Forms.DataGridViewImageColumn();
            this.WaitingCritterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaitingEnergyDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaitingAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaitingTimeToGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageLeaderboard = new System.Windows.Forms.TabPage();
            this.dataGridViewLeaderboard = new System.Windows.Forms.DataGridView();
            this.marqueeLabel1 = new CritterWorld.MarqueeLabel();
            this.arena = new CritterWorld.WorldPanel();
            this.LeaderboardCritterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaderboardCreator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaderboardFinishes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaderboardAverageTimeToGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTimeToGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuMain.SuspendLayout();
            this.tabStats.SuspendLayout();
            this.tabPageRunning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRunning)).BeginInit();
            this.tabPageFinished.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinished)).BeginInit();
            this.tabPageDied.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDied)).BeginInit();
            this.tabPageWaiting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWaiting)).BeginInit();
            this.tabPageLeaderboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaderboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arena)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.worldToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuMain.Size = new System.Drawing.Size(1140, 24);
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
            this.worldToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.worldToolStripMenuItem.Text = "World";
            // 
            // newWorldToolStripMenuItem
            // 
            this.newWorldToolStripMenuItem.Name = "newWorldToolStripMenuItem";
            this.newWorldToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newWorldToolStripMenuItem.Text = "Start World";
            this.newWorldToolStripMenuItem.Click += new System.EventHandler(this.newWorldToolStripMenuItem_Click);
            // 
            // stopWorldToolStripMenuItem
            // 
            this.stopWorldToolStripMenuItem.Name = "stopWorldToolStripMenuItem";
            this.stopWorldToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.stopWorldToolStripMenuItem.Text = "Stop World";
            this.stopWorldToolStripMenuItem.Click += new System.EventHandler(this.stopWorldToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(135, 6);
            // 
            // startCampaignToolStripMenuItem
            // 
            this.startCampaignToolStripMenuItem.Name = "startCampaignToolStripMenuItem";
            this.startCampaignToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.startCampaignToolStripMenuItem.Text = "Start Campaign";
            this.startCampaignToolStripMenuItem.Click += new System.EventHandler(this.startCampaignToolStripMenuItem_Click);
            // 
            // stopCampaignToolStripMenuItem
            // 
            this.stopCampaignToolStripMenuItem.Name = "stopCampaignToolStripMenuItem";
            this.stopCampaignToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.stopCampaignToolStripMenuItem.Text = "Stop Campaign";
            this.stopCampaignToolStripMenuItem.Click += new System.EventHandler(this.stopCampaignToolStripMenuItem_Click);
            // 
            // nextLevelToolStripMenuItem
            // 
            this.nextLevelToolStripMenuItem.Name = "nextLevelToolStripMenuItem";
            this.nextLevelToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.nextLevelToolStripMenuItem.Text = "Next level";
            this.nextLevelToolStripMenuItem.Click += new System.EventHandler(this.nextLevelToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loggingToolStripMenuItem,
            this.selectBackgroundToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // loggingToolStripMenuItem
            // 
            this.loggingToolStripMenuItem.CheckOnClick = true;
            this.loggingToolStripMenuItem.Name = "loggingToolStripMenuItem";
            this.loggingToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.loggingToolStripMenuItem.Text = "Display Log Window";
            this.loggingToolStripMenuItem.Click += new System.EventHandler(this.loggingToolStripMenuItem_Click);
            // 
            // selectBackgroundToolStripMenuItem
            // 
            this.selectBackgroundToolStripMenuItem.Name = "selectBackgroundToolStripMenuItem";
            this.selectBackgroundToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.selectBackgroundToolStripMenuItem.Text = "Edit Configuration...";
            this.selectBackgroundToolStripMenuItem.Click += new System.EventHandler(this.editConfigurationToolStripMenuItem_Click);
            // 
            // tabStats
            // 
            this.tabStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabStats.Controls.Add(this.tabPageRunning);
            this.tabStats.Controls.Add(this.tabPageFinished);
            this.tabStats.Controls.Add(this.tabPageDied);
            this.tabStats.Controls.Add(this.tabPageWaiting);
            this.tabStats.Controls.Add(this.tabPageLeaderboard);
            this.tabStats.Location = new System.Drawing.Point(13, 35);
            this.tabStats.Name = "tabStats";
            this.tabStats.SelectedIndex = 0;
            this.tabStats.Size = new System.Drawing.Size(457, 500);
            this.tabStats.TabIndex = 4;
            // 
            // tabPageRunning
            // 
            this.tabPageRunning.Controls.Add(this.dataGridViewRunning);
            this.tabPageRunning.Location = new System.Drawing.Point(4, 22);
            this.tabPageRunning.Name = "tabPageRunning";
            this.tabPageRunning.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRunning.Size = new System.Drawing.Size(449, 474);
            this.tabPageRunning.TabIndex = 0;
            this.tabPageRunning.Text = "Running";
            this.tabPageRunning.UseVisualStyleBackColor = true;
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
            this.dataGridViewRunning.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewRunning.Name = "dataGridViewRunning";
            this.dataGridViewRunning.ReadOnly = true;
            this.dataGridViewRunning.Size = new System.Drawing.Size(443, 468);
            this.dataGridViewRunning.TabIndex = 0;
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
            this.RunningAge.Width = 51;
            // 
            // RunningTimeToGoal
            // 
            this.RunningTimeToGoal.DataPropertyName = "TimeToGoal";
            this.RunningTimeToGoal.HeaderText = "Time to Goal";
            this.RunningTimeToGoal.Name = "RunningTimeToGoal";
            this.RunningTimeToGoal.ReadOnly = true;
            this.RunningTimeToGoal.Visible = false;
            // 
            // tabPageFinished
            // 
            this.tabPageFinished.Controls.Add(this.dataGridViewFinished);
            this.tabPageFinished.Location = new System.Drawing.Point(4, 22);
            this.tabPageFinished.Name = "tabPageFinished";
            this.tabPageFinished.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFinished.Size = new System.Drawing.Size(449, 474);
            this.tabPageFinished.TabIndex = 4;
            this.tabPageFinished.Text = "Finished";
            this.tabPageFinished.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFinished
            // 
            this.dataGridViewFinished.AllowUserToAddRows = false;
            this.dataGridViewFinished.AllowUserToDeleteRows = false;
            this.dataGridViewFinished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFinished.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FinishedPicture,
            this.FinishedCritterName,
            this.FinishedTimeToGoal,
            this.FinishedAge,
            this.FinishedEnergyDisplay});
            this.dataGridViewFinished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFinished.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewFinished.Name = "dataGridViewFinished";
            this.dataGridViewFinished.ReadOnly = true;
            this.dataGridViewFinished.Size = new System.Drawing.Size(443, 468);
            this.dataGridViewFinished.TabIndex = 0;
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
            this.FinishedCritterName.Width = 60;
            // 
            // FinishedTimeToGoal
            // 
            this.FinishedTimeToGoal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FinishedTimeToGoal.DataPropertyName = "TimeToGoal";
            this.FinishedTimeToGoal.HeaderText = "Time to Goal";
            this.FinishedTimeToGoal.Name = "FinishedTimeToGoal";
            this.FinishedTimeToGoal.ReadOnly = true;
            this.FinishedTimeToGoal.Width = 92;
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
            // tabPageDied
            // 
            this.tabPageDied.Controls.Add(this.dataGridViewDied);
            this.tabPageDied.Location = new System.Drawing.Point(4, 22);
            this.tabPageDied.Name = "tabPageDied";
            this.tabPageDied.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDied.Size = new System.Drawing.Size(449, 474);
            this.tabPageDied.TabIndex = 1;
            this.tabPageDied.Text = "Died";
            this.tabPageDied.UseVisualStyleBackColor = true;
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
            this.dataGridViewDied.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDied.Name = "dataGridViewDied";
            this.dataGridViewDied.ReadOnly = true;
            this.dataGridViewDied.Size = new System.Drawing.Size(443, 468);
            this.dataGridViewDied.TabIndex = 0;
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
            this.DiedCritterName.Width = 60;
            // 
            // DiedEnergyDisplay
            // 
            this.DiedEnergyDisplay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DiedEnergyDisplay.DataPropertyName = "EnergyDisplay";
            this.DiedEnergyDisplay.FillWeight = 75F;
            this.DiedEnergyDisplay.HeaderText = "Reason";
            this.DiedEnergyDisplay.Name = "DiedEnergyDisplay";
            this.DiedEnergyDisplay.ReadOnly = true;
            this.DiedEnergyDisplay.Width = 69;
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
            // tabPageWaiting
            // 
            this.tabPageWaiting.Controls.Add(this.dataGridViewWaiting);
            this.tabPageWaiting.Location = new System.Drawing.Point(4, 22);
            this.tabPageWaiting.Name = "tabPageWaiting";
            this.tabPageWaiting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWaiting.Size = new System.Drawing.Size(449, 474);
            this.tabPageWaiting.TabIndex = 3;
            this.tabPageWaiting.Text = "Waiting";
            this.tabPageWaiting.UseVisualStyleBackColor = true;
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
            this.dataGridViewWaiting.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewWaiting.Name = "dataGridViewWaiting";
            this.dataGridViewWaiting.ReadOnly = true;
            this.dataGridViewWaiting.Size = new System.Drawing.Size(443, 468);
            this.dataGridViewWaiting.TabIndex = 0;
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
            // tabPageLeaderboard
            // 
            this.tabPageLeaderboard.Controls.Add(this.dataGridViewLeaderboard);
            this.tabPageLeaderboard.Location = new System.Drawing.Point(4, 22);
            this.tabPageLeaderboard.Name = "tabPageLeaderboard";
            this.tabPageLeaderboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLeaderboard.Size = new System.Drawing.Size(449, 474);
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
            this.dataGridViewLeaderboard.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewLeaderboard.Name = "dataGridViewLeaderboard";
            this.dataGridViewLeaderboard.ReadOnly = true;
            this.dataGridViewLeaderboard.Size = new System.Drawing.Size(443, 468);
            this.dataGridViewLeaderboard.TabIndex = 0;
            // 
            // marqueeLabel1
            // 
            this.marqueeLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.marqueeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marqueeLabel1.Location = new System.Drawing.Point(0, 543);
            this.marqueeLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.marqueeLabel1.Name = "marqueeLabel1";
            this.marqueeLabel1.ScrollingEnabled = true;
            this.marqueeLabel1.ScrollPixelAmount = 3;
            this.marqueeLabel1.ScrollTimerInterval = 5;
            this.marqueeLabel1.Size = new System.Drawing.Size(1140, 41);
            this.marqueeLabel1.TabIndex = 3;
            // 
            // arena
            // 
            this.arena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.arena.BackColor = System.Drawing.SystemColors.Window;
            this.arena.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arena.BackgroundImage")));
            this.arena.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.arena.Location = new System.Drawing.Point(480, 55);
            this.arena.Margin = new System.Windows.Forms.Padding(2);
            this.arena.MaximumSize = new System.Drawing.Size(640, 480);
            this.arena.MinimumSize = new System.Drawing.Size(640, 480);
            this.arena.Name = "arena";
            this.arena.Size = new System.Drawing.Size(640, 480);
            this.arena.TabIndex = 2;
            this.arena.TabStop = false;
            // 
            // LeaderboardCritterName
            // 
            this.LeaderboardCritterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LeaderboardCritterName.DataPropertyName = "CritterName";
            this.LeaderboardCritterName.HeaderText = "Name";
            this.LeaderboardCritterName.Name = "LeaderboardCritterName";
            this.LeaderboardCritterName.ReadOnly = true;
            this.LeaderboardCritterName.Width = 60;
            // 
            // LeaderboardCreator
            // 
            this.LeaderboardCreator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LeaderboardCreator.DataPropertyName = "Creator";
            this.LeaderboardCreator.HeaderText = "Creator";
            this.LeaderboardCreator.Name = "LeaderboardCreator";
            this.LeaderboardCreator.ReadOnly = true;
            this.LeaderboardCreator.Width = 66;
            // 
            // LeaderboardFinishes
            // 
            this.LeaderboardFinishes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LeaderboardFinishes.DataPropertyName = "Finishes";
            this.LeaderboardFinishes.HeaderText = "Finishes";
            this.LeaderboardFinishes.Name = "LeaderboardFinishes";
            this.LeaderboardFinishes.ReadOnly = true;
            this.LeaderboardFinishes.Width = 70;
            // 
            // LeaderboardAverageTimeToGoal
            // 
            this.LeaderboardAverageTimeToGoal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LeaderboardAverageTimeToGoal.DataPropertyName = "AverageTimeToGoalDisplay";
            this.LeaderboardAverageTimeToGoal.HeaderText = "Average Time to Goal (Rank)";
            this.LeaderboardAverageTimeToGoal.Name = "LeaderboardAverageTimeToGoal";
            this.LeaderboardAverageTimeToGoal.ReadOnly = true;
            this.LeaderboardAverageTimeToGoal.Width = 104;
            // 
            // TotalTimeToGoal
            // 
            this.TotalTimeToGoal.DataPropertyName = "TotalTimeToGoal";
            this.TotalTimeToGoal.HeaderText = "TotalTimeToGoal";
            this.TotalTimeToGoal.Name = "TotalTimeToGoal";
            this.TotalTimeToGoal.ReadOnly = true;
            this.TotalTimeToGoal.Visible = false;
            // 
            // CritterWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 579);
            this.Controls.Add(this.tabStats);
            this.Controls.Add(this.marqueeLabel1);
            this.Controls.Add(this.arena);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CritterWorldForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorldForm_FormClosed);
            this.Load += new System.EventHandler(this.WorldForm_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.tabStats.ResumeLayout(false);
            this.tabPageRunning.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRunning)).EndInit();
            this.tabPageFinished.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinished)).EndInit();
            this.tabPageDied.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDied)).EndInit();
            this.tabPageWaiting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWaiting)).EndInit();
            this.tabPageLeaderboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaderboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arena)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem loggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem startCampaignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopCampaignToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem nextLevelToolStripMenuItem;
        private MarqueeLabel marqueeLabel1;
        private System.Windows.Forms.TabControl tabStats;
        private System.Windows.Forms.TabPage tabPageRunning;
        private System.Windows.Forms.TabPage tabPageDied;
        private System.Windows.Forms.TabPage tabPageLeaderboard;
        private System.Windows.Forms.TabPage tabPageWaiting;
        private System.Windows.Forms.DataGridView dataGridViewWaiting;
        private System.Windows.Forms.DataGridView dataGridViewDied;
        private System.Windows.Forms.DataGridView dataGridViewLeaderboard;
        private System.Windows.Forms.DataGridView dataGridViewRunning;
        private System.Windows.Forms.TabPage tabPageFinished;
        private System.Windows.Forms.DataGridView dataGridViewFinished;
        private System.Windows.Forms.DataGridViewImageColumn RunningPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunningCritterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunningEnergyDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunningAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunningTimeToGoal;
        private System.Windows.Forms.DataGridViewImageColumn FinishedPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishedCritterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishedTimeToGoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishedAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishedEnergyDisplay;
        private System.Windows.Forms.DataGridViewImageColumn DiedPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiedCritterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiedEnergyDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiedAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiedTimeToGoal;
        private System.Windows.Forms.DataGridViewImageColumn WaitingPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaitingCritterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaitingEnergyDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaitingAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaitingTimeToGoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaderboardCritterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaderboardCreator;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaderboardFinishes;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaderboardAverageTimeToGoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTimeToGoal;
    }
}

