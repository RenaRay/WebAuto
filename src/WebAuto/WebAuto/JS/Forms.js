function fx_click_button(type_btn, icons, button) {
    if (icons.indexOf(type_btn)==-1)
    {
        button.classList.add("selectedButton")
        icons.push(type_btn)
    }
    else 
    {
        icons.splice(icons.indexOf(type_btn), 1)
        button.classList.remove("selectedButton")
    }
}

function message() {
    var m = {
        comment: "",
        icons: [],
        number: "",
        dtime:new Date()
    }
    return m;
}

function sendMessage() {
    m = new message();

    m.comment = document.getElementById("textMessage").value;
    m.number = document.getElementById("number_result").value;

    _message = m.comment + ' ' + m.number + ' ' + m.icons + ' ' + m.dtime;
    alert(_message);
}

function checkNumber() {
    document.getElementById("number_result").value = document.getElementById("number_auto").value;
}