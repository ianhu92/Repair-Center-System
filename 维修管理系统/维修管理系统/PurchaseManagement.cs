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
    public partial class PurchaseManagement : Form
    {
        public static int ReturnFlag = 0;
        public PurchaseManagement()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommandBuilder cb = new SqlCommandBuilder();
        SqlCommand cmd = new SqlCommand();
        private string sql = "select * from PurchaseRequisition";

        DataSet ds2 = new DataSet();
        SqlDataAdapter da2 = new SqlDataAdapter();
        SqlCommandBuilder cb2 = new SqlCommandBuilder();
        SqlCommand cmd2 = new SqlCommand();
        string sql2 = "select * from PurchaseRequisitionDetail";

        DataSet ds3 = new DataSet();
        SqlDataAdapter da3 = new SqlDataAdapter();
        SqlCommandBuilder cb3 = new SqlCommandBuilder();
        SqlCommand cmd3 = new SqlCommand();
        string sql3 = "select * from Delivery";

        DataSet ds4 = new DataSet();
        SqlDataAdapter da4 = new SqlDataAdapter();
        SqlCommandBuilder cb4 = new SqlCommandBuilder();
        SqlCommand cmd4 = new SqlCommand();
        string sql4 = "select * from DeliveryDetail";

        DataSet ds5 = new DataSet();
        SqlDataAdapter da5 = new SqlDataAdapter();
        SqlCommandBuilder cb5 = new SqlCommandBuilder();
        SqlCommand cmd5 = new SqlCommand();
        string sql5 = "select * from PurchaseReturn";

        DataSet ds6 = new DataSet();
        SqlDataAdapter da6 = new SqlDataAdapter();
        SqlCommandBuilder cb6 = new SqlCommandBuilder();
        SqlCommand cmd6 = new SqlCommand();
        string sql6 = "select * from PurchaseReturnDetail";
        
        DataSet ds7 = new DataSet();
        SqlDataAdapter da7 = new SqlDataAdapter();
        SqlCommandBuilder cb7 = new SqlCommandBuilder();
        SqlCommand cmd7 = new SqlCommand();
        string sql7 = "select * from Supplier";

        DataSet ds8 = new DataSet();
        SqlDataAdapter da8 = new SqlDataAdapter();
        SqlCommandBuilder cb8 = new SqlCommandBuilder();
        SqlCommand cmd8 = new SqlCommand();
        string sql8 = "select * from SupplierMaterialDetatil";

        private string connString = "Data Source=IAN-PC\\Ian;Initial Catalog=RepairCenter;Persist Security Info=True;User ID=sa;Password=sa";
        int ButtonClicked = 0;
        int purchaseRequisitionID = 0; int deliveryID = 0; int purchaseReturnID = 0; int stockInID = 0;
      
        private void Form4_Load(object sender, EventArgs e)
        {
            PurchaseApplicationID2.Text = "0";
            StockInID.Text = "0";
            refreshDataGridView1();
            refreshDataGridView3();
            refreshDataGridView5();
            refreshDataGridView7();
            refreshDataGridView8();
            if (MaterialManagerment.StockInFlag == 1)
            {
                tabControl1.SelectedTab = tabPage2;
                PurchaseApplicationID2.Text = "0";
                Query_Delivery_Click(sender, e);
                dataGridView3.Columns[0].Visible = true;
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
            dataGridView1.Columns[1].HeaderText = "日期";
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].HeaderText = "申请人ID";
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].HeaderText = "审批人ID";
            dataGridView1.Columns[4].HeaderText = "状态";
        }
        private void refreshDataGridView2()
        {
            ds2.Clear();
            sql2 = "select * from PurchaseRequisitionDetail where PurchaseRequisitionID='" + purchaseRequisitionID + "'";
            if (purchaseRequisitionID == 0)
            {
                sql2 = "select * from PurchaseRequisitionDetail";
            }
            SqlConnection conn2 = new SqlConnection(connString);
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn2);
            da2.Fill(ds2);
            dataGridView2.DataSource = ds2.Tables[0];
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "采购申请ID";
            dataGridView2.Columns[1].ReadOnly = true;
            dataGridView2.Columns[2].HeaderText = "物资ID";
            dataGridView2.Columns[3].HeaderText = "请求数量";
            dataGridView2.Columns[4].HeaderText = "已发数量";
            dataGridView2.Columns[5].HeaderText = "截止时间";
        }
        private void refreshDataGridView3()
        {
            ds3.Clear();
            sql3 = "select * from Delivery where PurchaseRequisitionID='" + purchaseRequisitionID + "'";
            if (purchaseRequisitionID == 0)
            {
                sql3 = "select * from Delivery";
            }
            SqlConnection conn3 = new SqlConnection(connString);
            SqlDataAdapter da3 = new SqlDataAdapter(sql3, conn3);
            da3.Fill(ds3);
            dataGridView3.DataSource = ds3.Tables[0];
            dataGridView3.Columns[0].HeaderText = "送货单ID";
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Columns[1].HeaderText = "采购申请ID";
            //dataGridView3.Columns[1].ReadOnly = true;
            dataGridView3.Columns[2].HeaderText = "供应商ID";
            dataGridView3.Columns[3].HeaderText = "日期";
            dataGridView3.Columns[4].HeaderText = "接收人ID";
            dataGridView3.Columns[4].ReadOnly = true;
        }
        private void refreshDataGridView4()
        {
            ds4.Clear();
            sql4 = "select * from DeliveryDetail where DeliveryID='" + deliveryID + "'";
            if (deliveryID == 0)
            {
                sql4 = "select * from DeliveryDetail";
            }
            SqlConnection conn4 = new SqlConnection(connString);
            SqlDataAdapter da4 = new SqlDataAdapter(sql4, conn4);
            da4.Fill(ds4);
            dataGridView4.DataSource = ds4.Tables[0];
            dataGridView4.Columns[0].Visible = false;
            dataGridView4.Columns[1].HeaderText = "送货ID";
            dataGridView4.Columns[1].ReadOnly = true;
            dataGridView4.Columns[2].HeaderText = "物料ID";
            dataGridView4.Columns[3].HeaderText = "单价";
            dataGridView4.Columns[4].HeaderText = "到货数量";
        }
        private void refreshDataGridView5()
        {
            ds5.Clear();
            sql5 = "select * from PurchaseReturn where StockInID='" + stockInID + "'";
            if (purchaseRequisitionID == 0)
            {
                sql5 = "select * from PurchaseReturn";
            }
            SqlConnection conn5 = new SqlConnection(connString);
            SqlDataAdapter da5 = new SqlDataAdapter(sql5, conn5);
            da5.Fill(ds5);
            dataGridView5.DataSource = ds5.Tables[0];
            dataGridView5.Columns[0].Visible = false;
            dataGridView5.Columns[1].HeaderText = "入库单ID";
            //dataGridView5.Columns[1].ReadOnly = true;
            dataGridView5.Columns[2].HeaderText = "日期";
            dataGridView5.Columns[2].ReadOnly = true;
            dataGridView5.Columns[3].HeaderText = "仓管人ID";
            dataGridView5.Columns[3].ReadOnly = true;
            dataGridView5.Columns[4].HeaderText = "状态";
        }
        private void refreshDataGridView6()
        {
            ds6.Clear();
            sql6 = "select * from PurchaseReturnDetail where PurchaseReturnID='" + purchaseReturnID + "'";
            if (purchaseRequisitionID == 0)
            {
                sql6 = "select * from PurchaseReturnDetail";
            }
            SqlConnection conn6 = new SqlConnection(connString);
            SqlDataAdapter da6 = new SqlDataAdapter(sql6, conn6);
            da6.Fill(ds6);
            dataGridView6.DataSource = ds6.Tables[0];
            dataGridView6.Columns[0].Visible = false;
            dataGridView6.Columns[1].HeaderText = "退货单ID";
            dataGridView6.Columns[1].ReadOnly = true;
            dataGridView6.Columns[2].HeaderText = "退货数量";
            dataGridView6.Columns[3].HeaderText = "退货原因";
        }
        private void refreshDataGridView7()
        {
            ds7.Clear();
            SqlConnection conn7 = new SqlConnection(connString);
            SqlDataAdapter da7 = new SqlDataAdapter(sql7, conn7);
            da7.Fill(ds7);
            dataGridView7.DataSource = ds7.Tables[0];
            dataGridView7.Columns[0].Visible = false;
            dataGridView7.Columns[0].HeaderText = "供应商ID";
            dataGridView7.Columns[1].HeaderText = "供应商名称";
            dataGridView7.Columns[2].HeaderText = "联系人";
            dataGridView7.Columns[3].HeaderText = "电话";          
        }

        private void refreshDataGridView8()
        {
            ds8.Clear();
            SqlConnection conn8 = new SqlConnection(connString);
            SqlDataAdapter da8 = new SqlDataAdapter(sql8, conn8);
            da8.Fill(ds8);
            dataGridView8.DataSource = ds8.Tables[0];
            dataGridView8.Columns[0].HeaderText = "供应商物资明细ID";
            dataGridView8.Columns[0].Visible = false;
            dataGridView8.Columns[1].HeaderText = "供应商ID";
            dataGridView8.Columns[2].HeaderText = "物料ID";
            dataGridView8.Columns[3].HeaderText = "参考单价";
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells[1].Value = System.DateTime.Now.Date;
            e.Row.Cells[2].Value = Form1.userIDString;
            e.Row.Cells[4].Value = "未通过";
        }
        private void dataGridView2_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells[1].Value = purchaseRequisitionID;
        }
        private void dataGridView3_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            //e.Row.Cells[1].Value = purchaseRequisitionID;
            e.Row.Cells[4].Value = Form1.userIDString;
        }
        private void dataGridView4_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells[1].Value = deliveryID;
        }
        private void dataGridView5_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            //e.Row.Cells[1].Value = purchaseRequisitionID;
            e.Row.Cells[2].Value = System.DateTime.Now.Date;
            e.Row.Cells[3].Value = Form1.userIDString;
            e.Row.Cells[4].Value = "未发出";
        }
        private void dataGridView6_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells[1].Value = purchaseReturnID;
        }
        private void dataGridView7_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            ;
        }
        private void dataGridView8_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            ;
        }

        private void Save_Purchase_Click(object sender, EventArgs e)
        {
             if (ButtonClicked == 0 && MessageBox.Show("确认修改采购申请单？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
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

        private void Delete_Purchase_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除此采购申请单？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[i]);
                ButtonClicked = 1;
                Save_Purchase_Click(sender, e);
            }
        }

        private void QueryDetail_Purchase_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0 && int.TryParse(dataGridView1.SelectedCells[0].Value.ToString(), out purchaseRequisitionID))
            {
                PurchaseApplicationID.Text = purchaseRequisitionID.ToString();
                tabControl1.SelectedTab = tabPage4;
                Query_PurchaseDetail_Click(sender, e);
            }
            else
            {
                MessageBox.Show("请选择有效行");
            }
        }

        private void Query_PurchaseDetail_Click(object sender, EventArgs e)
        {
            if (int.TryParse(PurchaseApplicationID.Text, out purchaseRequisitionID))
            {
                refreshDataGridView2();
            }
            else
            {
                MessageBox.Show("请输入数字");
            }
        }

        private void save_PurchaseDetail_Click(object sender, EventArgs e)
        {
             if (ButtonClicked == 0 && MessageBox.Show("确认修改采购申请单明细？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
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

        private void Delete_PurchaseDetail_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除此采购申请单明细？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView2.SelectedRows.Count; i++)
                    dataGridView2.Rows.Remove(dataGridView2.SelectedRows[i]);
                ButtonClicked = 1;
                save_PurchaseDetail_Click(sender, e);
            }
        }

        private void Save_Delivery_Click(object sender, EventArgs e)
        {
        if (ButtonClicked == 0 && MessageBox.Show("确认修改送货单？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
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

        private void Delete_Delivery_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除此送货单？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView3.SelectedRows.Count; i++)
                    dataGridView3.Rows.Remove(dataGridView3.SelectedRows[i]);
                ButtonClicked = 1;
                Save_Delivery_Click(sender, e);
            }
        }

        private void QueryDetail_Delivery_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count != 0 && int.TryParse(dataGridView3.SelectedCells[0].Value.ToString(), out deliveryID))//purchaseRequisitionID
            {
                Delivery_ID.Text = deliveryID.ToString();
                tabControl1.SelectedTab = tabPage5;
                Query_DeliveryDetail_Click(sender, e);
            }
            else
            {
                MessageBox.Show("请选择有效行");
            }
        }

        private void Query_DeliveryDetail_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Delivery_ID.Text, out deliveryID))
            {
                refreshDataGridView4();
            }
            else
            {
                MessageBox.Show("请输入数字");
            }
        }

        private void Save_DeliveryDetail_Click(object sender, EventArgs e)
        {
            if (ButtonClicked == 0 && MessageBox.Show("确认修改送货单明细？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
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

        private void Delete_DeliveryDetail_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除此送货单明细？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView4.SelectedRows.Count; i++)
                    dataGridView4.Rows.Remove(dataGridView4.SelectedRows[i]);
                ButtonClicked = 1;
                Save_DeliveryDetail_Click(sender, e);
            }
        }

        private void Save_Return_Click(object sender, EventArgs e)
        {
        if (ButtonClicked == 0 && MessageBox.Show("确认修改采购退货单？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
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

        private void Delete_Return_Click(object sender, EventArgs e)
        {
         if (MessageBox.Show("确认删除此采购退货单？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView5.SelectedRows.Count; i++)
                    dataGridView5.Rows.Remove(dataGridView5.SelectedRows[i]);
                ButtonClicked = 1;
                Save_Return_Click(sender, e);
            }
        }

        private void QueryDetail_Return_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count != 0 && int.TryParse(dataGridView5.SelectedCells[0].Value.ToString(), out purchaseReturnID))
            {
                ReturnID.Text = purchaseReturnID.ToString();
                tabControl1.SelectedTab = tabPage6;
                Query_ReturnDetail_Click(sender, e);
            }
            else
            {
                MessageBox.Show("请选择有效行");
            }
        }

        private void Query_ReturnDetail_Click(object sender, EventArgs e)
        {
        if (int.TryParse(ReturnID.Text, out purchaseReturnID))
            {
                refreshDataGridView6();
            }
            else
            {
                MessageBox.Show("请输入数字");
            }
        }

        private void Save_ReturnDetail_Click(object sender, EventArgs e)
        {
        if (ButtonClicked == 0 && MessageBox.Show("确认修改采购退货单明细？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
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

        private void Delete_ReturnDetail_Click(object sender, EventArgs e)
        {
        if (MessageBox.Show("确认删除此采购退货单明细？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView6.SelectedRows.Count; i++)
                    dataGridView6.Rows.Remove(dataGridView6.SelectedRows[i]);
                ButtonClicked = 1;
                Save_ReturnDetail_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Material_Click(object sender, EventArgs e)
        {
            MaterialQuery form7 = new MaterialQuery();
            form7.ShowDialog();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            EmployeeQuery form8 = new EmployeeQuery();
            form8.ShowDialog();
        }

        private void Save_Supplier_Click(object sender, EventArgs e)
        {
            if (ButtonClicked == 0 && MessageBox.Show("确认修改供应商表？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
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

        private void Delete_Supplier_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除此供应商？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView7.SelectedRows.Count; i++)
                    dataGridView7.Rows.Remove(dataGridView7.SelectedRows[i]);
                ButtonClicked = 1;
                Save_Supplier_Click(sender, e);
            }
        }

        private void Save_SupplierMaterialDetatil_Click(object sender, EventArgs e)
        {
            if (ButtonClicked == 0 && MessageBox.Show("确认修改供应商物资表？", "确认保存修改？", MessageBoxButtons.OKCancel) == DialogResult.OK
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

        private void Delete_SupplierMaterialDetatil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除此行供应商物资？", "确认删除？", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView8.SelectedRows.Count; i++)
                    dataGridView8.Rows.Remove(dataGridView8.SelectedRows[i]);
                ButtonClicked = 1;
                Save_SupplierMaterialDetatil_Click(sender, e);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.ToString() == "TreeNode: 采购申请单")
            {
                tabControl1.SelectedTab = tabPage1;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 送货单")
            {
                tabControl1.SelectedTab = tabPage2;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 采购退货单")
            {
                tabControl1.SelectedTab = tabPage3;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 采购申请明细表")
            {
                tabControl1.SelectedTab = tabPage4;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 送货明细表")
            {
                tabControl1.SelectedTab = tabPage5;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 采购退货明细表")
            {
                tabControl1.SelectedTab = tabPage6;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 供应商信息")
            {
                tabControl1.SelectedTab = tabPage7;
            }
            else if (treeView1.SelectedNode.ToString() == "TreeNode: 供应商物资明细")
            {
                tabControl1.SelectedTab = tabPage8;
            }            
            else
            {
                ;
            }

        }

        private void Query_Delivery_Click(object sender, EventArgs e)
        {
            if (int.TryParse(PurchaseApplicationID2.Text, out purchaseRequisitionID))
            {
                refreshDataGridView3();
            }
            else
            {
                MessageBox.Show("请输入数字");
            }
        }

        private void Query_PurchaseReturn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(StockInID.Text, out stockInID))
            {
                refreshDataGridView5();
            }
            else
            {
                MessageBox.Show("请输入数字");
            }
        }

        private void QueryDelivery_PurchaseApplication_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0 && int.TryParse(dataGridView1.SelectedCells[0].Value.ToString(), out purchaseRequisitionID))
            {
                PurchaseApplicationID2.Text = purchaseRequisitionID.ToString();
                tabControl1.SelectedTab = tabPage2;
                Query_Delivery_Click(sender, e);
            }
            else
            {
                MessageBox.Show("请选择有效行");
            }
        }

        private void QueryReturn_PurchaseApplication_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0 && int.TryParse(dataGridView1.SelectedCells[0].Value.ToString(), out purchaseRequisitionID))
            {
                StockInID.Text = purchaseRequisitionID.ToString();
                tabControl1.SelectedTab = tabPage3;
                Query_PurchaseReturn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("请选择有效行");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaterialManagerment materialManagerment = new MaterialManagerment();
            ReturnFlag = 1;
            materialManagerment.ShowDialog();
            ReturnFlag = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index == dataGridView1.RowCount - 1)
            {
                if (dataGridView1.CurrentCell.Value.ToString() != "")
                {
                    string a = dataGridView1.CurrentCell.Value.ToString();
                    dataGridView1.CurrentCell.Value = a;
                }
            }
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

        

       

       


        
    }
}
    

