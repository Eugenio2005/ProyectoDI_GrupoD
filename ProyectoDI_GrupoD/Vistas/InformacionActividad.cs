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
            
            configuracionTooltip();
        }

        private void configuracionTooltip()
        {
            // Configurar propiedades del ToolTip
            toolTip.AutoPopDelay = 5000; // Tiempo que se muestra el mensaje
            toolTip.InitialDelay = 500; // Retardo antes de aparecer
            toolTip.ReshowDelay = 200;  // Retardo entre ToolTips
            toolTip.ShowAlways = true;  // Mostrar siempre, incluso si el botón está deshabilitado
        }

        private void InformacionActividad_Load(object sender, EventArgs e)
        {
            aplicarTextoCampos();
            deshabilitarCampos();
            
            if (UsuarioApuntado(DatosUsuario.Email, "zumba"))
            {
                btnApuntar.Enabled = false;
            }

        }

        private bool UsuarioApuntado(String emailUsuario, String nombreActividad)
        {
            return new Negocio.Management.UsuarioManagement().comprobarUsuarioApuntado(emailUsuario, nombreActividad);
        }

        private void aplicarTextoCampos()
        {
            txtNombreActividad.Text = "Actividad";
            txtDescripActividad.Text = "Descripcion";
            comBoxMonitores.SelectedIndex = 0;
        }

        private void deshabilitarCampos()
        {
            txtNombreActividad.Enabled = false;
            txtDescripActividad.Enabled = false;
            comBoxMonitores.Enabled = false;
        }

        private bool apuntarUsuarioActividad()
        {
            try
            {
                bool registroExitoso = new Negocio.Management.UsuarioManagement().apuntarUsuarioActividad(DatosUsuario.Email, "zumba"); // Llama a la lógica de negocio para añadir el usuario
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
        }
    }
}
