using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sprites;

namespace CritterWorld
{
    public class Poop : VisibleObject
    {
        public const int PoopBoundingRadius = 8;

        Timer timer = null;

        public static Poop CreatePoop(World world, int nearX, int nearY)
        {
            AnimationFramesInMultipleFiles poopImages = new AnimationFramesInMultipleFiles();
            poopImages.Add("poop.png");
            Poop poop = new Poop(world, new Sprite(new SpriteImageMultipleFiles(poopImages)), PoopBoundingRadius);
            poop.Position = world.GetRandomLocationNear(nearX, nearY, poop.Width, poop.Height, PoopBoundingRadius * 2);
            return poop;
        }

        public Poop(World world, Sprite sprite, int boundingRadius) : base(world, sprite, boundingRadius)
        {
            int poopEvaporatePeriod = Utility.GetConfiguration().PoopEvaporateTime;
            if (poopEvaporatePeriod > 0)
            {
                timer = new Timer();
                timer.Interval = 1000 * poopEvaporatePeriod;
                timer.Tick += (sender, args) => Die("Evaporated");
                timer.Start();
            }
        }

        protected override void NotifyBumped(VisibleObject bumpedObject)
        {
            if (bumpedObject is Critter)
            {
                Critter critter = (Critter)bumpedObject;
                critter.Energy -= Utility.GetConfiguration().CritterEnergyPerDefilement;
                try
                {
                    critter.CritterBrain.NotifyDefiled();
                }
                catch (System.Threading.ThreadAbortException)
                {
                    // Do nothing
                }
                catch (Exception e)
                {
                    Logger.OutputToLog("Error in NotifyBumped from file " + critter.File + ": Exception is " + e.Message + "\n" + e.StackTrace, Logger.LogLevel.Error);
                    Die("Crashed");
                }
            }
        }

        public override void Die(string reason)
        {
            if (IsDead)
            {
                return;
            }
            if (timer != null)
            {
                timer.Stop();
            }
            base.Die(reason);
            if (Utility.GetConfiguration().AutoNewFoodDump)
            {
                World.NotifyNewFoodNeeded();
            }
        }

    }
}
