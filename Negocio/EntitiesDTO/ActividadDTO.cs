using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.EntitiesDTO
{
    public class ActividadDTO
    {
        private string nombreActividad, descripActividad, monitorAsociado;
        private float valoracion_media;

        public string NombreActividad { get; set; }
        public string DescripActividad { get; set; }
        public string MonitorAsociado { get; set; }
        public double Valoracion_media { get; set; }
    }
}
