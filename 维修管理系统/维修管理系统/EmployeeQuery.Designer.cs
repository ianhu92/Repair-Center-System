namespace 维修管理系统
{
    partial class EmployeeQuery
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairCenterDataSet = new 维修管理系统.RepairCenterDataSet();
            this.employeeTableAdapter = new 维修管理系统.RepairCenterDataSetTableAdapters.EmployeeTableAdapter();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hometownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.householdRegisterTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.politicalLandscapeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationBackgroundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isOutGoingEmploymentCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthControlCertificateNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.householdRegisterLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resignationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.craftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technicalTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Certificate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(447, 386);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.hometownDataGridViewTextBoxColumn,
            this.nationDataGridViewTextBoxColumn,
            this.birthYearDataGridViewTextBoxColumn,
            this.birthMonthDataGridViewTextBoxColumn,
            this.householdRegisterTypeDataGridViewTextBoxColumn,
            this.politicalLandscapeDataGridViewTextBoxColumn,
            this.educationBackgroundDataGridViewTextBoxColumn,
            this.maritalStatusDataGridViewTextBoxColumn,
            this.isOutGoingEmploymentCardDataGridViewTextBoxColumn,
            this.birthControlCertificateNumberDataGridViewTextBoxColumn,
            this.householdRegisterLocationDataGridViewTextBoxColumn,
            this.iDNumberDataGridViewTextBoxColumn,
            this.currentAddressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.arrivalTimeDataGridViewTextBoxColumn,
            this.resignationTimeDataGridViewTextBoxColumn,
            this.craftDataGridViewTextBoxColumn,
            this.technicalTitleDataGridViewTextBoxColumn,
            this.Certificate,
            this.specificantDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(30, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(898, 356);
            this.dataGridView1.TabIndex = 1;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.repairCenterDataSet;
            // 
            // repairCenterDataSet
            // 
            this.repairCenterDataSet.DataSetName = "RepairCenterDataSet";
            this.repairCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.repairCenterDataSet;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "员工ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "性别";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hometownDataGridViewTextBoxColumn
            // 
            this.hometownDataGridViewTextBoxColumn.DataPropertyName = "Hometown";
            this.hometownDataGridViewTextBoxColumn.HeaderText = "籍贯";
            this.hometownDataGridViewTextBoxColumn.Name = "hometownDataGridViewTextBoxColumn";
            this.hometownDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nationDataGridViewTextBoxColumn
            // 
            this.nationDataGridViewTextBoxColumn.DataPropertyName = "Nation";
            this.nationDataGridViewTextBoxColumn.HeaderText = "民族";
            this.nationDataGridViewTextBoxColumn.Name = "nationDataGridViewTextBoxColumn";
            this.nationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthYearDataGridViewTextBoxColumn
            // 
            this.birthYearDataGridViewTextBoxColumn.DataPropertyName = "BirthYear";
            this.birthYearDataGridViewTextBoxColumn.HeaderText = "出生年";
            this.birthYearDataGridViewTextBoxColumn.Name = "birthYearDataGridViewTextBoxColumn";
            this.birthYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthMonthDataGridViewTextBoxColumn
            // 
            this.birthMonthDataGridViewTextBoxColumn.DataPropertyName = "BirthMonth";
            this.birthMonthDataGridViewTextBoxColumn.HeaderText = "出生月";
            this.birthMonthDataGridViewTextBoxColumn.Name = "birthMonthDataGridViewTextBoxColumn";
            this.birthMonthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // householdRegisterTypeDataGridViewTextBoxColumn
            // 
            this.householdRegisterTypeDataGridViewTextBoxColumn.DataPropertyName = "HouseholdRegisterType";
            this.householdRegisterTypeDataGridViewTextBoxColumn.HeaderText = "户口类型";
            this.householdRegisterTypeDataGridViewTextBoxColumn.Name = "householdRegisterTypeDataGridViewTextBoxColumn";
            this.householdRegisterTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // politicalLandscapeDataGridViewTextBoxColumn
            // 
            this.politicalLandscapeDataGridViewTextBoxColumn.DataPropertyName = "PoliticalLandscape";
            this.politicalLandscapeDataGridViewTextBoxColumn.HeaderText = "政治面貌";
            this.politicalLandscapeDataGridViewTextBoxColumn.Name = "politicalLandscapeDataGridViewTextBoxColumn";
            this.politicalLandscapeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // educationBackgroundDataGridViewTextBoxColumn
            // 
            this.educationBackgroundDataGridViewTextBoxColumn.DataPropertyName = "EducationBackground";
            this.educationBackgroundDataGridViewTextBoxColumn.HeaderText = "教育背景";
            this.educationBackgroundDataGridViewTextBoxColumn.Name = "educationBackgroundDataGridViewTextBoxColumn";
            this.educationBackgroundDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maritalStatusDataGridViewTextBoxColumn
            // 
            this.maritalStatusDataGridViewTextBoxColumn.DataPropertyName = "MaritalStatus";
            this.maritalStatusDataGridViewTextBoxColumn.HeaderText = "婚姻状况";
            this.maritalStatusDataGridViewTextBoxColumn.Name = "maritalStatusDataGridViewTextBoxColumn";
            this.maritalStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isOutGoingEmploymentCardDataGridViewTextBoxColumn
            // 
            this.isOutGoingEmploymentCardDataGridViewTextBoxColumn.DataPropertyName = "IsOutGoingEmploymentCard";
            this.isOutGoingEmploymentCardDataGridViewTextBoxColumn.HeaderText = "有无外出人员就业卡";
            this.isOutGoingEmploymentCardDataGridViewTextBoxColumn.Name = "isOutGoingEmploymentCardDataGridViewTextBoxColumn";
            this.isOutGoingEmploymentCardDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthControlCertificateNumberDataGridViewTextBoxColumn
            // 
            this.birthControlCertificateNumberDataGridViewTextBoxColumn.DataPropertyName = "BirthControlCertificateNumber";
            this.birthControlCertificateNumberDataGridViewTextBoxColumn.HeaderText = "计生证编号";
            this.birthControlCertificateNumberDataGridViewTextBoxColumn.Name = "birthControlCertificateNumberDataGridViewTextBoxColumn";
            this.birthControlCertificateNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // householdRegisterLocationDataGridViewTextBoxColumn
            // 
            this.householdRegisterLocationDataGridViewTextBoxColumn.DataPropertyName = "HouseholdRegisterLocation";
            this.householdRegisterLocationDataGridViewTextBoxColumn.HeaderText = "户口所在地";
            this.householdRegisterLocationDataGridViewTextBoxColumn.Name = "householdRegisterLocationDataGridViewTextBoxColumn";
            this.householdRegisterLocationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDNumberDataGridViewTextBoxColumn
            // 
            this.iDNumberDataGridViewTextBoxColumn.DataPropertyName = "IDNumber";
            this.iDNumberDataGridViewTextBoxColumn.HeaderText = "身份证号";
            this.iDNumberDataGridViewTextBoxColumn.Name = "iDNumberDataGridViewTextBoxColumn";
            this.iDNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentAddressDataGridViewTextBoxColumn
            // 
            this.currentAddressDataGridViewTextBoxColumn.DataPropertyName = "CurrentAddress";
            this.currentAddressDataGridViewTextBoxColumn.HeaderText = "现住址";
            this.currentAddressDataGridViewTextBoxColumn.Name = "currentAddressDataGridViewTextBoxColumn";
            this.currentAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "电话";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "岗位";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arrivalTimeDataGridViewTextBoxColumn
            // 
            this.arrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.HeaderText = "到岗时间";
            this.arrivalTimeDataGridViewTextBoxColumn.Name = "arrivalTimeDataGridViewTextBoxColumn";
            this.arrivalTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resignationTimeDataGridViewTextBoxColumn
            // 
            this.resignationTimeDataGridViewTextBoxColumn.DataPropertyName = "ResignationTime";
            this.resignationTimeDataGridViewTextBoxColumn.HeaderText = "离职时间";
            this.resignationTimeDataGridViewTextBoxColumn.Name = "resignationTimeDataGridViewTextBoxColumn";
            this.resignationTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // craftDataGridViewTextBoxColumn
            // 
            this.craftDataGridViewTextBoxColumn.DataPropertyName = "Craft";
            this.craftDataGridViewTextBoxColumn.HeaderText = "工种";
            this.craftDataGridViewTextBoxColumn.Name = "craftDataGridViewTextBoxColumn";
            this.craftDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // technicalTitleDataGridViewTextBoxColumn
            // 
            this.technicalTitleDataGridViewTextBoxColumn.DataPropertyName = "TechnicalTitle";
            this.technicalTitleDataGridViewTextBoxColumn.HeaderText = "技术职称";
            this.technicalTitleDataGridViewTextBoxColumn.Name = "technicalTitleDataGridViewTextBoxColumn";
            this.technicalTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Certificate
            // 
            this.Certificate.DataPropertyName = "Certificate";
            this.Certificate.HeaderText = "资格证书";
            this.Certificate.Name = "Certificate";
            this.Certificate.ReadOnly = true;
            // 
            // specificantDataGridViewTextBoxColumn
            // 
            this.specificantDataGridViewTextBoxColumn.DataPropertyName = "Specificant";
            this.specificantDataGridViewTextBoxColumn.HeaderText = "专长";
            this.specificantDataGridViewTextBoxColumn.Name = "specificantDataGridViewTextBoxColumn";
            this.specificantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EmployeeQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 433);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Exit);
            this.Name = "EmployeeQuery";
            this.Text = "EmployeeQuery";
            this.Load += new System.EventHandler(this.EmployeeQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RepairCenterDataSet repairCenterDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private RepairCenterDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificantDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hometownDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthMonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn householdRegisterTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn politicalLandscapeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationBackgroundDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isOutGoingEmploymentCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthControlCertificateNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn householdRegisterLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resignationTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn craftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicalTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Certificate;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificantDataGridViewTextBoxColumn;
    }
}