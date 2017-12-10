using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGSMIS
{
    public partial class frmMain : Form
    {

        #region Form objects
        frmSubcontractors _frmSubContractors;
        frmVehicles _frmVehicles;
        frmDrivers _frmDrivers;
        #endregion

        public frmMain()
        {
            InitializeComponent();
        }

        private void subcontractorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmSubcontractors.InstanceCount == 0)
            {
                this._frmSubContractors = new frmSubcontractors();
                this._frmSubContractors.MdiParent = this;
                this._frmSubContractors.WindowState = FormWindowState.Maximized;
                this._frmSubContractors.Text = "Subcontractors";
                this._frmSubContractors.Show();
            }
            else
            {
                this._frmSubContractors.BringToFront();

            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmVehicles.InstanceCount == 0)
            {
                this._frmVehicles = new frmVehicles();
                this._frmVehicles.MdiParent = this;
                this._frmVehicles.Show();

            }
            else
            {
                this._frmVehicles.BringToFront();

            }
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under construction", "Feature Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)== DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under construction", "Feature Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void sitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under construction", "Feature Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Under construction", "Feature Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if(frmDrivers.InstanceCount==0)
            {
                this._frmDrivers = new frmDrivers();
                this._frmDrivers.MdiParent = this;
                this._frmDrivers.Show();
            }
            else
            {
                this._frmDrivers.BringToFront();

            }
        }

        private void operationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under construction", "Feature Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}

