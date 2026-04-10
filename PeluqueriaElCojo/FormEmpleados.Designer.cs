namespace PeluqueriaElCojo
{
    partial class FormEmpleados
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
            this.pcbSalir = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApodo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.numSueldoBase = new System.Windows.Forms.NumericUpDown();
            this.numComision = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarEmpleado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSueldoBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComision)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbSalir
            // 
            this.pcbSalir.BackColor = System.Drawing.Color.Black;
            this.pcbSalir.Image = global::PeluqueriaElCojo.Properties.Resources.Captura_de_pantalla_2026_02_09_194549_Photoroom;
            this.pcbSalir.Location = new System.Drawing.Point(697, 12);
            this.pcbSalir.Name = "pcbSalir";
            this.pcbSalir.Size = new System.Drawing.Size(70, 55);
            this.pcbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSalir.TabIndex = 23;
            this.pcbSalir.TabStop = false;
            this.pcbSalir.Click += new System.EventHandler(this.pcbSalir_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 24;
            this.txtNombre.Text = "Nombre";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(136, 204);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono.TabIndex = 27;
            this.txtTelefono.Text = "Telefono";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(136, 153);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 22);
            this.txtCedula.TabIndex = 28;
            this.txtCedula.Text = "Cedula";
            // 
            // txtApodo
            // 
            this.txtApodo.Location = new System.Drawing.Point(265, 101);
            this.txtApodo.Name = "txtApodo";
            this.txtApodo.Size = new System.Drawing.Size(100, 22);
            this.txtApodo.TabIndex = 29;
            this.txtApodo.Text = "Apodo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PeluqueriaElCojo.Properties.Resources.Gemini_Generated_Image_v1boyv1boyv1boyv_Photoroom;
            this.pictureBox1.Location = new System.Drawing.Point(450, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Barbero",
            "Estilista"});
            this.cmbRol.Location = new System.Drawing.Point(136, 251);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 24);
            this.cmbRol.TabIndex = 31;
            this.cmbRol.Text = "Rol";
            // 
            // numSueldoBase
            // 
            this.numSueldoBase.Location = new System.Drawing.Point(137, 309);
            this.numSueldoBase.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSueldoBase.Name = "numSueldoBase";
            this.numSueldoBase.Size = new System.Drawing.Size(120, 22);
            this.numSueldoBase.TabIndex = 32;
            this.numSueldoBase.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // numComision
            // 
            this.numComision.Location = new System.Drawing.Point(137, 370);
            this.numComision.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numComision.Name = "numComision";
            this.numComision.Size = new System.Drawing.Size(120, 22);
            this.numComision.TabIndex = 33;
            this.numComision.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "SUELDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "SUELDO POR COMISION";
            // 
            // btnGuardarEmpleado
            // 
            this.btnGuardarEmpleado.Location = new System.Drawing.Point(388, 328);
            this.btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            this.btnGuardarEmpleado.Size = new System.Drawing.Size(134, 39);
            this.btnGuardarEmpleado.TabIndex = 36;
            this.btnGuardarEmpleado.Text = "Guardar Empleado";
            this.btnGuardarEmpleado.UseVisualStyleBackColor = true;
            this.btnGuardarEmpleado.Click += new System.EventHandler(this.btnGuardarEmpleado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(148, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "PELUQUERIA EL COJO";
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardarEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numComision);
            this.Controls.Add(this.numSueldoBase);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtApodo);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pcbSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmpleados";
            this.Text = "FormEmpleados";
            ((System.ComponentModel.ISupportInitialize)(this.pcbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSueldoBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbSalir;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApodo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.NumericUpDown numSueldoBase;
        private System.Windows.Forms.NumericUpDown numComision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardarEmpleado;
        private System.Windows.Forms.Label label3;
    }
}