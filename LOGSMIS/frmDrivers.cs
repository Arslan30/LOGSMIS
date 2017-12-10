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
    public partial class frmDrivers : Form
    {
        OperationModesEnum _operationMode;
        DSLOGS.DriversRow _editDriver;

        public static int InstanceCount { get; private set; }

        public frmDrivers()
        {
            InitializeComponent();

            InstanceCount++;
        }

        private void frmDrivers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSLOGS.Drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.dSLOGS.Drivers);
            this._operationMode = OperationModesEnum.None;
            this.panel1.Enabled = false;
            this.lblCaption.Text = this.Text;
            this.RetrieveData();

        }

        private void RetrieveData()
        {
            // TODO: This line of code loads data into the 'dSLOGS.Drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.dSLOGS.Drivers);

        }

        private void ClearControls()
        {
            this.txtDriverName.Text = "";
            this.txtPhone1.Text = "";
            this.txtPhone2.Text = "";

        }

        private void RetrieveDriver()
        {
            this.txtDriverName.Text = this._editDriver.IsDriver_NameNull() ? "" : this._editDriver.Driver_Name;
            this.txtPhone1.Text = this._editDriver.IsPhone_1Null() ? "" : this._editDriver.Phone_1;
            this.txtPhone2.Text = this._editDriver.IsPhone_2Null() ? "" : this._editDriver.Phone_2;

        }

        private void panel1_EnabledChanged(object sender, EventArgs e)
        {
            this.btnAddNew.Enabled = !this.panel1.Enabled;
            this.btnEdit.Enabled = this.btnAddNew.Enabled;
            this.btnSave.Enabled = !this.btnAddNew.Enabled;
            this.btnCancel.Enabled = this.btnSave.Enabled;
            this.dgvDrivers.Enabled = this.btnAddNew.Enabled;

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this._operationMode = OperationModesEnum.AddNew;
            this.panel1.Enabled = true;
            this.txtDriverName.Focus();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvDrivers.CurrentRow == null)
                return;
            this._editDriver =
                this.dSLOGS.Drivers.Select(this.dSLOGS.Drivers.Driver_IDColumn.ColumnName
                + "=" + this.dgvDrivers.CurrentRow.Cells[0].Value)[0] as DSLOGS.DriversRow;
            this._operationMode = OperationModesEnum.Edit;
            this.RetrieveDriver();
            this.panel1.Enabled = true;
            this.txtDriverName.Focus();
            this.txtDriverName.SelectAll();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                if (this.txtDriverName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Driver's name", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                this.txtDriverName.Focus();
                return;
            }
            decimal? id = this._operationMode == OperationModesEnum.AddNew ? 0 : this._editDriver.Driver_ID;
            string name = this.txtDriverName.Text.Trim();

            DSLOGS.DriversDataTable dtDuplicateDrivers = this.driversTableAdapter.GetDataByNameByNotID(id, name);
            if (dtDuplicateDrivers.Rows.Count > 0)
            {
                MessageBox.Show($"Driver with name {name} already exists. Please enter a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtDriverName.Focus();
                return;
            }

            if (this._operationMode == OperationModesEnum.AddNew)
            {
                int x = this.driversTableAdapter.Insert(ref id, name, this.txtCNIC.Text.Trim(), this.txtPhone1.Text.Trim(), this.txtPhone2.Text.Trim());
                if (x == 1)
                {
                    MessageBox.Show("Driver data saved successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ClearControls();

                    this._operationMode = OperationModesEnum.None;
                    this.panel1.Enabled = false;
                    this.RetrieveData();
                    this.btnAddNew.Focus();

                }
            }
            else if (this._operationMode == OperationModesEnum.Edit)
            {
                int x = this.driversTableAdapter.Update(name, this.txtCNIC.Text.Trim(), this.txtPhone1.Text.Trim(), this.txtPhone2.Text.Trim()
                    , this._editDriver.Active, id);
                if (x == 1)
                {
                    MessageBox.Show("Driver data updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ClearControls();

                    this._editDriver = null;
                    this._operationMode = OperationModesEnum.None;
                    this.panel1.Enabled = false;
                    this.RetrieveData();
                    this.btnAddNew.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this._editDriver = null;
            this._operationMode = OperationModesEnum.None;
            this.panel1.Enabled = false;
            this.btnAddNew.Focus();

        }

        private void dgvDrivers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                this.btnEdit_Click(sender, System.EventArgs.Empty);

        }
    }
}
