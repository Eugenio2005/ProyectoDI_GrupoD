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
                // Comprueba si el usuario está asociado con la actividad.
                return contexto.Usuarios.Any(u => u.id_usuario == idUsuario && u.Actividades.Any(a => a.id_actividad == idActividad));
            }
        }
    }
}