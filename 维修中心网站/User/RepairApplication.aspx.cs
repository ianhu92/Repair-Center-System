using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class User_RepairApplication : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] == null)
        {
            Response.Write("<script type='text/javascript'>alert('请登录');top.location='../Index.aspx'</script>");
        }
        String userid = Session["UserID"].ToString();
        TextBox2.Text = userid;
        //TextBox2.Visible = false;
        //string a = ListView1.InsertItem.ID;
    }
    protected void InsertButton_Click(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        conn.Open();
        string b = ApplicantID.Text;
        
        
        string sql;
        sql = "insert into RepairApplication (ApplicantID,Phone,Area,Building,Room,ApplicationReason,Date)"+
        "values('" + ApplicantID.Text + "','" + Phone.Text + "','" + Area.Text + "','" + Building.Text + "','" + Room.Text + "','" + ApplicationReason.Text + "','" +Convert.ToDateTime( Date.Text) + "')";
        SqlCommand comm = new SqlCommand(sql, conn);
        int i= comm.ExecuteNonQuery();
        if (i != 0)
        {
            Response.Write("<script language='javascript'>alert('添加成功');</script>");
        }
        else
        {
            Response.Write("<script language='javascript'>alert('添加失败');</script>");
        }
    }
}