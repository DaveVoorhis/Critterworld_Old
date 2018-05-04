﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using CritterBrains;
using Sprites;

namespace CritterWorld
{
    public partial class CritterWorldForm : Form
    {
        static MarqueeLabel messageMarquee = null;

        World world = null;
        Competition competition = null;
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
            Logger.SetLogWidget(textBoxLog);
            arena.CreateWorld();
            FormClosed += new FormClosedEventHandler(CritterWorldForm_FormClosed);
            messageMarquee = this.marqueeLabel1;
            autoLaunchCompetition = launchCompetition;
            runningUpdateTimer = new Timer();
            runningUpdateTimer.Interval = 1000;
            runningUpdateTimer.Tick += new EventHandler(runningUpdateTimer_Tick);
            nextLevelToolStripMenuItem.Enabled = false;
        }

        #region EventHandlers

        private void runningUpdateTimer_Tick(Object myObject, EventArgs myEventArgs)
        {
            dataGridViewRunning.Refresh();
            dataGridViewLeaderboard.Refresh();
            dataGridViewRunning.ClearSelection();
            dataGridViewWaiting.ClearSelection();
            dataGridViewLeaderboard.ClearSelection();
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
                StartCompetition();
            }
            runningUpdateTimer.Start();
        }

        private void newWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nextLevelToolStripMenuItem.Enabled = false;
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

        private void editConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utility.GetConfiguration().EditConfiguration();
        }

        private void startCompetitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nextLevelToolStripMenuItem.Enabled = true;
            StartCompetition();
        }

        private void stopCompetitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nextLevelToolStripMenuItem.Enabled = false;
            StopCompetition();
        }

        private void nextLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompetitionNextLevel();
        }

        #endregion

        private void StartCompetition()
        {
            competition = new CompetitionDefault(this);
            competition.Start();
        }

        private void StopCompetition()
        {
            if (competition != null)
            {
                competition.Stop();
                competition = null;
            }
        }

        private void CompetitionNextLevel()
        {
            if (competition != null)
            {
                competition.NextLevel();
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
            dataGridViewRunning.DataSource = world.CritterData;
            dataGridViewWaiting.DataSource = world.WaitingCritters;
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
            Environment.Exit(0);
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

        private void dataGridViewRunning_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewRunning.Rows[e.RowIndex];
            CritterWrapper item = (CritterWrapper)row.DataBoundItem;
            Form form = item.Brain.Form;
            if (form == null)
            {
                string msg = "Critter " + item.CritterName + " by " + item.CritterCreator + " in file " + item.File + " does not have an edit form.";
                MessageBox.Show(msg, "Edit Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                form.ShowDialog();
            }
        }
    }
}
