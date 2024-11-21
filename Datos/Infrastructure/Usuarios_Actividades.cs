using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Infrastructure
{
    public class Usuarios_Actividades
    {
        public int id_usuario { get; set; }
        public int id_actividad { get; set; }

        // Propiedades de navegación
        public virtual Usuarios Usuario { get; set; }
        public virtual Actividades Actividad { get; set; }
    }
}
