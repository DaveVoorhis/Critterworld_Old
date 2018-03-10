using System;
using System.Drawing;
using CritterBrains;

namespace CritterWorld
{
    public class CritterWrapper
    {
        public const string TimeToGoalDisplayFormat = @"mm\:ss\.fff";

        string file;
        CritterBrains.CritterBrain brain;
        Critter critter;

        static Image waitingCritterImage = null;

        internal CritterWrapper(string file, CritterBrains.CritterBrain brain)
        {
            this.file = file;
            this.brain = brain;
            critter = null;
            if (waitingCritterImage == null)
            {
                waitingCritterImage = Utility.GetImageFromResource("CritterWaiting.png");
            }
        }

        internal bool IsWaiting
        {
            get
            {
                return (critter == null);
            }
        }

        internal CritterBrain Brain
        {
            get
            {
                return brain;
            }
        }

        internal String File
        {
            get
            {
                return file;
            }
        }

        public string CritterName 
        {
            get 
            { 
                return brain.Name; 
            }
        }

        public string CritterCreator
        {
            get
            {
                return brain.Creator;
            }
        }

        public int Age 
        {
            get
            {
                if (critter != null)
                {
                    return critter.Age;
                }
                return 0;
            }
        }

        public string TimeToGoal
        {
            get
            {
                if (critter != null)
                {
                    TimeSpan timeToGoal = critter.TimeToGoal;
                    if (timeToGoal > TimeSpan.MinValue)
                    {
                        return timeToGoal.ToString(TimeToGoalDisplayFormat);
                    }
                }
                return "?";
            }
        }

        public string EnergyDisplay 
        {
            get
            {
                if (critter != null)
                {
                    return critter.EnergyDisplay;
                }
                return "Waiting";
            }
        }

        public Image Picture 
        {
            get
            {
                if (critter != null)
                {
                    return critter.Picture;
                }
                return waitingCritterImage;
            }
        }

        internal Critter Critter
        {
            get
            {
                return critter;
            }
            set
            {
                critter = value;
            }
        }
    }
}
