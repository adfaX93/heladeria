namespace Heladeria
{
    partial class frmSeleccionaProducto
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
            this.dataGridViewSeleccionaProducto = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalirListaProducto = new System.Windows.Forms.Button();
            this.btnAgregarProductoVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeleccionaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSeleccionaProducto
            // 
            this.dataGridViewSeleccionaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeleccionaProducto.Location = new System.Drawing.Point(38, 44);
            this.dataGridViewSeleccionaProducto.Name = "dataGridViewSeleccionaProducto";
            this.dataGridViewSeleccionaProducto.Size = new System.Drawing.Size(453, 339);
            this.dataGridViewSeleccionaProducto.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "SELECCIONE UN PRODUCTO";
            // 
            // btnSalirListaProducto
            // 
            this.btnSalirListaProducto.Location = new System.Drawing.Point(410, 402);
            this.btnSalirListaProducto.Name = "btnSalirListaProducto";
            this.btnSalirListaProducto.Size = new System.Drawing.Size(75, 23);
            this.btnSalirListaProducto.TabIndex = 30;
            this.btnSalirListaProducto.Text = "Salir";
            this.btnSalirListaProducto.UseVisualStyleBackColor = true;
            this.btnSalirListaProducto.Click += new System.EventHandler(this.btnSalirListaProducto_Click);
            // 
            // btnAgregarProductoVenta
            // 
            this.btnAgregarProductoVenta.Location = new System.Drawing.Point(329, 402);
            this.btnAgregarProductoVenta.Name = "btnAgregarProductoVenta";
            this.btnAgregarProductoVenta.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProductoVenta.TabIndex = 31;
            this.btnAgregarProductoVenta.Text = "Agregar";
            this.btnAgregarProductoVenta.UseVisualStyleBackColor = true;
            // 
            // frmSeleccionaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.btnAgregarProductoVenta);
            this.Controls.Add(this.btnSalirListaProducto);
            this.Controls.Add(this.dataGridViewSeleccionaProducto);
            this.Controls.Add(this.label2);
            this.Name = "frmSeleccionaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeleccionaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewSeleccionaProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalirListaProducto;
        private System.Windows.Forms.Button btnAgregarProductoVenta;
    }
}