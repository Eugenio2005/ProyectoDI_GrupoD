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
    public partial class PantallaPrincipalAdmin : Form
    {
        private string nombre,emailAdmin;

        public PantallaPrincipalAdmin(string email)
        {
            InitializeComponent();

            this.emailAdmin = email;

            NombreUsuario.ButtonText = emailAdmin;
            NombreUsuario.ButtonText = $"Bienvenido, {Negocio.Management.DatosUsuario.Nombre}";
        }

        public PantallaPrincipalAdmin()
        {
            InitializeComponent();

            NombreUsuario.ButtonText = $"Bienvenido, {Negocio.Management.DatosUsuario.Nombre}";

            pnlSuperiorDarDeAltaMonitor.Visible = false;
        }

        private void imgBtnDarAltaMonitor_Click(object sender, EventArgs e)
        {

            pnlSuperiorDarDeAltaMonitor.Visible = true;
            lblTextoSuperior.Text = "--- Alta Monitor ---";
            CentrarLabel(lblTextoSuperior, pnlSuperiorDarDeAltaMonitor);

            RegistroMonitor registroAdmin = new RegistroMonitor();
            AbrirPanel(registroAdmin, pnlPrincipal);

        }

        private void imgButtonDarAltaActividad_Load(object sender, EventArgs e)
        {
            pnlSuperiorDarDeAltaMonitor.Visible = true;
            lblTextoSuperior.Text = "--- Alta Actividad ---";
            CentrarLabel(lblTextoSuperior, pnlSuperiorDarDeAltaMonitor);

            AltaActividad altaActividad = new AltaActividad();
            AbrirPanel(altaActividad, pnlPrincipal);
        }

        private void imgButtonListarActividad_Click(object sender, EventArgs e)
        {
            pnlSuperiorDarDeAltaMonitor.Visible = true;
            lblTextoSuperior.Text = "--- Listar Actividades ---";
            CentrarLabel(lblTextoSuperior, pnlSuperiorDarDeAltaMonitor);

            ListadoActividades listadoActividades = new ListadoActividades();
            AbrirPanel(listadoActividades, pnlPrincipal);
        }

        private void imgAtras_Re_Click(object sender, EventArgs e)
        {
            pnlSuperiorDarDeAltaMonitor.Visible = false;
            lblTextoSuperior.Text = "";

            LimpiarPanel(pnlPrincipal);
        }

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
        private void CentrarLabel(System.Windows.Forms.Label label, Panel panel)
        {
            // Calcula la posición para centrar el Label
            label.Location = new Point(
                (panel.Width - label.Width) / 2,
                (panel.Height - label.Height) / 2
            );
        }

        private void LimpiarPanel(Panel panelDestino)
        {
            panelDestino.Controls.Clear();
        }

        

        private void PantallaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
