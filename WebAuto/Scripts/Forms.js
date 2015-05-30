/// <reference path="C:\Users\Компьютер\Documents\BI 2\Социальная сеть автомобилистов\WebAuto\WebAuto\HtmlMessageViewPage.html" />
function fx_click_button(type_btn, icons, button) {
    if (icons.indexOf(type_btn)==-1)
    {
        button.classList.add("selectedButton");
        icons.push(type_btn)
    }
    else 
    {
        icons.splice(icons.indexOf(type_btn), 1);
        button.classList.remove("selectedButton");
    }
}

function message() {
    var m = {
        comment: "",
        icons: [],
        number: "",
        dtime: new Date()
    };
    return m;
}

function sendMessage() {
    m = new message();

    m.comment = $("#textMessage").val();
    m.number = $("#number_result").val();
    m.icons = $('#panelButtons .selectedButton').map(function(index) {
        // this callback function will be called once for each matching element
        return this.id; 
    }).get();

    //TODO: Перед запросоом к серверу нужно отображать "крутилку"
   // document.documentElement.classList.add('image_load');
    $.post("api/messages", m, function () {
        location.href = "MessageViewPage.html";
    });
}

function checkNumber() {
    document.getElementById("number_result").value = document.getElementById("number_auto").value;
}

$(document).ready(function () {
    $('#panelButtons .blueorangebtn').click(function () {
        var button = $(this);
        if (button.hasClass('selectedButton')) {
            button.removeClass('selectedButton');
        }
        else {
            button.addClass('selectedButton');
        }
    });
});

