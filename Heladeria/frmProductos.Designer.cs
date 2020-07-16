namespace Heladeria
{
    partial class frmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtStockProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.btnSalirProducto = new System.Windows.Forms.Button();
            this.dataGridViewProducto = new System.Windows.Forms.DataGridView();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiltroProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProviderNombreProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderStockProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPrecioProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExcelProductos = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusFecha = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombreProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStockProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrecioProducto)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStockProducto
            // 
            this.txtStockProducto.Location = new System.Drawing.Point(92, 95);
            this.txtStockProducto.Name = "txtStockProducto";
            this.txtStockProducto.Size = new System.Drawing.Size(72, 20);
            this.txtStockProducto.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stock:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(174, 51);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(298, 20);
            this.txtNombreProducto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "PRODUCTOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precio :";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(322, 95);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(124, 20);
            this.txtPrecioProducto.TabIndex = 11;
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Location = new System.Drawing.Point(36, 143);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarProducto.TabIndex = 13;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Location = new System.Drawing.Point(36, 306);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEditarProducto.TabIndex = 14;
            this.btnEditarProducto.Text = "Editar";
            this.btnEditarProducto.UseVisualStyleBackColor = true;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // btnSalirProducto
            // 
            this.btnSalirProducto.Location = new System.Drawing.Point(198, 306);
            this.btnSalirProducto.Name = "btnSalirProducto";
            this.btnSalirProducto.Size = new System.Drawing.Size(75, 23);
            this.btnSalirProducto.TabIndex = 15;
            this.btnSalirProducto.Text = "Salir";
            this.btnSalirProducto.UseVisualStyleBackColor = true;
            this.btnSalirProducto.Click += new System.EventHandler(this.btnSalirProducto_Click);
            // 
            // dataGridViewProducto
            // 
            this.dataGridViewProducto.AllowUserToAddRows = false;
            this.dataGridViewProducto.AllowUserToDeleteRows = false;
            this.dataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducto.Location = new System.Drawing.Point(36, 335);
            this.dataGridViewProducto.Name = "dataGridViewProducto";
            this.dataGridViewProducto.ReadOnly = true;
            this.dataGridViewProducto.Size = new System.Drawing.Size(453, 280);
            this.dataGridViewProducto.TabIndex = 16;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(117, 306);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProducto.TabIndex = 17;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(432, 244);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProducto.TabIndex = 25;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Nombre:";
            // 
            // txtFiltroProducto
            // 
            this.txtFiltroProducto.Location = new System.Drawing.Point(95, 247);
            this.txtFiltroProducto.Name = "txtFiltroProducto";
            this.txtFiltroProducto.Size = new System.Drawing.Size(301, 20);
            this.txtFiltroProducto.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Buscar producto";
            // 
            // errorProviderNombreProducto
            // 
            this.errorProviderNombreProducto.ContainerControl = this;
            // 
            // errorProviderStockProducto
            // 
            this.errorProviderStockProducto.ContainerControl = this;
            // 
            // errorProviderPrecioProducto
            // 
            this.errorProviderPrecioProducto.ContainerControl = this;
            // 
            // btnExcelProductos
            // 
            this.btnExcelProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelProductos.Location = new System.Drawing.Point(432, 273);
            this.btnExcelProductos.Name = "btnExcelProductos";
            this.btnExcelProductos.Size = new System.Drawing.Size(75, 23);
            this.btnExcelProductos.TabIndex = 26;
            this.btnExcelProductos.Text = "Excel";
            this.btnExcelProductos.UseVisualStyleBackColor = true;
            this.btnExcelProductos.Click += new System.EventHandler(this.btnExcelProductos_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusFecha});
            this.statusStrip1.Location = new System.Drawing.Point(0, 619);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(526, 22);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusFecha
            // 
            this.statusFecha.Name = "statusFecha";
            this.statusFecha.Size = new System.Drawing.Size(41, 17);
            this.statusFecha.Text = "Fecha:";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 641);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnExcelProductos);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFiltroProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.dataGridViewProducto);
            this.Controls.Add(this.btnSalirProducto);
            this.Controls.Add(this.btnEditarProducto);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStockProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombreProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStockProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrecioProducto)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStockProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.Button btnSalirProducto;
        private System.Windows.Forms.DataGridView dataGridViewProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiltroProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProviderNombreProducto;
        private System.Windows.Forms.ErrorProvider errorProviderStockProducto;
        private System.Windows.Forms.ErrorProvider errorProviderPrecioProducto;
        private System.Windows.Forms.Button btnExcelProductos;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusFecha;
    }
}