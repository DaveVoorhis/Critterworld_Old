using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CritterWorld
{
    public class Level
    {
        public Level(string backgroundImageFilename, int maximumCrittersAtOnce, int maximumCritterAge, Point goal)
        {
            BackgroundImageFilename = backgroundImageFilename;
            MaximumCrittersAtOnce = maximumCrittersAtOnce;
            MaximumCritterAge = maximumCritterAge;
            Goal = goal;
        }

        public string BackgroundImageFilename 
        { 
            set; get; 
        }

        public int MaximumCrittersAtOnce
        {
            set; get;
        }

        public int MaximumCritterAge 
        { 
            set; get; 
        }

        public Point Goal 
        { 
            set; get; 
        }
    }
}
