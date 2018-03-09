using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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
            textBoxBrainDLLDirectory.Text = configuration.BrainDLLPath;
        }

        private void openBackgroundImage_Click(object sender, EventArgs e)
        {
            openBackgroundFileDialog.Title = "Open Background Image";
            openBackgroundFileDialog.Filter = "PNG Files|*.png|JPEG Files|*.jpg|All Files|*.*";
            openBackgroundFileDialog.FileName = textBoxBackgroundImage.Text;
            if (openBackgroundFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxBackgroundImage.Text = openBackgroundFileDialog.FileName;
            }
        }

        private void buttonBrainDLLDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "Critter Brain DLL Directory";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxBrainDLLDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private int AttemptStringToInt(string text, string identification)
        {
            int value;
            if (int.TryParse(text, out value))
            {
                return value;
            }
            throw new Exception(identification + " Value must be a number.");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                configuration.FoodDumps = AttemptStringToInt(textBoxFoodPerReplenish.Text, labelFoodPerReplenishment.Text);
                configuration.AutoNewFoodDump = checkBoxAutoFood.Checked;
                configuration.CritterEnergyPerFeed = AttemptStringToInt(textBoxEnergyPerFood.Text, labelEnergyGainedPerFood.Text);
                configuration.CritterEnergyPerDefilement = AttemptStringToInt(textBoxEnergyPerPoop.Text, labelEnergyLostPerPoopStepped.Text);
                configuration.CritterEnergyWhenBorn = AttemptStringToInt(textBoxInitialEnergy.Text, labelInitialEnergy.Text);
                configuration.FoodDecayTime = AttemptStringToInt(textBoxTimeToFoodVanish.Text, labelTimeTilFoodVanish.Text);
                configuration.PoopEvaporateTime = AttemptStringToInt(textBoxTimeToPoopVanish.Text, labelTimeTilPoopVanish.Text);
                configuration.WorldFileName = textBoxBackgroundImage.Text;
                configuration.BrainDLLPath = textBoxBrainDLLDirectory.Text;
                Utility.SaveConfiguration();
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
