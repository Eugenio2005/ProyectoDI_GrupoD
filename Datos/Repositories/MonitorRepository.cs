using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositories
{
    public class MonitorRepository
    {
        public bool comprobarMonitorEmail(string emailMonitor)
        {
            using (var contexto = new equipodEntities())
            {
                return contexto.Monitores.Any(m => m.email == emailMonitor);
            }
        }

        public List<Usuarios> ObtenerMonitores()
        {
            List<Usuarios> monitores = new List<Usuarios>();
            try
            {
                // Abrir la BD
                using (var contexto = new equipodEntities())
                {
                    // Filtrar solo los usuarios que sean monitores
                    monitores = contexto.Usuarios
                                        .Where(u => u.tipo_usuario == "Monitor")
                                        .ToList();
                }
                return monitores;
            }
            catch (Exception)
            {
                return monitores;
            }
        }
        }
    }
