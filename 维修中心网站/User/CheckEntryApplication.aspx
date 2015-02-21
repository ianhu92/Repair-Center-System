<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckEntryApplication.aspx.cs" Inherits="User_CheckEntryApplication" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="margin:0 0 0 250px">
            <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="　 查看修改应聘申请"></asp:Label>
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" 
            AutoGenerateRows="False" CellPadding="4" DataKeyNames="EntryApplicationID" 
            DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" 
            Height="52px" Width="366px">
            <AlternatingRowStyle BackColor="White" />
            <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
            <EditRowStyle BackColor="#00CCFF" />
            <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="EntryApplicationID" HeaderText="应聘申请ID" 
                    InsertVisible="False" ReadOnly="True" SortExpression="EntryApplicationID">
                <HeaderStyle Width="200px" />
                </asp:BoundField>
                <asp:BoundField DataField="UserID" HeaderText="用户ID" ReadOnly="True" 
                    SortExpression="UserID" />
                <asp:BoundField DataField="Name" HeaderText="姓名" SortExpression="Name" />
                <asp:BoundField DataField="Sex" HeaderText="性别" SortExpression="Sex" />
                <asp:BoundField DataField="Hometown" HeaderText="籍贯" 
                    SortExpression="Hometown" />
                <asp:BoundField DataField="Nation" HeaderText="民族" SortExpression="Nation" />
                <asp:BoundField DataField="BirthYear" HeaderText="出生年" 
                    SortExpression="BirthYear" />
                <asp:BoundField DataField="BirthMonth" HeaderText="出生月" 
                    SortExpression="BirthMonth" />
                <asp:BoundField DataField="HouseholdRegisterType" HeaderText="户口类型" 
                    SortExpression="HouseholdRegisterType" />
                <asp:BoundField DataField="PoliticalLandscape" HeaderText="政治面貌" 
                    SortExpression="PoliticalLandscape" />
                <asp:BoundField DataField="MaritalStatus" HeaderText="婚姻状况" 
                    SortExpression="MaritalStatus" />
                <asp:BoundField DataField="EducationBackground" HeaderText="学历" 
                    SortExpression="EducationBackground" />
                <asp:BoundField DataField="IsOutGoingEmploymentCard" HeaderText="有无外出人员就业卡" 
                    SortExpression="IsOutGoingEmploymentCard" />
                <asp:BoundField DataField="BirthControlCertificateNumber" HeaderText="计生证编号" 
                    SortExpression="BirthControlCertificateNumber" />
                <asp:BoundField DataField="HouseholdRegisterLocation" HeaderText="户口所在地" 
                    SortExpression="HouseholdRegisterLocation" />
                <asp:BoundField DataField="IDNumber" HeaderText="身份证编号" 
                    SortExpression="IDNumber" />
                <asp:BoundField DataField="CurrentAddress" HeaderText="现住址" 
                    SortExpression="CurrentAddress" />
                <asp:BoundField DataField="Phone" HeaderText="电话" SortExpression="Phone" />
                <asp:BoundField DataField="Position" HeaderText="申请岗位" 
                    SortExpression="Position" />
                <asp:BoundField DataField="ArrivalTime" HeaderText="到岗时间" 
                    SortExpression="ArrivalTime" />
                <asp:BoundField DataField="Craft" HeaderText="工种" SortExpression="Craft" />
                <asp:BoundField DataField="TechnicalTitle" HeaderText="技术职称" 
                    SortExpression="TechnicalTitle" />
                <asp:BoundField DataField="Certificate" HeaderText="资格证书" 
                    SortExpression="Certificate" />
                <asp:BoundField DataField="Specialty" HeaderText="专长" 
                    SortExpression="Specialty" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            </Fields>
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" 
                HorizontalAlign="Right" VerticalAlign="Middle" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:RepairCenterConnectionString %>" 
            DeleteCommand="DELETE FROM [EntryApplication] WHERE [EntryApplicationID] = @EntryApplicationID" 
            InsertCommand="INSERT INTO [EntryApplication] ([UserID], [Name], [Sex], [Hometown], [Nation], [BirthYear], [HouseholdRegisterType], [BirthMonth], [PoliticalLandscape], [MaritalStatus], [EducationBackground], [IsOutGoingEmploymentCard], [BirthControlCertificateNumber], [TechnicalTitle], [Certificate], [Specialty], [HouseholdRegisterLocation], [IDNumber], [CurrentAddress], [Phone], [Position], [ArrivalTime], [Craft]) VALUES (@UserID, @Name, @Sex, @Hometown, @Nation, @BirthYear, @HouseholdRegisterType, @BirthMonth, @PoliticalLandscape, @MaritalStatus, @EducationBackground, @IsOutGoingEmploymentCard, @BirthControlCertificateNumber, @TechnicalTitle, @Certificate, @Specialty, @HouseholdRegisterLocation, @IDNumber, @CurrentAddress, @Phone, @Position, @ArrivalTime, @Craft)" 
            SelectCommand="SELECT [UserID], [Name], [Sex], [Hometown], [Nation], [BirthYear], [HouseholdRegisterType], [BirthMonth], [PoliticalLandscape], [MaritalStatus], [EducationBackground], [IsOutGoingEmploymentCard], [BirthControlCertificateNumber], [TechnicalTitle], [Certificate], [Specialty], [HouseholdRegisterLocation], [IDNumber], [CurrentAddress], [Phone], [Position], [ArrivalTime], [Craft], [EntryApplicationID] FROM [EntryApplication] WHERE ([UserID] = @UserID)" 
            UpdateCommand="UPDATE [EntryApplication] SET [UserID] = @UserID, [Name] = @Name, [Sex] = @Sex, [Hometown] = @Hometown, [Nation] = @Nation, [BirthYear] = @BirthYear, [HouseholdRegisterType] = @HouseholdRegisterType, [BirthMonth] = @BirthMonth, [PoliticalLandscape] = @PoliticalLandscape, [MaritalStatus] = @MaritalStatus, [EducationBackground] = @EducationBackground, [IsOutGoingEmploymentCard] = @IsOutGoingEmploymentCard, [BirthControlCertificateNumber] = @BirthControlCertificateNumber, [TechnicalTitle] = @TechnicalTitle, [Certificate] = @Certificate, [Specialty] = @Specialty, [HouseholdRegisterLocation] = @HouseholdRegisterLocation, [IDNumber] = @IDNumber, [CurrentAddress] = @CurrentAddress, [Phone] = @Phone, [Position] = @Position, [ArrivalTime] = @ArrivalTime, [Craft] = @Craft WHERE [EntryApplicationID] = @EntryApplicationID">
            <DeleteParameters>
                <asp:Parameter Name="EntryApplicationID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="UserID" Type="Int32" />
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Sex" Type="String" />
                <asp:Parameter Name="Hometown" Type="String" />
                <asp:Parameter Name="Nation" Type="String" />
                <asp:Parameter Name="BirthYear" Type="Int32" />
                <asp:Parameter Name="HouseholdRegisterType" Type="String" />
                <asp:Parameter Name="BirthMonth" Type="Int32" />
                <asp:Parameter Name="PoliticalLandscape" Type="String" />
                <asp:Parameter Name="MaritalStatus" Type="String" />
                <asp:Parameter Name="EducationBackground" Type="String" />
                <asp:Parameter Name="IsOutGoingEmploymentCard" Type="String" />
                <asp:Parameter Name="BirthControlCertificateNumber" Type="String" />
                <asp:Parameter Name="TechnicalTitle" Type="String" />
                <asp:Parameter Name="Certificate" Type="String" />
                <asp:Parameter Name="Specialty" Type="String" />
                <asp:Parameter Name="HouseholdRegisterLocation" Type="String" />
                <asp:Parameter Name="IDNumber" Type="String" />
                <asp:Parameter Name="CurrentAddress" Type="String" />
                <asp:Parameter Name="Phone" Type="String" />
                <asp:Parameter Name="Position" Type="String" />
                <asp:Parameter Name="ArrivalTime" Type="DateTime" />
                <asp:Parameter Name="Craft" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:SessionParameter Name="UserID" SessionField="UserID" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="UserID" Type="Int32" />
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Sex" Type="String" />
                <asp:Parameter Name="Hometown" Type="String" />
                <asp:Parameter Name="Nation" Type="String" />
                <asp:Parameter Name="BirthYear" Type="Int32" />
                <asp:Parameter Name="HouseholdRegisterType" Type="String" />
                <asp:Parameter Name="BirthMonth" Type="Int32" />
                <asp:Parameter Name="PoliticalLandscape" Type="String" />
                <asp:Parameter Name="MaritalStatus" Type="String" />
                <asp:Parameter Name="EducationBackground" Type="String" />
                <asp:Parameter Name="IsOutGoingEmploymentCard" Type="String" />
                <asp:Parameter Name="BirthControlCertificateNumber" Type="String" />
                <asp:Parameter Name="TechnicalTitle" Type="String" />
                <asp:Parameter Name="Certificate" Type="String" />
                <asp:Parameter Name="Specialty" Type="String" />
                <asp:Parameter Name="HouseholdRegisterLocation" Type="String" />
                <asp:Parameter Name="IDNumber" Type="String" />
                <asp:Parameter Name="CurrentAddress" Type="String" />
                <asp:Parameter Name="Phone" Type="String" />
                <asp:Parameter Name="Position" Type="String" />
                <asp:Parameter Name="ArrivalTime" Type="DateTime" />
                <asp:Parameter Name="Craft" Type="String" />
                <asp:Parameter Name="EntryApplicationID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        </div>
    </div>
    </form>
</body>
</html>
