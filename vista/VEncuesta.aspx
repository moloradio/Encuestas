<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/controlador/VEncuesta.aspx.cs" Inherits="vista_VEncuesta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Encuesta</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" type="text/css" href="../res/bootstrap/css/bootstrap.min.css"/>
    <link rel="stylesheet" type="text/css" href="../res/styles/css/style_encuestas.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="div_main_content ">
        <div id="div_content_encuesta">
            <div id="div_encabezado">
                <img id="img_logo_ak_vw" src="../res/img/logo_autokam_vw.png"/>
                <label id="lbl_titulo">Encuesta de satisfacción del cliente.</label>
                <img id="img_logo_vw" src="../res/img/logo_vw.png"/>
            </div>
            <div class="div_contenedor_preguntas1">
                <div class="div_preguntas" id="div_pregunta1">
                    Basándose en su experiencia de compra de su vehículo nuevo, ¿Cuál es su nivel de satisfacción en general con la concesionaria? 
                </div>
                <div class="div_respuestas" id="div_respuesta1">
                    <input type="radio"/>Excelente
                    <input type="radio"/>Muy Bueno
                    <input type="radio"/>Bueno
                    <input type="radio"/>Regular
                    <input type="radio"/>Malo
                </div>
            </div>
            <div class="div_division"></div>
            <div class="div_contenedor_preguntas2">
                <div class="div_preguntas" id="div_pregunta2">
                    ¿Le ofrecieron una prueba de manejo en el proceso de compra?
                </div>
                <div class="div_respuestas" id="div_respuesta2">
                    <input type="radio"/>Si
                    <input type="radio"/>No
                </div>
            </div>
            <div class="div_division"></div>
            <div class="div_contenedor_preguntas1">
                <div class="div_preguntas" id="div_pregunta3">
                    ¿Realizó la prueba de manejo en el proceso de compra?
                </div>
                <div class="div_respuestas" id="div_respuesta3">
                    <input type="radio"/>Si
                    <input type="radio"/>No
                </div>
            </div>
            <div class="div_division"></div>
            <div class="div_contenedor_preguntas2">
                <div class="div_preguntas" id="div_pregunta4">
                    ¿Cuál es su nivel de satisfacción con la prueba de manejo en general?
                </div>
                <div class="div_respuestas" id="div_respuesta4">
                    <input type="radio"/>Excelente
                    <input type="radio"/>Muy Bueno
                    <input type="radio"/>Bueno
                    <input type="radio"/>Regular
                    <input type="radio"/>Malo
                </div>
            </div>
            <div class="div_division"></div>
            <div class="div_contenedor_preguntas1">
                <div class="div_preguntas" id="div_pregunta5">
                    A continuación marque los puntos que se cumplieron en la entrega de su vehículo:
                </div>
                <div class="div_respuestas" id="div_respuesta5">
                    <input type="radio"/>Presentación del vehículo<br />
                    <input type="radio"/>Plan de asistencia técnica y garantía Volkswagen<br />
                    <input type="radio"/>Presentación del asesor de servicio<br />
                </div>
            </div>
            <div class="div_division"></div>
            <div class="div_contenedor_preguntas2">
                <div class="div_preguntas" id="div_pregunta6">
                    ¿Su vehículo fue entregado a tiempo?
                </div>
                <div class="div_respuestas" id="div_respuesta6">
                    <input type="radio"/>Si
                    <input type="radio"/>No
                </div>
            </div>
            <div class="div_division"></div>
            <div class="div_contenedor_preguntas1">
                <div class="div_preguntas" id="div_pregunta7">
                    ¿Tuvo alguna reclamación en el proceso de venta?
                </div>
                <div class="div_respuestas" id="div_respuesta7">
                    <input type="radio"/>Si
                    <input type="radio"/>No
                </div>
            </div>
            <div class="div_division"></div>
            <div class="div_contenedor_preguntas2">
                <div class="div_preguntas" id="div_pregunta8">
                    ¿En relación a su reclamación, que tan satisfecho está con la solución otorgada por la concesionaria?
                </div>
                <div class="div_respuestas" id="div_respuesta8">
                    <input type="radio"/>Excelente
                    <input type="radio"/>Muy Bueno
                    <input type="radio"/>Bueno
                    <input type="radio"/>Regular
                    <input type="radio"/>Malo
                </div>
            </div>
            <div class="div_division">.</div>
            <div class="div_contenedor_preguntas1">
                <div class="div_preguntas" id="div_pregunta9">
                    Comentarios o Sugerencias:
                </div>
                <div class="div_respuestas" id="div_respuesta9">
                    <textarea id="ta_comentarios"></textarea>
                </div>
            </div>
        </div>
        <div id="div_datos_ctes">
            <label>Favor de llenar los siguientes campos:</label>
            <div id="div_ctes_row1">
                <div id="div_nombre">
                    <label>Nombre(s):</label>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="txt_field"></asp:TextBox>
                </div>
                <div id="div_ap_paterno">
                    <label>Apellido Paterno:</label>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="txt_field"></asp:TextBox>
                </div>
                <div id="div_ap_materno">
                    <label>Apellido Materno:</label>
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="txt_field"></asp:TextBox>
                </div>
            </div>
            <div id="div_ctes_row2">
                <div id="div_email">
                    <label>E-mail:</label>
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="txt_field"></asp:TextBox>
                </div>
                <div id="div_tel_casa">
                    <label>Teléfono de Casa:</label>
                    <asp:TextBox ID="TextBox5" runat="server" CssClass="txt_field"></asp:TextBox>
                </div>
                <div id="div_tel_cel">
                    <label>Teléfono Celular:</label>
                    <asp:TextBox ID="TextBox6" runat="server" CssClass="txt_field"></asp:TextBox>
                </div>
            </div>
            <div id="div_bttn_enviar">
                <asp:Button ID="Button1" runat="server" Text="Enviar" CssClass="btn btn-success" />
            </div>
        </div>
    </div>
    </form>
</body>
</html>
