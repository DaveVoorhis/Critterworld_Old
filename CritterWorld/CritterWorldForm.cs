using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using CritterBrainBase;
using Sprites;

namespace CritterWorld
{
    public partial class CritterWorldForm : Form
    {
        static MarqueeLabel messageMarquee = null;

        World world = null;
        Campaign campaign = null;
        Point goal = new Point();
        bool autoLaunchCompetition = false;
        Timer runningUpdateTimer;

        // Add marquee message of a given color
        public static void AddMarqueeMessage(string msg, Color color)
        {
            // messageMarque is singleton (via static) so we can have this:
            messageMarquee.Add(msg, color);
        }

        // Add marquee message
        public static void AddMarqueeMessage(string msg)
        {
            // messageMarque is singleton (via static) so we can have this:
            messageMarquee.Add(msg);
        }

        // Add priority marquee message of a given color
        public static void AddPriorityMarqueeMessage(string msg, Color color)
        {
            // messageMarque is singleton (via static) so we can have this:
            messageMarquee.AddPriority(msg, color);
        }

        // Add priority marquee message
        public static void AddPriorityMarqueeMessage(string msg)
        {
            // messageMarque is singleton (via static) so we can have this:
            messageMarquee.AddPriority(msg);
        }

        public CritterWorldForm(bool launchCompetition = false)
        {
            Text = Version.VersionString;
            InitializeComponent();
            arena.CreateWorld();
            FormClosed += new FormClosedEventHandler(CritterWorldForm_FormClosed);
            messageMarquee = this.marqueeLabel1;
            autoLaunchCompetition = launchCompetition;
            runningUpdateTimer = new Timer();
            runningUpdateTimer.Interval = 1000;
            runningUpdateTimer.Tick += new EventHandler(runningUpdateTimer_Tick);
        }

        #region EventHandlers

        int runningUpdateTimerTickCount = 0;

        private void runningUpdateTimer_Tick(Object myObject, EventArgs myEventArgs)
        {
            dataGridViewRunning.Refresh();
            if (autoLaunchCompetition)
            {
                runningUpdateTimerTickCount++;
                if (runningUpdateTimerTickCount > 10)
                {
                    tabStats.SelectedIndex = (tabStats.SelectedIndex + 1) % tabStats.TabCount;
                    tabStats.SelectedTab.Refresh();
                    // no selection in finished
                    dataGridViewFinished.ClearSelection();
                    runningUpdateTimerTickCount = 0;
                }
            }
        }

        private void CritterWorldForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            arena.DestroyWorld();
        }

        private void WorldForm_Load(object sender, EventArgs e)
        {
            arena.SetBackground(Utility.GetConfiguration().WorldFileName);
            world = new World(this);
            if (autoLaunchCompetition)
            {
                StartCampaign();
            }
            runningUpdateTimer.Start();
        }

        private void newWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void stopWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void WorldForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Shutdown();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shutdown();
        }

        private void loggingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.SetLoggingState(loggingToolStripMenuItem.Checked);
        }

        private void editConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Code to open a dialog box to edit the configuration options goes here.
            // Replace the code below
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Background Image";
            openFileDialog.Filter = "PNG Files|*.png|JPEG Files|*.jpg|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                SetBackground(openFileDialog.FileName);

        }

        private void startCampaignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartCampaign();
        }

        private void stopCampaignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopCampaign();
        }

        private void nextLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CampaignNextLevel();
        }

        #endregion

        private void StartCampaign()
        {
            campaign = new CampaignDefault(this);
            campaign.Start();
        }

        private void StopCampaign()
        {
            if (campaign != null)
            {
                campaign.Stop();
                campaign = null;
            }
        }

        private void CampaignNextLevel()
        {
            if (campaign != null)
            {
                campaign.NextCompetition();
            }
        }

        public void SetBackground(string fileName)
        {
            Stop();
            arena.SetBackground(fileName);
        }

        public WorldPanel Panel
        {
            get
            {
                return arena;
            }
        }

        public void Start()
        {
            Stop();
            world.CreateMap();
            world.LoadCritters();
            if (!goal.IsEmpty)
            {
                world.SetGoal(goal);
            }
            dataGridViewDied.DataSource = world.DeadCritters;
            dataGridViewFinished.DataSource = world.FinishedCritters;
            dataGridViewWaiting.DataSource = world.WaitingCritters;
            dataGridViewRunning.DataSource = world.RunningCritters;
            dataGridViewLeaderboard.DataSource = world.Highscores;
        }

        public void Stop()
        {
            world.StopWorld();
        }

        private void Shutdown()
        {
            Stop();
            world.Shutdown();
            Application.Exit();
        }

        public void Add(Sprite sprite)
        {
            arena.Add(sprite);
        }

        public void Remove(Sprite sprite)
        {
            arena.Remove(sprite);
        }

        public void SetGoal(Point goal)
        {
            this.goal = goal;
        }

        public bool IsWorldFinished
        {
            get
            {
                return world.IsWorldFinished;
            }
        }

        public int MaximumActiveCritterCount
        {
            get
            {
                return world.MaximumActiveCritterCount;
            }
            set
            {
                world.MaximumActiveCritterCount = value;
            }
        }

        public int MaximumCritterAge
        {
            get
            {
                return world.MaximumCritterAge;
            }
            set
            {
                world.MaximumCritterAge = value;
            }
        }

        private void dataGridViewRunning_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
