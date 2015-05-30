$(document).ready(function () {
    $('body').append('<table style="position:fixed; bottom:0px">\
        <tbody>\
            <tr>\
                <td>\
                    <div id="homeButton">\
                        <a href="HomePage.html"><img src="Images/homePic01.jpg"></a>\
                    </div>\
                </td>\
                <td>\
                    <div id="profileButton">\
                        <a href="ProfilePage.html"><img src="Images/profilePic01.jpg"></a>\
                    </div>\
                </td>\
                <td>\
                    <div id="chatButton">\
                        <a href="MessageViewPage.html"><img src="Images/chatPic01.jpg"></a>\
                    </div>\
                </td>\
            </tr>\
        </tbody>\
    </table>\
')
    // Setup the ajax indicator
    $('body').append('<div id="ajaxBusy"><p><img src="Images/ajax-loader-orange.gif"></p></div>');

    $('#ajaxBusy').css({
        //display: "none",
        margin: "0px",
        paddingLeft: "0px",
        paddingRight: "0px",
        paddingTop: "0px",
        paddingBottom: "0px",
        position: "absolute",
        top: "3px",
        width: "auto"
    });
});

// Ajax activity indicator bound to ajax start/stop document events
$(document).ajaxStart(function () {
    $('#ajaxBusy').show();
}).ajaxStop(function () {
    $('#ajaxBusy').hide();
})
