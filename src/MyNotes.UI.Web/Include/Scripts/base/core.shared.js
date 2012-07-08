
var mynotes = {
    CustomEvent: {
        LoginFormSubmitted: 'LoginFormSubmitted'
    },
    Constants: {
        AlertMessage: 'alertMessage',
        PopupView: 'popupContainer',
        ContentView: 'mainContainer'
    },
    // methods
    DisplayAlertMessage: function (text) {
        $('#' + mynotes.Constants.AlertMessage).html(text).slideDown();
    },
    ClearAlertMessage: function () {
        $('#' + mynotes.Constants.AlertMessage).html("").fadeOut();
    },
    uniqid: function()
    {
        var newdate = new date;
        return newdate.gettime();
    }
};