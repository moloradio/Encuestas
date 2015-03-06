using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for WSRespuestas
/// </summary>
public class WSRespuestas
{

    private int idRespuestas;
    private int numRespuesta;
    private String respuesta;

    public WSRespuestas()
    {

    }

    public int IdRespuestas
    {
        get { return idRespuestas; }
        set { idRespuestas = value; }
    }
    public int NumRespuesta
    {
        get { return numRespuesta; }
        set { numRespuesta = value; }
    }
    public String Respuesta
    {
        get { return respuesta; }
        set { respuesta = value; }
    }
}