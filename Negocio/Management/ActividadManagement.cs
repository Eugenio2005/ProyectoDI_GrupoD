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
    /// <summary>
    /// Clase que gestiona las actividades del gimnasio.
    /// Permite dar de alta, obtener y eliminar actividades, y verificar la existencia de monitores.
    /// </summary>
    public class ActividadManagement
    {
        /// <summary>
        /// Registra una nueva actividad en el sistema.
        /// Si se proporciona un monitor, se verifica si este existe en la base de datos.
        /// </summary>
        /// <param name="actividadDTO">Objeto que contiene los datos de la actividad.</param>
        /// <returns>
        /// true si la actividad se registra correctamente, 
        /// false si ocurre un error o el monitor no existe.
        /// </returns>
        public bool AltaActividad(ActividadDTO actividadDTO)
        {
            // Crear la actividad con los datos proporcionados
            Actividades actividad = new Actividades
            {
                nombre_actividad = actividadDTO.NombreActividad,
                descripcion = actividadDTO.DescripActividad,
                email_monitor = string.IsNullOrWhiteSpace(actividadDTO.MonitorAsociado) ? "Sin monitor" : actividadDTO.MonitorAsociado
            };

            // Verificar si se ha proporcionado un monitor
            if (actividad.email_monitor != null)
            {
                // Comprobar si el monitor existe en la tabla Monitores
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

        /// <summary>
        /// Obtiene todas las actividades junto con la información del monitor asociado.
        /// </summary>
        /// <returns>
        /// Una lista de objetos ActividadesMonitoresDTO que contiene el nombre y apellido del monitor y el nombre de la actividad.
        /// </returns>
        public BindingList<ActividadesMonitoresDTO> ObtenerActividades(String email)
        {
            BindingList<ClientActivityViewModel> actividades = new
            Datos.Repositories.ActividadRepository().ObtenerActividadesClienteApuntado(email);
            BindingList<ActividadesMonitoresDTO> ActividadesMonitoresDTO = new BindingList<ActividadesMonitoresDTO>();

            // Hacemos el Cast
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

        public BindingList<ActividadesClientesDTO> ObtenerActividadesClienteApuntado(String email)
        {
            BindingList<ClientActivityViewModel> actividades = new
            Datos.Repositories.ActividadRepository().ObtenerActividadesClienteApuntado(email);
            BindingList<ActividadesClientesDTO> actividadesClientesDTO = new BindingList<ActividadesClientesDTO>();

            // Hacemos el Cast
            foreach (var item in actividades)
            {
                var dto = new ActividadesClientesDTO();
                dto.NombreMonitor = item.NombreMonitor;
                dto.NombreActividad = item.NombreActividad;
                dto.ApellidoMonitor = item.ApellidoMonitor;
                dto.DescripActividad = item.DescripActividad;

                actividadesClientesDTO.Add(dto);
                
            }
            return actividadesClientesDTO;
        }

        /// <summary>
        /// Elimina una actividad del sistema a partir de su nombre.
        /// </summary>
        /// <param name="actividad">Objeto que contiene la actividad a eliminar.</param>
        public void EliminarActividad(ActividadesClientesDTO actividad)
        {
            string nombre = actividad.NombreActividad;
            new Datos.Repositories.ActividadRepository().EliminarActividad(nombre);
        }

        /// <summary>
        /// Verifica si un monitor con el correo electrónico proporcionado existe en la base de datos.
        /// </summary>
        /// <param name="email_monitor">El correo electrónico del monitor.</param>
        /// <returns>
        /// true si el monitor existe, false si no.
        /// </returns>
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

        public BindingList<ActividadesClientesDTO> ObtenerActividadesClientes()
        {
            BindingList<ClientActivityViewModel> actividades = new
            Datos.Repositories.ActividadRepository().ObtenerActividadesClientes();
            BindingList<ActividadesClientesDTO> ActividadesClientesDTO = new BindingList<ActividadesClientesDTO>();

            // Hacemos el Cast
            foreach (var item in actividades)
            {
                var dto = new ActividadesClientesDTO();
                dto.NombreMonitor = item.NombreMonitor;
                dto.ApellidoMonitor = item.ApellidoMonitor;
                dto.DescripActividad = item.DescripActividad;
                dto.NombreActividad = item.NombreActividad;

                ActividadesClientesDTO.Add(dto);
            }
            return ActividadesClientesDTO;
        }

        public void valorarActividad(string email, string nombreActividad, int valoracion)
        {
            int idActividad = new Datos.Repositories.ActividadRepository().ObtenerIDActividad(nombreActividad);
            int idUsuario = new Datos.Repositories.ClientRepository().ObtenerIDUsuario(email);
            Valoraciones valoracionDTO = new Valoraciones();
            valoracionDTO.id_usuario = idUsuario;
            valoracionDTO.id_actividad = idActividad;
            valoracionDTO.valoracion = valoracion;
            new Datos.Repositories.ValoracionRepository().valorarActividad(valoracionDTO);


        }
    }
}
