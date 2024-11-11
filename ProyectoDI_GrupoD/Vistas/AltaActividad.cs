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

        public AltaActividad()
        {
            InitializeComponent();
            btnRegistrar.Enabled = true; 
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ActividadDTO actividadDTO = new ActividadDTO();

            actividadDTO.NombreActividad = txtNombreActividad.Text;
            actividadDTO.DescripActividad = txtDescripActividad.Text;
            actividadDTO.MonitorAsociado = comBoxMonitores.Text as String;

            añadirActividad(actividadDTO);
        }

        private bool añadirActividad(ActividadDTO actividadDTO)
        {
            try
            {
                bool activRegistradaExitoso = new Negocio.Management.ActividadManagement().AltaActividad(actividadDTO); // Llama a la lógica de negocio para añadir el usuario
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
            var monitores = new Negocio.Management.MonitorManagement()
                .ObtenerCategorias()
                .Select(x => new { NombreCompleto = $"{x.Nombre} {x.Apellidos}", x.Email })
                .ToList();

            // Añadir la opción "Sin monitor"
            monitores.Insert(0, new { NombreCompleto = "Sin monitor", Email = (string)null });

            comBoxMonitores.DisplayMember = "NombreCompleto";
            comBoxMonitores.ValueMember = "Email";
            comBoxMonitores.DataSource = monitores;
        }

        private void ComprobarTextBox(object sender, EventArgs e)
        {

        }
    }
}
