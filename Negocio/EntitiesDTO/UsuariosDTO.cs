using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.EntitiesDTO
{
   
    public class UsuariosDTO
    {
        private string nombre, apellidos, dni, email, direccion, contraseña, telefono;

        public string Nombre { get; set; }
        public string Apellidos { get;  set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Contraseña { get; set; }

    }
}
