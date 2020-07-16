using Heladeria.CapaNegocio;
using Heladeria.Clases;
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
    public partial class frmLogin : Form
    {
        private CN_Empleado objCNEmpleados = new CN_Empleado();
        private List<Empleado> listaEmpleados = new List<Empleado>();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validacion())//validacion
            {
                try
                {
                    if(objCNEmpleados.login(txtUser.Text,               txtPassword.Text))
                    {
                        frmSplash P = new frmSplash();
                        P.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña            incorrectos");
                            txtUser.Clear();
                            txtPassword.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error:" +               ex.Message);
                }
                txtUser.Clear();
                txtPassword.Clear();

            }
        }
        private bool validacion()
        {
            bool estado = true;
            if (txtUser.Text == "")
            {
                errorProviderUser.SetError(txtUser, "Ingrese el usuario");
                estado = false;
            }
            else if (txtPassword.Text == "")
            {
                errorProviderPass.SetError(txtPassword, "Ingrese el password");
                estado = false;
            }
            else
            {
                errorProviderUser.SetError(txtUser, "");
                errorProviderPass.SetError(txtPassword, "");
            }

            return estado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
               Application.Exit();
        }
    }
}
