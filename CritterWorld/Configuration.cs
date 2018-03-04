using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CritterWorld
{
    public class Configuration
    {
        int foodDumps;
        int energyPerFoodDump;
        int foodDecayTime;
        int poopEvaporateTime;
        bool autoNewFoodDump;
        int critterEndurance;
        int critterEnergyPerFeed;
        int critterEnergyPerDefilement;
        int critterEnergyWhenBorn;
        string worldFileName;
        int refreshRate;

        public Configuration()
        {
            ResetToBuiltInDefaults();
        }

        public void EditConfiguration()
        {
        }

        public void ResetToBuiltInDefaults()
        {
            foodDumps = 6;
            energyPerFoodDump = 30;
            foodDecayTime = 30;
            poopEvaporateTime = 10;
            autoNewFoodDump = true;
            critterEndurance = 1000;
            critterEnergyPerFeed = 10;
            critterEnergyPerDefilement = 20;
            critterEnergyWhenBorn = 50;
            worldFileName = "BackgroundBase.png";
            refreshRate = 12;
        }

        public int FoodDumps 
        {
            get
            {
                return foodDumps;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid number of food dumps: " + value.ToString());
                }
                else
                {
                    foodDumps = value;
                }
            } 
        }

        public int EnergyPerFoodDump
        {
            get
            {
                return energyPerFoodDump;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid value for energy per food dump: " + value.ToString());
                }
                else
                {
                    energyPerFoodDump = value;
                }
            }
        }

        public bool AutoNewFoodDump 
        {
            get
            {
                return autoNewFoodDump;
            }
            set
            {
                autoNewFoodDump = value;
            }
        }

        public int FoodDecayTime
        {
            get
            {
                return foodDecayTime;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid food decay time: " + value.ToString());
                }
                else
                {
                    foodDecayTime = value;
                }
            }
        }

        public int PoopEvaporateTime
        {
            get
            {
                return poopEvaporateTime;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid poop evaporate time: " + value.ToString());
                }
                else
                {
                    poopEvaporateTime = value;
                }
            }
        }

        public int CritterEndurance
        {
            get
            {
                return critterEndurance;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid value for critter endurance: " + value.ToString());
                }
                else
                {
                    critterEndurance = value;
                }
            }
        }

        public int CritterEnergyWhenBorn
        {
            get
            {
                return critterEnergyWhenBorn;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid value for critter energy when born: " + value.ToString());
                }
                else
                {
                    critterEnergyWhenBorn = value;
                }
            }
        }

        public int CritterEnergyPerFeed
        {
            get
            {
                return critterEnergyPerFeed;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid value for energy gained by a critter per feed: " + value.ToString());
                }
                else
                {
                    critterEnergyPerFeed = value;
                }
            }
        }
        public int CritterEnergyPerDefilement
        {
            get
            {
                return critterEnergyPerDefilement;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid value for energy lost by a critter for stepping in poop: " + value.ToString());
                }
                else
                {
                    critterEnergyPerDefilement = value;
                }
            }
        }

        public string WorldFileName
        {
            get
            {
                return worldFileName;
            }
            set
            {
                worldFileName = value;
            }
        }

        public int RefreshRate 
        {
            get
            {
                return refreshRate;
            }
            set
            {
                if (value < 5 || value > 60)
                {
                    throw new Exception("Invalid refresh rate: " + value.ToString());
                }
                else
                {
                    refreshRate = value;
                }
            } 
        }
        
        
    }
}
