namespace proyecto
{
    partial class Pantalla
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
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lvQuejas = new System.Windows.Forms.ListView();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblQuejas = new System.Windows.Forms.Label();
            this.btnResponder = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbChat
            // 
            this.rtbChat.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtbChat.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbChat.Location = new System.Drawing.Point(135, 72);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.Size = new System.Drawing.Size(407, 171);
            this.rtbChat.TabIndex = 0;
            this.rtbChat.Text = "";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(135, 249);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(320, 68);
            this.txtMensaje.TabIndex = 1;
            // 
            // lvQuejas
            // 
            this.lvQuejas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvQuejas.FullRowSelect = true;
            this.lvQuejas.HideSelection = false;
            this.lvQuejas.Location = new System.Drawing.Point(8, 72);
            this.lvQuejas.Name = "lvQuejas";
            this.lvQuejas.Size = new System.Drawing.Size(121, 245);
            this.lvQuejas.TabIndex = 2;
            this.lvQuejas.UseCompatibleStateImageBehavior = false;
            this.lvQuejas.View = System.Windows.Forms.View.List;
            this.lvQuejas.SelectedIndexChanged += new System.EventHandler(this.lvQuejas_SelectedIndexChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(461, 249);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(81, 68);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Product Sans", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(12, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(85, 34);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "label2";
            // 
            // lblQuejas
            // 
            this.lblQuejas.AutoSize = true;
            this.lblQuejas.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuejas.Location = new System.Drawing.Point(16, 45);
            this.lblQuejas.Name = "lblQuejas";
            this.lblQuejas.Size = new System.Drawing.Size(81, 24);
            this.lblQuejas.TabIndex = 12;
            this.lblQuejas.Text = "QUEJAS";
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(461, 249);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(83, 68);
            this.btnResponder.TabIndex = 14;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(467, 43);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Pantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(556, 355);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.lblQuejas);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lvQuejas);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.rtbChat);
            this.Name = "Pantalla";
            this.Text = "Pantalla";
            this.Load += new System.EventHandler(this.Pantalla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.ListView lvQuejas;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblQuejas;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Button btnSalir;
    }
}