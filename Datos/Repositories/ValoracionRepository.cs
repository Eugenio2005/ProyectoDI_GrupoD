using Datos.Infrastructure;
using System;
using System.Linq;

namespace Datos.Repositories
{
    public class ValoracionRepository
    {
        /// <summary>
        /// Valora una actividad por un usuario específico.
        /// Si la relación entre el usuario y la actividad no existe, se crea una nueva, 
        /// de lo contrario, se actualiza la valoración existente.
        /// </summary>
        /// <param name="valoracion">Objeto de tipo <see cref="Valoraciones"/> que contiene la información de la valoración.</param>
        public void valorarActividad(Valoraciones valoracion)
        {
            // Guardar la valoración en la tabla Valoraciones
            using (var contexto = new equipodEntities())
            {
                contexto.Valoraciones.Add(valoracion);
                contexto.SaveChanges();
                ActualizarMediaValoracion(valoracion.id_actividad); // Actualizar la media de valoración
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

        /// <summary>
        /// Actualiza la valoración de una actividad para un usuario específico.
        /// Si no existe una valoración previa, se crea un nuevo registro.
        /// </summary>
        /// <param name="nuevaValoracion">Objeto de tipo <see cref="Valoraciones"/> que contiene la nueva valoración.</param>
        /// <exception cref="InvalidOperationException">Se lanza si no se encuentra una valoración existente para actualizar.</exception>
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
                    ActualizarMediaValoracion(nuevaValoracion.id_actividad); // Actualizar la media de valoración
                }
                else
                {
                    // Si no se encuentra una valoración para actualizar, se lanza una excepción
                    throw new InvalidOperationException("No se encontró una valoración existente para actualizar.");
                }
            }
        }

        /// <summary>
        /// Actualiza la media de las valoraciones para una actividad específica.
        /// Calcula el promedio de todas las valoraciones asociadas a la actividad.
        /// </summary>
        /// <param name="id_actividad">El ID de la actividad cuya media de valoraciones será actualizada.</param>
        private void ActualizarMediaValoracion(int id_actividad)
        {
            using (var contexto = new equipodEntities())
            {
                // Calcular la media de las valoraciones para la actividad
                var valoraciones = contexto.Valoraciones
                    .Where(v => v.id_actividad == id_actividad)
                    .ToList();

                if (valoraciones.Any())
                {
                    float media = (float)valoraciones.Average(v => v.valoracion);

                    // Obtener la actividad correspondiente
                    var actividad = contexto.Actividades
                        .FirstOrDefault(a => a.id_actividad == id_actividad);

                    if (actividad != null)
                    {
                        // Verificar si ya existe una valoración media en la actividad
                        if (actividad.valoracion_media != null)
                        {
                            // Si existe, actualizamos la media
                            actividad.valoracion_media = media;
                        }
                        else
                        {
                            // Si no existe, asignamos la nueva media
                            actividad.valoracion_media = media;
                        }

                        // Guardar los cambios en la tabla Actividades
                        contexto.SaveChanges();
                    }
                }
            }
        }
    }
}
