using Datos.Infrastructure;
using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Management
{
    public class UsuarioManagement
    {
        public void AltaCliente(UsuariosDTO usuarioDTO)
        {
            Usuarios usuario = new Usuarios
            {
                nombre = usuarioDTO.Nombre,
                apellidos = usuarioDTO.Apellidos,
                dni = usuarioDTO.Dni,
                ccc = usuarioDTO.CuentaCorriente,
                password = encriptarContrasena(usuarioDTO.Contraseña),
                direccion = usuarioDTO.Direccion,
                telefono = usuarioDTO.Telefono,
                tipo_usuario = "client",
                email = usuarioDTO.Email
            };

            new Datos.Repositories.ClientRepository().AltaCliente(usuario);

        }

        private string encriptarContrasena(string contrasena)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(contrasena));
            for (int i = 0; i < 5; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        public Boolean validarUsuario(string email, string contrasena)
        {
            Usuarios usuarioBD = new Datos.Repositories.ClientRepository().ConsultarCliente(email);

            string contrasenaEncript = encriptarContrasena(contrasena);

            return usuarioBD.email.Equals(email) && usuarioBD.password.Equals(contrasenaEncript);
        }
    }
}