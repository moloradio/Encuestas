using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Encuestas
/// </summary>
public class Encuestas
{

    private int idEncuesta;
    private String nombre;
    private String descripcion;
    private DateTime fecha_alta;
    private DateTime fecha_baja;
    private DateTime fecha_modificacion;
    private char activo;

    private Agencia idAgencia;
    private Users idUsers;
    private TEncuesta idTEncuesta;

	public Encuestas()
	{
        idAgencia = new Agencia();
        idUsers = new Users();
        idTEncuesta = new TEncuesta();
	}

    public Encuestas(int id_encuesta) {
        IdEncuesta = id_encuesta;
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
    public Agencia IdAgencia
    {
        get { return idAgencia; }
        set { idAgencia = value; }
    }
    public Users IdUsers
    {
        get { return idUsers; }
        set { idUsers = value; }
    }
    public TEncuesta IdTEncuesta
    {
        get { return idTEncuesta; }
        set { idTEncuesta = value; }
    }

}