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
    public class CD_Productos
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader reader;
        SqlCommand comando = new SqlCommand();

        public List<Producto> lista()
        {
            List<Producto> productos = new List<Producto>();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select *  from vista_productos";
            comando.CommandType = CommandType.Text;

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Producto prod = new Producto();

                prod.idProducto = reader.GetInt64(0);
                prod.nombre = reader.GetString(1);
                prod.stock = reader.GetInt64(2);
                prod.precioVenta = reader.GetInt64(3);

                productos.Add(prod);
            }

            conexion.CerrarConexion();

            return productos;
        }
        public void insertar(Producto prod)
        {

            string sql = "insert into  Productos (nombre, stock,precioVenta) values (@nombre, @stock, @precioVenta)";

            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = sql;
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@nombre", prod.nombre);
                comando.Parameters.AddWithValue("@stock", prod.stock);
                comando.Parameters.AddWithValue("@precioVenta", prod.precioVenta);


                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error al insertar:" + ex.Message);
            }

        }
        public void eliminar(long idProducto)
        {

            string sql = "delete from Productos where idProducto=@id";

            try
            {
                insertarHistoricoProductoEliminado(idProducto.ToString());

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = sql;
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@id", idProducto);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error al eliminar:" + ex.Message);
            }

        }
        public Producto obtenerProducto(string idProducto)
        {
            Producto producto= new Producto();

            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select idProducto, nombre, stock, precioVenta  from Productos where idProducto=@idProducto";
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@idProducto", idProducto);

                reader = comando.ExecuteReader();
                comando.Parameters.Clear();

                while (reader.Read())
                {
                    producto.idProducto = reader.GetInt64(0);
                    producto.nombre = reader.GetString(1);
                    producto.stock = reader.GetInt64(2);
                    producto.precioVenta = reader.GetInt64(3);
                }

                conexion.CerrarConexion();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error al obtener el producto:" + ex.Message);
            }


            return producto;
        }
        public void actualizar(Producto producto)
        {
            string sql = "update Productos set nombre=@nombre, stock=@stock, precioVenta=@precio where idProducto=@id";

            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = sql;
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@id", producto.idProducto);
                comando.Parameters.AddWithValue("@nombre",producto.nombre);
                comando.Parameters.AddWithValue("@stock", producto.stock);
                comando.Parameters.AddWithValue("@precio", producto.precioVenta);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error al actualizar:" + ex.Message);
            }

        }
        private void insertarHistoricoProductoEliminado(string idProducto)
        {

            try
            {
                Producto producto = obtenerProducto(idProducto);

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "sp_insert_historico_productos_eliminados";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@nombre", producto.nombre);
                comando.Parameters.AddWithValue("@stock", producto.stock);
                comando.Parameters.AddWithValue("@precioVenta", producto.precioVenta);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                conexion.CerrarConexion();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error al insertar historico de productos eliminados:" + ex.Message);
            }

        }
    }
}
