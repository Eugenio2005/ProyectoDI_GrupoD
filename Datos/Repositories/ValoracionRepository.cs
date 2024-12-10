using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositories
{
    public class ValoracionRepository
    {

        public void valorarActividad(Valoraciones valoracion)
        {
            using (var contexto = new equipodEntities())
            {
                contexto.Valoraciones.Add(valoracion);
                contexto.SaveChanges();
            }
        }
    }
}
