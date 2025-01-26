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
                    // Agregar la relación entre usuario y actividad
                    contexto.Usuarios_Actividades.Add(new Usuarios_Actividades
                    {
                        id_usuario = idUsuario,
                        id_actividad = idActividad,
                        valoracion = 0
                    });

                    // Buscar la actividad a la que el usuario se está apuntando
                    var actividad = contexto.Actividades
                        .FirstOrDefault(a => a.id_actividad == idActividad);

                    if (actividad != null)
                    {
                        // Sumar 1 al contador de usuarios apuntados en la actividad
                        actividad.numUsuariosApuntados = actividad.numUsuariosApuntados.HasValue
                            ? actividad.numUsuariosApuntados.Value + 1
                            : 1;

                        // Guardar los cambios en la actividad
                        contexto.SaveChanges();
                    }

                    // Guardar los cambios de la relación
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

                        // Restar 1 al contador de usuarios apuntados en la actividad
                        var actividad = contexto.Actividades
                            .FirstOrDefault(a => a.id_actividad == idActividad);

                        if (actividad != null)
                        {
                            actividad.numUsuariosApuntados = actividad.numUsuariosApuntados.HasValue
                                ? actividad.numUsuariosApuntados.Value - 1
                                : 0;

                            // Guardar cambios en la actividad
                            contexto.SaveChanges();
                        }

                        // Guardar los cambios para la eliminación de la relación
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