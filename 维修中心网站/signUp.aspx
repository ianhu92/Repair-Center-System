<%@ Page Language="C#" AutoEventWireup="true" CodeFile="signUp.aspx.cs" Inherits="signUp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>注册页面</title>
    <link rel="stylesheet" href="signUp.css" />
    <script type="text/javascript" src="js/signUp.js"></script>
    <script type="text/javascript" src="js/Ajax.js"></script>
</head>
<body>
    <form id="form1" runat="server" autocomplete="off">
    <div id="zcstartpage">
    	<div id="zccontent">
        	<div id="zc-head"></div>
            <div id="zc-body">
					<div style="padding-left: 70px; padding-top: 15px; text-align: left;">
						<br/>
                        请输入账号：
						<input id="username" type="text" style="width: 156px; height: 15px;" value="" onblur="checkUsername(this.value)" name="username"/>
                        &nbsp;<a href="Index.aspx" style="color:white;">已有账号？</a>
						<br/>
                        <span id="usernameHint" style="color:Red;display:none">请输入3-20位、以字母或下划线开头的账号</span>
						<br/>
                        
						
						请输入密码：
						<input id="password" type="password" style="width: 156px; height: 15px;" value="" onblur="checkPassword(this.value,1)" name="password"/>
                        <br/>
                        <span id="passwordHint" style="color:Red;display:none">请输入3-20位、以字母或下划线开头的密码</span>
						<br/>
                        请确认密码：
						<input id="passwordcheck" type="password" style="width: 156px; height: 15px;" value="" onblur="checkPassword(this.value,2)" name="passwordcheck"/>
						<br/>
                        <span id="passwordcheckHint" style="color:Red;display:none">请输入3-20位、以字母或下划线开头的密码</span>
						<br/>
                        <span id="passwordcheckHint2" style="color:Red;display:none">两次输入密码不相同</span>
					</div>
					<div id="zcbottomarea">
					    <input id="zcbottom" type="button" value="" onclick="signUp(document.getElementById('username').value,document.getElementById('password').value)"/>
					</div>
            </div>
            <div id="login-foot"></div>
		</div>
    </div>
    </form>
</body>
</html>
