using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using Negocio.Management; 

namespace ProyectoDI_GrupoD.Tests
{
    [TestClass]
    public class InicioSesionTests
    {
        private InicioSesion inicioSesion;
        private UsuarioManagement usuarioManagement;

        [TestInitialize]
        public void Setup()
        {
            inicioSesion = new InicioSesion();
            usuarioManagement = new UsuarioManagement();
        }

        [TestMethod]
        public void CP1_1_1_UsuarioYContraseñaValidos()
        {
            // Arrange
            string usuario = "juan@example.com";
            string contraseña = "Password@123"; 

            // Act
            bool resultado = new Negocio.Management.UsuarioManagement().validarUsuario(usuario, contraseña); // Simula el clic

            // Assert
            Assert.IsTrue(resultado, "El usuario es correcto");
        }

        [TestMethod]
        public void CP1_1_2_UsuarioValidoYContraseñaNoValida()
        {
            // Arrange
            string usuario = "juan@example.com";
            string contraseña = "Password@12";

            // Act
            bool resultado = new Negocio.Management.UsuarioManagement().validarUsuario(usuario, contraseña); // Simula el clic

            // Assert
            Assert.IsFalse(resultado, "El usuario es incorrecto");
        }

        [TestMethod]
        public void CP1_1_3_UsuarioNoValido()
        {
            // Arrange
            string usuario = "juan1@example.com";
            string contraseña = "Password@12";

            // Act
            bool resultado = new Negocio.Management.UsuarioManagement().validarUsuario(usuario, contraseña); // Simula el clic

            // Assert
            Assert.IsFalse(resultado, "El usuario es incorrecto");
        }

        [TestMethod]
        public void CP1_1_4_CamposVacios()
        {
            // Arrange
            string usuario = "";
            string contraseña = "";

            // Act
            bool resultado = new Negocio.Management.UsuarioManagement().validarUsuario(usuario, contraseña); // Simula el clic

            // Assert
            Assert.IsFalse(resultado, "El usuario es incorrecto");
        }
    }
}
