using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Municipio
/// </summary>
public class Municipio
{

    private int idMunicipio;
    private String nombre;

    private Estado idEstado;

	public Municipio()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int IdMunicipio
    {
        get { return idMunicipio; }
        set { idMunicipio = value; }
    }
    public String Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public Estado IdEstado
    {
        get { return idEstado; }
        set { idEstado = value; }
    }
}