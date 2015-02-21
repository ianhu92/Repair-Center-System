using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam.Admin
{
    public partial class viewqustion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["managerID"] == null)
            {
                //Response.Write("<script type='text/javascript'>alert('请登录');window.location='../Index.aspx'</script>");
            }
        }
    }
}