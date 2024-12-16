using Datos.Infrastructure;
using Datos.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAETesting
{
    [TestClass]
    public class ValorarActividadTest
    {
        [TestMethod]
        public void ValorarActividad_CuandoEsCorrecto_RegistraLaValoracionEnLaBaseDeDatos()
        {
            // Arrange
            var actividadId = 1; // ID de la actividad
            var usuarioId = 1; // ID del usuario
            var valoracion = 5; // Valoración dada (entre 1 y 5)

            // Crear un objeto de tipo Valoraciones con los datos necesarios
            Valoraciones valoracionDTO = new Valoraciones();
            valoracionDTO.id_usuario = usuarioId;
            valoracionDTO.id_actividad = actividadId;
            valoracionDTO.valoracion = valoracion;

            // Llamada al repositorio para guardar la valoración de la actividad
            

            // Act
            bool resultado = new Negocio.Management.ActividadManagement().ValorarActividad("apastraher@gmail.com", "Calistenia", 5);
            // Assert
            Assert.IsTrue(resultado, "La valoración no se registró correctamente.");

            // Aquí podrías consultar la base de datos para confirmar que la valoración fue guardada.
        }
    }
}
