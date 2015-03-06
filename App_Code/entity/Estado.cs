using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Estado
/// </summary>
public class Estado
{

    private int idEstado;
    private String nombre;
	public Estado()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int IdEstado
    {
        get { return idEstado; }
        set { idEstado = value; }
    }
    public String Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

}