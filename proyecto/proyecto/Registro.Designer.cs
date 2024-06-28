namespace proyecto
{
    partial class Registro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNMC = new System.Windows.Forms.TextBox();
            this.txtNMU = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.Empleado = new System.Windows.Forms.RadioButton();
            this.cliente = new System.Windows.Forms.RadioButton();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtConEmpleado = new System.Windows.Forms.TextBox();
            this.contraseñaAdmin = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "contraseña";
            // 
            // txtNMC
            // 
            this.txtNMC.Location = new System.Drawing.Point(30, 30);
            this.txtNMC.Name = "txtNMC";
            this.txtNMC.Size = new System.Drawing.Size(103, 20);
            this.txtNMC.TabIndex = 3;
            // 
            // txtNMU
            // 
            this.txtNMU.Location = new System.Drawing.Point(30, 65);
            this.txtNMU.Name = "txtNMU";
            this.txtNMU.Size = new System.Drawing.Size(103, 20);
            this.txtNMU.TabIndex = 4;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(30, 113);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(103, 20);
            this.txtcontraseña.TabIndex = 5;
            // 
            // Empleado
            // 
            this.Empleado.AutoSize = true;
            this.Empleado.Location = new System.Drawing.Point(29, 150);
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(72, 17);
            this.Empleado.TabIndex = 6;
            this.Empleado.TabStop = true;
            this.Empleado.Text = "Empleado";
            this.Empleado.UseVisualStyleBackColor = true;
            this.Empleado.CheckedChanged += new System.EventHandler(this.Empleado_CheckedChanged);
            // 
            // cliente
            // 
            this.cliente.AutoSize = true;
            this.cliente.Location = new System.Drawing.Point(107, 150);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(56, 17);
            this.cliente.TabIndex = 7;
            this.cliente.TabStop = true;
            this.cliente.Text = "cliente";
            this.cliente.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCrear.Location = new System.Drawing.Point(123, 237);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtConEmpleado
            // 
            this.txtConEmpleado.Location = new System.Drawing.Point(30, 202);
            this.txtConEmpleado.Name = "txtConEmpleado";
            this.txtConEmpleado.Size = new System.Drawing.Size(103, 20);
            this.txtConEmpleado.TabIndex = 9;
            this.txtConEmpleado.Visible = false;
            // 
            // contraseñaAdmin
            // 
            this.contraseñaAdmin.AutoSize = true;
            this.contraseñaAdmin.Location = new System.Drawing.Point(26, 186);
            this.contraseñaAdmin.Name = "contraseñaAdmin";
            this.contraseñaAdmin.Size = new System.Drawing.Size(124, 13);
            this.contraseñaAdmin.TabIndex = 10;
            this.contraseñaAdmin.Text = "contraseña de empleado";
            this.contraseñaAdmin.Visible = false;
            this.contraseñaAdmin.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(29, 237);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 277);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.contraseñaAdmin);
            this.Controls.Add(this.txtConEmpleado);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.Empleado);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtNMU);
            this.Controls.Add(this.txtNMC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNMC;
        private System.Windows.Forms.TextBox txtNMU;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.RadioButton Empleado;
        private System.Windows.Forms.RadioButton cliente;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtConEmpleado;
        private System.Windows.Forms.Label contraseñaAdmin;
        private System.Windows.Forms.Button btnCancelar;
    }
}