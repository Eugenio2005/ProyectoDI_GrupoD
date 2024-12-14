using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.EntitiesDTO
{
    public class ActividadesClientesDTO
    {
        private string nombreActividad, descripActividad, nombreMonitor, apellidoMonitor;
        private int valoracion;
        public float valoracion_media;
        public string NombreActividad { get; set; }
        public string DescripActividad { get; set; }
        public string NombreMonitor { get; set; }
        public string ApellidoMonitor { get; set; }
        public float Valoracion_media { get; set; }
        public int Valoracion { get; set; }
    }
}
