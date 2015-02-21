namespace 维修管理系统
{
    partial class EntryApplicationQuery
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.entryApplicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairCenterDataSet = new 维修管理系统.RepairCenterDataSet();
            this.entryApplicationTableAdapter = new 维修管理系统.RepairCenterDataSetTableAdapters.EntryApplicationTableAdapter();
            this.entryApplicationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKEntryApplicationLearningInformationEntryApplicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entryApplicationLearningInformationTableAdapter = new 维修管理系统.RepairCenterDataSetTableAdapters.EntryApplicationLearningInformationTableAdapter();
            this.entryApplicationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.entryApplicationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hometownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryApplicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryApplicationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEntryApplicationLearningInformationEntryApplicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryApplicationBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entryApplicationIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.hometownDataGridViewTextBoxColumn,
            this.nationDataGridViewTextBoxColumn,
            this.birthYearDataGridViewTextBoxColumn,
            this.birthMonthDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.entryApplicationBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(48, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(856, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // entryApplicationBindingSource
            // 
            this.entryApplicationBindingSource.DataMember = "EntryApplication";
            this.entryApplicationBindingSource.DataSource = this.repairCenterDataSet;
            // 
            // repairCenterDataSet
            // 
            this.repairCenterDataSet.DataSetName = "RepairCenterDataSet";
            this.repairCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entryApplicationTableAdapter
            // 
            this.entryApplicationTableAdapter.ClearBeforeFill = true;
            // 
            // entryApplicationBindingSource1
            // 
            this.entryApplicationBindingSource1.DataMember = "EntryApplication";
            this.entryApplicationBindingSource1.DataSource = this.repairCenterDataSet;
            // 
            // fKEntryApplicationLearningInformationEntryApplicationBindingSource
            // 
            this.fKEntryApplicationLearningInformationEntryApplicationBindingSource.DataMember = "FK_EntryApplicationLearningInformation_EntryApplication";
            this.fKEntryApplicationLearningInformationEntryApplicationBindingSource.DataSource = this.entryApplicationBindingSource1;
            // 
            // entryApplicationLearningInformationTableAdapter
            // 
            this.entryApplicationLearningInformationTableAdapter.ClearBeforeFill = true;
            // 
            // entryApplicationBindingSource2
            // 
            this.entryApplicationBindingSource2.DataMember = "EntryApplication";
            this.entryApplicationBindingSource2.DataSource = this.repairCenterDataSet;
            // 
            // entryApplicationIDDataGridViewTextBoxColumn
            // 
            this.entryApplicationIDDataGridViewTextBoxColumn.DataPropertyName = "EntryApplicationID";
            this.entryApplicationIDDataGridViewTextBoxColumn.HeaderText = "入职申请单ID";
            this.entryApplicationIDDataGridViewTextBoxColumn.Name = "entryApplicationIDDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "申请人ID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "性别";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // hometownDataGridViewTextBoxColumn
            // 
            this.hometownDataGridViewTextBoxColumn.DataPropertyName = "Hometown";
            this.hometownDataGridViewTextBoxColumn.HeaderText = "籍贯";
            this.hometownDataGridViewTextBoxColumn.Name = "hometownDataGridViewTextBoxColumn";
            // 
            // nationDataGridViewTextBoxColumn
            // 
            this.nationDataGridViewTextBoxColumn.DataPropertyName = "Nation";
            this.nationDataGridViewTextBoxColumn.HeaderText = "民族";
            this.nationDataGridViewTextBoxColumn.Name = "nationDataGridViewTextBoxColumn";
            // 
            // birthYearDataGridViewTextBoxColumn
            // 
            this.birthYearDataGridViewTextBoxColumn.DataPropertyName = "BirthYear";
            this.birthYearDataGridViewTextBoxColumn.HeaderText = "出生年";
            this.birthYearDataGridViewTextBoxColumn.Name = "birthYearDataGridViewTextBoxColumn";
            // 
            // birthMonthDataGridViewTextBoxColumn
            // 
            this.birthMonthDataGridViewTextBoxColumn.DataPropertyName = "BirthMonth";
            this.birthMonthDataGridViewTextBoxColumn.HeaderText = "出生月";
            this.birthMonthDataGridViewTextBoxColumn.Name = "birthMonthDataGridViewTextBoxColumn";
            // 
            // EntryApplicationQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 381);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EntryApplicationQuery";
            this.Text = "EntryApplicationQuery";
            this.Load += new System.EventHandler(this.EntryApplicationQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryApplicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryApplicationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEntryApplicationLearningInformationEntryApplicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryApplicationBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RepairCenterDataSet repairCenterDataSet;
        private System.Windows.Forms.BindingSource entryApplicationBindingSource;
        private RepairCenterDataSetTableAdapters.EntryApplicationTableAdapter entryApplicationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthMontyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource entryApplicationBindingSource1;
        private System.Windows.Forms.BindingSource fKEntryApplicationLearningInformationEntryApplicationBindingSource;
        private RepairCenterDataSetTableAdapters.EntryApplicationLearningInformationTableAdapter entryApplicationLearningInformationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryApplicationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hometownDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthMonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource entryApplicationBindingSource2;
    }
}