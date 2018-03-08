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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food pieces created per replenishment:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Energy gained per food piece eaten:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time until food vanishes (seconds):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time until poop vanishes (seconds):";
            // 
            // checkBoxAutoFood
            // 
            this.checkBoxAutoFood.AutoSize = true;
            this.checkBoxAutoFood.Location = new System.Drawing.Point(350, 11);
            this.checkBoxAutoFood.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAutoFood.Name = "checkBoxAutoFood";
            this.checkBoxAutoFood.Size = new System.Drawing.Size(160, 17);
            this.checkBoxAutoFood.TabIndex = 2;
            this.checkBoxAutoFood.Text = "Automatically replenish food.";
            this.checkBoxAutoFood.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Energy lost per poop stepped in:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Initial energy at birth:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Background image:";
            // 
            // textBoxFoodPerReplenish
            // 
            this.textBoxFoodPerReplenish.Location = new System.Drawing.Point(206, 12);
            this.textBoxFoodPerReplenish.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFoodPerReplenish.Name = "textBoxFoodPerReplenish";
            this.textBoxFoodPerReplenish.Size = new System.Drawing.Size(68, 20);
            this.textBoxFoodPerReplenish.TabIndex = 1;
            // 
            // textBoxEnergyPerFood
            // 
            this.textBoxEnergyPerFood.Location = new System.Drawing.Point(206, 36);
            this.textBoxEnergyPerFood.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEnergyPerFood.Name = "textBoxEnergyPerFood";
            this.textBoxEnergyPerFood.Size = new System.Drawing.Size(68, 20);
            this.textBoxEnergyPerFood.TabIndex = 3;
            // 
            // textBoxEnergyPerPoop
            // 
            this.textBoxEnergyPerPoop.Location = new System.Drawing.Point(206, 60);
            this.textBoxEnergyPerPoop.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEnergyPerPoop.Name = "textBoxEnergyPerPoop";
            this.textBoxEnergyPerPoop.Size = new System.Drawing.Size(68, 20);
            this.textBoxEnergyPerPoop.TabIndex = 4;
            // 
            // textBoxInitialEnergy
            // 
            this.textBoxInitialEnergy.Location = new System.Drawing.Point(206, 84);
            this.textBoxInitialEnergy.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxInitialEnergy.Name = "textBoxInitialEnergy";
            this.textBoxInitialEnergy.Size = new System.Drawing.Size(68, 20);
            this.textBoxInitialEnergy.TabIndex = 5;
            // 
            // textBoxTimeToFoodVanish
            // 
            this.textBoxTimeToFoodVanish.Location = new System.Drawing.Point(206, 108);
            this.textBoxTimeToFoodVanish.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTimeToFoodVanish.Name = "textBoxTimeToFoodVanish";
            this.textBoxTimeToFoodVanish.Size = new System.Drawing.Size(68, 20);
            this.textBoxTimeToFoodVanish.TabIndex = 6;
            // 
            // textBoxTimeToPoopVanish
            // 
            this.textBoxTimeToPoopVanish.Location = new System.Drawing.Point(206, 132);
            this.textBoxTimeToPoopVanish.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTimeToPoopVanish.Name = "textBoxTimeToPoopVanish";
            this.textBoxTimeToPoopVanish.Size = new System.Drawing.Size(68, 20);
            this.textBoxTimeToPoopVanish.TabIndex = 7;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // textBoxBackgroundImage
            // 
            this.textBoxBackgroundImage.Location = new System.Drawing.Point(116, 156);
            this.textBoxBackgroundImage.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBackgroundImage.Name = "textBoxBackgroundImage";
            this.textBoxBackgroundImage.Size = new System.Drawing.Size(475, 20);
            this.textBoxBackgroundImage.TabIndex = 8;
            // 
            // openBackgroundImage
            // 
            this.openBackgroundImage.Location = new System.Drawing.Point(592, 156);
            this.openBackgroundImage.Margin = new System.Windows.Forms.Padding(2);
            this.openBackgroundImage.Name = "openBackgroundImage";
            this.openBackgroundImage.Size = new System.Drawing.Size(22, 20);
            this.openBackgroundImage.TabIndex = 15;
            this.openBackgroundImage.Text = "?";
            this.openBackgroundImage.UseVisualStyleBackColor = true;
            this.openBackgroundImage.Click += new System.EventHandler(this.openBackgroundImage_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(19, 190);
            this.okButton.Margin = new System.Windows.Forms.Padding(2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(48, 30);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(70, 190);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(48, 30);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(512, 194);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(102, 30);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "Reset to Defaults";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 235);
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
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxAutoFood);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.Text = "Configuration";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ConfigForm_Closing);
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