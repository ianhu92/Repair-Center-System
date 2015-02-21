namespace 维修管理系统
{
    partial class PurchaseManagement
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
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("采购申请单");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("送货单");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("采购退货单");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("采购", new System.Windows.Forms.TreeNode[] {
            treeNode78,
            treeNode79,
            treeNode80});
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("采购申请明细表");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("送货明细表");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("采购退货明细表");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("采购记录查询", new System.Windows.Forms.TreeNode[] {
            treeNode82,
            treeNode83,
            treeNode84});
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("供应商信息");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("供应商物资明细");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("供应商管理", new System.Windows.Forms.TreeNode[] {
            treeNode86,
            treeNode87});
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OpenMaterialQuery = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.OpenEmployeeQuery = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.QueryDelivery_PurchaseApplication = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete_PurchaseApplication = new System.Windows.Forms.Button();
            this.QueryDetail_PurchaseApplication = new System.Windows.Forms.Button();
            this.Save_PurchaseApplication = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Delete_PurchaseDetail = new System.Windows.Forms.Button();
            this.Query_PurchaseDetail = new System.Windows.Forms.Button();
            this.PurchaseApplicationID = new System.Windows.Forms.TextBox();
            this.Save_PurchaseDetail = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Query_Delivery = new System.Windows.Forms.Button();
            this.PurchaseApplicationID2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Delete_Delivery = new System.Windows.Forms.Button();
            this.QueryDetail_Delivery = new System.Windows.Forms.Button();
            this.Save_Delivery = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Delete_DeliveryDetail = new System.Windows.Forms.Button();
            this.Query_DeliveryDetail = new System.Windows.Forms.Button();
            this.Delivery_ID = new System.Windows.Forms.TextBox();
            this.Save_DeliveryDetail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Query_PurchaseReturn = new System.Windows.Forms.Button();
            this.StockInID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.Delete_Return = new System.Windows.Forms.Button();
            this.QueryDetail_Return = new System.Windows.Forms.Button();
            this.Save_Return = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.Delete_ReturnDetail = new System.Windows.Forms.Button();
            this.Query_ReturnDetail = new System.Windows.Forms.Button();
            this.ReturnID = new System.Windows.Forms.TextBox();
            this.Save_ReturnDetail = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.Delete_Supplier = new System.Windows.Forms.Button();
            this.Save_Supplier = new System.Windows.Forms.Button();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.label24 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.Delete_SupplierMaterialDetatil = new System.Windows.Forms.Button();
            this.Save_SupplierMaterialDetatil = new System.Windows.Forms.Button();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.label25 = new System.Windows.Forms.Label();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "采购管理";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(797, 478);
            this.splitContainer1.SplitterDistance = 136;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.OpenMaterialQuery);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.OpenEmployeeQuery);
            this.panel1.Location = new System.Drawing.Point(7, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 93);
            this.panel1.TabIndex = 8;
            // 
            // OpenMaterialQuery
            // 
            this.OpenMaterialQuery.Location = new System.Drawing.Point(21, 25);
            this.OpenMaterialQuery.Name = "OpenMaterialQuery";
            this.OpenMaterialQuery.Size = new System.Drawing.Size(75, 23);
            this.OpenMaterialQuery.TabIndex = 3;
            this.OpenMaterialQuery.Text = "物料查询";
            this.OpenMaterialQuery.UseVisualStyleBackColor = true;
            this.OpenMaterialQuery.Click += new System.EventHandler(this.OpenMaterialQuery_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(30, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID查询：";
            // 
            // OpenEmployeeQuery
            // 
            this.OpenEmployeeQuery.Location = new System.Drawing.Point(21, 54);
            this.OpenEmployeeQuery.Name = "OpenEmployeeQuery";
            this.OpenEmployeeQuery.Size = new System.Drawing.Size(75, 23);
            this.OpenEmployeeQuery.TabIndex = 1;
            this.OpenEmployeeQuery.Text = "员工查询";
            this.OpenEmployeeQuery.UseVisualStyleBackColor = true;
            this.OpenEmployeeQuery.Click += new System.EventHandler(this.OpenEmployeeQuery_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(5, 70);
            this.treeView1.Name = "treeView1";
            treeNode78.Name = "节点1";
            treeNode78.Text = "采购申请单";
            treeNode79.Name = "节点2";
            treeNode79.Text = "送货单";
            treeNode80.Name = "节点0";
            treeNode80.Text = "采购退货单";
            treeNode81.Name = "节点0";
            treeNode81.Text = "采购";
            treeNode82.Name = "节点1";
            treeNode82.Text = "采购申请明细表";
            treeNode83.Name = "节点2";
            treeNode83.Text = "送货明细表";
            treeNode84.Name = "节点3";
            treeNode84.Text = "采购退货明细表";
            treeNode85.Name = "节点0";
            treeNode85.Text = "采购记录查询";
            treeNode86.Name = "节点4";
            treeNode86.Text = "供应商信息";
            treeNode87.Name = "节点5";
            treeNode87.Text = "供应商物资明细";
            treeNode88.Name = "节点1";
            treeNode88.Text = "供应商管理";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode81,
            treeNode85,
            treeNode88});
            this.treeView1.Size = new System.Drawing.Size(128, 218);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(657, 478);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.QueryDelivery_PurchaseApplication);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.Delete_PurchaseApplication);
            this.tabPage1.Controls.Add(this.QueryDetail_PurchaseApplication);
            this.tabPage1.Controls.Add(this.Save_PurchaseApplication);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(649, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "采购申请单";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // QueryDelivery_PurchaseApplication
            // 
            this.QueryDelivery_PurchaseApplication.Location = new System.Drawing.Point(470, 383);
            this.QueryDelivery_PurchaseApplication.Name = "QueryDelivery_PurchaseApplication";
            this.QueryDelivery_PurchaseApplication.Size = new System.Drawing.Size(107, 23);
            this.QueryDelivery_PurchaseApplication.TabIndex = 14;
            this.QueryDelivery_PurchaseApplication.Text = "查询相应送货单";
            this.QueryDelivery_PurchaseApplication.UseVisualStyleBackColor = true;
            this.QueryDelivery_PurchaseApplication.Click += new System.EventHandler(this.QueryDelivery_PurchaseApplication_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(560, 310);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // Delete_PurchaseApplication
            // 
            this.Delete_PurchaseApplication.Location = new System.Drawing.Point(178, 383);
            this.Delete_PurchaseApplication.Name = "Delete_PurchaseApplication";
            this.Delete_PurchaseApplication.Size = new System.Drawing.Size(75, 23);
            this.Delete_PurchaseApplication.TabIndex = 12;
            this.Delete_PurchaseApplication.Text = "删除";
            this.Delete_PurchaseApplication.UseVisualStyleBackColor = true;
            this.Delete_PurchaseApplication.Click += new System.EventHandler(this.Delete_Purchase_Click);
            // 
            // QueryDetail_PurchaseApplication
            // 
            this.QueryDetail_PurchaseApplication.Location = new System.Drawing.Point(290, 383);
            this.QueryDetail_PurchaseApplication.Name = "QueryDetail_PurchaseApplication";
            this.QueryDetail_PurchaseApplication.Size = new System.Drawing.Size(147, 23);
            this.QueryDetail_PurchaseApplication.TabIndex = 10;
            this.QueryDetail_PurchaseApplication.Text = "查询相应申请单明细";
            this.QueryDetail_PurchaseApplication.UseVisualStyleBackColor = true;
            this.QueryDetail_PurchaseApplication.Click += new System.EventHandler(this.QueryDetail_Purchase_Click);
            // 
            // Save_PurchaseApplication
            // 
            this.Save_PurchaseApplication.Location = new System.Drawing.Point(59, 383);
            this.Save_PurchaseApplication.Name = "Save_PurchaseApplication";
            this.Save_PurchaseApplication.Size = new System.Drawing.Size(75, 23);
            this.Save_PurchaseApplication.TabIndex = 9;
            this.Save_PurchaseApplication.Text = "保存";
            this.Save_PurchaseApplication.UseVisualStyleBackColor = true;
            this.Save_PurchaseApplication.Click += new System.EventHandler(this.Save_Purchase_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Controls.Add(this.Delete_PurchaseDetail);
            this.tabPage4.Controls.Add(this.Query_PurchaseDetail);
            this.tabPage4.Controls.Add(this.PurchaseApplicationID);
            this.tabPage4.Controls.Add(this.Save_PurchaseDetail);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(649, 452);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "采购申请明细表";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(40, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(560, 310);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView2_DefaultValuesNeeded);
            // 
            // Delete_PurchaseDetail
            // 
            this.Delete_PurchaseDetail.Location = new System.Drawing.Point(376, 389);
            this.Delete_PurchaseDetail.Name = "Delete_PurchaseDetail";
            this.Delete_PurchaseDetail.Size = new System.Drawing.Size(75, 23);
            this.Delete_PurchaseDetail.TabIndex = 5;
            this.Delete_PurchaseDetail.Text = "删除";
            this.Delete_PurchaseDetail.UseVisualStyleBackColor = true;
            this.Delete_PurchaseDetail.Click += new System.EventHandler(this.Delete_PurchaseDetail_Click);
            // 
            // Query_PurchaseDetail
            // 
            this.Query_PurchaseDetail.Location = new System.Drawing.Point(351, 16);
            this.Query_PurchaseDetail.Name = "Query_PurchaseDetail";
            this.Query_PurchaseDetail.Size = new System.Drawing.Size(75, 23);
            this.Query_PurchaseDetail.TabIndex = 4;
            this.Query_PurchaseDetail.Text = "查询";
            this.Query_PurchaseDetail.UseVisualStyleBackColor = true;
            this.Query_PurchaseDetail.Click += new System.EventHandler(this.Query_PurchaseDetail_Click);
            // 
            // PurchaseApplicationID
            // 
            this.PurchaseApplicationID.Location = new System.Drawing.Point(201, 16);
            this.PurchaseApplicationID.Name = "PurchaseApplicationID";
            this.PurchaseApplicationID.Size = new System.Drawing.Size(100, 21);
            this.PurchaseApplicationID.TabIndex = 3;
            // 
            // Save_PurchaseDetail
            // 
            this.Save_PurchaseDetail.Location = new System.Drawing.Point(150, 389);
            this.Save_PurchaseDetail.Name = "Save_PurchaseDetail";
            this.Save_PurchaseDetail.Size = new System.Drawing.Size(75, 23);
            this.Save_PurchaseDetail.TabIndex = 2;
            this.Save_PurchaseDetail.Text = "保存";
            this.Save_PurchaseDetail.UseVisualStyleBackColor = true;
            this.Save_PurchaseDetail.Click += new System.EventHandler(this.save_PurchaseDetail_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(71, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 12);
            this.label21.TabIndex = 0;
            this.label21.Text = "采购申请单ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Query_Delivery);
            this.tabPage2.Controls.Add(this.PurchaseApplicationID2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.Delete_Delivery);
            this.tabPage2.Controls.Add(this.QueryDetail_Delivery);
            this.tabPage2.Controls.Add(this.Save_Delivery);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(649, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "送货单";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Query_Delivery
            // 
            this.Query_Delivery.Location = new System.Drawing.Point(343, 16);
            this.Query_Delivery.Name = "Query_Delivery";
            this.Query_Delivery.Size = new System.Drawing.Size(75, 23);
            this.Query_Delivery.TabIndex = 22;
            this.Query_Delivery.Text = "查询";
            this.Query_Delivery.UseVisualStyleBackColor = true;
            this.Query_Delivery.Click += new System.EventHandler(this.Query_Delivery_Click);
            // 
            // PurchaseApplicationID2
            // 
            this.PurchaseApplicationID2.Location = new System.Drawing.Point(193, 16);
            this.PurchaseApplicationID2.Name = "PurchaseApplicationID2";
            this.PurchaseApplicationID2.Size = new System.Drawing.Size(100, 21);
            this.PurchaseApplicationID2.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "采购申请单ID";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(40, 50);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(560, 310);
            this.dataGridView3.TabIndex = 19;
            this.dataGridView3.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView3_DefaultValuesNeeded);
            // 
            // Delete_Delivery
            // 
            this.Delete_Delivery.Location = new System.Drawing.Point(231, 384);
            this.Delete_Delivery.Name = "Delete_Delivery";
            this.Delete_Delivery.Size = new System.Drawing.Size(75, 23);
            this.Delete_Delivery.TabIndex = 18;
            this.Delete_Delivery.Text = "删除";
            this.Delete_Delivery.UseVisualStyleBackColor = true;
            this.Delete_Delivery.Click += new System.EventHandler(this.Delete_Delivery_Click);
            // 
            // QueryDetail_Delivery
            // 
            this.QueryDetail_Delivery.Location = new System.Drawing.Point(352, 384);
            this.QueryDetail_Delivery.Name = "QueryDetail_Delivery";
            this.QueryDetail_Delivery.Size = new System.Drawing.Size(147, 23);
            this.QueryDetail_Delivery.TabIndex = 17;
            this.QueryDetail_Delivery.Text = "查询已选送货单明细";
            this.QueryDetail_Delivery.UseVisualStyleBackColor = true;
            this.QueryDetail_Delivery.Click += new System.EventHandler(this.QueryDetail_Delivery_Click);
            // 
            // Save_Delivery
            // 
            this.Save_Delivery.Location = new System.Drawing.Point(112, 384);
            this.Save_Delivery.Name = "Save_Delivery";
            this.Save_Delivery.Size = new System.Drawing.Size(75, 23);
            this.Save_Delivery.TabIndex = 16;
            this.Save_Delivery.Text = "保存";
            this.Save_Delivery.UseVisualStyleBackColor = true;
            this.Save_Delivery.Click += new System.EventHandler(this.Save_Delivery_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView4);
            this.tabPage5.Controls.Add(this.Delete_DeliveryDetail);
            this.tabPage5.Controls.Add(this.Query_DeliveryDetail);
            this.tabPage5.Controls.Add(this.Delivery_ID);
            this.tabPage5.Controls.Add(this.Save_DeliveryDetail);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(649, 452);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "送货明细表";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(40, 50);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(560, 310);
            this.dataGridView4.TabIndex = 12;
            this.dataGridView4.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView4_DefaultValuesNeeded);
            // 
            // Delete_DeliveryDetail
            // 
            this.Delete_DeliveryDetail.Location = new System.Drawing.Point(378, 392);
            this.Delete_DeliveryDetail.Name = "Delete_DeliveryDetail";
            this.Delete_DeliveryDetail.Size = new System.Drawing.Size(75, 23);
            this.Delete_DeliveryDetail.TabIndex = 11;
            this.Delete_DeliveryDetail.Text = "删除";
            this.Delete_DeliveryDetail.UseVisualStyleBackColor = true;
            this.Delete_DeliveryDetail.Click += new System.EventHandler(this.Delete_DeliveryDetail_Click);
            // 
            // Query_DeliveryDetail
            // 
            this.Query_DeliveryDetail.Location = new System.Drawing.Point(363, 18);
            this.Query_DeliveryDetail.Name = "Query_DeliveryDetail";
            this.Query_DeliveryDetail.Size = new System.Drawing.Size(75, 23);
            this.Query_DeliveryDetail.TabIndex = 10;
            this.Query_DeliveryDetail.Text = "查询";
            this.Query_DeliveryDetail.UseVisualStyleBackColor = true;
            this.Query_DeliveryDetail.Click += new System.EventHandler(this.Query_DeliveryDetail_Click);
            // 
            // Delivery_ID
            // 
            this.Delivery_ID.Location = new System.Drawing.Point(213, 18);
            this.Delivery_ID.Name = "Delivery_ID";
            this.Delivery_ID.Size = new System.Drawing.Size(100, 21);
            this.Delivery_ID.TabIndex = 9;
            // 
            // Save_DeliveryDetail
            // 
            this.Save_DeliveryDetail.Location = new System.Drawing.Point(146, 392);
            this.Save_DeliveryDetail.Name = "Save_DeliveryDetail";
            this.Save_DeliveryDetail.Size = new System.Drawing.Size(75, 23);
            this.Save_DeliveryDetail.TabIndex = 8;
            this.Save_DeliveryDetail.Text = "保存";
            this.Save_DeliveryDetail.UseVisualStyleBackColor = true;
            this.Save_DeliveryDetail.Click += new System.EventHandler(this.Save_DeliveryDetail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "送货单ID";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.Query_PurchaseReturn);
            this.tabPage3.Controls.Add(this.StockInID);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dataGridView5);
            this.tabPage3.Controls.Add(this.Delete_Return);
            this.tabPage3.Controls.Add(this.QueryDetail_Return);
            this.tabPage3.Controls.Add(this.Save_Return);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(649, 452);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "采购退货单";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "查询入库单ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Query_PurchaseReturn
            // 
            this.Query_PurchaseReturn.Location = new System.Drawing.Point(348, 16);
            this.Query_PurchaseReturn.Name = "Query_PurchaseReturn";
            this.Query_PurchaseReturn.Size = new System.Drawing.Size(75, 23);
            this.Query_PurchaseReturn.TabIndex = 20;
            this.Query_PurchaseReturn.Text = "查询";
            this.Query_PurchaseReturn.UseVisualStyleBackColor = true;
            this.Query_PurchaseReturn.Click += new System.EventHandler(this.Query_PurchaseReturn_Click);
            // 
            // StockInID
            // 
            this.StockInID.Location = new System.Drawing.Point(198, 16);
            this.StockInID.Name = "StockInID";
            this.StockInID.Size = new System.Drawing.Size(100, 21);
            this.StockInID.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "入库单ID";
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(40, 50);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.Height = 23;
            this.dataGridView5.Size = new System.Drawing.Size(560, 310);
            this.dataGridView5.TabIndex = 17;
            this.dataGridView5.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView5_DefaultValuesNeeded);
            // 
            // Delete_Return
            // 
            this.Delete_Return.Location = new System.Drawing.Point(198, 385);
            this.Delete_Return.Name = "Delete_Return";
            this.Delete_Return.Size = new System.Drawing.Size(75, 23);
            this.Delete_Return.TabIndex = 16;
            this.Delete_Return.Text = "删除";
            this.Delete_Return.UseVisualStyleBackColor = true;
            this.Delete_Return.Click += new System.EventHandler(this.Delete_Return_Click);
            // 
            // QueryDetail_Return
            // 
            this.QueryDetail_Return.Location = new System.Drawing.Point(318, 385);
            this.QueryDetail_Return.Name = "QueryDetail_Return";
            this.QueryDetail_Return.Size = new System.Drawing.Size(147, 23);
            this.QueryDetail_Return.TabIndex = 15;
            this.QueryDetail_Return.Text = "查询已选退货单明细";
            this.QueryDetail_Return.UseVisualStyleBackColor = true;
            this.QueryDetail_Return.Click += new System.EventHandler(this.QueryDetail_Return_Click);
            // 
            // Save_Return
            // 
            this.Save_Return.Location = new System.Drawing.Point(73, 385);
            this.Save_Return.Name = "Save_Return";
            this.Save_Return.Size = new System.Drawing.Size(75, 23);
            this.Save_Return.TabIndex = 14;
            this.Save_Return.Text = "保存";
            this.Save_Return.UseVisualStyleBackColor = true;
            this.Save_Return.Click += new System.EventHandler(this.Save_Return_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridView6);
            this.tabPage6.Controls.Add(this.Delete_ReturnDetail);
            this.tabPage6.Controls.Add(this.Query_ReturnDetail);
            this.tabPage6.Controls.Add(this.ReturnID);
            this.tabPage6.Controls.Add(this.Save_ReturnDetail);
            this.tabPage6.Controls.Add(this.label3);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(649, 452);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "采购退货明细表";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(40, 50);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowTemplate.Height = 23;
            this.dataGridView6.Size = new System.Drawing.Size(560, 310);
            this.dataGridView6.TabIndex = 12;
            this.dataGridView6.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView6_DefaultValuesNeeded);
            // 
            // Delete_ReturnDetail
            // 
            this.Delete_ReturnDetail.Location = new System.Drawing.Point(341, 388);
            this.Delete_ReturnDetail.Name = "Delete_ReturnDetail";
            this.Delete_ReturnDetail.Size = new System.Drawing.Size(75, 23);
            this.Delete_ReturnDetail.TabIndex = 11;
            this.Delete_ReturnDetail.Text = "删除";
            this.Delete_ReturnDetail.UseVisualStyleBackColor = true;
            this.Delete_ReturnDetail.Click += new System.EventHandler(this.Delete_ReturnDetail_Click);
            // 
            // Query_ReturnDetail
            // 
            this.Query_ReturnDetail.Location = new System.Drawing.Point(363, 18);
            this.Query_ReturnDetail.Name = "Query_ReturnDetail";
            this.Query_ReturnDetail.Size = new System.Drawing.Size(75, 23);
            this.Query_ReturnDetail.TabIndex = 10;
            this.Query_ReturnDetail.Text = "查询";
            this.Query_ReturnDetail.UseVisualStyleBackColor = true;
            this.Query_ReturnDetail.Click += new System.EventHandler(this.Query_ReturnDetail_Click);
            // 
            // ReturnID
            // 
            this.ReturnID.Location = new System.Drawing.Point(213, 18);
            this.ReturnID.Name = "ReturnID";
            this.ReturnID.Size = new System.Drawing.Size(100, 21);
            this.ReturnID.TabIndex = 9;
            // 
            // Save_ReturnDetail
            // 
            this.Save_ReturnDetail.Location = new System.Drawing.Point(155, 388);
            this.Save_ReturnDetail.Name = "Save_ReturnDetail";
            this.Save_ReturnDetail.Size = new System.Drawing.Size(75, 23);
            this.Save_ReturnDetail.TabIndex = 8;
            this.Save_ReturnDetail.Text = "保存";
            this.Save_ReturnDetail.UseVisualStyleBackColor = true;
            this.Save_ReturnDetail.Click += new System.EventHandler(this.Save_ReturnDetail_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "采购退货单ID";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.Delete_Supplier);
            this.tabPage7.Controls.Add(this.Save_Supplier);
            this.tabPage7.Controls.Add(this.dataGridView7);
            this.tabPage7.Controls.Add(this.label24);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(649, 452);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "供应商信息";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // Delete_Supplier
            // 
            this.Delete_Supplier.Location = new System.Drawing.Point(357, 387);
            this.Delete_Supplier.Name = "Delete_Supplier";
            this.Delete_Supplier.Size = new System.Drawing.Size(75, 23);
            this.Delete_Supplier.TabIndex = 5;
            this.Delete_Supplier.Text = "删除";
            this.Delete_Supplier.UseVisualStyleBackColor = true;
            this.Delete_Supplier.Click += new System.EventHandler(this.Delete_Supplier_Click);
            // 
            // Save_Supplier
            // 
            this.Save_Supplier.Location = new System.Drawing.Point(142, 387);
            this.Save_Supplier.Name = "Save_Supplier";
            this.Save_Supplier.Size = new System.Drawing.Size(75, 23);
            this.Save_Supplier.TabIndex = 4;
            this.Save_Supplier.Text = "保存";
            this.Save_Supplier.UseVisualStyleBackColor = true;
            this.Save_Supplier.Click += new System.EventHandler(this.Save_Supplier_Click);
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(40, 50);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.RowTemplate.Height = 23;
            this.dataGridView7.Size = new System.Drawing.Size(560, 310);
            this.dataGridView7.TabIndex = 3;
            this.dataGridView7.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView7_DefaultValuesNeeded);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 0;
            this.label24.Text = "供应商信息";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.Delete_SupplierMaterialDetatil);
            this.tabPage8.Controls.Add(this.Save_SupplierMaterialDetatil);
            this.tabPage8.Controls.Add(this.dataGridView8);
            this.tabPage8.Controls.Add(this.label25);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(649, 452);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "供应商物资明细";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // Delete_SupplierMaterialDetatil
            // 
            this.Delete_SupplierMaterialDetatil.Location = new System.Drawing.Point(381, 380);
            this.Delete_SupplierMaterialDetatil.Name = "Delete_SupplierMaterialDetatil";
            this.Delete_SupplierMaterialDetatil.Size = new System.Drawing.Size(75, 23);
            this.Delete_SupplierMaterialDetatil.TabIndex = 5;
            this.Delete_SupplierMaterialDetatil.Text = "删除";
            this.Delete_SupplierMaterialDetatil.UseVisualStyleBackColor = true;
            this.Delete_SupplierMaterialDetatil.Click += new System.EventHandler(this.Delete_SupplierMaterialDetatil_Click);
            // 
            // Save_SupplierMaterialDetatil
            // 
            this.Save_SupplierMaterialDetatil.Location = new System.Drawing.Point(116, 381);
            this.Save_SupplierMaterialDetatil.Name = "Save_SupplierMaterialDetatil";
            this.Save_SupplierMaterialDetatil.Size = new System.Drawing.Size(75, 23);
            this.Save_SupplierMaterialDetatil.TabIndex = 4;
            this.Save_SupplierMaterialDetatil.Text = "保存";
            this.Save_SupplierMaterialDetatil.UseVisualStyleBackColor = true;
            this.Save_SupplierMaterialDetatil.Click += new System.EventHandler(this.Save_SupplierMaterialDetatil_Click);
            // 
            // dataGridView8
            // 
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Location = new System.Drawing.Point(40, 50);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.RowTemplate.Height = 23;
            this.dataGridView8.Size = new System.Drawing.Size(560, 310);
            this.dataGridView8.TabIndex = 3;
            this.dataGridView8.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView8_DefaultValuesNeeded);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 10);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 12);
            this.label25.TabIndex = 0;
            this.label25.Text = "供应商物资信息";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 175);
            // 
            // PurchaseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 478);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PurchaseManagement";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button QueryDetail_PurchaseApplication;
        private System.Windows.Forms.Button Save_PurchaseApplication;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button Save_PurchaseDetail;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Button Delete_PurchaseApplication;
        private System.Windows.Forms.Button Delete_PurchaseDetail;
        private System.Windows.Forms.Button Query_PurchaseDetail;
        private System.Windows.Forms.TextBox PurchaseApplicationID;
        private System.Windows.Forms.Button Delete_Delivery;
        private System.Windows.Forms.Button QueryDetail_Delivery;
        private System.Windows.Forms.Button Save_Delivery;
        private System.Windows.Forms.Button Delete_DeliveryDetail;
        private System.Windows.Forms.Button Query_DeliveryDetail;
        private System.Windows.Forms.TextBox Delivery_ID;
        private System.Windows.Forms.Button Save_DeliveryDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Delete_Return;
        private System.Windows.Forms.Button QueryDetail_Return;
        private System.Windows.Forms.Button Save_Return;
        private System.Windows.Forms.Button Delete_ReturnDetail;
        private System.Windows.Forms.Button Query_ReturnDetail;
        private System.Windows.Forms.TextBox ReturnID;
        private System.Windows.Forms.Button Save_ReturnDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Delete_Supplier;
        private System.Windows.Forms.Button Save_Supplier;
        private System.Windows.Forms.Button Delete_SupplierMaterialDetatil;
        private System.Windows.Forms.Button Save_SupplierMaterialDetatil;
        private System.Windows.Forms.Button QueryDelivery_PurchaseApplication;
        private System.Windows.Forms.Button Query_Delivery;
        private System.Windows.Forms.TextBox PurchaseApplicationID2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Query_PurchaseReturn;
        private System.Windows.Forms.TextBox StockInID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OpenMaterialQuery;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button OpenEmployeeQuery;
    }
}