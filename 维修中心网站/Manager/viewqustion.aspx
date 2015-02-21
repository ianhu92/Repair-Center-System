<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewqustion.aspx.cs" Inherits="Exam.Admin.viewqustion" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p style="text-align:center;">已有试题浏览</p>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" DataSourceID="SqlDataSource1" 
            HorizontalAlign="Center">
            <Columns>
                <asp:BoundField DataField="questionID" HeaderText="questionID" 
                    SortExpression="questionID" >
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" >
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle Width="400px" />
                </asp:BoundField>
                <asp:BoundField DataField="type" HeaderText="type" SortExpression="type" >
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="Ans1" HeaderText="Ans1" SortExpression="Ans1" >
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="Ans2" HeaderText="Ans2" SortExpression="Ans2" >
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="Ans3" HeaderText="Ans3" SortExpression="Ans3" >
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="Ans4" HeaderText="Ans4" SortExpression="Ans4" >
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="keyAns" HeaderText="keyAns" 
                    SortExpression="keyAns" >
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:CheckBoxField DataField="pub" HeaderText="pub" SortExpression="pub" >
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:CheckBoxField>
                <asp:HyperLinkField DataNavigateUrlFields="questionID" 
                    DataNavigateUrlFormatString="qustion_modify.aspx?qustionID={0}" Text="更新" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT * FROM [Question]"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
