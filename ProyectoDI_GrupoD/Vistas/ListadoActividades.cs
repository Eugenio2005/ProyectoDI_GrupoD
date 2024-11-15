using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProyectoDI_GrupoD.Vistas
{
    public partial class ListadoActividades : Form
    {
        private BindingList<Negocio.EntitiesDTO.ActividadesMonitoresDTO> actividadesList;
        private Negocio.Management.ActividadManagement actividadManagement;

        public ListadoActividades()
        {
            InitializeComponent();
            actividadManagement = new Negocio.Management.ActividadManagement();
        }

        private void ListadoActividades_Load(object sender, EventArgs e)
        {
            // Cargar las actividades al DataGridView usando BindingList
            actividadesList = new Negocio.Management.ActividadManagement().ObtenerActividades();
            dataGridView1.DataSource = actividadesList;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Actualizar la lista de actividades
            actividadesList = actividadManagement.ObtenerActividades();
            dataGridView1.DataSource = actividadesList;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnEliminar"].Index && e.RowIndex >= 0)
            {
                // Obtener la actividad seleccionada
                var actividadSeleccionada = dataGridView1.Rows[e.RowIndex].DataBoundItem as Negocio.EntitiesDTO.ActividadesMonitoresDTO;

                if (actividadSeleccionada != null)
                {
                    DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar la actividad '{actividadSeleccionada.NombreActividad}'?",
                                                             "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        try
                        {
                            // Eliminar la actividad de la base de datos
                            actividadManagement.EliminarActividad(actividadSeleccionada);

                            // Eliminar la actividad de la BindingList (se reflejará automáticamente en el DataGridView)
                            actividadesList.Remove(actividadSeleccionada);

                            MessageBox.Show("Actividad eliminada correctamente.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar la actividad: {ex.Message}");
                        }
                    }
                }
            }
        }
    }
}
