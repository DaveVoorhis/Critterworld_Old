using System;
using System.Threading;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Sprites;

namespace CritterWorld
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class SpriteDemo : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.HScrollBar ScaleScroll;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer fpsTimer;
		private System.Windows.Forms.Label Frame;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.HScrollBar fpsScroll;
		private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
		private System.ComponentModel.IContainer components;

        private Button upBtn;
        private Button downBtn;
        private Button button5;
        private Button leftBtn;
        private Button btnRight;
        private Label label6;
        private Button resetBtn;

        // create "world"
        private SpriteEnvironment myWorld;

		public SpriteDemo()
		{
            AnimationFramesInOneFile donutFrames = new AnimationFramesInOneFile("donutcels.gif");
            AnimationFramesInMultipleFiles roboFrames = new AnimationFramesInMultipleFiles(new string[] { "Robo0_01.png", "Robo0_02.png" });

			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// create environment
			myWorld = new SpriteEnvironment(pictureBox1);
            // animated
            Sprite0 = new Sprite(new SpriteImageOneFile(donutFrames), new Point(20, 60), 30, true);
            myWorld.AddSprite(Sprite0);
            // also animated
            Sprite1 = new Sprite(new SpriteImageMultipleFiles(roboFrames), new Point(175, 60), 2, true);
            myWorld.AddSprite(Sprite1);
            // static
            Sprite2 = new Sprite(new SpriteImageOneFile(donutFrames), new Point(80, 50));
            myWorld.AddSprite(Sprite2);
            // static
            Sprite3 = new Sprite(new SpriteImageOneFile(donutFrames), new Point(70, 80));
            myWorld.AddSprite(Sprite3);
            // animated
            Sprite4 = new Sprite(new SpriteImageOneFile(donutFrames), new Point(100, 70), 30, true);
            myWorld.AddSprite(Sprite4);

            // start updating FPS monitor
            fpsTimer.Start();

            // show some numbers
            textBox3.Text = Convert.ToString(Sprite1.Image.FPS);
            textBox1.Text = Convert.ToString(Sprite2.Image.FrameNumber);
        }

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if (disposing)
			{
                myWorld.Shutdown();
                if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.HScrollBar velocityScrollBar;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ScaleScroll = new System.Windows.Forms.HScrollBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.fpsTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fpsScroll = new System.Windows.Forms.HScrollBar();
            this.Frame = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.upBtn = new System.Windows.Forms.Button();
            this.downBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.leftBtn = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            velocityScrollBar = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // velocityScrollBar
            // 
            velocityScrollBar.LargeChange = 1;
            velocityScrollBar.Location = new System.Drawing.Point(374, 228);
            velocityScrollBar.Maximum = 10;
            velocityScrollBar.Name = "velocityScrollBar";
            velocityScrollBar.Size = new System.Drawing.Size(177, 29);
            velocityScrollBar.TabIndex = 24;
            velocityScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.velocityScrollBar_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Next";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Prev";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(29, 22);
            this.textBox1.TabIndex = 7;
            // 
            // ScaleScroll
            // 
            this.ScaleScroll.LargeChange = 20;
            this.ScaleScroll.Location = new System.Drawing.Point(36, 318);
            this.ScaleScroll.Maximum = 1500;
            this.ScaleScroll.Minimum = 10;
            this.ScaleScroll.Name = "ScaleScroll";
            this.ScaleScroll.Size = new System.Drawing.Size(106, 29);
            this.ScaleScroll.TabIndex = 8;
            this.ScaleScroll.Value = 100;
            this.ScaleScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScaleScroll_Scroll);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(374, 324);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 22);
            this.textBox2.TabIndex = 9;
            // 
            // FPStimer
            // 
            this.fpsTimer.Enabled = true;
            this.fpsTimer.Interval = 500;
            this.fpsTimer.Tick += new System.EventHandler(this.FPStimer_Tick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(372, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "CPU fps";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(442, 324);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(38, 22);
            this.textBox3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(432, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sprite fps";
            // 
            // FPSScroll
            // 
            this.fpsScroll.LargeChange = 30;
            this.fpsScroll.Location = new System.Drawing.Point(374, 381);
            this.fpsScroll.Maximum = 330;
            this.fpsScroll.Minimum = 1;
            this.fpsScroll.Name = "FPSScroll";
            this.fpsScroll.Size = new System.Drawing.Size(106, 27);
            this.fpsScroll.TabIndex = 13;
            this.fpsScroll.Value = 100;
            this.fpsScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FPSScroll_Scroll);
            // 
            // Frame
            // 
            this.Frame.Location = new System.Drawing.Point(161, 301);
            this.Frame.Name = "Frame";
            this.Frame.Size = new System.Drawing.Size(48, 17);
            this.Frame.TabIndex = 14;
            this.Frame.Text = "Frame";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(32, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Scale";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(366, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sprite (apparent) fps";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(32, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 28);
            this.label5.TabIndex = 20;
            this.label5.Text = "Viewport";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.BackgroundImage = global::TestApp.Properties.Resources.Back;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(36, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // upBtn
            // 
            this.upBtn.Location = new System.Drawing.Point(436, 88);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(54, 26);
            this.upBtn.TabIndex = 21;
            this.upBtn.Text = "Up";
            this.upBtn.UseVisualStyleBackColor = true;
            this.upBtn.Click += new System.EventHandler(this.upBtn_Click);
            // 
            // downBtn
            // 
            this.downBtn.Location = new System.Drawing.Point(436, 155);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(54, 26);
            this.downBtn.TabIndex = 22;
            this.downBtn.Text = "Down";
            this.downBtn.UseVisualStyleBackColor = true;
            this.downBtn.Click += new System.EventHandler(this.downBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(436, 121);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 27);
            this.button5.TabIndex = 23;
            this.button5.Text = "Stop";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(371, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Velocity";
            // 
            // leftBtn
            // 
            this.leftBtn.Location = new System.Drawing.Point(374, 121);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(54, 27);
            this.leftBtn.TabIndex = 26;
            this.leftBtn.Text = "Left";
            this.leftBtn.UseVisualStyleBackColor = true;
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(497, 121);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(54, 27);
            this.btnRight.TabIndex = 27;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(436, 188);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(54, 27);
            this.resetBtn.TabIndex = 28;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(587, 442);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.leftBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(velocityScrollBar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.downBtn);
            this.Controls.Add(this.upBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Frame);
            this.Controls.Add(this.fpsScroll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ScaleScroll);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.Run(new SpriteDemo());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
            Sprite2.Image.FrameNumber++;
            myWorld.RequestRendering(Sprite2);
            Sprite3.Image.FrameNumber++;
            myWorld.RequestRendering(Sprite3);
			textBox1.Text=Convert.ToString(Sprite2.Image.FrameNumber);
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
            Sprite2.Image.FrameNumber--;
            myWorld.RequestRendering(Sprite2);
            Sprite3.Image.FrameNumber--;
            myWorld.RequestRendering(Sprite3);
			textBox1.Text=Convert.ToString(Sprite2.Image.FrameNumber);	
		}
		
		private void ScaleScroll_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
            myWorld.Resize(Sprite0, Convert.ToDouble(e.NewValue) / 100.0);
		}

        private Sprite Sprite0;
        private Sprite Sprite1;
        private Sprite Sprite2;
        private Sprite Sprite3;
        private Sprite Sprite4;

		private void FPStimer_Tick(object sender, System.EventArgs e)
		{
			// show new FPS
			textBox2.Text=Convert.ToString(myWorld.GetSystemFPS());
		}

		private void FPSScroll_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			// we will adjust fps of Sprite1 with this
			Sprite1.Image.FPS = e.NewValue;
			textBox3.Text=Convert.ToString(Sprite1.Image.FPS);
		}

        private void upBtn_Click(object sender, EventArgs e)
        {
            Sprite1.IsMoving = true;
            Sprite1.Direction = 0;
        }

        private void downBtn_Click(object sender, EventArgs e)
        {
            Sprite1.IsMoving = true;
            Sprite1.Direction = 180;
        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            Sprite1.IsMoving = true;
            Sprite1.Direction = 270;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            Sprite1.IsMoving = true;
            Sprite1.Direction = 90;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            Sprite1.IsMoving = false;
        }

        private void velocityScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Sprite1.Velocity = e.NewValue;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            myWorld.Move(Sprite1, new Point(175, 60));
        }
        
	}
}
