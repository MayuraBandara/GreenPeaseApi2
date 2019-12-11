
function GreenLogIn() {
    debugger;
    var request = {

        UserName: $('#txtUserName').val(),
        Password: $('#txtPassword').val()
    }
    var isSuccess = CallGreenAPI(request, LoginURL, "POST", false);
    debugger;
    alert(isSuccess);
     
}

function GreenRegister() {
    debugger;
    var request = {

        Name: $('#txRegistertName').val(),
        Email: $('#txtRegisterEmail').val(),
        RegisterPassword: $('#txtRegisterPassword').val()
    }
    var isSuccess = CallGreenAPI(request, RegisterURL, "POST", false);
    debugger;
    alert(isSuccess Register);

}

$(document).ready(function () {
    $('.img__btn').click(function () {

        $('.cont').toggleClass('s--signup');
    
    });
});
