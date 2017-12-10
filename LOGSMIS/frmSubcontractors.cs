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
    
    public partial class frmSubcontractors : Form
    {
        OperationModesEnum _operationMode;
        DSLOGS.SubcontractorsRow _editSubcontractor;

        public static int InstanceCount { get; private set; }
        public frmSubcontractors()
        {
            InitializeComponent();
            InstanceCount++;
        }

        private void frmSubcontractors_Load(object sender, EventArgs e)
        {
            this._operationMode = OperationModesEnum.None;
            this.panel1.Enabled = false;
            this.lblCaption.Text = this.Text;
            this.RetrieveData();

        }

        private void RetrieveData()
        {
            // TODO: This line of code loads data into the 'dSLOGS.Subcontractors' table. You can move, or remove it, as needed.
            this.subcontractorsTableAdapter.Fill(this.dSLOGS.Subcontractors);

        }

        private void ClearControls()
        {
            this.txtSubcontractorName.Text = "";
            this.txtPhone1.Text = "";
            this.txtPhone2.Text = "";

        }

        private void RetrieveSubcontractor()
        {
            this.txtSubcontractorName.Text = this._editSubcontractor.IsSubcontractor_NameNull() ? "" : this._editSubcontractor.Subcontractor_Name;
            this.txtPhone1.Text = this._editSubcontractor.IsPhone_1Null() ? "" : this._editSubcontractor.Phone_1;
            this.txtPhone2.Text = this._editSubcontractor.IsPhone_2Null() ? "" : this._editSubcontractor.Phone_2;

        }

        private void panel1_EnabledChanged(object sender, EventArgs e)
        {
            this.btnAddNew.Enabled = !this.panel1.Enabled;
            this.btnEdit.Enabled = this.btnAddNew.Enabled;
            this.btnSave.Enabled = !this.btnAddNew.Enabled;
            this.btnCancel.Enabled = this.btnSave.Enabled;
            this.dgvSubcontractors.Enabled = this.btnAddNew.Enabled;

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this._operationMode = OperationModesEnum.AddNew;
            this.panel1.Enabled = true;
            this.txtSubcontractorName.Focus();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvSubcontractors.CurrentRow == null)
                return;
            this._editSubcontractor = 
                this.dSLOGS.Subcontractors.Select(this.dSLOGS.Subcontractors.Subcontractor_IDColumn.ColumnName 
                + "=" + this.dgvSubcontractors.CurrentRow.Cells[0].Value)[0] as DSLOGS.SubcontractorsRow;
            this._operationMode = OperationModesEnum.Edit;
            this.RetrieveSubcontractor();
            this.panel1.Enabled = true;
            this.txtSubcontractorName.Focus();
            this.txtSubcontractorName.SelectAll();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(this.txtSubcontractorName.Text.Trim()=="")
            {
                MessageBox.Show("Please enter subcontractor's name", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                this.txtSubcontractorName.Focus();
                return;
            }
            decimal? id = this._operationMode == OperationModesEnum.AddNew ? 0 : this._editSubcontractor.Subcontractor_ID;
            string name = this.txtSubcontractorName.Text.Trim();

            DSLOGS.SubcontractorsDataTable dtDuplicateSubcontractors = this.subcontractorsTableAdapter.GetDataByNameByNotID(id, name);
            if(dtDuplicateSubcontractors.Rows.Count>0)
            {
                MessageBox.Show($"Subcontractor with name {name} already exists. Please enter a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtSubcontractorName.Focus();
                return;
            }

            if(this._operationMode== OperationModesEnum.AddNew)
            {
                int x = this.subcontractorsTableAdapter.Insert(ref id, name, this.txtPhone1.Text.Trim(), this.txtPhone2.Text.Trim());
                if(x==1)
                {
                    MessageBox.Show("Subcontractor data saved successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ClearControls();

                    this._operationMode = OperationModesEnum.None;
                    this.panel1.Enabled = false;
                    this.RetrieveData();
                    this.btnAddNew.Focus();
                    
                }
            }
            else if(this._operationMode== OperationModesEnum.Edit)
            {
                int x = this.subcontractorsTableAdapter.Update(name, this.txtPhone1.Text.Trim(), this.txtPhone2.Text.Trim()
                    , this._editSubcontractor.Active, id);
                if(x==1)
                {
                    MessageBox.Show("Subcontractor data updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ClearControls();

                    this._editSubcontractor = null;
                    this._operationMode = OperationModesEnum.None;
                    this.panel1.Enabled = false;
                    this.RetrieveData();
                    this.btnAddNew.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this._editSubcontractor = null;
            this._operationMode = OperationModesEnum.None;
            this.panel1.Enabled = false;
            this.btnAddNew.Focus();

        }

        private void dgvSubcontractors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                this.btnEdit_Click(sender, System.EventArgs.Empty);

        }
    }
}
