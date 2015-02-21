using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam.Student
{
    public partial class left_nav : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Write("<script type='text/javascript'>alert('请登录');top.location='../Index.aspx'</script>");
                return;
            }
        }
    }
}