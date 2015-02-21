/**
 * @author HU
 */

//创建xmlHttp空对象
var xmlHttp=null;

//检查账号规范
function checkUsername(username){
    var regUsername=/^\w{3,20}$/;
    if(regUsername.test(username)){
        document.getElementById("usernameHint").style.display="none";
    }
    else{
        document.getElementById("usernameHint").style.display="";
    }
}

//获得账号类型
function getUserType(){
    var r=document.getElementsByName("userType"); 
    for(var i=0;i<r.length;i++){
        if(r[i].checked){
            return r[i].value;
        }
    }
}

//登陆
function Login(username,password){
	//var regUsername=/^\w\d{9}$/;
	var regPassword=/^\w{3,20}$/;
	//if(regUsername.test(username)&&regPassword.test(password)){
    if(regPassword.test(password)){
	    var userType=getUserType();
		xmlHttp=GetXmlHttpObject();
		var url="doLogin.aspx?username="+username+"&password="+password+"&userType="+userType+"&sid="+Math.random();
		xmlHttp.onreadystatechange=doLogin;
		xmlHttp.open("GET",url,true);
		xmlHttp.send();
    }
	else{
	    alert("请输入正确的密码");
	}
}
function doLogin(){
	if(xmlHttp.readyState==4){
	    if(xmlHttp.status==200){
	        if (xmlHttp.responseText == "User") {
	            alert("登陆成功");
	            window.location = "User/User.aspx";
	        }
	        else if (xmlHttp.responseText == "Manager") {
	            alert("登陆成功");
	            window.location = "Manager/manager.aspx";
	        }
	        else if (xmlHttp.responseText == "Not Manager") {
	            alert("不是管理员");
	        }
	        else {
	            document.getElementById("password").value = "";
	            alert("账号或密码错误");
	        }
        }
        else{
            document.getElementById("password").value="";
            alert("出现错误");
        }
	}
}
