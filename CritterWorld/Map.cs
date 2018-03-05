using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CritterWorld
{
    public class Map
    {
        int[,] map = null;
        WorldPanel panel = null;

        // Build the map for the background image. 
        //
        // Each element of the array corresponds to one pixel on the image
        // 
        // 0   = No obstacle
        // 255 = Blocked
        //

        public Map(WorldPanel panel)
        {
            this.panel = panel;
            CreateMap();
        }

        private void CreateMap()
        {
            int width = panel.ClientSize.Width;
            int height = panel.ClientSize.Height;
            Bitmap backgroundImage = (Bitmap)panel.BackgroundImage;
            Color pixelColour;

            map = new int[width, height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    pixelColour = backgroundImage.GetPixel(x, y);
                    if (pixelColour.B >= 128 && pixelColour.G >= 128 && pixelColour.R >= 128)
                    {
                        map[x, y] = 0;
                    }
                    else
                    {
                        map[x, y] = 255;
                    }
                }
            }
            //Dump();
        }

        // Get the map value at the specified co-ordinates
        //
        // 0   = No obstacle
        // 255 = Blocked

        public int GetMapValue(int x, int y)
        {
            if (x >= map.GetLength(0) || y >= map.GetLength(1))
            {
                return 255;
            }
            return map[x, y];
        }

        public bool IsTerrain(int x, int y)
        {
            if (x < 0 || x >= map.GetLength(0) || y < 0 || y >= map.GetLength(1))
            {
                return true;
            }
            return (map[x, y] != 0);
        }

        public bool IsClearOfTerrain(int x, int y, int width, int height)
        {
            if (x < 0 || x + width >= map.GetLength(0) || y < 0 || y + height >= map.GetLength(1))
            {
                return false;
            }
            for (int xi = x; xi <= x + width; xi++)
            {
                for (int yi = y; yi < y + height; yi++)
                {
                    if (map[xi, yi] != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // Dump map representation to logger.  Diagnostic routine only.
        public void Dump()
        {
            Logger.OutputToLog("Map width = " + panel.ClientSize.Width, Logger.LogLevel.Message);
            Logger.OutputToLog("Map height = " + panel.ClientSize.Height, Logger.LogLevel.Message);
            string line = "";
            for (int y = 0; y < panel.ClientSize.Height; y++)
            {
                for (int x = 0; x < panel.ClientSize.Width; x++)
                {
                    int mapValue = map[x, y];
                    line += (mapValue == 0) ? " " : mapValue >= 255 ? "o" : ".";
                }
                Logger.OutputToLog(line, Logger.LogLevel.Message);
            }
        }

    }
}
