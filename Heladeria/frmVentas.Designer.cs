namespace Heladeria
{
    partial class frmVentas
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.btnSalirVenta = new System.Windows.Forms.Button();
            this.btnEliminarItem = new System.Windows.Forms.Button();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductoVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarProductoVenta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStockVenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidadVenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewVenta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "NUEVA VENTA";
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Location = new System.Drawing.Point(205, 159);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(94, 23);
            this.btnRegistrarVenta.TabIndex = 37;
            this.btnRegistrarVenta.Text = "Registrar venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            // 
            // btnSalirVenta
            // 
            this.btnSalirVenta.Location = new System.Drawing.Point(305, 159);
            this.btnSalirVenta.Name = "btnSalirVenta";
            this.btnSalirVenta.Size = new System.Drawing.Size(75, 23);
            this.btnSalirVenta.TabIndex = 36;
            this.btnSalirVenta.Text = "Salir";
            this.btnSalirVenta.UseVisualStyleBackColor = true;
            this.btnSalirVenta.Click += new System.EventHandler(this.btnSalirVenta_Click);
            // 
            // btnEliminarItem
            // 
            this.btnEliminarItem.Location = new System.Drawing.Point(124, 159);
            this.btnEliminarItem.Name = "btnEliminarItem";
            this.btnEliminarItem.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarItem.TabIndex = 35;
            this.btnEliminarItem.Text = "Eliminar item";
            this.btnEliminarItem.UseVisualStyleBackColor = true;
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Location = new System.Drawing.Point(43, 159);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarItem.TabIndex = 34;
            this.btnAgregarItem.Text = "Agregar item";
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 33;
            // 
            // txtProductoVenta
            // 
            this.txtProductoVenta.Location = new System.Drawing.Point(122, 66);
            this.txtProductoVenta.Name = "txtProductoVenta";
            this.txtProductoVenta.Size = new System.Drawing.Size(295, 20);
            this.txtProductoVenta.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Producto:";
            // 
            // btnBuscarProductoVenta
            // 
            this.btnBuscarProductoVenta.Location = new System.Drawing.Point(579, 63);
            this.btnBuscarProductoVenta.Name = "btnBuscarProductoVenta";
            this.btnBuscarProductoVenta.Size = new System.Drawing.Size(96, 23);
            this.btnBuscarProductoVenta.TabIndex = 38;
            this.btnBuscarProductoVenta.Text = "Buscar producto";
            this.btnBuscarProductoVenta.UseVisualStyleBackColor = true;
            this.btnBuscarProductoVenta.Click += new System.EventHandler(this.btnBuscarProductoVenta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(435, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "GS.";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(305, 111);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(124, 20);
            this.txtPrecioVenta.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Precio de venta:";
            // 
            // txtStockVenta
            // 
            this.txtStockVenta.Location = new System.Drawing.Point(99, 111);
            this.txtStockVenta.Name = "txtStockVenta";
            this.txtStockVenta.Size = new System.Drawing.Size(72, 20);
            this.txtStockVenta.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Stock:";
            // 
            // txtCantidadVenta
            // 
            this.txtCantidadVenta.Location = new System.Drawing.Point(564, 109);
            this.txtCantidadVenta.Name = "txtCantidadVenta";
            this.txtCantidadVenta.Size = new System.Drawing.Size(111, 20);
            this.txtCantidadVenta.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(481, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Cantidad:";
            // 
            // dataGridViewVenta
            // 
            this.dataGridViewVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVenta.Location = new System.Drawing.Point(43, 188);
            this.dataGridViewVenta.Name = "dataGridViewVenta";
            this.dataGridViewVenta.Size = new System.Drawing.Size(632, 264);
            this.dataGridViewVenta.TabIndex = 46;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 464);
            this.Controls.Add(this.dataGridViewVenta);
            this.Controls.Add(this.txtCantidadVenta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStockVenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscarProductoVenta);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.btnSalirVenta);
            this.Controls.Add(this.btnEliminarItem);
            this.Controls.Add(this.btnAgregarItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductoVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Button btnSalirVenta;
        private System.Windows.Forms.Button btnEliminarItem;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductoVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarProductoVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStockVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidadVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewVenta;
    }
}