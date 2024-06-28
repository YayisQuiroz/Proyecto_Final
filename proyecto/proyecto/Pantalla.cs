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
using System.Runtime.Remoting.Messaging;
using System.Runtime.Versioning;
using System.Collections;

namespace proyecto
{
    public partial class Pantalla : Form
    {
        string archivoQuejas = "quejas.json";
        List<Queja> quejas;
        int indiceDelvQueja;
        public Pantalla(string nombreusuario)
        {
            InitializeComponent();
            lblUsuario.Text = nombreusuario;
            quejas = new List<Queja>();
            rtbChat.ReadOnly = true;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            string NOmbreUsuario = lblUsuario.Text;
            string queja = txtMensaje.Text;
            quejas.Add(new Queja(queja, NOmbreUsuario, "sin respuesta"));

            rtbChat.AppendText("tu queja:" + queja + "\n");
            GuardarQuejas();
            MostrarquejasLv();
            txtMensaje.Clear();
        }
        private void Pantalla_Load(object sender, EventArgs e)
        {
            string nombreUsa = lblUsuario.Text;
            if (VerificarModoUsuario(nombreUsa) == true)
            {
                lvQuejas.Visible = true;
                CargarQuejas();
                MostrarquejasLv();
                btnEnviar.Visible = false;
                btnResponder.Visible = true;
            }
            else
            {
                CargarQuejas();
                MostrarQueja(nombreUsa);
                lvQuejas.Visible = false;
                btnEnviar.Visible = true;
                btnResponder.Visible = false;
            }

        }
        private void CargarQuejas()
        {
            if (File.Exists(archivoQuejas))
            {
                string json = File.ReadAllText(archivoQuejas);
                quejas = JsonConvert.DeserializeObject<List<Queja>>(json);
            }
        }
        private void GuardarQuejas()
        {
            string json = JsonConvert.SerializeObject(quejas);
            File.WriteAllText(archivoQuejas, json);

        }
        private void MostrarquejasLv()
        {
            lvQuejas.Items.Clear();
            foreach (Queja q in quejas)
            {
                ListViewItem item = new ListViewItem(new string[] { q.NombreCliente1, q.Description1 });
                lvQuejas.Items.Add(item);
            }
        }
        private void lvQuejas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvQuejas.SelectedItems.Count > 0)
            {
                Queja QS1 = quejas[lvQuejas.SelectedItems[0].Index];
                indiceDelvQueja = lvQuejas.SelectedIndices[0];
                rtbChat.Text = "usuario:" + QS1.NombreCliente1 + "\nQueja:" + QS1.Description1 + "\nRespuesta:"+QS1.Respuesta;
                GuardarQuejas();
                MostrarquejasLv();
                txtMensaje.Clear();
            }
        }
        private bool VerificarModoUsuario(string NombreUsuario)
        {
            string archivousuarios = "usuarios.txt";
            if (File.Exists(archivousuarios))
            {
                string[] lineas = File.ReadAllLines(archivousuarios);
                foreach (string linea in lineas)
                {
                    string[] partes = linea.Split(',');
                    if (partes.Length == 4 && partes[0] == NombreUsuario)
                    {
                        return bool.Parse(partes[3]);
                    }
                }
            }
            return false;

        }
        private void btnResponder_Click(object sender, EventArgs e)
        {
            try
            {
                int index = indiceDelvQueja;
                Queja QS = quejas[index];
                string respuesta = txtMensaje.Text;
                QS.Respuesta = respuesta;

                rtbChat.Text = "usuario:" + QS.NombreCliente1 + "\nQueja:" + QS.Description1 + "\nRespuesta:" + QS.Respuesta;
                GuardarQuejas();
                MostrarquejasLv();

                txtMensaje.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error"+ex.Message);
            }
        }
        private void MostrarQueja(string nombreusuario)
        {
            var quejasusuario = quejas.Where(q => q.NombreCliente1 == nombreusuario).ToList();

            if(quejasusuario.Count > 0)
            {
                string textoQuejas = "";
                foreach(Queja queja in quejasusuario)
                {
                    textoQuejas+=$"Queja:{queja.Description1}\nRespuesta del empleados:{queja.Respuesta}\n\n";
                }
                rtbChat.Text = textoQuejas;
            }
            else
            {
                rtbChat.Text = "no se encontraron quejas";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio nuevoinicio = new Inicio();
            nuevoinicio.Show();
        }
    }
}
