using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
        

namespace proyecto
{
    public partial class Registro : Form
    {
        private Usuario[] usuarios;
        public Registro()
        {
            InitializeComponent();
            usuarios = new Usuario[100];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Usuario NuevoUsuario = new Usuario();
            NuevoUsuario.Nombrecompleto = txtNMC.Text;
            NuevoUsuario.Nombreusuarios = txtNMU.Text;
            NuevoUsuario.Contraseña = txtcontraseña.Text;
            NuevoUsuario.Tipousuario = Empleado.Checked;
            if (NuevoUsuario.Tipousuario)
            {
                string contraseñaconfirmacion = txtConEmpleado.Text;
                if (contraseñaconfirmacion == "DIANA_YADIRA_QUIROZ_IBARRA")
                {
                    NuevoUsuario.Tipousuario = true;
                }
                else
                {
                    Empleado.Checked = false;
                    MessageBox.Show("contraseña incorrecta");
                }
            }
            else
            {
                NuevoUsuario.Tipousuario = false;
            }
            try
            {
               for(int i = 0; i < usuarios.Length; i++)
                {
                    if (usuarios[i] == null)
                    {
                        usuarios[i] = NuevoUsuario;
                        break;
                    }

                }
                GuardarUsuariosEnArchivo();
                this.Hide();
                Inicio nuevoinicio = new Inicio();
                nuevoinicio.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error al guardar"+ex.Message);
            }
        }
        private void VerficarEMpleado()
        {
            if (Empleado.Checked)
            {
                txtConEmpleado.Visible = true;
                contraseñaAdmin.Visible = true;
            }
            else
            {
                txtConEmpleado.Visible = false;
                contraseñaAdmin.Visible = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {}

        private void Empleado_CheckedChanged(object sender, EventArgs e)
        {
            VerficarEMpleado();
        }
        private void GuardarUsuariosEnArchivo()
        {
            string contenidoEXistente = "";
            string Archivo = "usuarios.txt";
            try
            {
                if (File.Exists(Archivo))
                {
                    using(StreamReader Lector= new StreamReader(Archivo))
                    {
                        contenidoEXistente = Lector.ReadToEnd();
                    }
                }
                
                using (StreamWriter escrito = new StreamWriter(Archivo))
                {
                   foreach(var usuario in usuarios)
                    {
                        if (usuario != null)
                        {
                            string linea = $"\n{usuario.Nombreusuarios},{usuario.Contraseña},{usuario.Nombrecompleto},{usuario.Tipousuario}";
                            contenidoEXistente += Environment.NewLine + linea;

                            escrito.WriteLine(contenidoEXistente);
                        }
                    }
                }
                MessageBox.Show("usuario guardado correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("error al guardar usuario" + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio nuevoinicio = new Inicio();
            nuevoinicio.Show();
        }
    }
}
