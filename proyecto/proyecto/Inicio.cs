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

namespace proyecto
{
    public partial class Inicio : Form
    {
        private Usuario[] usuarios;
        public Inicio()
        {
            InitializeComponent();
            usuarios = new Usuario[100];
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registro nuevousuario = new Registro();
            nuevousuario.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string nombreusuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;
            IniciarSesion(nombreusuario, contraseña);
            txtNombreUsuario.Clear();
            txtContraseña.Clear();
        }

        private bool VerificarCredenciales(string nombreusuario, string contraseña)
        {
            try
            {
                using (StreamReader lector = new StreamReader("usuarios.txt"))
                {
                    string linea;
                    while ((linea = lector.ReadLine()) != null)
                    {
                        string[] partes = linea.Split(',');
                        if (partes.Length >= 2)
                        {
                            string UsuarioGuardado = partes[0];
                            string contraseñaguardada = partes[1];
                            if (UsuarioGuardado == nombreusuario && contraseñaguardada == contraseña)
                            {
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("error al verificar las credenciales:" + ex.Message);
                return false;
            }
        }
        private void IniciarSesion(string nombreusuario,string contraseña)
        {
            this.Hide();
            string NOMUSUA = txtNombreUsuario.Text;
            if (VerificarCredenciales(nombreusuario, contraseña))
            {
                Pantalla nuevapantalla = new Pantalla(nombreusuario);
                nuevapantalla.Show(); 
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta intentelo de nuevo");
            }
        }
    }
}
