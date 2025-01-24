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
    using CrystalDecisions.CrystalReports.Engine;
    using CrystalDecisions.Shared;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Negocio.EntitiesDTO;
    using System.IO;
    using CrystalDecisions.ReportAppServer;
    using Negocio.Management;

    public partial class FormMisFacturas : Form
    {
        // Simulación de los datos de facturas
        private List<int> aniosDisponibles = new List<int> { 2023, 2024, 2025 };
        private Informe.Facturas Facturas;
        private Dictionary<int, List<string>> mesesPorAnio = new Dictionary<int, 
            List<string>> {
                            { 2023, new List<string> { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto" , "Septiembre", "Octubre", "Noviembre", "Diciembre" } },
                            { 2024, new List<string> { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto" , "Septiembre", "Octubre", "Noviembre", "Diciembre" }},
                            { 2025, new List<string> { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto" , "Septiembre", "Octubre", "Noviembre", "Diciembre" } }
                          };

        public FormMisFacturas()
        {
            Facturas = new Informe.Facturas();
            InitializeComponent();
            comboBoxAnios.DataSource = aniosDisponibles;
        }

        private void comboBoxAnios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int anioSeleccionado = (int)comboBoxAnios.SelectedItem;
            if (mesesPorAnio.ContainsKey(anioSeleccionado))
            {
                List<string> meses = mesesPorAnio[anioSeleccionado];

                // Obtener el mes actual
                int mesActual = DateTime.Now.Month;

                // Si el año seleccionado es el actual, limitar los meses hasta el mes actual
                if (anioSeleccionado == DateTime.Now.Year)
                {
                    meses = meses.Take(mesActual).ToList();
                }

                comboBoxMeses.DataSource = meses;
                ValidarYMostrarReporte();
            }
        }

        private void comboBoxMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarYMostrarReporte();
        }

        private void ValidarYMostrarReporte()
        {
            if (comboBoxAnios.SelectedItem != null && comboBoxMeses.SelectedItem != null)
            {
                int anioSeleccionado = (int)comboBoxAnios.SelectedItem;
                string mesSeleccionado = comboBoxMeses.SelectedItem.ToString();

                // Llamar al método actualizado con los parámetros seleccionados
                crystalReportViewer1Datos(anioSeleccionado, mesSeleccionado);
            }
        }


        private void crystalReportViewer1Datos(int anio, string mes)
        {
            if (Facturas == null)
            {
                MessageBox.Show("Error: El objeto Facturas no está inicializado.");
                return;
            }

            // Instanciar ActividadManagement
            ActividadManagement actividadManagement = new ActividadManagement();

            // Obtener las actividades del cliente
            string emailUsuario = Negocio.Management.DatosUsuario.Email; // Asumiendo que tienes el email del usuario
            var actividadesCliente = actividadManagement.ObtenerActividadesClienteApuntado(emailUsuario);

            // Crear un DataTable para las actividades
            var actividadesTable = new System.Data.DataTable();
            actividadesTable.Columns.Add("NombreActividad", typeof(string));
            actividadesTable.Columns.Add("DescripActividad", typeof(string));
            actividadesTable.Columns.Add("NombreMonitor", typeof(string));
            actividadesTable.Columns.Add("ApellidoMonitor", typeof(string));
            actividadesTable.Columns.Add("Valoracion", typeof(int));

            // Llenar el DataTable con los datos de las actividades
            foreach (var actividad in actividadesCliente)
            {
                actividadesTable.Rows.Add(actividad.NombreActividad, actividad.DescripActividad, actividad.NombreMonitor, actividad.ApellidoMonitor, actividad.Valoracion);
            }

            // Asignar el DataTable como fuente de datos del reporte
            Facturas.SetDataSource(actividadesTable);

            // Generar un número aleatorio para el número de factura
            Random random = new Random();
            int numeroFactura = random.Next(1000, 9999); // Generar un número aleatorio entre 1000 y 9999


            // Asignar los parámetros al objeto Facturas antes de mostrar el reporte
            Facturas.SetParameterValue("Ano", anio);
            Facturas.SetParameterValue("Mes", mes);
            Facturas.SetParameterValue("numeroFactura", numeroFactura);
            Facturas.SetParameterValue("Usuario.nombre", Negocio.Management.DatosUsuario.Nombre);
            Facturas.SetParameterValue("Usuario.apellido", Negocio.Management.DatosUsuario.Apellidos);
            Facturas.SetParameterValue("Usuario.direccion", Negocio.Management.DatosUsuario.Direccion);
            Facturas.SetParameterValue("Usuario.dni", Negocio.Management.DatosUsuario.Dni);
            Facturas.SetParameterValue("Usuario.ccc", Negocio.Management.DatosUsuario.CuentaCorriente);

            // Asignar el reporte al visor
            crystalReportViewer1.ReportSource = Facturas;

            crystalReportViewer1.Refresh();
        }



        private void ButtonDescargarFactura_Click(object sender, EventArgs e)
        {
            int anioSeleccionado = (int)comboBoxAnios.SelectedItem;
            string mesSeleccionado = comboBoxMeses.SelectedItem.ToString();

            // Crear la factura con los datos seleccionados
            FacturaDAO factura = new FacturaDAO
            {
                Anio = anioSeleccionado,
                Mes = mesSeleccionado,
                Contenido = $"Factura del mes de {mesSeleccionado} del año {anioSeleccionado}"
            };

            try
            {
                // Reutilizar el ReportDocument que ya se carga en crystalReportViewer1Datos
                ReportDocument reporte = Facturas;

                // Asignar los parámetros al objeto Facturas antes de generar el reporte
                reporte.SetParameterValue("Ano", anioSeleccionado);
                reporte.SetParameterValue("Mes", mesSeleccionado);
                reporte.SetParameterValue("Usuario.nombre", Negocio.Management.DatosUsuario.Nombre);
                reporte.SetParameterValue("Usuario.apellido", Negocio.Management.DatosUsuario.Apellidos);
                reporte.SetParameterValue("Usuario.direccion", Negocio.Management.DatosUsuario.Direccion);
                reporte.SetParameterValue("Usuario.dni", Negocio.Management.DatosUsuario.Dni);
                reporte.SetParameterValue("Usuario.ccc", Negocio.Management.DatosUsuario.CuentaCorriente);

                // Exportar el reporte a PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Guardar Factura como PDF";
                saveFileDialog.FileName = $"Factura_{anioSeleccionado}_{mesSeleccionado}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string exportFilePath = saveFileDialog.FileName;
                    try
                    {
                        reporte.ExportToDisk(ExportFormatType.PortableDocFormat, exportFilePath);
                        MessageBox.Show("Factura guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el informe: {ex.Message}");
            }
        }
    }
}
