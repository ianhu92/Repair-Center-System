using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Exam.Code;

namespace Exam.Admin
{
    public partial class question_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["managerID"] != null)
            {
                lblTeacher.Text = Session["managerID"].ToString();
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DataOperation.DBCon();
            string str = "INSERT INTO Question(Title,Type,Ans1,Ans2,Ans3,Ans4,keyAns,pub) VALUES('" + txtContent.Text.Trim() + "','" + DropDownList1.SelectedItem.Value.Trim() + "','" + txtAnsA.Text.Trim() + "','" + txtAnsB.Text.Trim() + "','" + txtAnsC.Text.Trim() + "','" + txtAnsD.Text.Trim() + "','" + RadioButtonList1.SelectedValue.Trim() + "','" + cbShare.Checked.ToString() + "')";
            SqlCommand cmd = new SqlCommand(str, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            Response.Write("<script lanuage=javascript>alert('出题成功！')</script>");
            conn.Close();
            txtContent.Text = "";
            txtAnsA.Text = "";
            txtAnsB.Text = "";
            txtAnsC.Text = "";
            txtAnsD.Text = "";
            for (int i = 0; i < RadioButtonList1.Items.Count; i++)
            { RadioButtonList1.Items[i].Selected = false; }
        }
    }
}