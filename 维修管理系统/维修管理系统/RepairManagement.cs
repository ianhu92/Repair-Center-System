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
    public partial class RepairManagement : Form
    {
        public RepairManagement()
        {
            InitializeComponent();
        }
        //基础按钮事件
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OpenMaterialQuery_Click(object sender, EventArgs e)
        {
            MaterialQuery materialQuery = new MaterialQuery();
            materialQuery.ShowDialog();
        }
        private void OpenEmployeeQuery_Click(object sender, EventArgs e)
        {
            EmployeeQuery employeeQuery = new EmployeeQuery();
            employeeQuery.ShowDialog();
        }
        private void OpenSuppilerQuery_Click(object sender, EventArgs e)
        {
            SupplierQuery supplierQuery = new SupplierQuery();
            supplierQuery.ShowDialog();
        }
        //基础数据库操作定义
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommandBuilder cb = new SqlCommandBuilder();
        SqlCommand cmd = new SqlCommand();
        private string sql = "select * from RepairApplication";

        DataSet ds2 = new DataSet();
        SqlDataAdapter da2 = new SqlDataAdapter();
        SqlCommandBuilder cb2 = new SqlCommandBuilder();
        SqlCommand cmd2 = new SqlCommand();
        string sql2 = "select * from Dispatch";

        DataSet ds3 = new DataSet();
        SqlDataAdapter da3 = new SqlDataAdapter();
        SqlCommandBuilder cb3 = new SqlCommandBuilder();
        SqlCommand cmd3 = new SqlCommand();
        string sql3 = "select * from DispatchMaterial";

        DataSet ds4 = new DataSet();
        SqlDataAdapter da4 = new SqlDataAdapter();
        SqlCommandBuilder cb4 = new SqlCommandBuilder();
        SqlCommand cmd4 = new SqlCommand();
        string sql4 = "select * from DispatchMaterialDetail";

        DataSet ds5 = new DataSet();
        SqlDataAdapter da5 = new SqlDataAdapter();
        SqlCommandBuilder cb5 = new SqlCommandBuilder();
        SqlCommand cmd5 = new SqlCommand();
        string sql5 = "select * from DispatchReceipt";

        DataSet ds6 = new DataSet();
        SqlDataAdapter da6 = new SqlDataAdapter();
        SqlCommandBuilder cb6 = new SqlCommandBuilder();
        SqlCommand cmd6 = new SqlCommand();
        string sql6 = "select * from OutsourceApplication";

        DataSet ds7 = new DataSet();
        SqlDataAdapter da7 = new SqlDataAdapter();
        SqlCommandBuilder cb7 = new SqlCommandBuilder();
        SqlCommand cmd7 = new SqlCommand();
        string sql7 = "select * from Outsource";
        //基础数据库字符串和全局变量定义
        private string connString = "Data Source=IAN-PC\\Ian;Initial Catalog=RepairCenter;Persist Security Info=True;User ID=sa;Password=sa";
        int ButtonClicked = 0;
        int RepairApplicationiD = 0; int DispatchiD = 0;
        int DispatchMaterialiD = 0; int OutsourceApplicationiD = 0;
        
        //Load事件
        private void RepairManagement_Load(object sender, EventArgs e)
        {
            refreshDataGridView1();
            if (MaterialManagerment.StockOutFlag == 1)
            {
                tabControl1.SelectedTab = tabPage2;
                RepairApplicationID.Text = "0";
                Query_Dispatch_Click(sender,e);
                dataGridView2.Columns[0].Visible = true;
            }
        }

        //各个DataGridView的refresh事件
        private void refreshDataGridView1()
        {
            ds.Clear();
            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "申请人ID";
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].HeaderText = "电话";
            dataGridView1.Columns[3].HeaderText = "片区";
            dataGridView1.Columns[4].HeaderText = "楼栋";
            dataGridView1.Columns[5].HeaderText = "房间号";
            dataGridView1.Columns[6].HeaderText = "申请原因";
            dataGridView1.Columns[7].HeaderText = "日期";
            dataGridView1.Columns[7].ReadOnly = true;
            dataGridView1.Columns[8].HeaderText = "状态";
        }
        private void refreshDataGridView2()
        {
            ds2.Clear();
            sql2 = "select * from Dispatch where RepairApplicationID='" + RepairApplicationiD + "'";
            if (RepairApplicationiD == 0)
            {
                sql2 = "select * from Dispatch";
            }
            SqlConnection conn2 = new SqlConnection(connString);
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn2);
            da2.Fill(ds2);
            dataGridView2.DataSource = ds2.Tables[0];
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[0].HeaderText = "派工单ID";
            dataGridView2.Columns[0].ReadOnly = true;
            dataGridView2.Columns[1].HeaderText = "维修申请ID";
            dataGridView2.Columns[1].ReadOnly = true;
            dataGridView2.Columns[2].HeaderText = "维修项目";
            dataGridView2.Columns[3].HeaderText = "维修员ID";
            dataGridView2.Columns[4].HeaderText = "调度员ID";
            dataGridView2.Columns[5].HeaderText = "派工时间";
            dataGridView2.Columns[5].ReadOnly = true;
            dataGridView2.Columns[6].HeaderText = "维修总金额";
            dataGridView2.Columns[7].HeaderText = "状态";
        }
        private void refreshDataGridView3()
        {
            ds3.Clear();
            sql3 = "select * from DispatchMaterial where DispatchID='" + DispatchiD + "'";
            if (DispatchiD == 0)
            {
                sql3 = "select * from DispatchMaterial";
            }
            SqlConnection conn3 = new SqlConnection(connString);
            SqlDataAdapter da3 = new SqlDataAdapter(sql3, conn3);
            da3.Fill(ds3);
            dataGridView3.DataSource = ds3.Tables[0];
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Columns[1].HeaderText = "派工单ID";
            dataGridView3.Columns[1].ReadOnly = true;
            dataGridView3.Columns[2].HeaderText = "领用时间";
            dataGridView3.Columns[3].HeaderText = "使用班组";
            dataGridView3.Columns[4].HeaderText = "用途";
            dataGridView3.Columns[5].HeaderText = "工程用途";
            dataGridView3.Columns[6].HeaderText = "领料人ID";
        }
        private void refreshDataGridView4()
        {
            ds4.Clear();
            sql4 = "select * from DispatchMaterialDetail where DispatchMaterialID='" + DispatchMaterialiD + "'";
            if (DispatchMaterialiD == 0)
            {
                sql4 = "select * from DispatchMaterialDetail";
            }
            SqlConnection conn4 = new SqlConnection(connString);
            SqlDataAdapter da4 = new SqlDataAdapter(sql4, conn4);
            da4.Fill(ds4);
            dataGridView4.DataSource = ds4.Tables[0];
            dataGridView4.Columns[0].Visible = false;
            dataGridView4.Columns[1].HeaderText = "派工物资单ID";
            dataGridView4.Columns[1].ReadOnly = true;
            dataGridView4.Columns[2].HeaderText = "物料ID";
            dataGridView4.Columns[3].HeaderText = "申请数量";
        }
        private void refreshDataGridView5()
        {
            ds5.Clear();
            sql5 = "select * from DispatchReceipt where DispatchID='" + DispatchiD + "'";
            if (DispatchiD == 0)
            {
                sql5 = "select * from DispatchReceipt";
            }
            SqlConnection conn5 = new SqlConnection(connString);
            SqlDataAdapter da5 = new SqlDataAdapter(sql5, conn5);
            da5.Fill(ds5);
            dataGridView5.DataSource = ds5.Tables[0];
            dataGridView5.Columns[0].Visible = false;
            dataGridView5.Columns[1].HeaderText = "派工单ID";
            dataGridView5.Columns[1].ReadOnly = true;
            dataGridView5.Columns[2].HeaderText = "完成时间";
            dataGridView5.Columns[3].HeaderText = "完成质量";
            dataGridView5.Columns[4].HeaderText = "其他";
            dataGridView5.Columns[5].HeaderText = "客户姓名";
        }
        private void refreshDataGridView6()
        {
            ds6.Clear();
            sql6 = "select * from OutsourceApplication where RepairApplicationID='" + RepairApplicationiD + "'";
            if (RepairApplicationiD == 0)
            {
                sql3 = "select * from OutsourceApplication";
            }
            SqlConnection conn6 = new SqlConnection(connString);
            SqlDataAdapter da6 = new SqlDataAdapter(sql6, conn6);
            da6.Fill(ds6);
            dataGridView6.DataSource = ds6.Tables[0];
            //dataGridView6.Columns[0].HeaderText = "物料ID";
            dataGridView6.Columns[0].Visible = false;
            dataGridView6.Columns[1].HeaderText = "维修申请ID";
            dataGridView6.Columns[1].ReadOnly = true;
            dataGridView6.Columns[2].HeaderText = "对外委托申请类型";
            dataGridView6.Columns[1].ReadOnly = true;
            dataGridView6.Columns[3].HeaderText = "申请时间";
            dataGridView6.Columns[1].ReadOnly = true;
            dataGridView6.Columns[4].HeaderText = "申请内容";
            dataGridView6.Columns[5].HeaderText = "状态";
        }
        private void refreshDataGridView7()
        {
            ds7.Clear();
            sql7 = "select * from Outsource where OutsourceApplicationID='" + OutsourceApplicationiD + "'";
            if (OutsourceApplicationiD == 0)
            {
                sql3 = "select * from Outsource";
            }
            SqlConnection conn7 = new SqlConnection(connString);
            SqlDataAdapter da7 = new SqlDataAdapter(sql7, conn7);
            da7.Fill(ds7);
            dataGridView7.DataSource = ds7.Tables[0];
            //dataGridView7.Columns[0].HeaderText = "报废单ID";
            dataGridView7.Columns[0].Visible = false;
            dataGridView7.Columns[1].HeaderText = "对外委托申请ID";
            dataGridView7.Columns[1].ReadOnly = true;
            dataGridView7.Columns[2].HeaderText = "委托类型";
            dataGridView7.Columns[3].HeaderText = "开始时间";
            dataGridView7.Columns[1].ReadOnly = true;
            dataGridView7.Columns[4].HeaderText = "完成时间";
            dataGridView7.Columns[5].HeaderText = "承包方";
            dataGridView7.Columns[6].HeaderText = "委托内容";
            dataGridView7.Columns[7].HeaderText = "总价";
            dataGridView7.Columns[8].HeaderText = "状态";
        }
        
        //各个DataGridView的默认值设置
        private void dataGridView1_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells[1].Value = Form1.userIDString;
            e.Row.Cells[7].Value = System.DateTime.Now.Date;
            e.Row.Cells[8].Value = "未受理";
        }
        private void dataGridView2_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells[1].Value = RepairApplicationiD;
            e.Row.Cells[5].Value = System.DateTime.Now;
            e.Row.Cells[7].Value = "未处理";
        }
        private void dataGridView3_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells[1].Value = DispatchiD;
        }
        private void dataGridView4_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells[1].Value = DispatchMaterialiD;
        }
        private void dataGridView5_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells[1].Value = DispatchiD;
        }
        private void dataGridView6_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells[1].Value = RepairApplicationiD;
            e.Row.Cells[2].Value = "小";
            e.Row.Cells[3].Value = System.DateTime.Now;
            e.Row.Cells[5].Value = "未通过";
        }
        private void dataGridView7_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells[1].Value = OutsourceApplicationiD;
            e.Row.Cells[3].Value = System.DateTime.Now;
            e.Row.Cells[8].Value = "未完成";
        }
        
        //RepairApplication页的按钮设置
        private void Save_RepairApplication_Click(object sender, EventArgs e)
        {
            if (ButtonClicked == 0 && MessageBox.Show("确认修改维修申请单？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
                || ButtonClicked == 1)
            {
                SqlConnection conn = new SqlConnection(connString);
                cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                try
                {
                    da.Update(ds);

                    if (ButtonClicked == 0)
                    {
                        MessageBox.Show("保存成功");
                    }
                    else
                    {
                        MessageBox.Show("删除成功");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                dataGridView1.Update();
                refreshDataGridView1();
                ButtonClicked = 0;
            }
        }
        private void Delete__RepairApplication_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确认删除此维修申请单？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                        dataGridView1.Rows.Remove(dataGridView1.SelectedRows[i]);
                    ButtonClicked = 1;
                    Save_RepairApplication_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }
        private void QueryDispatch_RepairApplication_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0 && int.TryParse(dataGridView1.SelectedCells[0].Value.ToString(), out RepairApplicationiD))
            {
                RepairApplicationID.Text = RepairApplicationiD.ToString();
                tabControl1.SelectedTab = tabPage2;
                Query_Dispatch_Click(sender, e);
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }
        private void QueryOutsourceApplication_RepairApplication_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0 && int.TryParse(dataGridView1.SelectedCells[0].Value.ToString(), out RepairApplicationiD))
            {
                RepairApplicationID2.Text = RepairApplicationiD.ToString();
                tabControl1.SelectedTab = tabPage5;
                Query_OutsourceApplication_Click(sender, e);
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }

        //Dispatch页按钮设置
        private void Query_Dispatch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(RepairApplicationID.Text, out RepairApplicationiD))
            {
                refreshDataGridView2();
            }
            else
            {
                MessageBox.Show("请输入数字");
            }
        }
        private void Save_Dispatch_Click(object sender, EventArgs e)
        {
            if (ButtonClicked == 0 && MessageBox.Show("确认修改派工单？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
                || ButtonClicked == 1)
            {
                SqlConnection conn2 = new SqlConnection(connString);
                cmd2 = conn2.CreateCommand();
                cmd2.CommandText = sql2;
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                SqlCommandBuilder cb2 = new SqlCommandBuilder(da2);
                try
                {
                    da2.Update(ds2);

                    if (ButtonClicked == 0)
                    {
                        MessageBox.Show("保存成功");
                    }
                    else
                    {
                        MessageBox.Show("删除成功");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                dataGridView2.Update();
                refreshDataGridView2();
                ButtonClicked = 0;
            }
        }
        private void Delect_Dispatch_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count> 0)
            {
                if (MessageBox.Show("确认删除此派工单？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < dataGridView2.SelectedRows.Count; i++)
                        dataGridView2.Rows.Remove(dataGridView2.SelectedRows[i]);
                    ButtonClicked = 1;
                    Save_Dispatch_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }
        private void QueryDispatchMaterial_Dispatch_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0 && int.TryParse(dataGridView2.SelectedCells[0].Value.ToString(), out DispatchiD))
            {
                DispatchID.Text = DispatchiD.ToString();
                tabControl1.SelectedTab = tabPage3;
                Query_DispatchMaterial_Click(sender, e);
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }
        private void QueryDispatchReceipt_Dispatch_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0 && int.TryParse(dataGridView2.SelectedCells[0].Value.ToString(), out DispatchiD))
            {
                DispatchID2.Text = DispatchiD.ToString();
                tabControl1.SelectedTab = tabPage4;
                Query_DispatchReceipt_Click(sender, e);
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }

        //DispatchMaterial页part1--DespatchMaterial
        private void Query_DispatchMaterial_Click(object sender, EventArgs e)
        {
            if (int.TryParse(DispatchID.Text, out DispatchiD))
            {
                refreshDataGridView3();
            }
            else
            {
                MessageBox.Show("请输入数字");
            }
        }
        private void Save_DispatchMaterial_Click(object sender, EventArgs e)
        {
            if (ButtonClicked == 0 && MessageBox.Show("确认修改派工物资单？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
              || ButtonClicked == 1)
            {
                SqlConnection conn3 = new SqlConnection(connString);
                cmd3 = conn3.CreateCommand();
                cmd3.CommandText = sql3;
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                SqlCommandBuilder cb3 = new SqlCommandBuilder(da3);
                try
                {
                    da3.Update(ds3);

                    if (ButtonClicked == 0)
                    {
                        MessageBox.Show("保存成功");
                    }
                    else
                    {
                        MessageBox.Show("删除成功");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                dataGridView3.Update();
                refreshDataGridView3();
                ButtonClicked = 0;
            }
        }
        private void Delete__DispatchMaterial_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确认删除此派工物资单？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < dataGridView3.SelectedRows.Count; i++)
                        dataGridView3.Rows.Remove(dataGridView3.SelectedRows[i]);
                    ButtonClicked = 1;
                    Save_DispatchMaterial_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }
        private void QueryDispatchMaterialDetail__DispatchMaterial_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count != 0 && int.TryParse(dataGridView3.SelectedCells[0].Value.ToString(), out DispatchMaterialiD))
            {
                DispatchMaterialID.Text = DispatchMaterialiD.ToString();
                //tabControl1.SelectedTab = tabPage3;
                Query_DispatchMaterialDetail_Click(sender, e);
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }

        //DispatchMaterial页part2--DespatchMaterialDetail
        private void Query_DispatchMaterialDetail_Click(object sender, EventArgs e)
        {
            if (int.TryParse(DispatchMaterialID.Text, out DispatchMaterialiD))
            {
                refreshDataGridView4();
            }
            else
            {
                MessageBox.Show("请输入数字");
            }
        }
        private void Save__DispatchMaterialDetail_Click(object sender, EventArgs e)
        {
            if (ButtonClicked == 0 && MessageBox.Show("确认修改派工物资明细单？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
               || ButtonClicked == 1)
            {
                SqlConnection conn4 = new SqlConnection(connString);
                cmd4 = conn4.CreateCommand();
                cmd4.CommandText = sql4;
                SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                SqlCommandBuilder cb4 = new SqlCommandBuilder(da4);
                try
                {
                    da4.Update(ds4);

                    if (ButtonClicked == 0)
                    {
                        MessageBox.Show("保存成功");
                    }
                    else
                    {
                        MessageBox.Show("删除成功");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                dataGridView4.Update();
                refreshDataGridView4();
                ButtonClicked = 0;
            }
        }
        private void Delete__DispatchMaterialDetail_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确认删除此派工物资明细单？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < dataGridView4.SelectedRows.Count; i++)
                        dataGridView4.Rows.Remove(dataGridView4.SelectedRows[i]);
                    ButtonClicked = 1;
                    Save__DispatchMaterialDetail_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }

        //DispatchReceipt页
        private void Query_DispatchReceipt_Click(object sender, EventArgs e)
        {
            if (int.TryParse(DispatchID2.Text, out DispatchiD))
            {
                refreshDataGridView5();
            }
            else
            {
                MessageBox.Show("请输入数字");
            }
        }
        private void Save_DispatchReceipt_Click(object sender, EventArgs e)
        {
            if (ButtonClicked == 0 && MessageBox.Show("确认修改派工回执？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
              || ButtonClicked == 1)
            {
                SqlConnection conn5 = new SqlConnection(connString);
                cmd5 = conn5.CreateCommand();
                cmd5.CommandText = sql5;
                SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
                SqlCommandBuilder cb5 = new SqlCommandBuilder(da5);
                try
                {
                    da5.Update(ds5);

                    if (ButtonClicked == 0)
                    {
                        MessageBox.Show("保存成功");
                    }
                    else
                    {
                        MessageBox.Show("删除成功");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                dataGridView5.Update();
                refreshDataGridView5();
                ButtonClicked = 0;
            }
        }
        private void Delete_DispatchReceipt_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确认删除此派工回执？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < dataGridView5.SelectedRows.Count; i++)
                        dataGridView5.Rows.Remove(dataGridView5.SelectedRows[i]);
                    ButtonClicked = 1;
                    Save_DispatchReceipt_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }

        //OutsourceApplication页
        private void Query_OutsourceApplication_Click(object sender, EventArgs e)
        {
            if (int.TryParse(RepairApplicationID2.Text, out RepairApplicationiD))
            {
                refreshDataGridView6();
            }
            else
            {
                MessageBox.Show("请输入数字");
            }
        }
        private void Save_OutsourceApplication_Click(object sender, EventArgs e)
        {
            if (ButtonClicked == 0 && MessageBox.Show("确认修改对外委托申请？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
               || ButtonClicked == 1)
            {
                SqlConnection conn6 = new SqlConnection(connString);
                cmd6 = conn6.CreateCommand();
                cmd6.CommandText = sql6;
                SqlDataAdapter da6 = new SqlDataAdapter(cmd6);
                SqlCommandBuilder cb6 = new SqlCommandBuilder(da6);
                try
                {
                    da6.Update(ds6);

                    if (ButtonClicked == 0)
                    {
                        MessageBox.Show("保存成功");
                    }
                    else
                    {
                        MessageBox.Show("删除成功");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                dataGridView6.Update();
                refreshDataGridView6();
                ButtonClicked = 0;
            }
        }
        private void Delete_OutsourceApplication_Click(object sender, EventArgs e)
        {
            if (dataGridView6.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确认删除此对外委托申请？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < dataGridView6.SelectedRows.Count; i++)
                        dataGridView6.Rows.Remove(dataGridView6.SelectedRows[i]);
                    ButtonClicked = 1;
                    Save_OutsourceApplication_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }
        private void QueryOutsource_OutsourceApplication_Click(object sender, EventArgs e)
        {
            if (dataGridView6.SelectedRows.Count != 0 && int.TryParse(dataGridView6.SelectedCells[0].Value.ToString(), out OutsourceApplicationiD))
            {
                OutsourceApplicationID.Text = OutsourceApplicationiD.ToString();
                tabControl1.SelectedTab = tabPage6;
                Query_Outsource_Click(sender, e);
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }

        //Outsource页
        private void Query_Outsource_Click(object sender, EventArgs e)
        {
            if (int.TryParse(OutsourceApplicationID.Text, out OutsourceApplicationiD))
            {
                refreshDataGridView7();
            }
            else
            {
                MessageBox.Show("请输入数字");
            }
        }
        private void Save_Outsource_Click(object sender, EventArgs e)
        {
            if (ButtonClicked == 0 && MessageBox.Show("确认修改对外委托单？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
               || ButtonClicked == 1)
            {
                SqlConnection conn7 = new SqlConnection(connString);
                cmd7 = conn7.CreateCommand();
                cmd7.CommandText = sql7;
                SqlDataAdapter da7 = new SqlDataAdapter(cmd7);
                SqlCommandBuilder cb7 = new SqlCommandBuilder(da7);
                try
                {
                    da7.Update(ds7);

                    if (ButtonClicked == 0)
                    {
                        MessageBox.Show("保存成功");
                    }
                    else
                    {
                        MessageBox.Show("删除成功");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                dataGridView7.Update();
                refreshDataGridView7();
                ButtonClicked = 0;
            }
        }
        private void Delete_Outsource_Click(object sender, EventArgs e)
        {
            if (dataGridView7.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确认删除此对外委托单？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < dataGridView7.SelectedRows.Count; i++)
                        dataGridView7.Rows.Remove(dataGridView7.SelectedRows[i]);
                    ButtonClicked = 1;
                    Save_Outsource_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.ToString() == "TreeNode: 维修申请")
            {
                tabControl1.SelectedTab = tabPage1;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 派工单")
            {
                tabControl1.SelectedTab = tabPage2;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 派工物资单")
            {
                tabControl1.SelectedTab = tabPage3;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 派工回执")
            {
                tabControl1.SelectedTab = tabPage4;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 对外委托申请")
            {
                tabControl1.SelectedTab = tabPage5;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 对外委托单")
            {
                tabControl1.SelectedTab = tabPage6;
            }
            else
            {
                ;
            }
        }
    }
}
