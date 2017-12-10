namespace LOGSMIS
{
    partial class frmSubcontractors
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
            InstanceCount--;

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubcontractorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dgvSubcontractors = new System.Windows.Forms.DataGridView();
            this.lblCaption = new System.Windows.Forms.Label();
            this.subcontractorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcontractorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.subcontractorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSLOGS = new LOGSMIS.DSLOGS();
            this.subcontractorsTableAdapter = new LOGSMIS.DSLOGSTableAdapters.SubcontractorsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubcontractors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcontractorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLOGS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtPhone2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPhone1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSubcontractorName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 71);
            this.panel1.TabIndex = 0;
            this.panel1.EnabledChanged += new System.EventHandler(this.panel1_EnabledChanged);
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(253, 39);
            this.txtPhone2.MaxLength = 30;
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(100, 20);
            this.txtPhone2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone &2";
            // 
            // txtPhone1
            // 
            this.txtPhone1.Location = new System.Drawing.Point(66, 36);
            this.txtPhone1.MaxLength = 30;
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(100, 20);
            this.txtPhone1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone &1";
            // 
            // txtSubcontractorName
            // 
            this.txtSubcontractorName.Location = new System.Drawing.Point(66, 10);
            this.txtSubcontractorName.MaxLength = 50;
            this.txtSubcontractorName.Name = "txtSubcontractorName";
            this.txtSubcontractorName.Size = new System.Drawing.Size(287, 20);
            this.txtSubcontractorName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Na&me";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnAddNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 40);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(256, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Ca&ncel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(175, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(94, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "&Open";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(13, 7);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Ne&w";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dgvSubcontractors
            // 
            this.dgvSubcontractors.AllowUserToAddRows = false;
            this.dgvSubcontractors.AllowUserToDeleteRows = false;
            this.dgvSubcontractors.AutoGenerateColumns = false;
            this.dgvSubcontractors.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubcontractors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubcontractors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subcontractorIDDataGridViewTextBoxColumn,
            this.subcontractorNameDataGridViewTextBoxColumn,
            this.phone1DataGridViewTextBoxColumn,
            this.phone2DataGridViewTextBoxColumn,
            this.dateAddedDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn});
            this.dgvSubcontractors.DataSource = this.subcontractorsBindingSource;
            this.dgvSubcontractors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubcontractors.Location = new System.Drawing.Point(0, 134);
            this.dgvSubcontractors.Name = "dgvSubcontractors";
            this.dgvSubcontractors.ReadOnly = true;
            this.dgvSubcontractors.Size = new System.Drawing.Size(438, 222);
            this.dgvSubcontractors.TabIndex = 2;
            this.dgvSubcontractors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubcontractors_CellDoubleClick);
            // 
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.White;
            this.lblCaption.Location = new System.Drawing.Point(0, 111);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(438, 23);
            this.lblCaption.TabIndex = 3;
            this.lblCaption.Text = "label4";
            // 
            // subcontractorIDDataGridViewTextBoxColumn
            // 
            this.subcontractorIDDataGridViewTextBoxColumn.DataPropertyName = "Subcontractor_ID";
            this.subcontractorIDDataGridViewTextBoxColumn.HeaderText = "Subcontractor_ID";
            this.subcontractorIDDataGridViewTextBoxColumn.Name = "subcontractorIDDataGridViewTextBoxColumn";
            this.subcontractorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.subcontractorIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // subcontractorNameDataGridViewTextBoxColumn
            // 
            this.subcontractorNameDataGridViewTextBoxColumn.DataPropertyName = "Subcontractor_Name";
            this.subcontractorNameDataGridViewTextBoxColumn.HeaderText = "Subcontractor Name";
            this.subcontractorNameDataGridViewTextBoxColumn.Name = "subcontractorNameDataGridViewTextBoxColumn";
            this.subcontractorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.subcontractorNameDataGridViewTextBoxColumn.Width = 140;
            // 
            // phone1DataGridViewTextBoxColumn
            // 
            this.phone1DataGridViewTextBoxColumn.DataPropertyName = "Phone_1";
            this.phone1DataGridViewTextBoxColumn.HeaderText = "Phone 1";
            this.phone1DataGridViewTextBoxColumn.Name = "phone1DataGridViewTextBoxColumn";
            this.phone1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phone2DataGridViewTextBoxColumn
            // 
            this.phone2DataGridViewTextBoxColumn.DataPropertyName = "Phone_2";
            this.phone2DataGridViewTextBoxColumn.HeaderText = "Phone 2";
            this.phone2DataGridViewTextBoxColumn.Name = "phone2DataGridViewTextBoxColumn";
            this.phone2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            this.dateAddedDataGridViewTextBoxColumn.DataPropertyName = "Date_Added";
            this.dateAddedDataGridViewTextBoxColumn.HeaderText = "Date_Added";
            this.dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            this.dateAddedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateAddedDataGridViewTextBoxColumn.Visible = false;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activeDataGridViewCheckBoxColumn.Visible = false;
            // 
            // subcontractorsBindingSource
            // 
            this.subcontractorsBindingSource.DataMember = "Subcontractors";
            this.subcontractorsBindingSource.DataSource = this.dSLOGS;
            // 
            // dSLOGS
            // 
            this.dSLOGS.DataSetName = "DSLOGS";
            this.dSLOGS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subcontractorsTableAdapter
            // 
            this.subcontractorsTableAdapter.ClearBeforeFill = true;
            // 
            // frmSubcontractors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 356);
            this.Controls.Add(this.dgvSubcontractors);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmSubcontractors";
            this.Text = "Subcontractors";
            this.Load += new System.EventHandler(this.frmSubcontractors_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubcontractors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcontractorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLOGS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSubcontractorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dgvSubcontractors;
        private DSLOGS dSLOGS;
        private System.Windows.Forms.BindingSource subcontractorsBindingSource;
        private DSLOGSTableAdapters.SubcontractorsTableAdapter subcontractorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcontractorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcontractorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label lblCaption;
    }
}