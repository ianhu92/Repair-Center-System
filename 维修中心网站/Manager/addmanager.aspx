<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addmanager.aspx.cs" Inherits="Manager_addmanager" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <fieldset style="border:solid 1px;margin:0 auto;width:400px;">
        <legend class="mailTitle">添加管理员</legend>
        <div style="margin:0 auto;width:300px;">
            <br />
            <asp:Label ID="Label1" runat="server" Text="管理员ID　："></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="管理员姓名："></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="请输入密码："></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="请确认密码："></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
            <br />
        </div>
        <div style="margin:20px auto;width:100px;">
            <br /><asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="添加" /><br />
        </div>
    </fieldset>
    </form>
</body>
</html>
