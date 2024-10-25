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

        public Usuarios ConsultarCliente(string email)
        {
            using (var contexto = new equipodEntities())
            {
                return contexto.Usuarios.FirstOrDefault(u => u.email == email);
            }
        }


    }
}

