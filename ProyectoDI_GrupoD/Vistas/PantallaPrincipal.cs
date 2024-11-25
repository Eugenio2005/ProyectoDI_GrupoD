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
            pnlSuperior.Visible = true;
            lblTextoSuperior.Text = "--- ACTIVIDADES DISPONIBLES ---";
            CentrarLabel(lblTextoSuperior, pnlSuperior);

            ListadoActUsuario listadoActUsuario = new ListadoActUsuario();
            AbrirPanel(listadoActUsuario, pnlPrincipal);
        }

        private void MisActividades_Click(object sender, EventArgs e)
        {
            pnlSuperior.Visible = true;
            lblTextoSuperior.Text = "--- MIS ACTIVIDADES ---";
            CentrarLabel(lblTextoSuperior, pnlSuperior);

            //ActividadesCliente actividadesCliente = new ActividadesCliente();
            //AbrirPanel(actividadesCliente, pnlPrincipal);
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de retroceder.
        /// Oculta el panel de alta de monitor y limpia el panel principal.
        /// </summary>
        private void imgAtras_Re_Click(object sender, EventArgs e)
        {
            pnlSuperior.Visible = false;
            lblTextoSuperior.Text = "";

            LimpiarPanel(pnlPrincipal);
        }

        /// <summary>
        /// Abre un formulario hijo dentro de un panel destino, cerrando cualquier formulario previamente abierto.
        /// Configura el formulario hijo para que se ajuste al panel y lo muestra al frente.
        /// </summary>
        /// <param name="formularioHijo">El formulario hijo que se desea abrir.</param>
        /// <param name="panelDestino">El panel en el que se abrirá el formulario hijo.</param>
        private void AbrirPanel(Form formularioHijo, Panel panelDestino)
        {
            // Cerrar cualquier formulario ya abierto dentro del panel
            if (panelDestino.Controls.Count > 0)
                panelDestino.Controls[0].Dispose();

            // Configurar el formulario hijo sin bordes y no como ventana superior
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;

            // Ajustar el tamaño del formulario hijo manualmente (opcional, si deseas un tamaño específico)
            formularioHijo.AutoSize = false;

            // Añadir el formulario hijo al panel destino
            panelDestino.Controls.Add(formularioHijo);
            panelDestino.Tag = formularioHijo;

            // Centrar el formulario hijo en el panel
            formularioHijo.Location = new Point(
                (panelDestino.Width - formularioHijo.Width) / 2,
                (panelDestino.Height - formularioHijo.Height) / 2
            );

            // Mostrar el formulario hijo
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        /// <summary>
        /// Centra un label dentro de un panel.
        /// </summary>
        /// <param name="label">El label que se desea centrar.</param>
        /// <param name="panel">El panel dentro del cual se centrará el label.</param>
        private void CentrarLabel(System.Windows.Forms.Label label, Panel panel)
        {
            // Calcula la posición para centrar el Label
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
    }
}
