using Datos.Infrastructure;
using System;
using System.Linq;

namespace Datos.Repositories
{
    public class ActividadUsuarioRepository
    {
        public bool apuntarUsuario(int idUsuario, int idActividad)
        {
            try
            {
                using (var contexto = new equipodEntities())
                {
                    contexto.Usuarios_Actividades.Add(new Usuarios_Actividades
                    {
                        id_usuario = idUsuario,
                        id_actividad = idActividad
                    });

                    contexto.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool ComprobarUsuarioApuntado(int idUsuario, int idActividad)
        {
            using (var contexto = new equipodEntities())
            {
                // Verificar si el usuario está apuntado a la actividad directamente en el return
                return contexto.Usuarios_Actividades
                    .Any(ua => ua.id_usuario == idUsuario && ua.id_actividad == idActividad);
            }
        }
    }
}