using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Clientes
/// </summary>
public class Clientes
{

    private int idClientes;
    private String nombre;
    private String aMaterno;
    private String aPaterno;
    private String calle;
    private String numero_casa;
    private String colonia;
    private String tel_casa;
    private String tel_celular;
    private String email;
    private DateTime fecha_alta;
    private DateTime fecha_baja;
    private char activo;
    
    private Municipio idMunicipio;
    private Estado idEstado;

    public Clientes()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public int IdClientes
    {
        get { return idClientes; }
        set { idClientes = value; }
    }
    public String Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public String AMaterno
    {
        get { return aMaterno; }
        set { aMaterno = value; }
    }
    public String APaterno
    {
        get { return aPaterno; }
        set { aPaterno = value; }
    }
    public String Calle
    {
        get { return calle; }
        set { calle = value; }
    }
    public String Numero_casa
    {
        get { return numero_casa; }
        set { numero_casa = value; }
    }
    public String Colonia
    {
        get { return colonia; }
        set { colonia = value; }
    }
    public String Tel_casa
    {
        get { return tel_casa; }
        set { tel_casa = value; }
    }
    public String Tel_celular
    {
        get { return tel_celular; }
        set { tel_celular = value; }
    }
    public String Email
    {
        get { return email; }
        set { email = value; }
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

    public Municipio IdMunicipio
    {
        get { return idMunicipio; }
        set { idMunicipio = value; }
    }
    public Estado IdEstado
    {
        get { return idEstado; }
        set { idEstado = value; }
    }

}