using Negocio.Management;
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

        /// <summary>
        /// Constructor de la clase ListadoActividades.
        /// Inicializa el formulario y crea una instancia de ActividadManagement.
        /// </summary>
        public ListadoActividades()
        {
            InitializeComponent();
            actividadManagement = new Negocio.Management.ActividadManagement();
        }

        /// <summary>
        /// Maneja el evento de carga del formulario.
        /// Carga las actividades en el DataGridView usando una BindingList.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento (el formulario).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void ListadoActividades_Load(object sender, EventArgs e)
        {
            // Cargar las actividades al DataGridView usando BindingList
            actividadesList = new Negocio.Management.ActividadManagement().ObtenerActividadesClienteApuntado(DatosUsuario.Email);
            VistaActividades.DataSource = actividadesList;
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Consultar".
        /// Actualiza la lista de actividades en el DataGridView.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento (el botón de consultar).</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Actualizar la lista de actividades
            actividadesList = actividadManagement.ObtenerActividadesClienteApuntado(DatosUsuario.Email);
            VistaActividades.DataSource = actividadesList;
        }

        /// <summary>
        /// Maneja el evento de clic en una celda del DataGridView.
        /// Si se hace clic en el botón "Eliminar", muestra una confirmación y elimina la actividad seleccionada.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento (el DataGridView).</param>
        /// <param name="e">Los argumentos del evento (información sobre la celda clickeada).</param>
        private void vistaActividades_ClicContenidoEliminarActividad(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la celda clickeada corresponde al botón "Eliminar"
            if (e.ColumnIndex == VistaActividades.Columns["btnEliminar"].Index && e.RowIndex >= 0)
            {
                // Obtener la actividad seleccionada
                var actividadSeleccionada = VistaActividades.Rows[e.RowIndex].DataBoundItem as Negocio.EntitiesDTO.ActividadesMonitoresDTO;

                if (actividadSeleccionada != null)
                {
                    // Confirmar la eliminación de la actividad
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
