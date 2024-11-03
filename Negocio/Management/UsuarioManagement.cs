﻿using Datos.Infrastructure; 
using Negocio.EntitiesDTO; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Negocio.Management
{
    public class UsuarioManagement
    {
        /// <summary>
        /// Registra un nuevo cliente en el sistema.
        /// Crea un Usuario a partir de un DTO y lo guarda en la base de datos.
        /// </summary>
        /// <param name="usuarioDTO">El objeto que contiene la información del usuario a registrar.</param>
        public bool AltaCliente(UsuariosDTO usuarioDTO)
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

            bool existeDNI = comprobarDNIExistente(usuarioDTO.Dni);
            bool existeEmail = comprobarEmailExistente(usuarioDTO.Email);

            // Añade al usuario a la base de datos si no existe ningun campo anterior.
            if (existeDNI || existeEmail)
            {
                return false;
            }
            else
            {
                new Datos.Repositories.ClientRepository().AltaCliente(usuario);
                return true;
            }
            
        }

        private bool comprobarDNIExistente(string dni)
        {
            Usuarios usuarioBD = new Datos.Repositories.ClientRepository().ConsultarClienteDNI(dni);

            if (usuarioBD == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool comprobarEmailExistente(string email)
        {
            Usuarios usuarioBD = new Datos.Repositories.ClientRepository().ConsultarClienteEmail(email);

            if (usuarioBD == null)
            {
                return false;
            }
            else
            {
                return true;
            }
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
        public Boolean validarUsuario(string email, string contrasena)
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
    }
}
