<%@ Page Language="C#" AutoEventWireup="true" CodeFile="rightframe.aspx.cs" Inherits="rightframe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Table ID="Table1" runat="server" BorderColor="#CC0000" 
            HorizontalAlign="Center" Width="33%">
            <asp:TableRow ID="TableRow1" runat="server" HorizontalAlign="Left" VerticalAlign="Middle" 
                Width="100%" BorderStyle="Solid" BorderWidth="1px">
                <asp:TableCell ID="TableCell1" runat="server" HorizontalAlign="Left">管理员ID：<%=Session["managerID"] %></asp:TableCell>
                <asp:TableCell ID="TableCell2" runat="server" HorizontalAlign="Left"></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="TableRow2" runat="server">
                <asp:TableCell ID="TableCell3" runat="server">姓名：<%=Session["name"]%></asp:TableCell>
                <asp:TableCell ID="TableCell4" runat="server"></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="TableRow3" runat="server">
                <asp:TableCell ID="TableCell5" runat="server">专业：信息管理与信息系统</asp:TableCell>
                <asp:TableCell ID="TableCell6" runat="server"></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
