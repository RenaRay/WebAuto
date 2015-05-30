$(document).ready(function () {
    jQuery.get("api/messages/getall", function (messages) {        
        jQuery('#message-template').tmpl(messages).appendTo('#message-list');
    });
    //update panel  


});