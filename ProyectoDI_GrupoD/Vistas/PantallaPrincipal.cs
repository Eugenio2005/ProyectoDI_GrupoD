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
    public partial class PantallaPrincipal : Form
    {
        private bool usuarioCollapsed;

        public PantallaPrincipal()
        {
            InitializeComponent();

            NombreUsuario.ButtonText = $"Bienvenido, {Negocio.Management.DatosUsuario.Nombre}";
            pnlSuperior.Visible = false;
        }

        private void PantallaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ActividadDisponible_Click(object sender, EventArgs e)
        {
           MostrarPanel("--- ACTIVIDADES DISPONIBLES ---", new ActividadesCliente());
        }

        private void MisActividades_Click(object sender, EventArgs e)
        {
            MostrarPanel("--- MIS ACTIVIDADES ---", new ListadoActUsuario());
        }

        /// <summary>
        /// Oculta el panel superior y limpia el contenido del panel principal.
        /// </summary>
        private void imgAtras_Re_Click(object sender, EventArgs e)
        {
            pnlSuperior.Visible = false;
            lblTextoSuperior.Text = "";
            LimpiarPanel(pnlPrincipal);
        }

        /// <summary>
        /// Método reutilizable para mostrar un formulario dentro de un panel, con título opcional.
        /// </summary>
        /// <param name="titulo">Título del panel superior.</param>
        /// <param name="formularioHijo">Formulario a mostrar en el panel.</param>
        private void MostrarPanel(string titulo, Form formularioHijo)
        {
            pnlSuperior.Visible = true;
            lblTextoSuperior.Text = titulo;
            CentrarLabel(lblTextoSuperior, pnlSuperior);
            AbrirPanel(formularioHijo, pnlPrincipal);
        }

        /// <summary>
        /// Abre un formulario hijo dentro de un panel destino, cerrando cualquier formulario previamente abierto.
        /// Configura el formulario hijo para que se ajuste al panel y lo muestra al frente.
        /// </summary>
        /// <param name="formularioHijo">El formulario hijo que se desea abrir.</param>
        /// <param name="panelDestino">El panel en el que se abrirá el formulario hijo.</param>
        private void AbrirPanel(Form formularioHijo, Panel panelDestino)
        {
            if (panelDestino.Controls.Count > 0)
                panelDestino.Controls[0].Dispose();

            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.AutoSize = false;

            panelDestino.Controls.Add(formularioHijo);
            panelDestino.Tag = formularioHijo;

            formularioHijo.Location = new Point(
                (panelDestino.Width - formularioHijo.Width) / 2,
                (panelDestino.Height - formularioHijo.Height) / 2
            );

            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        /// <summary>
        /// Centra un label dentro de un panel.
        /// </summary>
        /// <param name="label">El label que se desea centrar.</param>
        /// <param name="panel">El panel dentro del cual se centrará el label.</param>
        private void CentrarLabel(Label label, Panel panel)
        {
            label.Location = new Point(
                (panel.Width - label.Width) / 2,
                (panel.Height - label.Height) / 2
            );
        }

        /// <summary>
        /// Limpia todos los controles dentro de un panel destino.
        /// </summary>
        /// <param name="panelDestino">El panel que será limpiado.</param>
        private void LimpiarPanel(Panel panelDestino)
        {
            panelDestino.Controls.Clear();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuInicio menuInicio = new MenuInicio();
            menuInicio.ShowDialog();
            Negocio.Management.DatosUsuario.LimpiarDatos();
        }

        private void usuarioTimer_Tick(object sender, EventArgs e)
        {
            if (usuarioCollapsed)
            {
                pnlUsuario.Height += 10;
                if (pnlUsuario.Height == pnlUsuario.MaximumSize.Height)
                {
                    usuarioCollapsed = false;
                    usuarioTimer.Stop();
                }
            }
            else
            {
                pnlUsuario.Height -= 10;
                if (pnlUsuario.Height == pnlUsuario.MinimumSize.Height)
                {
                    usuarioCollapsed = true;
                    usuarioTimer.Stop();
                }
            }
        }

        private void NombreUsuario_Click(object sender, EventArgs e)
        {
            usuarioTimer.Start();
        }

        private void CerrarSSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuInicio menuInicio = new MenuInicio();
            menuInicio.ShowDialog();
            Negocio.Management.DatosUsuario.LimpiarDatos();
        }

        private void EditarPerfil_Click(object sender, EventArgs e)
        {
            MostrarPanel("--- EDITAR PERFIL ---", new EditarPerfil());
        }

        private void imageButton1_Click(object sender, EventArgs e)
        {
            MostrarPanel("--- GUARDAR FACTURA ---", new FormMisFacturas());
        }
    }
}
