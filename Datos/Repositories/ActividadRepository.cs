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
        public BindingList<MonitorActivityViewModel> ObtenerTodasActividades()
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

        public BindingList<ClientActivityViewModel> ObtenerActividadesClientes()
        {
            try
            {
                using (var contexto = new equipodEntities())
                {
                    var listaActividades = (from a in contexto.Actividades
                                            join u in contexto.Usuarios on a.email_monitor equals u.email
                                            where u.tipo_usuario == "Monitor"
                                            select new ClientActivityViewModel
                                            {
                                                NombreActividad = a.nombre_actividad,
                                                DescripActividad = a.descripcion,
                                                NombreMonitor = u.nombre,
                                                ApellidoMonitor = u.apellidos,
                                                Valoracion_media = (a.valoracion_media ?? 0),
                                            }).ToList();

                    return new BindingList<ClientActivityViewModel>(listaActividades);
                }
            }
            catch (Exception)
            {
                return new BindingList<ClientActivityViewModel>();
            }
        }


        /// <summary>
        /// Obtiene todas las actividades junto con el nombre y apellido de los monitores asociados.
        /// </summary>
        /// <returns>
        /// Una lista de objetos MonitorActivityViewModel que contiene la actividad y los datos del monitor.
        /// </returns>
        public BindingList<ClientActivityViewModel> ObtenerActividadesClienteApuntado(string email)
        {
            try
            {
                using (var contexto = new equipodEntities())
                {
                    var listaActividades = (from a in contexto.Usuarios_Actividades
                                            join ac in contexto.Actividades on a.id_actividad equals ac.id_actividad
                                            join u in contexto.Usuarios on a.id_usuario equals u.id_usuario
                                            join m in contexto.Usuarios on ac.email_monitor equals m.email
                                            where u.email == email// Unir con la tabla Usuarios para obtener los datos del monitor                                            where u.email == email // Asegurarse de que el email coincida
                                            select new ClientActivityViewModel
                                            {
                                                NombreActividad = ac.nombre_actividad,
                                                NombreMonitor = m.nombre,  // Obtener el nombre del monitor desde la tabla Usuarios
                                                ApellidoMonitor = m.apellidos, // Obtener el apellido del monitor desde la tabla Usuarios
                                                DescripActividad = ac.descripcion,
                                                Valoracion = a.valoracion // Obtener la valoración de la tabla Valoraciones
                                            }).ToList();

                    return new BindingList<ClientActivityViewModel>(listaActividades);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);  // Mostrar mensaje de error para depuración
                return new BindingList<ClientActivityViewModel>();
            }
        }


        public int ObtenerIDActividad(string nombreActividad)
        {
            using (var contexto = new equipodEntities())
            {
                // Busca el usuario con el email proporcionado y devuelve solo el ID.
                return contexto.Actividades
                               .Where(u => u.nombre_actividad == nombreActividad)
                               .Select(u => u.id_actividad) // Selecciona solo el ID.
                               .FirstOrDefault(); // Obtén el primer resultado o un valor predeterminado (null si no encuentra).
            }
        }
    
        public List<Actividades> ObtenerTop5Actividades()
        {
            try
            {
                using (var contexto = new equipodEntities())
                {
                    var top5Actividades = contexto.Actividades
                                                  .OrderByDescending(a => a.valoracion_media)
                                                  .Take(5)
                                                  .ToList();
                    return top5Actividades;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);  // Mostrar mensaje de error para depuración
                return new List<Actividades>();
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

    /// <summary>
    /// ViewModel utilizado para mostrar la actividad y el monitor asociado.
    /// </summary>
    public class ClientActivityViewModel
    {
        public string NombreActividad { get; set; }
        public string DescripActividad { get; set; }
        public string NombreMonitor { get; set; }
        public string ApellidoMonitor { get; set; }
        public double? Valoracion_media {  get; set; }
        public int? Valoracion {  get; set; }
    }
}
