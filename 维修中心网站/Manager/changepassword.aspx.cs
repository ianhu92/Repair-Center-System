using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class changepassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["managerID"] == null)
        {
            //Response.Write("<script type='text/javascript'>alert('请登录');window.location='../Index.aspx'</script>");
        }
    }
    protected void btnChange_Click(object sender, EventArgs e)
    {
        Response.Clear();
        if (txtNewPwd.Text == txtNewPwdA.Text)
        {
            string username = Session["managerID"].ToString();
            string owdPwd = txtOldPwd.Text;
            string newPwd = txtNewPwd.Text;

            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
            string sql = "select managerID from manager where managerID='" + username + "' and pwd='"+owdPwd+"'";
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader dr = comm.ExecuteReader();
            if (!dr.HasRows)
            {
                Response.Write("<script type='text/javascript'>alert('原密码错误');</script>");
                return;
            }
            dr.Close();

            sql = "update Manager set pwd='" + newPwd + "' where managerID='" + username + "'";
            comm = new SqlCommand(sql, conn);
            comm.ExecuteNonQuery();
            Response.Write("<script type='text/javascript'>alert('修改成功')</script>");
            conn.Close();
        }
        else
        {
            Response.Write("<script type='text/javascript'>alert('两次输入的新密码不一致')</script>");
            txtNewPwd.Text = "";
            txtNewPwdA.Text = "";
        }
    }
}