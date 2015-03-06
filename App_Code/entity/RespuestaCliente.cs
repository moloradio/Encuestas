using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RespuestaCliente
/// </summary>
public class RespuestaCliente
{

    private int idRespuestaCliente;
    private String respuesta;
    private DateTime fecha_alta;
    private char activo;

    private Encuestas idEncuesta;
    private Preguntas idPreguntas;

	public RespuestaCliente()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int IdRespuestaCliente
    {
        get { return idRespuestaCliente; }
        set { idRespuestaCliente = value; }
    }
    public String Respuesta
    {
        get { return respuesta; }
        set { respuesta = value; }
    }
    public DateTime Fecha_alta
    {
        get { return fecha_alta; }
        set { fecha_alta = value; }
    }
    public char Activo
    {
        get { return activo; }
        set { activo = value; }
    }
    public Encuestas IdEncuesta
    {
        get { return idEncuesta; }
        set { idEncuesta = value; }
    }
    public Preguntas IdPreguntas
    {
        get { return idPreguntas; }
        set { idPreguntas = value; }
    }

}