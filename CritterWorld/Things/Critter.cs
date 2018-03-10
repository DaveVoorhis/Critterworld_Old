using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using CritterBrains;
using Sprites;

namespace CritterWorld 
{
    public class Critter : VisibleMovableObject, ICritter, IOtherCritter
    {
        public const int CritterWidth = 15;
        public const int CritterHeight = 15;
        public const int CritterBoundingRadius = 8;

        CritterBrains.CritterBrain critterBrain;
        string fileContainingBrain = null;

        bool isGoalReached = false;
        bool isNewborn = true;

        int age;
        int maximumAge;
        int energy;

        Timer energyTimer;
        Timer ageTimer;
        Timer poopTimer;

        bool ateEnoughToPoop = false;

        DateTime birthday = DateTime.MinValue;
        TimeSpan timeToGoal = TimeSpan.MinValue;

        static int nextCritterNumber = 0;

        static Image deadCritterImage = null;
        static Image winnerCritterImage = null;

        static Random randomiser = new Random();
        
        public static Critter CreateCritter(String fileName, CritterBrains.CritterBrain critterBrain, World world, Point position)
        {
            if (deadCritterImage == null)
            {
                deadCritterImage = Utility.GetImageFromResource("DeadCritter.png");
            }
            if (winnerCritterImage == null)
            {
                winnerCritterImage = Utility.GetImageFromResource("WinnerCritter.png");
            }
            AnimationFramesInMultipleFiles critterImages = null;
            if (critterBrain.Images == null)
            {
                // The critter does not have any built-in 
                // images, so use two of our 'stock' images
                critterImages = new AnimationFramesInMultipleFiles();
                critterImages.Add(Utility.GetImageFromResource("Robo" + nextCritterNumber.ToString() + "_01.png"));
                critterImages.Add(Utility.GetImageFromResource("Robo" + nextCritterNumber.ToString() + "_02.png"));
                nextCritterNumber = (nextCritterNumber + 1) % 10;
            }
            else
            {
                critterImages = new AnimationFramesInMultipleFiles();
                foreach (Image image in critterBrain.Images)
                {
                    // Copy the images, resizing if necessary
                    Image newImage = new Bitmap(CritterWidth, CritterHeight);
                    Graphics graphic = Graphics.FromImage(newImage);
                    graphic.DrawImage(image, 0, 0, CritterWidth, CritterHeight);
                    critterImages.Add(newImage);
                }
            }
            SpriteImage critterAnimator = new SpriteImageMultipleFiles(critterImages);
            critterAnimator.FPS = 4;
            critterAnimator.IsAnimated = true;
            Sprite critterSprite = new Sprite(critterAnimator);
            return new Critter(fileName, critterBrain, world, critterSprite, CritterBoundingRadius, position);
        }

        public Critter(String fileName, CritterBrains.CritterBrain critterBrain, World world, Sprite sprite, int boundingRadius, Point position)
            : base(world, sprite, boundingRadius)
        {
            this.critterBrain = critterBrain;
            this.fileContainingBrain = fileName;
            critterBrain.Body = this;
            Energy = Utility.GetConfiguration().CritterEnergyWhenBorn;
            Position = position;
            maximumAge = 0;
            energyTimer = new Timer();
            energyTimer.Interval = 1000;
            energyTimer.Tick += new EventHandler(EnergyTimer_Tick);
            energyTimer.Start();
            ageTimer = new Timer();
            ageTimer.Interval = 1000 * 60;
            ageTimer.Tick += new EventHandler(AgeTimer_Tick);
            ageTimer.Start();
            poopTimer = new Timer();
            poopTimer.Interval = Utility.NextRandom(1000, 10000);
            poopTimer.Tick += new EventHandler(PoopTimer_Tick);
            poopTimer.Start();
        }

        public string WhoAmI
        {
            get
            {
                return critterBrain.Name + " by " + critterBrain.Creator;
            }
        }

        private void EnergyTimer_Tick(Object myObject, EventArgs myEventArgs)
        {
            double speedEnergyReductionFactor = 6.0;
            Energy -= (int)(Speed / speedEnergyReductionFactor + 1);
        }

        private void AgeTimer_Tick(Object myObject, EventArgs myEventArgs)
        {
            Age++;
        }

        private void PoopTimer_Tick(Object myObject, EventArgs myEventArgs)
        {
            if (ateEnoughToPoop)
            {
                Logger.OutputToLog(WhoAmI + " pooped.", Logger.LogLevel.Message);
                Poop.CreatePoop(World, X, Y);
                ateEnoughToPoop = false;
            }
            poopTimer.Interval = Utility.NextRandom(1000, 10000);
        }

        // Handle an event.  If consumed by this object, return true.
        public override bool HandleEvent(Message message)
        {
            if (base.HandleEvent(message)) 
            {
                return true;
            }
            if (message is MessageNotifyCloseToObject)
            {
                NotifyCloseToObject(((MessageNotifyCloseToObject)message).CloseToObject);
                return true;
            }
            else if (message is MessageNotifyBlockedByTerrain)
            {
                NotifyBlockedByTerrain();
                return true;
            }
            return false;
        }

        public Rectangle GetDestination()
        {
            Goal goal = World.GetGoal();
            if (goal == null)
            {
                return new Rectangle();
            }
            return new Rectangle(goal.Position.X, goal.Position.Y, goal.Width, goal.Height);
        }

        public CritterBrain CritterBrain
        {
            get
            {
                return critterBrain;
            }
        }

        public string File
        {
            get
            {
                return fileContainingBrain;
            }
        }

        public override void Processing()
        {
            base.Processing();
            if (critterBrain == null)
            {
                return;
            }
            if (isNewborn)
            {
                try
                {
                    birthday = DateTime.Now;
                    critterBrain.Birth();
                    isNewborn = false;
                    Logger.OutputToLog("Critter " + critterBrain.Name + " by " + critterBrain.Creator + " in file " + File + " was born", Logger.LogLevel.Message);
                }
                catch (Exception e)
                {
                    Logger.OutputToLog("Brain crashed from file " + File + " during birth: " + e.Message, Logger.LogLevel.Error);
                    Die("Crashed");
                    CritterWorldForm.AddMarqueeMessage(critterBrain.Name + " by " + critterBrain.Creator + " crashed.");
                }
                return;
            }
            try
            {
                critterBrain.Think();
            }
            catch (Exception e)
            {
                Logger.OutputToLog("Brain crashed from file " + File + " whilst thinking: " + e.Message, Logger.LogLevel.Error);
                Die("Crashed");
                CritterWorldForm.AddMarqueeMessage(critterBrain.Name + " by " + critterBrain.Creator + " crashed.");
            }
        }

        // ICritter Interface implementation
        public void MoveCritter(int speed)
        {
            Speed = speed;
        }

        public void Stop()
        {
            Speed = 0;
        }

        // ICritterStats interface
        public string CritterName
        {
            get
            {
                return critterBrain.Name;
            }
        }

        public string EnergyDisplay
        {
            get
            {
                if (IsDead)
                {
                    return DeadReason;
                }
                else
                {
                    return energy.ToString();
                }
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                if (IsDead)
                {
                    return;
                }
                age = value;
                if (maximumAge > 0 && age > maximumAge)
                {
                    Die("Old age");
                    ageTimer.Stop();
                    CritterWorldForm.AddMarqueeMessage(WhoAmI + " died of old age.");
                }
            }
        }

        public int MaximumAge
        {
            get
            {
                return maximumAge;
            }
            set
            {
                maximumAge = value;
            }
        }

        public int Energy
        {
            get
            {
                return energy;
            }
            set
            {
                if (IsDead)
                {
                    return;
                }
                energy = value;
                if (energy <= 0)
                {
                    Die("Starved");
                    energyTimer.Stop();
                    CritterWorldForm.AddMarqueeMessage(WhoAmI + " starved to death.");
                }
            }
        }

        // Time it took to reach goal.  TimeSpan.MinValue if not set.
        public TimeSpan TimeToGoal 
        {
            get
            {
                return timeToGoal;
            }
        }

        public Image Picture
        {
            get
            {
                if (isGoalReached)
                {
                    return winnerCritterImage;
                }
                else if (IsDead)
                {
                    return deadCritterImage;
                }
                else
                {
                    return sprite.Image.Image;
                }
            }
        }

        #region Notifier overrides

        public override void NotifyCloseToObject(VisibleObject objectCloseBy)
        {
            if (objectCloseBy is Food)
            {
                try
                {
                    critterBrain.NotifyCloseToFood(objectCloseBy);
                }
                catch (System.Threading.ThreadAbortException)
                {
                    // Do nothing
                }
                catch (Exception e)
                {
                    Logger.OutputToLog("Error in NotifyCloseToFood from file " + fileContainingBrain + ": Exception is " + e.Message + "\n" + e.StackTrace, Logger.LogLevel.Error);
                    Die("Crashed");
                    CritterWorldForm.AddMarqueeMessage(critterBrain.Name + " by " + critterBrain.Creator + " crashed.");
                }
            }
            else if (objectCloseBy is Critter)
            {
                try
                {
                    critterBrain.NotifyCloseToCritter((IOtherCritter)objectCloseBy);
                }
                catch (System.Threading.ThreadAbortException)
                {
                    // Do nothing
                }
                catch (Exception e)
                {
                    Logger.OutputToLog("Error in NotifyCloseToCritter from file " + fileContainingBrain + ": Exception is " + e.Message + "\n" + e.StackTrace, Logger.LogLevel.Error);
                    Die("Crashed");
                    CritterWorldForm.AddMarqueeMessage(critterBrain.Name + " by " + critterBrain.Creator + " crashed.");
                }
            }
            else if (objectCloseBy is Poop)
            {
                try
                {
                    critterBrain.NotifyCloseToPoop(objectCloseBy.X, objectCloseBy.Y);
                }
                catch (System.Threading.ThreadAbortException)
                {
                    // Do nothing
                }
                catch (Exception e)
                {
                    Logger.OutputToLog("Error in NotifyCloseToPoop from file " + fileContainingBrain + ": Exception is " + e.Message + "\n" + e.StackTrace, Logger.LogLevel.Error);
                    Die("Crashed");
                    CritterWorldForm.AddMarqueeMessage(critterBrain.Name + " by " + critterBrain.Creator + " crashed.");
                }
            }
        }

        public override void NotifyBlockedByTerrain()
        {
            try
            {
                critterBrain.NotifyBlockedByTerrain();
            }
            catch (System.Threading.ThreadAbortException)
            {
                // Do nothing
            }
            catch (Exception e)
            {
                Logger.OutputToLog("Error in NotifyBlockedByTerrain from file " + fileContainingBrain + ": Exception is " + e.Message + "\n" + e.StackTrace, Logger.LogLevel.Error);
                Die("Crashed");
                CritterWorldForm.AddMarqueeMessage(critterBrain.Name + " by " + critterBrain.Creator + " crashed.");
            }
        }

        protected override void NotifyBumped(VisibleObject bumpedObject)
        {
            if (bumpedObject is Food)
                return;
            if (bumpedObject is Poop)
                return;
            base.NotifyBumped(bumpedObject);
            try
            {
                critterBrain.NotifyBumped(bumpedObject);
            }
            catch (System.Threading.ThreadAbortException)
            {
                // Do nothing
            }
            catch (Exception e)
            {
                Logger.OutputToLog("Error in NotifyBumped from file " + fileContainingBrain + ": Exception is " + e.Message + "\n" + e.StackTrace, Logger.LogLevel.Error);
                Die("Crashed");
                CritterWorldForm.AddMarqueeMessage(critterBrain.Name + " by " + critterBrain.Creator + " crashed.");
            }
        }

        internal void NotifyEating(Food food)
        {
            ateEnoughToPoop = true;
        }

        public override bool IsBlockingObject()
        {
            return true;
        }

        #endregion

        public override void Die(string reason)
        {
            // Avoid repeated calls
            if (IsDead)
            {
                return;
            }
            poopTimer.Stop();
            energyTimer.Stop();
            ageTimer.Stop();
            Logger.OutputToLog("Critter " + WhoAmI + " in file " + fileContainingBrain + " died: " + reason, Logger.LogLevel.Message);
            Stop();
            base.Die(reason);
        }

        public Strength GetStrengthOf(IOtherCritter otherCritter)
        {
            int otherEnergy = ((Critter)otherCritter).Energy;
            if (otherEnergy == energy)
            {
                return Strength.Equal;
            }
            else if (otherEnergy < energy)
            {
                if (otherEnergy + 20 < energy)
                {
                    return Strength.MuchWeaker;
                }
                else
                {
                    return Strength.Weaker;
                }
            }
            else
            {
                if (otherEnergy > energy + 20)
                {
                    return Strength.MuchStronger;
                }
                else
                {
                    return Strength.Stronger;
                }
            }
        }

        public void Attack(IOtherCritter otherCritter)
        {
            if (IsDead)
            {
                return;
            }
            Critter other = (Critter)otherCritter;
            if (other.IsDead)
            {
                return;
            }
            bool iWin = false;
            if (other.Energy == energy)
            {
                // The two are evenly matched, so the result is 50/50
                iWin = Utility.NextRandom(0, 2) == 0;
            }
            else if (other.Energy < energy)
            {
                // The other critter is weaker
                if (other.Energy + 20 < energy)
                {
                    // 90% of me winning
                    iWin = Utility.NextRandom(0, 10) > 0;
                }
                else
                {
                    // 75% of me winning
                    iWin = Utility.NextRandom(0, 100) > 24;
                }
            }
            else
            {
                if (other.Energy > energy + 20)
                {
                    // 10% of me winning
                    iWin = Utility.NextRandom(0, 10) == 0;
                }
                else
                {
                    // 25% of me winning
                    iWin = Utility.NextRandom(0, 100) < 25;
                }
            }
            int energyLoss = Utility.NextRandom(5, 11);
            if (iWin)
            {
                // We win 
                Energy = Energy - energyLoss > 5 ? Energy - energyLoss : 5;
                string msg = WhoAmI + " attacked and killed " + other.WhoAmI + ".";
                Logger.OutputToLog(msg, Logger.LogLevel.Message);
                CritterWorldForm.AddMarqueeMessage(msg, Color.DarkRed);
                other.Die("Killed by " + WhoAmI);
            }
            else
            {
                // They win
                other.Energy = other.Energy - energyLoss > 5 ? other.Energy - energyLoss : 5;
                string msg = WhoAmI + " attacked and was killed by " + other.WhoAmI + ".";
                Logger.OutputToLog(msg, Logger.LogLevel.Message);
                CritterWorldForm.AddMarqueeMessage(msg, Color.DarkRed);
                Die("Killed by " + other.WhoAmI);
            }
        }

        public bool IsGoalReached
        {
            get
            {
                return isGoalReached;
            }
        }

        public void ReachedGoal()
        {
            if (isGoalReached)
            {
                return;
            }
            timeToGoal = DateTime.Now.Subtract(birthday);
            isGoalReached = true;
            Die("Win");   // happy
            CritterWorldForm.AddPriorityMarqueeMessage(WhoAmI + " reached the goal!", Color.Green);
        }
    }
}
