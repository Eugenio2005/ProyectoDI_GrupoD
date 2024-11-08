using System;
using System.Collections.Generic;
using System.Linq;
using Datos.Infrastructure;

namespace Datos.Repositories
{
    public class ActivityRepository
    {
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
                                                   NombreMonitor = u.nombre + " " + u.apellidos,
                                                   EmailMonitor = u.email
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
        public string EmailMonitor { get; set; }
    }
}