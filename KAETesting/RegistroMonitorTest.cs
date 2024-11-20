using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System;
using Datos.Infrastructure;
using Datos.Repositories;
using Negocio.Management;
using Negocio.EntitiesDTO;
using ProyectoDI_GrupoD.Vistas;

namespace ProyectoDI_GrupoD
{
    [TestClass]
    public class RegistroMonitorTests
    {
        RegistroMonitor registroMonitor = new RegistroMonitor();
        [TestMethod]
        public void CP1_1_1_RegistrarMonitorConTodosLosCamposValidos()
        {
            // Arrange
            UsuariosDTO usuarioMonitor = new UsuariosDTO
            {
                Nombre = "Juan",
                Apellidos = "Pérez",
                Dni = "12345678A",
                Email = "juan.perez@mail.com",
                Direccion = "Calle Falsa 123",
                Telefono = "600123456",
                Contraseña = "Password123"
            };

            MonitorDTO monitor = new MonitorDTO
            {
                Email = "juan.perez@mail.com",
            };

            // Act
            bool resultado = new UsuarioManagement().AltaMonitor(usuarioMonitor, monitor);

            // Assert
            Assert.IsTrue(resultado, "El monitor se registró correctamente.");
        }

        [TestMethod]
        public void CP1_1_2_RegistrarMonitorSinDireccionYTelefono()
        {
            // Arrange
            UsuariosDTO usuarioMonitor = new UsuariosDTO
            {
                Nombre = "Juan",
                Apellidos = "Pérez",
                Dni = "45645687R",
                Email = "juanPerez@mail.com",
                Direccion = null,
                Telefono = null,
                Contraseña = "Password123"
            };

            MonitorDTO monitor = new MonitorDTO
            {
                Email = "JuanPerez@mail.com",
            };

            // Act
            bool resultado = new UsuarioManagement().AltaMonitor(usuarioMonitor, monitor);

            // Assert
            Assert.IsTrue(resultado, "El monitor se registró correctamente.");
        }

        [TestMethod]
        public void CP1_1_4_RegistrarMonitorConDNINoValido()
        {


            // Arrange
            UsuariosDTO usuarioMonitor = new UsuariosDTO
            {
                Nombre = "Juan",
                Apellidos = "Pérez",
                Dni = "1234",
                Email = "juan.perez@mail.com",
                Direccion = null,
                Telefono = null,
                Contraseña = "Password123"
            };

            MonitorDTO monitor = new MonitorDTO
            {
                Email = "juan.perez@mail.com",
            };

            // Act
            bool resultado = registroMonitor.validarDNI(usuarioMonitor.Dni); ;

            // Assert
            Assert.IsFalse(resultado, "El DNI no es válido.");
        }

        [TestMethod]
        public void CP1_1_5_RegistrarMonitorConEmailNoValido()
        {
            // Arrange

            UsuariosDTO usuarioMonitor = new UsuariosDTO
            {
                Nombre = "Juan",
                Apellidos = "Pérez",
                Dni = "89789888R",
                Email = "correo-invalido",
                Direccion = null,
                Telefono = null,
                Contraseña = "Password123"
            };

            MonitorDTO monitor = new MonitorDTO
            {
                Email = "correo-invalido",
            };

            // Act
            bool resultado = registroMonitor.validarEmail(usuarioMonitor.Email); ;

            // Assert
            Assert.IsFalse(resultado, "El email no es válido.");
        }

        [TestMethod]
        public void CP1_1_6_RegistrarMonitorConContraseñasNoCoinciden()
        {
            // Arrange
            UsuariosDTO usuarioMonitor = new UsuariosDTO
            {
                Nombre = "Juan",
                Apellidos = "Pérez",
                Dni = "89789888R",
                Email = "juan.perez@mail.com",
                Direccion = null,
                Telefono = null,
                Contraseña = "Password123"
            };

            string validarContrasena = "Pasword123";

            MonitorDTO monitor = new MonitorDTO
            {
                Email = "juan.perez@mail.com",
            };

            // Act
            bool resultado = registroMonitor.comprobarIgualdadContrasena(usuarioMonitor.Contraseña, validarContrasena); ;

            // Assert
            Assert.IsFalse(resultado, "Las contraseñas no coinciden.");
        }

        [TestMethod]
        public void CP1_1_8_RegistrarMonitorConEmailExistente()
        {
            // Arrange
            UsuariosDTO usuarioMonitor = new UsuariosDTO
            {
                Nombre = "Juan",
                Apellidos = "Pérez",
                Dni = "78978978R",
                Email = "juan.perez@mail.com",
                Direccion = null,
                Telefono = null,
                Contraseña = "Password123"
            };

            MonitorDTO monitor = new MonitorDTO
            {
                Email = "juan.perez@mail.com",
            };

            // Act
            bool resultado = new UsuarioManagement().AltaMonitor(usuarioMonitor, monitor);

            // Assert
            Assert.IsFalse(resultado, "El monitor no se registró correctamente.");
        }

        [TestMethod]
        public void CP1_1_9_RegistrarMonitorConDNIExistente()
        {
            // Arrange
            UsuariosDTO usuarioMonitor = new UsuariosDTO
            {
                Nombre = "Juan",
                Apellidos = "Pérez",
                Dni = "12345678A",
                Email = "JuanPerez@mail.com",
                Direccion = null,
                Telefono = null,
                Contraseña = "Password123"
            };

            MonitorDTO monitor = new MonitorDTO
            {
                Email = "JuanPerez@mail.com",
            };

            // Act
            bool resultado = new UsuarioManagement().AltaMonitor(usuarioMonitor, monitor);

            // Assert
            Assert.IsFalse(resultado, "El monitor no se registró correctamente.");
        }
    }

}
