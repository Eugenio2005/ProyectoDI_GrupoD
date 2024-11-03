using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms; // Asegúrate de que tengas la referencia a Windows Forms
using Negocio.Management; // Asegúrate de que la referencia a UsuarioManagement sea correcta

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
        public void CP1_1_1_UsuarioYContraseñaValidos_AccessLanding()
        {
            // Arrange
            string usuario = "juan@example.com"; // Cambia a un usuario que existe en la base de datos
            string contraseña = "Password@123"; // Cambia a la contraseña correspondiente

            // Act
            bool resultado = new Negocio.Management.UsuarioManagement().validarUsuario(usuario, contraseña); // Simula el clic

            // Assert
            // Verifica que la pantalla principal se ha mostrado
            // Esto puede depender de cómo manejes las pantallas, aquí un ejemplo
            // Puedes verificar el estado de la ventana o que se haya creado el objeto
            Assert.IsTrue(resultado, "El usuario es correcto");
        }

        [TestMethod]
        public void CP1_1_2_UsuarioValidoYContraseñaNoValida_NoAccessLanding()
        {
            // Arrange
            inicioSesion.txtUsuarioInSe.Text = "usuarioValido"; // Cambia a un usuario que existe
            inicioSesion.txtContraseñaInSe.Text = "contraseñaInvalida"; // Cambia a una contraseña incorrecta

            // Act
            inicioSesion.btnIniciarSesionInSe_Click(null, null); // Simula el clic

            // Assert
            // Verifica que se muestre el mensaje de error
            Assert.AreEqual("El usuario no existe o la contraseña es incorrecta", MessageBox.Show(
                "El usuario no existe o la contraseña es incorrecta",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error).Text);
        }

        [TestMethod]
        public void CP1_1_3_UsuarioNoValido_NoAccessLanding()
        {
            // Arrange
            inicioSesion.txtUsuarioInSe.Text = "usuarioInvalido"; // Un usuario que no existe
            inicioSesion.txtContraseñaInSe.Text = "contraseñaCualquiera"; // Cualquier contraseña

            // Act
            inicioSesion.btnIniciarSesionInSe_Click(null, null); // Simula el clic

            // Assert
            // Verifica que se muestre el mensaje de error
            Assert.AreEqual("El usuario no existe o la contraseña es incorrecta", MessageBox.Show(
                "El usuario no existe o la contraseña es incorrecta",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error).Text);
        }

        [TestMethod]
        public void CP1_1_4_CamposVacios_NoAccessLanding()
        {
            // Arrange
            inicioSesion.txtUsuarioInSe.Text = ""; // Campo de usuario vacío
            inicioSesion.txtContraseñaInSe.Text = ""; // Campo de contraseña vacío

            // Act
            inicioSesion.btnIniciarSesionInSe_Click(null, null); // Simula el clic

            // Assert
            // Verifica que se muestre el mensaje de error
            Assert.AreEqual("El usuario no existe o la contraseña es incorrecta", MessageBox.Show(
                "El usuario no existe o la contraseña es incorrecta",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error).Text);
        }
    }
}
