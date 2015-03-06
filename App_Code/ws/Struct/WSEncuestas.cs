using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for WSEncuestas
/// </summary>
public class WSEncuestas
{

    private int idEncuesta;
    private String nombre;
    private String descripcion;
    private char activo;

    private List<WSPreguntas> preguntas;

	public WSEncuestas()
	{
		
	}
    public int IdEncuesta
    { 
        get { return idEncuesta; }
        set { idEncuesta = value; }
    }
    public String Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public String Descripcion
    {
        get { return descripcion; }
        set { descripcion = value; }
    }
    public char Activo
    {
        get { return activo; }
        set { activo = value; }
    }
    public List<WSPreguntas> Preguntas
    {
        get { return preguntas; }
        set { preguntas = value; }
    }
}