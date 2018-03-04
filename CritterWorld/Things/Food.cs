using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sprites;

namespace CritterWorld
{
    public class Food : VisibleObject
    {
        public const int FoodBoundingRadius = 8;

        Timer timer = null;

        public static Food CreateFood(World world)
        {
            Logger.OutputToLog("CreateFood", Logger.LogLevel.Message);

            AnimationFramesInMultipleFiles foodImages = new AnimationFramesInMultipleFiles();
            foodImages.Add("Kiwi-Fruit.png");
            return new Food(world, new Sprite(new SpriteImageMultipleFiles(foodImages)), FoodBoundingRadius);
        }

        public Food(World world, Sprite sprite, int boundingRadius) : base(world, sprite, boundingRadius)
        {
            int foodDecayPeriod = Utility.GetConfiguration().FoodDecayTime;
            if (foodDecayPeriod > 0)
            {
                timer = new Timer();
                timer.Interval = 1000 * foodDecayPeriod;
                timer.Tick += new EventHandler(Timer_Tick);
                timer.Start();
            }
        }

        private void Timer_Tick(Object myObject, EventArgs myEventArgs)
        {
            Die("Decayed");
        }

        protected override void NotifyBumped(VisibleObject bumpedObject)
        {
            Logger.OutputToLog("Food bumped", Logger.LogLevel.Message);
            if (bumpedObject is Critter)
            {
                Logger.OutputToLog("NotifyBumped against " + bumpedObject, Logger.LogLevel.Message);
                Critter critter = (Critter)bumpedObject;
                critter.Energy += Utility.GetConfiguration().CritterEnergyPerFeed;
                try
                {
                    critter.NotifyEating(this);
                    critter.CritterBrain.NotifyEaten();
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
                Die("Eaten");
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
