using Negocio.EntitiesDTO;
using Negocio.Management;
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
    public partial class InformacionActividad : Form
    {

        private ToolTip toolTip = new ToolTip();

        public InformacionActividad()
        {
            InitializeComponent();
        }

        public InformacionActividad(ActividadesClientesDTO actividadSeleccionada)
        {
            InitializeComponent();

            aplicarTextoCampos(actividadSeleccionada);

            deshabilitarCampos();
        }

        private bool UsuarioApuntado(String emailUsuario, String nombreActividad)
        {
            return new Negocio.Management.UsuarioManagement().comprobarUsuarioApuntado(emailUsuario, nombreActividad);
        }

        private void aplicarTextoCampos(ActividadesClientesDTO actividad)
        {
            txtNombreActividad.Text = actividad.NombreActividad;
            txtDescripActividad.Text = actividad.DescripActividad;
            txtMonitorAsociado.Text = actividad.NombreMonitor;
        }

        private void deshabilitarCampos()
        {
            txtNombreActividad.Enabled = false;
            txtDescripActividad.Enabled = false;
            txtMonitorAsociado.Enabled = false;
        }

        private bool apuntarUsuarioActividad()
        {
            try
            {
                bool registroExitoso = new Negocio.Management.UsuarioManagement().apuntarUsuarioActividad(DatosUsuario.Email, txtNombreActividad.Text); // Llama a la lógica de negocio para añadir el usuario
                if (registroExitoso)
                {
                    return true; // Registro exitoso
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Error al registrar
            }
        }

        private void btnApuntar_Click(object sender, EventArgs e)
        {
            if (apuntarUsuarioActividad())
            {
                MessageBox.Show("El usuario ha sido apuntado a la actividad.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            this.Hide();
            this.Close();
        }

        private void imgAtras_Re_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void InformacionActividad_Load(object sender, EventArgs e)
        {

        }
    }
}
