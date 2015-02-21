using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Exam.Code;
using System.Drawing;

public partial class Student_changepassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] == null)
        {
            Response.Write("<script type='text/javascript'>alert('请登录');top.location='../Index.aspx'</script>");
            return;
        }
    }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            if (Session["UserID"] != null)
            {
                if (txtOldPwd.Text!=null)
                {
                    string strsql = "update Users set password='" + txtNewPwdA.Text.Trim() + "' where UserID='" + Session["UserID"].ToString() + "'";
                    DataOperation.OperateData(strsql);
                    lblMessage.ForeColor = Color.Blue;
                    lblMessage.Text = "密码修改成功";
                    txtNewPwd.Text = "";
                    txtNewPwdA.Text = "";
                    txtOldPwd.Text = "";

                }
                else
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "旧密码错误";
                    txtOldPwd.Text = "";
                    txtOldPwd.Focus();
                    return;
                }
            }
        }
    
}