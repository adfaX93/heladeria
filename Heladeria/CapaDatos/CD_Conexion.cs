using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.CapaDatos
{
    public class CD_Conexion
    {
        private SqlConnection sqlConexion = new SqlConnection("Data Source=laptop-ka4fma0q;Initial Catalog=heladeria;Persist Security Info=True;User ID=sa;Password=a4510652f");


        public SqlConnection AbrirConexion()
        {
            if (sqlConexion.State == ConnectionState.Closed)
                sqlConexion.Open();
            return sqlConexion;
        }


        public SqlConnection CerrarConexion()
        {
            if (sqlConexion.State == ConnectionState.Open)
                sqlConexion.Close();
            return sqlConexion;
        }
    }
}
