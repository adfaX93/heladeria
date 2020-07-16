using Heladeria.CapaDatos;
using Heladeria.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.CapaNegocio
{
    public class CN_Empleado
    {
        private CD_Empleados objCDEmpleados = new CD_Empleados();
        public bool login(string usuario, string pass)
        {

            return objCDEmpleados.login(usuario,pass);
        
        }
    }
}
