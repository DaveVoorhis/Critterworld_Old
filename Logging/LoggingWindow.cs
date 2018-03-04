using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CritterWorld
{
    public partial class LoggingWindow : Form
    {
        Queue<string> messages = new Queue<string>();
        Timer logTimer = null;

        public LoggingWindow()
        {
            InitializeComponent();
        }

        public void Add(string message)
        {
            messages.Enqueue(message);
        }

        private void LoggingWindow_Load(object sender, EventArgs e)
        {
            logTimer = new Timer();
            logTimer.Interval = 1000;
            logTimer.Tick += new EventHandler(Timer_Tick);
            logTimer.Start();
        }

        private void Timer_Tick(Object myObject, EventArgs myEventArgs)
        {
            int messageCount = messages.Count;
            while (messageCount > 0)
            {
                string message = messages.Dequeue();
                listBoxLog.Items.Add(message);
                messageCount--;
            }
        }

        private void LoggingWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            logTimer.Stop();
        }
    }
}
