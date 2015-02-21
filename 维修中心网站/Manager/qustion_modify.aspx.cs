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
    public partial class qustion_modify : System.Web.UI.Page
    {

        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["managerID"] == null)
            {
                //Response.Write("<script type='text/javascript'>alert('请登录');window.location='../Index.aspx'</script>");
                //return;
            }
            id = Request.QueryString["qustionID"].ToString();
            SqlConnection conn = DataOperation.DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Question where questionID=" + id, conn);
            SqlDataReader re = cmd.ExecuteReader();
            while (re.Read())
            {
                lblTeacher.Text = re["questionID"].ToString();
                txtContent.Text = re["Title"].ToString();
                txtAnsA.Text = re["Ans1"].ToString();
                txtAnsB.Text = re["Ans2"].ToString();
                txtAnsC.Text = re["Ans3"].ToString();
                txtAnsD.Text = re["Ans4"].ToString();
                DropDownList1.SelectedValue = re["Type"].ToString();
                cbShare.Checked = (bool)re["pub"];
                RadioButtonList1.SelectedValue = re["keyAns"].ToString().Trim();

            }
            conn.Close();
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            id = Request.QueryString["qustionID"].ToString();
            string str = "update Question set Title='" + txtContent.Text.Trim() + "',Ans1='" + txtAnsA.Text.Trim() + "',Ans2='" + txtAnsB.Text.Trim() + "',Ans3='" + txtAnsC.Text.Trim() + "',Ans4='" + txtAnsD.Text.Trim() + "', keyAns='" + RadioButtonList1.SelectedValue + "', Type='" + DropDownList1.SelectedValue + "', pub='" + cbShare.Checked + "' where questionID='" + id + "'";
            DataOperation.OperateData(str);
            Response.Write("<script type='text/javascript'>alert('保存成功');window.location='viewqustion.aspx';</script>");
            Response.End();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            id = Request.QueryString["qustionID"].ToString();
            string str = "Delete from Question where questionID="+id;
            DataOperation.OperateData(str);
            Response.Write("<script type='text/javascript'>alert('删除成功');window.location='viewqustion.aspx';</script>");
            Response.End();
        }

    }
}