$(function () {
    $('form').live('submit', function () {
        $this = $(this);

        if ($this.hasClass('jqAjaxForm')) {
            submitJqueryForm($this);
            return false;
        }
        else {
            form.submit();
        }
    });
});

submitJqueryForm = function ($this) {
    data = $this.metadata({ type: 'attr', name: 'data-options' });
    if (data.IsAjax) {
        console.log('is ajax call');
        url = $this.attr('action');
        postData = $this.serialize();
        $.ajaxPost(url, postData, data.EventName, data.UpdateId);
    } else {
        $this[0].submit();
    }
};