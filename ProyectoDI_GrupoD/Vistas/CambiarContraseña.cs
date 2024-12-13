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
    public partial class CambiarContraseña : Form
    {
        public CambiarContraseña()
        {
            InitializeComponent();
            aplicarEventoComprobarTextBox();
        }

        /// <summary>
        /// Aplica eventos de cambio de texto para comprobar la validez de los campos de entrada.
        /// </summary>
        private void aplicarEventoComprobarTextBox()
        {
            txtContraseñaActual.TextChanged += new EventHandler(ComprobarTextBox);
            txtContraseña.TextChanged += new EventHandler(ComprobarTextBox);      
            txtValidarContraseñaRe.TextChanged += new EventHandler(ComprobarTextBox);
        }

        /// <summary>
        /// Comprueba si todos los campos obligatorios están completos 
        /// y habilita el botón de registro en consecuencia.
        /// </summary>
        private void ComprobarTextBox(object sender, EventArgs e)
        {
            // Habilitar el botón de registro solo si todos los campos están completos
            if (!string.IsNullOrWhiteSpace(txtContraseñaActual.Text) 
                && !string.IsNullOrWhiteSpace(txtContraseña.Text) 
                && !string.IsNullOrWhiteSpace(txtValidarContraseñaRe.Text))
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

        /// <summary>
        /// Metodo que sirve para validar los datos.
        /// </summary>
        /// <returns>Devuelve un string con el mensaje de validación</returns>
        private string validarDatos()
        {
            StringBuilder mensajeValidacion = new StringBuilder();
            
            //Secuencia de if que van a comprobar la validación de los campos, si no es correcto
            // añadira que no es valido por cada campo.
            if (!(Negocio.Management.DatosUsuario.Contraseña).Equals(new Negocio.Management.UsuarioManagement().encriptarContrasena(txtContraseñaActual.Text)))
            {
                mensajeValidacion.Append("- La contraseña no es la contraseña anterior\n");
                txtContraseñaActual.BorderColor = Color.Red;
            }
            if (!validarContrasena(txtContraseña.Text))
            {
                mensajeValidacion.Append("- La contraseña nueva no es valida\n");
                txtContraseña.BorderColor = Color.Red;
            }
            if (!comprobarIgualdadContrasena(txtContraseña.Text, txtValidarContraseñaRe.Text))
            {
                mensajeValidacion.Append("- Las contraseñas no coinciden\n");
                txtValidarContraseñaRe.BorderColor = Color.Red;
            }
         
            return mensajeValidacion.ToString();
        }

        public bool validarContrasena(string password)
        {
            string patternContrasena = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[%&$/\*]).{8,}$";
            return Regex.IsMatch(password, patternContrasena);
        }

        public bool comprobarIgualdadContrasena(string contraseña1, string contraseña2)
        {
            string patternContrasena = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[%&$/\*]).{8,}$";
            return Regex.IsMatch(contraseña1, patternContrasena) && contraseña1.Equals(contraseña2);
        }

        /// <summary>
        /// Maneja la visibilidad del icono para mostrar/ocultar la contraseña.
        /// </summary>
        /// 
        private void btnContraseñaActualOjoCerrado_Click(object sender, EventArgs e)
        {
            txtContraseñaActual.UseSystemPasswordChar = true; // Mostrar la contraseña
            btnContraseñaActualOjoAbierto.Visible = true;
            btnContraseñaActualOjoCerrado.Visible = false;
        }
        private void btnojoCerradoRe_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true; // Ocultar la contraseña
            btnojoAbierto.Visible = true; // Muestra el icono de ojo abierto
            btnojoCerrado.Visible = false; // Esconde el icono de ojo cerrado
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
        /// 
        private void btnContraseñaActualOjoAbierto_Click(object sender, EventArgs e)
        {
            txtContraseñaActual.UseSystemPasswordChar = false; // Mostrar la contraseña
            btnContraseñaActualOjoAbierto.Visible = false;
            btnContraseñaActualOjoCerrado.Visible = true;
        }
        private void ojo_abiertoRe_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false; // Mostrar la contraseña
            btnojoAbierto.Visible = false;
            btnojoCerrado.Visible = true;
        }
        private void btnojoAbiertoValidarRe_Click(object sender, EventArgs e)
        {
            txtValidarContraseñaRe.UseSystemPasswordChar = false; // Mostrar la contraseña
            btnojoAbiertoValidarRe.Visible = false;
            btnojoCerradoValidarRe.Visible = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarRe_Click(object sender, EventArgs e)
        {
            UsuariosDTO usuarioDTO = new UsuariosDTO();


            // Recoge los valores de los textBox y los aplica al usuario.
            usuarioDTO.Dni = Negocio.Management.DatosUsuario.Dni;
            usuarioDTO.Contraseña = txtContraseña.Text;

            // Valida los datos que se hayan ingresado en el registro y devuelve un mensaje.
            string mensajeValidacion = validarDatos();

            // Si el mensaje no tiene caracteres significa que no hay ningun error con los campos, si no saltara un error.
            if (mensajeValidacion.Length == 0)
            {
                //Si consigue añadir el usuario accede a la pantalla principal.
                if (ActualizarContraseñaUsuario(usuarioDTO))
                {
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show(mensajeValidacion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Intenta añadir un nuevo usuario utilizando el objeto UsuariosDTO 
        /// y muestra un mensaje de éxito o error.
        /// </summary>
        /// <param name="usuarioDTO">El objeto con la información del nuevo usuario.</param>
        /// <returns>Devuelve true si el usuario se registra correctamente, false en caso contrario.</returns>
        public bool ActualizarContraseñaUsuario(UsuariosDTO usuarioDTO)
        {
            try
            {
                bool registroExitoso = new Negocio.Management.UsuarioManagement().UpdateContraseñaCliente(usuarioDTO, usuarioDTO.Contraseña); // Llama a la lógica de negocio para añadir el usuario
                if (registroExitoso)
                {
                    MessageBox.Show("Contraseña modificada correctamente", "Modficación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true; // Registro exitoso
                }
                else
                {
                    MessageBox.Show("Los contraseña no se pudo modificar.", "Modficación fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar la contraseña: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Error al registrar
            }
        }

    }
}
