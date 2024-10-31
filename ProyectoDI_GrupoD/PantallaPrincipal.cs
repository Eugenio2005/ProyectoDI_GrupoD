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
        private string usuario, contraseña;

        public PantallaPrincipal(string usuario, string contraseña)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.contraseña = contraseña;

            lblNombreUsuarioP1.Text = usuario;
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
