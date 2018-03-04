using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CritterWorldRunner
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            File.Delete("_up");
            File.Delete("_down");
            File.Delete("_quit");
            InitializeComponent();
        }

        private void resetLock()
        {
            checkBoxStop1.Checked = false;
            checkBoxStop2.Checked = false;
            checkBoxStopAll1.Checked = false;
            checkBoxStopAll2.Checked = false;
            checkBoxStopAll3.Checked = false;
            checkBoxStopAll4.Checked = false;
        }

        private void buttonStartCritterWorld_Click(object sender, EventArgs e)
        {
            File.Create("_up").Close();
            resetLock();
            string msg = "CritterWorld startup requested.  If it's already running, this has done nothing.";
            MessageBox.Show(null, msg, "CritterWorld", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonStopCritterWorld_Click(object sender, EventArgs e)
        {
            File.Create("_down").Close();
            resetLock();
            string msg = "CritterWorld shutdown requested.  If it's not running, this has done nothing.";
            MessageBox.Show(null, msg, "CritterWorld", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonStopAll_Click(object sender, EventArgs e)
        {
            File.Create("_quit").Close();
            resetLock();
            string msg = "CritterWorld and runner total shutdown requested.\nCritterWorld can now only be re-started from its host machine.";
            MessageBox.Show(null, msg, "CritterWorld", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void checkBoxStop_CheckedChanged(object sender, EventArgs e)
        {
            buttonStopCritterWorld.Enabled = (checkBoxStop1.Checked && checkBoxStop2.Checked);
        }

        private void checkBoxStopAll_CheckedChanged(object sender, EventArgs e)
        {
            buttonStopAll.Enabled = (checkBoxStopAll1.Checked &&
                                     checkBoxStopAll2.Checked &&
                                     checkBoxStopAll3.Checked &&
                                     checkBoxStopAll4.Checked);
        }

        private void ControlPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
