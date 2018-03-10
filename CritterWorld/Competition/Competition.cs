using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CritterWorld
{
    public class Competition
    {
        CritterWorldForm critterWorld;
        List<Level> levels = new List<Level>();
        int currentLevel = -1;
        Timer checkCompletionTimer;

        public Competition(CritterWorldForm critterWorld)
        {
            this.critterWorld = critterWorld;
            checkCompletionTimer = new Timer();
            checkCompletionTimer.Interval = 1000;
            checkCompletionTimer.Tick += new EventHandler(checkCompletionTimer_Tick);
            checkCompletionTimer.Start();
        }

        private void checkCompletionTimer_Tick(Object myObject, EventArgs myEventArgs)
        {
            if (critterWorld.IsWorldFinished)
            {
                NextLevel();
            }
        }

        public void NextLevel()
        {
            currentLevel++;
            if (currentLevel >= levels.Count)
            {
                currentLevel = 0;
            }
            Level level = levels[currentLevel];
            critterWorld.SetBackground(level.BackgroundImageFilename);
            critterWorld.SetGoal(level.Goal);
            critterWorld.MaximumActiveCritterCount = level.MaximumCrittersAtOnce;
            critterWorld.MaximumCritterAge = level.MaximumCritterAge;
            critterWorld.Start();
        }

        public void Start()
        {
            critterWorld.Stop();
            NextLevel();
        }

        public void Stop()
        {
            critterWorld.Stop();
        }

        public void Add(Level competition)
        {
            levels.Add(competition);
        }
    }
}
