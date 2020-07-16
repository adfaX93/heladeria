using Heladeria.CapaDatos;
using Heladeria.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.CapaNegocio
{
    public class CN_Sabor
    {
        private CD_Sabores objCDSabores = new CD_Sabores();

        public List<Sabor> listaSabores()
        {

            return objCDSabores.lista();
        }

        public void insertar(Sabor sabor)
        {

            objCDSabores.insertar(sabor);
        }

        public void eliminar(long id)
        {
            objCDSabores.eliminar(id);
        }

        public Sabor obtenerSabor(string id)
        {

            return objCDSabores.obtenerSabor(id);
        }

        public void actualizar(Sabor sabor)
        {
            objCDSabores.actualizar(sabor);
        }
    }
}
