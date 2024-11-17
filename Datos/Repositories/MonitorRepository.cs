using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositories
{
    /// <summary>
    /// Repositorio que gestiona las operaciones relacionadas con los monitores en la base de datos.
    /// Incluye métodos para comprobar la existencia de un monitor por email y obtener la lista de monitores.
    /// </summary>
    public class MonitorRepository
    {
        /// <summary>
        /// Comprueba si un monitor existe en la base de datos a través de su email.
        /// </summary>
        /// <param name="emailMonitor">El email del monitor que se desea comprobar.</param>
        /// <returns>
        /// Devuelve true si el monitor existe con el email proporcionado, false en caso contrario.
        /// </returns>
        public bool comprobarMonitorEmail(string emailMonitor)
        {
            using (var contexto = new equipodEntities())
            {
                // Verifica si existe algún monitor con el email proporcionado
                return contexto.Monitores.Any(m => m.email == emailMonitor);
            }
        }

        /// <summary>
        /// Obtiene una lista de todos los monitores registrados en la base de datos.
        /// </summary>
        /// <returns>
        /// Devuelve una lista de objetos de tipo Usuarios que son monitores.
        /// Si ocurre un error, devuelve una lista vacía.
        /// </returns>
        public List<Usuarios> ObtenerMonitores()
        {
            List<Usuarios> monitores = new List<Usuarios>();
            try
            {
                // Abrir la base de datos y consultar los monitores
                using (var contexto = new equipodEntities())
                {
                    // Filtra los usuarios que tienen tipo de usuario "Monitor"
                    monitores = contexto.Usuarios
                                        .Where(u => u.tipo_usuario == "Monitor")
                                        .ToList();
                }
                return monitores;
            }
            catch (Exception)
            {
                // En caso de error, devuelve una lista vacía
                return monitores;
            }
        }
    }
}
