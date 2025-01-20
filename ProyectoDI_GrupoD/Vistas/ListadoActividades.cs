using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Negocio.EntitiesDTO;
using Negocio.Management;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

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
            actividadesList = new Negocio.Management.ActividadManagement().ObtenerTodasActividades();
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            var actividades = ObtenerDatosActividades(); 
            ExportarAPDF(actividades);
            ExportarAExcel(actividades);
        }

        private List<ActividadDTO> ObtenerDatosActividades()
        {
            var actividades = new List<ActividadDTO>();

            // Recorremos cada fila del DataGridView
            foreach (DataGridViewRow row in VistaActividades.Rows)
            {
                // Evitar procesar filas nuevas vacías (si AllowUserToAddRows está habilitado)
                if (row.IsNewRow) continue;

                // Crear una nueva actividad con los datos de la fila
                var actividad = new ActividadDTO
                {
                    NombreActividad = row.Cells["nombreActividadDataGridViewTextBoxColumn"].Value?.ToString() ?? "N/A",
                    MonitorAsociado = row.Cells["nombreMonitorDataGridViewTextBoxColumn"].Value?.ToString() ?? "N/A",
                    numUsuariosApuntados = int.TryParse(row.Cells["Usuarios_apuntados"].Value?.ToString(), out int usuarios) ? usuarios : 0,
                    Valoracion_media = float.TryParse(row.Cells["Valoracion_media"].Value?.ToString(), out float valoracion) ? valoracion : 0f
                };

                actividades.Add(actividad);
            }

            return actividades;
        }


        private void ExportarAExcel(List<ActividadDTO> actividades)
        {
            // Configurar la licencia de EPPlus
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Guardar archivo Excel";
                saveFileDialog.FileName = "Actividades.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var package = new ExcelPackage())
                    {
                        var worksheet = package.Workbook.Worksheets.Add("Actividades");

                        // Cabecera
                        worksheet.Cells[1, 1].Value = "Nombre Actividad";
                        worksheet.Cells[1, 2].Value = "Nombre Monitor";
                        worksheet.Cells[1, 3].Value = "Usuarios Apuntados";
                        worksheet.Cells[1, 4].Value = "Valoración Media";

                        int row = 2;
                        foreach (var actividad in actividades)
                        {
                            worksheet.Cells[row, 1].Value = actividad.NombreActividad;
                            worksheet.Cells[row, 2].Value = actividad.MonitorAsociado ?? "N/A";
                            worksheet.Cells[row, 3].Value = actividad.numUsuariosApuntados;
                            worksheet.Cells[row, 4].Value = actividad.Valoracion_media > 0
                                ? actividad.Valoracion_media.ToString("F2")
                                : "N/A";
                            row++;
                        }

                        package.SaveAs(new FileInfo(saveFileDialog.FileName));
                    }

                    MessageBox.Show("Excel generado con éxito.");
                }
            }
        }

        private void ExportarAPDF(List<ActividadDTO> actividades)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar archivo PDF";
                saveFileDialog.FileName = "Actividades.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new PdfWriter(saveFileDialog.FileName))
                    {
                        var pdf = new PdfDocument(writer);
                        var document = new Document(pdf);

                        // Crear fuente en negrita
                        var boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

                        // Crear el párrafo con estilo
                        var titulo = new Paragraph("Listado de Actividades")
                            .SetFont(boldFont) // Asignar la fuente en negrita
                            .SetFontSize(16);

                        document.Add(titulo);

                        // Tabla
                        var table = new Table(4); // 4 columnas
                        table.AddHeaderCell("Nombre Actividad");
                        table.AddHeaderCell("Nombre Monitor");
                        table.AddHeaderCell("Usuarios Apuntados");
                        table.AddHeaderCell("Valoración Media");

                        foreach (var actividad in actividades)
                        {
                            table.AddCell(actividad.NombreActividad);
                            table.AddCell(actividad.MonitorAsociado ?? "N/A");
                            table.AddCell(actividad.numUsuariosApuntados.ToString());
                            table.AddCell(actividad.Valoracion_media > 0
                                ? actividad.Valoracion_media.ToString("F2")
                                : "N/A");
                        }

                        document.Add(table);
                        document.Close();
                    }

                    MessageBox.Show("PDF generado con éxito.");
                }
            }
        }


    }
}
