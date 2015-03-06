<%@ Page Title="" Language="C#" MasterPageFile="~/vista/Administracion.master" AutoEventWireup="true" CodeFile="../controlador/envioInfo.aspx.cs" Inherits="vista_envioInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="div_bttn_send_email">
        <div id="div-cont-email1">
            <label id="lbl-email">Escriba:</label>
            <asp:TextBox ID="Texto_email" runat="server" CssClass="texto_email" TextMode="MultiLine"></asp:TextBox>
        </div>
        <div id="div-cont-email2">
            <asp:Button ID="Button1" runat="server" Text="Enviar Email" CssClass="btn btn-success bttn-send-email" OnClick="Button1_Click" />
            <input type="button" value="Cancelar" class="btn btn-danger" onclick="ocultarSendEmail()" />
        </div>
    </div>
    <div id="div_bttn_send_sms">
        <div id="div-cont-sms1">
            <label id="lbl-sms">Escriba:</label>
            <asp:TextBox ID="texto_sms" runat="server" CssClass="texto_sms" TextMode="MultiLine"></asp:TextBox>
        </div>
        <div id="div-cont-sms2">
            <asp:Button ID="Button2" runat="server" CssClass="btn btn-success bttn-send-sms" Text="Enviar SMS" OnClick="Button2_Click" />
            <input type="button" id="bttn-cancelar-sms" value="Cancelar" class="btn btn-danger" onclick="ocultarSendSms()" />
        </div>
    </div>
    <div></div>
    <div></div>
    <div id="div_tabla_clientes">
        <asp:Panel ID="Panel1" runat="server"></asp:Panel>
    </div>
</asp:Content>

