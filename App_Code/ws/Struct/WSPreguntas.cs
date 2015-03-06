using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for WSPreguntas
/// </summary>
public class WSPreguntas
{

    private int idPreguntas;
    private int numPregunta;
    private String pregunta;

    private List<WSRespuestas> respuestas;

    public WSPreguntas()
    {

    }

    public int IdPreguntas
    {
        get { return idPreguntas; }
        set { idPreguntas = value; }
    }
    public int NumPregunta
    {
        get { return numPregunta; }
        set { numPregunta = value; }
    }
    public String Pregunta
    {
        get { return pregunta; }
        set { pregunta = value; }
    }
    public List<WSRespuestas> Respuestas
    {
        get { return respuestas; }
        set { respuestas = value; }
    }
}