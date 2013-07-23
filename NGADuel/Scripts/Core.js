$(function () {
    $("input[type=submit], a, button,.oper li").button();
    $(document).tooltip();
    var icons = {
        header: "ui-icon-circle-arrow-e",
        activeHeader: "ui-icon-circle-arrow-s"
    };
    $(".accordion").accordion({
        icons: icons
    });
    var index = $("[index]").attr("index");
    $("[index] li:eq(" + index + ")").addClass("ui-state-active").off();
});
