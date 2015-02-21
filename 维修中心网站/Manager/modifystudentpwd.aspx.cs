using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class modifystudent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["managerID"] == null)
        {
            //Response.Write("<script type='text/javascript'>alert('请登录');window.location='../Index.aspx'</script>");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Clear();
        if (TextBox2.Text == TextBox3.Text)
        {
            string username = TextBox1.Text;
            string password = TextBox2.Text;

            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
            string sql = "select studentID from Student where studentID='" + username + "'";
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader dr = comm.ExecuteReader();
            if (!dr.HasRows)
            {
                Response.Write("没有此账号");
                return;
            }
            dr.Close();

            sql = "update Student set spwd='"+password+"' where studentID='"+username+"'";
            comm = new SqlCommand(sql, conn);
            comm.ExecuteNonQuery();
            Response.Write("<script type='text/javascript'>alert('修改成功')</script>");
            conn.Close();
        }
        else
        {
            Response.Write("<script type='text/javascript'>alert('两次输入密码不一致')</script>");
            TextBox2.Text = "";
            TextBox3.Text = "";
        }
    }
}