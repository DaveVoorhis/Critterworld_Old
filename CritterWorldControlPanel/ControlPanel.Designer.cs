namespace CritterWorldRunner
{
    partial class ControlPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.buttonStartCritterWorld = new System.Windows.Forms.Button();
            this.buttonStopCritterWorld = new System.Windows.Forms.Button();
            this.buttonStopAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxStopAll1 = new System.Windows.Forms.CheckBox();
            this.checkBoxStopAll2 = new System.Windows.Forms.CheckBox();
            this.checkBoxStopAll3 = new System.Windows.Forms.CheckBox();
            this.checkBoxStopAll4 = new System.Windows.Forms.CheckBox();
            this.checkBoxStop2 = new System.Windows.Forms.CheckBox();
            this.checkBoxStop1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStartCritterWorld
            // 
            this.buttonStartCritterWorld.Location = new System.Drawing.Point(26, 23);
            this.buttonStartCritterWorld.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonStartCritterWorld.Name = "buttonStartCritterWorld";
            this.buttonStartCritterWorld.Size = new System.Drawing.Size(518, 44);
            this.buttonStartCritterWorld.TabIndex = 0;
            this.buttonStartCritterWorld.Text = "Start CritterWorld";
            this.buttonStartCritterWorld.UseVisualStyleBackColor = true;
            this.buttonStartCritterWorld.Click += new System.EventHandler(this.buttonStartCritterWorld_Click);
            // 
            // buttonStopCritterWorld
            // 
            this.buttonStopCritterWorld.Enabled = false;
            this.buttonStopCritterWorld.Location = new System.Drawing.Point(24, 78);
            this.buttonStopCritterWorld.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonStopCritterWorld.Name = "buttonStopCritterWorld";
            this.buttonStopCritterWorld.Size = new System.Drawing.Size(520, 44);
            this.buttonStopCritterWorld.TabIndex = 1;
            this.buttonStopCritterWorld.Text = "Stop CritterWorld";
            this.buttonStopCritterWorld.UseVisualStyleBackColor = true;
            this.buttonStopCritterWorld.Click += new System.EventHandler(this.buttonStopCritterWorld_Click);
            // 
            // buttonStopAll
            // 
            this.buttonStopAll.Enabled = false;
            this.buttonStopAll.ForeColor = System.Drawing.Color.Red;
            this.buttonStopAll.Location = new System.Drawing.Point(24, 175);
            this.buttonStopAll.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonStopAll.Name = "buttonStopAll";
            this.buttonStopAll.Size = new System.Drawing.Size(520, 44);
            this.buttonStopAll.TabIndex = 2;
            this.buttonStopAll.Text = "Stop CritterWorld and Runner";
            this.buttonStopAll.UseVisualStyleBackColor = true;
            this.buttonStopAll.Click += new System.EventHandler(this.buttonStopAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unlock";
            // 
            // checkBoxStopAll1
            // 
            this.checkBoxStopAll1.AutoSize = true;
            this.checkBoxStopAll1.Location = new System.Drawing.Point(112, 223);
            this.checkBoxStopAll1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxStopAll1.Name = "checkBoxStopAll1";
            this.checkBoxStopAll1.Size = new System.Drawing.Size(28, 27);
            this.checkBoxStopAll1.TabIndex = 4;
            this.checkBoxStopAll1.UseVisualStyleBackColor = true;
            this.checkBoxStopAll1.CheckedChanged += new System.EventHandler(this.checkBoxStopAll_CheckedChanged);
            // 
            // checkBoxStopAll2
            // 
            this.checkBoxStopAll2.AutoSize = true;
            this.checkBoxStopAll2.Location = new System.Drawing.Point(154, 223);
            this.checkBoxStopAll2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxStopAll2.Name = "checkBoxStopAll2";
            this.checkBoxStopAll2.Size = new System.Drawing.Size(28, 27);
            this.checkBoxStopAll2.TabIndex = 5;
            this.checkBoxStopAll2.UseVisualStyleBackColor = true;
            this.checkBoxStopAll2.CheckedChanged += new System.EventHandler(this.checkBoxStopAll_CheckedChanged);
            // 
            // checkBoxStopAll3
            // 
            this.checkBoxStopAll3.AutoSize = true;
            this.checkBoxStopAll3.Location = new System.Drawing.Point(196, 223);
            this.checkBoxStopAll3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxStopAll3.Name = "checkBoxStopAll3";
            this.checkBoxStopAll3.Size = new System.Drawing.Size(28, 27);
            this.checkBoxStopAll3.TabIndex = 6;
            this.checkBoxStopAll3.UseVisualStyleBackColor = true;
            this.checkBoxStopAll3.CheckedChanged += new System.EventHandler(this.checkBoxStopAll_CheckedChanged);
            // 
            // checkBoxStopAll4
            // 
            this.checkBoxStopAll4.AutoSize = true;
            this.checkBoxStopAll4.Location = new System.Drawing.Point(238, 223);
            this.checkBoxStopAll4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxStopAll4.Name = "checkBoxStopAll4";
            this.checkBoxStopAll4.Size = new System.Drawing.Size(28, 27);
            this.checkBoxStopAll4.TabIndex = 7;
            this.checkBoxStopAll4.UseVisualStyleBackColor = true;
            this.checkBoxStopAll4.CheckedChanged += new System.EventHandler(this.checkBoxStopAll_CheckedChanged);
            // 
            // checkBoxStop2
            // 
            this.checkBoxStop2.AutoSize = true;
            this.checkBoxStop2.Location = new System.Drawing.Point(154, 127);
            this.checkBoxStop2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxStop2.Name = "checkBoxStop2";
            this.checkBoxStop2.Size = new System.Drawing.Size(28, 27);
            this.checkBoxStop2.TabIndex = 10;
            this.checkBoxStop2.UseVisualStyleBackColor = true;
            this.checkBoxStop2.CheckedChanged += new System.EventHandler(this.checkBoxStop_CheckedChanged);
            // 
            // checkBoxStop1
            // 
            this.checkBoxStop1.AutoSize = true;
            this.checkBoxStop1.Location = new System.Drawing.Point(112, 127);
            this.checkBoxStop1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxStop1.Name = "checkBoxStop1";
            this.checkBoxStop1.Size = new System.Drawing.Size(28, 27);
            this.checkBoxStop1.TabIndex = 9;
            this.checkBoxStop1.UseVisualStyleBackColor = true;
            this.checkBoxStop1.CheckedChanged += new System.EventHandler(this.checkBoxStop_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Unlock";
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 273);
            this.Controls.Add(this.checkBoxStop2);
            this.Controls.Add(this.checkBoxStop1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxStopAll4);
            this.Controls.Add(this.checkBoxStopAll3);
            this.Controls.Add(this.checkBoxStopAll2);
            this.Controls.Add(this.checkBoxStopAll1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStopAll);
            this.Controls.Add(this.buttonStopCritterWorld);
            this.Controls.Add(this.buttonStartCritterWorld);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlPanel";
            this.Text = "CritterWorld Control Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ControlPanel_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartCritterWorld;
        private System.Windows.Forms.Button buttonStopCritterWorld;
        private System.Windows.Forms.Button buttonStopAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxStopAll1;
        private System.Windows.Forms.CheckBox checkBoxStopAll2;
        private System.Windows.Forms.CheckBox checkBoxStopAll3;
        private System.Windows.Forms.CheckBox checkBoxStopAll4;
        private System.Windows.Forms.CheckBox checkBoxStop2;
        private System.Windows.Forms.CheckBox checkBoxStop1;
        private System.Windows.Forms.Label label2;
    }
}

