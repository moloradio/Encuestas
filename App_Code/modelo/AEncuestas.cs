using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for AEncuestas
/// </summary>
public class AEncuestas
{

    private Conexion con;
    private Encuestas encuesta;
    private Preguntas pregunta;
    private SqlConnection cn;
    private SqlCommand sqlcomm;
    private SqlDataReader reader;

	public AEncuestas(Encuestas encuestas)
	{
        con = new Conexion();
        cn = con.getConexion();
        encuesta = encuestas;
	}

    public AEncuestas(Preguntas preguntas)
    {
        con = new Conexion();
        cn = con.getConexion();
        pregunta = preguntas;
    }

    public void altaNomEncuesta(String idAgencia, String idTEncuesta) {
        try
        {
            String sIdAgencia = "(SELECT idAgencia FROM Agencia WHERE nombre = '"+ idAgencia +"')";
            String sIdTEncuesta = "(SELECT idTEncuesta FROM TEncuesta WHERE nombre = '"+ idTEncuesta +"')";
            String consultaSql = "INSERT INTO Encuestas (nombre,descripcion,fecha_alta,fecha_modificacion,activo,idAgencia,idUsers,idTEncuesta)"
                                    +"VALUES ('" + encuesta.Nombre + "','" + encuesta.Descripcion + "',GETDATE(),GETDATE(),'s'," + sIdAgencia + ",1," + sIdTEncuesta + ")";
            sqlcomm = new SqlCommand(consultaSql, cn);
            cn.Open();
            try
            {
                sqlcomm.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            cn.Close();
        }
        catch (SqlException e) {
            Console.WriteLine(e.Message);
        }
    }

    public void altaPregunta() {
        try
        {
            String consultaSql = "INSERT INTO Preguntas (numPregunta,pregunta,fecha_alta"
                                                        + ",activo,idEncuestas,idTPregunta)"
                                                + "VALUES"
                                                    + "(" + pregunta.NumPregunta + ",'" 
                                                    + pregunta.Pregunta + "'"+ ",GETDATE(),'"+pregunta.Activo+"' ,"
                                                    +pregunta.IdEncuestas.IdEncuesta+" ,"+pregunta.IdTPregunta.IdTPregunta+")";
            sqlcomm = new SqlCommand(consultaSql, cn);
            cn.Open();
            try
            {
                sqlcomm.ExecuteNonQuery();
            }
            catch (SqlException e) {
                Console.WriteLine(e.Message);
            }
            cn.Close();

        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }

    public void altaRespuestas(Respuestas respuesta) {
        try
        {
            String consultaSql = "INSERT INTO Respuestas (numRespuesta,respuesta,activo,idPregunta)"
                                                + "VALUES"
                                                    + "(" + respuesta.NumRespuesta + ",'"
                                                    + respuesta.Respuesta + "','" + respuesta.Activo + "' ,"
                                                    + respuesta.IdPreguntas.IdPreguntas +")";
            sqlcomm = new SqlCommand(consultaSql, cn);
            cn.Open();
            try
            {
                sqlcomm.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            cn.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public int getIdEncuesta()
    {

        int idEncuesta = 0;

        try
        {
            String consultaSql = "SELECT idEncuesta FROM Encuestas WHERE nombre = '" + encuesta.Nombre + "'";
            sqlcomm = new SqlCommand(consultaSql, cn);
            cn.Open();
            try
            {
                reader = sqlcomm.ExecuteReader();
                while (reader.Read())
                {
                    idEncuesta = (int)reader[0];
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            cn.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return idEncuesta;
    }

    public int getIdPregunta()
    {
        int idPregunta = 0;

        try
        {
            String consultaSql = "SELECT idPreguntas FROM Preguntas WHERE pregunta = '"
                                                                    + pregunta.Pregunta + "'"
                                                                    + " AND "
                                                                    + " idEncuestas = " 
                                                                    + pregunta.IdEncuestas.IdEncuesta;
            sqlcomm = new SqlCommand(consultaSql, cn);
            cn.Open();
            try
            {
                reader = sqlcomm.ExecuteReader();
                while (reader.Read())
                {
                    idPregunta = (int)reader[0];
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            cn.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return idPregunta;
    }
}