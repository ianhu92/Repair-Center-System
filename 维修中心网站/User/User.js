window.onload = function () {
    var a = document.getElementById("lbl_Id");
    var usernameInput = document.getElementById("username");
    usernameInput.value = a.innerHTML;
    //alert(a.innerHTML);

}
function b() {
    var a = document.getElementById("lbl_Id");
    var usernameInput = document.getElementById("username");
    usernameInput.value = "a.innerHTML";
    alert(a.innerHTML);
}