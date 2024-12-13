using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDI_GrupoD.Vistas
{
    public partial class MenuInicio : Form
    {
        /// <summary>
        /// Constructor de la clase MenuInicio. Inicializa los componentes del formulario.
        /// </summary>
        public MenuInicio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de inicio de sesión.
        /// Oculta el formulario actual y abre el formulario de inicio de sesión.
        /// </summary>
        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario de inicio
            InicioSesion inicioSesion = new InicioSesion(); 
            inicioSesion.ShowDialog(); 
        }

        /// <summary>
        /// Maneja el evento de clic en el enlace de registro.
        /// Oculta el formulario actual y abre el formulario de registro.
        /// </summary>
        private void linklblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); 
            Registro registro = new Registro(); 
            registro.ShowDialog(); 
        }

        private void MenuInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void imgCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
