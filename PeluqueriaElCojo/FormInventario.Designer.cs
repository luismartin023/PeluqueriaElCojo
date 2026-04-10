namespace PeluqueriaElCojo
{
    partial class FormInventario
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.numCosto = new System.Windows.Forms.NumericUpDown();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.pcbSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(147, 79);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(137, 22);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "Codigo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 131);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(137, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(147, 182);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(137, 22);
            this.txtCategoria.TabIndex = 2;
            this.txtCategoria.Text = "Categoria";
            // 
            // numPrecio
            // 
            this.numPrecio.Location = new System.Drawing.Point(59, 252);
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(120, 22);
            this.numPrecio.TabIndex = 3;
            // 
            // numCosto
            // 
            this.numCosto.Location = new System.Drawing.Point(254, 252);
            this.numCosto.Name = "numCosto";
            this.numCosto.Size = new System.Drawing.Size(120, 22);
            this.numCosto.TabIndex = 4;
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(147, 311);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(137, 22);
            this.numStock.TabIndex = 5;
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Location = new System.Drawing.Point(147, 365);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(134, 39);
            this.btnGuardarProducto.TabIndex = 6;
            this.btnGuardarProducto.Text = "Guardar Producto";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click_1);
            // 
            // pcbSalir
            // 
            this.pcbSalir.BackColor = System.Drawing.Color.Black;
            this.pcbSalir.Image = global::PeluqueriaElCojo.Properties.Resources.Captura_de_pantalla_2026_02_09_194549_Photoroom;
            this.pcbSalir.Location = new System.Drawing.Point(352, 12);
            this.pcbSalir.Name = "pcbSalir";
            this.pcbSalir.Size = new System.Drawing.Size(70, 55);
            this.pcbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSalir.TabIndex = 22;
            this.pcbSalir.TabStop = false;
            this.pcbSalir.Click += new System.EventHandler(this.pcbSalir_Click);
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.pcbSalir);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.numCosto);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInventario";
            this.Text = "FormInventario";
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.NumericUpDown numCosto;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.PictureBox pcbSalir;
    }
}