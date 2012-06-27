$(function () {
    $('form').live('submit', function () {
        $this = $(this);

        if ($this.hasClass('jqAjaxForm')) {
            submitJqueryForm($this, $this.metadata());
            return false;
        }
        else {
            form.submit();
        }
    });
});

submitJqueryForm = function ($this, data) {
    if (data.IsAjax) {
        console.log('is ajax call');
        url = $this.attr('action');
        $this.append('<input name="json" value="true" style="display:none"/>');
        postData = $this.serialize();
        $.AjaxPost(url, postData, data.EventName, data.UpdateId);
    } else {
        $this[0].submit();
    }
};