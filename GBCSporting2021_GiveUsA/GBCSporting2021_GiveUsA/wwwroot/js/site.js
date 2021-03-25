// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function getCustomerValidation() {
    var selectElement = document.getElementById("getCustomerSelect");
    var selected = selectElement.options[selectElement.selectedIndex].value
    if (isNaN(selected)) {
        selectElement.style.borderColor = "red";
        document.getElementById("getCustomerLabel").innerHTML = "please select a customer";
        return false;
    } else {
        return true;
    }
}

function registerProductValidation() {
    var selectElement = document.getElementById("registerProductSelect");
    var selected = selectElement.options[selectElement.selectedIndex].value
    if (isNaN(selected)) {
        selectElement.style.borderColor = "red";
        return false;
    } else {
        return true;
    }
}