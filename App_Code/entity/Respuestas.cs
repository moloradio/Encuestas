using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Respuestas
/// </summary>
public class Respuestas
{

    private int idRespuesta;
    private int numRespuesta;
    private String respuesta;
    private char activo;

    private Preguntas idPreguntas;

	public Respuestas()
	{
        idPreguntas = new Preguntas();
	}
    public int IdRespuesta
    {
        get { return idRespuesta; }
        set { idRespuesta = value; }
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
    public char Activo
    {
        get { return activo; }
        set { activo = value; }
    }
    public Preguntas IdPreguntas
    {
        get { return idPreguntas; }
        set { idPreguntas = value; }
    }

}