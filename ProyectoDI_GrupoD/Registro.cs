using Microsoft.Win32;
using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDI_GrupoD
{
    public partial class Registro : Form
    {
        private string placeholderTextCuentaCorriente = "XXXXXXXXXXXXXXXXXXX";
        private string nombre, apellidos, dni, telefono, email, direccion, cuentaCorriente, contraseña;

        public Registro()
        {
            InitializeComponent();

            txtCuentaCorrienteRe.Text = placeholderTextCuentaCorriente; // Texto predeterminado
            txtCuentaCorrienteRe.ForeColor = Color.Gray; // Color del texto predeterminado

            btnRegistrarRe.Enabled = false;

            txtContraseñaRe.TextChanged += new EventHandler(ComprobarTextBox);
            txtEmailRe.TextChanged += new EventHandler(ComprobarTextBox);
            txtDNI_Re.TextChanged += new EventHandler(ComprobarTextBox);
            txtUsuarioRe.TextChanged += new EventHandler(ComprobarTextBox);
            txtCuentaCorrienteRe.TextChanged += new EventHandler(ComprobarTextBox);
            txtApellidosRe.TextChanged += new EventHandler(ComprobarTextBox);
        }

        private void txtCuentaCorrienteRe_Enter(object sender, EventArgs e)
        {
            if (txtCuentaCorrienteRe.Text == placeholderTextCuentaCorriente)
            {
                txtCuentaCorrienteRe.Text = ""; // Limpiar el texto
                txtCuentaCorrienteRe.ForeColor = Color.Black; // Cambiar a color normal
            }
        }

        private void txtCuentaCorrienteRe_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCuentaCorrienteRe.Text))
            {
                txtCuentaCorrienteRe.Text = placeholderTextCuentaCorriente; // Restaurar texto predeterminado
                txtCuentaCorrienteRe.ForeColor = Color.Gray; // Volver al color predeterminado
            }
        }

        private void txtCuentaCorrienteRe_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCuentaCorrienteRe.Text) && txtCuentaCorrienteRe.Text != placeholderTextCuentaCorriente)
            {
                txtCuentaCorrienteRe.ForeColor = Color.FromArgb(202,224,212); // Cambiar a color normal
            }
        }

        private void btnRegistrarRe_Click(object sender, EventArgs e)
        {
            UsuariosDTO usuarioDTO = new UsuariosDTO();
            usuarioDTO.Nombre = txtUsuarioRe.Text;
            usuarioDTO.Apellidos = txtApellidosRe.Text;
            usuarioDTO.Dni = txtDNI_Re.Text;
            usuarioDTO.Telefono = txtTelefonoRe.Text;
            usuarioDTO.Email = txtEmailRe.Text;
            usuarioDTO.Direccion = txtDireccionRe.Text;
            usuarioDTO.CuentaCorriente = txtCuentaCorrienteRe.Text;
            usuarioDTO.Contraseña = txtContraseñaRe.Text;

            if (AñadirUsuario(usuarioDTO))
            {
                this.Hide();
                InicioSesion inicioSesion = new InicioSesion();
                inicioSesion.ShowDialog();
            }
            
        }

        private void btnojoCerradoRe_Click(object sender, EventArgs e)
        {
            txtContraseñaRe.UseSystemPasswordChar = true;
            btnojo_abiertoRe.Visible = true;
            btnojoCerradoRe.Visible = false;
        }

        private void ojo_abiertoRe_Click(object sender, EventArgs e)
        {
            txtContraseñaRe.UseSystemPasswordChar = false;
            btnojo_abiertoRe.Visible = false;
            btnojoCerradoRe.Visible = true;
        }

        private Boolean AñadirUsuario(UsuariosDTO usuarioDTO)
        {
            try
            {
                new Negocio.Management.UsuarioManagement().AltaCliente(usuarioDTO);

                MessageBox.Show("Usuario registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnBorrarRe_Click(object sender, EventArgs e)
        {
            txtUsuarioRe.Clear();
            txtApellidosRe.Clear();
            txtDNI_Re.Clear();
            txtTelefonoRe.Clear();
            txtEmailRe.Clear();
            txtDireccionRe.Clear();
            txtCuentaCorrienteRe.Clear();
            txtContraseñaRe.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.ShowDialog();
        }

        private void ComprobarTextBox(object sender, EventArgs e)
        {
            contraseña = txtContraseñaRe.Text;
            nombre = txtUsuarioRe.Text;
            email = txtEmailRe.Text;
            dni = txtDNI_Re.Text;
            apellidos = txtApellidosRe.Text;
            cuentaCorriente = txtCuentaCorrienteRe.Text;


            if (!string.IsNullOrWhiteSpace(contraseña) && !string.IsNullOrWhiteSpace(nombre) &&
                !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(dni) &&
                !string.IsNullOrWhiteSpace(apellidos) && !string.IsNullOrWhiteSpace(cuentaCorriente))
            {
                btnRegistrarRe.Enabled = true;
            }
            else
            {
                btnRegistrarRe.Enabled = false;
            }

        }
    }
}
