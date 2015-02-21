<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>登陆界面</title>
    <link type="text/css" rel="stylesheet" href="login.css" />
    <script type="text/javascript" src="js/login.js"></script>
    <script type="text/javascript" src="js/Ajax.js"></script>
</head>
<body>
    <form id="form1" runat="server" autocomplete="off">
    <div id="startpage">
    	<div id="content">
        	<div id="login-head"></div>
            <div id="login-body">
                <div id="formbox">
					<input type="radio" checked="checked" value="User" name="userType"/>
					<span>用户登陆</span>
                    <input type="radio" value="Manager" name="userType"/>
					<span>管理员登陆</span>
					<span style="margin-left:40px;">
					<a style="color:white;" href="signUp.aspx">注册</a>
					</span>
					<span style="margin-left:40px;"></span>
				</div>
				<div style="float: left; padding-left: 80px; margin-top: 10px; text-align: left;">
					账 &nbsp; &nbsp;号：
					<input id="username" type="text" style="width: 156px; height: 15px;" value="" onblur="checkUsername(this.value)" name="username"/>
                    <br/>
                    <span id="usernameHint" style="color:Red;display:none">请输入3-20位的账号</span>
					<br/>
					密 &nbsp; &nbsp;码：
					<input id="password" type="password" style="width: 156px; height: 15px;" value="" name="password"/>
					<br/>
					<br/>
				</div>
				<div id="bottomarea" >
				    <input id="bottom" class="login" type="button" value="" onclick="Login(document.getElementById('username').value,document.getElementById('password').value)" />
				</div>
            </div>
		</div>
    </div>
    </form>
</body>
</html>
