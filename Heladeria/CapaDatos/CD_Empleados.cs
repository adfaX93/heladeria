using Heladeria.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heladeria.CapaDatos
{
    public class CD_Empleados
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader reader;
        SqlCommand comando = new SqlCommand();

        public bool login(string usuario, string pass)
        {
            bool acceso;
            string sql = "select usuario, contraseña from Empleados where usuario=@usuario and contraseña=@contraseña";

            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = sql;
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@usuario",usuario);
                comando.Parameters.AddWithValue("@contraseña", pass);
                reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    acceso = true;
                }
                else
                {
                    acceso = false;
                }
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error: " + ex.Message);
            }
            return acceso;
            
        }
    }
}
