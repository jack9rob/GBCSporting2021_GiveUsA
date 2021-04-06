// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// validates customer selection
/*
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

// validates product selection
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

function incidentValidation() {
    var technician = document.getElementById("technicianSelect");
    var customer = document.getElementById("customerSelect");
    var product = document.getElementById("productSelect");

    technician.style.borderColor = "black";
    customer.style.borderColor = "black";
    product.style.borderColor = "black";

    var tSelect = technician.options[technician.selectedIndex].value;
    var cSelect = customer.options[customer.selectedIndex].value;
    var pSelect = product.options[product.selectedIndex].value;

    flag = true

    if (isNaN(tSelect)) {
        technician.style.borderColor = "red";
        flag = false
    }
    if (isNaN(cSelect)) {
        customer.style.borderColor = "red";
        flag = false
    }
    if (isNaN(pSelect)) {
        product.style.borderColor = "red";
        flag = false
    } 
    return flag;
}
*/