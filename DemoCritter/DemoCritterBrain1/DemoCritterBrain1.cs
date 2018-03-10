using System;
using System.IO;
using System.Windows.Forms;
using CritterBrains;

namespace DemoCritter
{
    public class DemoCritterBrain1 : CritterBrains.CritterBrain
    {
        const string ConfigurationFileName = "Drunkard.cfg";

        Random random = new Random();
        DateTime lastMovementTime;
        int randomIntervalInSeconds;
        DemoCritterBrain1Configuration configuration = null;

        public DemoCritterBrain1() : base("Drunkard", "Wayne & Dave")
        {
            LoadConfiguration();
        }

        public void LoadConfiguration()
        {
            TextReader reader = null;
            try
            {
                configuration = new DemoCritterBrain1Configuration();
                reader = new StreamReader(ConfigurationFileName);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] components = line.Split('=');
                    if (components.Length != 2)
                        continue;
                    string key = components[0];
                    string value = components[1];
                    if (key == "nominalSpeed")
                    {
                        int nominalSpeed;
                        if (int.TryParse(value, out nominalSpeed))
                        {
                            configuration.NominalSpeed = nominalSpeed;
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(ConfigurationFileName + " does not exist. Using defaults.");
            }
            catch (Exception e)
            {
                Console.WriteLine("LoadConfiguration error: " + e.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        public void SaveConfiguration()
        {
            TextWriter writer = null;
            try
            {
                writer = new StreamWriter(ConfigurationFileName);
                writer.WriteLine("nominalSpeed=" + configuration.NominalSpeed);
            }
            catch (Exception e)
            {
                Console.WriteLine("SaveConfiguration error: " + e.Message);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        public void ObtainDefaultConfiguration()
        {
            configuration = new DemoCritterBrain1Configuration();
        }

        public override Form Form {
            get
            {
                return new DemoCritterBrain1ConfigForm(this);
            }
        }

        public override void Birth()
        {
            DoRandomDirection();
        }

        public int Speed
        {
            get
            {
                return configuration.NominalSpeed;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Speed must be greater than or equal to zero.");
                }
                configuration.NominalSpeed = value;
            }
        }

        private void DoRandomDirection() 
        {
            Critter.Direction = random.Next(0, 360);
            Critter.Speed = configuration.NominalSpeed;
            lastMovementTime = DateTime.Now;
            randomIntervalInSeconds = random.Next(1, 5);
        }

        public override void Think()
        {
            int timePast = DateTime.Now.Subtract(lastMovementTime).Seconds;
            if (timePast >= randomIntervalInSeconds)
            {
                DoRandomDirection();
            }
        }
        
        public override void NotifyBlockedByTerrain()
        {
            Critter.Direction = Critter.Direction - 10;
            Critter.Speed = configuration.NominalSpeed;
        }

        public override void NotifyBumpedCritter(OtherCritter other)
        {
            Critter.Direction = Critter.Direction + 180;
            Critter.Speed = configuration.NominalSpeed;
        }

        public override void NotifyCloseToFood(int x, int y)
        {
            Critter.Direction = Critter.GetDirectionTo(x, y);
        }

        public override void NotifyCloseToCritter(OtherCritter otherCritter)
        {
            Critter.Direction = otherCritter.DirectionTo + 180;
        }
    }
}
