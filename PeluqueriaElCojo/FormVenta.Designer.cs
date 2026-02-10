namespace PeluqueriaElCojo
{
    partial class FormVenta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.chkCorteNormal = new System.Windows.Forms.CheckBox();
            this.chkDegradado = new System.Windows.Forms.CheckBox();
            this.chkAfeitado = new System.Windows.Forms.CheckBox();
            this.chkToalla = new System.Windows.Forms.CheckBox();
            this.chkCejas = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.numNivel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Ivory;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(87, 204);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(274, 30);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Ivory;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(87, 281);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(274, 30);
            this.txtTelefono.TabIndex = 1;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRecibo
            // 
            this.txtRecibo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRecibo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecibo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecibo.Location = new System.Drawing.Point(770, 176);
            this.txtRecibo.Multiline = true;
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.Size = new System.Drawing.Size(317, 359);
            this.txtRecibo.TabIndex = 2;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAgregarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.Location = new System.Drawing.Point(474, 438);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(116, 43);
            this.btnAgregarCliente.TabIndex = 3;
            this.btnAgregarCliente.Text = "AGREGAR";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCobrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Location = new System.Drawing.Point(870, 550);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(109, 42);
            this.btnCobrar.TabIndex = 4;
            this.btnCobrar.Text = "COBRAR";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // lstClientes
            // 
            this.lstClientes.BackColor = System.Drawing.Color.Ivory;
            this.lstClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstClientes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClientes.ForeColor = System.Drawing.Color.Black;
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 23;
            this.lstClientes.Location = new System.Drawing.Point(87, 367);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(274, 117);
            this.lstClientes.TabIndex = 5;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);
            // 
            // chkCorteNormal
            // 
            this.chkCorteNormal.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCorteNormal.AutoSize = true;
            this.chkCorteNormal.BackColor = System.Drawing.Color.Ivory;
            this.chkCorteNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkCorteNormal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCorteNormal.Location = new System.Drawing.Point(474, 200);
            this.chkCorteNormal.Name = "chkCorteNormal";
            this.chkCorteNormal.Size = new System.Drawing.Size(210, 33);
            this.chkCorteNormal.TabIndex = 6;
            this.chkCorteNormal.Text = "Corte Normal (RD$200)";
            this.chkCorteNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCorteNormal.UseVisualStyleBackColor = false;
            // 
            // chkDegradado
            // 
            this.chkDegradado.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkDegradado.AutoSize = true;
            this.chkDegradado.BackColor = System.Drawing.Color.Ivory;
            this.chkDegradado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDegradado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDegradado.Location = new System.Drawing.Point(474, 290);
            this.chkDegradado.Name = "chkDegradado";
            this.chkDegradado.Size = new System.Drawing.Size(110, 33);
            this.chkDegradado.TabIndex = 7;
            this.chkDegradado.Text = "Degradado";
            this.chkDegradado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkDegradado.UseVisualStyleBackColor = false;
            // 
            // chkAfeitado
            // 
            this.chkAfeitado.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAfeitado.AutoSize = true;
            this.chkAfeitado.BackColor = System.Drawing.Color.Ivory;
            this.chkAfeitado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAfeitado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAfeitado.Location = new System.Drawing.Point(474, 244);
            this.chkAfeitado.Name = "chkAfeitado";
            this.chkAfeitado.Size = new System.Drawing.Size(171, 33);
            this.chkAfeitado.TabIndex = 8;
            this.chkAfeitado.Text = "\tAfeitado (RD$150)";
            this.chkAfeitado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAfeitado.UseVisualStyleBackColor = false;
            // 
            // chkToalla
            // 
            this.chkToalla.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkToalla.AutoSize = true;
            this.chkToalla.BackColor = System.Drawing.Color.Ivory;
            this.chkToalla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkToalla.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkToalla.Location = new System.Drawing.Point(474, 334);
            this.chkToalla.Name = "chkToalla";
            this.chkToalla.Size = new System.Drawing.Size(166, 33);
            this.chkToalla.TabIndex = 9;
            this.chkToalla.Text = "+ Toalla (+RD$50)";
            this.chkToalla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkToalla.UseVisualStyleBackColor = false;
            // 
            // chkCejas
            // 
            this.chkCejas.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCejas.AutoSize = true;
            this.chkCejas.BackColor = System.Drawing.Color.Ivory;
            this.chkCejas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkCejas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCejas.Location = new System.Drawing.Point(474, 375);
            this.chkCejas.Name = "chkCejas";
            this.chkCejas.Size = new System.Drawing.Size(132, 33);
            this.chkCejas.TabIndex = 10;
            this.chkCejas.Text = "Cejas (RD$75)";
            this.chkCejas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCejas.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Ivory;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(455, 496);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(135, 28);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "TOTAL: RD$0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numNivel
            // 
            this.numNivel.BackColor = System.Drawing.Color.Ivory;
            this.numNivel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numNivel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNivel.Location = new System.Drawing.Point(116, 534);
            this.numNivel.Name = "numNivel";
            this.numNivel.Size = new System.Drawing.Size(136, 30);
            this.numNivel.TabIndex = 12;
            this.numNivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(138, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Wheat;
            this.label2.Location = new System.Drawing.Point(138, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "PELUQUERIA EL COJO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Wheat;
            this.label4.Location = new System.Drawing.Point(138, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Clientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Wheat;
            this.label5.Location = new System.Drawing.Point(138, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cantidad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PeluqueriaElCojo.Properties.Resources.Gemini_Generated_Image_v1boyv1boyv1boyv_Photoroom;
            this.pictureBox1.Location = new System.Drawing.Point(419, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PeluqueriaElCojo.Properties.Resources.Captura_de_pantalla_2026_02_09_194549_Photoroom;
            this.pictureBox2.Location = new System.Drawing.Point(1074, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Ivory;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(892, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "RECIBO";
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PeluqueriaElCojo.Properties.Resources.Gemini_Generated_Image_ukaddyukaddyukad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1137, 619);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numNivel);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.chkCejas);
            this.Controls.Add(this.chkToalla);
            this.Controls.Add(this.chkAfeitado);
            this.Controls.Add(this.chkDegradado);
            this.Controls.Add(this.chkCorteNormal);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.txtRecibo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVenta";
            this.Text = "PELUQUERIA";
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.CheckBox chkCorteNormal;
        private System.Windows.Forms.CheckBox chkDegradado;
        private System.Windows.Forms.CheckBox chkAfeitado;
        private System.Windows.Forms.CheckBox chkToalla;
        private System.Windows.Forms.CheckBox chkCejas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown numNivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
    }
}

