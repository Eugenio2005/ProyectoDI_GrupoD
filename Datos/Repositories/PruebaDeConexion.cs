using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositories
{
    public class PruebaDeConexion
    {
        public bool ProbarConexion()
        {
            try
            {
                using (var contexto = new equipodEntities())
                {
                    List<Usuarios> productos = contexto.Usuarios.ToList();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
