using Negocio.EntitiesDTO;
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
        private ActividadDTO actividadDTO = new ActividadDTO();
        public AltaActividad()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNombreActividad.Clear();
            txtDescripActividad.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            actividadDTO.NombreActividad = txtNombreActividad.Text;
            actividadDTO.DescripActividad = txtDescripActividad.Text;
            string nombreApellidoMonitor = comBoxMonitores.Text;

            if (nombreApellidoMonitor.Equals("Sin Monitor ")){
                actividadDTO.MonitorAsociado= "SinMonitor@sinmonitor.com";
            }
            else
            {
                actividadDTO.MonitorAsociado = encontrarEmailMonitor(nombreApellidoMonitor);
            }
                

            añadirActividad(actividadDTO);
        }

        private string encontrarEmailMonitor(string nombreApellidoMonitor)
        {
            return new Negocio.Management.UsuarioManagement().encontrarEmailMonitor(nombreApellidoMonitor);
        }

        private bool añadirActividad(ActividadDTO actividadDTO)
        {
            try
            {
                bool activRegistradaExitoso = new Negocio.Management.ActividadManagement().AltaActividad(actividadDTO); 

                if (activRegistradaExitoso)
                {
                    MessageBox.Show("Actividad registrada correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true; // Registro exitoso
                }
                else
                {
                    MessageBox.Show("La actividad ya existe.", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la actividad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Error al registrar
            }
        }

        private void AltaActividad_Load(object sender, EventArgs e)
        {
            // Deshabilitar el botón de registrar al inicio
            btnRegistrar.Enabled = false;

            // Aplicar el evento para comprobar los TextBox
            aplicarEventoComprobarTextBox();

            // Forzar la comprobación de los campos al cargar
            ComprobarTextBox(null, EventArgs.Empty);

            var monitores = new Negocio.Management.MonitorManagement()
                .ObtenerMonitores()
                .Select(x => new { NombreCompleto = $"{x.Nombre} {x.Apellidos}", x.Email })
                .ToList();

            comBoxMonitores.DisplayMember = "NombreCompleto";
            comBoxMonitores.ValueMember = "Email";
            comBoxMonitores.DataSource = monitores;
        }

        private void aplicarEventoComprobarTextBox()
        {
            txtNombreActividad.TextChanged += ComprobarTextBox;
            txtDescripActividad.TextChanged += ComprobarTextBox;
        }

        private void ComprobarTextBox(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = !string.IsNullOrWhiteSpace(txtNombreActividad.Text) &&
                           !string.IsNullOrWhiteSpace(txtDescripActividad.Text);
        }
    }
}
