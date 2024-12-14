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
    public partial class ActividadesCliente : Form
    {
        private string emailUsuario = DatosUsuario.Email;
        private ActividadesClientesDTO actividadesClientesDTO = new ActividadesClientesDTO();
        private BindingList<Negocio.EntitiesDTO.ActividadesClientesDTO> actividadesList;
        private Negocio.Management.ActividadManagement actividadManagement;

        public ActividadesCliente()
        {
            InitializeComponent();
        }

        private void ActividadesCliente_Load(object sender, EventArgs e)
        {
            actividadesList = new Negocio.Management.ActividadManagement().ObtenerActividadesClientes();
            VistaActividadesClientes.DataSource = actividadesList;
        }

        private void VistaActividadesClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hace clic en una fila válida
            if (e.RowIndex >= 0) // Asegurarse de que la fila no sea el encabezado
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = VistaActividadesClientes.Rows[e.RowIndex];

                // Obtener el valor de la celda correspondiente al nombre de la actividad
                string nombreActividad = selectedRow.Cells["nombreActividad"].Value?.ToString() ?? string.Empty;

                // Verificar si el usuario está apuntado a la actividad
                bool usuarioApuntado = new Negocio.Management.UsuarioManagement().comprobarUsuarioApuntado(emailUsuario, nombreActividad);

                // Activar o desactivar botones según el estado del usuario
                if (usuarioApuntado)
                {
                    btnApuntar.Enabled = false;
                }
                else
                {
                    btnApuntar.Enabled = true;
                }
            }
        }

        private void btnApuntar_Click(object sender, EventArgs e)
        {
            // Obtener el índice de la fila seleccionada
            int rowIndex = VistaActividadesClientes.CurrentCell.RowIndex;

            // Acceder a la fila seleccionada
            DataGridViewRow selectedRow = VistaActividadesClientes.Rows[rowIndex];
            ActividadesClientesDTO actividadesClientesDTO = obtenerActividad(selectedRow);

            // Comprobar si el usuario ya está apuntado a la actividad
            bool usuarioApuntado = new Negocio.Management.UsuarioManagement().comprobarUsuarioApuntado(emailUsuario, actividadesClientesDTO.NombreActividad);

            if (!usuarioApuntado)
            {
                // Si el usuario no está apuntado, muestra la vista de información
                InformacionActividad informacionActividad = new InformacionActividad(actividadesClientesDTO);
                informacionActividad.ShowDialog();
            }
            else
            {
                // Si el usuario ya está apuntado, muestra un mensaje de error
                MessageBox.Show($"El usuario ya está apuntado a esta actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private ActividadesClientesDTO obtenerActividad(DataGridViewRow selectedRow)
        {
            // Obtener los valores de las celdas correspondientes a la fila seleccionada
            string nombreActividad = selectedRow.Cells["nombreActividad"].Value.ToString();
            string nombreMonitor = selectedRow.Cells["NombreMonitor"].Value.ToString();
            string descripActividad = selectedRow.Cells["DescripActividad"].Value.ToString();

            // Asignar los valores al objeto actividadesClientesDTO
            actividadesClientesDTO.NombreActividad = nombreActividad;
            actividadesClientesDTO.NombreMonitor = nombreMonitor;
            actividadesClientesDTO.DescripActividad = descripActividad;

            return actividadesClientesDTO;
        }

        private void btnValorar_Click(object sender, EventArgs e)
        {
            // Obtener el índice de la fila seleccionada
            int rowIndex = VistaActividadesClientes.CurrentCell.RowIndex;

            // Acceder a la fila seleccionada
            DataGridViewRow selectedRow = VistaActividadesClientes.Rows[rowIndex];
            ActividadesClientesDTO actividadesClientesDTO = obtenerActividad(selectedRow);

            // Comprobar si el usuario ya está apuntado a la actividad
            bool usuarioApuntado = new Negocio.Management.UsuarioManagement().comprobarUsuarioApuntado(emailUsuario, actividadesClientesDTO.NombreActividad);

            if (!usuarioApuntado)
            {
                // Si el usuario no está apuntado, muestra la vista de información
                ValorarAct valorarAct = new ValorarAct(actividadesClientesDTO);
                valorarAct.ShowDialog();
            }
            else
            {
                // Si el usuario ya está apuntado, muestra un mensaje de error
                MessageBox.Show($"El usuario ya está apuntado a esta actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
