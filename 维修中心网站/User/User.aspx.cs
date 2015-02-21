using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam.Student
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Write("<script type='text/javascript'>alert('请登录');top.location='../Index.aspx'</script>");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<script langauge='javascript'>alert(a,a);</script>");
        }
}
}