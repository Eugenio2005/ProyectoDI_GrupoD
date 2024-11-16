using Datos.Infrastructure;
using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Management
{
    /// <summary>
    /// Clase que gestiona la información de los monitores.
    /// Permite obtener una lista de monitores con sus datos básicos.
    /// </summary>
    public class MonitorManagement
    {
        /// <summary>
        /// Obtiene la lista de monitores y sus datos asociados (nombre, apellidos, email).
        /// </summary>
        /// <returns>
        /// Una lista de objetos UsuariosDTO que contienen los datos de los monitores.
        /// </returns>
        public List<UsuariosDTO> ObtenerMonitores()
        {
            // Obtener la lista de monitores desde el repositorio
            List<Usuarios> monitores = new Datos.Repositories.MonitorRepository().ObtenerMonitores();

            // Crear una lista de DTOs para mapear los datos de los monitores
            List<UsuariosDTO> monitoresDTO = new List<UsuariosDTO>();

            // Hacer el cast de los objetos 'Usuarios' a 'UsuariosDTO'
            foreach (var item in monitores)
            {
                var dto = new UsuariosDTO();
                dto.Nombre = item.nombre;
                dto.Apellidos = item.apellidos;
                dto.Email = item.email;
                monitoresDTO.Add(dto);
            }

            // Retornar la lista de monitores mapeada
            return monitoresDTO;
        }
    }
}
