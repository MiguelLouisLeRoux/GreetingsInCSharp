// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', ()=>{
    const greetElem = document.getElementById("theGreet");
    const errorElem = document.getElementById("theError");

    if (theGreet.hasChildNodes()) {
        setTimeout(function (){
             theGreet.innerHTML = "";
        }, 3000);
    };

    if (theError.hasChildNodes()) {
        setTimeout(function (){
             theError.innerHTML = "";
        }, 3000);
    };
});