<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User.aspx.cs" Inherits="Exam.Student.Student" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>在线维修中心</title>
    <script type="text/javascript" src="User.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="header" style="background-image:url(../web-loginpic/pagetop.jpg);height:100px;">
            <div style="padding:70px 0 0 800px;">
                <span style="color: black">用户ID:</span><asp:Label id="lbl_Id" runat="server"><%=Session["UserName"] %></asp:Label>
                <span style="color: #ff0033">&nbsp;<a id="zhuxiao" style="color:white;"href="../Index.aspx">注销</a> </span>
                <span style="color: #ff0033"> </span>
            </div>
        </div>
        <table style="width: 100%;">
            <tr>
                <td style="width:25%">
                    <iframe src="left_nav.aspx" style="height: 490px"></iframe>
                </td>
                <td>
                    <iframe src="RepairApplication.aspx" name="showframe" 
                        style="width: 1000px; overflow:auto; height: 490px;" id="change_frame"></iframe>
                </td>
            </tr>        
                
        </table>
        <input id="username" value=""  style="display:none;"/>
        <input type="button" onclick="b();" style="display:none;"/>
    </div>
    </form>
</body>
</html>
