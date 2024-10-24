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

        public void AltaCliente(Usuarios cliente)
        {

            using (var contexto = new equipodEntities())
            {
               contexto.Usuarios.Add(cliente);
               contexto.SaveChanges();
            }

        }

        //public users ConsultarCliente(users client)
        //{
        //    using (var contexto = new equipodEntities())
        //    {
        //        return contexto.users.FirstOrDefault(u => u.email == client.email);
        //    }
        //}
    }
}

