using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CritterWorld
{
    public class Campaign
    {
        CritterWorldForm critterWorld;
        List<Competition> levels = new List<Competition>();
        int currentCompetition = -1;
        Timer checkCompletionTimer;

        public Campaign(CritterWorldForm critterWorld)
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
                NextCompetition();
            }
        }

        public void NextCompetition()
        {
            currentCompetition++;
            if (currentCompetition >= levels.Count)
            {
                currentCompetition = 0;
            }
            Competition campaign = levels[currentCompetition];
            critterWorld.SetBackground(campaign.BackgroundImageFilename);
            critterWorld.SetGoal(campaign.Goal);
            critterWorld.MaximumActiveCritterCount = campaign.MaximumCrittersAtOnce;
            critterWorld.MaximumCritterAge = campaign.MaximumCritterAge;
            critterWorld.Start();
        }

        public void Start()
        {
            critterWorld.Stop();
            NextCompetition();
        }

        public void Stop()
        {
            critterWorld.Stop();
        }

        public void Add(Competition competition)
        {
            levels.Add(competition);
        }
    }
}
