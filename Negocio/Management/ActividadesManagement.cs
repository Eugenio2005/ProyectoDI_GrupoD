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
        public void EliminarActividad(ActividadesMonitoresDTO actividad)
        {
            string nombre = actividad.NombreActividad;
          new Datos.Repositories.ActivityRepository().EliminarActividad(nombre);
        }

        public List<ActividadesMonitoresDTO> ObtenerProductos()
        {
            List<MonitorActivityViewModel> actividades = new
           Datos.Repositories.ActivityRepository().ObtenerActividadesConMonitores();
            List<ActividadesMonitoresDTO> ActividadesMonitoresDTO = new List<ActividadesMonitoresDTO>();
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

    }
}
