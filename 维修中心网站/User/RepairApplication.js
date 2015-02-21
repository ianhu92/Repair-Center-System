window.onload = function () {
    var textboxApplicantID = document.getElementById("ApplicantID");
    var date = document.getElementById("Date");
    var userid = document.getElementById("TextBox2");
    userid.style.display = "none";

    textboxApplicantID.value = userid.value;
    textboxApplicantID.readOnly = "true";
    //textboxApplicantID.disabled = "true";
    //var date1 = new Date(System.currentTimeMillis()).toString();
    date.value = new Date().toLocaleString();
    date.readOnly = "true";
    // + " 星期" + "日一二三四五六".charAt(new Date().getDay()););

}
function a(){
    var textboxApplicantID = document.getElementById("ApplicantID");
    var date = document.getElementById("Date");
    var userid = document.getElementById("TextBox2");
    userid.style.display = "none";

    textboxApplicantID.value = userid.value;
    //tesetAttribute.setAttribute("readonly", 'readonly');
    textboxApplicantID.readonly = "readonly";
    //textboxApplicantID.disabled = "true";
    //var date1 = new Date(System.currentTimeMillis()).toString();
    date.value = new Date().toLocaleString();
    // + " 星期" + "日一二三四五六".charAt(new Date().getDay()););
}
