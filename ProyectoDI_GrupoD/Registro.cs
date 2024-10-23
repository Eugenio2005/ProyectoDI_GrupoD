using Microsoft.Win32;
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
        private string nombre, apellidos, dni, telefono, email, direccion, cuentaCorriente, contraseña;

        public Registro()
        {
            InitializeComponent();

            btnRegistrarRe.Enabled = false;

            txtContraseñaRe.TextChanged += new EventHandler(ComprobarTextBox);
            txtEmailRe.TextChanged += new EventHandler(ComprobarTextBox);
            txtDNI_Re.TextChanged += new EventHandler(ComprobarTextBox);
            txtUsuarioRe.TextChanged += new EventHandler(ComprobarTextBox);
            txtCuentaCorrienteRe.TextChanged += new EventHandler(ComprobarTextBox);
            txtApellidosRe.TextChanged += new EventHandler(ComprobarTextBox);
        }

        private void btnRegistrarRe_Click(object sender, EventArgs e)
        {
            nombre = txtUsuarioRe.Text;
            apellidos = txtApellidosRe.Text;
            dni = txtDNI_Re.Text;
            telefono = txtTelefonoRe.Text;
            email = txtEmailRe.Text;
            direccion = txtDireccionRe.Text;
            cuentaCorriente = txtCuentaCorrienteRe.Text;
            contraseña = txtContraseñaRe.Text;

            this.Hide();
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.ShowDialog();
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
