using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;

namespace Datos.Repositories
{
    public class ActividadRepository
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
        public BindingList<MonitorActivityViewModel> ObtenerActividadesConMonitores()
        {
            try
            {
                using (var contexto = new equipodEntities())
                {
                    var listaActividades = (from a in contexto.Actividades
                                            join u in contexto.Usuarios on a.email_monitor equals u.email
                                            where u.tipo_usuario == "monitor"
                                            select new MonitorActivityViewModel
                                            {
                                                NombreActividad = a.nombre_actividad,
                                                NombreMonitor = u.nombre,
                                                ApellidoMonitor = u.apellidos
                                            }).ToList();

                    return new BindingList<MonitorActivityViewModel>(listaActividades);
                }
            }
            catch (Exception)
            {
                return new BindingList<MonitorActivityViewModel>();
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