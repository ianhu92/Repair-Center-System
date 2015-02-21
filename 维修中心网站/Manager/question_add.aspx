<%@ Page Language="C#" AutoEventWireup="true" CodeFile="question_add.aspx.cs" Inherits="Exam.Admin.question_add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="text-align: center">
            <br />
            <strong>添加试题</strong><br />
            <br />
            <fieldset style="margin: 0px auto 0px auto; width: 542px; height: 650px">
                &nbsp; &nbsp; &nbsp;
                &nbsp;&nbsp;<br />
                <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 502px;
                    height: 321px">
                    <tr>
                        <td style="width: 125px; height: 26px; text-align: right">
                            &nbsp;教师：</td>
                        <td colspan="2" style="width: 117px; height: 26px; text-align: left">
                            <asp:Label ID="lblTeacher" runat="server" Width="84px"></asp:Label>
                        </td>
                        <td style="width: 9px">
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 125px; height: 27px; text-align: right">
                            &nbsp;类型：</td>
                        <td colspan="2" style="width: 117px; height: 27px; text-align: left">
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem>A</asp:ListItem>
                                <asp:ListItem>B</asp:ListItem>
                                <asp:ListItem>C</asp:ListItem>
                                <asp:ListItem>D</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td style="width: 9px">
                            <asp:CheckBox ID="cbShare" runat="server" Checked="True" ForeColor="Blue" Text="发布"
                                Width="58px" /></td>
                    </tr>
                    <tr>
                        <td style="width: 125px; height: 122px; text-align: right">
                            &nbsp;试题题目：</td>
                        <td colspan="2" style="width: 117px; height: 122px; text-align: left">
                            <asp:TextBox ID="txtContent" runat="server" EnableTheming="True" Height="108px" TextMode="MultiLine"
                                Width="314px"></asp:TextBox></td>
                        <td style="width: 9px">
                            <asp:RequiredFieldValidator ID="rfvContent" runat="server" ControlToValidate="txtContent"
                                ErrorMessage="试题题目不能空">*</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td style="width: 125px; text-align: right">
                            &nbsp;选项A：</td>
                        <td colspan="2" style="width: 117px; text-align: left">
                            <asp:TextBox ID="txtAnsA" runat="server" TextMode="MultiLine" Width="316px"></asp:TextBox></td>
                        <td style="width: 9px">
                            <asp:RequiredFieldValidator ID="rfvA" runat="server" ControlToValidate="txtAnsA"
                                ErrorMessage="选项Ａ内容不能空">*</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td style="width: 125px; text-align: right">
                            &nbsp;选项B：</td>
                        <td colspan="2" style="width: 117px; text-align: left">
                            <asp:TextBox ID="txtAnsB" runat="server" TextMode="MultiLine" Width="316px"></asp:TextBox></td>
                        <td style="width: 9px">
                            <asp:RequiredFieldValidator ID="rfvB" runat="server" ControlToValidate="txtAnsB"
                                ErrorMessage="选项Ｂ内容不能空">*</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td style="width: 125px; text-align: right">
                            &nbsp;选项C：</td>
                        <td colspan="2" style="width: 117px; text-align: left">
                            <asp:TextBox ID="txtAnsC" runat="server" TextMode="MultiLine" Width="316px"></asp:TextBox></td>
                        <td style="width: 9px">
                            <asp:RequiredFieldValidator ID="rfvC" runat="server" ControlToValidate="txtAnsC"
                                ErrorMessage="选项Ｃ内容不能空">*</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td style="width: 125px; text-align: right">
                            &nbsp;选项D：</td>
                        <td colspan="2" style="width: 117px; text-align: left">
                            <asp:TextBox ID="txtAnsD" runat="server" TextMode="MultiLine" Width="316px"></asp:TextBox></td>
                        <td style="width: 9px; vertical-align: middle; text-align: left;">
                            <asp:RequiredFieldValidator ID="rfvD" runat="server" ControlToValidate="txtAnsD"
                                ErrorMessage="选项Ｄ内容不能空">*</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td style="width: 125px; height: 43px; text-align: right">
                            &nbsp;正确选项：</td>
                        <td colspan="2" style="width: 117px; height: 43px; text-align: left; vertical-align: bottom;">
                            <br />
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                                RepeatDirection="Horizontal" Width="100px">
                                <asp:ListItem>A</asp:ListItem>
                                <asp:ListItem>B</asp:ListItem>
                                <asp:ListItem>C</asp:ListItem>
                                <asp:ListItem>D</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td style="width: 9px; height: 43px">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="RadioButtonList1"
                                ErrorMessage="请选择一个答案">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3" style="height: 26px; text-align: center">
                            <asp:Button ID="btnOK" runat="server" Text="出题" OnClick="btnOK_Click" />
                            <asp:Button ID="btnClose" runat="server" Text="重置" />
                            &nbsp;
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
                                ShowSummary="False" />
                        </td>
                        <td style="width: 9px">
                            &nbsp;</td>
                    </tr>
                </table>
            </fieldset>
        </div>
    
    </div>
    </form>
</body>
</html>
