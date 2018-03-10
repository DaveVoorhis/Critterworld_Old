using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using CritterBrains;

using Sprites;

namespace CritterWorld
{
    public class World
    {
        public const string HighscoresFileName = "highscores.xml";

        CritterWorldForm worldForm = null;
        Map map = null;
        BindingList<CritterWrapper> waitingCritters = null;
        BindingList<CritterWrapper> runningCritters = null;
        BindingList<CritterWrapper> finishedCritters = null;
        BindingList<CritterWrapper> deadCritters = null;
        BindingList<CritterWrapper> displayCritters = null;
        List<VisibleObject> allObjects = null;
        int newFoodNeeded;
        Goal goal = null;
        int maximumActiveCritterCount = 0;
        int maximumCritterAge = 0;
        System.Windows.Forms.Timer updateTimer;
        Leaderboard leaderboard;

        public World(CritterWorldForm worldForm)
        {
            this.worldForm = worldForm;
            waitingCritters = new BindingList<CritterWrapper>();
            runningCritters = new BindingList<CritterWrapper>();
            finishedCritters = new BindingList<CritterWrapper>();
            deadCritters = new BindingList<CritterWrapper>();
            displayCritters = new BindingList<CritterWrapper>();
            allObjects = new List<VisibleObject>();
            leaderboard = new Leaderboard(HighscoresFileName);
            CreateMap();
            newFoodNeeded = Utility.GetConfiguration().FoodDumps;
            updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Interval = 1000;
            updateTimer.Tick += new EventHandler(updateTimer_Tick);
        }

        private void updateTimer_Tick(Object myObject, EventArgs myEventArgs)
        {
            CleanupDead();
            CheckFoodSupply();
            CheckActiveCritterCount();
        }

        internal void Activate(CritterWrapper critterWrapper)
        {
            if (!critterWrapper.IsWaiting)
                return;
            Critter critter = null;
            try
            {
                Point possibleCritterPosition = GetStartingCritterPosition();
                critter = Critter.CreateCritter(critterWrapper.File, critterWrapper.Brain, this, possibleCritterPosition);
                critter.MaximumAge = maximumCritterAge;
                critterWrapper.Critter = critter;
                runningCritters.Add(critterWrapper);
                displayCritters.Add(critterWrapper);
            }
            catch (Exception e)
            {
                Logger.OutputToLog("Critter " + critterWrapper.CritterName + " by " + critterWrapper.CritterCreator + " in file " + critterWrapper.File + " failed to activate: " + e, Logger.LogLevel.Error);
                if (critter != null)
                    critter.Die("Crashed");
                CritterWorldForm.AddMarqueeMessage(critterWrapper.CritterName + " by " + critterWrapper.CritterCreator + " crashed.");
            }
        }

        public int ActiveCritterCount
        {
            get
            {
                return runningCritters.Count;
            }
        }

        public bool HaveAllCrittersBeenActivated
        {
            get
            {
                return waitingCritters.Count == 0;
            }
        }

        public bool IsWorldFinished
        {
            get
            {
                return (HaveAllCrittersBeenActivated && ActiveCritterCount == 0);
            }
        }

        public int MaximumActiveCritterCount
        {
            get
            {
                return maximumActiveCritterCount;
            }
            set
            {
                maximumActiveCritterCount = value;
            }
        }

        public int MaximumCritterAge
        {
            get
            {
                return maximumCritterAge;
            }
            set
            {
                maximumCritterAge = value;
            }
        }

        public void CreateMap()
        {
            map = new Map(worldForm.Panel);
        }

        public void Add(Sprite sprite)
        {
            worldForm.Add(sprite);
        }

        public void Remove(Sprite sprite)
        {
            worldForm.Remove(sprite);
        }

        public Map Map
        {
            get
            {
                return map;
            }
        }

        public int Width
        {
            get
            {
                return worldForm.Panel.ClientSize.Width;
            }
        }

        public int Height
        {
            get
            {
                return worldForm.Panel.ClientSize.Height;
            }
        }

        public BindingList<CritterWrapper> CritterData
        {
            get
            {
                return displayCritters;
            }
        }

        public BindingList<CritterWrapper> WaitingCritters
        {
            get
            {
                return waitingCritters;
            }
        }

        public BindingList<Leaderboard.LeaderInfo> Highscores
        {
            get
            {
                return leaderboard.Highscores;
            }
        }

        public List<VisibleObject> AllObjects
        {
            get
            {
                return allObjects;
            }
        }

        public void NotifyNewFoodNeeded()
        {
            lock (allObjects)
            {
                newFoodNeeded++;
            }
        }
 
        public void CheckFoodSupply()
        {
           lock (allObjects)
           {
                while (newFoodNeeded > 0)
                {
                    Food.CreateFood(this);
                    newFoodNeeded--;
                }
           }
        }

        public void CheckActiveCritterCount()
        {
            lock (runningCritters)
            {
                if (runningCritters.Count < maximumActiveCritterCount || maximumActiveCritterCount <= 0)
                {
                    lock (waitingCritters)
                    {
                        if (waitingCritters.Count() > 0)
                        {
                            CritterWrapper critter = waitingCritters[0];
                            waitingCritters.RemoveAt(0);
                            Activate(critter);
                        }
                    }
                }
            }
        }

        private Point GetStartingCritterPosition()
        {
            // Horrible hard-coded kludge here:
            int nextCritterStartPositionX = 10;
            int nextCritterStartPositionY = 10;
            Point possibleCritterPosition;
            do
            {
                possibleCritterPosition = new Point(nextCritterStartPositionX, nextCritterStartPositionY);
                nextCritterStartPositionY += 40;
                if (nextCritterStartPositionY >= 500)
                {
                    nextCritterStartPositionX += 25;
                    nextCritterStartPositionY = 10;
                }
            }
            while (!map.IsClearOfTerrain(possibleCritterPosition.X, possibleCritterPosition.Y, Critter.CritterWidth, Critter.CritterHeight) ||
                    IsBlockedByCritter(possibleCritterPosition.X, possibleCritterPosition.Y, Critter.CritterWidth, Critter.CritterHeight));
            return possibleCritterPosition;
        }

        public void LoadCritters()
        {
            StopWorld();
            // Get list of all dll files in specified folder. Iterate through them to find classes that implement ICritterFactory.
            string configDLLPath = Utility.GetConfiguration().BrainDLLPath.Trim();
            string dllPath = (configDLLPath.Length > 0) ? configDLLPath : Path.GetDirectoryName(Application.ExecutablePath);
            Logger.OutputToLog("Loading critter brains from " + dllPath, Logger.LogLevel.Message);
            string[] dllFiles = System.IO.Directory.GetFiles(dllPath, "*.dll");
            foreach (string file in dllFiles)
            {
                try
                {
                    Assembly assembly = Assembly.LoadFrom(file);
                    foreach (Type type in assembly.GetTypes())
                    {
                        if (type.IsClass && type.GetInterface("ICritterFactory") != null)
                        {
                            // ICritterFactory is implemented. Get the brains and add them to the list.
                            try
                            {
                                ICritterFactory critterFactory = (ICritterFactory)Activator.CreateInstance(type);
                                foreach (CritterBrains.CritterBrain brain in critterFactory.GetCritterBrains())
                                {
                                    if (brain == null)
                                    {
                                        Logger.OutputToLog("Error in brain loading from " + file + ". Failed to load.  Brain is null.", Logger.LogLevel.Error);
                                        CritterWorldForm.AddMarqueeMessage(file + " crashed.");
                                    }
                                    else
                                    {
                                        waitingCritters.Add(new CritterWrapper(file, brain));
                                    }
                                }
                            }
                            catch (Exception e)
                            {
                                Logger.OutputToLog("Error in brain loading from " + file + ". Exception is " + e.Message + "\n" + e.StackTrace, Logger.LogLevel.Error);
                                CritterWorldForm.AddMarqueeMessage(file + " couldn't load.");
                            }
                        }
                        else
                        {
                            Logger.OutputToLog("Skipped type " + type.Name + " in " + file + "; it is not a class or doesn't implement ICritterFactory.", Logger.LogLevel.Warning);
                        }
                    }
                }
                catch (Exception e)
                {
                    Logger.OutputToLog("Error loading file " + file + ". Exception is " + e.Message + "\n" + e.StackTrace, Logger.LogLevel.Error);
                    CritterWorldForm.AddMarqueeMessage(file + " couldn't load.");
                }
            }
            updateTimer.Start();
        }
 
        public void StopWorld()
        {
            updateTimer.Stop();
            foreach (VisibleObject thing in AllObjects)
            {
                while (!thing.IsDead)
                {
                    thing.Die("Terminated");
                }
            }
            AllObjects.Clear();
            runningCritters.Clear();
            waitingCritters.Clear();
            finishedCritters.Clear();
            deadCritters.Clear();
            displayCritters.Clear();
            newFoodNeeded = Utility.GetConfiguration().FoodDumps;
        }

        // Return an enumeration of all objects that are within a specific range of a specific object
        public IEnumerable<VisibleObject> GetObjectsCloseBy(VisibleObject visibleObject, int range)
        {
            for (int i = 0; i < allObjects.Count; i++)
            {
                if (visibleObject != allObjects[i] && visibleObject.IsTouching(allObjects[i], range))
                {
                    yield return allObjects[i];
                }
            }
        }

        // Return the visible object we have collided with.  Null if no collision. 
        public VisibleObject GetTouching(VisibleObject me) 
        {
            lock (allObjects)
            {
    			foreach (VisibleObject another in allObjects)
                {
                    if (another != me && another.IsTouching(me))
                    {
                        return another;
                    }
                }
			}
			return null;
		}

        // Return true if a given rectangular region is likely to be blocked by a critter. 
        private bool IsBlockedByCritter(int x, int y, int width, int height) 
        {
		    lock (runningCritters) 
            {
			    foreach (CritterWrapper critterWrapper in runningCritters)
                {
				    if (critterWrapper.Critter.IsTouching(new Rectangle(x, y, width, height)))
                    {
					    return true;
                    }
                }
			}
            return false;
    	}

        // Obtain a random location, of a given width and height, that is not
        // occupied by unpassable terrain or a critter.  
        //
        // The time it will take for this to succeed is unbounded, but statistically 
        // unlikely to be undesirably slow unless free spaces in the terrain are very 
        // rare.  This is best used in a setup phase, rather than during play.
        public Point GetRandomLocation(int width, int height)
        {
            while (true)
            {
                int x = Utility.NextRandom(width / 2, worldForm.Panel.ClientSize.Width - width / 2);
                int y = Utility.NextRandom(height / 2, worldForm.Panel.ClientSize.Height - height / 2);
                if (map.IsClearOfTerrain(x, y, width, height) && !IsBlockedByCritter(x, y, width, height))
                {
                    return new Point(x, y);
                }
            }
        }

        // Obtain a random location, of a given width and height, as close as possible
        // to a given nearX and nearY, that is not occupied by unpassable terrain or a critter.
        // 
        // As per GetRandomLocation(), the time taken is unbounded.
        public Point GetRandomLocationNear(int nearX, int nearY, int width, int height, int distance)
        {
            while (true)
            {
                double theta = Utility.NextRandom(0, Math.PI * 2);
                int x = (int)(distance * Math.Sin(theta)) + nearX;
                int y = (int)(distance * Math.Cos(theta)) + nearY;
                if (map.IsClearOfTerrain(x, y, width, height) && !IsBlockedByCritter(x, y, width, height))
                {
                    return new Point(x, y);
                }
            }
        }

        public void Shutdown()
        {
            StopWorld();
        }

        private void recordFinishedCritter(CritterWrapper critter)
        {
            // crude insertion sort now; improve later
            for (int k = 0; k < finishedCritters.Count; k++)
            {
                if (critter.Critter.TimeToGoal < finishedCritters[k].Critter.TimeToGoal)
                {
                    finishedCritters.Insert(k, critter);
                    return;
                }
            }
            finishedCritters.Add(critter);
        }

        public void CleanupDead()
        {
            lock (allObjects)
            {
                for (int i = 0; i < allObjects.Count; i++)
                {
                    if (allObjects[i].IsDead)
                    {
                        if (allObjects[i] is Critter)
                        {
                            for (int j = 0; j < runningCritters.Count; j++)
                            {
                                if (runningCritters[j].Critter == allObjects[i])
                                {
                                    CritterWrapper critter = runningCritters[j];
                                    runningCritters.RemoveAt(j);
                                    if (critter.Critter.IsGoalReached)
                                    {
                                        recordFinishedCritter(critter);
                                        leaderboard.AddFinisher(critter.CritterName, (string)critter.Critter.CritterBrain.Creator, critter.Critter.TimeToGoal);
                                    }
                                    else
                                    {
                                        deadCritters.Add(critter);
                                    }
                                    break;
                                }
                            }
                        }
                        allObjects.RemoveAt(i);
                    }
                }
            }
        }

        public void SetGoal(Point goalLocation)
        {
            AnimationFramesInMultipleFiles spriteImage = new AnimationFramesInMultipleFiles();
            spriteImage.Add("Goal.png");
            Sprite goalSprite = new Sprite(new SpriteImageMultipleFiles(spriteImage));
            goal = new Goal(this, goalSprite, goalLocation);
        }

        public Goal GetGoal()
        {
            return goal;
        }
    }
}
