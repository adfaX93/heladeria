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
    public partial class frmProductos : Form
    {
        private string idProducto=string.Empty;
        private CN_Producto objCNProductos = new CN_Producto();
        private List<Producto> listaProductos = new List<Producto>();

        public frmProductos()
        {
            InitializeComponent();
        }

        #region eventos del formulario
        private void btnSalirProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /**
         * Metodo para guardar productos
         **/
        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (validacion())//validacion
            {
                Producto producto = new Producto();
                producto.nombre = txtNombreProducto.Text;
                producto.stock = long.Parse(txtStockProducto.Text);
                producto.precioVenta = long.Parse(txtPrecioProducto.Text);

                try
                {
                    if (string.IsNullOrEmpty(idProducto))
                    {
                       DialogResult result = MessageBox.Show("Desea guardar nuevo producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            objCNProductos.insertar(producto);
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Desea actualizar el producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            producto.idProducto = long.Parse(idProducto);
                            objCNProductos.actualizar(producto);
                        }
                    }
                    cargarListaProductos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error:" + ex.Message);
                }
            }
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            idProducto = obtenerId().ToString();

            //validacion
            if (!string.IsNullOrEmpty(idProducto))
            {
                try
                {
                    //cargar datos en el formulario
                    Producto producto = objCNProductos.obtenerProducto(idProducto);

                    txtNombreProducto.Text = producto.nombre;
                    txtStockProducto.Text = producto.stock.ToString();
                    txtPrecioProducto.Text = producto.precioVenta.ToString();
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

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            string idProducto = obtenerId().ToString();

            DialogResult result = MessageBox.Show("Desea eliminar el producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //validacion
                if (!string.IsNullOrEmpty(idProducto))
                {
                    //eliminar

                    objCNProductos.eliminar(long.Parse(idProducto));
                    cargarListaProductos();
                }
                else
                {
                    MessageBox.Show("Seleccione la fila que quiere eliminar");
                }
            }
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            cargarListaProductos();
            statusFecha.Text="Fecha: " + DateTime.Now.ToShortDateString();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            var filtrolistaProducto = from productos in listaProductos
                                     where productos.nombre.ToUpper().Contains(txtFiltroProducto.Text.ToUpper())
                                     select productos;

            dataGridViewProducto.DataSource = filtrolistaProducto.ToList();
        }

        private void btnExcelProductos_Click(object sender, EventArgs e)
        {
            exportarExcel();
        }
        #endregion

        #region utilidad
        private Int64? obtenerId()
        {
            try
            {

                return long.Parse(dataGridViewProducto.Rows[dataGridViewProducto.CurrentRow.Index].Cells[0].Value.ToString());

            }
            catch (Exception)
            {

            }

            return null;
        }
        private bool validacion()
        {
            bool estado = true;
            if (txtNombreProducto.Text == "")
            {
                errorProviderNombreProducto.SetError(txtNombreProducto, "Ingrese el nombre del producto");
                estado = false;
            }
            else if (txtStockProducto.Text == "")
            {
                errorProviderStockProducto.SetError(txtStockProducto, "Ingrese el stock del producto");
                estado = false;
            }
            else if (txtPrecioProducto.Text == "")
            {
                errorProviderPrecioProducto.SetError(txtPrecioProducto, "Ingrese el precio del producto");
                estado = false;
            }
            else
            {
                errorProviderNombreProducto.SetError(txtNombreProducto, "");
                errorProviderStockProducto.SetError(txtStockProducto, "");
                errorProviderPrecioProducto.SetError(txtPrecioProducto, "");
            }

            return estado;
        }
        private void cargarListaProductos()
        {
            listaProductos = objCNProductos.listaProductos();
            dataGridViewProducto.DataSource = listaProductos;
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
                worksheet.Cells[3, "A"] = "Nombre";
                worksheet.Cells[3, "B"] = "Stock";
                worksheet.Cells[3, "C"] = "Precio";


                //titulo
                worksheet.Cells[1, "A"] = "Listado de Productos";
                worksheet.Range["A1", "C1"].Merge(); //combinar
                worksheet.Range["A1", "C1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //centrar

                worksheet.Range["A1", "C1"].Font.Bold = true;
                worksheet.Range["A1", "C1"].Font.Size = 20;


                var row = 3;
                foreach (var producto in listaProductos)
                {
                    row++;
                    worksheet.Cells[row, "A"] = producto.nombre;
                    worksheet.Cells[row, "B"] = producto.stock;
                    worksheet.Cells[row, "C"] = producto.precioVenta;
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
