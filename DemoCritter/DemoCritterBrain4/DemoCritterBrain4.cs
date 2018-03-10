using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CritterBrains;

namespace DemoCritter
{
    public class DemoCritterBrain4 : CritterBrains.CritterBrain
    {
        Random random = new Random();

        public static DemoCritterBrain4 CreateCritterBrain4()
        {
            Image[] _images = {
                GetImageFromResource("demo4_1.png"),
                GetImageFromResource("demo4_2.png"),
                GetImageFromResource("demo4_3.png"),
                GetImageFromResource("demo4_4.png"),
                GetImageFromResource("demo4_5.png"),
                GetImageFromResource("demo4_6.png")
            };
            return new DemoCritterBrain4(_images);
        }

        public DemoCritterBrain4(Image[] images) : base("Wimp", "Wayne Rippin (with Dave mods)", images)
        {
        }

        public override void Birth()
        {
            Critter.Direction = random.Next(0, 360);
            Critter.Speed = 5;
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
            Critter.Speed = 1;
        }

        public override void NotifyBumpedCritter(OtherCritter other)
        {
            Critter.Direction = Critter.Direction + 180;
            Critter.Speed = 2;
        }

        public override void NotifyEaten()
        {
            Critter.Speed = 1;
        }

        public override void NotifyCloseToFood(int x, int y)
        {
            if (!Critter.IsTerrainBlockingRouteTo(x, y))
            {
                Critter.Direction = Critter.GetDirectionTo(x, y);
                Critter.Speed = 3;
            }
        }

        public override void NotifyCloseToCritter(OtherCritter otherCritter)
        {
            if (!otherCritter.IsTerrainBlockingRouteTo)
            {
                Critter.Direction = otherCritter.DirectionTo + 180;
                Critter.Speed = 3;
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
