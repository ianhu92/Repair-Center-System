using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class doLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Clear();
        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        
        string username = Request.QueryString["username"];
        string password = Request.QueryString["password"];
        string userType = Request.QueryString["userType"];
        
        conn.Open();

        string sql;
        sql = "select UserID from Users where UserName='"+username+"' and Password='"+password+"'";
        SqlCommand comm = new SqlCommand(sql, conn);
        SqlDataReader dr = comm.ExecuteReader();
        if (dr.Read())
        {
            Session["UserID"] = dr[0];
            Session["UserType"] = "User";
            Session["UserName"] = username;
        }
        else
        {
            Response.Write("Wrong");
        }
        dr.Close();
        

        if (userType == "Manager")
        {
            //sql="select * from User_Authority,Users where Users.UserName='"+username+"' and Users.UserID=User_Authority.UserID and User_Authority.AuthorityID=6";
            sql = "select Users.UserID from ManagerUser,Users,User_Authority where ManagerUser.UserID=Users.UserID and Users.UserName='" + username + "' and Users.UserID=User_Authority.UserID and User_Authority.AuthorityID=6";
            comm = new SqlCommand(sql, conn);
            dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                Session["UserType"] = "Manager";
                dr.Close();
                sql = "select Employee.Name from Employee,ManagerUser,Users where Employee.EmployeeID=ManagerUser.EmployeeID and ManagerUser.UserID=Users.UserID " +
                    "and Users.UserName='" + username + "'";
                comm = new SqlCommand(sql, conn);
                dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    Session["ManagerName"] = dr[0];
                }
                Response.Write("Manager");
            }
            else
            {
                Response.Write("Not Manager");
            }
            dr.Close();
        }
        else
        {
            Response.Write("User");
        }
        //dr.Close();
        conn.Close();
    }
}