using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CritterWorld
{
    class CampaignDefault : Campaign
    {
        public CampaignDefault(CritterWorldForm critterWorld) : base(critterWorld) 
        {
            Add(new Competition("BackgroundBase.png", 10, 5, new Point(595, 430)));
            Add(new Competition("Background01.png", 10, 5, new Point(595, 430)));
            Add(new Competition("Background02.png", 10, 5, new Point(595, 430)));
            Add(new Competition("Background03.png", 10, 5, new Point(595, 100)));
            Add(new Competition("Background04.png", 10, 5, new Point(595, 230)));
            Add(new Competition("Background05.png", 10, 5, new Point(595, 330)));

            Add(new Competition("BackgroundBase.png", 10, 5, new Point(295, 430)));
            Add(new Competition("Background01.png", 10, 5, new Point(395, 430)));
            Add(new Competition("Background02.png", 10, 5, new Point(595, 130)));
            Add(new Competition("Background03.png", 10, 5, new Point(495, 120)));
            Add(new Competition("Background04.png", 10, 5, new Point(195, 230)));
            Add(new Competition("Background05.png", 10, 5, new Point(595, 130)));

            Add(new Competition("Background06.png", 10, 5, new Point(255, 340)));        
        }
    }
}
