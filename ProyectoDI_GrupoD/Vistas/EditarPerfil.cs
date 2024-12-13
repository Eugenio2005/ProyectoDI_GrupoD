using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoDI_GrupoD.Vistas
{
    public partial class EditarPerfil : Form
    {
        private string nombre, apellidos, telefono, email, direccion, cuentaCorriente, contraseña;
        private const string placeholderTextCuentaCorriente = "Ingrese 22 dígitos",
                             placeholderTextEmail = "ejemplo@ejemplo.com";
        public EditarPerfil()
        {
            InitializeComponent();
            inicializarPlaceHolder();
            aplicarCamposUsuario();
            aplicarEventoComprobarTextBox();
        }

        /// <summary>
        /// Aplica eventos de cambio de texto para comprobar la validez de los campos de entrada.
        /// </summary>
        private void aplicarEventoComprobarTextBox()
        {
            txtUsuarioRe.TextChanged += new EventHandler(ComprobarTextBox);
            txtApellidosRe.TextChanged += new EventHandler(ComprobarTextBox);
            txtEmailRe.TextChanged += new EventHandler(ComprobarTextBox);
            txtTelefonoRe.TextChanged += new EventHandler(ComprobarTextBox);
            txtDireccionRe.TextChanged += new EventHandler(ComprobarTextBox);
            txtCuentaCorrienteRe.TextChanged += new EventHandler(ComprobarTextBox);
            
        }

        private void aplicarCamposUsuario()
        {
            txtUsuarioRe.Text = Negocio.Management.DatosUsuario.Nombre;
            txtApellidosRe.Text = Negocio.Management.DatosUsuario.Apellidos;
            txtDNI_Re.Text = Negocio.Management.DatosUsuario.Dni;
            txtEmailRe.Text = Negocio.Management.DatosUsuario.Email;
            txtTelefonoRe.Text = Negocio.Management.DatosUsuario.Telefono;
            txtDireccionRe.Text = Negocio.Management.DatosUsuario.Direccion;
            txtCuentaCorrienteRe.Text = Negocio.Management.DatosUsuario.CuentaCorriente;
        }

        /// <summary>
        /// Inicializa los placeholders para los textBox correspondientes 
        /// con su respectivo color de texto.
        /// </summary>
        private void inicializarPlaceHolder()
        {
            txtCuentaCorrienteRe.Text = placeholderTextCuentaCorriente; // Texto de guía al usuario
            txtCuentaCorrienteRe.ForeColor = Color.Gray; // Color del texto para el placeholder

            txtEmailRe.Text = placeholderTextEmail; // Establece el placeholder para el email
            txtEmailRe.ForeColor = Color.Gray; // Color del texto para el placeholder
        }

        /// <summary>
        /// Elimina el placeholder cuando el campo de cuenta corriente se ha seleccionado.
        /// </summary>
        private void txtBoxCuentaCorrienteEliminarPlaceHolder(object sender, EventArgs e)
        {
            if (txtCuentaCorrienteRe.Text == placeholderTextCuentaCorriente)
            {
                txtCuentaCorrienteRe.Text = ""; // Limpiar el texto
                txtCuentaCorrienteRe.ForeColor = Color.Black; // Cambiar a color normal
            }
        }

        /// <summary>
        /// Restaura el placeholder si el campo de cuenta corriente está vacío.
        /// </summary>
        private void txtBoxCuentaCorrienteAplicarPlaceHolder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCuentaCorrienteRe.Text))
            {
                txtCuentaCorrienteRe.Text = placeholderTextCuentaCorriente; // Restaurar texto predeterminado
                txtCuentaCorrienteRe.ForeColor = Color.Gray; // Volver al color predeterminado
            }
        }

        /// <summary>
        /// Cambia el color del texto de la cuenta corriente si hay contenido válido.
        /// </summary>
        private void txtCuentaCorrienteRe_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCuentaCorrienteRe.Text) && txtCuentaCorrienteRe.Text != placeholderTextCuentaCorriente)
            {
                txtCuentaCorrienteRe.ForeColor = Color.FromArgb(202, 224, 212); // Cambiar a color normal
            }
        }

        private void txtBoxEmailEliminarPlaceHolder(object sender, EventArgs e)
        {
            if (txtEmailRe.Text == placeholderTextEmail)
            {
                txtEmailRe.Text = ""; // Limpiar el texto
                txtEmailRe.ForeColor = Color.Black; // Cambiar a color normal
            }
        }

        private void txtBoxEmailAplicarPlaceHolder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmailRe.Text))
            {
                txtEmailRe.Text = placeholderTextEmail; // Restaurar texto predeterminado
                txtEmailRe.ForeColor = Color.Gray; // Volver al color predeterminado
            }
        }
        private void txtEmailRe_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtEmailRe.Text) && txtEmailRe.Text != placeholderTextEmail)
            {
                txtEmailRe.ForeColor = Color.FromArgb(202, 224, 212); // Cambiar a color normal
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de registrar.
        /// Crea un objeto UsuariosDTO y asigna los valores de los campos de entrada,
        /// luego intenta añadir el usuario.
        /// </summary>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            UsuariosDTO usuarioDTO = new UsuariosDTO();
            ClientesDTO clienteDTO = new ClientesDTO();


            // Recoge los valores de los textBox y los aplica al usuario.
            usuarioDTO.Nombre = txtUsuarioRe.Text;
            usuarioDTO.Apellidos = txtApellidosRe.Text;
            usuarioDTO.Dni = txtDNI_Re.Text;
            usuarioDTO.Telefono = txtTelefonoRe.Text;
            usuarioDTO.Email = txtEmailRe.Text;
            usuarioDTO.Direccion = txtDireccionRe.Text;

            clienteDTO.CuentaCorriente = txtCuentaCorrienteRe.Text;
            clienteDTO.Email = txtEmailRe.Text;

            // Valida los datos que se hayan ingresado en el registro y devuelve un mensaje.
            string mensajeValidacion = validarDatos(usuarioDTO, clienteDTO);

            // Si el mensaje no tiene caracteres significa que no hay ningun error con los campos, si no saltara un error.
            if (mensajeValidacion.Length == 0)
            {
                ModificarUsuario(clienteDTO, usuarioDTO);
            }
            else
            {
                MessageBox.Show(mensajeValidacion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Metodo que sirve para validar los datos.
        /// </summary>
        /// <param name="usuarioDTO"></param>
        /// <returns>Devuelve un string con el mensaje de validación</returns>
        private string validarDatos(UsuariosDTO usuarioDTO, ClientesDTO clienteDTO)
        {
            StringBuilder mensajeValidacion = new StringBuilder();

            //Secuencia de if que van a comprobar la validación de los campos, si no es correcto
            // añadira que no es valido por cada campo.
            if (!validarTelefono(usuarioDTO.Telefono))
            {
                mensajeValidacion.Append("- El telefono no es valido\n");
                txtTelefonoRe.BorderColor = Color.Red;
            }
            if (!validarEmail(usuarioDTO.Email))
            {
                mensajeValidacion.Append("- El email no es valido\n");
                txtEmailRe.BorderColor = Color.Red;
            }
            if (!validarCuentaCorriente(clienteDTO.CuentaCorriente))
            {
                mensajeValidacion.Append("- La cuenta corriente no es valida\n");
                txtCuentaCorrienteRe.BorderColor = Color.Red;
            }

            return mensajeValidacion.ToString();
        }

        /// <summary>
        /// Metodos que validan la variable introducida por el usuario con un pattern personalizado
        /// para cada validación
        /// </summary>
        /// <param name="telefono"></param>
        /// <returns></returns>
        public bool validarTelefono(string telefono)
        {
            string patternTelefono = @"^\d{9}$";
            return Regex.IsMatch(telefono, patternTelefono) || telefono.Equals("");
        }

        /// <summary>
        /// Cancela pulsar teclas que no sean números y borrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito y no es la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancela el evento si no es un número
                e.Handled = true;
            }
        }

        public bool validarCuentaCorriente(string cuentaCorriente)
        {
            string patternCuentaCorriente = @"^\d{22}$";
            return Regex.IsMatch(cuentaCorriente, patternCuentaCorriente);
        }

        public bool validarEmail(string email)
        {
            string patternEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$";
            return Regex.IsMatch(email, patternEmail);
        }

        private void btnRegistrarRe_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica si la tecla presionada es Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Evita el sonido de 'ding' al presionar Enter
                e.SuppressKeyPress = true;

                // Llama al evento Click del botón
                btnRegistrarRe.PerformClick();
            }
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            CambiarContraseña cambiarContraseña = new CambiarContraseña();
            cambiarContraseña.ShowDialog();
        }

        /// <summary>
        /// Intenta añadir un nuevo usuario utilizando el objeto UsuariosDTO 
        /// y muestra un mensaje de éxito o error.
        /// </summary>
        /// <param name="usuarioDTO">El objeto con la información del nuevo usuario.</param>
        /// <returns>Devuelve true si el usuario se registra correctamente, false en caso contrario.</returns>
        public bool ModificarUsuario(ClientesDTO clienteDTO, UsuariosDTO usuarioDTO)
        {
            try
            {
                bool registroExitoso = new Negocio.Management.UsuarioManagement().UpdateCliente(clienteDTO, usuarioDTO);
                
                if (registroExitoso)
                {
                    MessageBox.Show("Usuario modificado correctamente", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true; // Registro exitoso
                }
                else
                {
                    MessageBox.Show("Intentelo de nuevo mas tarde", "Modificación fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al Modificar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Error al registrar
            }
        }

        /// <summary>
        /// Borra el contenido de todos los campos del formulario de registro.
        /// </summary>
        private void btnBorrarRe_Click(object sender, EventArgs e)
        {
            txtUsuarioRe.Clear();
            txtApellidosRe.Clear();
            txtDNI_Re.Clear();
            txtTelefonoRe.Clear();
            txtEmailRe.Text = placeholderTextEmail; // Restaura el placeholder para email
            txtEmailRe.BorderColor = Color.White;
            txtDireccionRe.Clear();
            txtCuentaCorrienteRe.Text = placeholderTextCuentaCorriente; // Restaura placeholder para cuenta corriente
            txtCuentaCorrienteRe.BorderColor = Color.White;


            aplicarCamposUsuario();
        }

        /// <summary>
        /// Comprueba si todos los campos obligatorios están completos 
        /// y habilita el botón de registro en consecuencia.
        /// </summary>
        private void ComprobarTextBox(object sender, EventArgs e)
        {
            // Habilitar el botón de registro solo si todos los campos están completos
            if (NoBlancosNull() && ComprobarNoIguales())
            {
                btnRegistrarRe.Enabled = true; // Habilitar el botón de registro
            }
            else
            {
                btnRegistrarRe.Enabled = false; // Deshabilitar el botón de registro
            }
        }

        private bool NoBlancosNull() {
            nombre = txtUsuarioRe.Text;
            email = txtEmailRe.Text;
            apellidos = txtApellidosRe.Text;
            cuentaCorriente = txtCuentaCorrienteRe.Text;
            telefono = txtTelefonoRe.Text;
            direccion = txtDireccionRe.Text;

            return !string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(email) &&
                !string.IsNullOrWhiteSpace(apellidos) && !string.IsNullOrWhiteSpace(cuentaCorriente) &&
                !string.IsNullOrWhiteSpace(telefono) && !string.IsNullOrWhiteSpace(direccion);
        }

        private bool ComprobarNoIguales()
        {
            nombre = Negocio.Management.DatosUsuario.Nombre;
            apellidos = Negocio.Management.DatosUsuario.Apellidos;
            email = Negocio.Management.DatosUsuario.Email;
            telefono = Negocio.Management.DatosUsuario.Telefono;
            direccion = Negocio.Management.DatosUsuario.Direccion;
            cuentaCorriente = Negocio.Management.DatosUsuario.CuentaCorriente;

            return !nombre.Equals(txtUsuarioRe.Text) || !apellidos.Equals(txtApellidosRe.Text) ||
                !email.Equals(txtEmailRe.Text) || !telefono.Equals(txtTelefonoRe.Text) ||
                !direccion.Equals(txtDireccionRe.Text) || !cuentaCorriente.Equals(txtCuentaCorrienteRe.Text);
        }
    }
}
