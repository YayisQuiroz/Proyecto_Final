using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    public class Usuario
    {
        private string nombrecompleto;
        private string nombreusuarios;
        private string contraseña;
        private bool tipousuario;
        public Usuario()
        {}
        public Usuario(string nombrecompleto, string nombreusuarios, string contraseña, bool tipousuario)
        {
            this.nombrecompleto = nombrecompleto;
            this.nombreusuarios = nombreusuarios;
            this.contraseña = contraseña;
            this.tipousuario = tipousuario;
        }

        public string Nombrecompleto { get => nombrecompleto; set => nombrecompleto = value; }
        public string Nombreusuarios { get => nombreusuarios; set => nombreusuarios = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public bool Tipousuario { get => tipousuario; set => tipousuario = value; }
    }
}
