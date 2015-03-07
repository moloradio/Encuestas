<%@ Page Title="" Language="C#" MasterPageFile="~/vista/Administracion.master" AutoEventWireup="true" CodeFile="../controlador/adminEncuesta.aspx.cs" Inherits="vista_adminEncuesta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="div_cont_main_nueva_pregunta">
        <div id="div_main_nueva_pregunta">
            <div id="div_encabezado_preguntas">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </div>
            <div class="div_acomodo_cont" id="div_nombre_pregunta">
                <label id="lbl_pregunta">Pregunta:</label>
                <asp:TextBox ID="textarea_pregunta" CssClass="textarea_pregunta" runat="server"></asp:TextBox>
                <asp:HiddenField ID="HiddenField" runat="server" />
            </div>
            <div class="div_acomodo_cont" id="div_tipo_pregunta">
                <label id="lbl_tpregunta">Tipo de pregunta:</label>
                <asp:DropDownList ID="DropDownList5" runat="server" Height="24px" Width="229px">
                </asp:DropDownList>
            </div>
            <div class="div_acomodo_cont" id="div_respuesta_pregunta">
                <label id="lbl_opciones">Opciones de respuesta</label>
                <div id="div_respuestas">
                    <label id="lbl_orespuestas">Opciones de respuesta: Ingrese cada opcion en lineas separadas.</label>
                    <asp:TextBox ID="ta_opciones_respuestas" CssClass="ta_opciones_respuestas" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>
                <div id="div_dato_obligatorio">
                    <input type="radio" value="s" title="s" id="radio_obligatorio" />
                    <label id="pregunta_obligatoria">Pregunta de respuesta obligatoria.(Opcionales)</label>
                </div>
            </div>
            <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                <ContentTemplate>
                    <div id="bttn_opc_pregunta">
                        <input type="button" id="bttn_cancelar_pregunta" onclick="ocultarVentanaPreguntas()" value="Cancelar" class="btn btn-danger" />
                        <asp:Button ID="Button5" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="Button5_Click" /> 
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
    <div id="div_cont_main_nueva_pregunta2">
        <div id="div_main_nueva_pregunta2">
            <div id="div_encabezado_preguntas2">
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </div>
            <div class="div_acomodo_cont" id="div_nombre_pregunta2">
                <label id="lbl_pregunta2">Pregunta:</label>
                <asp:TextBox ID="textarea_pregunta2" CssClass="textarea_pregunta" runat="server"></asp:TextBox>
                <asp:HiddenField ID="HiddenField2" runat="server" />
            </div>
            <div class="div_acomodo_cont" id="div_tipo_pregunta2">
                <label id="lbl_tpregunta2">Tipo de pregunta:</label>
                <asp:DropDownList ID="DropDownList8" runat="server" Height="24px" Width="229px">
                </asp:DropDownList>
            </div>
            <div class="div_acomodo_cont" id="div_respuesta_pregunta2">
                <label id="lbl_opciones2">Opciones de respuesta</label>
                <div id="div_respuestas2">
                    <label id="lbl_orespuestas2">Opciones de respuesta: Ingrese cada opcion en lineas separadas.</label>
                    <asp:TextBox ID="ta_opciones_respuestas2" CssClass="ta_opciones_respuestas" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>
                <div id="div_dato_obligatorio2">
                    <input type="radio" value="s" title="s" id="radio_obligatorio2" />
                    <label id="pregunta_obligatoria2">Pregunta de respuesta obligatoria.(Opcionales)</label>
                </div>
            </div>
            <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                <ContentTemplate>
                    <div id="bttn_opc_pregunta2">
                        <input type="button" id="bttn_cancelar_pregunta2" onclick="ocultarVentanaPreguntas2()" value="Cancelar" class="btn btn-danger" />
                        <asp:Button ID="Button10" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="Button10_Click"  /> 
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
    <div id="div_modificar_preguntas">
        <div id="div_main_modif_preguntas">
            <div id="div_encabezado_modif_pregunta">
                <label id="lbl_modif_pregunta">Pregunta:</label>
                <asp:TextBox ID="txtbox_modificar_pregunta" TextMode="MultiLine" CssClass="txtbox_modificar_pregunta" runat="server"></asp:TextBox>
            </div>
            <div id="div_encabezado_modif_respuesta">
                <label id="lbl_modif_respuesta">Respuestas:</label>
                <asp:Button ID="bttn_agregar_respuesta" runat="server" Text="Agregar Respuesta" CssClass="btn btn-primary"/>
            </div>
            <div id="div_modif_respuestas">
                <asp:Panel ID="Panel3" runat="server"></asp:Panel>
            </div>
            <div id="div_bttn_modif_preguntas">
                <input type="button" id="bttn_cancelar_modif_pregunta" value="Cancelar" onclick="ocultarEdicionPreguntas()" class="btn btn-danger" />
                <asp:Button ID="bttn_guardar_pregunta" runat="server" CssClass="btn btn-info bttn_guardar_pregunta" Text="Guardar" />
            </div>
        </div>
    </div>
    <div id="div_modificar_encuestas">

    </div>
    <div id="div_main" class="jumbotron">
        <div id="div_opciones">
            <ul class="list-group">
                <li class="list-group-item" onclick="showAgregarEncuesta()">Agregar Encuesta</li>
                <li class="list-group-item" onclick="showModifEncuesta()">Modificar Encuesta</li>        
                <li class="list-group-item" onclick="showPrintEncuesta()">Imprimir Encuesta</li>
            </ul>
        </div>
        <div id="div_admon">
            <div id="div_admon_encuestas">
                <div id="div_titulo">
                    <label>Nueva Encuesta:</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Publicar encuesta" CssClass="btn btn-success" />
                </div>
                <div id="div_separacion"></div>
                <div id="div_nombre_encuesta">
                    <label>Nombre de la encuesta:</label>
                    <asp:TextBox ID="TextBox1" runat="server" Width="279px"></asp:TextBox>
                </div>
    <asp:UpdatePanel ID="UpdatePanel10" runat="server">
            <ContentTemplate>
                <div id="div_agencia_encuesta">
                    <label>Agencia:</label>
                    <asp:DropDownList ID="DropDownList3" runat="server" DataTextField="nombre" DataValueField="nombre">
                    </asp:DropDownList>
                </div>
                <div id="div_tipo_encuesta">
                    <label>Tipo de encuesta:</label>
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="322px" DataTextField="nombre" DataValueField="nombre"></asp:DropDownList>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
                <div id="div_bttn_encuesta">
                    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                        <ContentTemplate>
                            <asp:Button ID="Button1" runat="server" Text="Guardar Encuesta" CssClass="btn btn-info" OnClick="Button1_Click1" />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
                <div id="div_bttn_preguntas">
                    <input type="button" class="btn btn-primary" value="Agregar Pregunta" onclick="mostraAgregarPregunta()"/>
                </div>
                <div id="div_preguntas_encuesta">
                    <div id="div_label_preguntas">
                        <label id="label_preguntas">Preguntas Agregadas</label>
                    </div>
                    <div id="div_contenedor_preguntas">
                        <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                            <ContentTemplate>
                                <asp:Panel ID="Panel2" runat="server"></asp:Panel>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>   
                </div>
            </div>
            <div id="div_modif_encuestas">
                <div id="div_encabezado_modif">
                    <div id="div_encabezado1">
                        <label>Encuesta:</label>
                        <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                    </div>
                    <div id="div_encabezado2">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <asp:Button ID="Button3" runat="server" Text="Modificar" CssClass="btn btn-info" OnClick="Button3_Click" />
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                    <div id="div_encabezado3">
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <asp:Button ID="Button4" runat="server" Text="Borrar" CssClass="btn btn-danger" />
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
                    <div id="div-panel-edicion-encuesta">
                        <div id="div-encabezado-edicion-encuesta">
                        <div id="div-edit-nom-encuesta">
                            <label>Encuesta:</label>
                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                            <ContentTemplate>
                                <asp:TextBox ID="TextBox2" CssClass="text-box-nom-encuesta" runat="server"></asp:TextBox>
                                <asp:Button ID="Button6" runat="server" CssClass="btn btn-success bttn-edit-publicar-encuesta" Text="Publicar" />
                            </ContentTemplate>
                        </asp:UpdatePanel>      
                        </div>
                <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                    <ContentTemplate>
                        <div id="div-edit-datos-encuesta">
                            <div id="div-dropdown-agencia">
                                <label>Agencia:</label>
                                <asp:DropDownList ID="DropDownList6" runat="server"></asp:DropDownList>
                            </div>
                            <div id="div-dropdown-tencuesta">
                                <label>Tipo de Encuesta:</label>
                                <asp:DropDownList ID="DropDownList7" runat="server"></asp:DropDownList>
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
                        <div id="div-edit-descripcion-encuesta">
                            <label id="lbl-edit-descripcion-encuesta">Descripcion:</label>
                            <asp:TextBox ID="TextBox3" runat="server" CssClass="texbox-edit-descripcion-encuesta" TextMode="MultiLine"></asp:TextBox>
                        </div>
                    <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                        <ContentTemplate>
                        <div id="div-edit-bttn-encuesta">
                            <asp:Button ID="Button7" runat="server" CssClass="btn btn-info bttn-guardar-edit-encuestas" Text="Guardar" />
                            <asp:Button ID="Button8" runat="server" CssClass="btn btn-danger bttn-borrar-edit-encuestas" Text="Eliminar" />
                            <input id="Button9" type="button" class="btn btn-primary bttn-add-edit-encuestas" value="Agregar Pregunta" onclick="mostraAgregarPregunta2()" />
                        </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    </div>
                <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                    <ContentTemplate>
                        <asp:Panel ID="Panel1" runat="server"></asp:Panel>
                    </ContentTemplate>
                </asp:UpdatePanel>
                </div>
            </div>

            <div id="div-print-encuestas">
                <div id="div-encabezado-impresion">
                    <div id="div-title-encuesta-impresion">
                        <label>Encuesta:</label>
                        <asp:DropDownList ID="DropDownList4" runat="server"></asp:DropDownList>
                    </div>
                    <div id="div-bttn-ver-encuesta">
                        <asp:Button ID="Button13" runat="server" Text="Ver" CssClass="btn btn-info"/>
                    </div>
                    <div id="div-bttn-impresion-encuesta">
                        <asp:Button ID="Button14" runat="server" Text="Imprimir" CssClass="btn btn-success"/>
                    </div>
                </div>
                <div id="div-vista-previa-pdf">
                    Vista previa en PDF.
                </div>
            </div>
        </div>
    </div>
</asp:Content>

