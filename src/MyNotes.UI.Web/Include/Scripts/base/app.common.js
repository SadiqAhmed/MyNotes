$(function () {
    $('li.jqTab').bind('click', function () {
        $this = $(this);
        $ul = $this.parent('ul');
        $('li', $ul).removeClass('active');
        $this.addClass('active');
    });
});