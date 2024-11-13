using Datos.Infrastructure;
using System;

namespace Datos.Repositories
{
    public class ActividadesRepository
    {

        public void AltaActividad(Actividades actividad)
        {
            // Utiliza el contexto de la base de datos para realizar operaciones
            using (var contexto = new equipodEntities())
            {
                contexto.Actividades.Add(actividad);
                contexto.SaveChanges();
            }
        }
    }
}