using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
	public class Queja
	{
		private string Description;
		private string NombreCliente;
		private string respuesta;

		public Queja()
		{ }
		public Queja(string description, string nombreCliente,string Respuesta)
		{
			Description = description;
			NombreCliente = nombreCliente;
			respuesta = Respuesta;
		}

		public string Description1 { get => Description; set => Description = value; }
		public string NombreCliente1 { get => NombreCliente; set => NombreCliente = value; }
		public string Respuesta { get => respuesta; set => respuesta = value; }
	}
}
    
