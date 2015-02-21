<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RepairApplication.aspx.cs" Inherits="User_RepairApplication" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>维修申报</title>
    <script type="text/javascript" src="RepairApplication.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width:600px;height:500px;">
    <div style="float:left;margin:50px 0 0 300px;height:400px">
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="　　　　　维修申报"></asp:Label>
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <span>申请人ID：</span>

        <asp:TextBox id="ApplicantID" runat="server" style="width:200px" type="text" />
        <br />
        <span>　电话　：</span>
        <asp:TextBox id="Phone" runat="server" style="width:200px" type="text" />
        <br />
        <span>　片区　：</span>
        <asp:TextBox id="Area" runat="server" style="width:200px" type="text" />
        <br />
        <span>　楼栋　：</span>
        <asp:TextBox id="Building" runat="server" style="width:200px" type="text" />
        <br />
        <span>　房间　：</span>
        <asp:TextBox id="Room" runat="server" style="width:200px" type="text" />
        <br />
        <span>申请原因：</span>
        <asp:TextBox id="ApplicationReason" runat="server" style="width:200px" type="text" />
        <br />
        <span>申请日期：</span>
        <asp:TextBox id="Date" runat="server" style="width:200px" type="text" />
        <br />
        <input type="button" onclick="a();" style="display:none;" />
        <div style="margin:30px 0 0 120px">
            <asp:Button ID="Button1"
                runat="server" Text="添加" onclick="Button1_Click" />
        </div>
    </div>
    </div>
    </form>
</body>
</html>
