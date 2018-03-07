using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CritterBrainBase;

namespace DemoCritter
{
    public class DemoCritterBrain4 : CritterBrainCore
    {
        static Image[] _images = new Image[4];
        Random random = new Random();

        public static DemoCritterBrain4 CreateCritterBrain4()
        {
            _images[0] = GetImageFromResource("demo4_1.png");
            _images[1] = GetImageFromResource("demo4_1.png");
            _images[2] = GetImageFromResource("demo4_2.png");
            _images[3] = GetImageFromResource("demo4_2.png");
            return new DemoCritterBrain4(_images);
        }

        public DemoCritterBrain4(Image[] images) : base("Wimp", "Wayne Rippin", images)
        {
        }

        public override void Birth()
        {
            Critter.Direction = random.Next(0, 360);
            Critter.Move(5);
        }

        public override void NotifyBlockedByTerrain()
        {
            if (random.Next(0, 4) == 0)
            {
                Critter.Direction = Critter.Direction - 90;
            }
            else
            {
                Critter.Direction = Critter.Direction + 20;
            }
            Critter.Move(1);
        }

        public override void NotifyBumpedCritter(OtherCritter other)
        {
            Critter.Direction = Critter.Direction + 180;
            Critter.Move(2);
        }

        public override void NotifyEaten()
        {
            Critter.Move(1);
        }

        public override void NotifyCloseToFood(int x, int y)
        {
            if (!Critter.IsTerrainBlockingRouteTo(x, y))
            {
                Critter.Direction = Critter.GetDirectionTo(x, y);
                Critter.Move(3);
            }
        }

        public override void NotifyCloseToCritter(OtherCritter otherCritter)
        {
            if (!otherCritter.IsTerrainBlockingRouteTo)
            {
                Critter.Direction = otherCritter.DirectionTo + 180;
                Critter.Move(3);
            }
        }

        private static Image GetImageFromResource(string imageName)
        {
            System.IO.Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DemoCritter." + imageName);
            if (stream != null)
            {
                return Image.FromStream(stream);
            }
            else
            {
                return null;
            }
        }

    }
}
