// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



$(document).ready(function () {
    
    var url = window.location +'';
    var res = url.split("/");
    
    var previousUrl = document.referrer.split("/");

    console.log(previousUrl[3]);
    console.log(res[3]);

    if (previousUrl[3] === res[3]) { }

    $("#active-nav li a").each(function () {
        var str = this.href.split("/");
        if (str[3] === res[3] || this.href === "") {
            $(this).parent().addClass("active");
        }
    });
    
});


function rotate($el, degrees) {
    $el.css({
        '-webkit-transform': 'rotate(' + degrees + 'deg)',
        '-moz-transform': 'rotate(' + degrees + 'deg)',
        '-ms-transform': 'rotate(' + degrees + 'deg)',
        '-o-transform': 'rotate(' + degrees + 'deg)',
        'transform': 'rotate(' + degrees + 'deg)',
        'zoom': 1

    });
}

$(function () {

    $('.showArea').click(function (e) {
        var div = $(this).parent(".header-area").next();
        div.toggle();
        var degree = 0
        if (!div.is(':visible')) {

            $(e.target).attr("src", "/images/plus.png");
            rotate($(e.target), 90);
            
        } else {
            
            $(e.target).attr("src", "/images/minus.png");
            rotate($(e.target), 0);
        }
    });

});


$(function () {

    $('.showArea').click(function (e) {
        var div = $(this).parent(".header-area").next();
        div.toggle();
        var degree = 0
        if (!div.is(':visible')) {

            $(e.target).attr("src", "/images/plus.png");
            rotate($(e.target), 90);

        } else {

            $(e.target).attr("src", "/images/minus.png");
            rotate($(e.target), 0);
        }
    });

});


$(function () {

    $('.show').click(function(e) {
        $(this).next().toggle();
    });
});
