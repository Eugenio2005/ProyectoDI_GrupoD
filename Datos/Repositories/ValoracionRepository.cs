using Datos.Infrastructure;
using System;
using System.Linq;

namespace Datos.Repositories
{
    public class ValoracionRepository
    {
        public void valorarActividad(Valoraciones valoracion)
        {
            using (var contexto = new equipodEntities())
            {
                contexto.Valoraciones.Add(valoracion);
                contexto.SaveChanges();
            }

            // Verificar si la relación ya existe en la tabla Usuarios_Actividades
            using (var contexto = new equipodEntities())
            {
                var actividadExistente = contexto.Usuarios_Actividades
                    .FirstOrDefault(ua => ua.id_actividad == valoracion.id_actividad && ua.id_usuario == valoracion.id_usuario);

                if (actividadExistente == null)
                {
                    // Si no existe la relación, crearla
                    Usuarios_Actividades usuarios_Actividades = new Usuarios_Actividades
                    {
                        id_usuario = valoracion.id_usuario,
                        id_actividad = valoracion.id_actividad,
                        valoracion = valoracion.valoracion
                    };
                    contexto.Usuarios_Actividades.Add(usuarios_Actividades);
                    contexto.SaveChanges();
                }
                else
                {
                    // Si ya existe la relación, actualizar la valoración
                    actividadExistente.valoracion = valoracion.valoracion;
                    contexto.SaveChanges();
                }
            }
        }

        public void ActualizarValoracion(Valoraciones nuevaValoracion)
        {
            using (var contexto = new equipodEntities())
            {
                // Buscar la valoración existente en la tabla Valoraciones
                var valoracionExistente = contexto.Valoraciones
                    .FirstOrDefault(v => v.id_actividad == nuevaValoracion.id_actividad && v.id_usuario == nuevaValoracion.id_usuario);

                if (valoracionExistente != null)
                {
                    // Actualiza los valores en la tabla Valoraciones
                    valoracionExistente.valoracion = nuevaValoracion.valoracion;

                    // Busca el registro relacionado en Usuarios_Actividades
                    var actividadExistente = contexto.Usuarios_Actividades
                        .FirstOrDefault(ua => ua.id_actividad == nuevaValoracion.id_actividad && ua.id_usuario == nuevaValoracion.id_usuario);

                    if (actividadExistente != null)
                    {
                        // Actualiza los valores en la tabla Usuarios_Actividades
                        actividadExistente.valoracion = nuevaValoracion.valoracion;
                    }
                    else
                    {
                        // Si no existe un registro relacionado, lo crea
                        Usuarios_Actividades nuevaActividad = new Usuarios_Actividades
                        {
                            id_usuario = nuevaValoracion.id_usuario,
                            id_actividad = nuevaValoracion.id_actividad,
                            valoracion = nuevaValoracion.valoracion
                        };

                        contexto.Usuarios_Actividades.Add(nuevaActividad);
                    }

                    // Guarda los cambios en ambas tablas
                    contexto.SaveChanges();
                }
                else
                {
                    throw new InvalidOperationException("No se encontró una valoración existente para actualizar.");
                }
            }
        }
    }
}
