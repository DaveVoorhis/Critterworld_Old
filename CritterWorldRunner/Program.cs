using System;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace CritterWorldRunner
{
    class Program
    {
        const string critterWorldExecutable = "CritterWorld.exe";
        const string critterWorldArguments = "-competition";

        static Process critterWorldProcess = null;

        static Process StartCritterWorld()
        {
            return Process.Start(critterWorldExecutable, critterWorldArguments);
        }

        static void Daemon()
        {
            File.Delete("_quit");
            while (!File.Exists("_quit"))
            {
                File.Delete("_down");
                while (!critterWorldProcess.HasExited)
                {
                    if (File.Exists("_quit") || File.Exists("_down"))
                    {
                        critterWorldProcess.Kill();
                    }
                    Thread.Sleep(1000);
                }
                File.Delete("_down");
                Console.WriteLine("CritterWorld.exe has shut down.");
                File.Delete("_up");
                while (!File.Exists("_quit"))
                {
                    if (File.Exists("_up"))
                    {
                        critterWorldProcess = StartCritterWorld();
                        if (critterWorldProcess == null)
                        {
                            Console.WriteLine("Unable to start CritterWorld.exe");
                        }
                        else
                        {
                            Console.WriteLine("CritterWorld.exe has started.");
                            break;
                        }
                    }
                    Thread.Sleep(1000);
                }
                File.Delete("_up");
            }
            File.Delete("_quit");
            Console.WriteLine("CritterWorldRunner has shut down.");
        }

        static void Main(string[] args)
        {
            critterWorldProcess = StartCritterWorld();
            if (critterWorldProcess == null)
            {
                Console.WriteLine("Unable to start CritterWorld.exe");
            }
            else
            {
                Daemon();
            }
        }
    }
}
