<%@ Page Language="C#" AutoEventWireup="true" CodeFile="left_nav.aspx.cs" Inherits="Exam.Student.left_nav" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TreeView ID="TreeView1" runat="server" ImageSet="BulletedList" 
            ShowExpandCollapse="False">
            <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
            <Nodes>
                <asp:TreeNode Text="在线维修中心" Value="在线维修中心">
                    <asp:TreeNode Text="维修申报" Value="维修申报" 
                        NavigateUrl="~/User/RepairApplication.aspx" Target="showframe"></asp:TreeNode>
                    <asp:TreeNode Text="维修查询" Value="维修查询" 
                        NavigateUrl="~/User/SelectRepairApplication.aspx" Target="showframe"></asp:TreeNode>
                    <asp:TreeNode Text="修改密码" Value="修改密码" NavigateUrl="~/User/changepassword.aspx" 
                        Target="showframe">
                    </asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode 
                    Text="加入我们" Value="加入我们">
                    <asp:TreeNode NavigateUrl="~/User/EntryApplication.aspx" Target="showframe" 
                        Text="填写应聘申请" Value="填写应聘申请"></asp:TreeNode>
                    <asp:TreeNode NavigateUrl="~/User/CheckEntryApplication.aspx" 
                        Target="showframe" Text="查看应聘申请" Value="查看应聘申请"></asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
            <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" 
                HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
            <ParentNodeStyle Font-Bold="False" />
            <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" 
                HorizontalPadding="0px" VerticalPadding="0px" />
        </asp:TreeView>
    </div>
    </form>
</body>
</html>
