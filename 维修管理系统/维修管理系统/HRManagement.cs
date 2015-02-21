using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 维修管理系统
{
    public partial class HRManagement : Form
    {
        public HRManagement()
        {
            InitializeComponent();
        }
        private string saveType = "";private int isEditing = 0; private int isAdding = 0; private int isWriting = 0;
        private string saveType2 = ""; private int isEditing2 = 0; private int isAdding2 = 0; private int isWriting2 = 0;

        private void TextBoxCanWrite()
        {
            foreach (Control ctl in panel2.Controls)
            {
                if (ctl.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    TextBox a = (TextBox)ctl;
                    a.ReadOnly = false;
                }
                if (ctl.GetType().ToString() == "System.Windows.Forms.ComboBox")
                {
                    ComboBox a = (ComboBox)ctl;
                    a.Enabled = true;
                }
                TBEntryApplicationID.ReadOnly = true;
                TBUserID.ReadOnly = true;
            }
            isWriting = 1;
        }
        private void TextBoxCanNotWrite()
        {
            foreach (Control ctl in panel2.Controls)
            {
                if (ctl.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    TextBox a = (TextBox)ctl;
                    a.ReadOnly = true;
                }
                if (ctl.GetType().ToString() == "System.Windows.Forms.ComboBox")
                {
                    ComboBox a = (ComboBox)ctl;
                    a.Enabled = false;
                }
            }
            isWriting = 0;
        }
        private Boolean SaveVerification()
        {
            foreach (Control ctl in panel2.Controls)
            {
                if (ctl.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    TextBox a = (TextBox)ctl;
                    if (a.Name != "TBEntryApplicationID" && a.Name != "TBUserID" && a.Name != "TBBirthControlCertificateNumber"
                        && a.Name != "TBResignationTime" && a.Name != "TBSpecialty" && a.Name != "TBCraft")
                    {
                        if (a.Text == "")
                        {
                            ctl.BackColor = Color.Red;
                            MessageBox.Show("请填写必填内容");
                            return false;
                        }
                    }
                }
                if (ctl.GetType().ToString() == "System.Windows.Forms.ComboBox")
                {
                    ComboBox a = (ComboBox)ctl;
                    if (a.Text == "")
                    {
                        ctl.BackColor = Color.Red;
                        MessageBox.Show("请填写必填内容");
                        return false;
                    }
                }
            }
            return true;
        }
        private void QueryStatus()
        {
            TextBoxCanNotWrite();
            Add_EntryApplication.Enabled = false;
            Edit_EntryApplication.Enabled = true;
            Save_EntryApplication.Enabled = false;
            Delete_EntryApplication.Enabled = true;
            Clear_EntryApplication.Enabled = true;
            QueryLearningDetail_EntryApplication.Enabled = true;
        }
        private void TextBoxCanWrite2()
        {
            foreach (Control ctl in panel5.Controls)
            {
                if (ctl.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    TextBox a = (TextBox)ctl;
                    a.ReadOnly = false;
                }
                if (ctl.GetType().ToString() == "System.Windows.Forms.ComboBox")
                {
                    ComboBox a = (ComboBox)ctl;
                    a.Enabled = true;
                }
                TBEmployeeID2.ReadOnly = true;
            }
            isWriting = 1;
        }
        private void TextBoxCanNotWrite2()
        {
            foreach (Control ctl in panel5.Controls)
            {
                if (ctl.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    TextBox a = (TextBox)ctl;
                    a.ReadOnly = true;
                }
                if (ctl.GetType().ToString() == "System.Windows.Forms.ComboBox")
                {
                    ComboBox a = (ComboBox)ctl;
                    a.Enabled = false;
                }
            }
            isWriting = 0;
        }
        private Boolean SaveVerification2()
        {
            foreach (Control ctl in panel5.Controls)
            {
                if (ctl.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    TextBox a = (TextBox)ctl;
                    if (a.Name != "TBEmployeeID2" && a.Name != "TBBirthControlCertificateNumber2"
                        && a.Name != "TBResignationTime2" && a.Name != "TBSpecialty2" && a.Name != "TBCraft2")
                    {
                        if (a.Text == "")
                        {
                            ctl.BackColor = Color.Red;
                            MessageBox.Show("请填写必填内容");
                            return false;
                        }
                    }
                }
                if (ctl.GetType().ToString() == "System.Windows.Forms.ComboBox")
                {
                    ComboBox a = (ComboBox)ctl;
                    if (a.Text == "")
                    {
                        ctl.BackColor = Color.Red;
                        MessageBox.Show("请填写必填内容");
                        return false;
                    }
                }
            }
            return true;
        }
        private void QueryStatus2()
        {
            TextBoxCanNotWrite2();
            Add_Employee.Enabled = false;
            Edit_Employee.Enabled = true;
            Save_Employee.Enabled = false;
            Delete_Employee.Enabled = true;
            Clear_Employee.Enabled = true;
            QueryDetail_Employee.Enabled = true;
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“repairCenterDataSet1.EntryApplication”中。您可以根据需要移动或删除它。
            this.entryApplicationTableAdapter.Fill(this.repairCenterDataSet1.EntryApplication);
            // TODO: 这行代码将数据加载到表“repairCenterDataSet.EntryApplication”中。您可以根据需要移动或删除它。
            this.entryApplicationTableAdapter.Fill(this.repairCenterDataSet.EntryApplication);
            // TODO: 这行代码将数据加载到表“repairCenterDataSet19.ResignationHandover”中。您可以根据需要移动或删除它。
            this.resignationHandoverTableAdapter.Fill(this.repairCenterDataSet19.ResignationHandover);
            this.bindingNavigator1.BindingSource = resignationHandoverBindingSource;
            // TODO: 这行代码将数据加载到表“repairCenterDataSet18.EmployeeEvaluation”中。您可以根据需要移动或删除它。
            this.employeeEvaluationTableAdapter.Fill(this.repairCenterDataSet18.EmployeeEvaluation);
            this.bindingNavigator2.BindingSource = employeeEvaluationBindingSource;
            // TODO: 这行代码将数据加载到表“repairCenterDataSet17.CheckAttendance”中。您可以根据需要移动或删除它。
            this.checkAttendanceTableAdapter.Fill(this.repairCenterDataSet17.CheckAttendance);
            this.bindingNavigator3.BindingSource = checkAttendanceBindingSource;
            // TODO: 这行代码将数据加载到表“repairCenterDataSet16.EmployeeFamilyInformation”中。您可以根据需要移动或删除它。
            this.employeeFamilyInformationTableAdapter.Fill(this.repairCenterDataSet16.EmployeeFamilyInformation);
            this.bindingNavigator4.BindingSource = employeeFamilyInformationBindingSource;
            // TODO: 这行代码将数据加载到表“repairCenterDataSet15.EmployeeTrainInformation”中。您可以根据需要移动或删除它。
            this.employeeTrainInformationTableAdapter.Fill(this.repairCenterDataSet15.EmployeeTrainInformation);
            this.bindingNavigator5.BindingSource = employeeTrainInformationBindingSource;
            // TODO: 这行代码将数据加载到表“repairCenterDataSet14.EmploymentLearningInformation”中。您可以根据需要移动或删除它。
            this.employmentLearningInformationTableAdapter.Fill(this.repairCenterDataSet14.EmploymentLearningInformation);
            this.bindingNavigator6.BindingSource = employmentLearningInformationBindingSource;
            // TODO: 这行代码将数据加载到表“repairCenterDataSet13.EntryApplicationLearningInformation”中。您可以根据需要移动或删除它。
            this.entryApplicationLearningInformationTableAdapter.Fill(this.repairCenterDataSet13.EntryApplicationLearningInformation);
            this.bindingNavigator7.BindingSource = entryApplicationLearningInformationBindingSource;
            
        }

        private void 查询ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.entryApplicationLearningInformationTableAdapter.查询(this.repairCenterDataSet13.EntryApplicationLearningInformation, ((int)(System.Convert.ChangeType(入职申请IDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void 员工学习信息查询ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employmentLearningInformationTableAdapter.员工学习信息查询(this.repairCenterDataSet14.EmploymentLearningInformation, ((int)(System.Convert.ChangeType(员工信息IDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void 员工培训信息查询ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeTrainInformationTableAdapter.员工培训信息查询(this.repairCenterDataSet15.EmployeeTrainInformation, ((int)(System.Convert.ChangeType(员工信息IDToolStripTextBox1.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void 员工家庭信息查询ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeFamilyInformationTableAdapter.员工家庭信息查询(this.repairCenterDataSet16.EmployeeFamilyInformation, ((int)(System.Convert.ChangeType(员工信息IDToolStripTextBox2.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void 考勤信息查询ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.checkAttendanceTableAdapter.考勤信息查询(this.repairCenterDataSet17.CheckAttendance, new System.Nullable<int>(((int)(System.Convert.ChangeType(员工信息IDToolStripTextBox3.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void 员工评价信息查询ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeEvaluationTableAdapter.员工评价信息查询(this.repairCenterDataSet18.EmployeeEvaluation, ((int)(System.Convert.ChangeType(员工信息IDToolStripTextBox4.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void 离职交接查询ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.resignationHandoverTableAdapter.离职交接查询(this.repairCenterDataSet19.ResignationHandover, ((int)(System.Convert.ChangeType(离职表IDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Refresh_EntryApplication_Click(object sender, EventArgs e)
        {
            this.entryApplicationLearningInformationTableAdapter.Fill(this.repairCenterDataSet13.EntryApplicationLearningInformation);
        }
        private void Save2_EntryApplication_Click(object sender, EventArgs e)
        {
            this.entryApplicationLearningInformationTableAdapter.Update(repairCenterDataSet13.EntryApplicationLearningInformation);
            MessageBox.Show("更改成功");
        }



        private void Refresh_EmployeeLearning_Click(object sender, EventArgs e)
        {
            this.employmentLearningInformationTableAdapter.Fill(this.repairCenterDataSet14.EmploymentLearningInformation);
        }
        private void Save_EmployeeLearning_Click(object sender, EventArgs e)
        {
            this.employmentLearningInformationTableAdapter.Update(repairCenterDataSet14.EmploymentLearningInformation);
            MessageBox.Show("更改成功");
        }




        private void Refresh_EmployeeTrainIn_Click(object sender, EventArgs e)
        {
            this.employeeTrainInformationTableAdapter.Fill(this.repairCenterDataSet15.EmployeeTrainInformation);
        }
        private void Save_EmployeeTrainIn_Click(object sender, EventArgs e)
        {
            this.employeeTrainInformationTableAdapter.Update(repairCenterDataSet15.EmployeeTrainInformation);
            MessageBox.Show("更改成功");
        }




        private void Refresh_EmployeeFamily_Click(object sender, EventArgs e)
        {
            this.employeeFamilyInformationTableAdapter.Fill(this.repairCenterDataSet16.EmployeeFamilyInformation);
        }
        private void Save_EmployeeFamily_Click(object sender, EventArgs e)
        {
            this.employeeFamilyInformationTableAdapter.Update(repairCenterDataSet16.EmployeeFamilyInformation);
            MessageBox.Show("更改成功");
        }




        private void Refresh_CheckAttendance_Click(object sender, EventArgs e)
        {
            this.checkAttendanceTableAdapter.Fill(this.repairCenterDataSet17.CheckAttendance);
        }
        private void Save_CheckAttendance_Click(object sender, EventArgs e)
        {
            this.checkAttendanceTableAdapter.Update(repairCenterDataSet17.CheckAttendance);
            MessageBox.Show("更改成功");
        }



        private void Refresh_EmployeeEvaluation_Click(object sender, EventArgs e)
        {
            this.employeeEvaluationTableAdapter.Fill(this.repairCenterDataSet18.EmployeeEvaluation);
        }
        private void Save_EmployeeEvaluation_Click(object sender, EventArgs e)
        {
            this.employeeEvaluationTableAdapter.Update(repairCenterDataSet18.EmployeeEvaluation);
            MessageBox.Show("更改成功");
        }



        private void Refresh_ResignationHandover_Click(object sender, EventArgs e)
        {
            this.resignationHandoverTableAdapter.Fill(this.repairCenterDataSet19.ResignationHandover);
        }
        private void Save_ResignationHandover_Click(object sender, EventArgs e)
        {
            this.resignationHandoverTableAdapter.Update(repairCenterDataSet19.ResignationHandover);
            MessageBox.Show("更改成功");
        }





        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.ToString() == "TreeNode: 入职申请表")
            {
                tabControl1.SelectedTab = tabPage1;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 入职申请学习信息")
            {
                tabControl1.SelectedTab = tabPage2;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 员工信息表")
            {
                tabControl1.SelectedTab = tabPage3;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 员工学习信息")
            {
                tabControl1.SelectedTab = tabPage4;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 员工培训信息")
            {
                tabControl1.SelectedTab = tabPage5;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 员工家庭信息")
            {
                tabControl1.SelectedTab = tabPage6;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 考勤表")
            {
                tabControl1.SelectedTab = tabPage7;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 员工评价信息表")
            {
                tabControl1.SelectedTab = tabPage8;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 离职表")
            {
                tabControl1.SelectedTab = tabPage9;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 离职交接")
            {
                tabControl1.SelectedTab = tabPage10;
            }
            else
            {
                ;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EntryApplicationQuery entryApplicationQuery = new EntryApplicationQuery();
            entryApplicationQuery.ShowDialog();
        }
        private void Query_EntryApplication_Click(object sender, EventArgs e)
        {
            int a;
            if(EntryApplicationID.Text==null || !int.TryParse(EntryApplicationID.Text,out a) || a<=0)
            {
                MessageBox.Show("请输入有效数字");
                EntryApplicationID.Text = "";
                return;
            }
            SqlConnection conn = new SqlConnection("Data Source=Ian-PC\\Ian;Initial Catalog=RepairCenter;Integrated Security=True");
            conn.Open();
            string sql = "select * from EntryApplication where EntryApplicationID='" + EntryApplicationID.Text + "'";
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                TBEntryApplicationID.Text = dr[0].ToString();
                TBUserID.Text = dr[1].ToString();
                TBName.Text = dr[2].ToString();
                CBSex.Text = dr[3].ToString();
                TBHometown.Text = dr[4].ToString();
                TBNation.Text = dr[5].ToString();
                TBYear.Text = dr[7].ToString();
                TBMonth.Text = dr[8].ToString();
                CBHouseholdRegisterType.Text = dr[9].ToString();
                TBPoliticalLandscape.Text = dr[10].ToString();
                CBEducationBackground.Text = dr[11].ToString();
                CBMaritalStatus.Text = dr[12].ToString();
                CBIsOutGoingEmploymentCard.Text = dr[13].ToString();
                TBBirthControlCertificateNumber.Text = dr[14].ToString();
                TBHouseholdRegisterLocation.Text = dr[15].ToString();
                TBIDNumber.Text = dr[16].ToString();
                TBCurrentAddress.Text = dr[17].ToString();
                TBPhone.Text = dr[18].ToString();
                TBPosition.Text = dr[19].ToString();
                TBArrivalTime.Text =dr[20].ToString();
                TBResignationTime.Text = dr[21].ToString();
                TBCraft.Text = dr[22].ToString();
                TBTechnicalTitle.Text = dr[23].ToString();
                TBCertificate.Text = dr[24].ToString();
                TBSpecialty.Text = dr[25].ToString();

                QueryStatus();
            }
            else
            {
                MessageBox.Show("没有该申请单ID的入职申请单");
            }
            dr.Close();
            conn.Close();
        }
        private void Add_EntryApplication_Click(object sender, EventArgs e)
        {
            if (isAdding == 0)
            {
                isAdding = 1;
                saveType = "Add";
                TextBoxCanWrite();
                Add_EntryApplication.Text = "取消添加";
                TBUserID.Text = Form1.userIDString;
                Save_EntryApplication.Enabled = true;
                Clear_EntryApplication.Enabled = true;
            }
            else
            {
                isAdding = 0;
                saveType = "";
                TextBoxCanNotWrite();
                Add_EntryApplication.Text = "添加";
                TBUserID.Text = "";
                QueryStatus();
                Clear_EntryApplication_Click(sender, e); 
            }
        }

        private void Edit_EntryApplication_Click(object sender, EventArgs e)
        {
            if (isEditing == 0)
            {
                isEditing = 1;
                saveType = "Edit";
                TextBoxCanWrite();
                Edit_EntryApplication.Text = "取消修改";
                QueryLearningDetail_EntryApplication.Enabled = false;
                Delete_EntryApplication.Enabled = false;
            }
            else
            {
                isEditing = 0;
                saveType = "";
                TextBoxCanNotWrite();
                Edit_EntryApplication.Text = "修改";
                QueryStatus();
                if (EntryApplicationID.Text != "")
                {
                    Query_EntryApplication_Click(sender, e);
                }
            }
        }

        private void Save_EntryApplication_Click(object sender, EventArgs e)
        {
            if (SaveVerification())
            {
                if (saveType == "Add")
                {
                    SqlConnection conn = new SqlConnection("Data Source=Ian-PC\\Ian;Initial Catalog=RepairCenter;Integrated Security=True");
                    conn.Open();
                    string sql = "INSERT INTO EntryApplication ([UserID],[Name],[Sex],[Hometown],[Nation],[BirthYear],[BirthMonth],[HouseholdRegisterType]"+
                        ",[PoliticalLandscape],[EducationBackground],[MaritalStatus],[IsOutGoingEmploymentCard],[BirthControlCertificateNumber]"+
                        ",[HouseholdRegisterLocation],[IDNumber],[CurrentAddress],[Phone],[Position],[ArrivalTime],[ResignationTime],[Craft]"+
                        ",[TechnicalTitle],[Certificate],[Specialty]) VALUES ('"+TBUserID.Text+"','"+TBName.Text+"','"+CBSex.Text+"','"+TBHometown.Text+
                        "','"+TBNation.Text+"','"+TBYear.Text+"','"+TBMonth.Text+"','"+CBHouseholdRegisterType.Text+
                        "','"+TBPoliticalLandscape.Text+"','"+CBEducationBackground.Text+"','"+CBMaritalStatus.Text+"','"+CBIsOutGoingEmploymentCard.Text+
                        "','"+TBBirthControlCertificateNumber.Text+"','"+TBHouseholdRegisterLocation.Text+"','"+TBIDNumber.Text+"','"+TBCurrentAddress.Text+
                        "','"+TBPhone.Text+"','"+TBPosition.Text+"','"+TBArrivalTime.Text+"','"+TBResignationTime.Text+"','"+TBCraft.Text+"','"+TBTechnicalTitle.Text+
                        "','"+TBCertificate.Text+"','"+TBSpecialty.Text+"')";
                    SqlCommand comm = new SqlCommand(sql, conn);
                    try 
                    {
                        comm.ExecuteNonQuery();
                        QueryStatus();
                        MessageBox.Show("保存成功");
                    }
                    catch(Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                        return;
                    }

                    sql = "select EntryApplicationID from EntryApplication order by EntryApplicationID DESC";
                    comm = new SqlCommand(sql, conn);
                    SqlDataReader dr = comm.ExecuteReader();
                    {
                        TBEntryApplicationID.Text = dr[0].ToString();
                        EntryApplicationID.Text = dr[0].ToString();
                    }
                    dr.Close();
                    conn.Close();
                }
                else if (saveType == "Edit")
                {
                    SqlConnection conn = new SqlConnection("Data Source=Ian-PC\\Ian;Initial Catalog=RepairCenter;Integrated Security=True");
                    conn.Open();
                    string sql = "UPDATE EntryApplication SET UserID = '" + TBUserID.Text + "',Name = '" + TBName.Text + "',Sex ='" + CBSex.Text +
                        "',Hometown = '" + TBHometown.Text + "',Nation = '" + TBNation.Text + "',BirthYear = '" + TBYear.Text +
                        "',BirthMonth = '" + TBMonth.Text + "',HouseholdRegisterType = '" + CBHouseholdRegisterType.Text +
                        "',PoliticalLandscape = '" + TBPoliticalLandscape.Text + "',EducationBackground = '" + CBEducationBackground.Text +
                        "',MaritalStatus = '" + CBMaritalStatus.Text + "',IsOutGoingEmploymentCard = '" + CBIsOutGoingEmploymentCard.Text +
                        "',BirthControlCertificateNumber = '" + TBBirthControlCertificateNumber.Text +
                        "',HouseholdRegisterLocation= '" + TBHouseholdRegisterLocation.Text + "',IDNumber = '" + TBIDNumber.Text +
                        "',CurrentAddress = '" + TBCurrentAddress.Text + "',Phone = '" + TBPhone.Text + "',Position = '" + TBPosition.Text +
                        "',ArrivalTime = '" + TBArrivalTime.Text + "',ResignationTime = '" + TBResignationTime.Text + "',Craft = '" + TBCraft.Text +
                        "',TechnicalTitle = '" + TBTechnicalTitle.Text + "',Certificate = '" + TBCertificate.Text + "',Specialty = '" + TBSpecialty.Text +
                        "'WHERE EntryApplicationID='" + TBEntryApplicationID.Text + "'";
                    SqlCommand comm = new SqlCommand(sql, conn);
                    try
                    {
                        comm.ExecuteNonQuery();
                        QueryStatus();
                        MessageBox.Show("保存成功");
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                        return;
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("错了");
                }
            }
        }
        private void Delete_EntryApplication_Click(object sender, EventArgs e)
        {
            if (TBEntryApplicationID.Text == "")
            {
                MessageBox.Show("没有查询某申请单");
                return;
            }
            SqlConnection conn = new SqlConnection("Data Source=Ian-PC\\Ian;Initial Catalog=RepairCenter;Integrated Security=True");
            conn.Open();
            string sql = "delete from EntryApplication where EntryApplicationID='" + TBEntryApplicationID.Text + "'";
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                comm.ExecuteNonQuery();
                QueryStatus();
                Clear_EntryApplication_Click(sender,e);
                MessageBox.Show("删除成功");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            conn.Close();
        }
        private void Clear_EntryApplication_Click(object sender, EventArgs e)
        {
            if (isWriting == 0)
            {
                foreach (Control ctl in panel2.Controls)
                {
                    if (ctl.GetType().ToString() == "System.Windows.Forms.TextBox")
                    {
                        TextBox a = (TextBox)ctl;
                        a.Text = "";
                    }
                    else if (ctl.GetType().ToString() == "System.Windows.Forms.ComboBox")
                    {
                        ComboBox a = (ComboBox)ctl;
                        a.SelectedIndex=-1;
                    }
                    Add_EntryApplication.Enabled = true;
                    Save_EntryApplication.Enabled = false;
                    Edit_EntryApplication.Enabled = false;
                    Delete_EntryApplication.Enabled = false;
                    Clear_EntryApplication.Enabled = false;
                    QueryLearningDetail_EntryApplication.Enabled = false;
                }
                EntryApplicationID.Text = "";
            }
            else
            {
                foreach (Control ctl in panel2.Controls)
                {
                    if (ctl.GetType().ToString() == "System.Windows.Forms.TextBox")
                    {
                        if (ctl.Name != "TBEntryApplicationID" && ctl.Name != "TBUserID")
                        {
                            TextBox a = (TextBox)ctl;
                            a.Text = "";
                        }
                    }
                    else if (ctl.GetType().ToString() == "System.Windows.Forms.ComboBox")
                    {
                        ComboBox a = (ComboBox)ctl;
                        a.SelectedIndex = -1;
                    }
                }
            }
        }

        private void QueryLearningDetail_EntryApplication_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            入职申请IDToolStripTextBox.Text = TBEntryApplicationID.Text;
            查询ToolStripButton_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeQuery employeeQuery = new EmployeeQuery();
            employeeQuery.ShowDialog();
        }

        private void Query_Employee_Click(object sender, EventArgs e)
        {
            int a;
            if (EmployeeID.Text == null || !int.TryParse(EmployeeID.Text, out a) || a <= 0)
            {
                MessageBox.Show("请输入有效数字");
                EmployeeID.Text = "";
                return;
            }
            SqlConnection conn = new SqlConnection("Data Source=Ian-PC\\Ian;Initial Catalog=RepairCenter;Integrated Security=True");
            conn.Open();
            string sql = "select * from Employee where EmployeeID='" + EmployeeID.Text + "'";
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                TBEmployeeID2.Text = dr[0].ToString();
                TBName2.Text = dr[1].ToString();
                CBSex2.Text = dr[2].ToString();
                TBHometown2.Text = dr[3].ToString();
                TBNation2.Text = dr[4].ToString();
                TBYear2.Text = dr[6].ToString();
                TBMonth2.Text = dr[7].ToString();
                CBHouseholdRegisterType2.Text = dr[8].ToString();
                TBPoliticalLandscape2.Text = dr[9].ToString();
                CBEducationBackground2.Text = dr[10].ToString();
                CBMaritalStatus2.Text = dr[11].ToString();
                CBIsOutGoingEmploymentCard2.Text = dr[12].ToString();
                TBBirthControlCertificateNumber2.Text = dr[13].ToString();
                TBHouseholdRegisterLocation2.Text = dr[14].ToString();
                TBIDNumber2.Text = dr[15].ToString();
                TBCurrentAddress2.Text = dr[16].ToString();
                TBPhone2.Text = dr[17].ToString();
                TBPosition2.Text = dr[18].ToString();
                TBArrivalTime2.Text = dr[19].ToString();
                TBResignationTime2.Text = dr[20].ToString();
                TBCraft2.Text = dr[21].ToString();
                TBTechnicalTitle2.Text = dr[22].ToString();
                TBCertificate2.Text = dr[23].ToString();
                TBSpecialty2.Text = dr[24].ToString();

                QueryStatus2();
            }
            else
            {
                MessageBox.Show("没有该申请单ID的入职申请单");
            }
            dr.Close();
            conn.Close();
        }

        private void Add_Employee_Click(object sender, EventArgs e)
        {
            if (isAdding2 == 0)
            {
                isAdding2 = 1;
                saveType2 = "Add";
                TextBoxCanWrite2();
                Add_Employee.Text = "取消添加";
                Save_Employee.Enabled = true;
                Clear_Employee.Enabled = true;
            }
            else
            {
                isAdding2 = 0;
                saveType2 = "";
                TextBoxCanNotWrite2();
                Add_Employee.Text = "添加";
                QueryStatus2();
                Clear_Employee_Click(sender, e);
            }
        }

        private void Edit_Employee_Click(object sender, EventArgs e)
        {
            if (isEditing2 == 0)
            {
                isEditing2 = 1;
                saveType2 = "Edit";
                TextBoxCanWrite2();
                Edit_Employee.Text = "取消修改";
                QueryDetail_Employee.Enabled = false;
                Delete_Employee.Enabled = false;
            }
            else
            {
                isEditing2 = 0;
                saveType2 = "";
                TextBoxCanNotWrite2();
                Edit_Employee.Text = "修改";
                QueryStatus2();
                if (EmployeeID.Text != "")
                {
                    Query_Employee_Click(sender, e);
                }
            }
        }

        private void Save_Employee_Click(object sender, EventArgs e)
        {
            if (SaveVerification2())
            {
                if (saveType2 == "Add")
                {
                    SqlConnection conn = new SqlConnection("Data Source=Ian-PC\\Ian;Initial Catalog=RepairCenter;Integrated Security=True");
                    conn.Open();
                    string sql = "INSERT INTO Employee ([Name],[Sex],[Hometown],[Nation],[BirthYear],[BirthMonth],[HouseholdRegisterType]" +
                        ",[PoliticalLandscape],[EducationBackground],[MaritalStatus],[IsOutGoingEmploymentCard],[BirthControlCertificateNumber]" +
                        ",[HouseholdRegisterLocation],[IDNumber],[CurrentAddress],[Phone],[Position],[ArrivalTime],[ResignationTime],[Craft]" +
                        ",[TechnicalTitle],[Certificate],[Specialty]) VALUES ('" + TBName2.Text + "','" + CBSex2.Text + "','" + TBHometown2.Text +
                        "','" + TBNation2.Text + "','" + TBYear2.Text + "','" + TBMonth2.Text + "','" + CBHouseholdRegisterType2.Text +
                        "','" + TBPoliticalLandscape2.Text + "','" + CBEducationBackground2.Text + "','" + CBMaritalStatus2.Text + "','" + CBIsOutGoingEmploymentCard2.Text +
                        "','" + TBBirthControlCertificateNumber2.Text + "','" + TBHouseholdRegisterLocation2.Text + "','" + TBIDNumber2.Text + "','" + TBCurrentAddress2.Text +
                        "','" + TBPhone2.Text + "','" + TBPosition2.Text + "','" + TBArrivalTime2.Text + "','" + TBResignationTime2.Text + "','" + TBCraft2.Text + "','" + TBTechnicalTitle2.Text +
                        "','" + TBCertificate2.Text + "','" + TBSpecialty2.Text + "')";
                    SqlCommand comm = new SqlCommand(sql, conn);
                    try
                    {
                        comm.ExecuteNonQuery();
                        QueryStatus2();
                        MessageBox.Show("保存成功");
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                        return;
                    }

                    sql = "select EmployeeID from Employee order by EmployeeID DESC";
                    comm = new SqlCommand(sql, conn);
                    SqlDataReader dr = comm.ExecuteReader();
                    {
                        TBEmployeeID2.Text = dr[0].ToString();
                        EmployeeID.Text = dr[0].ToString();
                    }
                    dr.Close();
                    conn.Close();
                }
                else if (saveType2 == "Edit")
                {
                    SqlConnection conn = new SqlConnection("Data Source=Ian-PC\\Ian;Initial Catalog=RepairCenter;Integrated Security=True");
                    conn.Open();
                    string sql = "UPDATE Employee SET Name = '" + TBName2.Text + "',Sex ='" + CBSex2.Text +
                        "',Hometown = '" + TBHometown2.Text + "',Nation = '" + TBNation2.Text + "',BirthYear = '" + TBYear2.Text +
                        "',BirthMonth = '" + TBMonth2.Text + "',HouseholdRegisterType = '" + CBHouseholdRegisterType2.Text +
                        "',PoliticalLandscape = '" + TBPoliticalLandscape2.Text + "',EducationBackground = '" + CBEducationBackground2.Text +
                        "',MaritalStatus = '" + CBMaritalStatus2.Text + "',IsOutGoingEmploymentCard = '" + CBIsOutGoingEmploymentCard2.Text +
                        "',BirthControlCertificateNumber = '" + TBBirthControlCertificateNumber2.Text +
                        "',HouseholdRegisterLocation= '" + TBHouseholdRegisterLocation2.Text + "',IDNumber = '" + TBIDNumber2.Text +
                        "',CurrentAddress = '" + TBCurrentAddress2.Text + "',Phone = '" + TBPhone2.Text + "',Position = '" + TBPosition2.Text +
                        "',ArrivalTime = '" + TBArrivalTime2.Text + "',ResignationTime = '" + TBResignationTime2.Text + "',Craft = '" + TBCraft2.Text +
                        "',TechnicalTitle = '" + TBTechnicalTitle2.Text + "',Certificate = '" + TBCertificate2.Text + "',Specialty = '" + TBSpecialty2.Text +
                        "'WHERE EmployeeID='" + TBEmployeeID2.Text + "'";
                    SqlCommand comm = new SqlCommand(sql, conn);
                    try
                    {
                        comm.ExecuteNonQuery();
                        QueryStatus2();
                        MessageBox.Show("保存成功");
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                        return;
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("错了");
                }
            }
        }

        private void Delete_Employee_Click(object sender, EventArgs e)
        {
            if (TBEmployeeID2.Text == "")
            {
                MessageBox.Show("没有查询某申请单");
                return;
            }
            SqlConnection conn = new SqlConnection("Data Source=Ian-PC\\Ian;Initial Catalog=RepairCenter;Integrated Security=True");
            conn.Open();
            string sql = "delete from Employee where EmployeeID='" + TBEmployeeID2.Text + "'";
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                comm.ExecuteNonQuery();
                QueryStatus2();
                Clear_Employee_Click(sender, e);
                MessageBox.Show("删除成功");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            conn.Close();
        }

        private void Clear_Employee_Click(object sender, EventArgs e)
        {
            if (isWriting2 == 0)
            {
                foreach (Control ctl in panel5.Controls)
                {
                    if (ctl.GetType().ToString() == "System.Windows.Forms.TextBox")
                    {
                        TextBox a = (TextBox)ctl;
                        a.Text = "";
                    }
                    else if (ctl.GetType().ToString() == "System.Windows.Forms.ComboBox")
                    {
                        ComboBox a = (ComboBox)ctl;
                        a.SelectedIndex = -1;
                    }
                }
                Add_Employee.Enabled = true;
                Save_Employee.Enabled = false;
                Edit_Employee.Enabled = false;
                Delete_Employee.Enabled = false;
                Clear_Employee.Enabled = false;
                QueryDetail_Employee.Enabled = false;
                EmployeeID.Text = "";
            }
            else
            {
                foreach (Control ctl in panel5.Controls)
                {
                    if (ctl.GetType().ToString() == "System.Windows.Forms.TextBox")
                    {
                        if (ctl.Name != "TBEmployeeID2")
                        {
                            TextBox a = (TextBox)ctl;
                            a.Text = "";
                        }
                    }
                    else if (ctl.GetType().ToString() == "System.Windows.Forms.ComboBox")
                    {
                        ComboBox a = (ComboBox)ctl;
                        a.SelectedIndex = -1;
                    }
                }
            }
        }

        private void QueryDetail_Employee_Click(object sender, EventArgs e)
        {
            if (QueryDetailText_Employee.Text == "学习信息")
            {
                tabControl1.SelectedTab = tabPage4;
                员工信息IDToolStripTextBox.Text = TBEmployeeID2.Text;
                员工学习信息查询ToolStripButton_Click(sender, e);
            }
            else if (QueryDetailText_Employee.Text == "培训信息")
            {
                tabControl1.SelectedTab = tabPage5;
                员工信息IDToolStripTextBox1.Text = TBEmployeeID2.Text;
                员工培训信息查询ToolStripButton_Click(sender, e);
            }
            else if (QueryDetailText_Employee.Text == "家庭信息")
            {
                tabControl1.SelectedTab = tabPage6;
                员工信息IDToolStripTextBox2.Text = TBEmployeeID2.Text;
                员工家庭信息查询ToolStripButton_Click(sender, e);
            }
            else if (QueryDetailText_Employee.Text == "考勤信息")
            {
                tabControl1.SelectedTab = tabPage7;
                员工信息IDToolStripTextBox3.Text = TBEmployeeID2.Text;
                考勤信息查询ToolStripButton_Click(sender, e);
            }
            else if (QueryDetailText_Employee.Text == "评价信息")
            {
                tabControl1.SelectedTab = tabPage8;
                员工信息IDToolStripTextBox4.Text = TBEmployeeID2.Text;
                员工评价信息查询ToolStripButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("请选择查询信息类型");
            }
        }

       

        

        

        
        

        
    }
}
