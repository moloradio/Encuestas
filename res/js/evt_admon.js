$(document).ready(function () {
    
});

function ocultarVentanaPreguntas() {
    $("#div_cont_main_nueva_pregunta").css("display", "none");
}

function ocultarVentanaPreguntas2() {
    $("#div_cont_main_nueva_pregunta2").css("display", "none");
}

function mostraAgregarPregunta() {
    $("#div_cont_main_nueva_pregunta").css("display", "block");
}

function mostraAgregarPregunta2() {
    $("#div_cont_main_nueva_pregunta2").css("display", "block");
}


function mostrarEnviarEmail() {
    $("#div_bttn_send_email").css("display", "block");
    $("#div_bttn_send_sms").css("display", "none");
}

function mostrarEnviarSms() {
    $("#div_bttn_send_sms").css("display", "block");
    $("#div_bttn_send_email").css("display", "none");
}

function showAgregarEncuesta() {
    $("#div_admon_encuestas").css("display", "block");
    $("#div-print-encuestas").css("display", "none");
    $("#div_modif_encuestas").css("display", "none");
}

function showModifEncuesta() {
    $("#div_admon_encuestas").css("display", "none");
    $("#div-print-encuestas").css("display", "none");
    $("#div_modif_encuestas").css("display", "block");
}

function showPrintEncuesta() {
    $("#div_admon_encuestas").css("display", "none");
    $("#div-print-encuestas").css("display", "block");
    $("#div_modif_encuestas").css("display", "none");
}

function ocultarSendEmail() {
    $("#div_bttn_send_email").css("display", "none");
}

function ocultarSendSms() {
    $("#div_bttn_send_sms").css("display", "none");
}