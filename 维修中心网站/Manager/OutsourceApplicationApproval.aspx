<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OutsourceApplicationApproval.aspx.cs" Inherits="Manager_OutsourceApplicationApproval" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="margin:0 0 0 150px">
        <div style="margin:0 0 0 230px"><asp:Label ID="Label4" runat="server" Text="对外委托申请审批"></asp:Label></div>
        <br />
        <div style="margin:0 0 0 50px"><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" DataKeyNames="OutsourceApplicationID" 
            DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="OutsourceApplicationID" 
                    HeaderText="OutsourceApplicationID" InsertVisible="False" ReadOnly="True" 
                    SortExpression="OutsourceApplicationID" Visible="False" />
                <asp:BoundField DataField="RepairApplicationID" HeaderText="维修申请ID" 
                    ReadOnly="True" SortExpression="RepairApplicationID" />
                <asp:BoundField DataField="OutsourceApplicationType" HeaderText="对外委托类型" 
                    ReadOnly="True" SortExpression="OutsourceApplicationType" />
                <asp:BoundField DataField="ApplyTime" HeaderText="申请时间" ReadOnly="True" 
                    SortExpression="ApplyTime" />
                <asp:BoundField DataField="ApplyContent" HeaderText="申请内容" ReadOnly="True" 
                    SortExpression="ApplyContent" />
                <asp:TemplateField HeaderText="状态" SortExpression="Status">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="100px">
                            <asp:ListItem>未通过</asp:ListItem>
                            <asp:ListItem>已通过</asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Status") %>'></asp:Label>
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
        </asp:GridView></div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:RepairCenterConnectionString %>" 
            DeleteCommand="DELETE FROM [OutsourceApplication] WHERE [OutsourceApplicationID] = @OutsourceApplicationID" 
            InsertCommand="INSERT INTO [OutsourceApplication] ([RepairApplicationID], [OutsourceApplicationType], [ApplyTime], [ApplyContent], [Status]) VALUES (@RepairApplicationID, @OutsourceApplicationType, @ApplyTime, @ApplyContent, @Status)" 
            SelectCommand="SELECT * FROM [OutsourceApplication]" 
            UpdateCommand="UPDATE [OutsourceApplication] SET [RepairApplicationID] = @RepairApplicationID, [OutsourceApplicationType] = @OutsourceApplicationType, [ApplyTime] = @ApplyTime, [ApplyContent] = @ApplyContent, [Status] = @Status WHERE [OutsourceApplicationID] = @OutsourceApplicationID">
            <DeleteParameters>
                <asp:Parameter Name="OutsourceApplicationID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="RepairApplicationID" Type="Int32" />
                <asp:Parameter Name="OutsourceApplicationType" Type="String" />
                <asp:Parameter Name="ApplyTime" Type="DateTime" />
                <asp:Parameter Name="ApplyContent" Type="String" />
                <asp:Parameter Name="Status" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="RepairApplicationID" Type="Int32" />
                <asp:Parameter Name="OutsourceApplicationType" Type="String" />
                <asp:Parameter Name="ApplyTime" Type="DateTime" />
                <asp:Parameter Name="ApplyContent" Type="String" />
                <asp:Parameter Name="Status" Type="String" />
                <asp:Parameter Name="OutsourceApplicationID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <div style="margin:0 0 0 250px"><asp:Label ID="Label2" runat="server" Text="维修申请查看"></asp:Label></div>
        <br />
        <br />
        <div style="margin:0 0 0 20px"><asp:Label ID="Label3" runat="server" Text="维修申请ID:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Width="134px">1</asp:TextBox>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" DataKeyNames="RepairApplicationID" 
        DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="RepairApplicationID" 
                HeaderText="RepairApplicationID" InsertVisible="False" ReadOnly="True" 
                SortExpression="RepairApplicationID" Visible="False" />
            <asp:BoundField DataField="ApplicantID" HeaderText="申请人ID" 
                SortExpression="ApplicantID" />
            <asp:BoundField DataField="Phone" HeaderText="电话" 
                SortExpression="Phone" />
            <asp:BoundField DataField="Area" HeaderText="片区" 
                SortExpression="Area" />
            <asp:BoundField DataField="Building" HeaderText="楼栋" 
                SortExpression="Building" />
            <asp:BoundField DataField="Room" HeaderText="房间号" 
                SortExpression="Room" />
            <asp:BoundField DataField="ApplicationReason" HeaderText="申请原因" 
                SortExpression="ApplicationReason" />
            <asp:BoundField DataField="Date" HeaderText="日期" SortExpression="Date" />
            <asp:BoundField DataField="Status" HeaderText="状态" SortExpression="Status" />
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
    </asp:GridView></div>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:RepairCenterConnectionString %>" 
            SelectCommand="SELECT * FROM [RepairApplication] WHERE ([RepairApplicationID] = @RepairApplicationID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox2" Name="RepairApplicationID" 
                    PropertyName="Text" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        </div>
    </div>
    </form>
</body>
</html>
