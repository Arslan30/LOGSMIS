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
    public partial class frmVehicles : Form
    {
        OperationModesEnum _operationMode;
        DSLOGS.VehiclesRow _editVehicle;

        public static int InstanceCount { get; private set; }

        public frmVehicles()
        {
            InitializeComponent();
            InstanceCount++;
        }

        private void frmVehicles_Load(object sender, EventArgs e)
        {
            this._operationMode = OperationModesEnum.None;
            this.panel1.Enabled = false;
            this.lblCaption.Text = this.Text;
            this.RetrieveData();



        }

        private void RetrieveData()
        {
            this.subcontractorsTableAdapter.Fill(this.dSLOGS.Subcontractors);
            // TODO: This line of code loads data into the 'dSLOGS.VehicleTypesDistinct' table. You can move, or remove it, as needed.
            this.vehicleTypesDistinctTableAdapter.Fill(this.dSLOGS.VehicleTypesDistinct);
            this.driversTableAdapter.Fill(this.dSLOGS.Drivers);

            // TODO: This line of code loads data into the 'dSLOGS.Vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter.Fill(this.dSLOGS.Vehicles);

            //// TODO: This line of code loads data into the 'dSLOGS.Drivers' table. You can move, or remove it, as needed.
            //this.driversTableAdapter.Fill(this.dSLOGS.Drivers);
        }

        private void ClearControls()
        {
            this.cmbSubcontractors.SelectedIndex = -1;
            this.txtRegnNo.Text = "";
            this.cmbVehicleType.SelectedIndex = -1;
            this.cmbVehicleType.Text = "";
            this.cmbSubcontractors.SelectedIndex = this.cmbSubcontractors.Items.Count == 0 ? -1 : 0;
            this.cmbDrivers.SelectedIndex = this.cmbDrivers.Items.Count == 0 ? -1 : 0;



        }

        private void RetrieveVehicle()
        {
            this.cmbSubcontractors.SelectedValue = this._editVehicle.Current_Subcontractor_ID;

            this.txtRegnNo.Text = this._editVehicle.IsRegistration_NoNull() ? "" : this._editVehicle.Registration_No;
            this.cmbVehicleType.Text = this._editVehicle.IsVehicle_TypeNull() ? "" : this._editVehicle.Vehicle_Type;
            

        }

        private void panel1_EnabledChanged(object sender, EventArgs e)
        {
            this.btnAddNew.Enabled = !this.panel1.Enabled;
            this.btnEdit.Enabled = this.btnAddNew.Enabled;
            this.btnSave.Enabled = !this.btnAddNew.Enabled;
            this.btnCancel.Enabled = this.btnSave.Enabled;
            this.dgvVehicles.Enabled = this.btnAddNew.Enabled;

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this._operationMode = OperationModesEnum.AddNew;
            this.panel1.Enabled = true;

            this.cmbSubcontractors.Focus();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvVehicles.CurrentRow == null)
                return;
            this.btnSubcintractorChange.Enabled = true;
            this.btnDriverChange.Enabled = this.btnSubcintractorChange.Enabled;

            this._editVehicle =
                this.dSLOGS.Vehicles.Select(this.dSLOGS.Vehicles.Vehicle_IDColumn.ColumnName
                + "='" + this.dgvVehicles.CurrentRow.Cells[0].Value + "'"
                )[0] as DSLOGS.VehiclesRow;
            this._operationMode = OperationModesEnum.Edit;
            this.RetrieveVehicle();
            this.panel1.Enabled = true;
            this.btnSubcintractorChange.Enabled = true;
            this.btnDriverChange.Enabled = this.btnSubcintractorChange.Enabled;
            

            this.cmbSubcontractors.Focus();
            //this.txtSubcontractorName.SelectAll();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtRegnNo.Text.Trim() == "")
            {
                MessageBox.Show("Please enter registration number", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                this.txtRegnNo.Focus();
                return;
            }

            if (this.cmbSubcontractors.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a subcontractor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.cmbSubcontractors.Focus();
                return;

            }

            if (this.chkDriver.Checked && this.cmbDrivers.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a driver", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.cmbDrivers.Focus();
                return;

            }


            decimal? id = this._operationMode == OperationModesEnum.AddNew ? 0 : this._editVehicle.Vehicle_ID;
            string name = this.txtRegnNo.Text.Trim();

            System.Data.SqlClient.SqlTransaction trans=null;
            System.Data.SqlClient.SqlConnection con = this.vehiclesTableAdapter.Connection;
            if (con.State != ConnectionState.Open) con.Open();
            trans = con.BeginTransaction();

            this.vehiclesTableAdapter.Transaction= trans;
            
            DSLOGS.VehiclesDataTable dtDuplicateVehicles = this.vehiclesTableAdapter.GetDataByRegistrationNoByNotVehicleID(id, name);
            if(dtDuplicateVehicles.Rows.Count>0)
            {
                trans.Rollback();
                MessageBox.Show($"Another vehicle with registration No '{name}' already exists. Please enter some other registration no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtRegnNo.Focus();
                this.txtRegnNo.SelectAll();

                return;
            }
            
            if (this._operationMode == OperationModesEnum.AddNew)
            {
                int x = this.vehiclesTableAdapter.Insert(ref id, (decimal?)this.cmbSubcontractors.SelectedValue
                    , (decimal?)(this.chkDriver.Checked ? this.cmbDrivers.SelectedValue: null), (decimal?)null
                    , this.txtRegnNo.Text.Trim(), this.cmbVehicleType.Text.Trim());
                
                if (x == 1)
                {
                    DSLOGSTableAdapters.SubcontractorVehiclesTableAdapter taSubcontractorVehicles = new DSLOGSTableAdapters.SubcontractorVehiclesTableAdapter();
                    taSubcontractorVehicles.Connection = con;
                    taSubcontractorVehicles.Transaction = trans;
                    decimal? subcontractorVehicleID = 0;

                    int y=taSubcontractorVehicles.Insert(ref subcontractorVehicleID, (decimal?)this.cmbSubcontractors.SelectedValue
                        , id, this.dtSubcontractorStartDate.Value, (DateTime?)null, "Initial subcontractor");
                    decimal? driverID = this.chkDriver.Checked && cmbDrivers.SelectedIndex >= 0 ? (decimal?)this.cmbDrivers.SelectedValue : null;
                    if(driverID!=null)
                    {
                        DSLOGSTableAdapters.DriverVehiclesTableAdapter taDriverVehicles = new DSLOGSTableAdapters.DriverVehiclesTableAdapter();
                        taDriverVehicles.Connection = con;
                        taDriverVehicles.Transaction = trans;

                        decimal? driverVehicleID = 0;
                        int z = taDriverVehicles.Insert(ref driverVehicleID, driverID, id, this.dtDriverrStartDate.Value, null, "Initial driver");

                    }
                    trans.Commit();
                    con.Close();
                    MessageBox.Show("Vehicle  data saved successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ClearControls();

                    this._operationMode = OperationModesEnum.None;
                    this.panel1.Enabled = false;
                    this.btnSubcintractorChange.Enabled = true;
                    this.btnDriverChange.Enabled = this.btnSubcintractorChange.Enabled;
                    this.RetrieveData();
                    this.btnAddNew.Focus();

                }
            }
            else if (this._operationMode == OperationModesEnum.Edit)
            {

                decimal? driverid=(decimal?) (this.chkDriver.Checked? this.cmbDrivers.SelectedValue: null)    ;
                int x = this.vehiclesTableAdapter.Update((decimal?)this.cmbSubcontractors.SelectedValue, driverid, null, name, this.cmbVehicleType.Text.Trim(), id);

                if (x == 1)
                {
                    MessageBox.Show("Vehicle data updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ClearControls();

                    this._editVehicle = null;
                    this._operationMode = OperationModesEnum.None;
                    this.panel1.Enabled = false;
                    this.btnSubcintractorChange.Enabled = false;
                    this.btnSubcintractorChange.Enabled = true;
                    this.btnDriverChange.Enabled = this.btnSubcintractorChange.Enabled;
                    this.btnDriverChange.Enabled = this.btnSubcintractorChange.Enabled;

                    this.RetrieveData();
                    this.btnAddNew.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this._editVehicle = null;
            this._operationMode = OperationModesEnum.None;
            this.panel1.Enabled = false;
            this.btnSubcintractorChange.Enabled = false;
            this.btnDriverChange.Enabled = this.btnSubcintractorChange.Enabled;

            this.btnAddNew.Focus();
            this.ClearControls();
        }

        private void dgvSubcontractors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                this.btnEdit_Click(sender, System.EventArgs.Empty);

        }

        private void chkDriver_CheckedChanged(object sender, EventArgs e)
        {
            this.pnlDriver.Enabled = this.chkDriver.Checked;

        }

        private void btnSubcintractorChange_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon", "Change subcontractor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnDriverChange_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon", "Change subcontractor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnSubcintractorChange_EnabledChanged(object sender, EventArgs e)
        {
            this.cmbSubcontractors.Enabled = !this.btnSubcintractorChange.Enabled;
            this.dtSubcontractorStartDate.Enabled = this.cmbSubcontractors.Enabled;
        }

        private void btnDriverChange_EnabledChanged(object sender, EventArgs e)
        {
            this.cmbDrivers.Enabled = !this.btnDriverChange.Enabled;
            this.dtDriverrStartDate.Enabled = this.cmbDrivers.Enabled;
        }
    }
}
