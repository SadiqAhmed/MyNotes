$(function () {
    $.ajaxGet({ url: groupListUrl });
});

handler.admin = function ($selector) {
    $selector.find('#btnNewGroup').bind('click', function () {
        $.ajaxGet({ url: addGroupUrl });
    });

    $selector.find('#btnNewUser').bind('click', function () {
        $.ajaxGet({ url: addUserUrl });
    });

    $selector.bind('addGroup', function () {
        $(mynotes.Constants.PopupView).modal('hide');
        $.ajaxGet({ url: groupListUrl });
    });

    $selector.bind('addUser', function () {
        $(mynotes.Constants.PopupView).modal('hide');
        $.ajaxGet({ url: userListUrl });
    });
};