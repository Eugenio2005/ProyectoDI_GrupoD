using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Management;
using Negocio.EntitiesDTO;
using ProyectoDI_GrupoD;

namespace KAETesting
{
    [TestClass]
    public class RegistroUsuarioTests
    {
        private Registro registro;

        [TestInitialize]
        public void Setup()
        {
            registro = new Registro();
        }

        [TestMethod]
        public void CP1_1_1_RegistrarUsuario_ConTodosCamposValidos_RetornaTrue()
        {
            // Arrange
            var usuarioDTO = new UsuariosDTO
            {
                Nombre = "Juan",
                Apellidos = "Pérez",
                Dni = "12345678A",
                Telefono = "612345678",
                Email = "juan@example.com",
                Direccion = "Calle Falsa 123",
                CuentaCorriente = "1234567890123456789012",
                Contraseña = "Password@123"
            };

            // Act
            bool resultado = registro.AñadirUsuario(usuarioDTO);

            // Assert
            Assert.IsTrue(resultado, "El usuario debería registrarse correctamente.");
        }

        [TestMethod]
        public void CP1_1_2_RegistrarUsuario_SinDireccionYTelefono_RetornaTrue()
        {
            // Arrange
            var usuarioDTO = new UsuariosDTO
            {
                Nombre = "Ana",
                Apellidos = "García",
                Dni = "87654321B",
                Email = "ana@example.com",
                CuentaCorriente = "1234567890123456789012",
                Contraseña = "Password@123"
            };

            // Act
            bool resultado = registro.AñadirUsuario(usuarioDTO);

            // Assert
            Assert.IsTrue(resultado, "El usuario debería registrarse correctamente sin dirección y teléfono.");
        }

        [TestMethod]
        public void CP1_1_3_RegistrarUsuario_ConDatosValidos_RetornaTrue()
        {
            // Arrange
            var usuarioDTO = new UsuariosDTO
            {
                Nombre = "Luis",
                Apellidos = "Martínez",
                Dni = "12345678C",
                Telefono = "612345679",
                Email = "luis@example.com",
                Direccion = "Calle Ejemplo 456",
                CuentaCorriente = "1234567890123456789012",
                Contraseña = "Password@123"
            };

            // Act
            bool resultado = registro.AñadirUsuario(usuarioDTO);

            // Assert
            Assert.IsTrue(resultado, "El usuario debería registrarse correctamente.");
        }

        [TestMethod]
        public void CP1_1_4_RegistrarUsuario_DNIInvalido_RetornaFalse()
        {
            // Arrange
            var usuarioDTO = new UsuariosDTO
            {
                Nombre = "Carlos",
                Apellidos = "López",
                Dni = "1234567A", // DNI incorrecto
                Email = "carlos@example.com",
                CuentaCorriente = "1234567890123456789012",
                Contraseña = "Password@123"
            };

            // Act
            bool resultado = registro.validarDNI(usuarioDTO.Dni);

            // Assert
            Assert.IsFalse(resultado, "Debería informar que el DNI no es válido.");
        }

        [TestMethod]
        public void CP1_1_5_RegistrarUsuario_EmailInvalido_RetornaFalse()
        {
            // Arrange
            var usuarioDTO = new UsuariosDTO
            {
                Nombre = "Laura",
                Apellidos = "Sánchez",
                Dni = "12345678D",
                Email = "laura@example", // Email incorrecto
                CuentaCorriente = "1234567890123456789012",
                Contraseña = "Password@123"
            };

            // Act
            bool resultado = registro.validarEmail(usuarioDTO.Email);

            // Assert
            Assert.IsFalse(resultado, "Debería informar que el email no es válido.");
        }

        [TestMethod]
        public void CP1_1_6_RegistrarUsuario_CCCInvalido_RetornaFalse()
        {
            // Arrange
            var usuarioDTO = new UsuariosDTO
            {
                Nombre = "Pedro",
                Apellidos = "Gómez",
                Dni = "12345678E",
                Email = "pedro@example.com",
                CuentaCorriente = "12345", // CCC incorrecto
                Contraseña = "Password@123"
            };

            // Act
            bool resultado = registro.validarCuentaCorriente(usuarioDTO.CuentaCorriente);

            // Assert
            Assert.IsFalse(resultado, "Debería informar que el CCC no es válido.");
        }

        [TestMethod]
        public void CP1_1_9_RegistrarUsuario_ContraseñaInvalida_RetornaFalse()
        {
            // Arrange
            var usuarioDTO = new UsuariosDTO
            {
                Nombre = "Sofía",
                Apellidos = "Torres",
                Dni = "12345678H",
                Email = "sofia@example.com",
                CuentaCorriente = "1234567890123456789012",
                Contraseña = "12345" // Contraseña muy débil
            };

            // Act
            bool resultado = registro.validarContrasena(usuarioDTO.Contraseña);

            // Assert
            Assert.IsFalse(resultado, "Debería informar que la contraseña no es válida.");
        }

        [TestMethod]
        public void CP1_1_10_RegistrarUsuario_EmailYaRegistrado_RetornaFalse()
        {
            // Arrange
            // Primero, se agrega un usuario con el mismo email
            var usuarioExistente = new UsuariosDTO
            {
                Nombre = "Fernando",
                Apellidos = "Martínez",
                Dni = "12345678I",
                Email = "existente@example.com",
                CuentaCorriente = "1234567890123456789012",
                Contraseña = "Password@123"
            };
            registro.AñadirUsuario(usuarioExistente);

            // Ahora, intentamos registrar un nuevo usuario con el mismo email
            var usuarioDTO = new UsuariosDTO
            {
                Nombre = "Claudia",
                Apellidos = "López",
                Dni = "87654321J",
                Email = "existente@example.com", // Email ya registrado
                CuentaCorriente = "1234567890123456789012",
                Contraseña = "Password@123"
            };

            // Act
            bool resultado = registro.AñadirUsuario(usuarioDTO);

            // Assert
            Assert.IsFalse(resultado, "Debería informar que el email ya está registrado.");
        }

        [TestMethod]
        public void CP1_1_11_RegistrarUsuario_DNIYaRegistrado_RetornaFalse()
        {
            // Arrange
            // Primero, se agrega un usuario con el mismo DNI
            var usuarioExistente = new UsuariosDTO
            {
                Nombre = "Martín",
                Apellidos = "González",
                Dni = "23456789K",
                Email = "martin@example.com",
                CuentaCorriente = "1234567890123456789012",
                Contraseña = "Password@123"
            };
            registro.AñadirUsuario(usuarioExistente);

            // Ahora, intentamos registrar un nuevo usuario con el mismo DNI
            var usuarioDTO = new UsuariosDTO
            {
                Nombre = "Isabel",
                Apellidos = "Fernández",
                Dni = "23456789K", // DNI ya registrado
                Email = "isabel@example.com",
                CuentaCorriente = "1234567890123456789012",
                Contraseña = "Password@123"
            };

            // Act
            bool resultado = registro.AñadirUsuario(usuarioDTO);

            // Assert
            Assert.IsFalse(resultado, "Debería informar que el DNI ya está registrado.");
        }
    }
}
