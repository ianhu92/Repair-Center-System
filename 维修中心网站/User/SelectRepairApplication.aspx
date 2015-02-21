<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SelectRepairApplication.aspx.cs" Inherits="User_SelectRepairApplication" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label9" runat="server" Font-Size="XX-Large" 
            Text="　　　　　　　　 　查看修改维修申请"></asp:Label>
        <br />
        <br />
        <br />
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataSourceID="SqlDataSource1" DataKeyNames="RepairApplicationID" 
            CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="维修申请ID" InsertVisible="False" 
                    SortExpression="RepairApplicationID">
                    <EditItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("RepairApplicationID") %>' 
                            Width="80px"></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Height="16px" 
                            Text='<%# Bind("RepairApplicationID") %>' Width="124px"></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle Width="100px" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="电话" SortExpression="Phone">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Phone") %>' 
                            Width="100px"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("Phone") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="片区" SortExpression="Area">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Area") %>' 
                            Width="100px"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("Area") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="楼栋" SortExpression="Building">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Building") %>' 
                            Width="100px"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("Building") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="房间号" SortExpression="Room">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Room") %>' 
                            Width="100px"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("Room") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="申请原因" SortExpression="ApplicationReason">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" 
                            Text='<%# Bind("ApplicationReason") %>' Width="150px"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("ApplicationReason") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle Width="200px" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="日期" SortExpression="Date">
                    <EditItemTemplate>
                        <asp:Label ID="Label7" runat="server" Text='<%# Bind("Date") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label7" runat="server" Text='<%# Bind("Date") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="状态" SortExpression="Status">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="19px" 
                            SelectedValue='<%# Bind("Status") %>' Width="100px">
                            <asp:ListItem>未受理</asp:ListItem>
                            <asp:ListItem>已派工</asp:ListItem>
                            <asp:ListItem>派工维修完成</asp:ListItem>
                            <asp:ListItem>已委外</asp:ListItem>
                            <asp:ListItem>委外维修完成</asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label8" runat="server" Text='<%# Bind("Status") %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle Width="100px" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="操作" ShowHeader="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" 
                            CommandName="Update" Text="更新"></asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" 
                            CommandName="Cancel" Text="取消"></asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" 
                            CommandName="Edit" Text="编辑"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" 
                            CommandName="Delete" Text="删除"></asp:LinkButton>
                    </ItemTemplate>
                    <HeaderStyle Width="100px" />
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#66FFFF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" 
                BorderStyle="None" />
            <RowStyle BackColor="#EFF3FB" BorderStyle="Solid" BorderWidth="1px" 
                HorizontalAlign="Center" VerticalAlign="Middle" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:RepairCenterConnectionString %>" 
            
            SelectCommand="SELECT [Phone], [Area], [Building], [Room], [ApplicationReason], [Date], [Status], [RepairApplicationID] FROM [RepairApplication] WHERE ([ApplicantID] = @ApplicantID)" 
            DeleteCommand="DELETE FROM [RepairApplication] WHERE [RepairApplicationID] = @RepairApplicationID" 
            InsertCommand="INSERT INTO [RepairApplication] ([Phone], [Area], [Building], [Room], [ApplicationReason], [Date], [Status]) VALUES (@Phone, @Area, @Building, @Room, @ApplicationReason, @Date, @Status)" 
            UpdateCommand="UPDATE [RepairApplication] SET [Phone] = @Phone, [Area] = @Area, [Building] = @Building, [Room] = @Room, [ApplicationReason] = @ApplicationReason, [Date] = @Date, [Status] = @Status WHERE [RepairApplicationID] = @RepairApplicationID">
            <DeleteParameters>
                <asp:Parameter Name="RepairApplicationID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Phone" Type="String" />
                <asp:Parameter Name="Area" Type="String" />
                <asp:Parameter Name="Building" Type="String" />
                <asp:Parameter Name="Room" Type="String" />
                <asp:Parameter Name="ApplicationReason" Type="String" />
                <asp:Parameter Name="Date" Type="DateTime" />
                <asp:Parameter Name="Status" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:SessionParameter Name="ApplicantID" SessionField="userid" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="Phone" Type="String" />
                <asp:Parameter Name="Area" Type="String" />
                <asp:Parameter Name="Building" Type="String" />
                <asp:Parameter Name="Room" Type="String" />
                <asp:Parameter Name="ApplicationReason" Type="String" />
                <asp:Parameter Name="Date" Type="DateTime" />
                <asp:Parameter Name="Status" Type="String" />
                <asp:Parameter Name="RepairApplicationID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
