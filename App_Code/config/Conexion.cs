using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for conexion
/// </summary>
public class Conexion
{

    private SqlConnection cn;
    private String connectionString;

	public Conexion()
	{
        try
        {
            connectionString = ConfigurationManager.ConnectionStrings["encuestasConnectionString"].ConnectionString;
            cn = new SqlConnection(connectionString);
        }
        catch (Exception e) {
            Console.Write(e.Message);
        }
	}

    public SqlConnection getConexion() {
        return cn;
    }

}