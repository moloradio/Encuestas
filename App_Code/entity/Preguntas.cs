using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Preguntas
/// </summary>
public class Preguntas
{

    private int idPreguntas;
    private int numPregunta;
    private String pregunta;
    private DateTime fecha_alta;
    private DateTime fecha_baja;
    private DateTime fecha_modificacion;
    private char activo;

    private Encuestas idEncuestas;
    private TPregunta idTPregunta;

	public Preguntas()
	{
        idEncuestas = new Encuestas();
        idTPregunta = new TPregunta();
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
    public DateTime Fecha_alta
    {
        get { return fecha_alta; }
        set { fecha_alta = value; }
    }
    public DateTime Fecha_baja
    {
        get { return fecha_baja; }
        set { fecha_baja = value; }
    }
    public DateTime Fecha_modificacion
    {
        get { return fecha_modificacion; }
        set { fecha_modificacion = value; }
    }
    public char Activo
    {
        get { return activo; }
        set { activo = value; }
    }
    public Encuestas IdEncuestas
    {
        get { return idEncuestas; }
        set { idEncuestas = value; }
    }
    public TPregunta IdTPregunta
    {
        get { return idTPregunta; }
        set { idTPregunta = value; }
    }

}