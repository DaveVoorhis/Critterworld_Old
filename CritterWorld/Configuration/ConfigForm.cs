using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CritterWorld
{
    public partial class ConfigForm : Form
    {
        Configuration configuration;

        public ConfigForm(Configuration configuration)
        {
            this.configuration = configuration;
            InitializeComponent();
            SetupWidgets();
        }

        private void SetupWidgets()
        {
            textBoxFoodPerReplenish.Text = configuration.FoodDumps.ToString();
            checkBoxAutoFood.Checked = configuration.AutoNewFoodDump;
            textBoxEnergyPerFood.Text = configuration.CritterEnergyPerFeed.ToString();
            textBoxEnergyPerPoop.Text = configuration.CritterEnergyPerDefilement.ToString();
            textBoxInitialEnergy.Text = configuration.CritterEnergyWhenBorn.ToString();
            textBoxTimeToFoodVanish.Text = configuration.FoodDecayTime.ToString();
            textBoxTimeToPoopVanish.Text = configuration.PoopEvaporateTime.ToString();
            textBoxBackgroundImage.Text = configuration.WorldFileName;
        }

        private void openBackgroundImage_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Open Background Image";
            openFileDialog.Filter = "PNG Files|*.png|JPEG Files|*.jpg|All Files|*.*";
            openFileDialog.FileName = textBoxBackgroundImage.Text;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                textBoxBackgroundImage.Text = openFileDialog.FileName;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                configuration.FoodDumps = int.Parse(textBoxFoodPerReplenish.Text);
                configuration.AutoNewFoodDump = checkBoxAutoFood.Checked;
                configuration.CritterEnergyPerFeed = int.Parse(textBoxEnergyPerFood.Text);
                configuration.CritterEnergyPerDefilement = int.Parse(textBoxEnergyPerPoop.Text);
                configuration.CritterEnergyWhenBorn = int.Parse(textBoxInitialEnergy.Text);
                configuration.FoodDecayTime = int.Parse(textBoxTimeToFoodVanish.Text);
                configuration.PoopEvaporateTime = int.Parse(textBoxTimeToPoopVanish.Text);
                configuration.WorldFileName = textBoxBackgroundImage.Text;
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Unable to update configuration due to error: " + exception.Message,
                    "Configuration Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            configuration.ResetToBuiltInDefaults();
            SetupWidgets();
        }

        private void ConfigForm_Closing(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
