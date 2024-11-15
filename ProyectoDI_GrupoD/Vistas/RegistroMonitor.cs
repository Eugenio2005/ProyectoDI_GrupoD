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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ProyectoDI_GrupoD.Vistas
{
    public partial class RegistroMonitor : Form
    {
        private string nombre, apellidos, dni, telefono, email, emailAdmin, direccion, contraseñaValidada, contraseña;
        private const string placeholderTextEmail = "ejemplo@ejemplo.com";
        public RegistroMonitor()
        {
            InitializeComponent(); 
            inicializarPlaceHolder();
            btnRegistrarRe.Enabled = false;
            aplicarEventoComprobarTextBox();
        }

        /// <summary>
        /// Aplica eventos de cambio de texto para comprobar la validez de los campos de entrada.
        /// </summary>
        private void aplicarEventoComprobarTextBox()
        {
            txtUsuarioRe.TextChanged += new EventHandler(ComprobarTextBox);
            txtApellidosRe.TextChanged += new EventHandler(ComprobarTextBox);
            txtContraseñaRe.TextChanged += new EventHandler(ComprobarTextBox);
            txtEmailRe.TextChanged += new EventHandler(ComprobarTextBox);
            txtDNI_Re.TextChanged += new EventHandler(ComprobarTextBox);
            txtValidarContraseñaRe.TextChanged += new EventHandler(ComprobarTextBox);
        }

        /// <summary>
        /// Inicializa los placeholders para los textBox correspondientes 
        /// con su respectivo color de texto.
        /// </summary>
        private void inicializarPlaceHolder()
        {
            txtEmailRe.Text = placeholderTextEmail; // Establece el placeholder para el email
            txtEmailRe.ForeColor = Color.Gray; // Color del texto para el placeholder
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

        private void Registro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
        private void btnRegistrarRe_Click(object sender, EventArgs e)
        {
            UsuariosDTO usuarioDTO = new UsuariosDTO();
            MonitorDTO monitorDTO = new MonitorDTO();

            // Recoge los valores de los textBox y los aplica al usuario.
            usuarioDTO.Nombre = txtUsuarioRe.Text;
            usuarioDTO.Apellidos = txtApellidosRe.Text;
            usuarioDTO.Dni = txtDNI_Re.Text;
            usuarioDTO.Telefono = txtTelefonoRe.Text;
            usuarioDTO.Email = txtEmailRe.Text;
            usuarioDTO.Direccion = txtDireccionRe.Text;
            usuarioDTO.Contraseña = txtContraseñaRe.Text;

            monitorDTO.Email = txtEmailRe.Text;

            // Valida los datos que se hayan ingresado en el registro y devuelve un mensaje.
            string mensajeValidacion = validarDatos(usuarioDTO);

            // Si el mensaje no tiene caracteres significa que no hay ningun error con los campos, si no saltara un error.
            if (mensajeValidacion.Length == 0)
            {
                //Si consigue añadir el usuario accede a la pantalla principal.
                if (AñadirMonitor(usuarioDTO, monitorDTO))
                {
                    btnBorrarRe_Click(sender, e);
                }
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
        private string validarDatos(UsuariosDTO usuarioDTO)
        {
            StringBuilder mensajeValidacion = new StringBuilder();

            //Secuencia de if que van a comprobar la validación de los campos, si no es correcto
            // añadira que no es valido por cada campo.
            if (!validarContrasena(usuarioDTO.Contraseña))
            {
                mensajeValidacion.Append("- La contraseña no es valida\n");
                txtContraseñaRe.BorderColor = Color.Red;
            }
            if (!comprobarIgualdadContrasena(txtValidarContraseñaRe.Text))
            {
                mensajeValidacion.Append("- Las contraseñas no coinciden\n");
                txtValidarContraseñaRe.BorderColor = Color.Red;
            }
            if (!validarTelefono(usuarioDTO.Telefono))
            {
                mensajeValidacion.Append("- El telefono no es valido\n");
                txtTelefonoRe.BorderColor = Color.Red;
            }
            if (!validarDNI(usuarioDTO.Dni))
            {
                mensajeValidacion.Append("- El DNI no es valido\n");
                txtDNI_Re.BorderColor = Color.Red;
            }
            if (!validarEmail(usuarioDTO.Email))
            {
                mensajeValidacion.Append("- El email no es valido\n");
                txtEmailRe.BorderColor = Color.Red;
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

        public bool validarDNI(string DNI)
        {
            string patternDNI = @"^\d{8}[A-Za-z]$";
            return Regex.IsMatch(DNI, patternDNI);
        }


        public bool validarContrasena(string password)
        {
            string patternContrasena = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[%&$/\*]).{8,}$";
            return Regex.IsMatch(password, patternContrasena);
        }

        public bool comprobarIgualdadContrasena(string password)
        {
            string contraseña1 = txtContraseñaRe.Text, contraseña2 = txtValidarContraseñaRe.Text, patternContrasena = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[%&$/\*]).{8,}$";
            return Regex.IsMatch(password, patternContrasena) && contraseña1.Equals(contraseña2);
        }

        /// <summary>
        /// Maneja la visibilidad del icono para mostrar/ocultar la contraseña.
        /// </summary>
        private void btnojoCerradoRe_Click(object sender, EventArgs e)
        {
            txtContraseñaRe.UseSystemPasswordChar = true; // Ocultar la contraseña
            btnojo_abiertoRe.Visible = true; // Muestra el icono de ojo abierto
            btnojoCerradoRe.Visible = false; // Esconde el icono de ojo cerrado
        }
        private void btnojoCerradoValidarRe_Click(object sender, EventArgs e)
        {
            txtValidarContraseñaRe.UseSystemPasswordChar = true; // Mostrar la contraseña
            btnojoAbiertoValidarRe.Visible = true;
            btnojoCerradoValidarRe.Visible = false;
        }

        /// <summary>
        /// Maneja el evento de clic en el icono de ojo abierto 
        /// para mostrar la contraseña.
        /// </summary>
        private void ojo_abiertoRe_Click(object sender, EventArgs e)
        {
            txtContraseñaRe.UseSystemPasswordChar = false; // Mostrar la contraseña
            btnojo_abiertoRe.Visible = false;
            btnojoCerradoRe.Visible = true;
        }
        private void btnojoAbiertoValidarRe_Click(object sender, EventArgs e)
        {
            txtValidarContraseñaRe.UseSystemPasswordChar = false; // Mostrar la contraseña
            btnojoAbiertoValidarRe.Visible = false;
            btnojoCerradoValidarRe.Visible = true;
        }

        /// <summary>
        /// Intenta añadir un nuevo usuario utilizando el objeto UsuariosDTO 
        /// y muestra un mensaje de éxito o error.
        /// </summary>
        /// <param name="usuarioDTO">El objeto con la información del nuevo usuario.</param>
        /// <returns>Devuelve true si el usuario se registra correctamente, false en caso contrario.</returns>
        public bool AñadirMonitor(UsuariosDTO usuarioDTO, MonitorDTO monitorDTO)
        {
            try
            {
                bool registroExitoso = new Negocio.Management.UsuarioManagement().AltaMonitor(usuarioDTO, monitorDTO); // Llama a la lógica de negocio para añadir el usuario
                if (registroExitoso)
                {
                    MessageBox.Show("Usuario registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true; // Registro exitoso
                }
                else
                {
                    MessageBox.Show("Los datos ya esta en uso.", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtContraseñaRe.Clear();
            txtContraseñaRe.UseSystemPasswordChar = true;
            txtValidarContraseñaRe.Clear();
            txtValidarContraseñaRe.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// Comprueba si todos los campos obligatorios están completos 
        /// y habilita el botón de registro en consecuencia.
        /// </summary>
        private void ComprobarTextBox(object sender, EventArgs e)
        {
            contraseña = txtContraseñaRe.Text;
            nombre = txtUsuarioRe.Text;
            email = txtEmailRe.Text;
            dni = txtDNI_Re.Text;
            apellidos = txtApellidosRe.Text;
            contraseñaValidada = txtValidarContraseñaRe.Text;

            // Habilitar el botón de registro solo si todos los campos están completos
            if (!string.IsNullOrWhiteSpace(txtUsuarioRe.Text) && !string.IsNullOrWhiteSpace(txtApellidosRe.Text) &&
                !string.IsNullOrWhiteSpace(contraseña) &&
                !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(dni) && !string.IsNullOrWhiteSpace(contraseñaValidada))
            {
                btnRegistrarRe.Cursor = Cursors.Hand;
                btnRegistrarRe.Enabled = true; // Habilitar el botón de registro
            }
            else
            {
                btnRegistrarRe.Cursor = Cursors.No;
                btnRegistrarRe.Enabled = false; // Deshabilitar el botón de registro
            }
        }
    }
}
