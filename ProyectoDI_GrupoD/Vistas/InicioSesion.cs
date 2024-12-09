using ProyectoDI_GrupoD.Vistas;
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
    public partial class InicioSesion : Form
    {
        private string email, contraseña;
        private string[] emailAdmin = { "kevinAD@gmail.com", "andoniAD@gmail.com", "eugenioAD@gmail.com" };

        public InicioSesion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de iniciar sesión.
        /// Valida el usuario y la contraseña ingresados.
        /// Si son correctos, oculta la ventana de inicio de sesión y muestra la ventana principal.
        /// Si son incorrectos, muestra un mensaje de error.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento (el botón de iniciar sesión).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnIniciarSesionInSe_Click(object sender, EventArgs e)
        {
            // Verifica si el usuario y la contraseña son válidos
            if (new Negocio.Management.UsuarioManagement().validarUsuario(txtUsuarioInSe.Text, txtContraseñaInSe.Text))
            {
                this.Hide();
                // Verifica si el usuario es un administrador y muestra la pantalla correspondiente
                if (emailAdmin.Contains(txtUsuarioInSe.Text))
                {
                    PantallaPrincipalAdmin pantallaPrincipalAD = new PantallaPrincipalAdmin();
                    pantallaPrincipalAD.ShowDialog();
                }
                else
                {
                    PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
                    pantallaPrincipal.ShowDialog();
                    //ActividadesCliente actividadesCliente = new ActividadesCliente();
                    //actividadesCliente.ShowDialog();
                }

            }
            else
            {
                // Muestra un mensaje de error si el usuario o la contraseña son incorrectos
                MessageBox.Show($"El usuario no existe o la contraseña es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuarioInSe.BorderColor = Color.Red;
                txtContraseñaInSe.BorderColor = Color.Red;
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el icono de ojo cerrado.
        /// Cambia la visibilidad de la contraseña a oculta y actualiza la visibilidad del icono.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento (el icono de ojo cerrado).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnojoCerradoInSe_Click(object sender, EventArgs e)
        {
            txtContraseñaInSe.UseSystemPasswordChar = true; // Oculta la contraseña
            btnojo_abiertoInSe.Visible = true;
            btnojoCerradoInSe.Visible = false;
        }

        /// <summary>
        /// Maneja el evento de clic en el icono de ojo abierto.
        /// Cambia la visibilidad de la contraseña a visible y actualiza el estado del icono.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento (el icono de ojo abierto).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnojoAbiertoInSe_Click(object sender, EventArgs e)
        {
            txtContraseñaInSe.UseSystemPasswordChar = false; // Muestra la contraseña
            btnojo_abiertoInSe.Visible = false;
            btnojoCerradoInSe.Visible = true;
        }

        /// <summary>
        /// Maneja el evento de cierre de la ventana de inicio de sesión.
        /// Cierra completamente la aplicación cuando la ventana se cierra.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento (la ventana de inicio de sesión).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void InicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Maneja el evento de clic en el icono de "atrás".
        /// Oculta la ventana de inicio de sesión y muestra la ventana del menú de inicio.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento (el icono de "atrás").</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void imgAtras_Re_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuInicio menuInicio = new MenuInicio();
            menuInicio.ShowDialog(); // Muestra la ventana de menú de inicio
        }

        private void imgCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Maneja el evento de presionar una tecla mientras el botón de iniciar sesión tiene el foco.
        /// Si la tecla presionada es Enter, simula un clic en el botón de iniciar sesión.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento (el botón de iniciar sesión).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnIniciarSesionInSe_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica si la tecla presionada es Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Evita el sonido de 'ding' al presionar Enter
                e.SuppressKeyPress = true;

                // Llama al evento Click del botón
                btnIniciarSesionInSe.PerformClick();
            }
        }
    }
}
