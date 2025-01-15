using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.EntitiesDTO
{
    public class ActividadesMonitoresDTO
    {
        private string nombreActividad, nombreMonitor, apellidoMonitor;
        private int numUsuariosApuntados;
        private float valoracionMedia;

        public string NombreActividad { get; set; }
        public string NombreMonitor { get; set; }
        public string ApellidoMonitor { get; set; }
        public int NumUsuariosApuntados { get; set; }
        public float ValoracionMedia { get; set; }
    }
}
