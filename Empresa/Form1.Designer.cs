namespace Empresa
{
    partial class Form1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCuil = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.lblCantidadDeHijos = new System.Windows.Forms.Label();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.txtBoxCuil = new System.Windows.Forms.TextBox();
            this.txtBoxCantidadDeHijos = new System.Windows.Forms.TextBox();
            this.txtBoxAntiguedad = new System.Windows.Forms.TextBox();
            this.btnCalcularSueldo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(59, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(152, 42);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(121, 20);
            this.txtBoxNombre.TabIndex = 1;
            this.txtBoxNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(61, 74);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Location = new System.Drawing.Point(61, 103);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(31, 13);
            this.lblCuil.TabIndex = 3;
            this.lblCuil.Text = "CUIL";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(61, 142);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "Cargo";
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(152, 142);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(121, 21);
            this.cmbCargo.TabIndex = 5;
            // 
            // lblCantidadDeHijos
            // 
            this.lblCantidadDeHijos.AutoSize = true;
            this.lblCantidadDeHijos.Location = new System.Drawing.Point(61, 183);
            this.lblCantidadDeHijos.Name = "lblCantidadDeHijos";
            this.lblCantidadDeHijos.Size = new System.Drawing.Size(88, 13);
            this.lblCantidadDeHijos.TabIndex = 7;
            this.lblCantidadDeHijos.Text = "Cantidad de hijos";
            this.lblCantidadDeHijos.Click += new System.EventHandler(this.lblCantidadDeHijos_Click);
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Location = new System.Drawing.Point(61, 218);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(61, 13);
            this.lblAntiguedad.TabIndex = 8;
            this.lblAntiguedad.Text = "Antigüedad";
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(152, 74);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(121, 20);
            this.txtBoxApellido.TabIndex = 9;
            // 
            // txtBoxCuil
            // 
            this.txtBoxCuil.Location = new System.Drawing.Point(150, 107);
            this.txtBoxCuil.Name = "txtBoxCuil";
            this.txtBoxCuil.Size = new System.Drawing.Size(123, 20);
            this.txtBoxCuil.TabIndex = 10;
            // 
            // txtBoxCantidadDeHijos
            // 
            this.txtBoxCantidadDeHijos.Location = new System.Drawing.Point(152, 180);
            this.txtBoxCantidadDeHijos.Name = "txtBoxCantidadDeHijos";
            this.txtBoxCantidadDeHijos.Size = new System.Drawing.Size(121, 20);
            this.txtBoxCantidadDeHijos.TabIndex = 11;
            // 
            // txtBoxAntiguedad
            // 
            this.txtBoxAntiguedad.Location = new System.Drawing.Point(155, 217);
            this.txtBoxAntiguedad.Name = "txtBoxAntiguedad";
            this.txtBoxAntiguedad.Size = new System.Drawing.Size(118, 20);
            this.txtBoxAntiguedad.TabIndex = 12;
            // 
            // btnCalcularSueldo
            // 
            this.btnCalcularSueldo.Location = new System.Drawing.Point(324, 335);
            this.btnCalcularSueldo.Name = "btnCalcularSueldo";
            this.btnCalcularSueldo.Size = new System.Drawing.Size(154, 44);
            this.btnCalcularSueldo.TabIndex = 13;
            this.btnCalcularSueldo.Text = "Calcular sueldo";
            this.btnCalcularSueldo.UseVisualStyleBackColor = true;
            this.btnCalcularSueldo.Click += new System.EventHandler(this.btnCalcularSueldo_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularSueldo);
            this.Controls.Add(this.txtBoxAntiguedad);
            this.Controls.Add(this.txtBoxCantidadDeHijos);
            this.Controls.Add(this.txtBoxCuil);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.lblAntiguedad);
            this.Controls.Add(this.lblCantidadDeHijos);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblCuil);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label lblCantidadDeHijos;
        private System.Windows.Forms.Label lblAntiguedad;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.TextBox txtBoxCuil;
        private System.Windows.Forms.TextBox txtBoxCantidadDeHijos;
        private System.Windows.Forms.TextBox txtBoxAntiguedad;
        private System.Windows.Forms.Button btnCalcularSueldo;
    }
}

