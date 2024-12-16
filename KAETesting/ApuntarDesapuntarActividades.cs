using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.EntitiesDTO;
using Negocio.Management;
using System;

namespace KAETesting
{
    [TestClass]
    public class ApuntarDesapuntarActividades
    {
        private ActividadManagement actividadManagement;
        private UsuarioManagement usuarioManagement;
        private UsuariosDTO usuario;
        private ActividadDTO actividad;

        [TestInitialize]
        public void Setup()
        {
            // Instanciar las capas de negocio y objetos necesarios
            actividadManagement = new ActividadManagement();
            usuarioManagement = new UsuarioManagement();

            
        }

        [TestMethod]
        public void CP1_1_1_ApuntarActividad()
        {
            ActividadDTO actividad = new ActividadDTO();
            actividad.NombreActividad = "Zumba";
            actividad.DescripActividad = "Calentamiento";
            actividad.MonitorAsociado = "SinMonitor@sinmonitor.com";

            new ActividadManagement().AltaActividad(actividad);

            bool usuarioApuntado = usuarioManagement.apuntarUsuarioActividad("apastraher@gmail.com", "Zumba");

            Assert.IsTrue(usuarioApuntado, "El usuario ha sido apuntado exitosamente");
        }

        [TestMethod]
        public void CP2_1_1_DesapuntarActividad()
        {
            // Suponer que el usuario ya está apuntado
            bool desapuntarUsuario = usuarioManagement.desapuntarUsuarioActividad("apastraher@gmail.com", "Zumba");

            // Verificar que el resultado sea positivo
            Assert.IsTrue(desapuntarUsuario, "El usuario no pudo desapuntarse de la actividad.");
        }
    }
}
