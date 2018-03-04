using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace CritterWorld
{
    public class Logger
    {
        enum LogType
        {
            None,
            File,
            Window
        }

        public enum LogLevel
        {
            Debug,
            Message,
            Warning,
            Error
        }

        static bool isLogging = false;
        static LogType LoggingType = LogType.Window;
        static string debugLogFile = "debug.txt";
        static string messageLogFile = "messages.txt";
        static string warningLogFile = "warnings.txt";
        static string errorLogFile = "errors.txt";
        static StreamWriter logger;
        static Object lockObject = new Object();
        static LoggingWindow logForm = null;
        static string lastMessage = "";

        public static void StartUp()
        {
            if (LoggingType == LogType.Window)
            {
                logForm = new LoggingWindow();
                logForm.Show();
            }
        }

        public static void Shutdown()
        {
            if (LoggingType == LogType.Window)
            {
                logForm.Close();
            }
        }

        public static void SetLoggingState(bool loggingState)
        {
            isLogging = loggingState;
            if (LoggingType != LogType.Window)
            {
                return;
            }
            if (isLogging)
            {
                StartUp();
            }
            else
            {
                Shutdown();
            }
        }

        public static void OutputToLog(string value, LogLevel level)
        {
            lock (lockObject)
            {
                if (value == lastMessage)
                    return;
                lastMessage = value;
                switch (level)
                {
                    case LogLevel.Debug: logger = new StreamWriter(debugLogFile, true); break;
                    case LogLevel.Message: logger = new StreamWriter(messageLogFile, true); break;
                    case LogLevel.Warning: logger = new StreamWriter(warningLogFile, true); break;
                    case LogLevel.Error: logger = new StreamWriter(errorLogFile, true); break;
                    default: logger = new StreamWriter(errorLogFile, true); break;
                }
                logger.Write(DateTime.Now.ToString() + ": ");
                logger.WriteLine(value);
                logger.Close();
            }
            if (!isLogging)
            {
                return;
            }
            switch (LoggingType)
            {
                case LogType.None:
                    break;

                case LogType.File:
                    break;

                case LogType.Window:
                    logForm.Add(DateTime.Now.ToString() + ": " + value);
                    break;
            }
        }

        public static void Start()
        {
            if (LoggingType == LogType.None)
            {
                return;
            }
            logger = new StreamWriter(debugLogFile, true);
        }

        public static void Write(string value)
        {
            if (LoggingType == LogType.None)
            {
                return;
            }
            logger.Write(value);
        }

        public static void WriteLine(string value)
        {
            if (LoggingType == LogType.None)
            {
                return;
            }
            logger.WriteLine(value);
        }

        public static void Stop()
        {
            if (LoggingType == LogType.None)
            {
                return;
            }
            logger.Close();
        }

    }
}
