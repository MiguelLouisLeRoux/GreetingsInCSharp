// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', ()=>{
    const greetElem = document.getElementById("theGreet");
    const errorElem = document.getElementById("theError");
    const successMessage = document.getElementById("successMessage");
    const namesListSuccessMessage = document.getElementById("namesListSuccessMessage");

    if (greetElem !== null) {
        if (greetElem.hasChildNodes()) {
            setTimeout(function (){
                    greetElem.innerHTML = "";
            }, 3000);
        };
    }
    
    if (greetElem !== null) {
        if (errorElem.hasChildNodes()) {
            setTimeout(function (){
                    errorElem.innerHTML = "";
            }, 3000);
        };
    }
    
    if (greetElem !== null) {
        if (successMessage.hasChildNodes()) {
            setTimeout(function (){
                successMessage.innerHTML = "";
            }, 3000);
        };
    }
    

    if (namesListSuccessMessage !== null) {
        if (namesListSuccessMessage.hasChildNodes()) {
            setTimeout(function (){
                namesListSuccessMessage.innerHTML = "";
            }, 3000);
        };
    }
         
});