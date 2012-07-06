$(function () {
    $('#btnClear').bind('click', function () {
        $('#Username, #Password').val('');
    });

    $('#btnLogIn').bind('click', function () {
        $.ajaxGet({
            url: validateUrl,
            data: { Username: $('#Username').val(), Password: $('#Password').val() },
            callback: function (response) {
                jsonResult = $.pasreJson(response.Result);
            }
        });
    });
});