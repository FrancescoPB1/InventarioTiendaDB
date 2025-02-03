using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Conexion
{
    public class ConexionDB
    {
        private SqlDataReader lector;
        private SqlConnection conn;
        private SqlCommand cmd;
        public SqlDataReader Lector
        {
            get
            {
                return lector;
            }
        }

        public ConexionDB()
        {
            conn = new SqlConnection("server=.\\SQLEXPRESS;database=CATALOGO_DB;integrated security=true");
            cmd = new SqlCommand();
        }
        public void instruccionSQL(string sentencia)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = sentencia;
            cmd.Connection = conn;
        }
        public void leerDB()
        {
            cmd.Connection=conn;
            try
            {
                conn.Open();
                lector=cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void setearComando(string nombre,object parametro)
        {
            cmd.Parameters.AddWithValue(nombre,parametro);
        }
        public void ejecutarAccion()
        {
            cmd.Connection=conn;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void cerrarConexion()
        {
            if (lector!=null) 
                lector.Close();
            conn.Close();
        }

    }
}
