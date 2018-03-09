using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Sprites;
using System.Xml.Serialization;
using System.IO;
using System.ComponentModel;

namespace CritterWorld
{
    public class Utility
    {
        const string fileName = "configuration.xml";

        static Configuration configuration = null;
        static Random random = new Random();

        private static void LoadConfiguration()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
                TextReader reader = new StreamReader(fileName);
                configuration = (Configuration)serializer.Deserialize(reader);
                reader.Close();
            }
            catch (FileNotFoundException)
            {
                Logger.OutputToLog("Saved configuration file not found. It will be created automatically.", Logger.LogLevel.Message);
            }
            catch (Exception exception)
            {
                Logger.OutputToLog("Unable to load configuration: " + exception, Logger.LogLevel.Error);
            }
        }

        public static void SaveConfiguration()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
                TextWriter writer = new StreamWriter(fileName);
                serializer.Serialize(writer, configuration);
                writer.Close();
            }
            catch (Exception exception)
            {
                Logger.OutputToLog("Unable to save configuration: " + exception, Logger.LogLevel.Error);
            }
        }

        public static Configuration GetConfiguration()
        {
            if (configuration == null)
            {
                LoadConfiguration();
                if (configuration == null)
                {
                    configuration = new Configuration();
                }
            }
            return configuration;
        }

        public static int NextRandom(int lower, int higher)
        {
            return random.Next(lower, higher);
        }

        public static double NextRandom(double lower, double higher)
        {
            return lower + random.NextDouble() * (higher - lower);
        }

        public static Image GetImageFromResource(string imageName)
        {
            return SpriteEnvironment.GetImageFromResource(imageName);
        }

    }
}
