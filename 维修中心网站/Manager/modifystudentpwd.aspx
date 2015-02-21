<%@ Page Language="C#" AutoEventWireup="true" CodeFile="modifystudentpwd.aspx.cs" Inherits="modifystudent" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <fieldset style="border:solid 1px;margin:0 auto;width:400px;">
        <legend class="mailTitle">修改学生密码</legend>
        <div style="margin:0 auto;width:320px;">
            <br />
            请输入修改的学生ID：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br/>
            请输入新的学生密码：<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <br/>
            请再次输入新的密码：<asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div style="margin:20px auto;width:100px;">
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="修改" />
        </div>
    </fieldset>
    </form>
</body>
</html>
