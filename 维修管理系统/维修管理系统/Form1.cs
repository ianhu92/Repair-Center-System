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
    public partial class Form1 : Form
    {
        public static string employeeNameString = "";
        public static string userIDString = "";
        public static int Authority1 = 0;
        public static int Authority2 = 0;
        public static int Authority3 = 0;
        public static int Authority4 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authority1 = 0;
            Authority2 = 0;
            Authority3 = 0;
            Authority4 = 0;
            WrongHint.Visible = false;
            SqlConnection conn = new SqlConnection("Data Source=Ian-PC\\Ian;Initial Catalog=RepairCenter;Integrated Security=True");
            conn.Open();
            string sql = "select Employee.Name,Users.UserID from Employee,Users,ManagerUser where Users.UserName='" + userName.Text + "' and Password='" + password.Text + 
                "' and Users.UserID=ManagerUser.UserID and ManagerUser.EmployeeID=Employee.EmployeeID";
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                userIDString = dr[1].ToString();
                employeeNameString = dr[0].ToString();
            }
            else
            {
                WrongHint.Visible = true;
                password.Text = "";
                return;
            }
            dr.Close();
            sql = "select User_Authority.AuthorityID from User_Authority,Users where Users.UserName='" + userName.Text + "' and Users.UserID=User_Authority.UserID";
            comm = new SqlCommand(sql, conn);
            dr = comm.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString().Equals("1"))
                {
                    Authority1 = 1;
                }
                else if (dr[0].ToString().Equals("2"))
                {
                    Authority2 = 1;
                }
                else if (dr[0].ToString().Equals("3"))
                {
                    Authority3 = 1;
                }
                else if (dr[0].ToString().Equals("4"))
                {
                    Authority4 = 1;
                }
                
            }
            dr.Close();
            

            if (ManagerRadioButton.Checked == true)
            {
                sql = "select * from User_Authority,Users where Users.UserName='"+userName.Text+"' and Users.UserID=User_Authority.UserID and User_Authority.AuthorityID=5";
                comm = new SqlCommand(sql, conn);
                dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("登录成功，已进入管理员界面。");
                    UserManagement usermanagerment = new UserManagement();
                    usermanagerment.ShowDialog();
                }
                else
                {
                    MessageBox.Show("你不是管理员。登录失败");
                }
                dr.Close();
            }
            else
            {
                MessageBox.Show("登录成功，已进入用户界面。");
                Form2 form2 = new Form2(); 
                form2.ShowDialog();
            }
            conn.Close();
            password.Text = "";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
