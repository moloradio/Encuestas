using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for dUsers
/// </summary>
public class dUsers
{

    private int iddUser;
    private String nombre;
    private String aPaterno;
    private String aMaterno;
    private char permisos;
    private DateTime fecha_alta;
    private DateTime fecha_baja;
    private char activo;
    private Users idUsers;

  	public dUsers()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public int IddUser
    {
        get { return iddUser; }
        set { iddUser = value; }
    }
    public String Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public String APaterno
    {
        get { return aPaterno; }
        set { aPaterno = value; }
    }
    public String AMaterno
    {
        get { return aMaterno; }
        set { aMaterno = value; }
    }
    public char Permisos
    {
        get { return permisos; }
        set { permisos = value; }
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
    public Users IdUsers
    {
        get { return idUsers; }
        set { idUsers = value; }
    }

}