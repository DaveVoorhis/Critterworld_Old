using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCritter
{
    public partial class DemoCritterBrain1ConfigForm : Form
    {
        DemoCritterBrain1 brain;

        public DemoCritterBrain1ConfigForm(DemoCritterBrain1 brain)
        {
            this.brain = brain;
            InitializeComponent();
            textBoxSpeed.Text = brain.Speed.ToString();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxSpeed.Text, out int speed))
            {
                MessageBox.Show("Speed must be a whole number.", "Edit Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    brain.Speed = speed;
                    brain.SaveConfiguration();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to set speed: " + ex.Message, "Edit Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DemoCritterBrain1ConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
