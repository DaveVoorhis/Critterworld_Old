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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CritterWorldForm));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.worldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.startCompetitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopCompetitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewRunning = new System.Windows.Forms.DataGridView();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.critterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energyDisplayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeToGoalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.critterWrapperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewWaiting = new System.Windows.Forms.DataGridView();
            this.critterNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.critterCreatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewLeaderboard = new System.Windows.Forms.DataGridView();
            this.LeaderboardCritterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaderboardCreator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaderboardFinishes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaderboardAverageTimeToGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTimeToGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.marqueeLabel1 = new CritterWorld.MarqueeLabel();
            this.arena = new CritterWorld.WorldPanel();
            this.menuMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRunning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.critterWrapperBindingSource)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWaiting)).BeginInit();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaderboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arena)).BeginInit();
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
            this.menuMain.Size = new System.Drawing.Size(3336, 44);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // worldToolStripMenuItem
            // 
            this.worldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWorldToolStripMenuItem,
            this.stopWorldToolStripMenuItem,
            this.toolStripSeparator2,
            this.startCompetitionToolStripMenuItem,
            this.stopCompetitionToolStripMenuItem,
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
            // startCompetitionToolStripMenuItem
            // 
            this.startCompetitionToolStripMenuItem.Name = "startCompetitionToolStripMenuItem";
            this.startCompetitionToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.startCompetitionToolStripMenuItem.Text = "Start Competition";
            this.startCompetitionToolStripMenuItem.Click += new System.EventHandler(this.startCompetitionToolStripMenuItem_Click);
            // 
            // stopCompetitionToolStripMenuItem
            // 
            this.stopCompetitionToolStripMenuItem.Name = "stopCompetitionToolStripMenuItem";
            this.stopCompetitionToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.stopCompetitionToolStripMenuItem.Text = "Stop Competition";
            this.stopCompetitionToolStripMenuItem.Click += new System.EventHandler(this.stopCompetitionToolStripMenuItem_Click);
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
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1090, 50);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 1137);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewRunning);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(918, 1090);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Running - Double-click to Edit a Critter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRunning
            // 
            this.dataGridViewRunning.AllowUserToAddRows = false;
            this.dataGridViewRunning.AllowUserToDeleteRows = false;
            this.dataGridViewRunning.AutoGenerateColumns = false;
            this.dataGridViewRunning.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewRunning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRunning.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pictureDataGridViewImageColumn,
            this.critterNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.energyDisplayDataGridViewTextBoxColumn,
            this.timeToGoalDataGridViewTextBoxColumn});
            this.dataGridViewRunning.DataSource = this.critterWrapperBindingSource;
            this.dataGridViewRunning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRunning.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewRunning.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewRunning.MultiSelect = false;
            this.dataGridViewRunning.Name = "dataGridViewRunning";
            this.dataGridViewRunning.ReadOnly = true;
            this.dataGridViewRunning.RowHeadersVisible = false;
            this.dataGridViewRunning.RowTemplate.Height = 33;
            this.dataGridViewRunning.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewRunning.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewRunning.Size = new System.Drawing.Size(906, 1078);
            this.dataGridViewRunning.TabIndex = 15;
            this.dataGridViewRunning.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRunning_CellContentDoubleClick);
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.ReadOnly = true;
            this.pictureDataGridViewImageColumn.Width = 85;
            // 
            // critterNameDataGridViewTextBoxColumn
            // 
            this.critterNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.critterNameDataGridViewTextBoxColumn.DataPropertyName = "CritterName";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.critterNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.critterNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.critterNameDataGridViewTextBoxColumn.Name = "critterNameDataGridViewTextBoxColumn";
            this.critterNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.critterNameDataGridViewTextBoxColumn.Width = 113;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Width = 95;
            // 
            // energyDisplayDataGridViewTextBoxColumn
            // 
            this.energyDisplayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.energyDisplayDataGridViewTextBoxColumn.DataPropertyName = "EnergyDisplay";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.energyDisplayDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.energyDisplayDataGridViewTextBoxColumn.HeaderText = "Energy/Status";
            this.energyDisplayDataGridViewTextBoxColumn.Name = "energyDisplayDataGridViewTextBoxColumn";
            this.energyDisplayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeToGoalDataGridViewTextBoxColumn
            // 
            this.timeToGoalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timeToGoalDataGridViewTextBoxColumn.DataPropertyName = "TimeToGoal";
            this.timeToGoalDataGridViewTextBoxColumn.HeaderText = "Time to Goal";
            this.timeToGoalDataGridViewTextBoxColumn.Name = "timeToGoalDataGridViewTextBoxColumn";
            this.timeToGoalDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeToGoalDataGridViewTextBoxColumn.Width = 125;
            // 
            // critterWrapperBindingSource
            // 
            this.critterWrapperBindingSource.DataSource = typeof(CritterWorld.CritterWrapper);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(669, 50);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(417, 1137);
            this.tabControl2.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewWaiting);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(401, 1090);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Waiting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWaiting
            // 
            this.dataGridViewWaiting.AllowUserToAddRows = false;
            this.dataGridViewWaiting.AllowUserToDeleteRows = false;
            this.dataGridViewWaiting.AutoGenerateColumns = false;
            this.dataGridViewWaiting.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewWaiting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWaiting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.critterNameDataGridViewTextBoxColumn1,
            this.critterCreatorDataGridViewTextBoxColumn});
            this.dataGridViewWaiting.DataSource = this.critterWrapperBindingSource;
            this.dataGridViewWaiting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWaiting.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewWaiting.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewWaiting.MultiSelect = false;
            this.dataGridViewWaiting.Name = "dataGridViewWaiting";
            this.dataGridViewWaiting.ReadOnly = true;
            this.dataGridViewWaiting.RowHeadersVisible = false;
            this.dataGridViewWaiting.RowTemplate.Height = 33;
            this.dataGridViewWaiting.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewWaiting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewWaiting.Size = new System.Drawing.Size(389, 1078);
            this.dataGridViewWaiting.StandardTab = true;
            this.dataGridViewWaiting.TabIndex = 0;
            // 
            // critterNameDataGridViewTextBoxColumn1
            // 
            this.critterNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.critterNameDataGridViewTextBoxColumn1.DataPropertyName = "CritterName";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.critterNameDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.critterNameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.critterNameDataGridViewTextBoxColumn1.Name = "critterNameDataGridViewTextBoxColumn1";
            this.critterNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.critterNameDataGridViewTextBoxColumn1.Width = 113;
            // 
            // critterCreatorDataGridViewTextBoxColumn
            // 
            this.critterCreatorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.critterCreatorDataGridViewTextBoxColumn.DataPropertyName = "CritterCreator";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.critterCreatorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.critterCreatorDataGridViewTextBoxColumn.HeaderText = "Creator";
            this.critterCreatorDataGridViewTextBoxColumn.Name = "critterCreatorDataGridViewTextBoxColumn";
            this.critterCreatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.critterCreatorDataGridViewTextBoxColumn.Width = 128;
            // 
            // tabControl3
            // 
            this.tabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Location = new System.Drawing.Point(15, 50);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(650, 1137);
            this.tabControl3.TabIndex = 17;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewLeaderboard);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage3.Size = new System.Drawing.Size(634, 1090);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Leaderboard";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLeaderboard
            // 
            this.dataGridViewLeaderboard.AllowUserToAddRows = false;
            this.dataGridViewLeaderboard.AllowUserToDeleteRows = false;
            this.dataGridViewLeaderboard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeaderboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LeaderboardCritterName,
            this.LeaderboardCreator,
            this.LeaderboardFinishes,
            this.LeaderboardAverageTimeToGoal,
            this.TotalTimeToGoal});
            this.dataGridViewLeaderboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLeaderboard.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewLeaderboard.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewLeaderboard.MultiSelect = false;
            this.dataGridViewLeaderboard.Name = "dataGridViewLeaderboard";
            this.dataGridViewLeaderboard.ReadOnly = true;
            this.dataGridViewLeaderboard.RowHeadersVisible = false;
            this.dataGridViewLeaderboard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewLeaderboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewLeaderboard.Size = new System.Drawing.Size(622, 1078);
            this.dataGridViewLeaderboard.TabIndex = 1;
            // 
            // LeaderboardCritterName
            // 
            this.LeaderboardCritterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LeaderboardCritterName.DataPropertyName = "CritterName";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LeaderboardCritterName.DefaultCellStyle = dataGridViewCellStyle5;
            this.LeaderboardCritterName.HeaderText = "Name";
            this.LeaderboardCritterName.Name = "LeaderboardCritterName";
            this.LeaderboardCritterName.ReadOnly = true;
            this.LeaderboardCritterName.Width = 113;
            // 
            // LeaderboardCreator
            // 
            this.LeaderboardCreator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LeaderboardCreator.DataPropertyName = "Creator";
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LeaderboardCreator.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.textBoxLog.Location = new System.Drawing.Point(2034, 1023);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(1274, 158);
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.TabIndex = 18;
            // 
            // marqueeLabel1
            // 
            this.marqueeLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marqueeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marqueeLabel1.Location = new System.Drawing.Point(0, 1200);
            this.marqueeLabel1.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.marqueeLabel1.Name = "marqueeLabel1";
            this.marqueeLabel1.ScrollingEnabled = true;
            this.marqueeLabel1.ScrollPixelAmount = 3;
            this.marqueeLabel1.ScrollTimerInterval = 5;
            this.marqueeLabel1.Size = new System.Drawing.Size(3336, 83);
            this.marqueeLabel1.TabIndex = 3;
            // 
            // arena
            // 
            this.arena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arena.BackColor = System.Drawing.SystemColors.Window;
            this.arena.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arena.BackgroundImage")));
            this.arena.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.arena.Location = new System.Drawing.Point(2034, 90);
            this.arena.Margin = new System.Windows.Forms.Padding(4);
            this.arena.MaximumSize = new System.Drawing.Size(1276, 919);
            this.arena.MinimumSize = new System.Drawing.Size(1276, 919);
            this.arena.Name = "arena";
            this.arena.Size = new System.Drawing.Size(1276, 919);
            this.arena.TabIndex = 2;
            this.arena.TabStop = false;
            // 
            // CritterWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3336, 1281);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.tabControl3);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.marqueeLabel1);
            this.Controls.Add(this.arena);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CritterWorldForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorldForm_FormClosed);
            this.Load += new System.EventHandler(this.WorldForm_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRunning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.critterWrapperBindingSource)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWaiting)).EndInit();
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem selectBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem startCompetitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopCompetitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem nextLevelToolStripMenuItem;
        private MarqueeLabel marqueeLabel1;
        private System.Windows.Forms.BindingSource critterWrapperBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewRunning;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewLeaderboard;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.DataGridView dataGridViewWaiting;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn critterNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn energyDisplayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeToGoalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaderboardCritterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaderboardCreator;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaderboardFinishes;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaderboardAverageTimeToGoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTimeToGoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn critterNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn critterCreatorDataGridViewTextBoxColumn;
    }
}

