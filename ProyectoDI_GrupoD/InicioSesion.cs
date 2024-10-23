using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDI_GrupoD
{
    public partial class InicioSesion : Form
    {
        private String usuario;
        private String contraseña;
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void txtUsuarioInSe_TextChanged(object sender, EventArgs e)
        {
            usuario = txtUsuarioInSe.Text;
        }

        private void txtContraseñaInSe_TextChanged(object sender, EventArgs e)
        {
            contraseña = txtContraseñaInSe.Text;
        }

        private void btnIniciarSesionInSe_Click(object sender, EventArgs e)
        {
            
        }

        private void brnRegistrarInSe_Click(object sender, EventArgs e)
        {
            this.Hide();  // Oculta la ventana actual (inicio de sesión)
            Registro registro = new Registro();
            registro.ShowDialog();  // Muestra la ventana de registro como diálogo modal
            this.Show();  // Vuelve a mostrar la ventana de inicio de sesión después de cerrar la ventana de registro
        }
    }
}
