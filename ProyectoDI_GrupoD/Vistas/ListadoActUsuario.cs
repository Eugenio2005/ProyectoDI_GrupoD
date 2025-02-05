﻿using Negocio.EntitiesDTO;
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

        private void VistaActividades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (VistaActividades.CurrentCell == null)
            {
                // Si no hay celda seleccionada, mostrar un mensaje de error
                MessageBox.Show("Por favor, seleccione una actividad antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir de la función si no hay selección
            }
            int rowIndex = VistaActividades.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = VistaActividades.Rows[rowIndex];
            ActividadesClientesDTO actividadesClientesDTO = obtenerActividad(selectedRow);
            ValorarAct valorarAct = new ValorarAct(actividadesClientesDTO);
            valorarAct.ShowDialog();
            ListadoActUsuario_Load(sender, e);
        }

    }
}
