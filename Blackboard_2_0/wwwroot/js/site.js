﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



$(document).ready(function () {
    var url = window.location +'';
    var res = url.split("/");
    
    var previousUrl = document.referrer.split("/");



    $('#active-nav li a').each(function () {
        var str = this.href.split("/");
        if (str[3] == res[3] || this.href == "") {
            $(this).parent().addClass('active');
        }
    });
});