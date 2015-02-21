<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PurchaseApplicationApproval.aspx.cs" Inherits="Manager_PurchaseApplicationApproval" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="margin:0 0 0 250px">
        <div style="margin:0 0 0 180px"><asp:Label ID="Label1" runat="server" Text="采购申请单审批"></asp:Label></div>
            <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" DataKeyNames="PurchaseRequisitionID" 
            DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="PurchaseRequisitionID" HeaderText="采购申请ID" 
                    InsertVisible="False" ReadOnly="True" SortExpression="PurchaseRequisitionID" />
                <asp:BoundField DataField="date" HeaderText="日期" SortExpression="date" 
                    ReadOnly="True" />
                <asp:BoundField DataField="ApplicantID" HeaderText="申请人" 
                    SortExpression="ApplicantID" ReadOnly="True" />
                <asp:TemplateField HeaderText="审批人" SortExpression="ApproverID">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" 
                            Text='<%# Bind("ApproverID") %>' Width="100px"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("ApproverID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="状态" SortExpression="Status">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" 
                            SelectedValue='<%# Bind("Status") %>' Width="100px">
                            <asp:ListItem>未通过</asp:ListItem>
                            <asp:ListItem>通过  </asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("Status") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:RepairCenterConnectionString %>" 
            DeleteCommand="DELETE FROM [PurchaseRequisition] WHERE [PurchaseRequisitionID] = @PurchaseRequisitionID" 
            InsertCommand="INSERT INTO [PurchaseRequisition] ([date], [ApplicantID], [ApproverID], [Status]) VALUES (@date, @ApplicantID, @ApproverID, @Status)" 
            SelectCommand="SELECT * FROM [PurchaseRequisition]" 
            UpdateCommand="UPDATE [PurchaseRequisition] SET [date] = @date, [ApplicantID] = @ApplicantID, [ApproverID] = @ApproverID, [Status] = @Status WHERE [PurchaseRequisitionID] = @PurchaseRequisitionID">
            <DeleteParameters>
                <asp:Parameter Name="PurchaseRequisitionID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="date" Type="DateTime" />
                <asp:Parameter Name="ApplicantID" Type="Int32" />
                <asp:Parameter Name="ApproverID" Type="Int32" />
                <asp:Parameter Name="Status" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="date" Type="DateTime" />
                <asp:Parameter Name="ApplicantID" Type="Int32" />
                <asp:Parameter Name="ApproverID" Type="Int32" />
                <asp:Parameter Name="Status" Type="String" />
                <asp:Parameter Name="PurchaseRequisitionID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <div style="margin:0 0 0 160px"><asp:Label ID="Label2" runat="server" Text="采购申请单明细查看"></asp:Label></div>
            <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="采购申请单ID:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Width="134px">1</asp:TextBox>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" DataKeyNames="PurchaseRequisitionDetailID" 
        DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="PurchaseRequisitionDetailID" 
                HeaderText="PurchaseRequisitionDetailID" InsertVisible="False" ReadOnly="True" 
                SortExpression="PurchaseRequisitionDetailID" Visible="False" />
            <asp:BoundField DataField="PurchaseRequisitionID" HeaderText="采购申请ID" 
                SortExpression="PurchaseRequisitionID" />
            <asp:BoundField DataField="MaterialID" HeaderText="物料ID" 
                SortExpression="MaterialID" />
            <asp:BoundField DataField="RequestNumber" HeaderText="申请数量" 
                SortExpression="RequestNumber" />
            <asp:BoundField DataField="IssuedNumber" HeaderText="已发数量" 
                SortExpression="IssuedNumber" />
            <asp:BoundField DataField="Deadline" HeaderText="截止日期" 
                SortExpression="Deadline" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:RepairCenterConnectionString %>" 
        DeleteCommand="DELETE FROM [PurchaseRequisitionDetail] WHERE [PurchaseRequisitionDetailID] = @PurchaseRequisitionDetailID" 
        InsertCommand="INSERT INTO [PurchaseRequisitionDetail] ([PurchaseRequisitionID], [MaterialID], [RequestNumber], [IssuedNumber], [Deadline]) VALUES (@PurchaseRequisitionID, @MaterialID, @RequestNumber, @IssuedNumber, @Deadline)" 
        SelectCommand="SELECT * FROM [PurchaseRequisitionDetail] WHERE ([PurchaseRequisitionID] = @PurchaseRequisitionID)" 
        UpdateCommand="UPDATE [PurchaseRequisitionDetail] SET [PurchaseRequisitionID] = @PurchaseRequisitionID, [MaterialID] = @MaterialID, [RequestNumber] = @RequestNumber, [IssuedNumber] = @IssuedNumber, [Deadline] = @Deadline WHERE [PurchaseRequisitionDetailID] = @PurchaseRequisitionDetailID">
        <DeleteParameters>
            <asp:Parameter Name="PurchaseRequisitionDetailID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="PurchaseRequisitionID" Type="Int32" />
            <asp:Parameter Name="MaterialID" Type="Int32" />
            <asp:Parameter Name="RequestNumber" Type="Int32" />
            <asp:Parameter Name="IssuedNumber" Type="Int32" />
            <asp:Parameter Name="Deadline" Type="DateTime" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="TextBox2" Name="PurchaseRequisitionID" 
                PropertyName="Text" Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="PurchaseRequisitionID" Type="Int32" />
            <asp:Parameter Name="MaterialID" Type="Int32" />
            <asp:Parameter Name="RequestNumber" Type="Int32" />
            <asp:Parameter Name="IssuedNumber" Type="Int32" />
            <asp:Parameter Name="Deadline" Type="DateTime" />
            <asp:Parameter Name="PurchaseRequisitionDetailID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
        </div>
    </div>
    
    </form>
</body>
</html>
