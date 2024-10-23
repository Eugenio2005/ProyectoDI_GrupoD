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
    public partial class Registro : Form
    {
        private String nombre, apellido, DNI, telefono, email, direccion, cuentaCorriente, contraseña;
        public Registro()
        {
            InitializeComponent();
        }

        private void brnRegistrarRe_Click(object sender, EventArgs e)
        {
            nombre = txtUsuarioRe.Text;
            apellido = txtApellidosRe.Text;
            DNI = txtDNI_Re.Text;
            telefono = txtTelefonoRe.Text;
            email = txtEmailRe.Text;
            direccion = txtDireccionRe.Text;
            cuentaCorriente = txtCuentaCorrienteRe.Text;
            contraseña = txtContraseñaRe.Text;
        }

        private void brnBorrarRe_Click(object sender, EventArgs e)
        {
            txtUsuarioRe.Clear();
            txtApellidosRe.Clear();
            txtDNI_Re.Clear();
            txtTelefonoRe.Clear();
            txtEmailRe.Clear();
            txtDireccionRe.Clear();
            txtCuentaCorrienteRe.Clear();
            txtContraseñaRe.Clear();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
