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
    public partial class PantallaPrincipal : Form
    {
        private string email, contraseña;

        public PantallaPrincipal(string email)
        {
            InitializeComponent();

            this.email = email;

            NombreUsuario.ButtonText = email;
            lblNombreUsuarioP1.Text = email;
        }

        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void PantallaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
