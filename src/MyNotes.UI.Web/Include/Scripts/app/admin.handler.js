$(function () {
    $.ajaxGet({ url: groupListUrl });
});

handler.admin = function ($selector) {
    $selector.find('#btnNewGroup').bind('click', function () {
        alert('new group clicked');
    });

    $selector.find('#btnNewUser').bind('click', function () {
        alert('new user clicked');
    });
};