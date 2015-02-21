<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EntryApplication.aspx.cs" Inherits="User_EntryApplication" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="EntryApplicaiton.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="margin-left:400px;">
            <h2>填写应聘申请</h2>
        </div>
        <div style="margin:0 0 0 100px;width:350px;float:left">
            <asp:Label ID="Label1" runat="server" Text="　　　　　　用户ID："></asp:Label>
            <asp:TextBox ID="TBUserID" runat="server" ReadOnly="True" Width="150px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="　　　　　　　姓名："></asp:Label>
            <asp:TextBox ID="TBName" runat="server" Width="150px"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="　　　　　　　性别："></asp:Label>
            <asp:DropDownList ID="CBSex" runat="server" Height="20px" Width="156px">
                <asp:ListItem>男</asp:ListItem>
                <asp:ListItem>女</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label4" runat="server" Text="　　　　　　　籍贯："></asp:Label>
            <asp:TextBox ID="TBHometown" runat="server" Width="150px"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="　　　　　　　民族："></asp:Label>
            <asp:TextBox ID="TBNation" runat="server" Width="150px"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="　　　　　　出生年："></asp:Label>
            <asp:TextBox ID="TBYear" runat="server" Width="150px"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="　　　　　　出生月："></asp:Label>
            <asp:TextBox ID="TBMonth" runat="server" Width="150px"></asp:TextBox>
            <br />
            <asp:Label ID="Label8" runat="server" Text="　　　　　户口性质："></asp:Label>
            <asp:DropDownList ID="CBHouseholdRegisterType" runat="server" Height="20px" 
                Width="156px">
                <asp:ListItem>非农</asp:ListItem>
                <asp:ListItem>农</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label9" runat="server" Text="　　　　　政治面貌："></asp:Label>
            <asp:TextBox ID="TBPoliticalLandscape" runat="server" Width="150px"></asp:TextBox>
            <br />
            <asp:Label ID="Label10" runat="server" Text="　　　　　　　学历："></asp:Label>
            <asp:DropDownList ID="CBEducationBackground" runat="server" Height="20px" 
                Width="156px">
                <asp:ListItem>小学</asp:ListItem>
                <asp:ListItem>初中</asp:ListItem>
                <asp:ListItem>高中</asp:ListItem>
                <asp:ListItem>中专</asp:ListItem>
                <asp:ListItem>大专</asp:ListItem>
                <asp:ListItem>本科</asp:ListItem>
                <asp:ListItem>硕士</asp:ListItem>
                <asp:ListItem>博士</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label11" runat="server" Text="　　　　　婚姻状况："></asp:Label>
            <asp:DropDownList ID="CBMaritalStatus" runat="server" Height="20px" 
                Width="156px">
                <asp:ListItem>未婚</asp:ListItem>
                <asp:ListItem>已婚</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label12" runat="server" Text="有无外出人员就业卡："></asp:Label>
            <asp:DropDownList ID="CBIsOutGoingEmploymentCard" runat="server" Height="20px" 
                Width="156px">
                <asp:ListItem>有</asp:ListItem>
                <asp:ListItem>无</asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
        <div style="margin:0 0 0 80px;width:420px;float:left">
            <asp:Label ID="Label13" runat="server" Text="计生证编号："></asp:Label>
            <asp:TextBox ID="TBBirthControlCertificateNumber" runat="server" Width="150px"></asp:TextBox>
            <br />
            <asp:Label ID="Label14" runat="server" Text="户口所在地："></asp:Label>
            <asp:TextBox ID="TBHouseholdRegisterLocation" runat="server" Width="150px"></asp:TextBox>
            <br />
            <asp:Label ID="Label15" runat="server" Text="身份证编号："></asp:Label>
            <asp:TextBox ID="TBIDNumber" runat="server" Width="150px"></asp:TextBox>
            <br />
            <asp:Label ID="Label16" runat="server" Text="　　现住址："></asp:Label>
            <asp:TextBox ID="TBCurrentAddress" runat="server" Width="150px"></asp:TextBox>
            <br />
            <asp:Label ID="Label17" runat="server" Text="　联系电话："></asp:Label>
            <asp:TextBox ID="TBPhone" runat="server" Width="150px"></asp:TextBox>
            <br />
            <asp:Label ID="Label18" runat="server" Text="　求职岗位："></asp:Label>
            <asp:TextBox ID="TBPosition" runat="server" Width="150px"></asp:TextBox>
            <br />
            <asp:Label ID="Label19" runat="server" Text="　到岗时间："></asp:Label>
            <asp:TextBox ID="TBArrivalTime" runat="server" Width="150px"></asp:TextBox>
            <asp:Label ID="Label25" runat="server" Text="请按YYYY/MM/DD格式"></asp:Label>
            <br />
            <asp:Label ID="Label21" runat="server" Text="　　　工种："></asp:Label>
            <asp:TextBox ID="TBCraft" runat="server" Width="150px"></asp:TextBox>
            <br />
            <asp:Label ID="Label22" runat="server" Text="　技术职称："></asp:Label>
            <asp:TextBox ID="TBTechnicalTitle" runat="server" Width="150px"></asp:TextBox>
            <br />
            <asp:Label ID="Label23" runat="server" Text="　资格证书："></asp:Label>
            <asp:TextBox ID="TBCertificate" runat="server" Width="150px"></asp:TextBox>
            <br />
            <asp:Label ID="Label24" runat="server" Text="　　　专长："></asp:Label>
            <asp:TextBox ID="TBSpecialty" runat="server" Width="150px"></asp:TextBox>
        </div>
        <div style="margin:50px 0 0 0px;float:left">
            <asp:Button ID="Button1" runat="server" Text="保存" Height="25px" Width="80px" 
                onclick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="清空" 
                Height="25px" Width="80px" onclick="Button2_Click" Visible="False" />
            <br />
            <asp:Label ID="Label26" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>
    
    </form>
</body>
</html>
