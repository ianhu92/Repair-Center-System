using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 维修管理系统
{
    public partial class UserManagement : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommandBuilder cb = new SqlCommandBuilder();
        SqlCommand cmd = new SqlCommand();
        private string sql = "select UserID,UserName,Password from Users";

        DataSet ds2 = new DataSet();
        SqlDataAdapter da2 = new SqlDataAdapter();
        SqlCommandBuilder cb2 = new SqlCommandBuilder();
        SqlCommand cmd2 = new SqlCommand();
        private string sql2 = "select Users.UserID,Users.UserName,Employee.Name,Employee.EmployeeID from Users,Employee,ManagerUser "+
            "where Users.UserID=ManagerUser.UserID and ManagerUser.EmployeeID=Employee.EmployeeID";

        DataSet ds3 = new DataSet();
        SqlDataAdapter da3 = new SqlDataAdapter();
        SqlCommandBuilder cb3 = new SqlCommandBuilder();
        SqlCommand cmd3 = new SqlCommand();
        private string sql3 = "select ManagerUserID,UserID,EmployeeID from ManagerUser";

        DataSet ds4 = new DataSet();
        SqlDataAdapter da4 = new SqlDataAdapter();
        SqlCommandBuilder cb4 = new SqlCommandBuilder();
        SqlCommand cmd4 = new SqlCommand();
        private string sql4 = "select * from User_Authority";

        private string connString = "Data Source=IAN-PC\\Ian;Initial Catalog=RepairCenter;Persist Security Info=True;User ID=sa;Password=sa";
        int ButtonClicked = 0;

        public UserManagement()
        {
            InitializeComponent();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            label3.Text = "欢迎你，" + Form1.employeeNameString;
            // cmd = conn.CreateCommand();
            // cmd.CommandText = "select * from TEST_Table";
            // SqlDataAdapter da = new SqlDataAdapter(cmd);
            // private string tableName = "test";
            //da.Fill(ds, "test");
            //dataGridView1.DataSource = ds.Tables[tableName];
            refreshDataGridView1();
            refreshDataGridView2();
            refreshDataGridView3();
            refreshDataGridView4();
        }
        private void refreshDataGridView1()
        {
            ds.Clear();
            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[0].HeaderText = "账号ID";
            dataGridView1.Columns[1].HeaderText = "账号/用户名";
            dataGridView1.Columns[2].HeaderText = "密码";
        }
        private void refreshDataGridView2()
        {
            ds2.Clear();
            SqlConnection conn2 = new SqlConnection(connString);
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn2);
            da2.Fill(ds2);
            dataGridView2.DataSource = ds2.Tables[0];
            dataGridView2.Columns[0].HeaderText = "账号ID";
            dataGridView2.Columns[1].HeaderText = "账号/用户名";
            dataGridView2.Columns[2].HeaderText = "员工姓名";
            dataGridView2.Columns[3].HeaderText = "员工ID";
        }
        private void refreshDataGridView3()
        {
            ds3.Clear();
            SqlConnection conn3 = new SqlConnection(connString);
            SqlDataAdapter da3 = new SqlDataAdapter(sql3, conn3);
            da3.Fill(ds3);
            dataGridView3.DataSource = ds3.Tables[0];
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Columns[1].HeaderText = "账号ID";
            dataGridView3.Columns[2].HeaderText = "员工ID";
        }
        private void refreshDataGridView4()
        {
            ds4.Clear();
            SqlConnection conn4 = new SqlConnection(connString);
            SqlDataAdapter da4 = new SqlDataAdapter(sql4, conn4);
            da4.Fill(ds4);
            dataGridView4.DataSource = ds4.Tables[0];
            dataGridView4.Columns[0].Visible = false;
            dataGridView4.Columns[1].HeaderText = "账号ID";
            dataGridView4.Columns[2].HeaderText = "权限ID";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (ButtonClicked == 0 && MessageBox.Show("确认修改账号信息？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
                ||ButtonClicked==1)
            {
                SqlConnection conn = new SqlConnection(connString);
                cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                try
                {
                    da.Update(ds);
                    
                    if (ButtonClicked == 0)
                    {
                        MessageBox.Show("保存成功");
                    }
                    else
                    {
                        MessageBox.Show("删除成功");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                dataGridView1.Update();
                refreshDataGridView1();
                ButtonClicked = 0;
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确认删除此账号？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                        dataGridView1.Rows.Remove(dataGridView1.SelectedRows[i]);
                    ButtonClicked = 1;
                    Save_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }

        private void Save2_Click(object sender, EventArgs e)
        {
            if (ButtonClicked == 0 && MessageBox.Show("确认修改账号信息？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
                || ButtonClicked == 1)
            {
                SqlConnection conn3 = new SqlConnection(connString);
                cmd3 = conn3.CreateCommand();
                cmd3.CommandText = sql3;
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                SqlCommandBuilder cb3 = new SqlCommandBuilder(da3);
                try
                {
                    da3.Update(ds3);
                    
                    if (ButtonClicked == 0)
                    {
                        MessageBox.Show("保存成功");
                    }
                    else
                    {
                        MessageBox.Show("删除成功");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                dataGridView3.Update();
                refreshDataGridView2();
                refreshDataGridView3();
                ButtonClicked = 0;
            }
        }

        private void Delete2_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确认删除此账号？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < dataGridView3.SelectedRows.Count; i++)
                        dataGridView3.Rows.Remove(dataGridView3.SelectedRows[i]);
                    ButtonClicked = 1;
                    Save2_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }
        
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "账号管理")
            {
                if (treeView1.SelectedNode.Parent != null)
                {
                    tabcontrol1.SelectedTab = tabPage1;
                }
            }
            else
            {
                tabcontrol1.SelectedTab = tabPage2;
            }
        }

        private void OpenUserQuery_Click(object sender, EventArgs e)
        {
            UserQuery userQuery = new UserQuery();
            userQuery.ShowDialog();
        }

        private void OpenEmployeeQuery_Click(object sender, EventArgs e)
        {
            EmployeeQuery employeeQuery = new EmployeeQuery();
            employeeQuery.ShowDialog();
        }

        private void Save3_Click(object sender, EventArgs e)
        {
            if (ButtonClicked == 0 && MessageBox.Show("确认修改账号信息？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
                || ButtonClicked == 1)
            {
                SqlConnection conn4 = new SqlConnection(connString);
                cmd4 = conn4.CreateCommand();
                cmd4.CommandText = sql4;
                SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                SqlCommandBuilder cb4 = new SqlCommandBuilder(da4);
                try
                {
                    da4.Update(ds4);

                    if (ButtonClicked == 0)
                    {
                        MessageBox.Show("保存成功");
                    }
                    else
                    {
                        MessageBox.Show("删除成功");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                dataGridView4.Update();
                refreshDataGridView4();
                ButtonClicked = 0;
            }
        }

        private void Delete3_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确认删除此账号？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < dataGridView4.SelectedRows.Count; i++)
                        dataGridView4.Rows.Remove(dataGridView4.SelectedRows[i]);
                    ButtonClicked = 1;
                    Save3_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthorityQuery authorityQuery = new AuthorityQuery();
            authorityQuery.ShowDialog();
        }

        
    }
}
