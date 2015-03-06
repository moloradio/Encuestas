using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TPregunta
/// </summary>
public class TPregunta
{

    private int idTPregunta;
    private String nombre;
    private String descripcion;
    private DateTime fecha_alta;

	public TPregunta()
	{
	}
    public TPregunta(int id_TPregunta) {
        idTPregunta = id_TPregunta;
    }

    public int IdTPregunta
    {
        get { return idTPregunta; }
        set { idTPregunta = value; }
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
    public DateTime Fecha_alta
    {
        get { return fecha_alta; }
        set { fecha_alta = value; }
    }
}