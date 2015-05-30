function newUser (){
    newUser = {login:"", password:""};
    return newUser;
}

function CheckLogin() {    
    user = new newUser();
    user.login = $("#login").val();
    user.password = $("#password").val();
}

//$(document).ready(function () {
//    jQuery.get("api/users/getall", function (users) {   
        
//    });