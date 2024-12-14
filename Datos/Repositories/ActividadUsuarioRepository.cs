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
                        id_actividad = idActividad,
                        valoracion = 0
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
        public bool ComprobarActividadValorada(int idUsuario, int idActividad)
        {
            using (var contexto = new equipodEntities())
            {
                // Verificar si el usuario a valorado la actividad directamente en el return
                return contexto.Valoraciones
                    .Any(ua => ua.id_usuario == idUsuario && ua.id_actividad == idActividad);
            }
        }

        public bool desapuntarUsuario(int idUsuario, int idActividad)
        {
            try
            {
                using (var contexto = new equipodEntities())
                {
                    // Buscar el registro que asocia al usuario con la actividad
                    var usuarioActividad = contexto.Usuarios_Actividades
                        .FirstOrDefault(ua => ua.id_usuario == idUsuario && ua.id_actividad == idActividad);

                    if (usuarioActividad != null)
                    {
                        // Eliminar el registro de la relación
                        contexto.Usuarios_Actividades.Remove(usuarioActividad);
                        contexto.SaveChanges();
                        return true;
                    }

                    return false; // No se encontró el registro
                }
            }
            catch
            {
                return false; // Hubo un error
            }
        }

    }
}