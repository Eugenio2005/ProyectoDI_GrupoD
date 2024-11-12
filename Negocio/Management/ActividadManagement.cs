using Datos.Infrastructure;
using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Management
{
    public class ActividadManagement
    {
        public bool AltaActividad(ActividadDTO actividadDTO)
        {
            // Crear la actividad con los datos proporcionados
            Actividades actividad = new Actividades
            {
                nombre_actividad = actividadDTO.NombreActividad,
                descripcion = actividadDTO.DescripActividad,
                email_monitor = string.IsNullOrWhiteSpace(actividadDTO.MonitorAsociado) ? null : actividadDTO.MonitorAsociado
            };

            //Verificar si se ha proporcionado un monitor
            if (actividad.email_monitor != null)
            {

                //Comprobar si el monitor existe en la tabla Monitores
                bool monitorExistente = comprobarMonitor(actividad.email_monitor);
                if (!monitorExistente)
                {
                    return false;
                }

            }

            try
            {
                // Si la validación es correcta, registrar la actividad
                new Datos.Repositories.ActividadesRepository().AltaActividad(actividad);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private bool comprobarMonitor(string email_monitor)
        {
            bool monitorExiste = new Datos.Repositories.MonitorRepository().comprobarMonitorEmail(email_monitor);

            if (monitorExiste)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
