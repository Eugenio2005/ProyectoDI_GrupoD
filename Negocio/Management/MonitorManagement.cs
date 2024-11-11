using Datos.Infrastructure;
using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Management
{
    public class MonitorManagement
    {
        public List<UsuariosDTO> ObtenerCategorias() { 
            List<Usuarios> monitores = new Datos.Repositories.MonitorRepository().ObtenerMonitores();
            List<UsuariosDTO> monotiresDTO = new List<UsuariosDTO>();
            //Hacemos el Cast
            foreach (var item in monitores)
            {
                var dto = new UsuariosDTO();
                dto.Nombre = item.nombre;
                dto.Apellidos = item.apellidos;
                monotiresDTO.Add(dto);
            }
            return monotiresDTO;
        }
    }
}
