namespace CritterWorld
{
    partial class ConfigForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxAutoFood = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFoodPerGrowth = new System.Windows.Forms.TextBox();
            this.textBoxEnergyPerFood = new System.Windows.Forms.TextBox();
            this.textBoxEnergyPerPoop = new System.Windows.Forms.TextBox();
            this.textBoxInitialEnergy = new System.Windows.Forms.TextBox();
            this.textBoxTimeToFoodVanish = new System.Windows.Forms.TextBox();
            this.textBoxTimeToPoopVanish = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxBackgroundImage = new System.Windows.Forms.TextBox();
            this.openBackgroundImage = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food pieces created per growth cycle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Energy gained per food piece eaten:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time until food vanishes (seconds):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(358, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time until poop vanishes (seconds):";
            // 
            // checkBoxAutoFood
            // 
            this.checkBoxAutoFood.AutoSize = true;
            this.checkBoxAutoFood.Location = new System.Drawing.Point(699, 22);
            this.checkBoxAutoFood.Name = "checkBoxAutoFood";
            this.checkBoxAutoFood.Size = new System.Drawing.Size(337, 29);
            this.checkBoxAutoFood.TabIndex = 2;
            this.checkBoxAutoFood.Text = "Automatically create new food.";
            this.checkBoxAutoFood.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Energy lost per poop stepped in:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Initial energy at birth:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Background image:";
            // 
            // textBoxFoodPerGrowth
            // 
            this.textBoxFoodPerGrowth.Location = new System.Drawing.Point(411, 23);
            this.textBoxFoodPerGrowth.Name = "textBoxFoodPerGrowth";
            this.textBoxFoodPerGrowth.Size = new System.Drawing.Size(132, 31);
            this.textBoxFoodPerGrowth.TabIndex = 1;
            // 
            // textBoxEnergyPerFood
            // 
            this.textBoxEnergyPerFood.Location = new System.Drawing.Point(411, 60);
            this.textBoxEnergyPerFood.Name = "textBoxEnergyPerFood";
            this.textBoxEnergyPerFood.Size = new System.Drawing.Size(132, 31);
            this.textBoxEnergyPerFood.TabIndex = 3;
            // 
            // textBoxEnergyPerPoop
            // 
            this.textBoxEnergyPerPoop.Location = new System.Drawing.Point(411, 97);
            this.textBoxEnergyPerPoop.Name = "textBoxEnergyPerPoop";
            this.textBoxEnergyPerPoop.Size = new System.Drawing.Size(132, 31);
            this.textBoxEnergyPerPoop.TabIndex = 4;
            // 
            // textBoxInitialEnergy
            // 
            this.textBoxInitialEnergy.Location = new System.Drawing.Point(411, 134);
            this.textBoxInitialEnergy.Name = "textBoxInitialEnergy";
            this.textBoxInitialEnergy.Size = new System.Drawing.Size(132, 31);
            this.textBoxInitialEnergy.TabIndex = 5;
            // 
            // textBoxTimeToFoodVanish
            // 
            this.textBoxTimeToFoodVanish.Location = new System.Drawing.Point(411, 171);
            this.textBoxTimeToFoodVanish.Name = "textBoxTimeToFoodVanish";
            this.textBoxTimeToFoodVanish.Size = new System.Drawing.Size(132, 31);
            this.textBoxTimeToFoodVanish.TabIndex = 6;
            // 
            // textBoxTimeToPoopVanish
            // 
            this.textBoxTimeToPoopVanish.Location = new System.Drawing.Point(411, 208);
            this.textBoxTimeToPoopVanish.Name = "textBoxTimeToPoopVanish";
            this.textBoxTimeToPoopVanish.Size = new System.Drawing.Size(132, 31);
            this.textBoxTimeToPoopVanish.TabIndex = 7;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // textBoxBackgroundImage
            // 
            this.textBoxBackgroundImage.Location = new System.Drawing.Point(231, 245);
            this.textBoxBackgroundImage.Name = "textBoxBackgroundImage";
            this.textBoxBackgroundImage.Size = new System.Drawing.Size(946, 31);
            this.textBoxBackgroundImage.TabIndex = 8;
            // 
            // openBackgroundImage
            // 
            this.openBackgroundImage.Location = new System.Drawing.Point(1183, 245);
            this.openBackgroundImage.Name = "openBackgroundImage";
            this.openBackgroundImage.Size = new System.Drawing.Size(36, 31);
            this.openBackgroundImage.TabIndex = 15;
            this.openBackgroundImage.Text = "?";
            this.openBackgroundImage.UseVisualStyleBackColor = true;
            this.openBackgroundImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(42, 304);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(96, 57);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(144, 304);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 57);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 405);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.openBackgroundImage);
            this.Controls.Add(this.textBoxBackgroundImage);
            this.Controls.Add(this.textBoxTimeToPoopVanish);
            this.Controls.Add(this.textBoxTimeToFoodVanish);
            this.Controls.Add(this.textBoxInitialEnergy);
            this.Controls.Add(this.textBoxEnergyPerPoop);
            this.Controls.Add(this.textBoxEnergyPerFood);
            this.Controls.Add(this.textBoxFoodPerGrowth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxAutoFood);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxAutoFood;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFoodPerGrowth;
        private System.Windows.Forms.TextBox textBoxEnergyPerFood;
        private System.Windows.Forms.TextBox textBoxEnergyPerPoop;
        private System.Windows.Forms.TextBox textBoxInitialEnergy;
        private System.Windows.Forms.TextBox textBoxTimeToFoodVanish;
        private System.Windows.Forms.TextBox textBoxTimeToPoopVanish;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBoxBackgroundImage;
        private System.Windows.Forms.Button openBackgroundImage;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}