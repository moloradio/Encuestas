using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Agencia
/// </summary>
public class Agencia
{

    private int idAgencia;
    private String nombre;
    private String direccion;
    private String telefono;
    private DateTime fecha_alta;
    private DateTime fecha_baja;
    private char activo;

    private Estado idEstado;
    private Municipio idMunicipio;

    public Agencia()
    {
    }

    public Agencia(int idAgencia) {
        this.IdAgencia = idAgencia;
    }

    public int IdAgencia
    {
        get { return idAgencia; }
        set { idAgencia = value; }
    }
    public String Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public String Direccion
    {
        get { return direccion; }
        set { direccion = value; }
    }
    public String Telefono
    {
        get { return telefono; }
        set { telefono = value; }
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
    public Estado IdEstado
    {
        get { return idEstado; }
        set { idEstado = value; }
    }
    public Municipio IdMunicipio
    {
        get { return idMunicipio; }
        set { idMunicipio = value; }
    }

}