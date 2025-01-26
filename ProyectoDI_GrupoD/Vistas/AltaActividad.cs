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

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Borrar".
        /// Limpia los campos de texto de nombre y descripción de la actividad.
        /// </summary>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNombreActividad.Clear();
            txtDescripActividad.Clear();
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Registrar".
        /// Registra una nueva actividad en el sistema utilizando los datos ingresados en el formulario.
        /// </summary>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            actividadDTO.NombreActividad = txtNombreActividad.Text;
            actividadDTO.DescripActividad = txtDescripActividad.Text;
            actividadDTO.PrecioActividad = (float)Math.Round(float.Parse(txtPrecioActividad.Text, System.Globalization.CultureInfo.InvariantCulture), 2);


            string nombreApellidoMonitor = comBoxMonitores.Text;

            if (nombreApellidoMonitor.Equals("Sin Monitor "))
            {
                actividadDTO.MonitorAsociado = "SinMonitor@sinmonitor.com";
            }
            else
            {
                actividadDTO.MonitorAsociado = encontrarEmailMonitor(nombreApellidoMonitor);
            }

            añadirActividad(actividadDTO);
        }

        /// <summary>
        /// Busca el correo electrónico del monitor a partir de su nombre completo.
        /// </summary>
        /// <param name="nombreApellidoMonitor">El nombre completo del monitor.</param>
        /// <returns>El correo electrónico del monitor.</returns>
        private string encontrarEmailMonitor(string nombreApellidoMonitor)
        {
            return new Negocio.Management.UsuarioManagement().encontrarEmailMonitor(nombreApellidoMonitor);
        }

        /// <summary>
        /// Registra una actividad en la base de datos a través de la capa de negocio.
        /// Muestra un mensaje al usuario según el resultado del registro.
        /// </summary>
        /// <param name="actividadDTO">El objeto que contiene los datos de la actividad a registrar.</param>
        /// <returns>Devuelve true si la actividad fue registrada correctamente, de lo contrario false.</returns>
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
                    return false; // Registro fallido
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la actividad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Error al registrar
            }
        }

        /// <summary>
        /// Evento que se ejecuta al cargar la ventana de alta de actividad.
        /// Configura el formulario, deshabilita el botón de registro y carga la lista de monitores disponibles.
        /// </summary>
        private void AltaActividad_Load(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = false;
            aplicarEventoComprobarTextBox();
            ComprobarTextBox(null, EventArgs.Empty);

            var monitores = new Negocio.Management.MonitorManagement()
                .ObtenerMonitores()
                .Select(x => new { NombreCompleto = $"{x.Nombre} {x.Apellidos}", x.Email })
                .ToList();

            comBoxMonitores.DisplayMember = "NombreCompleto";
            comBoxMonitores.ValueMember = "Email";
            comBoxMonitores.DataSource = monitores;
        }

        /// <summary>
        /// Asocia los eventos de validación a los campos de texto de nombre y descripción de la actividad.
        /// </summary>
        private void aplicarEventoComprobarTextBox()
        {
            txtNombreActividad.TextChanged += ComprobarTextBox;
            txtDescripActividad.TextChanged += ComprobarTextBox;
        }

        /// <summary>
        /// Valida si los campos de nombre y descripción están completos.
        /// Habilita o deshabilita el botón de registrar según los resultados de la validación.
        /// </summary>
        /// <param name="sender">El origen del evento (en este caso no se usa).</param>
        /// <param name="e">Los argumentos del evento (en este caso no se usan).</param>
        private void ComprobarTextBox(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = !string.IsNullOrWhiteSpace(txtNombreActividad.Text) &&
                                   !string.IsNullOrWhiteSpace(txtDescripActividad.Text);
        }
    }
}
