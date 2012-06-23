
var mynotes = {
    CustomEvent: {
        LoginFormSubmitted: 'LoginFormSubmitted'
    },
    Constants: {
        AlertMessage: 'alertMessage',
        LeftView: 'leftContainer',
        RightView: 'rightContainer',
        DataEditorContainerView: 'dataEditorContainerView',
        ContentContainerView: 'contentContainerView'
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