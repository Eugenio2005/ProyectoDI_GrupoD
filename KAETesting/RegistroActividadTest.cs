using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.EntitiesDTO;
using Negocio.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAETesting
{
    [TestClass]
    public class RegistroActividadTest
    {
        private ActividadManagement actividadManagement;

        [TestInitialize]
        public void Setup()
        {
            actividadManagement = new ActividadManagement();
        }

        [TestMethod]
        public void CP3_1_1_RegistrarActividadConTodosLosCamposValidos()
        {
            // Arrange
            ActividadDTO actividad = new ActividadDTO
            {
                NombreActividad = "Yoga",
                DescripActividad = "Clase de yoga para principiantes",
                MonitorAsociado = "juan.perez@mail.com"
            };

            // Act
            bool resultado = actividadManagement.AltaActividad(actividad);

            // Assert
            Assert.IsTrue(resultado, "La actividad debería haberse registrado correctamente.");
        }

        [TestMethod]
        public void CP3_1_2_RegistrarActividadConNombreExistente()
        {
            // Arrange
            ActividadDTO actividad = new ActividadDTO
            {
                NombreActividad = "Yoga",
                DescripActividad = "Clase de yoga para novatos",
                MonitorAsociado = "juan.perez@mail.com"
            };

            // Act
            bool resultado = actividadManagement.AltaActividad(actividad);

            // Assert
            Assert.IsFalse(resultado, "La actividad no debería haberse registrado porque el nombre ya existe.");
        }

        [TestMethod]
        public void CP3_1_3_RegistrarActividadSinMonitorAsociado()
        {
            // Arrange
            ActividadDTO actividad = new ActividadDTO
            {
                NombreActividad = "Zumba",
                DescripActividad = "Clase de zumba para novatos",
                MonitorAsociado = "SinMonitor@sinmonitor.com"
            };

            // Act
            bool resultado = actividadManagement.AltaActividad(actividad);

            // Assert
            Assert.IsTrue(resultado, "La actividad se ha registrado sin monitor asociado.");
        }
    }
}
