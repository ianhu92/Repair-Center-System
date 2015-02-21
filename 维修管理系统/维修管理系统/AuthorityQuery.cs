using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 维修管理系统
{
    public partial class AuthorityQuery : Form
    {
        public AuthorityQuery()
        {
            InitializeComponent();
        }

        private void AuthorityQuery_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“repairCenterDataSet.Authority”中。您可以根据需要移动或删除它。
            this.authorityTableAdapter.Fill(this.repairCenterDataSet.Authority);

        }
    }
}
