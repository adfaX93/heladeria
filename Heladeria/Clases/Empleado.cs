using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Clases
{
    public class Empleado
    {
        public Int64 idEmpleado { get; set; }
        public Int64 dni { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string fechaNacimiento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
    }
}
