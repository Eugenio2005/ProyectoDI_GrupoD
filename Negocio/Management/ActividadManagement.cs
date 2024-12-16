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
                dto.Valoracion = item.Valoracion;

                actividadesClientesDTO.Add(dto);
                
            }
            return actividadesClientesDTO;
        }

        /// <summary>
        /// Elimina una actividad del sistema a partir de su nombre.
        /// </summary>
        /// <param name="actividad">Objeto que contiene la actividad a eliminar.</param>
        public void EliminarActividad(ActividadesMonitoresDTO actividad)
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

        /// <summary>
        /// Obtiene la lista de actividades de los clientes, convirtiéndolas a un DTO.
        /// </summary>
        /// <returns>
        /// Una lista enlazada de tipo <see cref="BindingList{ActividadesClientesDTO}"/> que contiene las actividades de los clientes.
        /// </returns>
        public BindingList<ActividadesClientesDTO> ObtenerActividadesClientes()
        {
            // Llamada al repositorio para obtener las actividades de los clientes
            BindingList<ClientActivityViewModel> actividades = new Datos.Repositories.ActividadRepository().ObtenerActividadesClientes();
            BindingList<ActividadesClientesDTO> ActividadesClientesDTO = new BindingList<ActividadesClientesDTO>();

            // Hacemos el Cast de las actividades obtenidas a DTO
            foreach (var item in actividades)
            {
                var dto = new ActividadesClientesDTO();
                dto.NombreMonitor = item.NombreMonitor;
                dto.ApellidoMonitor = item.ApellidoMonitor;
                dto.DescripActividad = item.DescripActividad;
                dto.NombreActividad = item.NombreActividad;
                dto.Valoracion_media = (item.Valoracion_media ?? 0);
                ActividadesClientesDTO.Add(dto); // Agregar el DTO a la lista
            }
            return ActividadesClientesDTO; // Retornar la lista de actividades convertidas a DTO
        }

        public BindingList<ActividadesMonitoresDTO> ObtenerTodasActividades()
        {
            BindingList<MonitorActivityViewModel> actividades = new
            Datos.Repositories.ActividadRepository().ObtenerTodasActividades();
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

        /// <summary>
        /// Permite valorar una actividad por parte de un usuario. Si la actividad no tiene valoración, se asigna una nueva valoración.
        /// </summary>
        /// <param name="email">El correo electrónico del usuario que realiza la valoración.</param>
        /// <param name="nombreActividad">El nombre de la actividad a valorar.</param>
        /// <param name="valoracion">El valor de la valoración (de 1 a 5).</param>
        /// <returns>Devuelve true si la valoración se registró correctamente; false en caso contrario.</returns>
        public bool ValorarActividad(string email, string nombreActividad, int valoracion)
        {
            try
            {
                // Obtener el ID de la actividad a partir del nombre
                int idActividad = new Datos.Repositories.ActividadRepository().ObtenerIDActividad(nombreActividad);

                if (idActividad == 0)
                {
                    // No se encontró la actividad
                    return false;
                }

                // Obtener el ID del usuario a partir del correo electrónico
                int idUsuario = new Datos.Repositories.ClientRepository().ObtenerIDUsuario(email);

                if (idUsuario == 0)
                {
                    // No se encontró el usuario
                    return false;
                }

                // Crear un objeto de tipo Valoraciones con los datos necesarios
                Valoraciones valoracionDTO = new Valoraciones
                {
                    id_usuario = idUsuario,
                    id_actividad = idActividad,
                    valoracion = valoracion
                };

                // Llamada al repositorio para guardar la valoración de la actividad
                new Datos.Repositories.ValoracionRepository().valorarActividad(valoracionDTO);

                // Si llega aquí, la operación fue exitosa
                return true;
            }
            catch (Exception)
            {
                // Manejar errores si es necesario
                return false;
            }
        }


        /// <summary>
        /// Actualiza la valoración de una actividad para un usuario específico.
        /// </summary>
        /// <param name="email">El correo electrónico del usuario cuya valoración se actualizará.</param>
        /// <param name="nombreActividad">El nombre de la actividad cuya valoración se actualizará.</param>
        /// <param name="valoracion">El nuevo valor de la valoración (de 1 a 5).</param>
        public void actualizarValoracion(string email, string nombreActividad, int valoracion)
        {
            // Obtener el ID de la actividad a partir del nombre
            int idActividad = new Datos.Repositories.ActividadRepository().ObtenerIDActividad(nombreActividad);

            // Obtener el ID del usuario a partir del correo electrónico
            int idUsuario = new Datos.Repositories.ClientRepository().ObtenerIDUsuario(email);

            // Crear un objeto de tipo Valoraciones con los datos necesarios
            Valoraciones valoracionDTO = new Valoraciones();
            valoracionDTO.id_usuario = idUsuario;
            valoracionDTO.id_actividad = idActividad;
            valoracionDTO.valoracion = valoracion;

            // Llamada al repositorio para actualizar la valoración de la actividad
            new Datos.Repositories.ValoracionRepository().ActualizarValoracion(valoracionDTO);
        }
    }
}
