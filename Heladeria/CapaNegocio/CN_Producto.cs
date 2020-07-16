using Heladeria.CapaDatos;
using Heladeria.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.CapaNegocio
{
    public class CN_Producto
    {
        private CD_Productos objCDProductos = new CD_Productos();

        public List<Producto> listaProductos()
        {

            return objCDProductos.lista();
        }

        public void insertar(Producto prod)
        {

            objCDProductos.insertar(prod);
        }

        public void eliminar(long id)
        {
            objCDProductos.eliminar(id);
        }

        public Producto obtenerProducto(string id)
        {

            return objCDProductos.obtenerProducto(id);
        }

        public void actualizar(Producto prod)
        {
            objCDProductos.actualizar(prod);
        }
    }
}
