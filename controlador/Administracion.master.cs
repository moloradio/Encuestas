using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vista_Administracion : System.Web.UI.MasterPage
{

    private String sPregunta;
    private String sTPregunta;
    private String sRespuesta;

    private System.Web.UI.Page currentContentPage = new System.Web.UI.Page();

    public void pageInstance(Page pagina) {
        //currentContentPage = pagina;
        //currentContentPage.mostrarPreguntas();
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    

    
}
