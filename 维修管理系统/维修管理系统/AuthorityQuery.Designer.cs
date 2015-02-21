namespace 维修管理系统
{
    partial class AuthorityQuery
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
            this.repairCenterDataSet = new 维修管理系统.RepairCenterDataSet();
            this.authorityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorityTableAdapter = new 维修管理系统.RepairCenterDataSetTableAdapters.AuthorityTableAdapter();
            this.authorityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorityTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorityIDDataGridViewTextBoxColumn,
            this.authorityTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.authorityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(258, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // repairCenterDataSet
            // 
            this.repairCenterDataSet.DataSetName = "RepairCenterDataSet";
            this.repairCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorityBindingSource
            // 
            this.authorityBindingSource.DataMember = "Authority";
            this.authorityBindingSource.DataSource = this.repairCenterDataSet;
            // 
            // authorityTableAdapter
            // 
            this.authorityTableAdapter.ClearBeforeFill = true;
            // 
            // authorityIDDataGridViewTextBoxColumn
            // 
            this.authorityIDDataGridViewTextBoxColumn.DataPropertyName = "AuthorityID";
            this.authorityIDDataGridViewTextBoxColumn.HeaderText = "权限ID";
            this.authorityIDDataGridViewTextBoxColumn.Name = "authorityIDDataGridViewTextBoxColumn";
            this.authorityIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorityTypeDataGridViewTextBoxColumn
            // 
            this.authorityTypeDataGridViewTextBoxColumn.DataPropertyName = "AuthorityType";
            this.authorityTypeDataGridViewTextBoxColumn.HeaderText = "权限类型";
            this.authorityTypeDataGridViewTextBoxColumn.Name = "authorityTypeDataGridViewTextBoxColumn";
            // 
            // AuthorityQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 300);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AuthorityQuery";
            this.Text = "AuthorityQuery";
            this.Load += new System.EventHandler(this.AuthorityQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RepairCenterDataSet repairCenterDataSet;
        private System.Windows.Forms.BindingSource authorityBindingSource;
        private RepairCenterDataSetTableAdapters.AuthorityTableAdapter authorityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorityTypeDataGridViewTextBoxColumn;
    }
}