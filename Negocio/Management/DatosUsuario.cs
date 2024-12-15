using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.EntitiesDTO;

namespace Negocio.Management
{
    public static class DatosUsuario
    {
        // Propiedades para almacenar los datos del usuario logueado


    public static string Dni { get; private set; }
        public static string Nombre { get; private set; }
        public static string Apellidos { get; private set; }
        public static string Email { get; private set; }
        public static string Telefono { get; private set; }
        public static string Direccion { get; private set; }
        public static string CuentaCorriente { get; private set; }
        public static string Contraseña { get; private set; }
        // Método para inicializar los datos del usuario desde un objeto UsuariosDTO
        public static void SetDatosUsuario(UsuariosDTO usuarioDTO)
        {

            Dni = usuarioDTO.Dni;
            Nombre = usuarioDTO.Nombre;
            Apellidos = usuarioDTO.Apellidos;
            Email = usuarioDTO.Email;
            Telefono = usuarioDTO.Telefono;
            Direccion = usuarioDTO.Direccion;
            CuentaCorriente = usuarioDTO.CuentaCorriente;
            Contraseña = usuarioDTO.Contraseña;
        }

        // Método para limpiar los datos del usuario al cerrar sesión
        public static void LimpiarDatos()
        {
            Dni = null;
            Nombre = null;
            Apellidos = null;
            Email = null;
            Telefono = null;
            Direccion = null;
            CuentaCorriente = null;
            Contraseña = null;
        }
    }
}
