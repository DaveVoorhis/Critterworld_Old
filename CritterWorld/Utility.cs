using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Sprites;

namespace CritterWorld
{
    public class Utility
    {
        static Configuration configuration = null;
        static Random random = new Random();

        public static Configuration GetConfiguration()
        {
            if (configuration == null)
            {
                configuration = new Configuration();
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
