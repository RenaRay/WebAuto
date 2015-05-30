function user() {
    var u = {
        login: "",
        firstName:""
    };
    return u;
}

function sendData() {
    u = new user();
    u.login = $("#login").val();
    u.firstName = $("#firstName").val();


    }