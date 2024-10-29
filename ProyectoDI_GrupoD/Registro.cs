﻿using Microsoft.Win32;
using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDI_GrupoD
{
    public partial class Registro : Form
    {
        private string nombre, apellidos, dni, telefono, email, direccion, cuentaCorriente, contraseña;
        private const string placeholderTextCuentaCorriente = "Ingrese 22 dígitos",
            placeholderTextEmail = "ejemplo@ejemplo.com";

        /// <summary>
        /// Constructor de la clase Registro.
        /// Inicializa los componentes del formulario, configura los placeholders y eventos necesarios.
        /// </summary>
        public Registro()
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
            txtContraseñaRe.TextChanged += new EventHandler(ComprobarTextBox);
            txtEmailRe.TextChanged += new EventHandler(ComprobarTextBox);
            txtDNI_Re.TextChanged += new EventHandler(ComprobarTextBox);
            txtUsuarioRe.TextChanged += new EventHandler(ComprobarTextBox);
            txtCuentaCorrienteRe.TextChanged += new EventHandler(ComprobarTextBox);
            txtApellidosRe.TextChanged += new EventHandler(ComprobarTextBox);
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

        private void Registro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrarRe_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            int borderRadius = 20; // Ajusta el radio del borde

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(btn.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(btn.Width - borderRadius, btn.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, btn.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);

            using (Pen pen = new Pen(Color.Gray, 1))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void btnBorrarRe_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            int borderRadius = 20; // Ajusta el radio del borde

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(btn.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(btn.Width - borderRadius, btn.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, btn.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);

            using (Pen pen = new Pen(Color.Gray, 1))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
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
        private void btnRegistrarRe_Click(object sender, EventArgs e)
        {
            UsuariosDTO usuarioDTO = new UsuariosDTO();

            // Recoge los valores de los textBox y los aplica al usuario.
            usuarioDTO.Nombre = txtUsuarioRe.Text;
            usuarioDTO.Apellidos = txtApellidosRe.Text;
            usuarioDTO.Dni = txtDNI_Re.Text;
            usuarioDTO.Telefono = txtTelefonoRe.Text;
            usuarioDTO.Email = txtEmailRe.Text;
            usuarioDTO.Direccion = txtDireccionRe.Text;
            usuarioDTO.CuentaCorriente = txtCuentaCorrienteRe.Text;
            usuarioDTO.Contraseña = txtContraseñaRe.Text;

            // Intenta añadir el usuario y muestra la ventana de inicio de sesión si lo añade.
            if (AñadirUsuario(usuarioDTO))
            {
                this.Hide();
                InicioSesion inicioSesion = new InicioSesion();
                inicioSesion.ShowDialog();
            }
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

        /// <summary>
        /// Intenta añadir un nuevo usuario utilizando el objeto UsuariosDTO 
        /// y muestra un mensaje de éxito o error.
        /// </summary>
        /// <param name="usuarioDTO">El objeto con la información del nuevo usuario.</param>
        /// <returns>Devuelve true si el usuario se registra correctamente, false en caso contrario.</returns>
        private Boolean AñadirUsuario(UsuariosDTO usuarioDTO)
        {
            try
            {
                new Negocio.Management.UsuarioManagement().AltaCliente(usuarioDTO); // Llama a la lógica de negocio para añadir el usuario
                MessageBox.Show("Usuario registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true; // Registro exitoso
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
            txtDireccionRe.Clear();
            txtCuentaCorrienteRe.Text = placeholderTextCuentaCorriente; // Restaura placeholder para cuenta corriente
            txtContraseñaRe.Clear();
        }

        /// <summary>
        /// Maneja el evento de volver a la ventana de inicio de sesión.
        /// </summary>
        private void volverAtras(object sender, EventArgs e)
        {
            this.Hide();
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.ShowDialog(); // Muestra la ventana de inicio de sesión
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
            cuentaCorriente = txtCuentaCorrienteRe.Text;

            // Habilitar el botón de registro solo si todos los campos están completos
            if (!string.IsNullOrWhiteSpace(contraseña) && !string.IsNullOrWhiteSpace(nombre) &&
                !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(dni) &&
                !string.IsNullOrWhiteSpace(apellidos) && !string.IsNullOrWhiteSpace(cuentaCorriente))
            {
                btnRegistrarRe.Enabled = true; // Habilitar el botón de registro
            }
            else
            {
                btnRegistrarRe.Enabled = false; // Deshabilitar el botón de registro
            }
        }
    }
}
