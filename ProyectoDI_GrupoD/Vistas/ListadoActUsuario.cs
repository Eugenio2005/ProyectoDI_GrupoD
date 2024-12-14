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
    public partial class ListadoActUsuario : Form
    {
        private BindingList<Negocio.EntitiesDTO.ActividadesClientesDTO> actividadesList;
        private Negocio.Management.ActividadManagement actividadManagement;
        private ActividadesClientesDTO actividadesClientesDTO = new ActividadesClientesDTO();
        public ListadoActUsuario()
        {
            InitializeComponent();
            actividadManagement = new Negocio.Management.ActividadManagement();
        }

        private void ListadoActUsuario_Load(object sender, EventArgs e)
        {
            actividadesList = new Negocio.Management.ActividadManagement().ObtenerActividadesClienteApuntado(DatosUsuario.Email);
            VistaActividades.DataSource = actividadesList;
        }

        private void btnDesapuntar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una celda seleccionada
            if (VistaActividades.CurrentCell == null)
            {
                MessageBox.Show("Por favor, seleccione una actividad para desapuntarse.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el índice de la fila seleccionada
            int rowIndex = VistaActividades.CurrentCell.RowIndex;

            // Acceder a la fila seleccionada
            DataGridViewRow selectedRow = VistaActividades.Rows[rowIndex];
            ActividadesClientesDTO actividadesClientesDTO = obtenerActividad(selectedRow);

            // Comprobar si el usuario ya está apuntado a la actividad
            bool usuarioApuntado = new Negocio.Management.UsuarioManagement().comprobarUsuarioApuntado(DatosUsuario.Email, actividadesClientesDTO.NombreActividad);

            if (usuarioApuntado)
            {
                // Preguntar al usuario si está seguro de desapuntarse
                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de que desea desapuntarse de esta actividad?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    // Proceder con la desapuntación
                    bool desapuntarUsuario = new Negocio.Management.UsuarioManagement().desapuntarUsuarioActividad(DatosUsuario.Email, actividadesClientesDTO.NombreActividad);

                    if (desapuntarUsuario)
                    {
                        MessageBox.Show($"El usuario se desapuntó exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Error, el usuario no se pudo desapuntar de esta actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Si el usuario no está apuntado, muestra un mensaje de error
                MessageBox.Show($"El usuario no está apuntado a esta actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Recargar la vista
            ListadoActUsuario_Load(sender, e);
        }


        private ActividadesClientesDTO obtenerActividad(DataGridViewRow selectedRow)
        {
            // Obtener los valores de las celdas correspondientes a la fila seleccionada
            string nombreActividad = selectedRow.Cells["NombreActividad"].Value.ToString();
            string nombreMonitor = selectedRow.Cells["NombreMonitor"].Value.ToString();
            string descripActividad = selectedRow.Cells["DescripActividad"].Value.ToString();

            // Asignar los valores al objeto actividadesClientesDTO
            actividadesClientesDTO.NombreActividad = nombreActividad;
            actividadesClientesDTO.NombreMonitor = nombreMonitor;
            actividadesClientesDTO.DescripActividad = descripActividad;

            return actividadesClientesDTO;
        }
    }
}
