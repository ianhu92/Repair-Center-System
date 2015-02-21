using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class User_EntryApplication : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TBUserID.Text = Session["UserID"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label26.Visible = false;
        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        conn.Open();
        string sql = "INSERT INTO EntryApplication ([UserID],[Name],[Sex],[Hometown],[Nation],[BirthYear],[BirthMonth],[HouseholdRegisterType]" +
            ",[PoliticalLandscape],[EducationBackground],[MaritalStatus],[IsOutGoingEmploymentCard],[BirthControlCertificateNumber]" +
            ",[HouseholdRegisterLocation],[IDNumber],[CurrentAddress],[Phone],[Position],[ArrivalTime],[Craft]" +
            ",[TechnicalTitle],[Certificate],[Specialty]) VALUES ('" + TBUserID.Text + "','" + TBName.Text + "','" + CBSex.Text + "','" + TBHometown.Text +
            "','" + TBNation.Text + "','" + TBYear.Text + "','" + TBMonth.Text + "','" + CBHouseholdRegisterType.Text +
            "','" + TBPoliticalLandscape.Text + "','" + CBEducationBackground.Text + "','" + CBMaritalStatus.Text + "','" + CBIsOutGoingEmploymentCard.Text +
            "','" + TBBirthControlCertificateNumber.Text + "','" + TBHouseholdRegisterLocation.Text + "','" + TBIDNumber.Text + "','" + TBCurrentAddress.Text +
            "','" + TBPhone.Text + "','" + TBPosition.Text + "','" + TBArrivalTime.Text + "','" +  TBCraft.Text + "','" + TBTechnicalTitle.Text +
            "','" + TBCertificate.Text + "','" + TBSpecialty.Text + "')";
        SqlCommand comm = new SqlCommand(sql, conn);
        try
        {
            comm.ExecuteNonQuery();
            //QueryStatus();
            Label26.Visible = true;
            Label26.Text = "保存成功";
            //Response.Write("<script language='javascript'>alert('保存成功');</script>");
        }
        catch (Exception exception)
        {
            Label26.Visible = true;
            Label26.Text = exception.Message;
            //Response.Write("<script language='javascript'>alert("+exception.Message+"');</script>");
            return;
        }
        sql = "select EntryApplicationID from EntryApplication order by EntryApplicationID DESC";
        comm = new SqlCommand(sql, conn);
        SqlDataReader dr = comm.ExecuteReader();
        {
            //TBEntryApplicationID.Text = dr[0].ToString();
            //EntryApplicationID.Text = dr[0].ToString();
        }
        dr.Close();
        conn.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Write("<script language='javascript>clearText();</script>");
        //foreach (Control ctl in form1)
        //{
        //    if (ctl.GetType().ToString() == "System.Windows.Forms.TextBox")
        //    {
        //        if (ctl.Name != "TBEntryApplicationID" && ctl.Name != "TBUserID")
        //        {
        //            TextBox a = (TextBox)ctl;
        //            a.Text = "";
        //        }
        //    }
        //    else if (ctl.GetType().ToString() == "System.Windows.Forms.ComboBox")
        //    {
        //        ComboBox a = (ComboBox)ctl;
        //        a.SelectedIndex = -1;
        //    }
        //}
    }
}