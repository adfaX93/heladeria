namespace Heladeria
{
    partial class frmSabores
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
            this.btnEliminarSabor = new System.Windows.Forms.Button();
            this.dataGridViewSabor = new System.Windows.Forms.DataGridView();
            this.btnSalirSabor = new System.Windows.Forms.Button();
            this.btnEditarSabor = new System.Windows.Forms.Button();
            this.btnGuardarSabor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreSabor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarSabor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiltroSabor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProviderNombreSabor = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExcelSabores = new System.Windows.Forms.Button();
            this.statusSt = new System.Windows.Forms.StatusStrip();
            this.statusFecha = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSabor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombreSabor)).BeginInit();
            this.statusSt.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminarSabor
            // 
            this.btnEliminarSabor.Location = new System.Drawing.Point(121, 197);
            this.btnEliminarSabor.Name = "btnEliminarSabor";
            this.btnEliminarSabor.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarSabor.TabIndex = 30;
            this.btnEliminarSabor.Text = "Eliminar";
            this.btnEliminarSabor.UseVisualStyleBackColor = true;
            this.btnEliminarSabor.Click += new System.EventHandler(this.btnEliminarSabor_Click);
            // 
            // dataGridViewSabor
            // 
            this.dataGridViewSabor.AllowUserToAddRows = false;
            this.dataGridViewSabor.AllowUserToDeleteRows = false;
            this.dataGridViewSabor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSabor.Location = new System.Drawing.Point(40, 226);
            this.dataGridViewSabor.Name = "dataGridViewSabor";
            this.dataGridViewSabor.ReadOnly = true;
            this.dataGridViewSabor.Size = new System.Drawing.Size(453, 299);
            this.dataGridViewSabor.TabIndex = 29;
            // 
            // btnSalirSabor
            // 
            this.btnSalirSabor.Location = new System.Drawing.Point(202, 197);
            this.btnSalirSabor.Name = "btnSalirSabor";
            this.btnSalirSabor.Size = new System.Drawing.Size(75, 23);
            this.btnSalirSabor.TabIndex = 28;
            this.btnSalirSabor.Text = "Salir";
            this.btnSalirSabor.UseVisualStyleBackColor = true;
            this.btnSalirSabor.Click += new System.EventHandler(this.btnSalirSabor_Click);
            // 
            // btnEditarSabor
            // 
            this.btnEditarSabor.Location = new System.Drawing.Point(40, 197);
            this.btnEditarSabor.Name = "btnEditarSabor";
            this.btnEditarSabor.Size = new System.Drawing.Size(75, 23);
            this.btnEditarSabor.TabIndex = 27;
            this.btnEditarSabor.Text = "Editar";
            this.btnEditarSabor.UseVisualStyleBackColor = true;
            this.btnEditarSabor.Click += new System.EventHandler(this.btnEditarSabor_Click);
            // 
            // btnGuardarSabor
            // 
            this.btnGuardarSabor.Location = new System.Drawing.Point(40, 79);
            this.btnGuardarSabor.Name = "btnGuardarSabor";
            this.btnGuardarSabor.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarSabor.TabIndex = 26;
            this.btnGuardarSabor.Text = "Guardar";
            this.btnGuardarSabor.UseVisualStyleBackColor = true;
            this.btnGuardarSabor.Click += new System.EventHandler(this.btnGuardarSabor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 21;
            // 
            // txtNombreSabor
            // 
            this.txtNombreSabor.Location = new System.Drawing.Point(155, 47);
            this.txtNombreSabor.Name = "txtNombreSabor";
            this.txtNombreSabor.Size = new System.Drawing.Size(338, 20);
            this.txtNombreSabor.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "SABORES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre sabor:";
            // 
            // btnBuscarSabor
            // 
            this.btnBuscarSabor.Location = new System.Drawing.Point(418, 148);
            this.btnBuscarSabor.Name = "btnBuscarSabor";
            this.btnBuscarSabor.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarSabor.TabIndex = 34;
            this.btnBuscarSabor.Text = "Buscar";
            this.btnBuscarSabor.UseVisualStyleBackColor = true;
            this.btnBuscarSabor.Click += new System.EventHandler(this.btnBuscarSabor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Nombre:";
            // 
            // txtFiltroSabor
            // 
            this.txtFiltroSabor.Location = new System.Drawing.Point(90, 150);
            this.txtFiltroSabor.Name = "txtFiltroSabor";
            this.txtFiltroSabor.Size = new System.Drawing.Size(301, 20);
            this.txtFiltroSabor.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "Buscar sabor";
            // 
            // errorProviderNombreSabor
            // 
            this.errorProviderNombreSabor.ContainerControl = this;
            // 
            // btnExcelSabores
            // 
            this.btnExcelSabores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelSabores.Location = new System.Drawing.Point(418, 177);
            this.btnExcelSabores.Name = "btnExcelSabores";
            this.btnExcelSabores.Size = new System.Drawing.Size(75, 23);
            this.btnExcelSabores.TabIndex = 35;
            this.btnExcelSabores.Text = "Excel";
            this.btnExcelSabores.UseVisualStyleBackColor = true;
            this.btnExcelSabores.Click += new System.EventHandler(this.btnExcelSabores_Click);
            // 
            // statusSt
            // 
            this.statusSt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusFecha});
            this.statusSt.Location = new System.Drawing.Point(0, 526);
            this.statusSt.Name = "statusSt";
            this.statusSt.Size = new System.Drawing.Size(525, 22);
            this.statusSt.TabIndex = 36;
            this.statusSt.Text = "statusStrip1";
            // 
            // statusFecha
            // 
            this.statusFecha.Name = "statusFecha";
            this.statusFecha.Size = new System.Drawing.Size(41, 17);
            this.statusFecha.Text = "Fecha:";
            // 
            // frmSabores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 548);
            this.Controls.Add(this.statusSt);
            this.Controls.Add(this.btnExcelSabores);
            this.Controls.Add(this.btnBuscarSabor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFiltroSabor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEliminarSabor);
            this.Controls.Add(this.dataGridViewSabor);
            this.Controls.Add(this.btnSalirSabor);
            this.Controls.Add(this.btnEditarSabor);
            this.Controls.Add(this.btnGuardarSabor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreSabor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSabores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sabores";
            this.Load += new System.EventHandler(this.frmSabores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSabor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombreSabor)).EndInit();
            this.statusSt.ResumeLayout(false);
            this.statusSt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarSabor;
        private System.Windows.Forms.DataGridView dataGridViewSabor;
        private System.Windows.Forms.Button btnSalirSabor;
        private System.Windows.Forms.Button btnEditarSabor;
        private System.Windows.Forms.Button btnGuardarSabor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreSabor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarSabor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiltroSabor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProviderNombreSabor;
        private System.Windows.Forms.Button btnExcelSabores;
        private System.Windows.Forms.StatusStrip statusSt;
        private System.Windows.Forms.ToolStripStatusLabel statusFecha;
    }
}