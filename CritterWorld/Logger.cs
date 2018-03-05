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
        public enum LogLevel
        {
            Debug,
            Message,
            Warning,
            Error
        }

        static string debugLogFile = "debug.txt";
        static string messageLogFile = "messages.txt";
        static string warningLogFile = "warnings.txt";
        static string errorLogFile = "errors.txt";

        static StreamWriter logger;
        static Object lockObject = new Object();
        static TextBox logWidget = null;
        static string lastMessage = "";

        private static void AddWidgetText(string value)
        {
            logWidget.AppendText(DateTime.Now.ToString() + ": " + value);
            logWidget.AppendText(Environment.NewLine);
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
            if (logWidget != null)
            {
                if (logWidget.InvokeRequired)
                { 
                    logWidget.Invoke(new MethodInvoker(delegate {
                        AddWidgetText(value);
                    }));
                }
                else
                {
                    AddWidgetText(value);
                }
            }
        }

        public static void SetLogWidget(TextBox textBox)
        {
            logWidget = textBox;
        }

    }
}
