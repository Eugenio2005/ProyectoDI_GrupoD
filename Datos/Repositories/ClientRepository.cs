using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositories
{
    public class ClientRepository
    {
        /// <summary>
        /// Agrega un nuevo cliente a la base de datos.
        /// </summary>
        /// <param name="cliente">El objeto que representa al usuario a registrar.</param>
        public void AltaCliente(Usuarios cliente)
        {
            // Utiliza el contexto de la base de datos para realizar operaciones
            using (var contexto = new equipodEntities())
            {
                contexto.Usuarios.Add(cliente); 
                contexto.SaveChanges(); 
            }
        }

        /// <summary>
        /// Consulta un cliente en la base de datos a través de su email.
        /// </summary>
        /// <param name="email">El email del usuario que se desea consultar.</param>
        /// <returns>Devuelve el usuario con el que coincida el email introducido.</returns>
        public Usuarios ConsultarClienteEmail(string email)
        {
            using (var contexto = new equipodEntities())
            {
                // Devuelve el primer usuario que encuentra con el mismo email.
                return contexto.Usuarios.FirstOrDefault(u => u.email == email);
            }
        }

        /// <summary>
        /// Consulta un cliente en la base de datos a través de su email.
        /// </summary>
        /// <param name="email">El email del usuario que se desea consultar.</param>
        /// <returns>Devuelve el usuario con el que coincida el email introducido.</returns>
        public Usuarios ConsultarClienteDNI(string dni)
        {
            using (var contexto = new equipodEntities())
            {
                // Devuelve el primer usuario que encuentra con el mismo email.
                return contexto.Usuarios.FirstOrDefault(u => u.dni == dni);
            }
        }
    }
}
