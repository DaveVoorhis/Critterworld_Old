using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CritterWorld
{
    class CompetitionDefault : Competition
    {
        public CompetitionDefault(CritterWorldForm critterWorld) : base(critterWorld) 
        {
            Add(new Level("BackgroundBase.png", 10, 5, new Point(595, 430)));
            Add(new Level("Background01.png", 10, 5, new Point(595, 430)));
            Add(new Level("Background02.png", 10, 5, new Point(595, 430)));
            Add(new Level("Background03.png", 10, 5, new Point(595, 100)));
            Add(new Level("Background04.png", 10, 5, new Point(595, 230)));
            Add(new Level("Background05.png", 10, 5, new Point(595, 330)));

            Add(new Level("BackgroundBase.png", 10, 5, new Point(295, 430)));
            Add(new Level("Background01.png", 10, 5, new Point(395, 430)));
            Add(new Level("Background02.png", 10, 5, new Point(595, 130)));
            Add(new Level("Background03.png", 10, 5, new Point(495, 120)));
            Add(new Level("Background04.png", 10, 5, new Point(195, 230)));
            Add(new Level("Background05.png", 10, 5, new Point(595, 130)));

            Add(new Level("Background06.png", 10, 5, new Point(255, 340)));        
        }
    }
}
