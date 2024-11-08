using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoDI_GrupoD.Vistas
{
    public partial class AltaActividad : Form
    {
        private string nombreActividad, descripActividad;

        public AltaActividad()
        {
            InitializeComponent();
            btnRegistrar.Enabled = false;
            aplicarEventoComprobarTextBox();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNombreActividad.Clear();
            txtDescripActividad.Clear();
        }

        private void aplicarEventoComprobarTextBox()
        {
            txtNombreActividad.TextChanged += new EventHandler(ComprobarTextBox);
            txtDescripActividad.TextChanged += new EventHandler(ComprobarTextBox);
        }

        private void ComprobarTextBox(object sender, EventArgs e)
        {
            nombreActividad = txtNombreActividad.Text;
            descripActividad = txtDescripActividad.Text;

            // Habilitar el botón de registro solo si todos los campos están completos
            if (!string.IsNullOrWhiteSpace(nombreActividad) && !string.IsNullOrWhiteSpace(descripActividad))
            {
                btnRegistrar.Enabled = true; // Habilitar el botón de registro
            }
            else
            {
                btnRegistrar.Enabled = false; // Deshabilitar el botón de registro
            }
        }
    }
}
