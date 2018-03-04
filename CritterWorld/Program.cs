using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CritterWorld
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool launchCompetition = false;
            if (args.Length > 0)
            {
                if (args[0].Substring(1, 1).ToLower() == "c")
                {
                    launchCompetition = true;
                }
                else
                {
                    Usage();
                    return;
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CritterWorldForm(launchCompetition));
        }

        static void Usage()
        {
            Console.WriteLine("CritterWorld [-c[ompetition]]");
            Console.WriteLine("  -c[competition] launches competition mode on startup.");
        }
    }
}
