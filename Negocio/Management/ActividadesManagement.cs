using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Infrastructure;
using Datos.Repositories;
using Negocio.EntitiesDTO;

namespace Negocio.Management
{
    public class ActividadesManagement
    {
        public List<ActividadesMonitoresDTO> ObtenerProductos()
        {
            List<MonitorActivityViewModel> actividades = new
           Datos.Repositories.ActivityRepository().ObtenerActividadesConMonitores();
            List<ActividadesDTO> ActividadesMonitoresDTO = new List<ActividadesDTO>();
            //Hacemos el Cast
            foreach (var item in actividades)
            {
                var dto = new ActividadesMonitoresDTO();
                dto.NombreMonitor = item.NombreMonitor;
                dto.NombreActividad = item.NombreActividad;

                ActividadesMonitoresDTO.Add(dto);
            }
            return ActividadesMonitoresDTO;
        }

    }
}
