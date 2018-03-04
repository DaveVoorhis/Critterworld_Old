using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CritterWorld
{
    /// <summary>
    /// A one-time, multi-message scrolling marquee control.
    /// by DMVoorhis, d.voorhis@derby.ac.uk
    /// </summary>
    public partial class MarqueeLabel : UserControl
    {
        private class MarqueeMessage
        {
            internal MarqueeMessage(Image image)
            {
                this.image = image;
                this.position = 0;
                this.isDisplayed = false;
            }
            internal Image image;
            internal int position;
            internal bool isDisplayed;
        }
        
        System.Windows.Forms.Timer timerScroll;
        List<MarqueeMessage> messages = new List<MarqueeMessage>();

        public MarqueeLabel()
        {
            InitializeComponent();

            timerScroll = new System.Windows.Forms.Timer();
            timerScroll.Tick += new System.EventHandler(timerScroll_Tick);

            DoubleBuffered = true;
            ResizeRedraw = true;

            ScrollTimerInterval = 5;
            ScrollPixelAmount = 3;

            ScrollingEnabled = true;
        }

        public bool ScrollingEnabled
        {
            get
            {
                return timerScroll.Enabled;
            }
            set
            {
                timerScroll.Enabled = value;
            }
        }

        public int ScrollPixelAmount
        {
            get;
            set;
        }

        public int ScrollTimerInterval
        {
            get
            {
                return timerScroll.Interval;
            }
            set
            {
                timerScroll.Interval = value;
            }
        }

        private MarqueeMessage MakeMessage(string text, Color color)
        {
            string textForDisplay = text + " ";
            int width = (int)CreateGraphics().MeasureString(textForDisplay, Font).Width;
            Bitmap textImage = new Bitmap(width, ClientSize.Height);
            Graphics textGraphics = Graphics.FromImage(textImage);
            textGraphics.FillRectangle(new SolidBrush(BackColor), 0, 0, ClientSize.Width, ClientSize.Height);
            textGraphics.DrawString(textForDisplay, Font, new SolidBrush(color), 0, 0);
            return new MarqueeMessage(textImage);
        }

        // Add a new message at the end of the message queue, with a given color.
        public void Add(string text, Color color)
        {
            lock (messages)
            {
                messages.Add(MakeMessage(text, color));
            }
        }

        // Add a new message at the end of the message queue.
        public void Add(string text)
        {
            Add(text, ForeColor);
        }

        // Add a new message as soon as possible, with a given color.
        public void AddPriority(string text, Color color)
        {
            lock (messages)
            {
                for (int i = 0; i < messages.Count; i++)
                {
                    if (!messages[i].isDisplayed)
                    {
                        messages.Insert(i, MakeMessage(text, color));
                        return;
                    }
                }
                messages.Add(MakeMessage(text, color));
            }
        }

        // Add a new message as soon as possible.
        public void AddPriority(string text)
        {
            AddPriority(text, ForeColor);
        }

        public void Clear()
        {
            messages.Clear();
        }

        private void timerScroll_Tick(object sender, System.EventArgs e)
        {
            Invalidate();
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            int nextVisiblePosition = 0;
            for (int i=0; i<messages.Count; i++)
            {
                MarqueeMessage message = messages[i];
                if (message.isDisplayed)
                {
                    if (message.position + message.image.Width < 0)
                    {
                        messages.RemoveAt(i);
                    }
                    else
                    {
                        e.Graphics.DrawImage(message.image, message.position, 0);
                        message.position -= ScrollPixelAmount;
                        nextVisiblePosition = message.position + message.image.Width;
                        if (nextVisiblePosition > ClientSize.Width)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    if (nextVisiblePosition <= ClientSize.Width)
                    {
                        message.position = ClientSize.Width;
                        message.isDisplayed = true;
                    }
                    break;
                }
            }
        }

    }
}
