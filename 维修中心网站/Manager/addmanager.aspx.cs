using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Manager_addmanager : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["managerID"] == null)
        {
            //Response.Write("<script type='text/javascript'>alert('请登录');top.location='../Index.aspx'</script>");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox3.Text == TextBox4.Text)
        {
            string username = TextBox1.Text;
            string name = TextBox2.Text;
            string password = TextBox3.Text;
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
            string sql = "select managerID from Manager where managerID='" + username + "'";
            conn.Open();

            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                Response.Write("<script type='text/javascript'>alert('已存在此账号')</script>");
                return;
            }
            dr.Close();

            sql="insert into Manager values('"+username+"','"+name+"','"+password+"')";
            comm = new SqlCommand(sql, conn);
            comm.ExecuteNonQuery();
            Response.Write("<script type='text/javascript'>alert('添加成功')</script>");
            conn.Close();
        }

        else 
        {
            Response.Write("<script type='text/javascript'>alert('两次密码输入不一致')</script>");
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

        

    }
}