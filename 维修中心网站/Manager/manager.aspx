<%@ Page Language="C#" AutoEventWireup="true" CodeFile="manager.aspx.cs" Inherits="manager" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>管理员，欢迎你！</title>
    <link type="text/css" rel="Stylesheet" href="managerpage.css" />

</head>
<body runat="server">
    <div id="m_page">   
        <div id="m_head">
            <div style="padding:70px 0 0 800px;">
                <span style="color: black"> &nbsp; &nbsp; &nbsp;&nbsp;管理员姓名:</span><asp:Label id="lbl_Name" runat="server"><%=Session["ManagerName"]%></asp:Label>
                <span >&nbsp;<a style="color:blue;"href="../Index.aspx">注销</a> </span>
            </div>
        </div>
        <div id="m_body">
            <div id="left">
            <iframe src="leftframe.aspx" height="490px" width="200px"  frameborder="1">
            </iframe>
            </div>
            <div id="right">
            <iframe name="main" src="PurchaseApplicationApproval.aspx" height="490px" width="1000px"  frameborder="1">
            </iframe>
            </div>
        </div>
    </div>
</body>
</html>
