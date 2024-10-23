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
        public Boolean ProbarConexion()
        {
            try
            {
                using (var contexto = new equipodEntities())
                {
                    List<administradores> productos = contexto.administradores.ToList();
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
