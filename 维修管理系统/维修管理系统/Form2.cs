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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = "欢迎你，" + Form1.employeeNameString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.Authority1 == 1)
            {
                MaterialManagerment materialManagerment = new MaterialManagerment();
                materialManagerment.ShowDialog();
            }
            else
            {
                MessageBox.Show("无权限");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form1.Authority2 == 1)
            {
                PurchaseManagement purchaseManagement = new PurchaseManagement();
                purchaseManagement.ShowDialog();
            }
            else
            {
                MessageBox.Show("无权限");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form1.Authority3 == 1)
            {
                RepairManagement repairManagement = new RepairManagement();
                repairManagement.ShowDialog();
            }
            else
            {
                MessageBox.Show("无权限");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Form1.Authority4 == 1)
            {
                HRManagement HRManagement = new HRManagement();
                HRManagement.ShowDialog();
            }
            else
            {
                MessageBox.Show("无权限");
            }
        }
    }
}
