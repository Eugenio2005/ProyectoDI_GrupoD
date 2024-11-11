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
    public partial class ListadoActividades : Form
    {
        public ListadoActividades()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =  new Negocio.Management.ActividadesManagement().ObtenerProductos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DataGridViewButtonColumn(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en el botón "Eliminar"
            if (e.ColumnIndex == dataGridView1.Columns["btnEliminar"].Index)
            {
                // Obtener el índice de la fila seleccionada
                int rowIndex = e.RowIndex;

                // Obtener el objeto de la actividad seleccionada
                Negocio.EntitiesDTO.ActividadesMonitoresDTO actividadSeleccionada = dataGridView1.Rows[rowIndex].DataBoundItem as Negocio.EntitiesDTO.ActividadesMonitoresDTO;

                // Confirmar la eliminación
                DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar la actividad '{actividadSeleccionada.NombreActividad}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
 

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Llamar al método para eliminar la  actividad en la capa de negocio
                        new Negocio.Management.ActividadesManagement().EliminarActividad(actividadSeleccionada);

                        // Eliminar la fila del DataGridView
                        dataGridView1.Rows.RemoveAt(rowIndex);

                        // Mostrar mensaje de éxito
                        MessageBox.Show("Actividad eliminada correctamente.");
                    }
                    catch (Exception ex)
                    {
                        // Manejar la excepción
                        MessageBox.Show($"Error al eliminar la actividad: {ex.Message}");
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListadoActividades_Load(object sender, EventArgs e)
        {

        }
    }
}
