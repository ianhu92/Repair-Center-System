/**
 * @author HU
 */
//创建xmlHttp空对象
var xmlHttp=null;

//检查账号规范
function checkUsername(username){
    var reg = /^[a-zA-Z_]\w{2,19}$/;
    if(reg.test(username)){
        document.getElementById("usernameHint").style.display="none";
    }
    else{
        document.getElementById("usernameHint").style.display="";
    }
}
function checkPassword(password,i){
    var reg=/^[a-zA-Z_]\w{2,19}$/;
    var hint;
    if(i==1){
        hint=document.getElementById("passwordHint");
    }
    else{
        hint=document.getElementById("passwordcheckHint");
    }
    
    if(reg.test(password)){
        hint.style.display="none";
        if(i==2){
            if(password!=document.getElementById("password").value){
                document.getElementById("passwordcheckHint2").style.display="";
            }
            else{
                document.getElementById("passwordcheckHint2").style.display="none";
            }
        }
    }
    else{
        hint.style.display="";
    }
}

function signUp(username,password){
    //var reg1=/^\w\d{9}$/;
    var reg2=/^[a-zA-Z_]\w{2,19}$/;
    if(reg2.test(username)&&reg2.test(password)&&password==document.getElementById("passwordcheck").value){
        xmlHttp=GetXmlHttpObject();
        var url="doSignUp.aspx?username="+username+"&password="+password+"&sid="+Math.random();
        xmlHttp.onreadystatechange=doSignUp;
        xmlHttp.open("GET",url,true);
        xmlHttp.send();
    }
    else{
        alert("请正确输入信息");
    }
}
function doSignUp(){
    if(xmlHttp.readyState==4){
        if(xmlHttp.status==200){
            if(xmlHttp.responseText=="注册成功"){
                alert(xmlHttp.responseText);
                window.location="Index.aspx";
            }
            else{
                document.getElementById("password").value="";
                document.getElementById("passwordcheck").value="";
                alert(xmlHttp.responseText);
            }
        }
        else{
            document.getElementById("password").value="";
            document.getElementById("passwordcheck").value="";
            alert("出现错误");
        }
    }
}
