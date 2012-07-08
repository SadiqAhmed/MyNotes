var handler = function () { };
$(function () {
    handler.functions = [
        handler.admin,
        handler.undefinedhandler
    ];
});

handler.bindFunctions = function ($selector) {
    var i, f, p = [];
    for (i in handler.functions) {
        if (f = handler.functions[i])
            f($selector);
    }
};