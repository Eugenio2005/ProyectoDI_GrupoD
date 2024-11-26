using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositories
{
    /// <summary>
    /// Clase que gestiona las operaciones relacionadas con los clientes y monitores en la base de datos.
    /// Permite agregar nuevos clientes, consultar clientes por email o DNI, y agregar monitores.
    /// </summary>
    public class ClientRepository
    {
        /// <summary>
        /// Agrega un nuevo cliente y su correspondiente usuario a la base de datos.
        /// </summary>
        /// <param name="usuario">El objeto que representa al usuario a registrar.</param>
        /// <param name="cliente">El objeto que representa al cliente a registrar.</param>
        public void AltaCliente(Usuarios usuario, Clientes cliente)
        {
            // Utiliza el contexto de la base de datos para realizar operaciones
            using (var contexto = new equipodEntities())
            {
                contexto.Usuarios.Add(usuario);
                contexto.SaveChanges();
            }
            using (var contexto2 = new equipodEntities())
            {
                contexto2.Clientes.Add(cliente);
                contexto2.SaveChanges();
            }
        }

        /// <summary>
        /// Consulta un cliente en la base de datos a través de su email.
        /// </summary>
        /// <param name="email">El email del usuario que se desea consultar.</param>
        /// <returns>
        /// Devuelve el usuario con el que coincida el email introducido.
        /// Si no se encuentra, devuelve null.
        /// </returns>
        public Usuarios ConsultarClienteEmail(string email)
        {
            using (var contexto = new equipodEntities())
            {
                // Devuelve el primer usuario que encuentra con el mismo email.
                return contexto.Usuarios.FirstOrDefault(u => u.email == email);
            }
        }

        /// <summary>
        /// Consulta un cliente en la base de datos a través de su DNI.
        /// </summary>
        /// <param name="dni">El DNI del usuario que se desea consultar.</param>
        /// <returns>
        /// Devuelve el usuario con el que coincida el DNI introducido.
        /// Si no se encuentra, devuelve null.
        /// </returns>
        public Usuarios ConsultarClienteDNI(string dni)
        {
            using (var contexto = new equipodEntities())
            {
                // Devuelve el primer usuario que encuentra con el mismo DNI.
                return contexto.Usuarios.FirstOrDefault(u => u.dni == dni);
            }
        }

        /// <summary>
        /// Consulta un monitor en la base de datos a través de su nombre y apellido.
        /// </summary>
        /// <param name="nombreApellidoMonitor">El nombre y apellido del monitor que se desea consultar.</param>
        /// <returns>
        /// Devuelve el usuario que coincida con el nombre, apellido y tipo de usuario "Monitor".
        /// Si no se encuentra, devuelve null.
        /// </returns>
        public Usuarios consultarMonitorEmail(string nombreApellidoMonitor)
        {
            string nombreMonitor = nombreApellidoMonitor.Split(' ')[0];
            string apellidoMonitor = nombreApellidoMonitor.Split(' ')[1];

            using (var contexto = new equipodEntities())
            {
                // Devuelve el primer usuario que encuentra con el nombre y apellido coincidentes.
                return contexto.Usuarios.FirstOrDefault(u => u.nombre == nombreMonitor && u.apellidos == apellidoMonitor && u.tipo_usuario == "Monitor");
            }
        }

        public int ObtenerIDUsuario(string email)
        {
            using (var contexto = new equipodEntities())
            {
                // Busca el usuario con el email proporcionado y devuelve solo el ID.
                return contexto.Usuarios
                               .Where(u => u.email == email)
                               .Select(u => u.id_usuario) // Selecciona solo el ID.
                               .FirstOrDefault(); // Obtén el primer resultado o un valor predeterminado (null si no encuentra).
            }
        }
    }
}
