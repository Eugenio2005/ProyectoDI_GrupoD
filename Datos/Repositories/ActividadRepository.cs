using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;

namespace Datos.Repositories
{
    /// <summary>
    /// Clase que gestiona las operaciones relacionadas con las actividades en la base de datos.
    /// Permite dar de alta, eliminar actividades y obtener una lista de actividades con sus monitores asociados.
    /// </summary>
    public class ActividadRepository
    {
        /// <summary>
        /// Registra una nueva actividad en la base de datos.
        /// </summary>
        /// <param name="actividad">El objeto Actividades que contiene los datos de la actividad a registrar.</param>
        public void AltaActividad(Actividades actividad)
        {
            // Utiliza el contexto de la base de datos para realizar operaciones
            using (var contexto = new equipodEntities())
            {
                contexto.Actividades.Add(actividad);
                contexto.SaveChanges();
            }
        }

        /// <summary>
        /// Elimina una actividad de la base de datos por su nombre.
        /// Si la actividad no existe, muestra un mensaje indicando que no se encontró.
        /// </summary>
        /// <param name="nombreActividad">El nombre de la actividad a eliminar.</param>
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

        /// <summary>
        /// Obtiene todas las actividades junto con el nombre y apellido de los monitores asociados.
        /// </summary>
        /// <returns>
        /// Una lista de objetos MonitorActivityViewModel que contiene la actividad y los datos del monitor.
        /// </returns>
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

    /// <summary>
    /// ViewModel utilizado para mostrar la actividad y el monitor asociado.
    /// </summary>
    public class MonitorActivityViewModel
    {
        public string NombreActividad { get; set; }
        public string NombreMonitor { get; set; }
        public string ApellidoMonitor { get; set; }
    }
}
