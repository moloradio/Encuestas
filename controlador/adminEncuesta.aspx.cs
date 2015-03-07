using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vista_adminEncuesta : System.Web.UI.Page
{
    private Encuestas encuesta;
    private AEncuestas aencuesta;
    private MostrarDatos datos;
    private String nomEncuesta;

    private String sPregunta;
    private String sTPregunta;
    private String sRespuesta;

    private HiddenField hIdPregunta;
    private Button bttnEditarPregunta;

    protected void Page_Load(object sender, EventArgs e)
    {

        datos = new MostrarDatos();
        List<Agencia> agencias = datos.mostrarAgencias();
        for (int i = 0; i < agencias.Count; i++)
        {
            Agencia agencia = (Agencia)agencias.ElementAt(i);
            DropDownList3.Items.Add(new ListItem(agencia.Nombre));
        }
        List<TEncuesta> tencuestas = datos.mostrarTEncuestas();
        for (int i = 0; i < tencuestas.Count; i++)
        {
            TEncuesta tencuesta = (TEncuesta)tencuestas.ElementAt(i);
            DropDownList1.Items.Add(new ListItem(tencuesta.Nombre));
        }
        List<Encuestas> encuestas = datos.mostrarEncuestas();
        for (int i = 0; i < encuestas.Count; i++ )
        {
            Encuestas encuesta = encuestas.ElementAt(i);
            DropDownList2.Items.Add(new ListItem(encuesta.Nombre));
            DropDownList4.Items.Add(new ListItem(encuesta.Nombre));
        }
        botonModificar();
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        encuesta = new Encuestas();
        nomEncuesta = TextBox1.Text;

        encuesta.Nombre = nomEncuesta;
        aencuesta = new AEncuestas(encuesta);
        aencuesta.altaNomEncuesta();

        Session["idEncuesta"] = aencuesta.getIdEncuesta();
    }

    public void botonModificar() {
        bttnEditarPregunta = new Button();
        bttnEditarPregunta.Text = "Modificar";
        bttnEditarPregunta.CssClass = "btn btn-info bttn-modif-pregunta";
        bttnEditarPregunta.Click += new EventHandler(this.bttnModificarPregunta);
        bttnEditarPregunta.OnClientClick = "mostrarEdicionPreguntas()";
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        MostrarDatos datos = new MostrarDatos();
        String nomEncuesta = DropDownList2.SelectedItem.Text;
        List<Preguntas> preguntas;
        Preguntas pregunta;
        Encuestas encuesta;
        
        encuesta = datos.mostrarEncuesta(nomEncuesta);
        TextBox2.Text = encuesta.Nombre;
        TextBox3.Text = encuesta.Descripcion;
        Session["idEncuesta_modif"] = encuesta.IdEncuesta;

        List<Agencia> agencias = datos.mostrarAgencias();
        for (int i = 0; i < agencias.Count; i++)
        {
            Agencia agencia = (Agencia)agencias.ElementAt(i);
            DropDownList6.Items.Add(new ListItem(agencia.Nombre));
        }
        String tEncuesta = "";
        List<TEncuesta> tencuestas = datos.mostrarTEncuestas();
        for (int i = 0; i < tencuestas.Count; i++)
        {
            TEncuesta tencuesta = (TEncuesta)tencuestas.ElementAt(i);
            DropDownList7.Items.Add(new ListItem(tencuesta.Nombre));
            if (tencuesta.IdTEncuesta == encuesta.IdTEncuesta.IdTEncuesta) {
                tEncuesta = DropDownList7.SelectedItem.Text;
            }
        }

        Button bttnEditarPregunta = new Button();
        bttnEditarPregunta.Text = "Modificar";
        bttnEditarPregunta.CssClass = "btn btn-info bttn-modif-pregunta";
        bttnEditarPregunta.Click += bttnBorrarPregunta;

       // bttnEditarPregunta.OnClientClick = "mostrarEdicionPreguntas()";

        preguntas = datos.mostrarPreguntasDeEncuesta(nomEncuesta);
        Panel1.Controls.Add(bttnEditarPregunta);
        Panel1.Controls.Add(new LiteralControl( "<div id='div-modificacion-preguntas'>"));

        for(int i=0; i<preguntas.Count; i++){
            pregunta = preguntas.ElementAt(i);
            hIdPregunta = new HiddenField();
            hIdPregunta.Value = pregunta.IdPreguntas+"";
            hIdPregunta.ID = "hiddenIdPreguntas";
            Panel1.Controls.Add(new LiteralControl("<div class='div-preguntas'>"
                        + "<div class='div-lbl-pregunta'>"
                        + "   <Label ID='lbl_pregunta' runat='server' Text='Label' class='lbl-modif-pregunta'>"+ pregunta.Pregunta +"</asp:Label>"
                        + "</div>"
                        + "<div class='div-bttn-modif'>"));
            Panel1.Controls.Add(bttnEditarPregunta);
            Panel1.Controls.Add(hIdPregunta);
                        //"   <input type='button' ID='Button5' value='Modificar' class='btn btn-info bttn-modif-pregunta' onclick='mostrarEdicionPreguntas()' />"
            Panel1.Controls.Add(new LiteralControl("</div>"
                        + "<div class='div-bttn-erase'>"
                        + "   <input type='button' ID='Button6' runat='server' value='Borrar' class='btn btn-danger bttn-erase-pregunta' OnClick='bttnBorrarPregunta' />" 
                        + "</div>"
                    + "</div>"));
            
        }
        Panel1.Controls.Add(new LiteralControl("</div>"));
    }

    public void mostrarPreguntas(Panel panel, Object sesion, String tipoAlta) {
        Panel panelSelect = panel;
        MostrarDatos datos = new MostrarDatos();
        int idEncuesta = (int)sesion;
        List<Preguntas> preguntas;
        Preguntas pregunta;
        preguntas = datos.mostrarPreguntasDeEncuesta(idEncuesta);
        String html = "<div id='div-modificacion-preguntas'>";

        for (int i = 0; i < preguntas.Count; i++)
        {
            pregunta = preguntas.ElementAt(i);

            if (tipoAlta.Equals("modif")) {
                html += "<div class='div-preguntas'>"
                            + "<div class='div-lbl-pregunta'>"
                            + "   <Label ID='lbl_pregunta' runat='server' Text='Label' class='lbl-modif-pregunta'>" + pregunta.Pregunta + "</asp:Label>"
                            + "</div>"
                            + "<div class='div-bttn-modif'>"
                            + "   <input type='button' ID='Button5' value='Modificar' class='btn btn-info bttn-modif-pregunta' onclick='mostrarEdicionPreguntas()' />"
                            + "</div>"
                            + "<div class='div-bttn-erase'>"
                            + "   <input type='button' ID='Button6' runat='server' value='Borrar' class='btn btn-danger bttn-erase-pregunta' OnClick='bttnBorrarPregunta' />"
                            + "</div>"
                        + "</div>";
            }
            if (tipoAlta.Equals("alta")){
                html += "<div class='div-preguntas'>"
                    + "<div class='div-lbl-pregunta'>"
                    + "   <Label ID='lbl_pregunta' runat='server' Text='Label' class='lbl-modif-pregunta'>" + pregunta.Pregunta + "</asp:Label>"
                    + "</div>"
                    + "</div>";
            }

        }
        html += "</div>";

        panelSelect.Controls.Add(new LiteralControl(html));
    }

    protected void bttnBorrarPregunta(object sender, EventArgs e) {
        Button13.Text = "Cambiando";
    }

    protected void bttnModificarPregunta(object sender, EventArgs e)
    {
        Button3.Text = hIdPregunta.Value;
        Button6.Text = "Cambiando";
    }

    /****************************************************/

    protected void Button5_Click(object sender, EventArgs e)
    {
        sPregunta = textarea_pregunta.Text;
        sTPregunta = DropDownList2.SelectedValue;
        sRespuesta = getRespuestaPregunta(ta_opciones_respuestas.Text);

        guardarPregunta(Panel2, Session["idEncuesta"], "alta");
    }

    private void guardarPregunta(Panel panel, Object sesion, String tipoAlta) {
        if (sesion != null)
        {
            Preguntas pregunta = new Preguntas();
            Respuestas respuesta = new Respuestas();

            pregunta.IdEncuestas = new Encuestas((int)sesion);
            //pregunta.IdEncuestas = new Encuestas(1);
            pregunta.IdTPregunta = new TPregunta(1);
            pregunta.NumPregunta = 1;
            pregunta.Pregunta = sPregunta;
            pregunta.Activo = 's';

            AEncuestas aencuesta = new AEncuestas(pregunta);
            aencuesta.altaPregunta();

            String[] resp;
            resp = getArrayRespuestas(sRespuesta).ToArray();
            int cont = 0;

            respuesta.Activo = 's';
            respuesta.IdPreguntas.IdPreguntas = aencuesta.getIdPregunta();

            while (cont < resp.Length)
            {
                respuesta.NumRespuesta = cont + 1;
                respuesta.Respuesta = resp[cont];
                aencuesta.altaRespuestas(respuesta);
                cont++;
            }
            mostrarPreguntas(panel, sesion, tipoAlta);
        }
        else
        {
            Label1.Text = "No se ha dado de alta encuesta!!!";
        }
    }

    private List<String> getArrayRespuestas(String r)
    {
        List<String> arrayRespuestas = new List<string>();
        char[] aux = r.ToCharArray();
        int cont = 0;
        Boolean bandera = false;
        String cadena = "";

        while (cont < aux.Length)
        {
            if (aux[cont] == '[')
            {
                bandera = true;
                cont++;
            }
            if (bandera)

            {
                if (aux[cont] != ']' && aux[cont] != null)
                {
                    cadena = cadena + aux[cont];
                }
                else
                {
                    arrayRespuestas.Add(cadena);
                    bandera = false;
                    cadena = "";
                }
            }
            cont++;
        }
        return arrayRespuestas;
    }

    private String getRespuestaPregunta(String opcRespuestas)
    {

        String respuestas = "[";

        String auxRespuestas = opcRespuestas;
        char[] aux = auxRespuestas.ToCharArray();
        int cont = 0;

        while (cont < aux.Length)
        {
            if (aux[cont] == 10)
            {
                respuestas += "][";
            }
            else
            {
                if (aux[cont] != 13)
                    respuestas += aux[cont].ToString();
            }
            cont++;
            if (cont == aux.Length)
            {
                respuestas += "]";
            }
        }
        //ta_opciones_respuestas.Text = ta_opciones_respuestas.Text + " " +respuestas;
        return respuestas;
    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        sPregunta = textarea_pregunta2.Text;
        sTPregunta = DropDownList2.SelectedValue;
        sRespuesta = getRespuestaPregunta(ta_opciones_respuestas2.Text);

        guardarPregunta(Panel1, Session["idEncuesta_modif"],"modif");
    }
}