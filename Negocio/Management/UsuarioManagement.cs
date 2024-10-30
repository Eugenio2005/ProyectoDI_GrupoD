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
        /// <summary>
        /// Registra un nuevo cliente en el sistema.
        /// Crea un Usuario a partir de un DTO y lo guarda en la base de datos.
        /// </summary>
        /// <param name="usuarioDTO">El objeto que contiene la información del usuario a registrar.</param>
        public void AltaCliente(UsuariosDTO usuarioDTO)
        {
            // Crea un usuario con los datos enviados del registro.
            Usuarios usuario = new Usuarios
            {
                nombre = usuarioDTO.Nombre, 
                apellidos = usuarioDTO.Apellidos,
                dni = usuarioDTO.Dni, 
                ccc = usuarioDTO.CuentaCorriente, 
                password = encriptarContrasena(usuarioDTO.Contraseña), 
                direccion = usuarioDTO.Direccion, 
                telefono = usuarioDTO.Telefono,
                tipo_usuario = "client", // Por defecto hasta que nos digan lo contrario.
                email = usuarioDTO.Email 
            };

            // Añade la usuario a la base de datos.
            new Datos.Repositories.ClientRepository().AltaCliente(usuario);
        }

        /// <summary>
        /// Encripta la contraseña utilizando el algoritmo SHA256.
        /// </summary>
        /// <param name="contrasena">La contraseña a encriptar.</param>
        /// <returns>La contraseña encriptada en formato hexadecimal.</returns>
        private string encriptarContrasena(string contrasena)
        {
            SHA256 sha256 = SHA256Managed.Create(); // Crea una instancia de SHA256
            ASCIIEncoding encoding = new ASCIIEncoding(); // Crea una instancia de ASCIIEncoding
            byte[] stream = null; // Array para almacenar el hash
            StringBuilder sb = new StringBuilder(); // StringBuilder para construir la cadena final

            // Computa el hash de la contraseña
            stream = sha256.ComputeHash(encoding.GetBytes(contrasena));
            // Convierte el hash a formato hexadecimal
            for (int i = 0; i < 5; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString(); // Retorna la contraseña encriptada
        }

        /// <summary>
        /// Valida las credenciales del usuario comparando el email y la contraseña.
        /// </summary>
        /// <param name="email">El email del usuario.</param>
        /// <param name="contrasena">La contraseña del usuario.</param>
        /// <returns>True si el usuario existe y las credenciales son válidas, false en caso contrario.</returns>
        public bool validarUsuario(string email, string contrasena)
        {
            // Verifica que los campos no estén vacíos
            if (!email.Equals("") && !contrasena.Equals(""))
            {
                // Consulta el usuario en la base de datos
                Usuarios usuarioBD = new Datos.Repositories.ClientRepository().ConsultarClienteEmail(email);

                // Encripta la contraseña introducida para compararla con la que se recoge de la base de datos.
                string contrasenaEncript = encriptarContrasena(contrasena);

                // Verifica si el usuario existe y si las credenciales son correctas
                if (usuarioBD != null)
                {
                    return usuarioBD.email.Equals(email) && usuarioBD.password.Equals(contrasenaEncript);
                }
                else
                {
                    return false; // El usuario no existe
                }
            }

            return false; // Retorna false si alguno de los campos está vacío
        }

        /// <summary>
        /// Metodo que comprueba si un usuario contiene el mismo email o un usuario con el mismo dni que el que se quiere registrar.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="dni"></param>
        /// <returns>Devuelve un string indicando los campos en conflicto, o una cadena vacía si no existen conflictos.</returns>
        public string existeUsuario(string email, string dni)
        {
            StringBuilder campos = new StringBuilder("");
            Usuarios usuarioBDEmail = new Datos.Repositories.ClientRepository().ConsultarClienteEmail(email);
            Usuarios usuarioBDDNI = new Datos.Repositories.ClientRepository().ConsultarClienteDNI(dni);

            // Verifica si el usuario con el email existe y añade el mensaje correspondiente
            if (usuarioBDEmail != null && usuarioBDEmail.email.Equals(email))
            {
                campos.Append("- El email ya está en uso\n");
            }

            // Verifica si el usuario con el dni existe y añade el mensaje correspondiente
            if (usuarioBDDNI != null && usuarioBDDNI.dni.Equals(dni))
            {
                campos.Append("- El DNI ya está en uso");
            }

            return campos.ToString();
        }

    }
}
