using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using capaentidad;
using System.Data;
namespace capadatos
{
    public class D_tbfinal
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_tbfinal> Listartbfinal(string buscar)
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
            
            SqlDataReader LeerFila;
            SqlCommand cmd = new SqlCommand("SP_BUSCARtbfinal", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("BUSCAR", buscar);

            LeerFila = cmd.ExecuteReader();

            List<E_tbfinal> Listar = new List<E_tbfinal>();
            while (LeerFila.Read())
            {
                Listar.Add(new E_tbfinal
                {
                    Idtbfinal = LeerFila.GetInt32(0),
                    Nombre = LeerFila.GetString(1),
                    Apellido = LeerFila.GetString(2),
                    Carrera = LeerFila.GetString(3),
                    Entrada = LeerFila.GetString(4),
                    Salida = LeerFila.GetString(5),
                   
                   
                });
            }
            conexion.Close();
            LeerFila.Close();
            return Listar;
        }

        public void Insertartbfinal(E_tbfinal tbfinal)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARtbfinal", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", tbfinal.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", tbfinal.Apellido);
            cmd.Parameters.AddWithValue("@CARRERA", tbfinal.Carrera);
            cmd.Parameters.AddWithValue("@ENTRADA", tbfinal.Entrada);
            cmd.Parameters.AddWithValue("@SALIDA", tbfinal.Salida);
            

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void Editartbfinal(E_tbfinal tbfinal)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARTBFINAL", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDtbfinal", tbfinal.Idtbfinal);
            cmd.Parameters.AddWithValue("@NOMBRE", tbfinal.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", tbfinal.Apellido);
            cmd.Parameters.AddWithValue("@CARRERA", tbfinal.Carrera);
            cmd.Parameters.AddWithValue("@ENTRADA", tbfinal.Entrada);
            cmd.Parameters.AddWithValue("@SALIDA", tbfinal.Salida);
           
            conexion.Close();

        }

        public void Eliminartbfinal(E_tbfinal tbfinal)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARTBFINAL", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDTBFINAL", tbfinal.Idtbfinal);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }


    }
}
