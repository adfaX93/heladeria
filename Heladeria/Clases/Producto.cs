 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Clases
{
    public class Producto
    {
        public Int64 idProducto  { get; set; }
        public string nombre { get; set; }
        public Int64 stock { get; set; }
        public Int64 precioVenta { get; set; }
    }
}
