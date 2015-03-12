using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Configuration;
using System.ComponentModel;
using Newtonsoft.Json;

/// <summary>
/// Summary description for Test
/// </summary>
[WebService(Namespace = "http://encuestas.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Test : System.Web.Services.WebService {

    private Conexion con;
    private SqlConnection cn;
    private SqlCommand sqlcomm;
    private SqlDataReader reader;

    public Test () {
        con = new Conexion();
        cn = con.getConexion();
    }

   // [WebMethod]
    public int getNumPreguntasDeEncuesta(int idEncuesta) {
        int numPreguntas = 0;
        try
        {
            String consultaSql = "SELECT COUNT(pregunta) FROM Encuestas AS t1, Preguntas AS t2"
		                                                + " WHERE t1.idEncuesta = t2.idEncuestas"
		                                                + " AND t1.idEncuesta = " + idEncuesta;
            sqlcomm = new SqlCommand(consultaSql, cn);
            cn.Open();
            try
            {
                reader = sqlcomm.ExecuteReader();
                while (reader.Read())
                {
                    numPreguntas = (int)reader[0];
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
        return numPreguntas;
    }

    [WebMethod]
    public int[] getIdPreguntasDeEncuesta(int idEncuesta)
    {
        int[] array = new int[getNumPreguntasDeEncuesta(idEncuesta)];
        int i = 0;
        try
        {
            String consultaSql = "SELECT t2.idPreguntas FROM Encuestas AS t1, Preguntas AS t2"
                                                        + " WHERE t1.idEncuesta = t2.idEncuestas"
                                                        + " AND t1.idEncuesta = " + idEncuesta;
            sqlcomm = new SqlCommand(consultaSql, cn);
            cn.Open();
            try
            {
                reader = sqlcomm.ExecuteReader();
                while (reader.Read())
                {
                    array[i] = (int)reader[0];
                    i++;
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
        return array;
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public WSEncuestas getPregunta(int idEncuesta, int idPreguntas)
    {
        Boolean flagEncuesta = true;
        Boolean flagPregunta = true;
        int idPregunta = 0;
        String pregunta = "";
        int auxPregunta = 0;
        int tam = getNumPreguntasDeEncuesta(idEncuesta);
        WSRespuestas respuesta;
        WSPreguntas preguntas = new WSPreguntas();
        WSEncuestas encuestas = new WSEncuestas();
        List<WSRespuestas> listRespuesta = new List<WSRespuestas>();
        List<WSPreguntas> listPregunta = new List<WSPreguntas>();

        try
        {
            String consultaSql = "SELECT t1.nombre,t2.pregunta,t3.numRespuesta,t3.respuesta"
                                         + ",t1.idEncuesta,t1.idAgencia,t1.idTEncuesta"
                                         + ",t2.idPreguntas,t2.idTPregunta,t3.idRespuestas"
                                                        + " FROM Encuestas AS t1, Preguntas AS t2, Respuestas AS t3 "
			                                                    + " WHERE t1.idEncuesta = " + idEncuesta
			                                                    + " AND t1.idEncuesta = t2.idEncuestas"
			                                                 //   + " AND t2.idPreguntas = " + idPregunta
		                                                        + " AND t2.idPreguntas = t3.idPregunta	";
            sqlcomm = new SqlCommand(consultaSql, cn);
            cn.Open();
            try
            {
                reader = sqlcomm.ExecuteReader();
                while (flagPregunta)
                {
                    if (reader.Read())
                    {
                        if (flagEncuesta)
                        {
                            flagEncuesta = false;
                            encuestas.IdEncuesta = (int)reader[4];
                            encuestas.Nombre = (String)reader[0];
                            auxPregunta = (int)reader[7];
                        }
                        if (auxPregunta != (int)reader[7])
                        {
                            preguntas.IdPreguntas = idPregunta;
                            preguntas.Pregunta = pregunta;
                            preguntas.Respuestas = listRespuesta;
                            listPregunta.Add(preguntas);
                            preguntas = new WSPreguntas();
                            listRespuesta = new List<WSRespuestas>();
                        }
                        respuesta = new WSRespuestas();
                        respuesta.IdRespuestas = (int)reader[9];
                        respuesta.NumRespuesta = (int)reader[2];
                        respuesta.Respuesta = (String)reader[3];
                        listRespuesta.Add(respuesta);
                        idPregunta = (int)reader[7];
                        pregunta = (String)reader[1];
                        auxPregunta = (int)reader[7];
                    }
                    else {
                        preguntas.IdPreguntas = idPregunta;
                        preguntas.Pregunta = pregunta;
                        preguntas.Respuestas = listRespuesta;
                        listPregunta.Add(preguntas);
                        flagPregunta = false;
                    }
                }
                encuestas.Preguntas = listPregunta;
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
        //return JsonConvert.SerializeObject(encuestas);
        return encuestas;
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public List<WSEncuestas> getEncuestas() {
        List<WSEncuestas> encuestas = new List<WSEncuestas>();
        WSEncuestas encuesta;
        String consultaSql = "SELECT * FROM Encuestas";
        try
        {
            sqlcomm = new SqlCommand(consultaSql, cn);
            cn.Open();
            try
            {
                reader = sqlcomm.ExecuteReader();
                while(reader.Read()){
                    encuesta = new WSEncuestas();
                    encuesta.IdEncuesta = (int)reader[0];
                    encuesta.Nombre = (String)reader[1];
                    //encuesta.Descripcion = (String)reader[2];
                    encuestas.Add(encuesta);
                }
            }
            catch (SqlException e) {
                Console.WriteLine(e.Message);
            }
            cn.Close();
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }
        return encuestas;
    }

    [WebMethod]
    public int agregarRespuesta(String nombre, String aMaterno, String aPaterno, String email, String tCasa, String tCelular) {
        int rows = 0;
        String consultaSql = "INSERT INTO Clientes"
                                           +"(nombre"
                                           +",aMaterno"
                                           +",aPaterno"
                                           +",tel_casa"
                                           +",tel_celular"
                                           +",email)"
                                     +"VALUES"
                                           +"('"+ nombre+"'"
                                           +",'"+ aMaterno+"'"
                                           +",'"+ aPaterno+"'"
                                           +",'"+ tCasa+"'"
                                           +",'"+ tCelular+"'"
                                           +",'"+ email +"')";
        try
        {
            sqlcomm = new SqlCommand(consultaSql, cn);
            cn.Open();
            try
            {
                rows = sqlcomm.ExecuteNonQuery();
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
        return rows;
    }

}

   /* [WebMethod]
    public List<Respuestas> getPregunta(int idEncuesta, int idPregunta)
    {
        int tam = getNumPreguntasDeEncuesta(idEncuesta);
        Respuestas respuesta;
        List<Respuestas> listRespuesta = new List<Respuestas>();

        try
        {
            String consultaSql = "SELECT t1.nombre,t2.pregunta,t3.numRespuesta,t3.respuesta"
                                         + ",t1.idEncuesta,t1.idAgencia,t1.idTEncuesta"
                                         + ",t2.idPreguntas,t2.idTPregunta,t3.idRespuestas"
                                                        + " FROM Encuestas AS t1, Preguntas AS t2, Respuestas AS t3 "
			                                                    + " WHERE t1.idEncuesta = " + idEncuesta
			                                                    + " AND t1.idEncuesta = t2.idEncuestas"
			                                                    + " AND t2.idPreguntas = " + idPregunta
		                                                        + " AND t2.idPreguntas = t3.idPregunta	";
            sqlcomm = new SqlCommand(consultaSql, cn);
            cn.Open();
            try
            {
                reader = sqlcomm.ExecuteReader();
                while (reader.Read())
                {
                    respuesta = new Respuestas();
                    respuesta.IdPreguntas.IdEncuestas.Nombre = (String)reader[0];
                    respuesta.IdPreguntas.Pregunta = (String)reader[1];
                    respuesta.NumRespuesta = (int)reader[2];
                    respuesta.Respuesta = (String)reader[3];
                    respuesta.IdPreguntas.IdEncuestas.IdEncuesta = (int)reader[4];
                    respuesta.IdPreguntas.IdEncuestas.IdAgencia.IdAgencia = (int)reader[5];
                    respuesta.IdPreguntas.IdEncuestas.IdTEncuesta.IdTEncuesta = (int)reader[6];
                    respuesta.IdPreguntas.IdPreguntas = (int)reader[7];
                    respuesta.IdPreguntas.IdTPregunta.IdTPregunta = (int)reader[8];
                    respuesta.IdRespuesta = (int)reader[9];
                    listRespuesta.Add(respuesta);
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
        return listRespuesta;
    }

}*/
