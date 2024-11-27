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
        private BindingList<Negocio.EntitiesDTO.ActividadesMonitoresDTO> actividadesList;
        private Negocio.Management.ActividadManagement actividadManagement;
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
    }
}
