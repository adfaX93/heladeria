using Heladeria.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.CapaDatos
{
    public class CD_Sabores
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader reader;
        SqlCommand comando = new SqlCommand();

        public List<Sabor> lista()
        {
            List<Sabor> sabores = new List<Sabor>();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select *  from vista_sabores";
            comando.CommandType = CommandType.Text;

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Sabor sabor = new Sabor();

                sabor.idSabor= reader.GetInt64(0);
                sabor.nombre = reader.GetString(1);

                sabores.Add(sabor);
            }

            conexion.CerrarConexion();

            return sabores;
        }
        public void insertar(Sabor sabor)
        {

            string sql = "insert into  Sabores (nombre) values (@nombre)";

            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = sql;
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@nombre", sabor.nombre);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error al insertar:" + ex.Message);
            }

        }
        public void eliminar(long idSabor)
        {

            string sql = "delete from Sabores where idSabor=@id";

            try
            {
                insertarHistoricoSaborEliminado(idSabor.ToString());
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = sql;
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@id", idSabor);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error al eliminar:" + ex.Message);
            }

        }
        public Sabor obtenerSabor(string idSabor)
        {
            Sabor sabor = new Sabor();

            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select idSabor, nombre from Sabores where idSabor=@id";
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@id", idSabor);

                reader = comando.ExecuteReader();
                comando.Parameters.Clear();

                while (reader.Read())
                {
                    sabor.idSabor = reader.GetInt64(0);
                    sabor.nombre = reader.GetString(1);
                }

                conexion.CerrarConexion();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error al obtener el sabor:" + ex.Message);
            }


            return sabor;
        }
        public void actualizar(Sabor sabor)
        {
            string sql = "update Sabores set nombre=@nombre where idSabor=@id";

            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = sql;
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@id", sabor.idSabor);
                comando.Parameters.AddWithValue("@nombre", sabor.nombre);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error al actualizar:" + ex.Message);
            }

        }
        private void insertarHistoricoSaborEliminado(string idSabor)
        {

            try
            {
                Sabor sabor = obtenerSabor(idSabor);

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "sp_insert_historico_sabores_eliminados";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Nombre", sabor.nombre);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                conexion.CerrarConexion();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error al insertar historico de sabores eliminados:" + ex.Message);
            }

        }
    }
}
