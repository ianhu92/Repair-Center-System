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
    public partial class EntryApplicationQuery : Form
    {
        public EntryApplicationQuery()
        {
            InitializeComponent();
        }

        private void EntryApplicationQuery_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“repairCenterDataSet.EntryApplicationLearningInformation”中。您可以根据需要移动或删除它。
            this.entryApplicationLearningInformationTableAdapter.Fill(this.repairCenterDataSet.EntryApplicationLearningInformation);
            // TODO: 这行代码将数据加载到表“repairCenterDataSet.EntryApplication”中。您可以根据需要移动或删除它。
            this.entryApplicationTableAdapter.Fill(this.repairCenterDataSet.EntryApplication);

        }
    }
}
