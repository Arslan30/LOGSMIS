namespace LOGSMIS
{
    partial class frmVehicles
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
            this.chkDriver = new System.Windows.Forms.CheckBox();
            this.pnlDriver = new System.Windows.Forms.Panel();
            this.dtDriverrStartDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDrivers = new System.Windows.Forms.ComboBox();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSLOGS = new LOGSMIS.DSLOGS();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDriverChange = new System.Windows.Forms.Button();
            this.btnSubcintractorChange = new System.Windows.Forms.Button();
            this.dtSubcontractorStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.vehicleTypesDistinctBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSubcontractors = new System.Windows.Forms.ComboBox();
            this.subcontractorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegnNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.driversTableAdapter = new LOGSMIS.DSLOGSTableAdapters.DriversTableAdapter();
            this.subcontractorsTableAdapter = new LOGSMIS.DSLOGSTableAdapters.SubcontractorsTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblCaption = new System.Windows.Forms.Label();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vehiclesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiclesTableAdapter = new LOGSMIS.DSLOGSTableAdapters.VehiclesTableAdapter();
            this.vehicleTypesDistinctTableAdapter = new LOGSMIS.DSLOGSTableAdapters.VehicleTypesDistinctTableAdapter();
            this.panel1.SuspendLayout();
            this.pnlDriver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLOGS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypesDistinctBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcontractorsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.chkDriver);
            this.panel1.Controls.Add(this.pnlDriver);
            this.panel1.Controls.Add(this.btnSubcintractorChange);
            this.panel1.Controls.Add(this.dtSubcontractorStartDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbVehicleType);
            this.panel1.Controls.Add(this.cmbSubcontractors);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRegnNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 115);
            this.panel1.TabIndex = 0;
            this.panel1.EnabledChanged += new System.EventHandler(this.panel1_EnabledChanged);
            // 
            // chkDriver
            // 
            this.chkDriver.AutoSize = true;
            this.chkDriver.Checked = true;
            this.chkDriver.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDriver.Location = new System.Drawing.Point(28, 61);
            this.chkDriver.Name = "chkDriver";
            this.chkDriver.Size = new System.Drawing.Size(54, 17);
            this.chkDriver.TabIndex = 9;
            this.chkDriver.Text = "Dri&ver";
            this.chkDriver.UseVisualStyleBackColor = true;
            this.chkDriver.CheckedChanged += new System.EventHandler(this.chkDriver_CheckedChanged);
            // 
            // pnlDriver
            // 
            this.pnlDriver.Controls.Add(this.dtDriverrStartDate);
            this.pnlDriver.Controls.Add(this.label6);
            this.pnlDriver.Controls.Add(this.cmbDrivers);
            this.pnlDriver.Controls.Add(this.label3);
            this.pnlDriver.Controls.Add(this.btnDriverChange);
            this.pnlDriver.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDriver.Location = new System.Drawing.Point(0, 78);
            this.pnlDriver.Name = "pnlDriver";
            this.pnlDriver.Size = new System.Drawing.Size(603, 49);
            this.pnlDriver.TabIndex = 10;
            // 
            // dtDriverrStartDate
            // 
            this.dtDriverrStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtDriverrStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDriverrStartDate.Location = new System.Drawing.Point(334, 0);
            this.dtDriverrStartDate.Name = "dtDriverrStartDate";
            this.dtDriverrStartDate.Size = new System.Drawing.Size(121, 20);
            this.dtDriverrStartDate.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Start date";
            // 
            // cmbDrivers
            // 
            this.cmbDrivers.DataSource = this.driversBindingSource;
            this.cmbDrivers.DisplayMember = "Driver_Name";
            this.cmbDrivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrivers.FormattingEnabled = true;
            this.cmbDrivers.Location = new System.Drawing.Point(109, 3);
            this.cmbDrivers.Name = "cmbDrivers";
            this.cmbDrivers.Size = new System.Drawing.Size(121, 21);
            this.cmbDrivers.TabIndex = 1;
            this.cmbDrivers.ValueMember = "Driver_ID";
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataMember = "Drivers";
            this.driversBindingSource.DataSource = this.dSLOGS;
            // 
            // dSLOGS
            // 
            this.dSLOGS.DataSetName = "DSLOGS";
            this.dSLOGS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Driver";
            // 
            // btnDriverChange
            // 
            this.btnDriverChange.Enabled = false;
            this.btnDriverChange.Location = new System.Drawing.Point(461, 1);
            this.btnDriverChange.Name = "btnDriverChange";
            this.btnDriverChange.Size = new System.Drawing.Size(75, 23);
            this.btnDriverChange.TabIndex = 4;
            this.btnDriverChange.Text = "Change...";
            this.btnDriverChange.UseVisualStyleBackColor = true;
            this.btnDriverChange.EnabledChanged += new System.EventHandler(this.btnDriverChange_EnabledChanged);
            this.btnDriverChange.Click += new System.EventHandler(this.btnDriverChange_Click);
            // 
            // btnSubcintractorChange
            // 
            this.btnSubcintractorChange.Enabled = false;
            this.btnSubcintractorChange.Location = new System.Drawing.Point(457, 37);
            this.btnSubcintractorChange.Name = "btnSubcintractorChange";
            this.btnSubcintractorChange.Size = new System.Drawing.Size(75, 23);
            this.btnSubcintractorChange.TabIndex = 8;
            this.btnSubcintractorChange.Text = "Change...";
            this.btnSubcintractorChange.UseVisualStyleBackColor = true;
            this.btnSubcintractorChange.EnabledChanged += new System.EventHandler(this.btnSubcintractorChange_EnabledChanged);
            this.btnSubcintractorChange.Click += new System.EventHandler(this.btnSubcintractorChange_Click);
            // 
            // dtSubcontractorStartDate
            // 
            this.dtSubcontractorStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtSubcontractorStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSubcontractorStartDate.Location = new System.Drawing.Point(333, 41);
            this.dtSubcontractorStartDate.Name = "dtSubcontractorStartDate";
            this.dtSubcontractorStartDate.Size = new System.Drawing.Size(121, 20);
            this.dtSubcontractorStartDate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Type";
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbVehicleType.DataSource = this.vehicleTypesDistinctBindingSource;
            this.cmbVehicleType.DisplayMember = "Vehicle_Type";
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Location = new System.Drawing.Point(330, 16);
            this.cmbVehicleType.MaxLength = 50;
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(121, 21);
            this.cmbVehicleType.TabIndex = 3;
            this.cmbVehicleType.ValueMember = "Vehicle_Type";
            // 
            // vehicleTypesDistinctBindingSource
            // 
            this.vehicleTypesDistinctBindingSource.DataMember = "VehicleTypesDistinct";
            this.vehicleTypesDistinctBindingSource.DataSource = this.dSLOGS;
            // 
            // cmbSubcontractors
            // 
            this.cmbSubcontractors.DataSource = this.subcontractorsBindingSource;
            this.cmbSubcontractors.DisplayMember = "Subcontractor_Name";
            this.cmbSubcontractors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubcontractors.FormattingEnabled = true;
            this.cmbSubcontractors.Location = new System.Drawing.Point(105, 39);
            this.cmbSubcontractors.Name = "cmbSubcontractors";
            this.cmbSubcontractors.Size = new System.Drawing.Size(121, 21);
            this.cmbSubcontractors.TabIndex = 5;
            this.cmbSubcontractors.ValueMember = "Subcontractor_ID";
            // 
            // subcontractorsBindingSource
            // 
            this.subcontractorsBindingSource.DataMember = "Subcontractors";
            this.subcontractorsBindingSource.DataSource = this.dSLOGS;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subcontractor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Start date";
            // 
            // txtRegnNo
            // 
            this.txtRegnNo.Location = new System.Drawing.Point(105, 12);
            this.txtRegnNo.MaxLength = 50;
            this.txtRegnNo.Name = "txtRegnNo";
            this.txtRegnNo.Size = new System.Drawing.Size(121, 20);
            this.txtRegnNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reg. No";
            // 
            // driversTableAdapter
            // 
            this.driversTableAdapter.ClearBeforeFill = true;
            // 
            // subcontractorsTableAdapter
            // 
            this.subcontractorsTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnAddNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 40);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(256, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
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
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.White;
            this.lblCaption.Location = new System.Drawing.Point(0, 155);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(620, 23);
            this.lblCaption.TabIndex = 2;
            this.lblCaption.Text = "label4";
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.AutoGenerateColumns = false;
            this.dgvVehicles.BackgroundColor = System.Drawing.Color.White;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleIDDataGridViewTextBoxColumn,
            this.registrationNoDataGridViewTextBoxColumn,
            this.vehicleTypeDataGridViewTextBoxColumn,
            this.dateAddedDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn});
            this.dgvVehicles.DataSource = this.vehiclesBindingSource1;
            this.dgvVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVehicles.Location = new System.Drawing.Point(0, 178);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            this.dgvVehicles.Size = new System.Drawing.Size(620, 273);
            this.dgvVehicles.TabIndex = 3;
            this.dgvVehicles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubcontractors_CellDoubleClick);
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            this.vehicleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicleIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // registrationNoDataGridViewTextBoxColumn
            // 
            this.registrationNoDataGridViewTextBoxColumn.DataPropertyName = "Registration_No";
            this.registrationNoDataGridViewTextBoxColumn.HeaderText = "Registration No";
            this.registrationNoDataGridViewTextBoxColumn.Name = "registrationNoDataGridViewTextBoxColumn";
            this.registrationNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.registrationNoDataGridViewTextBoxColumn.Width = 120;
            // 
            // vehicleTypeDataGridViewTextBoxColumn
            // 
            this.vehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Type";
            this.vehicleTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.vehicleTypeDataGridViewTextBoxColumn.Name = "vehicleTypeDataGridViewTextBoxColumn";
            this.vehicleTypeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // vehiclesBindingSource1
            // 
            this.vehiclesBindingSource1.DataMember = "Vehicles";
            this.vehiclesBindingSource1.DataSource = this.dSLOGS;
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataMember = "Vehicles";
            this.vehiclesBindingSource.DataSource = this.dSLOGS;
            // 
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // vehicleTypesDistinctTableAdapter
            // 
            this.vehicleTypesDistinctTableAdapter.ClearBeforeFill = true;
            // 
            // frmVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 451);
            this.Controls.Add(this.dgvVehicles);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmVehicles";
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.frmVehicles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDriver.ResumeLayout(false);
            this.pnlDriver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLOGS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypesDistinctBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcontractorsBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtSubcontractorStartDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.ComboBox cmbSubcontractors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegnNo;
        private System.Windows.Forms.Label label1;
        private DSLOGS dSLOGS;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private DSLOGSTableAdapters.DriversTableAdapter driversTableAdapter;
        private System.Windows.Forms.BindingSource subcontractorsBindingSource;
        private DSLOGSTableAdapters.SubcontractorsTableAdapter subcontractorsTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private DSLOGSTableAdapters.VehiclesTableAdapter vehiclesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcontractorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusrrentDriverIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentProjectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentDriverStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentProjectStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcontractorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vehiclesBindingSource1;
        private System.Windows.Forms.BindingSource vehicleTypesDistinctBindingSource;
        private DSLOGSTableAdapters.VehicleTypesDistinctTableAdapter vehicleTypesDistinctTableAdapter;
        private System.Windows.Forms.Button btnSubcintractorChange;
        private System.Windows.Forms.CheckBox chkDriver;
        private System.Windows.Forms.Panel pnlDriver;
        private System.Windows.Forms.DateTimePicker dtDriverrStartDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDrivers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDriverChange;
    }
}