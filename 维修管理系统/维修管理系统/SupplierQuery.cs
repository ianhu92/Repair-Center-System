﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 维修管理系统
{
    public partial class SupplierQuery : Form
    {
        public SupplierQuery()
        {
            InitializeComponent();
        }

        private void SupplierQuery_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“repairCenterDataSet.Supplier”中。您可以根据需要移动或删除它。
            this.supplierTableAdapter.Fill(this.repairCenterDataSet.Supplier);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
