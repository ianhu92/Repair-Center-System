namespace 维修管理系统
{
    partial class HRManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("入职申请表");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("入职申请学习信息");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("招聘管理", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("员工信息表");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("员工学习信息");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("员工培训信息");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("员工家庭信息");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("人员管理", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("考勤表");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("员工评价信息表");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("考核管理", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("离职表");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("离职交接");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("离职管理", new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode41});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HRManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Exit = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.QueryLearningDetail_EntryApplication = new System.Windows.Forms.Button();
            this.Add_EntryApplication = new System.Windows.Forms.Button();
            this.Edit_EntryApplication = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Clear_EntryApplication = new System.Windows.Forms.Button();
            this.Delete_EntryApplication = new System.Windows.Forms.Button();
            this.Save_EntryApplication = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Query_EntryApplication = new System.Windows.Forms.Button();
            this.EntryApplicationID = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBArrivalTime = new System.Windows.Forms.TextBox();
            this.CBIsOutGoingEmploymentCard = new System.Windows.Forms.ComboBox();
            this.CBMaritalStatus = new System.Windows.Forms.ComboBox();
            this.CBHouseholdRegisterType = new System.Windows.Forms.ComboBox();
            this.CBEducationBackground = new System.Windows.Forms.ComboBox();
            this.entryApplicationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.repairCenterDataSet1 = new 维修管理系统.RepairCenterDataSet();
            this.CBSex = new System.Windows.Forms.ComboBox();
            this.label104 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.TBUserID = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.TBCraft = new System.Windows.Forms.TextBox();
            this.label90 = new System.Windows.Forms.Label();
            this.TBSpecialty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBCertificate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBTechnicalTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBResignationTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBPosition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TBCurrentAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TBIDNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TBHouseholdRegisterLocation = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TBBirthControlCertificateNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TBPoliticalLandscape = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TBMonth = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TBYear = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.TBHometown = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.TBNation = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.TBEntryApplicationID = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Save2_EntryApplication = new System.Windows.Forms.Button();
            this.查询ToolStrip = new System.Windows.Forms.ToolStrip();
            this.入职申请IDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.入职申请IDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Refresh_EntryApplication = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.entryApplicationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.craftOrPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryApplicationLearningInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairCenterDataSet13 = new 维修管理系统.RepairCenterDataSet13();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.QueryDetailText_Employee = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TBArrivalTime2 = new System.Windows.Forms.TextBox();
            this.CBIsOutGoingEmploymentCard2 = new System.Windows.Forms.ComboBox();
            this.CBMaritalStatus2 = new System.Windows.Forms.ComboBox();
            this.CBHouseholdRegisterType2 = new System.Windows.Forms.ComboBox();
            this.CBEducationBackground2 = new System.Windows.Forms.ComboBox();
            this.CBSex2 = new System.Windows.Forms.ComboBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.TBCraft2 = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.TBSpecialty2 = new System.Windows.Forms.TextBox();
            this.label84 = new System.Windows.Forms.Label();
            this.TBCertificate2 = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.TBTechnicalTitle2 = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.TBResignationTime2 = new System.Windows.Forms.TextBox();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.TBPosition2 = new System.Windows.Forms.TextBox();
            this.label89 = new System.Windows.Forms.Label();
            this.TBPhone2 = new System.Windows.Forms.TextBox();
            this.label95 = new System.Windows.Forms.Label();
            this.TBCurrentAddress2 = new System.Windows.Forms.TextBox();
            this.label102 = new System.Windows.Forms.Label();
            this.TBIDNumber2 = new System.Windows.Forms.TextBox();
            this.label105 = new System.Windows.Forms.Label();
            this.TBHouseholdRegisterLocation2 = new System.Windows.Forms.TextBox();
            this.label106 = new System.Windows.Forms.Label();
            this.TBBirthControlCertificateNumber2 = new System.Windows.Forms.TextBox();
            this.label107 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.TBPoliticalLandscape2 = new System.Windows.Forms.TextBox();
            this.label111 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.TBMonth2 = new System.Windows.Forms.TextBox();
            this.label114 = new System.Windows.Forms.Label();
            this.TBYear2 = new System.Windows.Forms.TextBox();
            this.label115 = new System.Windows.Forms.Label();
            this.TBHometown2 = new System.Windows.Forms.TextBox();
            this.label116 = new System.Windows.Forms.Label();
            this.TBNation2 = new System.Windows.Forms.TextBox();
            this.label117 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.TBName2 = new System.Windows.Forms.TextBox();
            this.label119 = new System.Windows.Forms.Label();
            this.TBEmployeeID2 = new System.Windows.Forms.TextBox();
            this.label120 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.QueryDetail_Employee = new System.Windows.Forms.Button();
            this.Add_Employee = new System.Windows.Forms.Button();
            this.Edit_Employee = new System.Windows.Forms.Button();
            this.Clear_Employee = new System.Windows.Forms.Button();
            this.Delete_Employee = new System.Windows.Forms.Button();
            this.Save_Employee = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Query_Employee = new System.Windows.Forms.Button();
            this.EmployeeID = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.员工学习信息查询ToolStrip = new System.Windows.Forms.ToolStrip();
            this.员工信息IDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.员工信息IDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.员工学习信息查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Refresh_EmployeeLearning = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.employmenIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.craftOrPositionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employmentLearningInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairCenterDataSet14 = new 维修管理系统.RepairCenterDataSet14();
            this.Save_EmployeeLearning = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.员工培训信息查询ToolStrip = new System.Windows.Forms.ToolStrip();
            this.员工信息IDToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.员工信息IDToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.员工培训信息查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Refresh_EmployeeTrainIn = new System.Windows.Forms.Button();
            this.Save_EmployeeTrainIn = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainEffectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeTrainInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairCenterDataSet15 = new 维修管理系统.RepairCenterDataSet15();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.员工家庭信息查询ToolStrip = new System.Windows.Forms.ToolStrip();
            this.员工信息IDToolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.员工信息IDToolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.员工家庭信息查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Refresh_EmployeeFamily = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appellationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentDepartmentAndPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.politicalLandscapeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFamilyInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairCenterDataSet16 = new 维修管理系统.RepairCenterDataSet16();
            this.Save_EmployeeFamily = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.bindingNavigator4 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem3 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem3 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.考勤信息查询ToolStrip = new System.Windows.Forms.ToolStrip();
            this.员工信息IDToolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.员工信息IDToolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.考勤信息查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Refresh_CheckAttendance = new System.Windows.Forms.Button();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkResultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairCenterDataSet17 = new 维修管理系统.RepairCenterDataSet17();
            this.Save_CheckAttendance = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.bindingNavigator5 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem4 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem4 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.员工评价信息查询ToolStrip = new System.Windows.Forms.ToolStrip();
            this.员工信息IDToolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.员工信息IDToolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.员工评价信息查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Refresh_EmployeeEvaluation = new System.Windows.Forms.Button();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluateYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluateResultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeEvaluationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairCenterDataSet18 = new 维修管理系统.RepairCenterDataSet18();
            this.Save_EmployeeEvaluation = new System.Windows.Forms.Button();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button34 = new System.Windows.Forms.Button();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.button26 = new System.Windows.Forms.Button();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.bindingNavigator6 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem5 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem5 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.离职交接查询ToolStrip = new System.Windows.Forms.ToolStrip();
            this.离职表IDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.离职表IDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.离职交接查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Refresh_ResignationHandover = new System.Windows.Forms.Button();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.resignationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handoverContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resignationHandoverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairCenterDataSet19 = new 维修管理系统.RepairCenterDataSet19();
            this.Save_ResignationHandover = new System.Windows.Forms.Button();
            this.entryApplicationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.repairCenterDataSet = new 维修管理系统.RepairCenterDataSet();
            this.entryApplicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entryApplicationLearningInformationTableAdapter = new 维修管理系统.RepairCenterDataSet13TableAdapters.EntryApplicationLearningInformationTableAdapter();
            this.employmentLearningInformationTableAdapter = new 维修管理系统.RepairCenterDataSet14TableAdapters.EmploymentLearningInformationTableAdapter();
            this.employeeTrainInformationTableAdapter = new 维修管理系统.RepairCenterDataSet15TableAdapters.EmployeeTrainInformationTableAdapter();
            this.employeeFamilyInformationTableAdapter = new 维修管理系统.RepairCenterDataSet16TableAdapters.EmployeeFamilyInformationTableAdapter();
            this.checkAttendanceTableAdapter = new 维修管理系统.RepairCenterDataSet17TableAdapters.CheckAttendanceTableAdapter();
            this.employeeEvaluationTableAdapter = new 维修管理系统.RepairCenterDataSet18TableAdapters.EmployeeEvaluationTableAdapter();
            this.resignationHandoverTableAdapter = new 维修管理系统.RepairCenterDataSet19TableAdapters.ResignationHandoverTableAdapter();
            this.entryApplicationTableAdapter = new 维修管理系统.RepairCenterDataSetTableAdapters.EntryApplicationTableAdapter();
            this.bindingNavigator7 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entryApplicationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.查询ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryApplicationLearningInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet13)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.员工学习信息查询ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employmentLearningInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet14)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.员工培训信息查询ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTrainInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet15)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            this.员工家庭信息查询ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeFamilyInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet16)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).BeginInit();
            this.bindingNavigator4.SuspendLayout();
            this.考勤信息查询ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet17)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).BeginInit();
            this.bindingNavigator5.SuspendLayout();
            this.员工评价信息查询ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeEvaluationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet18)).BeginInit();
            this.tabPage9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator6)).BeginInit();
            this.bindingNavigator6.SuspendLayout();
            this.离职交接查询ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resignationHandoverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryApplicationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryApplicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator7)).BeginInit();
            this.bindingNavigator7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "人事管理";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Exit);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(933, 524);
            this.splitContainer1.SplitterDistance = 163;
            this.splitContainer1.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(17, 349);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(5, 70);
            this.treeView1.Name = "treeView1";
            treeNode29.Name = "节点1";
            treeNode29.Text = "入职申请表";
            treeNode30.Name = "节点2";
            treeNode30.Text = "入职申请学习信息";
            treeNode31.Name = "节点0";
            treeNode31.Text = "招聘管理";
            treeNode32.Name = "节点4";
            treeNode32.Text = "员工信息表";
            treeNode33.Name = "节点5";
            treeNode33.Text = "员工学习信息";
            treeNode34.Name = "节点0";
            treeNode34.Text = "员工培训信息";
            treeNode35.Name = "节点1";
            treeNode35.Text = "员工家庭信息";
            treeNode36.Name = "节点3";
            treeNode36.Text = "人员管理";
            treeNode37.Name = "节点2";
            treeNode37.Text = "考勤表";
            treeNode38.Name = "节点7";
            treeNode38.Text = "员工评价信息表";
            treeNode39.Name = "节点6";
            treeNode39.Text = "考核管理";
            treeNode40.Name = "节点4";
            treeNode40.Text = "离职表";
            treeNode41.Name = "节点5";
            treeNode41.Text = "离职交接";
            treeNode42.Name = "节点3";
            treeNode42.Text = "离职管理";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode36,
            treeNode39,
            treeNode42});
            this.treeView1.Size = new System.Drawing.Size(145, 234);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(766, 524);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.QueryLearningDetail_EntryApplication);
            this.tabPage1.Controls.Add(this.Add_EntryApplication);
            this.tabPage1.Controls.Add(this.Edit_EntryApplication);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.Clear_EntryApplication);
            this.tabPage1.Controls.Add(this.Delete_EntryApplication);
            this.tabPage1.Controls.Add(this.Save_EntryApplication);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(758, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "入职申请表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // QueryLearningDetail_EntryApplication
            // 
            this.QueryLearningDetail_EntryApplication.Enabled = false;
            this.QueryLearningDetail_EntryApplication.Location = new System.Drawing.Point(594, 464);
            this.QueryLearningDetail_EntryApplication.Name = "QueryLearningDetail_EntryApplication";
            this.QueryLearningDetail_EntryApplication.Size = new System.Drawing.Size(118, 23);
            this.QueryLearningDetail_EntryApplication.TabIndex = 14;
            this.QueryLearningDetail_EntryApplication.Text = "查询入职学习信息";
            this.QueryLearningDetail_EntryApplication.UseVisualStyleBackColor = true;
            this.QueryLearningDetail_EntryApplication.Click += new System.EventHandler(this.QueryLearningDetail_EntryApplication_Click);
            // 
            // Add_EntryApplication
            // 
            this.Add_EntryApplication.Location = new System.Drawing.Point(47, 464);
            this.Add_EntryApplication.Name = "Add_EntryApplication";
            this.Add_EntryApplication.Size = new System.Drawing.Size(75, 23);
            this.Add_EntryApplication.TabIndex = 13;
            this.Add_EntryApplication.Text = "添加";
            this.Add_EntryApplication.UseVisualStyleBackColor = true;
            this.Add_EntryApplication.Click += new System.EventHandler(this.Add_EntryApplication_Click);
            // 
            // Edit_EntryApplication
            // 
            this.Edit_EntryApplication.Enabled = false;
            this.Edit_EntryApplication.Location = new System.Drawing.Point(153, 464);
            this.Edit_EntryApplication.Name = "Edit_EntryApplication";
            this.Edit_EntryApplication.Size = new System.Drawing.Size(75, 23);
            this.Edit_EntryApplication.TabIndex = 12;
            this.Edit_EntryApplication.Text = "修改";
            this.Edit_EntryApplication.UseVisualStyleBackColor = true;
            this.Edit_EntryApplication.Click += new System.EventHandler(this.Edit_EntryApplication_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(61, 14);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "查询入职申请表ID";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Clear_EntryApplication
            // 
            this.Clear_EntryApplication.Enabled = false;
            this.Clear_EntryApplication.Location = new System.Drawing.Point(486, 464);
            this.Clear_EntryApplication.Name = "Clear_EntryApplication";
            this.Clear_EntryApplication.Size = new System.Drawing.Size(75, 23);
            this.Clear_EntryApplication.TabIndex = 10;
            this.Clear_EntryApplication.Text = "清空";
            this.Clear_EntryApplication.UseVisualStyleBackColor = true;
            this.Clear_EntryApplication.Click += new System.EventHandler(this.Clear_EntryApplication_Click);
            // 
            // Delete_EntryApplication
            // 
            this.Delete_EntryApplication.Enabled = false;
            this.Delete_EntryApplication.Location = new System.Drawing.Point(378, 464);
            this.Delete_EntryApplication.Name = "Delete_EntryApplication";
            this.Delete_EntryApplication.Size = new System.Drawing.Size(75, 23);
            this.Delete_EntryApplication.TabIndex = 9;
            this.Delete_EntryApplication.Text = "删除";
            this.Delete_EntryApplication.UseVisualStyleBackColor = true;
            this.Delete_EntryApplication.Click += new System.EventHandler(this.Delete_EntryApplication_Click);
            // 
            // Save_EntryApplication
            // 
            this.Save_EntryApplication.Enabled = false;
            this.Save_EntryApplication.Location = new System.Drawing.Point(264, 464);
            this.Save_EntryApplication.Name = "Save_EntryApplication";
            this.Save_EntryApplication.Size = new System.Drawing.Size(75, 23);
            this.Save_EntryApplication.TabIndex = 8;
            this.Save_EntryApplication.Text = "保存";
            this.Save_EntryApplication.UseVisualStyleBackColor = true;
            this.Save_EntryApplication.Click += new System.EventHandler(this.Save_EntryApplication_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.Query_EntryApplication);
            this.panel4.Controls.Add(this.EntryApplicationID);
            this.panel4.Controls.Add(this.label63);
            this.panel4.Location = new System.Drawing.Point(409, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 25);
            this.panel4.TabIndex = 5;
            // 
            // Query_EntryApplication
            // 
            this.Query_EntryApplication.Location = new System.Drawing.Point(217, 0);
            this.Query_EntryApplication.Name = "Query_EntryApplication";
            this.Query_EntryApplication.Size = new System.Drawing.Size(75, 23);
            this.Query_EntryApplication.TabIndex = 6;
            this.Query_EntryApplication.Text = "查询";
            this.Query_EntryApplication.UseVisualStyleBackColor = true;
            this.Query_EntryApplication.Click += new System.EventHandler(this.Query_EntryApplication_Click);
            // 
            // EntryApplicationID
            // 
            this.EntryApplicationID.Location = new System.Drawing.Point(90, 2);
            this.EntryApplicationID.Name = "EntryApplicationID";
            this.EntryApplicationID.Size = new System.Drawing.Size(100, 21);
            this.EntryApplicationID.TabIndex = 5;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(5, 7);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(77, 12);
            this.label63.TabIndex = 4;
            this.label63.Text = "入职申请表ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.TBArrivalTime);
            this.panel2.Controls.Add(this.CBIsOutGoingEmploymentCard);
            this.panel2.Controls.Add(this.CBMaritalStatus);
            this.panel2.Controls.Add(this.CBHouseholdRegisterType);
            this.panel2.Controls.Add(this.CBEducationBackground);
            this.panel2.Controls.Add(this.CBSex);
            this.panel2.Controls.Add(this.label104);
            this.panel2.Controls.Add(this.label103);
            this.panel2.Controls.Add(this.label101);
            this.panel2.Controls.Add(this.label100);
            this.panel2.Controls.Add(this.label99);
            this.panel2.Controls.Add(this.label98);
            this.panel2.Controls.Add(this.label97);
            this.panel2.Controls.Add(this.label96);
            this.panel2.Controls.Add(this.label94);
            this.panel2.Controls.Add(this.label93);
            this.panel2.Controls.Add(this.label92);
            this.panel2.Controls.Add(this.label91);
            this.panel2.Controls.Add(this.label34);
            this.panel2.Controls.Add(this.label33);
            this.panel2.Controls.Add(this.label32);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.TBUserID);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.TBCraft);
            this.panel2.Controls.Add(this.label90);
            this.panel2.Controls.Add(this.TBSpecialty);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TBCertificate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TBTechnicalTitle);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TBResignationTime);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.TBPosition);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.TBPhone);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.TBCurrentAddress);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.TBIDNumber);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.TBHouseholdRegisterLocation);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.TBBirthControlCertificateNumber);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.TBPoliticalLandscape);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.TBMonth);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.TBYear);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.TBHometown);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.TBNation);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.TBName);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.TBEntryApplicationID);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Location = new System.Drawing.Point(1, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 412);
            this.panel2.TabIndex = 1;
            // 
            // TBArrivalTime
            // 
            this.TBArrivalTime.Location = new System.Drawing.Point(208, 309);
            this.TBArrivalTime.Name = "TBArrivalTime";
            this.TBArrivalTime.ReadOnly = true;
            this.TBArrivalTime.Size = new System.Drawing.Size(100, 21);
            this.TBArrivalTime.TabIndex = 132;
            // 
            // CBIsOutGoingEmploymentCard
            // 
            this.CBIsOutGoingEmploymentCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBIsOutGoingEmploymentCard.Enabled = false;
            this.CBIsOutGoingEmploymentCard.FormattingEnabled = true;
            this.CBIsOutGoingEmploymentCard.Items.AddRange(new object[] {
            "有",
            "无"});
            this.CBIsOutGoingEmploymentCard.Location = new System.Drawing.Point(518, 155);
            this.CBIsOutGoingEmploymentCard.Name = "CBIsOutGoingEmploymentCard";
            this.CBIsOutGoingEmploymentCard.Size = new System.Drawing.Size(47, 20);
            this.CBIsOutGoingEmploymentCard.TabIndex = 131;
            // 
            // CBMaritalStatus
            // 
            this.CBMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMaritalStatus.Enabled = false;
            this.CBMaritalStatus.FormattingEnabled = true;
            this.CBMaritalStatus.Items.AddRange(new object[] {
            "未婚",
            "已婚"});
            this.CBMaritalStatus.Location = new System.Drawing.Point(209, 155);
            this.CBMaritalStatus.Name = "CBMaritalStatus";
            this.CBMaritalStatus.Size = new System.Drawing.Size(94, 20);
            this.CBMaritalStatus.TabIndex = 130;
            // 
            // CBHouseholdRegisterType
            // 
            this.CBHouseholdRegisterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBHouseholdRegisterType.Enabled = false;
            this.CBHouseholdRegisterType.FormattingEnabled = true;
            this.CBHouseholdRegisterType.Items.AddRange(new object[] {
            "农",
            "非农"});
            this.CBHouseholdRegisterType.Location = new System.Drawing.Point(209, 122);
            this.CBHouseholdRegisterType.Name = "CBHouseholdRegisterType";
            this.CBHouseholdRegisterType.Size = new System.Drawing.Size(94, 20);
            this.CBHouseholdRegisterType.TabIndex = 129;
            // 
            // CBEducationBackground
            // 
            this.CBEducationBackground.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.entryApplicationBindingSource2, "EducationBackground", true));
            this.CBEducationBackground.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEducationBackground.Enabled = false;
            this.CBEducationBackground.FormattingEnabled = true;
            this.CBEducationBackground.Items.AddRange(new object[] {
            "小学",
            "初中",
            "高中",
            "中专",
            "大专",
            "本科",
            "硕士",
            "博士"});
            this.CBEducationBackground.Location = new System.Drawing.Point(561, 122);
            this.CBEducationBackground.Name = "CBEducationBackground";
            this.CBEducationBackground.Size = new System.Drawing.Size(63, 20);
            this.CBEducationBackground.TabIndex = 128;
            // 
            // entryApplicationBindingSource2
            // 
            this.entryApplicationBindingSource2.DataMember = "EntryApplication";
            this.entryApplicationBindingSource2.DataSource = this.repairCenterDataSet1;
            // 
            // repairCenterDataSet1
            // 
            this.repairCenterDataSet1.DataSetName = "RepairCenterDataSet";
            this.repairCenterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CBSex
            // 
            this.CBSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSex.Enabled = false;
            this.CBSex.FormattingEnabled = true;
            this.CBSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.CBSex.Location = new System.Drawing.Point(434, 59);
            this.CBSex.Name = "CBSex";
            this.CBSex.Size = new System.Drawing.Size(47, 20);
            this.CBSex.TabIndex = 127;
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.ForeColor = System.Drawing.Color.Red;
            this.label104.Location = new System.Drawing.Point(577, 347);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(11, 12);
            this.label104.TabIndex = 126;
            this.label104.Text = "*";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.ForeColor = System.Drawing.Color.Red;
            this.label103.Location = new System.Drawing.Point(315, 346);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(11, 12);
            this.label103.TabIndex = 125;
            this.label103.Text = "*";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.ForeColor = System.Drawing.Color.Red;
            this.label101.Location = new System.Drawing.Point(315, 312);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(11, 12);
            this.label101.TabIndex = 123;
            this.label101.Text = "*";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.ForeColor = System.Drawing.Color.Red;
            this.label100.Location = new System.Drawing.Point(577, 274);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(11, 12);
            this.label100.TabIndex = 122;
            this.label100.Text = "*";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.ForeColor = System.Drawing.Color.Red;
            this.label99.Location = new System.Drawing.Point(315, 274);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(11, 12);
            this.label99.TabIndex = 121;
            this.label99.Text = "*";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.ForeColor = System.Drawing.Color.Red;
            this.label98.Location = new System.Drawing.Point(577, 234);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(11, 12);
            this.label98.TabIndex = 120;
            this.label98.Text = "*";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.ForeColor = System.Drawing.Color.Red;
            this.label97.Location = new System.Drawing.Point(338, 234);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(11, 12);
            this.label97.TabIndex = 119;
            this.label97.Text = "*";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.ForeColor = System.Drawing.Color.Red;
            this.label96.Location = new System.Drawing.Point(577, 196);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(11, 12);
            this.label96.TabIndex = 118;
            this.label96.Text = "*";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.ForeColor = System.Drawing.Color.Red;
            this.label94.Location = new System.Drawing.Point(577, 158);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(11, 12);
            this.label94.TabIndex = 116;
            this.label94.Text = "*";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.ForeColor = System.Drawing.Color.Red;
            this.label93.Location = new System.Drawing.Point(315, 158);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(11, 12);
            this.label93.TabIndex = 115;
            this.label93.Text = "*";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.ForeColor = System.Drawing.Color.Red;
            this.label92.Location = new System.Drawing.Point(608, 125);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(11, 12);
            this.label92.TabIndex = 114;
            this.label92.Text = "*";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.ForeColor = System.Drawing.Color.Red;
            this.label91.Location = new System.Drawing.Point(484, 125);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(11, 12);
            this.label91.TabIndex = 113;
            this.label91.Text = "*";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.Color.Red;
            this.label34.Location = new System.Drawing.Point(280, 125);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(11, 12);
            this.label34.TabIndex = 112;
            this.label34.Text = "*";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.Color.Red;
            this.label33.Location = new System.Drawing.Point(559, 93);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(11, 12);
            this.label33.TabIndex = 111;
            this.label33.Text = "*";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.Color.Red;
            this.label32.Location = new System.Drawing.Point(338, 93);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(11, 12);
            this.label32.TabIndex = 110;
            this.label32.Text = "*";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.Red;
            this.label31.Location = new System.Drawing.Point(625, 62);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(11, 12);
            this.label31.TabIndex = 109;
            this.label31.Text = "*";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.Red;
            this.label30.Location = new System.Drawing.Point(315, 62);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(11, 12);
            this.label30.TabIndex = 108;
            this.label30.Text = "*";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.Red;
            this.label29.Location = new System.Drawing.Point(499, 62);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(11, 12);
            this.label29.TabIndex = 107;
            this.label29.Text = "*";
            // 
            // TBUserID
            // 
            this.TBUserID.Location = new System.Drawing.Point(488, 26);
            this.TBUserID.Name = "TBUserID";
            this.TBUserID.ReadOnly = true;
            this.TBUserID.Size = new System.Drawing.Size(100, 21);
            this.TBUserID.TabIndex = 106;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(411, 29);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(65, 12);
            this.label27.TabIndex = 105;
            this.label27.Text = "申请用户ID";
            // 
            // TBCraft
            // 
            this.TBCraft.Location = new System.Drawing.Point(470, 380);
            this.TBCraft.Name = "TBCraft";
            this.TBCraft.ReadOnly = true;
            this.TBCraft.Size = new System.Drawing.Size(100, 21);
            this.TBCraft.TabIndex = 104;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(414, 383);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(29, 12);
            this.label90.TabIndex = 103;
            this.label90.Text = "工种";
            // 
            // TBSpecialty
            // 
            this.TBSpecialty.Location = new System.Drawing.Point(185, 380);
            this.TBSpecialty.Name = "TBSpecialty";
            this.TBSpecialty.ReadOnly = true;
            this.TBSpecialty.Size = new System.Drawing.Size(210, 21);
            this.TBSpecialty.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 99;
            this.label2.Text = "专长";
            // 
            // TBCertificate
            // 
            this.TBCertificate.Location = new System.Drawing.Point(470, 343);
            this.TBCertificate.Name = "TBCertificate";
            this.TBCertificate.ReadOnly = true;
            this.TBCertificate.Size = new System.Drawing.Size(100, 21);
            this.TBCertificate.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 97;
            this.label3.Text = "资格证书";
            // 
            // TBTechnicalTitle
            // 
            this.TBTechnicalTitle.Location = new System.Drawing.Point(209, 343);
            this.TBTechnicalTitle.Name = "TBTechnicalTitle";
            this.TBTechnicalTitle.ReadOnly = true;
            this.TBTechnicalTitle.Size = new System.Drawing.Size(100, 21);
            this.TBTechnicalTitle.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 95;
            this.label4.Text = "技术职称";
            // 
            // TBResignationTime
            // 
            this.TBResignationTime.Location = new System.Drawing.Point(470, 309);
            this.TBResignationTime.Name = "TBResignationTime";
            this.TBResignationTime.ReadOnly = true;
            this.TBResignationTime.Size = new System.Drawing.Size(100, 21);
            this.TBResignationTime.TabIndex = 94;
            this.TBResignationTime.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 93;
            this.label5.Text = "离职时间";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 91;
            this.label6.Text = "到岗时间";
            // 
            // TBPosition
            // 
            this.TBPosition.Location = new System.Drawing.Point(470, 271);
            this.TBPosition.Name = "TBPosition";
            this.TBPosition.ReadOnly = true;
            this.TBPosition.Size = new System.Drawing.Size(100, 21);
            this.TBPosition.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 89;
            this.label7.Text = "求职岗位";
            // 
            // TBPhone
            // 
            this.TBPhone.Location = new System.Drawing.Point(209, 271);
            this.TBPhone.Name = "TBPhone";
            this.TBPhone.ReadOnly = true;
            this.TBPhone.Size = new System.Drawing.Size(100, 21);
            this.TBPhone.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 87;
            this.label8.Text = "联系电话";
            // 
            // TBCurrentAddress
            // 
            this.TBCurrentAddress.Location = new System.Drawing.Point(470, 231);
            this.TBCurrentAddress.Name = "TBCurrentAddress";
            this.TBCurrentAddress.ReadOnly = true;
            this.TBCurrentAddress.Size = new System.Drawing.Size(100, 21);
            this.TBCurrentAddress.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 85;
            this.label9.Text = "现住址";
            // 
            // TBIDNumber
            // 
            this.TBIDNumber.Location = new System.Drawing.Point(209, 231);
            this.TBIDNumber.Name = "TBIDNumber";
            this.TBIDNumber.ReadOnly = true;
            this.TBIDNumber.Size = new System.Drawing.Size(123, 21);
            this.TBIDNumber.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 83;
            this.label10.Text = "身份证编号";
            // 
            // TBHouseholdRegisterLocation
            // 
            this.TBHouseholdRegisterLocation.Location = new System.Drawing.Point(470, 193);
            this.TBHouseholdRegisterLocation.Name = "TBHouseholdRegisterLocation";
            this.TBHouseholdRegisterLocation.ReadOnly = true;
            this.TBHouseholdRegisterLocation.Size = new System.Drawing.Size(100, 21);
            this.TBHouseholdRegisterLocation.TabIndex = 82;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(399, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 81;
            this.label11.Text = "户口所在地";
            // 
            // TBBirthControlCertificateNumber
            // 
            this.TBBirthControlCertificateNumber.Location = new System.Drawing.Point(209, 193);
            this.TBBirthControlCertificateNumber.Name = "TBBirthControlCertificateNumber";
            this.TBBirthControlCertificateNumber.ReadOnly = true;
            this.TBBirthControlCertificateNumber.Size = new System.Drawing.Size(123, 21);
            this.TBBirthControlCertificateNumber.TabIndex = 80;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(138, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 79;
            this.label12.Text = "计生证编号";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(399, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 12);
            this.label13.TabIndex = 77;
            this.label13.Text = "有无外出人员就业卡";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(149, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 75;
            this.label14.Text = "婚姻状况";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(517, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 73;
            this.label15.Text = "学历";
            // 
            // TBPoliticalLandscape
            // 
            this.TBPoliticalLandscape.Location = new System.Drawing.Point(401, 122);
            this.TBPoliticalLandscape.Name = "TBPoliticalLandscape";
            this.TBPoliticalLandscape.ReadOnly = true;
            this.TBPoliticalLandscape.Size = new System.Drawing.Size(77, 21);
            this.TBPoliticalLandscape.TabIndex = 72;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(330, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 71;
            this.label16.Text = "政治面貌";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(149, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 69;
            this.label17.Text = "户口性质";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(315, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 12);
            this.label18.TabIndex = 67;
            this.label18.Text = "月";
            // 
            // TBMonth
            // 
            this.TBMonth.Location = new System.Drawing.Point(280, 89);
            this.TBMonth.Name = "TBMonth";
            this.TBMonth.ReadOnly = true;
            this.TBMonth.Size = new System.Drawing.Size(28, 21);
            this.TBMonth.TabIndex = 66;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(257, 93);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 12);
            this.label19.TabIndex = 65;
            this.label19.Text = "年";
            // 
            // TBYear
            // 
            this.TBYear.Location = new System.Drawing.Point(209, 89);
            this.TBYear.Name = "TBYear";
            this.TBYear.ReadOnly = true;
            this.TBYear.Size = new System.Drawing.Size(42, 21);
            this.TBYear.TabIndex = 64;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(150, 92);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 63;
            this.label20.Text = "出生日期";
            // 
            // TBHometown
            // 
            this.TBHometown.Location = new System.Drawing.Point(446, 89);
            this.TBHometown.Name = "TBHometown";
            this.TBHometown.ReadOnly = true;
            this.TBHometown.Size = new System.Drawing.Size(100, 21);
            this.TBHometown.TabIndex = 62;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(399, 92);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 61;
            this.label21.Text = "籍贯";
            // 
            // TBNation
            // 
            this.TBNation.Location = new System.Drawing.Point(552, 59);
            this.TBNation.Name = "TBNation";
            this.TBNation.ReadOnly = true;
            this.TBNation.Size = new System.Drawing.Size(62, 21);
            this.TBNation.TabIndex = 60;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(517, 62);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 59;
            this.label22.Text = "民族";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(399, 62);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 12);
            this.label23.TabIndex = 57;
            this.label23.Text = "性别";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(209, 59);
            this.TBName.Name = "TBName";
            this.TBName.ReadOnly = true;
            this.TBName.Size = new System.Drawing.Size(100, 21);
            this.TBName.TabIndex = 56;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(173, 62);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 12);
            this.label24.TabIndex = 55;
            this.label24.Text = "姓名";
            // 
            // TBEntryApplicationID
            // 
            this.TBEntryApplicationID.Location = new System.Drawing.Point(209, 26);
            this.TBEntryApplicationID.Name = "TBEntryApplicationID";
            this.TBEntryApplicationID.ReadOnly = true;
            this.TBEntryApplicationID.Size = new System.Drawing.Size(100, 21);
            this.TBEntryApplicationID.TabIndex = 54;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(138, 29);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 12);
            this.label25.TabIndex = 53;
            this.label25.Text = "入职申请ID";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(330, 8);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 12);
            this.label26.TabIndex = 52;
            this.label26.Text = "入职申请表";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bindingNavigator7);
            this.tabPage2.Controls.Add(this.Save2_EntryApplication);
            this.tabPage2.Controls.Add(this.查询ToolStrip);
            this.tabPage2.Controls.Add(this.Refresh_EntryApplication);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(758, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "入职申请学习信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Save2_EntryApplication
            // 
            this.Save2_EntryApplication.Location = new System.Drawing.Point(306, 422);
            this.Save2_EntryApplication.Name = "Save2_EntryApplication";
            this.Save2_EntryApplication.Size = new System.Drawing.Size(75, 23);
            this.Save2_EntryApplication.TabIndex = 5;
            this.Save2_EntryApplication.Text = "保存";
            this.Save2_EntryApplication.UseVisualStyleBackColor = true;
            this.Save2_EntryApplication.Click += new System.EventHandler(this.Save2_EntryApplication_Click);
            // 
            // 查询ToolStrip
            // 
            this.查询ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.查询ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入职申请IDToolStripLabel,
            this.入职申请IDToolStripTextBox,
            this.查询ToolStripButton});
            this.查询ToolStrip.Location = new System.Drawing.Point(46, 39);
            this.查询ToolStrip.Name = "查询ToolStrip";
            this.查询ToolStrip.Size = new System.Drawing.Size(242, 25);
            this.查询ToolStrip.TabIndex = 2;
            this.查询ToolStrip.Text = "查询ToolStrip";
            // 
            // 入职申请IDToolStripLabel
            // 
            this.入职申请IDToolStripLabel.Name = "入职申请IDToolStripLabel";
            this.入职申请IDToolStripLabel.Size = new System.Drawing.Size(72, 22);
            this.入职申请IDToolStripLabel.Text = "入职申请ID:";
            // 
            // 入职申请IDToolStripTextBox
            // 
            this.入职申请IDToolStripTextBox.Name = "入职申请IDToolStripTextBox";
            this.入职申请IDToolStripTextBox.Size = new System.Drawing.Size(120, 25);
            // 
            // 查询ToolStripButton
            // 
            this.查询ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.查询ToolStripButton.Name = "查询ToolStripButton";
            this.查询ToolStripButton.Size = new System.Drawing.Size(36, 22);
            this.查询ToolStripButton.Text = "查询";
            this.查询ToolStripButton.Click += new System.EventHandler(this.查询ToolStripButton_Click);
            // 
            // Refresh_EntryApplication
            // 
            this.Refresh_EntryApplication.Location = new System.Drawing.Point(546, 422);
            this.Refresh_EntryApplication.Name = "Refresh_EntryApplication";
            this.Refresh_EntryApplication.Size = new System.Drawing.Size(75, 23);
            this.Refresh_EntryApplication.TabIndex = 4;
            this.Refresh_EntryApplication.Text = "刷新";
            this.Refresh_EntryApplication.UseVisualStyleBackColor = true;
            this.Refresh_EntryApplication.Click += new System.EventHandler(this.Refresh_EntryApplication_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entryApplicationIDDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.craftOrPositionDataGridViewTextBoxColumn,
            this.referenceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.entryApplicationLearningInformationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(575, 331);
            this.dataGridView1.TabIndex = 0;
            // 
            // entryApplicationIDDataGridViewTextBoxColumn
            // 
            this.entryApplicationIDDataGridViewTextBoxColumn.DataPropertyName = "EntryApplicationID";
            this.entryApplicationIDDataGridViewTextBoxColumn.HeaderText = "入职申请ID";
            this.entryApplicationIDDataGridViewTextBoxColumn.Name = "entryApplicationIDDataGridViewTextBoxColumn";
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "起始时间";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "结束时间";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            // 
            // craftOrPositionDataGridViewTextBoxColumn
            // 
            this.craftOrPositionDataGridViewTextBoxColumn.DataPropertyName = "CraftOrPosition";
            this.craftOrPositionDataGridViewTextBoxColumn.HeaderText = "工种或职务";
            this.craftOrPositionDataGridViewTextBoxColumn.Name = "craftOrPositionDataGridViewTextBoxColumn";
            // 
            // referenceDataGridViewTextBoxColumn
            // 
            this.referenceDataGridViewTextBoxColumn.DataPropertyName = "Reference";
            this.referenceDataGridViewTextBoxColumn.HeaderText = "证明人";
            this.referenceDataGridViewTextBoxColumn.Name = "referenceDataGridViewTextBoxColumn";
            // 
            // entryApplicationLearningInformationBindingSource
            // 
            this.entryApplicationLearningInformationBindingSource.DataMember = "EntryApplicationLearningInformation";
            this.entryApplicationLearningInformationBindingSource.DataSource = this.repairCenterDataSet13;
            // 
            // repairCenterDataSet13
            // 
            this.repairCenterDataSet13.DataSetName = "RepairCenterDataSet13";
            this.repairCenterDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.QueryDetailText_Employee);
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Controls.Add(this.QueryDetail_Employee);
            this.tabPage3.Controls.Add(this.Add_Employee);
            this.tabPage3.Controls.Add(this.Edit_Employee);
            this.tabPage3.Controls.Add(this.Clear_Employee);
            this.tabPage3.Controls.Add(this.Delete_Employee);
            this.tabPage3.Controls.Add(this.Save_Employee);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.panel6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(758, 498);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "员工信息表";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // QueryDetailText_Employee
            // 
            this.QueryDetailText_Employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QueryDetailText_Employee.FormattingEnabled = true;
            this.QueryDetailText_Employee.Items.AddRange(new object[] {
            "学习信息",
            "培训信息",
            "家庭信息",
            "考勤信息"});
            this.QueryDetailText_Employee.Location = new System.Drawing.Point(664, 466);
            this.QueryDetailText_Employee.Name = "QueryDetailText_Employee";
            this.QueryDetailText_Employee.Size = new System.Drawing.Size(88, 20);
            this.QueryDetailText_Employee.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SeaShell;
            this.panel5.Controls.Add(this.TBArrivalTime2);
            this.panel5.Controls.Add(this.CBIsOutGoingEmploymentCard2);
            this.panel5.Controls.Add(this.CBMaritalStatus2);
            this.panel5.Controls.Add(this.CBHouseholdRegisterType2);
            this.panel5.Controls.Add(this.CBEducationBackground2);
            this.panel5.Controls.Add(this.CBSex2);
            this.panel5.Controls.Add(this.label60);
            this.panel5.Controls.Add(this.label65);
            this.panel5.Controls.Add(this.label66);
            this.panel5.Controls.Add(this.label67);
            this.panel5.Controls.Add(this.label68);
            this.panel5.Controls.Add(this.label69);
            this.panel5.Controls.Add(this.label70);
            this.panel5.Controls.Add(this.label71);
            this.panel5.Controls.Add(this.label72);
            this.panel5.Controls.Add(this.label73);
            this.panel5.Controls.Add(this.label74);
            this.panel5.Controls.Add(this.label75);
            this.panel5.Controls.Add(this.label76);
            this.panel5.Controls.Add(this.label77);
            this.panel5.Controls.Add(this.label78);
            this.panel5.Controls.Add(this.label79);
            this.panel5.Controls.Add(this.label80);
            this.panel5.Controls.Add(this.label81);
            this.panel5.Controls.Add(this.TBCraft2);
            this.panel5.Controls.Add(this.label83);
            this.panel5.Controls.Add(this.TBSpecialty2);
            this.panel5.Controls.Add(this.label84);
            this.panel5.Controls.Add(this.TBCertificate2);
            this.panel5.Controls.Add(this.label85);
            this.panel5.Controls.Add(this.TBTechnicalTitle2);
            this.panel5.Controls.Add(this.label86);
            this.panel5.Controls.Add(this.TBResignationTime2);
            this.panel5.Controls.Add(this.label87);
            this.panel5.Controls.Add(this.label88);
            this.panel5.Controls.Add(this.TBPosition2);
            this.panel5.Controls.Add(this.label89);
            this.panel5.Controls.Add(this.TBPhone2);
            this.panel5.Controls.Add(this.label95);
            this.panel5.Controls.Add(this.TBCurrentAddress2);
            this.panel5.Controls.Add(this.label102);
            this.panel5.Controls.Add(this.TBIDNumber2);
            this.panel5.Controls.Add(this.label105);
            this.panel5.Controls.Add(this.TBHouseholdRegisterLocation2);
            this.panel5.Controls.Add(this.label106);
            this.panel5.Controls.Add(this.TBBirthControlCertificateNumber2);
            this.panel5.Controls.Add(this.label107);
            this.panel5.Controls.Add(this.label108);
            this.panel5.Controls.Add(this.label109);
            this.panel5.Controls.Add(this.label110);
            this.panel5.Controls.Add(this.TBPoliticalLandscape2);
            this.panel5.Controls.Add(this.label111);
            this.panel5.Controls.Add(this.label112);
            this.panel5.Controls.Add(this.label113);
            this.panel5.Controls.Add(this.TBMonth2);
            this.panel5.Controls.Add(this.label114);
            this.panel5.Controls.Add(this.TBYear2);
            this.panel5.Controls.Add(this.label115);
            this.panel5.Controls.Add(this.TBHometown2);
            this.panel5.Controls.Add(this.label116);
            this.panel5.Controls.Add(this.TBNation2);
            this.panel5.Controls.Add(this.label117);
            this.panel5.Controls.Add(this.label118);
            this.panel5.Controls.Add(this.TBName2);
            this.panel5.Controls.Add(this.label119);
            this.panel5.Controls.Add(this.TBEmployeeID2);
            this.panel5.Controls.Add(this.label120);
            this.panel5.Controls.Add(this.label121);
            this.panel5.Location = new System.Drawing.Point(0, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(758, 412);
            this.panel5.TabIndex = 21;
            // 
            // TBArrivalTime2
            // 
            this.TBArrivalTime2.Location = new System.Drawing.Point(208, 309);
            this.TBArrivalTime2.Name = "TBArrivalTime2";
            this.TBArrivalTime2.ReadOnly = true;
            this.TBArrivalTime2.Size = new System.Drawing.Size(100, 21);
            this.TBArrivalTime2.TabIndex = 132;
            // 
            // CBIsOutGoingEmploymentCard2
            // 
            this.CBIsOutGoingEmploymentCard2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBIsOutGoingEmploymentCard2.Enabled = false;
            this.CBIsOutGoingEmploymentCard2.FormattingEnabled = true;
            this.CBIsOutGoingEmploymentCard2.Items.AddRange(new object[] {
            "有",
            "无"});
            this.CBIsOutGoingEmploymentCard2.Location = new System.Drawing.Point(518, 155);
            this.CBIsOutGoingEmploymentCard2.Name = "CBIsOutGoingEmploymentCard2";
            this.CBIsOutGoingEmploymentCard2.Size = new System.Drawing.Size(47, 20);
            this.CBIsOutGoingEmploymentCard2.TabIndex = 131;
            // 
            // CBMaritalStatus2
            // 
            this.CBMaritalStatus2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMaritalStatus2.Enabled = false;
            this.CBMaritalStatus2.FormattingEnabled = true;
            this.CBMaritalStatus2.Items.AddRange(new object[] {
            "未婚",
            "已婚"});
            this.CBMaritalStatus2.Location = new System.Drawing.Point(209, 155);
            this.CBMaritalStatus2.Name = "CBMaritalStatus2";
            this.CBMaritalStatus2.Size = new System.Drawing.Size(94, 20);
            this.CBMaritalStatus2.TabIndex = 130;
            // 
            // CBHouseholdRegisterType2
            // 
            this.CBHouseholdRegisterType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBHouseholdRegisterType2.Enabled = false;
            this.CBHouseholdRegisterType2.FormattingEnabled = true;
            this.CBHouseholdRegisterType2.Items.AddRange(new object[] {
            "农",
            "非农"});
            this.CBHouseholdRegisterType2.Location = new System.Drawing.Point(209, 122);
            this.CBHouseholdRegisterType2.Name = "CBHouseholdRegisterType2";
            this.CBHouseholdRegisterType2.Size = new System.Drawing.Size(94, 20);
            this.CBHouseholdRegisterType2.TabIndex = 129;
            // 
            // CBEducationBackground2
            // 
            this.CBEducationBackground2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.entryApplicationBindingSource2, "EducationBackground", true));
            this.CBEducationBackground2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEducationBackground2.Enabled = false;
            this.CBEducationBackground2.FormattingEnabled = true;
            this.CBEducationBackground2.Items.AddRange(new object[] {
            "小学",
            "初中",
            "高中",
            "中专",
            "大专",
            "本科",
            "硕士",
            "博士"});
            this.CBEducationBackground2.Location = new System.Drawing.Point(561, 122);
            this.CBEducationBackground2.Name = "CBEducationBackground2";
            this.CBEducationBackground2.Size = new System.Drawing.Size(63, 20);
            this.CBEducationBackground2.TabIndex = 128;
            // 
            // CBSex2
            // 
            this.CBSex2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSex2.Enabled = false;
            this.CBSex2.FormattingEnabled = true;
            this.CBSex2.Items.AddRange(new object[] {
            "男",
            "女"});
            this.CBSex2.Location = new System.Drawing.Point(434, 59);
            this.CBSex2.Name = "CBSex2";
            this.CBSex2.Size = new System.Drawing.Size(47, 20);
            this.CBSex2.TabIndex = 127;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.ForeColor = System.Drawing.Color.Red;
            this.label60.Location = new System.Drawing.Point(577, 347);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(11, 12);
            this.label60.TabIndex = 126;
            this.label60.Text = "*";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.ForeColor = System.Drawing.Color.Red;
            this.label65.Location = new System.Drawing.Point(315, 346);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(11, 12);
            this.label65.TabIndex = 125;
            this.label65.Text = "*";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.ForeColor = System.Drawing.Color.Red;
            this.label66.Location = new System.Drawing.Point(315, 312);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(11, 12);
            this.label66.TabIndex = 123;
            this.label66.Text = "*";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.ForeColor = System.Drawing.Color.Red;
            this.label67.Location = new System.Drawing.Point(577, 274);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(11, 12);
            this.label67.TabIndex = 122;
            this.label67.Text = "*";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.ForeColor = System.Drawing.Color.Red;
            this.label68.Location = new System.Drawing.Point(315, 274);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(11, 12);
            this.label68.TabIndex = 121;
            this.label68.Text = "*";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.ForeColor = System.Drawing.Color.Red;
            this.label69.Location = new System.Drawing.Point(577, 234);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(11, 12);
            this.label69.TabIndex = 120;
            this.label69.Text = "*";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.ForeColor = System.Drawing.Color.Red;
            this.label70.Location = new System.Drawing.Point(338, 234);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(11, 12);
            this.label70.TabIndex = 119;
            this.label70.Text = "*";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.ForeColor = System.Drawing.Color.Red;
            this.label71.Location = new System.Drawing.Point(577, 196);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(11, 12);
            this.label71.TabIndex = 118;
            this.label71.Text = "*";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.ForeColor = System.Drawing.Color.Red;
            this.label72.Location = new System.Drawing.Point(577, 158);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(11, 12);
            this.label72.TabIndex = 116;
            this.label72.Text = "*";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.ForeColor = System.Drawing.Color.Red;
            this.label73.Location = new System.Drawing.Point(315, 158);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(11, 12);
            this.label73.TabIndex = 115;
            this.label73.Text = "*";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.ForeColor = System.Drawing.Color.Red;
            this.label74.Location = new System.Drawing.Point(608, 125);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(11, 12);
            this.label74.TabIndex = 114;
            this.label74.Text = "*";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.ForeColor = System.Drawing.Color.Red;
            this.label75.Location = new System.Drawing.Point(484, 125);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(11, 12);
            this.label75.TabIndex = 113;
            this.label75.Text = "*";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.ForeColor = System.Drawing.Color.Red;
            this.label76.Location = new System.Drawing.Point(280, 125);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(11, 12);
            this.label76.TabIndex = 112;
            this.label76.Text = "*";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.ForeColor = System.Drawing.Color.Red;
            this.label77.Location = new System.Drawing.Point(559, 93);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(11, 12);
            this.label77.TabIndex = 111;
            this.label77.Text = "*";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.ForeColor = System.Drawing.Color.Red;
            this.label78.Location = new System.Drawing.Point(338, 93);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(11, 12);
            this.label78.TabIndex = 110;
            this.label78.Text = "*";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.ForeColor = System.Drawing.Color.Red;
            this.label79.Location = new System.Drawing.Point(625, 62);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(11, 12);
            this.label79.TabIndex = 109;
            this.label79.Text = "*";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.ForeColor = System.Drawing.Color.Red;
            this.label80.Location = new System.Drawing.Point(315, 62);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(11, 12);
            this.label80.TabIndex = 108;
            this.label80.Text = "*";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.ForeColor = System.Drawing.Color.Red;
            this.label81.Location = new System.Drawing.Point(499, 62);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(11, 12);
            this.label81.TabIndex = 107;
            this.label81.Text = "*";
            // 
            // TBCraft2
            // 
            this.TBCraft2.Location = new System.Drawing.Point(470, 380);
            this.TBCraft2.Name = "TBCraft2";
            this.TBCraft2.ReadOnly = true;
            this.TBCraft2.Size = new System.Drawing.Size(100, 21);
            this.TBCraft2.TabIndex = 104;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(414, 383);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(29, 12);
            this.label83.TabIndex = 103;
            this.label83.Text = "工种";
            // 
            // TBSpecialty2
            // 
            this.TBSpecialty2.Location = new System.Drawing.Point(185, 380);
            this.TBSpecialty2.Name = "TBSpecialty2";
            this.TBSpecialty2.ReadOnly = true;
            this.TBSpecialty2.Size = new System.Drawing.Size(210, 21);
            this.TBSpecialty2.TabIndex = 100;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(149, 383);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(29, 12);
            this.label84.TabIndex = 99;
            this.label84.Text = "专长";
            // 
            // TBCertificate2
            // 
            this.TBCertificate2.Location = new System.Drawing.Point(470, 343);
            this.TBCertificate2.Name = "TBCertificate2";
            this.TBCertificate2.ReadOnly = true;
            this.TBCertificate2.Size = new System.Drawing.Size(100, 21);
            this.TBCertificate2.TabIndex = 98;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(399, 346);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(53, 12);
            this.label85.TabIndex = 97;
            this.label85.Text = "资格证书";
            // 
            // TBTechnicalTitle2
            // 
            this.TBTechnicalTitle2.Location = new System.Drawing.Point(209, 343);
            this.TBTechnicalTitle2.Name = "TBTechnicalTitle2";
            this.TBTechnicalTitle2.ReadOnly = true;
            this.TBTechnicalTitle2.Size = new System.Drawing.Size(100, 21);
            this.TBTechnicalTitle2.TabIndex = 96;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(149, 346);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(53, 12);
            this.label86.TabIndex = 95;
            this.label86.Text = "技术职称";
            // 
            // TBResignationTime2
            // 
            this.TBResignationTime2.Location = new System.Drawing.Point(470, 309);
            this.TBResignationTime2.Name = "TBResignationTime2";
            this.TBResignationTime2.ReadOnly = true;
            this.TBResignationTime2.Size = new System.Drawing.Size(100, 21);
            this.TBResignationTime2.TabIndex = 94;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(399, 312);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(53, 12);
            this.label87.TabIndex = 93;
            this.label87.Text = "离职时间";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(149, 312);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(53, 12);
            this.label88.TabIndex = 91;
            this.label88.Text = "到岗时间";
            // 
            // TBPosition2
            // 
            this.TBPosition2.Location = new System.Drawing.Point(470, 271);
            this.TBPosition2.Name = "TBPosition2";
            this.TBPosition2.ReadOnly = true;
            this.TBPosition2.Size = new System.Drawing.Size(100, 21);
            this.TBPosition2.TabIndex = 90;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(399, 274);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(53, 12);
            this.label89.TabIndex = 89;
            this.label89.Text = "安排岗位";
            // 
            // TBPhone2
            // 
            this.TBPhone2.Location = new System.Drawing.Point(209, 271);
            this.TBPhone2.Name = "TBPhone2";
            this.TBPhone2.ReadOnly = true;
            this.TBPhone2.Size = new System.Drawing.Size(100, 21);
            this.TBPhone2.TabIndex = 88;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(149, 274);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(53, 12);
            this.label95.TabIndex = 87;
            this.label95.Text = "联系电话";
            // 
            // TBCurrentAddress2
            // 
            this.TBCurrentAddress2.Location = new System.Drawing.Point(470, 231);
            this.TBCurrentAddress2.Name = "TBCurrentAddress2";
            this.TBCurrentAddress2.ReadOnly = true;
            this.TBCurrentAddress2.Size = new System.Drawing.Size(100, 21);
            this.TBCurrentAddress2.TabIndex = 86;
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(401, 234);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(41, 12);
            this.label102.TabIndex = 85;
            this.label102.Text = "现住址";
            // 
            // TBIDNumber2
            // 
            this.TBIDNumber2.Location = new System.Drawing.Point(209, 231);
            this.TBIDNumber2.Name = "TBIDNumber2";
            this.TBIDNumber2.ReadOnly = true;
            this.TBIDNumber2.Size = new System.Drawing.Size(123, 21);
            this.TBIDNumber2.TabIndex = 84;
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(138, 234);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(65, 12);
            this.label105.TabIndex = 83;
            this.label105.Text = "身份证编号";
            // 
            // TBHouseholdRegisterLocation2
            // 
            this.TBHouseholdRegisterLocation2.Location = new System.Drawing.Point(470, 193);
            this.TBHouseholdRegisterLocation2.Name = "TBHouseholdRegisterLocation2";
            this.TBHouseholdRegisterLocation2.ReadOnly = true;
            this.TBHouseholdRegisterLocation2.Size = new System.Drawing.Size(100, 21);
            this.TBHouseholdRegisterLocation2.TabIndex = 82;
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(399, 196);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(65, 12);
            this.label106.TabIndex = 81;
            this.label106.Text = "户口所在地";
            // 
            // TBBirthControlCertificateNumber2
            // 
            this.TBBirthControlCertificateNumber2.Location = new System.Drawing.Point(209, 193);
            this.TBBirthControlCertificateNumber2.Name = "TBBirthControlCertificateNumber2";
            this.TBBirthControlCertificateNumber2.ReadOnly = true;
            this.TBBirthControlCertificateNumber2.Size = new System.Drawing.Size(123, 21);
            this.TBBirthControlCertificateNumber2.TabIndex = 80;
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(138, 196);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(65, 12);
            this.label107.TabIndex = 79;
            this.label107.Text = "计生证编号";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(399, 158);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(113, 12);
            this.label108.TabIndex = 77;
            this.label108.Text = "有无外出人员就业卡";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(149, 158);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(53, 12);
            this.label109.TabIndex = 75;
            this.label109.Text = "婚姻状况";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(517, 125);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(29, 12);
            this.label110.TabIndex = 73;
            this.label110.Text = "学历";
            // 
            // TBPoliticalLandscape2
            // 
            this.TBPoliticalLandscape2.Location = new System.Drawing.Point(401, 122);
            this.TBPoliticalLandscape2.Name = "TBPoliticalLandscape2";
            this.TBPoliticalLandscape2.ReadOnly = true;
            this.TBPoliticalLandscape2.Size = new System.Drawing.Size(77, 21);
            this.TBPoliticalLandscape2.TabIndex = 72;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(330, 125);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(53, 12);
            this.label111.TabIndex = 71;
            this.label111.Text = "政治面貌";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(149, 125);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(53, 12);
            this.label112.TabIndex = 69;
            this.label112.Text = "户口性质";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(315, 92);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(17, 12);
            this.label113.TabIndex = 67;
            this.label113.Text = "月";
            // 
            // TBMonth2
            // 
            this.TBMonth2.Location = new System.Drawing.Point(280, 89);
            this.TBMonth2.Name = "TBMonth2";
            this.TBMonth2.ReadOnly = true;
            this.TBMonth2.Size = new System.Drawing.Size(28, 21);
            this.TBMonth2.TabIndex = 66;
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(257, 93);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(17, 12);
            this.label114.TabIndex = 65;
            this.label114.Text = "年";
            // 
            // TBYear2
            // 
            this.TBYear2.Location = new System.Drawing.Point(209, 89);
            this.TBYear2.Name = "TBYear2";
            this.TBYear2.ReadOnly = true;
            this.TBYear2.Size = new System.Drawing.Size(42, 21);
            this.TBYear2.TabIndex = 64;
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(150, 92);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(53, 12);
            this.label115.TabIndex = 63;
            this.label115.Text = "出生日期";
            // 
            // TBHometown2
            // 
            this.TBHometown2.Location = new System.Drawing.Point(446, 89);
            this.TBHometown2.Name = "TBHometown2";
            this.TBHometown2.ReadOnly = true;
            this.TBHometown2.Size = new System.Drawing.Size(100, 21);
            this.TBHometown2.TabIndex = 62;
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(399, 92);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(29, 12);
            this.label116.TabIndex = 61;
            this.label116.Text = "籍贯";
            // 
            // TBNation2
            // 
            this.TBNation2.Location = new System.Drawing.Point(552, 59);
            this.TBNation2.Name = "TBNation2";
            this.TBNation2.ReadOnly = true;
            this.TBNation2.Size = new System.Drawing.Size(62, 21);
            this.TBNation2.TabIndex = 60;
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(517, 62);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(29, 12);
            this.label117.TabIndex = 59;
            this.label117.Text = "民族";
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(399, 62);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(29, 12);
            this.label118.TabIndex = 57;
            this.label118.Text = "性别";
            // 
            // TBName2
            // 
            this.TBName2.Location = new System.Drawing.Point(209, 59);
            this.TBName2.Name = "TBName2";
            this.TBName2.ReadOnly = true;
            this.TBName2.Size = new System.Drawing.Size(100, 21);
            this.TBName2.TabIndex = 56;
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(173, 62);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(29, 12);
            this.label119.TabIndex = 55;
            this.label119.Text = "姓名";
            // 
            // TBEmployeeID2
            // 
            this.TBEmployeeID2.Location = new System.Drawing.Point(209, 26);
            this.TBEmployeeID2.Name = "TBEmployeeID2";
            this.TBEmployeeID2.ReadOnly = true;
            this.TBEmployeeID2.Size = new System.Drawing.Size(100, 21);
            this.TBEmployeeID2.TabIndex = 54;
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(161, 29);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(41, 12);
            this.label120.TabIndex = 53;
            this.label120.Text = "员工ID";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(330, 8);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(65, 12);
            this.label121.TabIndex = 52;
            this.label121.Text = "员工信息表";
            // 
            // QueryDetail_Employee
            // 
            this.QueryDetail_Employee.Enabled = false;
            this.QueryDetail_Employee.Location = new System.Drawing.Point(586, 464);
            this.QueryDetail_Employee.Name = "QueryDetail_Employee";
            this.QueryDetail_Employee.Size = new System.Drawing.Size(70, 23);
            this.QueryDetail_Employee.TabIndex = 20;
            this.QueryDetail_Employee.Text = "查询相应";
            this.QueryDetail_Employee.UseVisualStyleBackColor = true;
            this.QueryDetail_Employee.Click += new System.EventHandler(this.QueryDetail_Employee_Click);
            // 
            // Add_Employee
            // 
            this.Add_Employee.Location = new System.Drawing.Point(46, 464);
            this.Add_Employee.Name = "Add_Employee";
            this.Add_Employee.Size = new System.Drawing.Size(75, 23);
            this.Add_Employee.TabIndex = 19;
            this.Add_Employee.Text = "添加";
            this.Add_Employee.UseVisualStyleBackColor = true;
            this.Add_Employee.Click += new System.EventHandler(this.Add_Employee_Click);
            // 
            // Edit_Employee
            // 
            this.Edit_Employee.Enabled = false;
            this.Edit_Employee.Location = new System.Drawing.Point(152, 464);
            this.Edit_Employee.Name = "Edit_Employee";
            this.Edit_Employee.Size = new System.Drawing.Size(75, 23);
            this.Edit_Employee.TabIndex = 18;
            this.Edit_Employee.Text = "修改";
            this.Edit_Employee.UseVisualStyleBackColor = true;
            this.Edit_Employee.Click += new System.EventHandler(this.Edit_Employee_Click);
            // 
            // Clear_Employee
            // 
            this.Clear_Employee.Enabled = false;
            this.Clear_Employee.Location = new System.Drawing.Point(485, 464);
            this.Clear_Employee.Name = "Clear_Employee";
            this.Clear_Employee.Size = new System.Drawing.Size(75, 23);
            this.Clear_Employee.TabIndex = 17;
            this.Clear_Employee.Text = "清空";
            this.Clear_Employee.UseVisualStyleBackColor = true;
            this.Clear_Employee.Click += new System.EventHandler(this.Clear_Employee_Click);
            // 
            // Delete_Employee
            // 
            this.Delete_Employee.Enabled = false;
            this.Delete_Employee.Location = new System.Drawing.Point(377, 464);
            this.Delete_Employee.Name = "Delete_Employee";
            this.Delete_Employee.Size = new System.Drawing.Size(75, 23);
            this.Delete_Employee.TabIndex = 16;
            this.Delete_Employee.Text = "删除";
            this.Delete_Employee.UseVisualStyleBackColor = true;
            this.Delete_Employee.Click += new System.EventHandler(this.Delete_Employee_Click);
            // 
            // Save_Employee
            // 
            this.Save_Employee.Enabled = false;
            this.Save_Employee.Location = new System.Drawing.Point(263, 464);
            this.Save_Employee.Name = "Save_Employee";
            this.Save_Employee.Size = new System.Drawing.Size(75, 23);
            this.Save_Employee.TabIndex = 15;
            this.Save_Employee.Text = "保存";
            this.Save_Employee.UseVisualStyleBackColor = true;
            this.Save_Employee.Click += new System.EventHandler(this.Save_Employee_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "查询员工ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.Controls.Add(this.Query_Employee);
            this.panel6.Controls.Add(this.EmployeeID);
            this.panel6.Controls.Add(this.label28);
            this.panel6.Location = new System.Drawing.Point(438, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(282, 25);
            this.panel6.TabIndex = 12;
            // 
            // Query_Employee
            // 
            this.Query_Employee.Location = new System.Drawing.Point(193, 0);
            this.Query_Employee.Name = "Query_Employee";
            this.Query_Employee.Size = new System.Drawing.Size(75, 23);
            this.Query_Employee.TabIndex = 6;
            this.Query_Employee.Text = "查询";
            this.Query_Employee.UseVisualStyleBackColor = true;
            this.Query_Employee.Click += new System.EventHandler(this.Query_Employee_Click);
            // 
            // EmployeeID
            // 
            this.EmployeeID.Location = new System.Drawing.Point(66, 2);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(100, 21);
            this.EmployeeID.TabIndex = 5;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 6);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 12);
            this.label28.TabIndex = 4;
            this.label28.Text = "员工ID";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.bindingNavigator1);
            this.tabPage4.Controls.Add(this.员工学习信息查询ToolStrip);
            this.tabPage4.Controls.Add(this.Refresh_EmployeeLearning);
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Controls.Add(this.Save_EmployeeLearning);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(758, 498);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "员工学习信息";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(752, 25);
            this.bindingNavigator1.TabIndex = 11;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // 员工学习信息查询ToolStrip
            // 
            this.员工学习信息查询ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.员工学习信息查询ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工信息IDToolStripLabel,
            this.员工信息IDToolStripTextBox,
            this.员工学习信息查询ToolStripButton});
            this.员工学习信息查询ToolStrip.Location = new System.Drawing.Point(41, 48);
            this.员工学习信息查询ToolStrip.Name = "员工学习信息查询ToolStrip";
            this.员工学习信息查询ToolStrip.Size = new System.Drawing.Size(270, 25);
            this.员工学习信息查询ToolStrip.TabIndex = 2;
            this.员工学习信息查询ToolStrip.Text = "员工学习信息查询ToolStrip";
            // 
            // 员工信息IDToolStripLabel
            // 
            this.员工信息IDToolStripLabel.Name = "员工信息IDToolStripLabel";
            this.员工信息IDToolStripLabel.Size = new System.Drawing.Size(48, 22);
            this.员工信息IDToolStripLabel.Text = "员工ID:";
            // 
            // 员工信息IDToolStripTextBox
            // 
            this.员工信息IDToolStripTextBox.Name = "员工信息IDToolStripTextBox";
            this.员工信息IDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // 员工学习信息查询ToolStripButton
            // 
            this.员工学习信息查询ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.员工学习信息查询ToolStripButton.Name = "员工学习信息查询ToolStripButton";
            this.员工学习信息查询ToolStripButton.Size = new System.Drawing.Size(108, 22);
            this.员工学习信息查询ToolStripButton.Text = "员工学习信息查询";
            this.员工学习信息查询ToolStripButton.Click += new System.EventHandler(this.员工学习信息查询ToolStripButton_Click);
            // 
            // Refresh_EmployeeLearning
            // 
            this.Refresh_EmployeeLearning.Location = new System.Drawing.Point(633, 432);
            this.Refresh_EmployeeLearning.Name = "Refresh_EmployeeLearning";
            this.Refresh_EmployeeLearning.Size = new System.Drawing.Size(75, 23);
            this.Refresh_EmployeeLearning.TabIndex = 10;
            this.Refresh_EmployeeLearning.Text = "刷新";
            this.Refresh_EmployeeLearning.UseVisualStyleBackColor = true;
            this.Refresh_EmployeeLearning.Click += new System.EventHandler(this.Refresh_EmployeeLearning_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employmenIDDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn1,
            this.endTimeDataGridViewTextBoxColumn1,
            this.craftOrPositionDataGridViewTextBoxColumn1,
            this.referenceDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.employmentLearningInformationBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(41, 74);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(667, 326);
            this.dataGridView3.TabIndex = 2;
            // 
            // employmenIDDataGridViewTextBoxColumn
            // 
            this.employmenIDDataGridViewTextBoxColumn.DataPropertyName = "EmploymenID";
            this.employmenIDDataGridViewTextBoxColumn.HeaderText = "员工信息ID";
            this.employmenIDDataGridViewTextBoxColumn.Name = "employmenIDDataGridViewTextBoxColumn";
            // 
            // startTimeDataGridViewTextBoxColumn1
            // 
            this.startTimeDataGridViewTextBoxColumn1.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn1.HeaderText = "起始时间";
            this.startTimeDataGridViewTextBoxColumn1.Name = "startTimeDataGridViewTextBoxColumn1";
            // 
            // endTimeDataGridViewTextBoxColumn1
            // 
            this.endTimeDataGridViewTextBoxColumn1.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn1.HeaderText = "结束时间";
            this.endTimeDataGridViewTextBoxColumn1.Name = "endTimeDataGridViewTextBoxColumn1";
            // 
            // craftOrPositionDataGridViewTextBoxColumn1
            // 
            this.craftOrPositionDataGridViewTextBoxColumn1.DataPropertyName = "CraftOrPosition";
            this.craftOrPositionDataGridViewTextBoxColumn1.HeaderText = "工种或职务";
            this.craftOrPositionDataGridViewTextBoxColumn1.Name = "craftOrPositionDataGridViewTextBoxColumn1";
            // 
            // referenceDataGridViewTextBoxColumn1
            // 
            this.referenceDataGridViewTextBoxColumn1.DataPropertyName = "Reference";
            this.referenceDataGridViewTextBoxColumn1.HeaderText = "证明人";
            this.referenceDataGridViewTextBoxColumn1.Name = "referenceDataGridViewTextBoxColumn1";
            // 
            // employmentLearningInformationBindingSource
            // 
            this.employmentLearningInformationBindingSource.DataMember = "EmploymentLearningInformation";
            this.employmentLearningInformationBindingSource.DataSource = this.repairCenterDataSet14;
            // 
            // repairCenterDataSet14
            // 
            this.repairCenterDataSet14.DataSetName = "RepairCenterDataSet14";
            this.repairCenterDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Save_EmployeeLearning
            // 
            this.Save_EmployeeLearning.Location = new System.Drawing.Point(415, 432);
            this.Save_EmployeeLearning.Name = "Save_EmployeeLearning";
            this.Save_EmployeeLearning.Size = new System.Drawing.Size(75, 23);
            this.Save_EmployeeLearning.TabIndex = 0;
            this.Save_EmployeeLearning.Text = "保存";
            this.Save_EmployeeLearning.UseVisualStyleBackColor = true;
            this.Save_EmployeeLearning.Click += new System.EventHandler(this.Save_EmployeeLearning_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.bindingNavigator2);
            this.tabPage5.Controls.Add(this.员工培训信息查询ToolStrip);
            this.tabPage5.Controls.Add(this.Refresh_EmployeeTrainIn);
            this.tabPage5.Controls.Add(this.Save_EmployeeTrainIn);
            this.tabPage5.Controls.Add(this.dataGridView4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(758, 498);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "员工培训信息";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator2.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator2.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator2.Size = new System.Drawing.Size(752, 25);
            this.bindingNavigator2.TabIndex = 11;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "新添";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem1.Text = "/ {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "位置";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // 员工培训信息查询ToolStrip
            // 
            this.员工培训信息查询ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.员工培训信息查询ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工信息IDToolStripLabel1,
            this.员工信息IDToolStripTextBox1,
            this.员工培训信息查询ToolStripButton});
            this.员工培训信息查询ToolStrip.Location = new System.Drawing.Point(35, 48);
            this.员工培训信息查询ToolStrip.Name = "员工培训信息查询ToolStrip";
            this.员工培训信息查询ToolStrip.Size = new System.Drawing.Size(270, 25);
            this.员工培训信息查询ToolStrip.TabIndex = 2;
            this.员工培训信息查询ToolStrip.Text = "员工培训信息查询ToolStrip";
            // 
            // 员工信息IDToolStripLabel1
            // 
            this.员工信息IDToolStripLabel1.Name = "员工信息IDToolStripLabel1";
            this.员工信息IDToolStripLabel1.Size = new System.Drawing.Size(48, 22);
            this.员工信息IDToolStripLabel1.Text = "员工ID:";
            // 
            // 员工信息IDToolStripTextBox1
            // 
            this.员工信息IDToolStripTextBox1.Name = "员工信息IDToolStripTextBox1";
            this.员工信息IDToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // 员工培训信息查询ToolStripButton
            // 
            this.员工培训信息查询ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.员工培训信息查询ToolStripButton.Name = "员工培训信息查询ToolStripButton";
            this.员工培训信息查询ToolStripButton.Size = new System.Drawing.Size(108, 22);
            this.员工培训信息查询ToolStripButton.Text = "员工培训信息查询";
            this.员工培训信息查询ToolStripButton.Click += new System.EventHandler(this.员工培训信息查询ToolStripButton_Click);
            // 
            // Refresh_EmployeeTrainIn
            // 
            this.Refresh_EmployeeTrainIn.Location = new System.Drawing.Point(580, 423);
            this.Refresh_EmployeeTrainIn.Name = "Refresh_EmployeeTrainIn";
            this.Refresh_EmployeeTrainIn.Size = new System.Drawing.Size(75, 23);
            this.Refresh_EmployeeTrainIn.TabIndex = 10;
            this.Refresh_EmployeeTrainIn.Text = "刷新";
            this.Refresh_EmployeeTrainIn.UseVisualStyleBackColor = true;
            this.Refresh_EmployeeTrainIn.Click += new System.EventHandler(this.Refresh_EmployeeTrainIn_Click);
            // 
            // Save_EmployeeTrainIn
            // 
            this.Save_EmployeeTrainIn.Location = new System.Drawing.Point(325, 423);
            this.Save_EmployeeTrainIn.Name = "Save_EmployeeTrainIn";
            this.Save_EmployeeTrainIn.Size = new System.Drawing.Size(75, 23);
            this.Save_EmployeeTrainIn.TabIndex = 1;
            this.Save_EmployeeTrainIn.Text = "保存";
            this.Save_EmployeeTrainIn.UseVisualStyleBackColor = true;
            this.Save_EmployeeTrainIn.Click += new System.EventHandler(this.Save_EmployeeTrainIn_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.trainTimeDataGridViewTextBoxColumn,
            this.trainContentDataGridViewTextBoxColumn,
            this.trainModeDataGridViewTextBoxColumn,
            this.trainEffectDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.employeeTrainInformationBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(35, 75);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(644, 327);
            this.dataGridView4.TabIndex = 0;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "员工信息ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // trainTimeDataGridViewTextBoxColumn
            // 
            this.trainTimeDataGridViewTextBoxColumn.DataPropertyName = "TrainTime";
            this.trainTimeDataGridViewTextBoxColumn.HeaderText = "培训时间";
            this.trainTimeDataGridViewTextBoxColumn.Name = "trainTimeDataGridViewTextBoxColumn";
            // 
            // trainContentDataGridViewTextBoxColumn
            // 
            this.trainContentDataGridViewTextBoxColumn.DataPropertyName = "TrainContent";
            this.trainContentDataGridViewTextBoxColumn.HeaderText = "培训内容";
            this.trainContentDataGridViewTextBoxColumn.Name = "trainContentDataGridViewTextBoxColumn";
            // 
            // trainModeDataGridViewTextBoxColumn
            // 
            this.trainModeDataGridViewTextBoxColumn.DataPropertyName = "TrainMode";
            this.trainModeDataGridViewTextBoxColumn.HeaderText = "培训方式";
            this.trainModeDataGridViewTextBoxColumn.Name = "trainModeDataGridViewTextBoxColumn";
            // 
            // trainEffectDataGridViewTextBoxColumn
            // 
            this.trainEffectDataGridViewTextBoxColumn.DataPropertyName = "TrainEffect";
            this.trainEffectDataGridViewTextBoxColumn.HeaderText = "培训效果";
            this.trainEffectDataGridViewTextBoxColumn.Name = "trainEffectDataGridViewTextBoxColumn";
            // 
            // employeeTrainInformationBindingSource
            // 
            this.employeeTrainInformationBindingSource.DataMember = "EmployeeTrainInformation";
            this.employeeTrainInformationBindingSource.DataSource = this.repairCenterDataSet15;
            // 
            // repairCenterDataSet15
            // 
            this.repairCenterDataSet15.DataSetName = "RepairCenterDataSet15";
            this.repairCenterDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.bindingNavigator3);
            this.tabPage6.Controls.Add(this.员工家庭信息查询ToolStrip);
            this.tabPage6.Controls.Add(this.Refresh_EmployeeFamily);
            this.tabPage6.Controls.Add(this.dataGridView5);
            this.tabPage6.Controls.Add(this.Save_EmployeeFamily);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(758, 498);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "员工家庭信息";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = this.bindingNavigatorAddNewItem2;
            this.bindingNavigator3.CountItem = this.bindingNavigatorCountItem2;
            this.bindingNavigator3.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.bindingNavigatorAddNewItem2,
            this.bindingNavigatorDeleteItem2});
            this.bindingNavigator3.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator3.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.bindingNavigator3.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.bindingNavigator3.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.bindingNavigator3.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = this.bindingNavigatorPositionItem2;
            this.bindingNavigator3.Size = new System.Drawing.Size(752, 25);
            this.bindingNavigator3.TabIndex = 11;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // bindingNavigatorAddNewItem2
            // 
            this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem2.Image")));
            this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem2";
            this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem2.Text = "新添";
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem2.Text = "/ {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem2";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem2.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem2.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem2.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "位置";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem2.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem2.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // 员工家庭信息查询ToolStrip
            // 
            this.员工家庭信息查询ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.员工家庭信息查询ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工信息IDToolStripLabel2,
            this.员工信息IDToolStripTextBox2,
            this.员工家庭信息查询ToolStripButton});
            this.员工家庭信息查询ToolStrip.Location = new System.Drawing.Point(37, 49);
            this.员工家庭信息查询ToolStrip.Name = "员工家庭信息查询ToolStrip";
            this.员工家庭信息查询ToolStrip.Size = new System.Drawing.Size(270, 25);
            this.员工家庭信息查询ToolStrip.TabIndex = 2;
            this.员工家庭信息查询ToolStrip.Text = "员工家庭信息查询ToolStrip";
            // 
            // 员工信息IDToolStripLabel2
            // 
            this.员工信息IDToolStripLabel2.Name = "员工信息IDToolStripLabel2";
            this.员工信息IDToolStripLabel2.Size = new System.Drawing.Size(48, 22);
            this.员工信息IDToolStripLabel2.Text = "员工ID:";
            // 
            // 员工信息IDToolStripTextBox2
            // 
            this.员工信息IDToolStripTextBox2.Name = "员工信息IDToolStripTextBox2";
            this.员工信息IDToolStripTextBox2.Size = new System.Drawing.Size(100, 25);
            // 
            // 员工家庭信息查询ToolStripButton
            // 
            this.员工家庭信息查询ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.员工家庭信息查询ToolStripButton.Name = "员工家庭信息查询ToolStripButton";
            this.员工家庭信息查询ToolStripButton.Size = new System.Drawing.Size(108, 22);
            this.员工家庭信息查询ToolStripButton.Text = "员工家庭信息查询";
            this.员工家庭信息查询ToolStripButton.Click += new System.EventHandler(this.员工家庭信息查询ToolStripButton_Click);
            // 
            // Refresh_EmployeeFamily
            // 
            this.Refresh_EmployeeFamily.Location = new System.Drawing.Point(545, 423);
            this.Refresh_EmployeeFamily.Name = "Refresh_EmployeeFamily";
            this.Refresh_EmployeeFamily.Size = new System.Drawing.Size(75, 23);
            this.Refresh_EmployeeFamily.TabIndex = 10;
            this.Refresh_EmployeeFamily.Text = "刷新";
            this.Refresh_EmployeeFamily.UseVisualStyleBackColor = true;
            this.Refresh_EmployeeFamily.Click += new System.EventHandler(this.Refresh_EmployeeFamily_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn1,
            this.appellationDataGridViewTextBoxColumn,
            this.currentDepartmentAndPositionDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.politicalLandscapeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.employeeFamilyInformationBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(37, 77);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.Height = 23;
            this.dataGridView5.Size = new System.Drawing.Size(670, 330);
            this.dataGridView5.TabIndex = 2;
            // 
            // employeeIDDataGridViewTextBoxColumn1
            // 
            this.employeeIDDataGridViewTextBoxColumn1.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn1.HeaderText = "员工信息ID";
            this.employeeIDDataGridViewTextBoxColumn1.Name = "employeeIDDataGridViewTextBoxColumn1";
            // 
            // appellationDataGridViewTextBoxColumn
            // 
            this.appellationDataGridViewTextBoxColumn.DataPropertyName = "Appellation";
            this.appellationDataGridViewTextBoxColumn.HeaderText = "称谓";
            this.appellationDataGridViewTextBoxColumn.Name = "appellationDataGridViewTextBoxColumn";
            // 
            // currentDepartmentAndPositionDataGridViewTextBoxColumn
            // 
            this.currentDepartmentAndPositionDataGridViewTextBoxColumn.DataPropertyName = "CurrentDepartmentAndPosition";
            this.currentDepartmentAndPositionDataGridViewTextBoxColumn.HeaderText = "现工作（学习）单位及职务";
            this.currentDepartmentAndPositionDataGridViewTextBoxColumn.Name = "currentDepartmentAndPositionDataGridViewTextBoxColumn";
            this.currentDepartmentAndPositionDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "联系电话";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // politicalLandscapeDataGridViewTextBoxColumn
            // 
            this.politicalLandscapeDataGridViewTextBoxColumn.DataPropertyName = "PoliticalLandscape";
            this.politicalLandscapeDataGridViewTextBoxColumn.HeaderText = "政治面貌";
            this.politicalLandscapeDataGridViewTextBoxColumn.Name = "politicalLandscapeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // employeeFamilyInformationBindingSource
            // 
            this.employeeFamilyInformationBindingSource.DataMember = "EmployeeFamilyInformation";
            this.employeeFamilyInformationBindingSource.DataSource = this.repairCenterDataSet16;
            // 
            // repairCenterDataSet16
            // 
            this.repairCenterDataSet16.DataSetName = "RepairCenterDataSet16";
            this.repairCenterDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Save_EmployeeFamily
            // 
            this.Save_EmployeeFamily.Location = new System.Drawing.Point(350, 423);
            this.Save_EmployeeFamily.Name = "Save_EmployeeFamily";
            this.Save_EmployeeFamily.Size = new System.Drawing.Size(75, 23);
            this.Save_EmployeeFamily.TabIndex = 0;
            this.Save_EmployeeFamily.Text = "保存";
            this.Save_EmployeeFamily.UseVisualStyleBackColor = true;
            this.Save_EmployeeFamily.Click += new System.EventHandler(this.Save_EmployeeFamily_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.bindingNavigator4);
            this.tabPage7.Controls.Add(this.考勤信息查询ToolStrip);
            this.tabPage7.Controls.Add(this.Refresh_CheckAttendance);
            this.tabPage7.Controls.Add(this.dataGridView6);
            this.tabPage7.Controls.Add(this.Save_CheckAttendance);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(758, 498);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "考勤信息";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator4
            // 
            this.bindingNavigator4.AddNewItem = this.bindingNavigatorAddNewItem3;
            this.bindingNavigator4.CountItem = this.bindingNavigatorCountItem3;
            this.bindingNavigator4.DeleteItem = this.bindingNavigatorDeleteItem3;
            this.bindingNavigator4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem3,
            this.bindingNavigatorMovePreviousItem3,
            this.bindingNavigatorSeparator9,
            this.bindingNavigatorPositionItem3,
            this.bindingNavigatorCountItem3,
            this.bindingNavigatorSeparator10,
            this.bindingNavigatorMoveNextItem3,
            this.bindingNavigatorMoveLastItem3,
            this.bindingNavigatorSeparator11,
            this.bindingNavigatorAddNewItem3,
            this.bindingNavigatorDeleteItem3});
            this.bindingNavigator4.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator4.MoveFirstItem = this.bindingNavigatorMoveFirstItem3;
            this.bindingNavigator4.MoveLastItem = this.bindingNavigatorMoveLastItem3;
            this.bindingNavigator4.MoveNextItem = this.bindingNavigatorMoveNextItem3;
            this.bindingNavigator4.MovePreviousItem = this.bindingNavigatorMovePreviousItem3;
            this.bindingNavigator4.Name = "bindingNavigator4";
            this.bindingNavigator4.PositionItem = this.bindingNavigatorPositionItem3;
            this.bindingNavigator4.Size = new System.Drawing.Size(752, 25);
            this.bindingNavigator4.TabIndex = 17;
            this.bindingNavigator4.Text = "bindingNavigator4";
            // 
            // bindingNavigatorAddNewItem3
            // 
            this.bindingNavigatorAddNewItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem3.Image")));
            this.bindingNavigatorAddNewItem3.Name = "bindingNavigatorAddNewItem3";
            this.bindingNavigatorAddNewItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem3.Text = "新添";
            // 
            // bindingNavigatorCountItem3
            // 
            this.bindingNavigatorCountItem3.Name = "bindingNavigatorCountItem3";
            this.bindingNavigatorCountItem3.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem3.Text = "/ {0}";
            this.bindingNavigatorCountItem3.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem3
            // 
            this.bindingNavigatorDeleteItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem3.Image")));
            this.bindingNavigatorDeleteItem3.Name = "bindingNavigatorDeleteItem3";
            this.bindingNavigatorDeleteItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem3.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem3
            // 
            this.bindingNavigatorMoveFirstItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem3.Image")));
            this.bindingNavigatorMoveFirstItem3.Name = "bindingNavigatorMoveFirstItem3";
            this.bindingNavigatorMoveFirstItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem3.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem3
            // 
            this.bindingNavigatorMovePreviousItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem3.Image")));
            this.bindingNavigatorMovePreviousItem3.Name = "bindingNavigatorMovePreviousItem3";
            this.bindingNavigatorMovePreviousItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem3.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator9
            // 
            this.bindingNavigatorSeparator9.Name = "bindingNavigatorSeparator9";
            this.bindingNavigatorSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem3
            // 
            this.bindingNavigatorPositionItem3.AccessibleName = "位置";
            this.bindingNavigatorPositionItem3.AutoSize = false;
            this.bindingNavigatorPositionItem3.Name = "bindingNavigatorPositionItem3";
            this.bindingNavigatorPositionItem3.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem3.Text = "0";
            this.bindingNavigatorPositionItem3.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator10
            // 
            this.bindingNavigatorSeparator10.Name = "bindingNavigatorSeparator10";
            this.bindingNavigatorSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem3
            // 
            this.bindingNavigatorMoveNextItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem3.Image")));
            this.bindingNavigatorMoveNextItem3.Name = "bindingNavigatorMoveNextItem3";
            this.bindingNavigatorMoveNextItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem3.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem3
            // 
            this.bindingNavigatorMoveLastItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem3.Image")));
            this.bindingNavigatorMoveLastItem3.Name = "bindingNavigatorMoveLastItem3";
            this.bindingNavigatorMoveLastItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem3.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator11
            // 
            this.bindingNavigatorSeparator11.Name = "bindingNavigatorSeparator11";
            this.bindingNavigatorSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // 考勤信息查询ToolStrip
            // 
            this.考勤信息查询ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.考勤信息查询ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工信息IDToolStripLabel3,
            this.员工信息IDToolStripTextBox3,
            this.考勤信息查询ToolStripButton});
            this.考勤信息查询ToolStrip.Location = new System.Drawing.Point(42, 48);
            this.考勤信息查询ToolStrip.Name = "考勤信息查询ToolStrip";
            this.考勤信息查询ToolStrip.Size = new System.Drawing.Size(246, 25);
            this.考勤信息查询ToolStrip.TabIndex = 2;
            this.考勤信息查询ToolStrip.Text = "考勤信息查询ToolStrip";
            // 
            // 员工信息IDToolStripLabel3
            // 
            this.员工信息IDToolStripLabel3.Name = "员工信息IDToolStripLabel3";
            this.员工信息IDToolStripLabel3.Size = new System.Drawing.Size(48, 22);
            this.员工信息IDToolStripLabel3.Text = "员工ID:";
            // 
            // 员工信息IDToolStripTextBox3
            // 
            this.员工信息IDToolStripTextBox3.Name = "员工信息IDToolStripTextBox3";
            this.员工信息IDToolStripTextBox3.Size = new System.Drawing.Size(100, 25);
            // 
            // 考勤信息查询ToolStripButton
            // 
            this.考勤信息查询ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.考勤信息查询ToolStripButton.Name = "考勤信息查询ToolStripButton";
            this.考勤信息查询ToolStripButton.Size = new System.Drawing.Size(84, 22);
            this.考勤信息查询ToolStripButton.Text = "考勤信息查询";
            this.考勤信息查询ToolStripButton.Click += new System.EventHandler(this.考勤信息查询ToolStripButton_Click);
            // 
            // Refresh_CheckAttendance
            // 
            this.Refresh_CheckAttendance.Location = new System.Drawing.Point(526, 425);
            this.Refresh_CheckAttendance.Name = "Refresh_CheckAttendance";
            this.Refresh_CheckAttendance.Size = new System.Drawing.Size(75, 23);
            this.Refresh_CheckAttendance.TabIndex = 16;
            this.Refresh_CheckAttendance.Text = "刷新";
            this.Refresh_CheckAttendance.UseVisualStyleBackColor = true;
            this.Refresh_CheckAttendance.Click += new System.EventHandler(this.Refresh_CheckAttendance_Click);
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn2,
            this.dateDataGridViewTextBoxColumn,
            this.checkResultDataGridViewTextBoxColumn});
            this.dataGridView6.DataSource = this.checkAttendanceBindingSource;
            this.dataGridView6.Location = new System.Drawing.Point(42, 75);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowTemplate.Height = 23;
            this.dataGridView6.Size = new System.Drawing.Size(669, 330);
            this.dataGridView6.TabIndex = 12;
            // 
            // employeeIDDataGridViewTextBoxColumn2
            // 
            this.employeeIDDataGridViewTextBoxColumn2.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn2.HeaderText = "员工信息ID";
            this.employeeIDDataGridViewTextBoxColumn2.Name = "employeeIDDataGridViewTextBoxColumn2";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "日期";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // checkResultDataGridViewTextBoxColumn
            // 
            this.checkResultDataGridViewTextBoxColumn.DataPropertyName = "CheckResult";
            this.checkResultDataGridViewTextBoxColumn.HeaderText = "考勤结果";
            this.checkResultDataGridViewTextBoxColumn.Name = "checkResultDataGridViewTextBoxColumn";
            // 
            // checkAttendanceBindingSource
            // 
            this.checkAttendanceBindingSource.DataMember = "CheckAttendance";
            this.checkAttendanceBindingSource.DataSource = this.repairCenterDataSet17;
            // 
            // repairCenterDataSet17
            // 
            this.repairCenterDataSet17.DataSetName = "RepairCenterDataSet17";
            this.repairCenterDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Save_CheckAttendance
            // 
            this.Save_CheckAttendance.Location = new System.Drawing.Point(361, 425);
            this.Save_CheckAttendance.Name = "Save_CheckAttendance";
            this.Save_CheckAttendance.Size = new System.Drawing.Size(75, 23);
            this.Save_CheckAttendance.TabIndex = 10;
            this.Save_CheckAttendance.Text = "保存";
            this.Save_CheckAttendance.UseVisualStyleBackColor = true;
            this.Save_CheckAttendance.Click += new System.EventHandler(this.Save_CheckAttendance_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.bindingNavigator5);
            this.tabPage8.Controls.Add(this.员工评价信息查询ToolStrip);
            this.tabPage8.Controls.Add(this.Refresh_EmployeeEvaluation);
            this.tabPage8.Controls.Add(this.dataGridView7);
            this.tabPage8.Controls.Add(this.Save_EmployeeEvaluation);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(758, 498);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "员工评价信息";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator5
            // 
            this.bindingNavigator5.AddNewItem = this.bindingNavigatorAddNewItem4;
            this.bindingNavigator5.CountItem = this.bindingNavigatorCountItem4;
            this.bindingNavigator5.DeleteItem = this.bindingNavigatorDeleteItem4;
            this.bindingNavigator5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem4,
            this.bindingNavigatorMovePreviousItem4,
            this.bindingNavigatorSeparator12,
            this.bindingNavigatorPositionItem4,
            this.bindingNavigatorCountItem4,
            this.bindingNavigatorSeparator13,
            this.bindingNavigatorMoveNextItem4,
            this.bindingNavigatorMoveLastItem4,
            this.bindingNavigatorSeparator14,
            this.bindingNavigatorAddNewItem4,
            this.bindingNavigatorDeleteItem4});
            this.bindingNavigator5.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator5.MoveFirstItem = this.bindingNavigatorMoveFirstItem4;
            this.bindingNavigator5.MoveLastItem = this.bindingNavigatorMoveLastItem4;
            this.bindingNavigator5.MoveNextItem = this.bindingNavigatorMoveNextItem4;
            this.bindingNavigator5.MovePreviousItem = this.bindingNavigatorMovePreviousItem4;
            this.bindingNavigator5.Name = "bindingNavigator5";
            this.bindingNavigator5.PositionItem = this.bindingNavigatorPositionItem4;
            this.bindingNavigator5.Size = new System.Drawing.Size(752, 25);
            this.bindingNavigator5.TabIndex = 17;
            this.bindingNavigator5.Text = "bindingNavigator5";
            // 
            // bindingNavigatorAddNewItem4
            // 
            this.bindingNavigatorAddNewItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem4.Image")));
            this.bindingNavigatorAddNewItem4.Name = "bindingNavigatorAddNewItem4";
            this.bindingNavigatorAddNewItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem4.Text = "新添";
            // 
            // bindingNavigatorCountItem4
            // 
            this.bindingNavigatorCountItem4.Name = "bindingNavigatorCountItem4";
            this.bindingNavigatorCountItem4.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem4.Text = "/ {0}";
            this.bindingNavigatorCountItem4.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem4
            // 
            this.bindingNavigatorDeleteItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem4.Image")));
            this.bindingNavigatorDeleteItem4.Name = "bindingNavigatorDeleteItem4";
            this.bindingNavigatorDeleteItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem4.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem4
            // 
            this.bindingNavigatorMoveFirstItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem4.Image")));
            this.bindingNavigatorMoveFirstItem4.Name = "bindingNavigatorMoveFirstItem4";
            this.bindingNavigatorMoveFirstItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem4.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem4
            // 
            this.bindingNavigatorMovePreviousItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem4.Image")));
            this.bindingNavigatorMovePreviousItem4.Name = "bindingNavigatorMovePreviousItem4";
            this.bindingNavigatorMovePreviousItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem4.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator12
            // 
            this.bindingNavigatorSeparator12.Name = "bindingNavigatorSeparator12";
            this.bindingNavigatorSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem4
            // 
            this.bindingNavigatorPositionItem4.AccessibleName = "位置";
            this.bindingNavigatorPositionItem4.AutoSize = false;
            this.bindingNavigatorPositionItem4.Name = "bindingNavigatorPositionItem4";
            this.bindingNavigatorPositionItem4.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem4.Text = "0";
            this.bindingNavigatorPositionItem4.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator13
            // 
            this.bindingNavigatorSeparator13.Name = "bindingNavigatorSeparator13";
            this.bindingNavigatorSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem4
            // 
            this.bindingNavigatorMoveNextItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem4.Image")));
            this.bindingNavigatorMoveNextItem4.Name = "bindingNavigatorMoveNextItem4";
            this.bindingNavigatorMoveNextItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem4.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem4
            // 
            this.bindingNavigatorMoveLastItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem4.Image")));
            this.bindingNavigatorMoveLastItem4.Name = "bindingNavigatorMoveLastItem4";
            this.bindingNavigatorMoveLastItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem4.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator14
            // 
            this.bindingNavigatorSeparator14.Name = "bindingNavigatorSeparator14";
            this.bindingNavigatorSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // 员工评价信息查询ToolStrip
            // 
            this.员工评价信息查询ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.员工评价信息查询ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工信息IDToolStripLabel4,
            this.员工信息IDToolStripTextBox4,
            this.员工评价信息查询ToolStripButton});
            this.员工评价信息查询ToolStrip.Location = new System.Drawing.Point(40, 54);
            this.员工评价信息查询ToolStrip.Name = "员工评价信息查询ToolStrip";
            this.员工评价信息查询ToolStrip.Size = new System.Drawing.Size(270, 25);
            this.员工评价信息查询ToolStrip.TabIndex = 2;
            this.员工评价信息查询ToolStrip.Text = "员工评价信息查询ToolStrip";
            // 
            // 员工信息IDToolStripLabel4
            // 
            this.员工信息IDToolStripLabel4.Name = "员工信息IDToolStripLabel4";
            this.员工信息IDToolStripLabel4.Size = new System.Drawing.Size(48, 22);
            this.员工信息IDToolStripLabel4.Text = "员工ID:";
            // 
            // 员工信息IDToolStripTextBox4
            // 
            this.员工信息IDToolStripTextBox4.Name = "员工信息IDToolStripTextBox4";
            this.员工信息IDToolStripTextBox4.Size = new System.Drawing.Size(100, 25);
            // 
            // 员工评价信息查询ToolStripButton
            // 
            this.员工评价信息查询ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.员工评价信息查询ToolStripButton.Name = "员工评价信息查询ToolStripButton";
            this.员工评价信息查询ToolStripButton.Size = new System.Drawing.Size(108, 22);
            this.员工评价信息查询ToolStripButton.Text = "员工评价信息查询";
            this.员工评价信息查询ToolStripButton.Click += new System.EventHandler(this.员工评价信息查询ToolStripButton_Click);
            // 
            // Refresh_EmployeeEvaluation
            // 
            this.Refresh_EmployeeEvaluation.Location = new System.Drawing.Point(504, 427);
            this.Refresh_EmployeeEvaluation.Name = "Refresh_EmployeeEvaluation";
            this.Refresh_EmployeeEvaluation.Size = new System.Drawing.Size(75, 23);
            this.Refresh_EmployeeEvaluation.TabIndex = 16;
            this.Refresh_EmployeeEvaluation.Text = "刷新";
            this.Refresh_EmployeeEvaluation.UseVisualStyleBackColor = true;
            this.Refresh_EmployeeEvaluation.Click += new System.EventHandler(this.Refresh_EmployeeEvaluation_Click);
            // 
            // dataGridView7
            // 
            this.dataGridView7.AutoGenerateColumns = false;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn3,
            this.evaluateYearDataGridViewTextBoxColumn,
            this.evaluateResultDataGridViewTextBoxColumn});
            this.dataGridView7.DataSource = this.employeeEvaluationBindingSource;
            this.dataGridView7.Location = new System.Drawing.Point(40, 81);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.RowTemplate.Height = 23;
            this.dataGridView7.Size = new System.Drawing.Size(669, 330);
            this.dataGridView7.TabIndex = 12;
            // 
            // employeeIDDataGridViewTextBoxColumn3
            // 
            this.employeeIDDataGridViewTextBoxColumn3.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn3.HeaderText = "员工信息ID";
            this.employeeIDDataGridViewTextBoxColumn3.Name = "employeeIDDataGridViewTextBoxColumn3";
            // 
            // evaluateYearDataGridViewTextBoxColumn
            // 
            this.evaluateYearDataGridViewTextBoxColumn.DataPropertyName = "EvaluateYear";
            this.evaluateYearDataGridViewTextBoxColumn.HeaderText = "评价年份";
            this.evaluateYearDataGridViewTextBoxColumn.Name = "evaluateYearDataGridViewTextBoxColumn";
            // 
            // evaluateResultDataGridViewTextBoxColumn
            // 
            this.evaluateResultDataGridViewTextBoxColumn.DataPropertyName = "EvaluateResult";
            this.evaluateResultDataGridViewTextBoxColumn.HeaderText = "评价结果";
            this.evaluateResultDataGridViewTextBoxColumn.Name = "evaluateResultDataGridViewTextBoxColumn";
            this.evaluateResultDataGridViewTextBoxColumn.Width = 250;
            // 
            // employeeEvaluationBindingSource
            // 
            this.employeeEvaluationBindingSource.DataMember = "EmployeeEvaluation";
            this.employeeEvaluationBindingSource.DataSource = this.repairCenterDataSet18;
            // 
            // repairCenterDataSet18
            // 
            this.repairCenterDataSet18.DataSetName = "RepairCenterDataSet18";
            this.repairCenterDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Save_EmployeeEvaluation
            // 
            this.Save_EmployeeEvaluation.Location = new System.Drawing.Point(339, 427);
            this.Save_EmployeeEvaluation.Name = "Save_EmployeeEvaluation";
            this.Save_EmployeeEvaluation.Size = new System.Drawing.Size(75, 23);
            this.Save_EmployeeEvaluation.TabIndex = 10;
            this.Save_EmployeeEvaluation.Text = "保存";
            this.Save_EmployeeEvaluation.UseVisualStyleBackColor = true;
            this.Save_EmployeeEvaluation.Click += new System.EventHandler(this.Save_EmployeeEvaluation_Click);
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.panel3);
            this.tabPage9.Controls.Add(this.panel1);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(758, 498);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "离职表";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.button34);
            this.panel3.Controls.Add(this.textBox60);
            this.panel3.Controls.Add(this.label64);
            this.panel3.Location = new System.Drawing.Point(43, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 25);
            this.panel3.TabIndex = 4;
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(193, 0);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(75, 23);
            this.button34.TabIndex = 6;
            this.button34.Text = "查询";
            this.button34.UseVisualStyleBackColor = true;
            // 
            // textBox60
            // 
            this.textBox60.Location = new System.Drawing.Point(64, 2);
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(100, 21);
            this.textBox60.TabIndex = 5;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(5, 8);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(53, 12);
            this.label64.TabIndex = 4;
            this.label64.Text = "离职表ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.textBox58);
            this.panel1.Controls.Add(this.label59);
            this.panel1.Controls.Add(this.textBox57);
            this.panel1.Controls.Add(this.textBox56);
            this.panel1.Controls.Add(this.label62);
            this.panel1.Controls.Add(this.label61);
            this.panel1.Controls.Add(this.label51);
            this.panel1.Controls.Add(this.button26);
            this.panel1.Controls.Add(this.textBox32);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.textBox33);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.textBox34);
            this.panel1.Controls.Add(this.label37);
            this.panel1.Controls.Add(this.textBox35);
            this.panel1.Controls.Add(this.label38);
            this.panel1.Controls.Add(this.textBox36);
            this.panel1.Controls.Add(this.label39);
            this.panel1.Controls.Add(this.textBox37);
            this.panel1.Controls.Add(this.label40);
            this.panel1.Controls.Add(this.textBox38);
            this.panel1.Controls.Add(this.label41);
            this.panel1.Controls.Add(this.textBox39);
            this.panel1.Controls.Add(this.label42);
            this.panel1.Controls.Add(this.textBox40);
            this.panel1.Controls.Add(this.label43);
            this.panel1.Controls.Add(this.textBox41);
            this.panel1.Controls.Add(this.label44);
            this.panel1.Controls.Add(this.textBox42);
            this.panel1.Controls.Add(this.label45);
            this.panel1.Controls.Add(this.textBox43);
            this.panel1.Controls.Add(this.label46);
            this.panel1.Controls.Add(this.textBox44);
            this.panel1.Controls.Add(this.label47);
            this.panel1.Controls.Add(this.textBox45);
            this.panel1.Controls.Add(this.label48);
            this.panel1.Controls.Add(this.textBox46);
            this.panel1.Controls.Add(this.label49);
            this.panel1.Controls.Add(this.textBox47);
            this.panel1.Controls.Add(this.label50);
            this.panel1.Controls.Add(this.textBox48);
            this.panel1.Controls.Add(this.label52);
            this.panel1.Controls.Add(this.textBox49);
            this.panel1.Controls.Add(this.label53);
            this.panel1.Controls.Add(this.textBox50);
            this.panel1.Controls.Add(this.label54);
            this.panel1.Controls.Add(this.textBox51);
            this.panel1.Controls.Add(this.label55);
            this.panel1.Controls.Add(this.textBox52);
            this.panel1.Controls.Add(this.label56);
            this.panel1.Controls.Add(this.textBox53);
            this.panel1.Controls.Add(this.label57);
            this.panel1.Controls.Add(this.textBox54);
            this.panel1.Controls.Add(this.label58);
            this.panel1.Location = new System.Drawing.Point(-4, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 450);
            this.panel1.TabIndex = 0;
            // 
            // textBox58
            // 
            this.textBox58.Location = new System.Drawing.Point(425, 381);
            this.textBox58.Name = "textBox58";
            this.textBox58.Size = new System.Drawing.Size(100, 21);
            this.textBox58.TabIndex = 107;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label59.Location = new System.Drawing.Point(251, 12);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(93, 16);
            this.label59.TabIndex = 52;
            this.label59.Text = "离职审批表";
            // 
            // textBox57
            // 
            this.textBox57.Location = new System.Drawing.Point(168, 381);
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(100, 21);
            this.textBox57.TabIndex = 106;
            // 
            // textBox56
            // 
            this.textBox56.Location = new System.Drawing.Point(371, 346);
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(100, 21);
            this.textBox56.TabIndex = 105;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(296, 384);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(113, 12);
            this.label62.TabIndex = 104;
            this.label62.Text = "本人证实收到计生证";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(11, 384);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(125, 12);
            this.label61.TabIndex = 103;
            this.label61.Text = "本人证实收到最后工资";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(296, 349);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(53, 12);
            this.label51.TabIndex = 102;
            this.label51.Text = "核准日期";
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(108, 421);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(75, 23);
            this.button26.TabIndex = 101;
            this.button26.Text = "保存";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(118, 346);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(65, 21);
            this.textBox32.TabIndex = 100;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(35, 349);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(41, 12);
            this.label35.TabIndex = 99;
            this.label35.Text = "经办人";
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(249, 317);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(100, 21);
            this.textBox33.TabIndex = 98;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(11, 320);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(221, 12);
            this.label36.TabIndex = 97;
            this.label36.Text = "财务人员（按考勤及奖罚情况）核准金额";
            // 
            // textBox34
            // 
            this.textBox34.Location = new System.Drawing.Point(371, 296);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(100, 21);
            this.textBox34.TabIndex = 96;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(299, 299);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(53, 12);
            this.label37.TabIndex = 95;
            this.label37.Text = "应发工资";
            // 
            // textBox35
            // 
            this.textBox35.Location = new System.Drawing.Point(118, 296);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(100, 21);
            this.textBox35.TabIndex = 94;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(11, 299);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(89, 12);
            this.label38.TabIndex = 93;
            this.label38.Text = "扣（补）发工资";
            // 
            // textBox36
            // 
            this.textBox36.Location = new System.Drawing.Point(371, 269);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(100, 21);
            this.textBox36.TabIndex = 92;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(296, 272);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(53, 12);
            this.label39.TabIndex = 91;
            this.label39.Text = "工资标准";
            // 
            // textBox37
            // 
            this.textBox37.Location = new System.Drawing.Point(118, 269);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(100, 21);
            this.textBox37.TabIndex = 90;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(23, 272);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(53, 12);
            this.label40.TabIndex = 89;
            this.label40.Text = "出勤天数";
            // 
            // textBox38
            // 
            this.textBox38.Location = new System.Drawing.Point(371, 244);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(100, 21);
            this.textBox38.TabIndex = 88;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(251, 247);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(101, 12);
            this.label41.TabIndex = 87;
            this.label41.Text = "工资结算结束日期";
            // 
            // textBox39
            // 
            this.textBox39.Location = new System.Drawing.Point(118, 244);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(100, 21);
            this.textBox39.TabIndex = 86;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(11, 247);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(101, 12);
            this.label42.TabIndex = 85;
            this.label42.Text = "工资结算起始日期";
            // 
            // textBox40
            // 
            this.textBox40.Location = new System.Drawing.Point(469, 205);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(137, 21);
            this.textBox40.TabIndex = 84;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(346, 208);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(89, 12);
            this.label43.TabIndex = 83;
            this.label43.Text = "人力资源部日期";
            // 
            // textBox41
            // 
            this.textBox41.Location = new System.Drawing.Point(469, 180);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(137, 21);
            this.textBox41.TabIndex = 82;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(346, 183);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(113, 12);
            this.label44.TabIndex = 81;
            this.label44.Text = "人力资源部意见签字";
            // 
            // textBox42
            // 
            this.textBox42.Location = new System.Drawing.Point(82, 180);
            this.textBox42.Multiline = true;
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(256, 46);
            this.textBox42.TabIndex = 80;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(11, 183);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(65, 24);
            this.label45.TabIndex = 79;
            this.label45.Text = "人力资源部\r\n    意见";
            // 
            // textBox43
            // 
            this.textBox43.Location = new System.Drawing.Point(469, 127);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(137, 21);
            this.textBox43.TabIndex = 78;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(344, 130);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(101, 12);
            this.label46.TabIndex = 77;
            this.label46.Text = "单位意见领导签字";
            // 
            // textBox44
            // 
            this.textBox44.Location = new System.Drawing.Point(82, 127);
            this.textBox44.Multiline = true;
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(256, 46);
            this.textBox44.TabIndex = 76;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(23, 130);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(53, 12);
            this.label47.TabIndex = 75;
            this.label47.Text = "单位意见";
            // 
            // textBox45
            // 
            this.textBox45.Location = new System.Drawing.Point(469, 152);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(137, 21);
            this.textBox45.TabIndex = 74;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(344, 155);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(77, 12);
            this.label48.TabIndex = 73;
            this.label48.Text = "单位意见日期";
            // 
            // textBox46
            // 
            this.textBox46.Location = new System.Drawing.Point(559, 98);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(111, 21);
            this.textBox46.TabIndex = 72;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(500, 101);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(53, 12);
            this.label49.TabIndex = 71;
            this.label49.Text = "离职原因";
            // 
            // textBox47
            // 
            this.textBox47.Location = new System.Drawing.Point(405, 98);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(89, 21);
            this.textBox47.TabIndex = 70;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(345, 101);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(53, 12);
            this.label50.TabIndex = 69;
            this.label50.Text = "离职日期";
            // 
            // textBox48
            // 
            this.textBox48.Location = new System.Drawing.Point(81, 98);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(101, 21);
            this.textBox48.TabIndex = 66;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(23, 101);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(53, 12);
            this.label52.TabIndex = 65;
            this.label52.Text = "基层单位";
            // 
            // textBox49
            // 
            this.textBox49.Location = new System.Drawing.Point(405, 71);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(91, 21);
            this.textBox49.TabIndex = 64;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(346, 74);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(53, 12);
            this.label53.TabIndex = 63;
            this.label53.Text = "入职时间";
            // 
            // textBox50
            // 
            this.textBox50.Location = new System.Drawing.Point(238, 98);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(100, 21);
            this.textBox50.TabIndex = 62;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(203, 101);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(29, 12);
            this.label54.TabIndex = 61;
            this.label54.Text = "岗位";
            // 
            // textBox51
            // 
            this.textBox51.Location = new System.Drawing.Point(531, 35);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(114, 21);
            this.textBox51.TabIndex = 60;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(467, 41);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(53, 12);
            this.label55.TabIndex = 59;
            this.label55.Text = "填表日期";
            // 
            // textBox52
            // 
            this.textBox52.Location = new System.Drawing.Point(241, 71);
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(47, 21);
            this.textBox52.TabIndex = 58;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(206, 74);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(29, 12);
            this.label56.TabIndex = 57;
            this.label56.Text = "性别";
            // 
            // textBox53
            // 
            this.textBox53.Location = new System.Drawing.Point(82, 71);
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(100, 21);
            this.textBox53.TabIndex = 56;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(46, 74);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(29, 12);
            this.label57.TabIndex = 55;
            this.label57.Text = "姓名";
            // 
            // textBox54
            // 
            this.textBox54.Location = new System.Drawing.Point(82, 38);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(100, 21);
            this.textBox54.TabIndex = 54;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(11, 41);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(53, 12);
            this.label58.TabIndex = 53;
            this.label58.Text = "离职表ID";
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.bindingNavigator6);
            this.tabPage10.Controls.Add(this.离职交接查询ToolStrip);
            this.tabPage10.Controls.Add(this.Refresh_ResignationHandover);
            this.tabPage10.Controls.Add(this.dataGridView8);
            this.tabPage10.Controls.Add(this.Save_ResignationHandover);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(758, 498);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "离职交接";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator6
            // 
            this.bindingNavigator6.AddNewItem = this.bindingNavigatorAddNewItem5;
            this.bindingNavigator6.CountItem = this.bindingNavigatorCountItem5;
            this.bindingNavigator6.DeleteItem = this.bindingNavigatorDeleteItem5;
            this.bindingNavigator6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem5,
            this.bindingNavigatorMovePreviousItem5,
            this.bindingNavigatorSeparator15,
            this.bindingNavigatorPositionItem5,
            this.bindingNavigatorCountItem5,
            this.bindingNavigatorSeparator16,
            this.bindingNavigatorMoveNextItem5,
            this.bindingNavigatorMoveLastItem5,
            this.bindingNavigatorSeparator17,
            this.bindingNavigatorAddNewItem5,
            this.bindingNavigatorDeleteItem5});
            this.bindingNavigator6.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator6.MoveFirstItem = this.bindingNavigatorMoveFirstItem5;
            this.bindingNavigator6.MoveLastItem = this.bindingNavigatorMoveLastItem5;
            this.bindingNavigator6.MoveNextItem = this.bindingNavigatorMoveNextItem5;
            this.bindingNavigator6.MovePreviousItem = this.bindingNavigatorMovePreviousItem5;
            this.bindingNavigator6.Name = "bindingNavigator6";
            this.bindingNavigator6.PositionItem = this.bindingNavigatorPositionItem5;
            this.bindingNavigator6.Size = new System.Drawing.Size(752, 25);
            this.bindingNavigator6.TabIndex = 17;
            this.bindingNavigator6.Text = "bindingNavigator6";
            // 
            // bindingNavigatorAddNewItem5
            // 
            this.bindingNavigatorAddNewItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem5.Image")));
            this.bindingNavigatorAddNewItem5.Name = "bindingNavigatorAddNewItem5";
            this.bindingNavigatorAddNewItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem5.Text = "新添";
            // 
            // bindingNavigatorCountItem5
            // 
            this.bindingNavigatorCountItem5.Name = "bindingNavigatorCountItem5";
            this.bindingNavigatorCountItem5.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem5.Text = "/ {0}";
            this.bindingNavigatorCountItem5.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem5
            // 
            this.bindingNavigatorDeleteItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem5.Image")));
            this.bindingNavigatorDeleteItem5.Name = "bindingNavigatorDeleteItem5";
            this.bindingNavigatorDeleteItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem5.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem5
            // 
            this.bindingNavigatorMoveFirstItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem5.Image")));
            this.bindingNavigatorMoveFirstItem5.Name = "bindingNavigatorMoveFirstItem5";
            this.bindingNavigatorMoveFirstItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem5.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem5
            // 
            this.bindingNavigatorMovePreviousItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem5.Image")));
            this.bindingNavigatorMovePreviousItem5.Name = "bindingNavigatorMovePreviousItem5";
            this.bindingNavigatorMovePreviousItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem5.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator15
            // 
            this.bindingNavigatorSeparator15.Name = "bindingNavigatorSeparator15";
            this.bindingNavigatorSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem5
            // 
            this.bindingNavigatorPositionItem5.AccessibleName = "位置";
            this.bindingNavigatorPositionItem5.AutoSize = false;
            this.bindingNavigatorPositionItem5.Name = "bindingNavigatorPositionItem5";
            this.bindingNavigatorPositionItem5.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem5.Text = "0";
            this.bindingNavigatorPositionItem5.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator16
            // 
            this.bindingNavigatorSeparator16.Name = "bindingNavigatorSeparator16";
            this.bindingNavigatorSeparator16.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem5
            // 
            this.bindingNavigatorMoveNextItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem5.Image")));
            this.bindingNavigatorMoveNextItem5.Name = "bindingNavigatorMoveNextItem5";
            this.bindingNavigatorMoveNextItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem5.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem5
            // 
            this.bindingNavigatorMoveLastItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem5.Image")));
            this.bindingNavigatorMoveLastItem5.Name = "bindingNavigatorMoveLastItem5";
            this.bindingNavigatorMoveLastItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem5.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator17
            // 
            this.bindingNavigatorSeparator17.Name = "bindingNavigatorSeparator17";
            this.bindingNavigatorSeparator17.Size = new System.Drawing.Size(6, 25);
            // 
            // 离职交接查询ToolStrip
            // 
            this.离职交接查询ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.离职交接查询ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.离职表IDToolStripLabel,
            this.离职表IDToolStripTextBox,
            this.离职交接查询ToolStripButton});
            this.离职交接查询ToolStrip.Location = new System.Drawing.Point(55, 42);
            this.离职交接查询ToolStrip.Name = "离职交接查询ToolStrip";
            this.离职交接查询ToolStrip.Size = new System.Drawing.Size(258, 25);
            this.离职交接查询ToolStrip.TabIndex = 2;
            this.离职交接查询ToolStrip.Text = "离职交接查询ToolStrip";
            // 
            // 离职表IDToolStripLabel
            // 
            this.离职表IDToolStripLabel.Name = "离职表IDToolStripLabel";
            this.离职表IDToolStripLabel.Size = new System.Drawing.Size(60, 22);
            this.离职表IDToolStripLabel.Text = "离职表ID:";
            // 
            // 离职表IDToolStripTextBox
            // 
            this.离职表IDToolStripTextBox.Name = "离职表IDToolStripTextBox";
            this.离职表IDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // 离职交接查询ToolStripButton
            // 
            this.离职交接查询ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.离职交接查询ToolStripButton.Name = "离职交接查询ToolStripButton";
            this.离职交接查询ToolStripButton.Size = new System.Drawing.Size(84, 22);
            this.离职交接查询ToolStripButton.Text = "离职交接查询";
            this.离职交接查询ToolStripButton.Click += new System.EventHandler(this.离职交接查询ToolStripButton_Click);
            // 
            // Refresh_ResignationHandover
            // 
            this.Refresh_ResignationHandover.Location = new System.Drawing.Point(523, 426);
            this.Refresh_ResignationHandover.Name = "Refresh_ResignationHandover";
            this.Refresh_ResignationHandover.Size = new System.Drawing.Size(75, 23);
            this.Refresh_ResignationHandover.TabIndex = 16;
            this.Refresh_ResignationHandover.Text = "刷新";
            this.Refresh_ResignationHandover.UseVisualStyleBackColor = true;
            this.Refresh_ResignationHandover.Click += new System.EventHandler(this.Refresh_ResignationHandover_Click);
            // 
            // dataGridView8
            // 
            this.dataGridView8.AutoGenerateColumns = false;
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resignationIDDataGridViewTextBoxColumn,
            this.handoverContentDataGridViewTextBoxColumn,
            this.receiverDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn1,
            this.remarkDataGridViewTextBoxColumn});
            this.dataGridView8.DataSource = this.resignationHandoverBindingSource;
            this.dataGridView8.Location = new System.Drawing.Point(55, 69);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.RowTemplate.Height = 23;
            this.dataGridView8.Size = new System.Drawing.Size(638, 330);
            this.dataGridView8.TabIndex = 12;
            // 
            // resignationIDDataGridViewTextBoxColumn
            // 
            this.resignationIDDataGridViewTextBoxColumn.DataPropertyName = "ResignationID";
            this.resignationIDDataGridViewTextBoxColumn.HeaderText = "离职表ID";
            this.resignationIDDataGridViewTextBoxColumn.Name = "resignationIDDataGridViewTextBoxColumn";
            // 
            // handoverContentDataGridViewTextBoxColumn
            // 
            this.handoverContentDataGridViewTextBoxColumn.DataPropertyName = "HandoverContent";
            this.handoverContentDataGridViewTextBoxColumn.HeaderText = "交接项目";
            this.handoverContentDataGridViewTextBoxColumn.Name = "handoverContentDataGridViewTextBoxColumn";
            // 
            // receiverDataGridViewTextBoxColumn
            // 
            this.receiverDataGridViewTextBoxColumn.DataPropertyName = "Receiver";
            this.receiverDataGridViewTextBoxColumn.HeaderText = "签收人";
            this.receiverDataGridViewTextBoxColumn.Name = "receiverDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "日期";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "备注";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.Width = 150;
            // 
            // resignationHandoverBindingSource
            // 
            this.resignationHandoverBindingSource.DataMember = "ResignationHandover";
            this.resignationHandoverBindingSource.DataSource = this.repairCenterDataSet19;
            // 
            // repairCenterDataSet19
            // 
            this.repairCenterDataSet19.DataSetName = "RepairCenterDataSet19";
            this.repairCenterDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Save_ResignationHandover
            // 
            this.Save_ResignationHandover.Location = new System.Drawing.Point(366, 426);
            this.Save_ResignationHandover.Name = "Save_ResignationHandover";
            this.Save_ResignationHandover.Size = new System.Drawing.Size(75, 23);
            this.Save_ResignationHandover.TabIndex = 10;
            this.Save_ResignationHandover.Text = "保存";
            this.Save_ResignationHandover.UseVisualStyleBackColor = true;
            this.Save_ResignationHandover.Click += new System.EventHandler(this.Save_ResignationHandover_Click);
            // 
            // entryApplicationBindingSource1
            // 
            this.entryApplicationBindingSource1.DataMember = "EntryApplication";
            this.entryApplicationBindingSource1.DataSource = this.repairCenterDataSet;
            // 
            // repairCenterDataSet
            // 
            this.repairCenterDataSet.DataSetName = "RepairCenterDataSet";
            this.repairCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entryApplicationBindingSource
            // 
            this.entryApplicationBindingSource.DataMember = "EntryApplication";
            this.entryApplicationBindingSource.DataSource = this.repairCenterDataSet;
            // 
            // entryApplicationLearningInformationTableAdapter
            // 
            this.entryApplicationLearningInformationTableAdapter.ClearBeforeFill = true;
            // 
            // employmentLearningInformationTableAdapter
            // 
            this.employmentLearningInformationTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTrainInformationTableAdapter
            // 
            this.employeeTrainInformationTableAdapter.ClearBeforeFill = true;
            // 
            // employeeFamilyInformationTableAdapter
            // 
            this.employeeFamilyInformationTableAdapter.ClearBeforeFill = true;
            // 
            // checkAttendanceTableAdapter
            // 
            this.checkAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // employeeEvaluationTableAdapter
            // 
            this.employeeEvaluationTableAdapter.ClearBeforeFill = true;
            // 
            // resignationHandoverTableAdapter
            // 
            this.resignationHandoverTableAdapter.ClearBeforeFill = true;
            // 
            // entryApplicationTableAdapter
            // 
            this.entryApplicationTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator7
            // 
            this.bindingNavigator7.AddNewItem = this.toolStripButton1;
            this.bindingNavigator7.CountItem = this.toolStripLabel1;
            this.bindingNavigator7.DeleteItem = this.toolStripButton2;
            this.bindingNavigator7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2});
            this.bindingNavigator7.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator7.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator7.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator7.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator7.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator7.Name = "bindingNavigator7";
            this.bindingNavigator7.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator7.Size = new System.Drawing.Size(752, 25);
            this.bindingNavigator7.TabIndex = 12;
            this.bindingNavigator7.Text = "bindingNavigator7";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "新添";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "/ {0}";
            this.toolStripLabel1.ToolTipText = "总项数";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "删除";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "移到第一条记录";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "移到上一条记录";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "位置";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "当前位置";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "移到下一条记录";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "移到最后一条记录";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // HRManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 524);
            this.Controls.Add(this.splitContainer1);
            this.Name = "HRManagement";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entryApplicationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.查询ToolStrip.ResumeLayout(false);
            this.查询ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryApplicationLearningInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet13)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.员工学习信息查询ToolStrip.ResumeLayout(false);
            this.员工学习信息查询ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employmentLearningInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet14)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.员工培训信息查询ToolStrip.ResumeLayout(false);
            this.员工培训信息查询ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTrainInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet15)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            this.员工家庭信息查询ToolStrip.ResumeLayout(false);
            this.员工家庭信息查询ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeFamilyInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet16)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).EndInit();
            this.bindingNavigator4.ResumeLayout(false);
            this.bindingNavigator4.PerformLayout();
            this.考勤信息查询ToolStrip.ResumeLayout(false);
            this.考勤信息查询ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet17)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).EndInit();
            this.bindingNavigator5.ResumeLayout(false);
            this.bindingNavigator5.PerformLayout();
            this.员工评价信息查询ToolStrip.ResumeLayout(false);
            this.员工评价信息查询ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeEvaluationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet18)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator6)).EndInit();
            this.bindingNavigator6.ResumeLayout(false);
            this.bindingNavigator6.PerformLayout();
            this.离职交接查询ToolStrip.ResumeLayout(false);
            this.离职交接查询ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resignationHandoverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryApplicationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairCenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryApplicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator7)).EndInit();
            this.bindingNavigator7.ResumeLayout(false);
            this.bindingNavigator7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TBSpecialty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBCertificate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBTechnicalTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBResignationTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBCurrentAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBIDNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBHouseholdRegisterLocation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TBBirthControlCertificateNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TBPoliticalLandscape;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TBMonth;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TBYear;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TBHometown;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox TBNation;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox TBEntryApplicationID;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button Save_EmployeeLearning;
        private System.Windows.Forms.Button Save_EmployeeTrainIn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button Save_EmployeeFamily;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.Button Save_CheckAttendance;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.Button Save_EmployeeEvaluation;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBox37;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox textBox39;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox textBox40;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox textBox42;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox textBox43;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox textBox44;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox textBox45;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox textBox46;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox textBox47;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox textBox48;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox textBox49;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox textBox50;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox textBox51;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox textBox52;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox textBox53;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox textBox54;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.Button Save_ResignationHandover;
        private System.Windows.Forms.TextBox textBox58;
        private System.Windows.Forms.TextBox textBox57;
        private System.Windows.Forms.TextBox textBox56;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Button Refresh_EmployeeLearning;
        private System.Windows.Forms.Button Refresh_EmployeeTrainIn;
        private System.Windows.Forms.Button Refresh_EmployeeFamily;
        private System.Windows.Forms.Button Refresh_CheckAttendance;
        private System.Windows.Forms.Button Refresh_EmployeeEvaluation;
        private System.Windows.Forms.Button Refresh_ResignationHandover;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Query_EntryApplication;
        private System.Windows.Forms.TextBox EntryApplicationID;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.TextBox textBox60;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox TBCraft;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Button Refresh_EntryApplication;
        private RepairCenterDataSet13 repairCenterDataSet13;
        private System.Windows.Forms.BindingSource entryApplicationLearningInformationBindingSource;
        private RepairCenterDataSet13TableAdapters.EntryApplicationLearningInformationTableAdapter entryApplicationLearningInformationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryApplicationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn craftOrPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip 查询ToolStrip;
        private System.Windows.Forms.ToolStripLabel 入职申请IDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox 入职申请IDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton 查询ToolStripButton;
        private RepairCenterDataSet14 repairCenterDataSet14;
        private System.Windows.Forms.BindingSource employmentLearningInformationBindingSource;
        private RepairCenterDataSet14TableAdapters.EmploymentLearningInformationTableAdapter employmentLearningInformationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employmenIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn craftOrPositionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStrip 员工学习信息查询ToolStrip;
        private System.Windows.Forms.ToolStripLabel 员工信息IDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox 员工信息IDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton 员工学习信息查询ToolStripButton;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private RepairCenterDataSet15 repairCenterDataSet15;
        private System.Windows.Forms.BindingSource employeeTrainInformationBindingSource;
        private RepairCenterDataSet15TableAdapters.EmployeeTrainInformationTableAdapter employeeTrainInformationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainEffectDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip 员工培训信息查询ToolStrip;
        private System.Windows.Forms.ToolStripLabel 员工信息IDToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox 员工信息IDToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton 员工培训信息查询ToolStripButton;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private RepairCenterDataSet16 repairCenterDataSet16;
        private System.Windows.Forms.BindingSource employeeFamilyInformationBindingSource;
        private RepairCenterDataSet16TableAdapters.EmployeeFamilyInformationTableAdapter employeeFamilyInformationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appellationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentDepartmentAndPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn politicalLandscapeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip 员工家庭信息查询ToolStrip;
        private System.Windows.Forms.ToolStripLabel 员工信息IDToolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox 员工信息IDToolStripTextBox2;
        private System.Windows.Forms.ToolStripButton 员工家庭信息查询ToolStripButton;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private RepairCenterDataSet17 repairCenterDataSet17;
        private System.Windows.Forms.BindingSource checkAttendanceBindingSource;
        private RepairCenterDataSet17TableAdapters.CheckAttendanceTableAdapter checkAttendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkResultDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip 考勤信息查询ToolStrip;
        private System.Windows.Forms.ToolStripLabel 员工信息IDToolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox 员工信息IDToolStripTextBox3;
        private System.Windows.Forms.ToolStripButton 考勤信息查询ToolStripButton;
        private System.Windows.Forms.BindingNavigator bindingNavigator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem3;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator9;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator10;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator11;
        private RepairCenterDataSet18 repairCenterDataSet18;
        private System.Windows.Forms.BindingSource employeeEvaluationBindingSource;
        private RepairCenterDataSet18TableAdapters.EmployeeEvaluationTableAdapter employeeEvaluationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluateYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluateResultDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip 员工评价信息查询ToolStrip;
        private System.Windows.Forms.ToolStripLabel 员工信息IDToolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox 员工信息IDToolStripTextBox4;
        private System.Windows.Forms.ToolStripButton 员工评价信息查询ToolStripButton;
        private System.Windows.Forms.BindingNavigator bindingNavigator5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem4;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator12;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator13;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator14;
        private RepairCenterDataSet19 repairCenterDataSet19;
        private System.Windows.Forms.BindingSource resignationHandoverBindingSource;
        private RepairCenterDataSet19TableAdapters.ResignationHandoverTableAdapter resignationHandoverTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn resignationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handoverContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip 离职交接查询ToolStrip;
        private System.Windows.Forms.ToolStripLabel 离职表IDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox 离职表IDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton 离职交接查询ToolStripButton;
        private System.Windows.Forms.BindingNavigator bindingNavigator6;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem5;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator15;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator16;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator17;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Clear_EntryApplication;
        private System.Windows.Forms.Button Delete_EntryApplication;
        private System.Windows.Forms.Button Save_EntryApplication;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Edit_EntryApplication;
        private System.Windows.Forms.Button Add_EntryApplication;
        private System.Windows.Forms.Button QueryLearningDetail_EntryApplication;
        private System.Windows.Forms.TextBox TBUserID;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox CBSex;
        private System.Windows.Forms.ComboBox CBEducationBackground;
        private RepairCenterDataSet repairCenterDataSet;
        private System.Windows.Forms.BindingSource entryApplicationBindingSource;
        private RepairCenterDataSetTableAdapters.EntryApplicationTableAdapter entryApplicationTableAdapter;
        private System.Windows.Forms.BindingSource entryApplicationBindingSource1;
        private RepairCenterDataSet repairCenterDataSet1;
        private System.Windows.Forms.BindingSource entryApplicationBindingSource2;
        private System.Windows.Forms.ComboBox CBMaritalStatus;
        private System.Windows.Forms.ComboBox CBHouseholdRegisterType;
        private System.Windows.Forms.ComboBox CBIsOutGoingEmploymentCard;
        private System.Windows.Forms.TextBox TBArrivalTime;
        private System.Windows.Forms.Button QueryDetail_Employee;
        private System.Windows.Forms.Button Add_Employee;
        private System.Windows.Forms.Button Edit_Employee;
        private System.Windows.Forms.Button Clear_Employee;
        private System.Windows.Forms.Button Delete_Employee;
        private System.Windows.Forms.Button Save_Employee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Query_Employee;
        private System.Windows.Forms.TextBox EmployeeID;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TBArrivalTime2;
        private System.Windows.Forms.ComboBox CBIsOutGoingEmploymentCard2;
        private System.Windows.Forms.ComboBox CBMaritalStatus2;
        private System.Windows.Forms.ComboBox CBHouseholdRegisterType2;
        private System.Windows.Forms.ComboBox CBEducationBackground2;
        private System.Windows.Forms.ComboBox CBSex2;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.TextBox TBCraft2;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.TextBox TBSpecialty2;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.TextBox TBCertificate2;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.TextBox TBTechnicalTitle2;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.TextBox TBResignationTime2;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.TextBox TBPosition2;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.TextBox TBPhone2;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.TextBox TBCurrentAddress2;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.TextBox TBIDNumber2;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.TextBox TBHouseholdRegisterLocation2;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.TextBox TBBirthControlCertificateNumber2;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.TextBox TBPoliticalLandscape2;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.TextBox TBMonth2;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.TextBox TBYear2;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.TextBox TBHometown2;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.TextBox TBNation2;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.TextBox TBName2;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.TextBox TBEmployeeID2;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.ComboBox QueryDetailText_Employee;
        private System.Windows.Forms.Button Save2_EntryApplication;
        private System.Windows.Forms.BindingNavigator bindingNavigator7;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}