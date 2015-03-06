using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for MostrarDatos
/// </summary>
public class MostrarDatos
{
    private Conexion con;
    private SqlConnection cn;
    private SqlCommand sqlcomm;
    private SqlDataReader reader;
    
    private Agencia agencia;
    private List<Agencia> agencias;
    
    private TEncuesta tencuesta;
    private List<TEncuesta> tencuestas;

    private Encuestas encuesta;
    private List<Encuestas> encuestas;
	
    public MostrarDatos()
	{
        con = new Conexion();
        cn = con.getConexion();
	}

    public List<Agencia> mostrarAgencias() {
        String cadenaSql = "SELECT * FROM agencia";
        agencias = new List<Agencia>();
        try
        {
            sqlcomm = new SqlCommand(cadenaSql,cn);
            cn.Open();
            try
            {
                reader = sqlcomm.ExecuteReader();
                while(reader.Read()){
                    agencia = new Agencia();
                    agencia.IdAgencia = (int)reader[0];
                    agencia.Nombre = (String)reader[1];
                    agencia.Direccion = (String)reader[2];
                    agencia.Telefono = (String)reader[3];
                    agencia.Fecha_alta = (DateTime)reader[4];
                    agencia.Fecha_baja = (DateTime)reader[5];
                    //agencia.Activo = (Char)reader[6];
                    agencia.IdEstado = new Estado();
                    agencia.IdMunicipio = new Municipio();
                    agencias.Add(agencia);
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

        return agencias;
    }

    public List<TEncuesta> mostrarTEncuestas()
    {
        String cadenaSql = "SELECT * FROM TEncuesta";
        tencuestas = new List<TEncuesta>();
        try
        {
            sqlcomm = new SqlCommand(cadenaSql, cn);
            cn.Open();
            try
            {
                reader = sqlcomm.ExecuteReader();
                while (reader.Read())
                {
                    tencuesta = new TEncuesta();
                    tencuesta.IdTEncuesta = (int)reader[0];
                    tencuesta.Nombre = (String)reader[1];
                    tencuesta.Descripcion = (String)reader[2];
                    tencuesta.Fecha_alta = (DateTime)reader[3];
                    //tencuesta.Fecha_baja = (DateTime)reader[4];
                    tencuestas.Add(tencuesta);
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

        return tencuestas;
    }

    public List<Encuestas> mostrarEncuestas()
    {
        String cadenaSql = "SELECT * FROM Encuestas";
        encuestas = new List<Encuestas>();
        try
        {
            sqlcomm = new SqlCommand(cadenaSql, cn);
            cn.Open();
            try
            {
                reader = sqlcomm.ExecuteReader();
                while (reader.Read())
                {
                    encuesta = new Encuestas();
                    encuesta.IdEncuesta = (int)reader[0];
                    encuesta.Nombre = (String)reader[1];
                    //encuesta.Descripcion = (String)reader[2];
                    encuestas.Add(encuesta);
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

        return encuestas;
    }

    public Encuestas mostrarEncuesta(String nomEncuesta) {
        Encuestas encuesta = new Encuestas();
        String cadenaSql = "SELECT idEncuesta,nombre,descripcion,idAgencia,idTEncuesta "
                                        +"FROM Encuestas WHERE nombre = '"+ nomEncuesta +"'";
        try
        {
            sqlcomm = new SqlCommand(cadenaSql, cn);
            cn.Open();
            try
            {
                reader = sqlcomm.ExecuteReader();
                while (reader.Read())
                {
                    encuesta.IdEncuesta = (int)reader[0];
                    encuesta.Nombre = (String)reader[1];
                    encuesta.Descripcion = (String)reader[2];
                    encuesta.IdAgencia = new Agencia((int)reader[3]);
                    encuesta.IdTEncuesta = new TEncuesta((int)reader[4]);
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
        return encuesta;
    }

    public List<Preguntas> mostrarPreguntasDeEncuesta(String nomEncuesta) {
        List<Preguntas> preguntas = new List<Preguntas>();
        Preguntas pregunta;
        String cadenaSql = "SELECT * FROM Preguntas "
	                                +"WHERE idEncuestas = (SELECT idEncuesta FROM Encuestas "
										                                +"WHERE nombre = '"+ nomEncuesta +"')";
        try
        {
            sqlcomm = new SqlCommand(cadenaSql, cn);
            cn.Open();
            try
            {
                reader = sqlcomm.ExecuteReader();
                while (reader.Read())
                {
                    pregunta = new Preguntas();
                    pregunta.IdPreguntas = (int)reader[0];
                    pregunta.NumPregunta = (int)reader[1];
                    pregunta.Pregunta = (String)reader[2];
                    pregunta.Fecha_alta = (DateTime)reader[3];
                    preguntas.Add(pregunta);
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

        return preguntas;
    }

    public List<Preguntas> mostrarPreguntasDeEncuesta(int idEncuesta)
    {
        List<Preguntas> preguntas = new List<Preguntas>();
        Preguntas pregunta;
        String cadenaSql = "SELECT * FROM Preguntas "
                                    + "WHERE idEncuestas = "+ idEncuesta +"";
        try
        {
            sqlcomm = new SqlCommand(cadenaSql, cn);
            cn.Open();
            try
            {
                reader = sqlcomm.ExecuteReader();
                while (reader.Read())
                {
                    pregunta = new Preguntas();
                    pregunta.IdPreguntas = (int)reader[0];
                    pregunta.NumPregunta = (int)reader[1];
                    pregunta.Pregunta = (String)reader[2];
                    pregunta.Fecha_alta = (DateTime)reader[3];
                    preguntas.Add(pregunta);
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

        return preguntas;
    }

    public List<Clientes> mostrarClientes() { 
        List<Clientes> clientes = new List<Clientes>();
        Clientes cliente = null;
        String cadenaSql = "SELECT * FROM Clientes";
        try
        {
            sqlcomm = new SqlCommand(cadenaSql, cn);
            cn.Open();
            try
            {
                reader = sqlcomm.ExecuteReader();
                while (reader.Read())
                {
                    cliente = new Clientes();
                    cliente.IdClientes = (int)reader[0];
                    cliente.Nombre = (String)reader[1];
                    cliente.AMaterno = (String)reader[2];
                    cliente.APaterno = (String)reader[3];
                    cliente.Tel_casa = (String)reader[7];
                    cliente.Tel_celular = (String)reader[8];
                    cliente.Email = (String)reader[9];
                    clientes.Add(cliente);
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

        return clientes;
    }
}