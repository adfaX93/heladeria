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
    public partial class frmSabores : Form
    {
        private string idSabor = string.Empty;
        private CN_Sabor objCNSabores = new CN_Sabor();
        private List<Sabor> listaSabores = new List<Sabor>();

        public frmSabores()
        {
            InitializeComponent();
        }

        #region eventos del formulario
        private void btnSalirSabor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSabores_Load(object sender, EventArgs e)
        {
            cargarListaSabores();
            statusFecha.Text= "Fecha: " + DateTime.Now.ToShortDateString();
        }

        private void btnBuscarSabor_Click(object sender, EventArgs e)
        {
            var filtrolistaSabor = from Sabor in listaSabores
                                      where Sabor.nombre.ToUpper().Contains(txtFiltroSabor.Text.ToUpper())
                                      select Sabor;

            dataGridViewSabor.DataSource = filtrolistaSabor.ToList();
        }

        private void btnGuardarSabor_Click(object sender, EventArgs e)
        {
            if (validacion())//validacion
            {
                Sabor sabor = new Sabor();
                sabor.nombre = txtNombreSabor.Text;

                try
                {
                    if (string.IsNullOrEmpty(idSabor))
                    {
                        DialogResult result = MessageBox.Show("Desea guardar nuevo sabor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            objCNSabores.insertar(sabor);
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Desea actualizar sabor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            sabor.idSabor = long.Parse(idSabor);
                            objCNSabores.actualizar(sabor);
                        }
                    }
                    cargarListaSabores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error:" + ex.Message);
                }
            }
        }

        private void btnEditarSabor_Click(object sender, EventArgs e)
        {
            idSabor = obtenerId().ToString();

            //validacion
            if (!string.IsNullOrEmpty(idSabor))
            {
                try
                {
                    //cargar datos en el formulario
                    Sabor sabor = objCNSabores.obtenerSabor(idSabor);
                    txtNombreSabor.Text = sabor.nombre;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila que quiere actualizar");
            }
        }

        private void btnEliminarSabor_Click(object sender, EventArgs e)
        {
            string idSabor = obtenerId().ToString();

            DialogResult result = MessageBox.Show("Desea eliminar el sabor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //validacion
                if (!string.IsNullOrEmpty(idSabor))
                {
                    //eliminar

                    objCNSabores.eliminar(long.Parse(idSabor));
                    cargarListaSabores();
                }
                else
                {
                    MessageBox.Show("Seleccione la fila que quiere eliminar");
                }
            }
        }

        private void btnExcelSabores_Click(object sender, EventArgs e)
        {
            exportarExcel();
        }
        #endregion

        #region utilidad
        private Int64? obtenerId()
        {
            try
            {

                return long.Parse(dataGridViewSabor.Rows[dataGridViewSabor.CurrentRow.Index].Cells[0].Value.ToString());

            }
            catch (Exception)
            {

            }

            return null;
        }
        private void cargarListaSabores()
        {
            listaSabores = objCNSabores.listaSabores();
            dataGridViewSabor.DataSource = listaSabores;
        }
        private bool validacion()
        {
            bool estado = true;
            if (txtNombreSabor.Text == "")
            {
                errorProviderNombreSabor.SetError(txtNombreSabor, "Ingrese el nombre del sabor");
                estado = false;
            }
            else
            {
                errorProviderNombreSabor.SetError(txtNombreSabor, "");
            }

            return estado;
        }
        private void exportarExcel()
        {
            try
            {
                var excelApp = new Microsoft.Office.Interop.Excel.Application();

                excelApp.Visible = true;

                excelApp.Workbooks.Add(); //creamos un libro 

                Microsoft.Office.Interop.Excel._Worksheet worksheet = excelApp.ActiveSheet; //crear una hoja

                //encabezados
                worksheet.Cells[3, "A"] = "Nombres";
            
                //titulo
                worksheet.Cells[1, "A"] = "Listado de Sabores";
                worksheet.Range["A1", "C1"].Merge(); //combinar
                worksheet.Range["A1", "C1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //centrar

                worksheet.Range["A1", "C1"].Font.Bold = true;
                worksheet.Range["A1", "C1"].Font.Size = 20;


                var row = 3;
                foreach (var sabor in listaSabores)
                {
                    row++;
                    worksheet.Cells[row, "A"] = sabor.nombre;
                }

                worksheet.Columns[1].AutoFit();
                worksheet.Columns[2].AutoFit();
                worksheet.Columns[3].AutoFit();

                //Aplicando un autoformato a la tabla
                worksheet.Range["A3", "C" + row].AutoFormat(Microsoft.Office.Interop.Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrío un error, " + ex.Message);
                //insertar en una tabla los errores, para hacer seguimiento
            }

        }
        #endregion
    }
}
