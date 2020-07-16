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
    public partial class frmSplash : Form
    {
        Timer timer; //DECLARMOS EL OBJETO TIMER
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Shown(object sender, EventArgs e)
        {
            timer = new Timer();

            //SE ESTABLECE EL INTERVALO DEL TIEMPO EN 3 SEGUNDOS
            timer.Interval = 3000;

            timer.Start();//arranca el temporizador

            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();//se detiene el temporizador
            //mostrar el formulario principal

            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();

            //ocultar el formulario
            this.Hide();
        }
    }
}
