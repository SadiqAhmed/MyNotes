$(function () {
    $.ajaxGet({ url: groupListUrl });
});

handler.admin = function ($selector) {
    $selector.find('#btnNewGroup').bind('click', function () {
        $.ajaxGet({ url: addGroupUrl });
    });

    $selector.find('#btnNewUser').bind('click', function () {
        alert('new user clicked');
    });

    $selector.bind('addGroup', function () {
        $(mynotes.Constants.PopupView).modal('hide');
        $.ajaxGet({ url: groupListUrl });
    });
};