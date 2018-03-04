using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CritterWorld
{
    class Version
    {
        public static string Product
        {
            get
            {
                return "CritterWorld";
            }
        }

        public static int Major 
        {
            get
            {
                return 0;
            }
        }

        public static int Minor
        {
            get
            {
                return 1;
            }
        }

        public static int Revision
        {
            get
            {
                return 11;
            }
        }

        public static string Release
        {
            get
            {
                return "Alpha";
            }
        }

        public static string VersionString
        {
            get
            {
                return Product + " version " + Major + "." + Minor + "." + Revision + " " + Release;
            }
        }
    }
}
