using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class doSignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Clear();
        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        
        string username = Request.QueryString["username"];
        string password = Request.QueryString["password"];

        string sql = "select UserName from Users where UserName='" + username+"'";
        conn.Open();
        SqlCommand comm = new SqlCommand(sql, conn);
        SqlDataReader dr = comm.ExecuteReader();
        if (dr.HasRows)
        {
            Response.Write("此账户已注册");
            return;
        }
        dr.Close();

        sql = "insert into Users values('" + username + "','" + password + "')";
        comm = new SqlCommand(sql,conn);
        comm.ExecuteNonQuery();
        Response.Write("注册成功");
        conn.Close();
    }
}