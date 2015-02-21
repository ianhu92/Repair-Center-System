<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addstudent.aspx.cs" Inherits="addstudent" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <fieldset style="border:solid 1px;margin:0 auto;width:400px;">
        <legend class="mailTitle">添加学生</legend>
        <div style="margin:0 auto;width:300px;">
            <br />
            请输入学生姓名：
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br/>
            请输入学生学号：
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>(1位字母+9位数字)
            <br/>
            请输入学生密码：
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
            <br/>
            再输入一次密码：
            <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
            <br />
        </div>
        <div style="margin:20px auto;width:100px;">
            <asp:Button ID="Button1" runat="server" Text="注册" onclick="Button1_Click" />
        </div>
    </fieldset>
    
    </form>
</body>
</html>
