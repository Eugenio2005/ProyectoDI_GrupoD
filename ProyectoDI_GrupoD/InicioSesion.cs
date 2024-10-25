using Negocio.EntitiesDTO;
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
        private string usuario, contraseña;
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
            if (new Negocio.Management.UsuarioManagement().validarUsuario(txtUsuarioInSe.Text, txtContraseñaInSe.Text))
            {
                this.Hide();  // Oculta la ventana actual (inicio de sesión)
                PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
                pantallaPrincipal.ShowDialog();  // Muestra la ventana principal como diálogo modal
            }
            else
            {
                MessageBox.Show($"El usuario no existe o la contraseña es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void brnRegistrarInSe_Click(object sender, EventArgs e)
        {
            this.Hide();  // Oculta la ventana actual (inicio de sesión)
            Registro registro = new Registro();
            registro.ShowDialog();  // Muestra la ventana de registro como diálogo modal
        }

    }
}
