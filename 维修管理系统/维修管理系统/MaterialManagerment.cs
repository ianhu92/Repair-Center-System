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
    public partial class MaterialManagerment : Form
    {
        public static int StockInFlag = 0;
        public static int StockOutFlag = 0;
        public MaterialManagerment()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommandBuilder cb = new SqlCommandBuilder();
        SqlCommand cmd = new SqlCommand();
        private string sql = "select * from StockIn";

        DataSet ds2 = new DataSet();
        SqlDataAdapter da2 = new SqlDataAdapter();
        SqlCommandBuilder cb2 = new SqlCommandBuilder();
        SqlCommand cmd2 = new SqlCommand();
        string sql2 = "select * from StockInDetail";

        DataSet ds3 = new DataSet();
        SqlDataAdapter da3 = new SqlDataAdapter();
        SqlCommandBuilder cb3 = new SqlCommandBuilder();
        SqlCommand cmd3 = new SqlCommand();
        string sql3 = "select * from StockOut";

        DataSet ds4 = new DataSet();
        SqlDataAdapter da4 = new SqlDataAdapter();
        SqlCommandBuilder cb4 = new SqlCommandBuilder();
        SqlCommand cmd4 = new SqlCommand();
        string sql4 = "select * from StockOutDetail";

        DataSet ds5 = new DataSet();
        SqlDataAdapter da5 = new SqlDataAdapter();
        SqlCommandBuilder cb5 = new SqlCommandBuilder();
        SqlCommand cmd5 = new SqlCommand();
        string sql5 = "select * from Material where Amount<Cordon";

        DataSet ds6 = new DataSet();
        SqlDataAdapter da6 = new SqlDataAdapter();
        SqlCommandBuilder cb6 = new SqlCommandBuilder();
        SqlCommand cmd6 = new SqlCommand();
        string sql6 = "select * from Material";

        DataSet ds7 = new DataSet();
        SqlDataAdapter da7 = new SqlDataAdapter();
        SqlCommandBuilder cb7 = new SqlCommandBuilder();
        SqlCommand cmd7 = new SqlCommand();
        string sql7 = "select * from Scrap";

        DataSet ds8 = new DataSet();
        SqlDataAdapter da8 = new SqlDataAdapter();
        SqlCommandBuilder cb8 = new SqlCommandBuilder();
        SqlCommand cmd8 = new SqlCommand();
        string sql8 = "select * from ScrapDetail";

        private string connString = "Data Source=IAN-PC\\Ian;Initial Catalog=RepairCenter;Persist Security Info=True;User ID=sa;Password=sa";
        int ButtonClicked = 0;
        int StockinID = 0; int StockoutID = 0; int ScrapiD = 0;

        private void Form3_Load(object sender, EventArgs e)
        {
            refreshDataGridView1();
            refreshDataGridView3();
            refreshDataGridView5();
            refreshDataGridView6();
            refreshDataGridView7();
            if (PurchaseManagement.ReturnFlag==1)
            {
                //tabControl1.SelectedTab = tabPage1;
                //PurchaseApplicationID2.Text = "0";
                //Query_Delivery_Click(sender, e);
                dataGridView1.Columns[0].Visible = true;
            }
        }
        private void refreshDataGridView1()
        {
            ds.Clear();
            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[0].HeaderText = "入库单ID";
            dataGridView1.Columns[1].HeaderText = "送货单ID";
            dataGridView1.Columns[2].HeaderText = "日期";
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].HeaderText = "入库人ID";
            dataGridView1.Columns[4].HeaderText = "仓管人ID";
            dataGridView1.Columns[4].ReadOnly = true;
        }
        private void refreshDataGridView2()
        {
            ds2.Clear();
            sql2 = "select * from StockInDetail where StockInID='" + StockinID + "'";
            SqlConnection conn2 = new SqlConnection(connString);
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn2);
            da2.Fill(ds2);
            dataGridView2.DataSource = ds2.Tables[0];
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "入库单ID";
            dataGridView2.Columns[1].ReadOnly = true;
            dataGridView2.Columns[2].HeaderText = "物料ID";
            dataGridView2.Columns[3].HeaderText = "到货数量";
            dataGridView2.Columns[4].HeaderText = "入库数量";
            dataGridView2.Columns[5].HeaderText = "检验结果";
            dataGridView2.Columns[6].HeaderText = "供应商ID";
            dataGridView2.Columns[7].HeaderText = "仓管员ID";
            dataGridView2.Columns[7].ReadOnly = true;
        }
        private void refreshDataGridView3()
        {
            ds3.Clear();
            SqlConnection conn3 = new SqlConnection(connString);
            SqlDataAdapter da3 = new SqlDataAdapter(sql3, conn3);
            da3.Fill(ds3);
            dataGridView3.DataSource = ds3.Tables[0];
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Columns[1].HeaderText = "派工单ID";
            dataGridView3.Columns[2].HeaderText = "日期";
            dataGridView3.Columns[2].ReadOnly = true;
            dataGridView3.Columns[3].HeaderText = "出库人ID";
            dataGridView3.Columns[4].HeaderText = "仓管人ID";
            dataGridView3.Columns[4].ReadOnly = true;
        }
        private void refreshDataGridView4()
        {
            ds4.Clear();
            sql4 = "select * from StockOutDetail where StockOutID='" + StockoutID + "'";
            SqlConnection conn4 = new SqlConnection(connString);
            SqlDataAdapter da4 = new SqlDataAdapter(sql4, conn4);
            da4.Fill(ds4);
            dataGridView4.DataSource = ds4.Tables[0];
            dataGridView4.Columns[0].Visible = false;
            dataGridView4.Columns[1].HeaderText = "出库单ID";
            dataGridView4.Columns[1].ReadOnly = true;
            dataGridView4.Columns[2].HeaderText = "物料ID";
            dataGridView4.Columns[3].HeaderText = "数量";
        }
        private void refreshDataGridView5()
        {
            ds5.Clear();
            SqlConnection conn5 = new SqlConnection(connString);
            SqlDataAdapter da5 = new SqlDataAdapter(sql5, conn5);
            da5.Fill(ds5);
            dataGridView5.DataSource = ds5.Tables[0];
            dataGridView5.Columns[0].HeaderText = "物料ID";
            dataGridView5.Columns[1].HeaderText = "物料名称";
            dataGridView5.Columns[2].HeaderText = "规格";
            dataGridView5.Columns[3].HeaderText = "单位";
            dataGridView5.Columns[4].HeaderText = "物料类型";
            dataGridView5.Columns[5].HeaderText = "数量";
            dataGridView5.Columns[6].HeaderText = "警戒线";
            dataGridView5.Columns[7].HeaderText = "维修价格";
            dataGridView5.Columns[8].HeaderText = "仓库";
        }
        private void refreshDataGridView6()
        {
            ds6.Clear();
            SqlConnection conn6 = new SqlConnection(connString);
            SqlDataAdapter da6 = new SqlDataAdapter(sql6, conn6);
            da6.Fill(ds6);
            dataGridView6.DataSource = ds6.Tables[0];
            dataGridView6.Columns[0].HeaderText = "物料ID";
            dataGridView6.Columns[0].ReadOnly = true;
            dataGridView6.Columns[1].HeaderText = "物料名称";
            dataGridView6.Columns[2].HeaderText = "规格";
            dataGridView6.Columns[3].HeaderText = "单位";
            dataGridView6.Columns[4].HeaderText = "物料类型";
            dataGridView6.Columns[5].HeaderText = "数量";
            dataGridView6.Columns[6].HeaderText = "警戒线";
            dataGridView6.Columns[7].HeaderText = "维修价格";
            dataGridView6.Columns[8].HeaderText = "仓库";
        }
        private void refreshDataGridView7()
        {
            ds7.Clear();
            SqlConnection conn7 = new SqlConnection(connString);
            SqlDataAdapter da7 = new SqlDataAdapter(sql7, conn7);
            da7.Fill(ds7);
            dataGridView7.DataSource = ds7.Tables[0];
            dataGridView7.Columns[0].HeaderText = "报废单ID";
            dataGridView7.Columns[0].Visible = false;
            dataGridView7.Columns[1].HeaderText = "日期";
            dataGridView7.Columns[1].ReadOnly = true;
            dataGridView7.Columns[2].HeaderText = "仓管人ID";
            dataGridView7.Columns[2].ReadOnly = true;
        }
        private void refreshDataGridView8()
        {
            ds8.Clear();
            sql8 = "select * from ScrapDetail where ScrapID='" + ScrapiD + "'";
            SqlConnection conn8 = new SqlConnection(connString);
            SqlDataAdapter da8 = new SqlDataAdapter(sql8, conn8);
            da8.Fill(ds8);
            dataGridView8.DataSource = ds8.Tables[0];
            dataGridView8.Columns[0].HeaderText = "报废单明细ID";
            dataGridView8.Columns[0].ReadOnly = true;
            //dataGridView8.Columns[0].Visible = false;
            dataGridView8.Columns[1].HeaderText = "报废单ID";
            dataGridView8.Columns[1].ReadOnly = true;
            dataGridView8.Columns[2].HeaderText = "物料ID";
            dataGridView8.Columns[3].HeaderText = "数量";
        }
        private void dataGridView1_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells[2].Value = System.DateTime.Now.Date;
            e.Row.Cells[4].Value = Form1.userIDString;
        }
        private void dataGridView2_DefaultValuesNeeded(object sender,System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells[1].Value = StockinID;
            e.Row.Cells[7].Value = Form1.userIDString;
        }
        private void dataGridView3_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells[2].Value = System.DateTime.Now.Date;
            e.Row.Cells[4].Value = Form1.userIDString;
        }
        private void dataGridView4_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells[1].Value = StockoutID;
        }
        private void dataGridView5_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            ;
        }
        private void dataGridView6_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            ;
        }
        private void dataGridView7_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells[1].Value = System.DateTime.Now.Date;
            e.Row.Cells[2].Value = Form1.userIDString;
        }
        private void dataGridView8_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells[1].Value = ScrapiD;
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.ToString() == "TreeNode: 入库单")
            {
                tabControl1.SelectedTab = tabPage1;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 入库单明细")
            {
                tabControl1.SelectedTab = tabPage2;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 出库单")
            {
                tabControl1.SelectedTab = tabPage3;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 出库单明细")
            {
                tabControl1.SelectedTab = tabPage4;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 报废单")
            {
                tabControl1.SelectedTab = tabPage7;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 报废单明细")
            {
                tabControl1.SelectedTab = tabPage8;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 缺货提醒")
            {
                tabControl1.SelectedTab = tabPage5;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 物料详细信息")
            {
                tabControl1.SelectedTab = tabPage6;
            }
            else
            {
                ;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenEmployeeQuery_Click(object sender, EventArgs e)
        {
            EmployeeQuery employeeQuery = new EmployeeQuery();
            employeeQuery.ShowDialog();
        }
        private void OpenMaterialQuery_Click(object sender, EventArgs e)
        {
            MaterialQuery materialQuery = new MaterialQuery();
            materialQuery.ShowDialog();
        }
        private void OpenSuppilerQuery_Click(object sender, EventArgs e)
        {
            SupplierQuery supplierQuery = new SupplierQuery();
            supplierQuery.ShowDialog();
        }
        private void Save_StockIn_Click(object sender, EventArgs e)
        {
            if (ButtonClicked == 0 && MessageBox.Show("确认修改入库单？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
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
        private void Delete_StockIn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确认删除此入库单？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                        dataGridView1.Rows.Remove(dataGridView1.SelectedRows[i]);
                    ButtonClicked = 1;
                    Save_StockIn_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }
        

        private void QueryDetail_StockIn_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count!=0&&int.TryParse(dataGridView1.SelectedCells[0].Value.ToString(), out StockinID))
            {
                StockInID.Text = StockinID.ToString();
                tabControl1.SelectedTab = tabPage2;
                Query_StockInDetail_Click(sender, e);
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }
        private void Query_StockInDetail_Click(object sender, EventArgs e)
        {
            if (int.TryParse(StockInID.Text, out StockinID))
            {
                refreshDataGridView2();
            }
            else
            {
                MessageBox.Show("请输入数字");
            }
        }

        private void Save_StockInDetail_Click(object sender, EventArgs e)
        {
            if (ButtonClicked == 0 && MessageBox.Show("确认修改入库单明细？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
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
        private void Delect_StockInDetail_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确认删除此入库单明细？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < dataGridView2.SelectedRows.Count; i++)
                        dataGridView2.Rows.Remove(dataGridView2.SelectedRows[i]);
                    ButtonClicked = 1;
                    Save_StockInDetail_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }
        private void Save_StockOut_Click(object sender, EventArgs e)
        {
            if (ButtonClicked == 0 && MessageBox.Show("确认修改入库单明细？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
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
        private void Delect_StockOut_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确认删除此入库单明细？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < dataGridView3.SelectedRows.Count; i++)
                        dataGridView3.Rows.Remove(dataGridView3.SelectedRows[i]);
                    ButtonClicked = 1;
                    Save_StockOut_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }

        private void QueryDetail_StockOut_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count != 0 && int.TryParse(dataGridView3.SelectedCells[0].Value.ToString(), out StockoutID))
            {
                StockOutID.Text = StockoutID.ToString();
                tabControl1.SelectedTab = tabPage4;
                Query_StockOutDetail_Click(sender, e);
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }
        private void Query_StockOutDetail_Click(object sender, EventArgs e)
        {
            if (int.TryParse(StockOutID.Text, out StockoutID))
            {
                refreshDataGridView4();
            }
            else
            {
                MessageBox.Show("请输入数字");
            }
        }

        private void Save_StockOutDetail_Click(object sender, EventArgs e)
        {
            if (ButtonClicked == 0 && MessageBox.Show("确认修改入库单明细？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
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
        private void Delect_StockOutDetail_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确认删除此入库单明细？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < dataGridView4.SelectedRows.Count; i++)
                        dataGridView4.Rows.Remove(dataGridView4.SelectedRows[i]);
                    ButtonClicked = 1;
                    Save_StockOutDetail_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }

        private void Save_Material_Click(object sender, EventArgs e)
        {
            if (ButtonClicked == 0 && MessageBox.Show("确认修改入库单明细？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
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

        private void Delete_Material_Click(object sender, EventArgs e)
        {
            if (dataGridView6.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确认删除此入库单明细？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < dataGridView6.SelectedRows.Count; i++)
                        dataGridView6.Rows.Remove(dataGridView6.SelectedRows[i]);
                    ButtonClicked = 1;
                    Save_Material_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }

        private void Save_Scrap_Click(object sender, EventArgs e)
        {
            if (ButtonClicked == 0 && MessageBox.Show("确认修改入库单明细？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
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

        private void Delete_Scrap_Click(object sender, EventArgs e)
        {
            if (dataGridView7.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确认删除此入库单明细？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < dataGridView7.SelectedRows.Count; i++)
                        dataGridView7.Rows.Remove(dataGridView7.SelectedRows[i]);
                    ButtonClicked = 1;
                    Save_StockOut_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }

        private void QueryDetail_Scrap_Click(object sender, EventArgs e)
        {
            if (dataGridView7.SelectedRows.Count != 0 && int.TryParse(dataGridView7.SelectedCells[0].Value.ToString(), out ScrapiD))
            {
                ScrapID.Text = ScrapiD.ToString();
                tabControl1.SelectedTab = tabPage8;
                Query_ScrapDetail_Click(sender, e);
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }

        private void Query_ScrapDetail_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ScrapID.Text, out ScrapiD))
            {
                refreshDataGridView8();
            }
            else
            {
                MessageBox.Show("请输入数字");
            }
        }

        private void Save_ScrapDetail_Click(object sender, EventArgs e)
        {
            if (ButtonClicked == 0 && MessageBox.Show("确认修改入库单明细？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
               || ButtonClicked == 1)
            {
                SqlConnection conn8 = new SqlConnection(connString);
                cmd8 = conn8.CreateCommand();
                cmd8.CommandText = sql8;
                SqlDataAdapter da8 = new SqlDataAdapter(cmd8);
                SqlCommandBuilder cb8 = new SqlCommandBuilder(da8);
                try
                {
                    da8.Update(ds8);

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
                dataGridView8.Update();
                refreshDataGridView8();
                ButtonClicked = 0;
            }
        }

        private void Detail_ScrapDetail_Click(object sender, EventArgs e)
        {
            if (dataGridView8.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确认删除此入库单明细？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < dataGridView8.SelectedRows.Count; i++)
                        dataGridView8.Rows.Remove(dataGridView8.SelectedRows[i]);
                    ButtonClicked = 1;
                    Save_ScrapDetail_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("请选择有效的一整行");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RepairManagement repairManagerment = new RepairManagement();
            StockOutFlag = 1;
            repairManagerment.ShowDialog();
            StockOutFlag = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PurchaseManagement purchaseManagerment = new PurchaseManagement();
            StockInFlag = 1;
            purchaseManagerment.ShowDialog();
            StockInFlag = 0;
        }

        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView7.CurrentRow.Index == dataGridView7.RowCount - 1)
            {
                string a =dataGridView7.CurrentCell.Value.ToString();
                dataGridView7.CurrentCell.Value = a;
            }
        }


        

    }
}
