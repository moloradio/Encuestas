using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TEncuesta
/// </summary>
public class TEncuesta
{

    private int idTEncuesta;
    private String nombre;
    private String descripcion;
    private DateTime fecha_alta;
    private DateTime fecha_baja;
    private char activo;

	public TEncuesta()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public TEncuesta(int idTEncuesta) {
        this.IdTEncuesta = idTEncuesta;
    }

    public int IdTEncuesta
    {
        get { return idTEncuesta; }
        set { idTEncuesta = value; }
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
    public DateTime Fecha_baja
    {
        get { return fecha_baja; }
        set { fecha_baja = value; }
    }
    public char Activo
    {
        get { return activo; }
        set { activo = value; }
    }


}