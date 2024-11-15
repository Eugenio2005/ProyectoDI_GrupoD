using Datos.Infrastructure;
using Datos.Repositories;
using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                email_monitor = string.IsNullOrWhiteSpace(actividadDTO.MonitorAsociado) ? "Sin monitor" : actividadDTO.MonitorAsociado
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
                new Datos.Repositories.ActividadRepository().AltaActividad(actividad);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public BindingList<ActividadesMonitoresDTO> ObtenerActividades()
        {
            BindingList<MonitorActivityViewModel> actividades = new
            Datos.Repositories.ActividadRepository().ObtenerActividadesConMonitores();
            BindingList<ActividadesMonitoresDTO> ActividadesMonitoresDTO = new BindingList<ActividadesMonitoresDTO>();
            //Hacemos el Cast
            foreach (var item in actividades)
            {
                var dto = new ActividadesMonitoresDTO();
                dto.NombreMonitor = item.NombreMonitor;
                dto.NombreActividad = item.NombreActividad;
                dto.ApellidoMonitor = item.ApellidoMonitor;
                ActividadesMonitoresDTO.Add(dto);
            }
            return ActividadesMonitoresDTO;
        }

        public void EliminarActividad(ActividadesMonitoresDTO actividad)
        {
            string nombre = actividad.NombreActividad;
            new Datos.Repositories.ActividadRepository().EliminarActividad(nombre);
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
