using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heladeria
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos P = new frmProductos();
            P.Show();
        }

        private void btnSabores_Click(object sender, EventArgs e)
        {
            frmSabores S = new frmSabores();
            S.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas V = new frmVentas();
            V.Show();
        }

        private void frmMenu_Load_1(object sender, EventArgs e)
        {
            statusFecha.Text="Fecha: " + DateTime.Now.ToShortDateString();
        }
    }
}
