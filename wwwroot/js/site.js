// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// let x = document.getElementById("toggler");
// addEventListener.x(click, openNav)


function openNav() {
    if (document.getElementById("sidebar").style.width === "100%") {
        document.getElementById("sidebar").style.width = "0";
    } else {
        document.getElementById("sidebar").style.width = "100%";
    }
}


function closeNav(){
    document.getElementById("sidebar").style.width = "0";
}