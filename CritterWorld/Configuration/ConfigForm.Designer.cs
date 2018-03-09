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
            this.labelFoodPerReplenishment = new System.Windows.Forms.Label();
            this.labelEnergyGainedPerFood = new System.Windows.Forms.Label();
            this.labelTimeTilFoodVanish = new System.Windows.Forms.Label();
            this.labelTimeTilPoopVanish = new System.Windows.Forms.Label();
            this.checkBoxAutoFood = new System.Windows.Forms.CheckBox();
            this.labelEnergyLostPerPoopStepped = new System.Windows.Forms.Label();
            this.labelInitialEnergy = new System.Windows.Forms.Label();
            this.labelBackground = new System.Windows.Forms.Label();
            this.textBoxFoodPerReplenish = new System.Windows.Forms.TextBox();
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
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFoodPerReplenishment
            // 
            this.labelFoodPerReplenishment.AutoSize = true;
            this.labelFoodPerReplenishment.Location = new System.Drawing.Point(28, 27);
            this.labelFoodPerReplenishment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFoodPerReplenishment.Name = "labelFoodPerReplenishment";
            this.labelFoodPerReplenishment.Size = new System.Drawing.Size(392, 25);
            this.labelFoodPerReplenishment.TabIndex = 0;
            this.labelFoodPerReplenishment.Text = "Food pieces created per replenishment:";
            // 
            // labelEnergyGainedPerFood
            // 
            this.labelEnergyGainedPerFood.AutoSize = true;
            this.labelEnergyGainedPerFood.Location = new System.Drawing.Point(28, 73);
            this.labelEnergyGainedPerFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnergyGainedPerFood.Name = "labelEnergyGainedPerFood";
            this.labelEnergyGainedPerFood.Size = new System.Drawing.Size(360, 25);
            this.labelEnergyGainedPerFood.TabIndex = 1;
            this.labelEnergyGainedPerFood.Text = "Energy gained per food piece eaten:";
            // 
            // labelTimeTilFoodVanish
            // 
            this.labelTimeTilFoodVanish.AutoSize = true;
            this.labelTimeTilFoodVanish.Location = new System.Drawing.Point(28, 210);
            this.labelTimeTilFoodVanish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimeTilFoodVanish.Name = "labelTimeTilFoodVanish";
            this.labelTimeTilFoodVanish.Size = new System.Drawing.Size(352, 25);
            this.labelTimeTilFoodVanish.TabIndex = 2;
            this.labelTimeTilFoodVanish.Text = "Time until food vanishes (seconds):";
            // 
            // labelTimeTilPoopVanish
            // 
            this.labelTimeTilPoopVanish.AutoSize = true;
            this.labelTimeTilPoopVanish.Location = new System.Drawing.Point(28, 258);
            this.labelTimeTilPoopVanish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimeTilPoopVanish.Name = "labelTimeTilPoopVanish";
            this.labelTimeTilPoopVanish.Size = new System.Drawing.Size(358, 25);
            this.labelTimeTilPoopVanish.TabIndex = 3;
            this.labelTimeTilPoopVanish.Text = "Time until poop vanishes (seconds):";
            // 
            // checkBoxAutoFood
            // 
            this.checkBoxAutoFood.AutoSize = true;
            this.checkBoxAutoFood.Location = new System.Drawing.Point(700, 21);
            this.checkBoxAutoFood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxAutoFood.Name = "checkBoxAutoFood";
            this.checkBoxAutoFood.Size = new System.Drawing.Size(320, 29);
            this.checkBoxAutoFood.TabIndex = 2;
            this.checkBoxAutoFood.Text = "Automatically replenish food.";
            this.checkBoxAutoFood.UseVisualStyleBackColor = true;
            // 
            // labelEnergyLostPerPoopStepped
            // 
            this.labelEnergyLostPerPoopStepped.AutoSize = true;
            this.labelEnergyLostPerPoopStepped.Location = new System.Drawing.Point(28, 119);
            this.labelEnergyLostPerPoopStepped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnergyLostPerPoopStepped.Name = "labelEnergyLostPerPoopStepped";
            this.labelEnergyLostPerPoopStepped.Size = new System.Drawing.Size(323, 25);
            this.labelEnergyLostPerPoopStepped.TabIndex = 5;
            this.labelEnergyLostPerPoopStepped.Text = "Energy lost per poop stepped in:";
            // 
            // labelInitialEnergy
            // 
            this.labelInitialEnergy.AutoSize = true;
            this.labelInitialEnergy.Location = new System.Drawing.Point(28, 163);
            this.labelInitialEnergy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInitialEnergy.Name = "labelInitialEnergy";
            this.labelInitialEnergy.Size = new System.Drawing.Size(212, 25);
            this.labelInitialEnergy.TabIndex = 6;
            this.labelInitialEnergy.Text = "Initial energy at birth:";
            // 
            // labelBackground
            // 
            this.labelBackground.AutoSize = true;
            this.labelBackground.Location = new System.Drawing.Point(28, 304);
            this.labelBackground.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(197, 25);
            this.labelBackground.TabIndex = 7;
            this.labelBackground.Text = "Background image:";
            // 
            // textBoxFoodPerReplenish
            // 
            this.textBoxFoodPerReplenish.Location = new System.Drawing.Point(428, 24);
            this.textBoxFoodPerReplenish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFoodPerReplenish.Name = "textBoxFoodPerReplenish";
            this.textBoxFoodPerReplenish.Size = new System.Drawing.Size(132, 31);
            this.textBoxFoodPerReplenish.TabIndex = 1;
            // 
            // textBoxEnergyPerFood
            // 
            this.textBoxEnergyPerFood.Location = new System.Drawing.Point(428, 70);
            this.textBoxEnergyPerFood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEnergyPerFood.Name = "textBoxEnergyPerFood";
            this.textBoxEnergyPerFood.Size = new System.Drawing.Size(132, 31);
            this.textBoxEnergyPerFood.TabIndex = 3;
            // 
            // textBoxEnergyPerPoop
            // 
            this.textBoxEnergyPerPoop.Location = new System.Drawing.Point(428, 116);
            this.textBoxEnergyPerPoop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEnergyPerPoop.Name = "textBoxEnergyPerPoop";
            this.textBoxEnergyPerPoop.Size = new System.Drawing.Size(132, 31);
            this.textBoxEnergyPerPoop.TabIndex = 4;
            // 
            // textBoxInitialEnergy
            // 
            this.textBoxInitialEnergy.Location = new System.Drawing.Point(428, 163);
            this.textBoxInitialEnergy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxInitialEnergy.Name = "textBoxInitialEnergy";
            this.textBoxInitialEnergy.Size = new System.Drawing.Size(132, 31);
            this.textBoxInitialEnergy.TabIndex = 5;
            // 
            // textBoxTimeToFoodVanish
            // 
            this.textBoxTimeToFoodVanish.Location = new System.Drawing.Point(428, 209);
            this.textBoxTimeToFoodVanish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTimeToFoodVanish.Name = "textBoxTimeToFoodVanish";
            this.textBoxTimeToFoodVanish.Size = new System.Drawing.Size(132, 31);
            this.textBoxTimeToFoodVanish.TabIndex = 6;
            // 
            // textBoxTimeToPoopVanish
            // 
            this.textBoxTimeToPoopVanish.Location = new System.Drawing.Point(428, 255);
            this.textBoxTimeToPoopVanish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.textBoxBackgroundImage.Location = new System.Drawing.Point(232, 300);
            this.textBoxBackgroundImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBackgroundImage.Name = "textBoxBackgroundImage";
            this.textBoxBackgroundImage.Size = new System.Drawing.Size(946, 31);
            this.textBoxBackgroundImage.TabIndex = 8;
            // 
            // openBackgroundImage
            // 
            this.openBackgroundImage.Location = new System.Drawing.Point(1184, 300);
            this.openBackgroundImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openBackgroundImage.Name = "openBackgroundImage";
            this.openBackgroundImage.Size = new System.Drawing.Size(44, 38);
            this.openBackgroundImage.TabIndex = 15;
            this.openBackgroundImage.Text = "?";
            this.openBackgroundImage.UseVisualStyleBackColor = true;
            this.openBackgroundImage.Click += new System.EventHandler(this.openBackgroundImage_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(38, 365);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(96, 58);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(140, 365);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 58);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(1024, 373);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(204, 58);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "Reset to Defaults";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 452);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.openBackgroundImage);
            this.Controls.Add(this.textBoxBackgroundImage);
            this.Controls.Add(this.textBoxTimeToPoopVanish);
            this.Controls.Add(this.textBoxTimeToFoodVanish);
            this.Controls.Add(this.textBoxInitialEnergy);
            this.Controls.Add(this.textBoxEnergyPerPoop);
            this.Controls.Add(this.textBoxEnergyPerFood);
            this.Controls.Add(this.textBoxFoodPerReplenish);
            this.Controls.Add(this.labelBackground);
            this.Controls.Add(this.labelInitialEnergy);
            this.Controls.Add(this.labelEnergyLostPerPoopStepped);
            this.Controls.Add(this.checkBoxAutoFood);
            this.Controls.Add(this.labelTimeTilPoopVanish);
            this.Controls.Add(this.labelTimeTilFoodVanish);
            this.Controls.Add(this.labelEnergyGainedPerFood);
            this.Controls.Add(this.labelFoodPerReplenishment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.Text = "Configuration";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ConfigForm_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFoodPerReplenishment;
        private System.Windows.Forms.Label labelEnergyGainedPerFood;
        private System.Windows.Forms.Label labelTimeTilFoodVanish;
        private System.Windows.Forms.Label labelTimeTilPoopVanish;
        private System.Windows.Forms.CheckBox checkBoxAutoFood;
        private System.Windows.Forms.Label labelEnergyLostPerPoopStepped;
        private System.Windows.Forms.Label labelInitialEnergy;
        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.TextBox textBoxFoodPerReplenish;
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
        private System.Windows.Forms.Button buttonReset;
    }
}