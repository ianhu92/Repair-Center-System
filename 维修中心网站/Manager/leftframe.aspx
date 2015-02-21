<%@ Page Language="C#" AutoEventWireup="true" CodeFile="leftframe.aspx.cs" Inherits="leftframe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>leftframe</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="page">
        <div id="head" style="background-image:">
        </div>
        <div id="content" style="margin:0 auto; ">
                <asp:TreeView ID="TreeView1" runat="server" ImageSet="BulletedList" 
                    ShowExpandCollapse="False">
                    <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                    <Nodes>
                        <asp:TreeNode Text="单据审批" Value="管理员管理">
                            <asp:TreeNode Text="采购申请单" Value="采购申请单" 
                                NavigateUrl="~/Manager/PurchaseApplicationApproval.aspx" Target="main">
                            </asp:TreeNode>
                            <asp:TreeNode Text="对外委托申请单" Value="对外委托申请单" 
                                NavigateUrl="~/Manager/OutsourceApplicationApproval.aspx" Target="main">
                            </asp:TreeNode>
                        </asp:TreeNode>
                    </Nodes>
                    <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" 
                        HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                    <ParentNodeStyle Font-Bold="False" />
                    <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" 
                        HorizontalPadding="0px" VerticalPadding="0px" />
                </asp:TreeView>           
        </div>
     </div>
    </form>
</body>
</html>
