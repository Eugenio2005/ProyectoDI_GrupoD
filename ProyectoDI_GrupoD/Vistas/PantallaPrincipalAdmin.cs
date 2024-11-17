using Negocio.EntitiesDTO;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Text;
using System.Windows.Forms;
using ProyectoDI_GrupoD.Vistas;
using System.Reflection.Emit;

namespace ProyectoDI_GrupoD
{
    /// <summary>
    /// Representa la pantalla principal de administración, donde se gestionan las actividades y monitores.
    /// </summary>
    public partial class PantallaPrincipalAdmin : Form
    {
        private string nombre, emailAdmin;

        /// <summary>
        /// Constructor de la clase PantallaPrincipalAdmin. Inicializa los componentes del formulario.
        /// Configura el nombre del usuario mostrado en la interfaz.
        /// </summary>
        public PantallaPrincipalAdmin()
        {
            InitializeComponent();

            NombreUsuario.ButtonText = $"Bienvenido, {Negocio.Management.DatosUsuario.Nombre}";

            pnlSuperiorDarDeAltaMonitor.Visible = false;
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de dar de alta a un monitor.
        /// Muestra el panel de alta de monitor y abre el formulario de registro de monitor.
        /// </summary>
        private void imgBtnDarAltaMonitor_Click(object sender, EventArgs e)
        {
            pnlSuperiorDarDeAltaMonitor.Visible = true;
            lblTextoSuperior.Text = "--- Alta Monitor ---";
            CentrarLabel(lblTextoSuperior, pnlSuperiorDarDeAltaMonitor);

            RegistroMonitor registroAdmin = new RegistroMonitor();
            AbrirPanel(registroAdmin, pnlPrincipal);
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de dar de alta a una actividad.
        /// Muestra el panel de alta de actividad y abre el formulario de alta de actividad.
        /// </summary>
        private void imgButtonDarAltaActividad_Click(object sender, EventArgs e)
        {
            pnlSuperiorDarDeAltaMonitor.Visible = true;
            lblTextoSuperior.Text = "--- Alta Actividad ---";
            CentrarLabel(lblTextoSuperior, pnlSuperiorDarDeAltaMonitor);

            AltaActividad altaActividad = new AltaActividad();
            AbrirPanel(altaActividad, pnlPrincipal);
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de listar actividades.
        /// Muestra el panel de listado de actividades y abre el formulario de listado de actividades.
        /// </summary>
        private void imgButtonListarActividad_Click(object sender, EventArgs e)
        {
            pnlSuperiorDarDeAltaMonitor.Visible = true;
            lblTextoSuperior.Text = "--- Listar Actividades ---";
            CentrarLabel(lblTextoSuperior, pnlSuperiorDarDeAltaMonitor);

            ListadoActividades listadoActividades = new ListadoActividades();
            AbrirPanel(listadoActividades, pnlPrincipal);
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de retroceder.
        /// Oculta el panel de alta de monitor y limpia el panel principal.
        /// </summary>
        private void imgAtras_Re_Click(object sender, EventArgs e)
        {
            pnlSuperiorDarDeAltaMonitor.Visible = false;
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

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuInicio menuInicio = new MenuInicio();
            menuInicio.ShowDialog();
            Negocio.Management.DatosUsuario.LimpiarDatos();
        }

        /// <summary>
        /// Maneja el evento de cierre del formulario principal.
        /// Cierra la aplicación cuando se intenta cerrar el formulario.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento (el formulario de cierre).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void PantallaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
