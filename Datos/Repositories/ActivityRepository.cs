using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Datos.Infrastructure;

namespace Datos.Repositories
{
    public class ActivityRepository
    {

        public void EliminarActividad(string nombreActividad)
        {
            using (var contexto = new equipodEntities())
            {
                Actividades actividadEliminar = contexto.Actividades.FirstOrDefault(x => x.nombre_actividad == nombreActividad);

                if (actividadEliminar != null)
                {
                    contexto.Entry(actividadEliminar).State = EntityState.Deleted;
                    contexto.SaveChanges();
                }
                else
                {
                    // Manejar el caso en el que no se encuentra la actividad
                    Console.WriteLine("No se encontró ninguna actividad con el nombre: " + nombreActividad);
                    // Aquí puedes implementar otras acciones, como registrar un log o mostrar un mensaje de error al usuario.
                }
            }
        }
        public List<MonitorActivityViewModel> ObtenerActividadesConMonitores()
        {
            List<MonitorActivityViewModel> actividadesConMonitores = new List<MonitorActivityViewModel>();
            try
            {
                using (var contexto = new equipodEntities())
                {
                    actividadesConMonitores = (from a in contexto.Actividades
                                               join u in contexto.Usuarios on a.email_monitor equals u.email
                                               where u.tipo_usuario == "monitor"
                                               select new MonitorActivityViewModel
                                               {
                                                   NombreActividad = a.nombre_actividad,
                                                   NombreMonitor = u.nombre  ,
                                                   ApellidoMonitor = u.apellidos
                                               }).ToList();
                }
                return actividadesConMonitores;
            }
            catch (Exception ex)
            {
                // Manejar la excepción de manera adecuada
                return actividadesConMonitores;
            }
        }
    }

    

    public class MonitorActivityViewModel
    {
        public string NombreActividad { get; set; }
        public string NombreMonitor { get; set; }
        public string ApellidoMonitor { get; set; }
    }

}
