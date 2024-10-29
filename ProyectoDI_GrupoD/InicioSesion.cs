using Negocio.EntitiesDTO; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        /// <summary>
        /// Maneja el evento de clic en el botón de iniciar sesión.
        /// Valida el usuario y la contraseña ingresados.
        /// Si son correctos, oculta la ventana de inicio de sesión y muestra la ventana principal.
        /// Si son incorrectos, muestra un mensaje de error.
        /// </summary>
        private void btnIniciarSesionInSe_Click(object sender, EventArgs e)
        {
            // Verifica si el usuario y la contraseña son válidos
            if (new Negocio.Management.UsuarioManagement().validarUsuario(txtUsuarioInSe.Text, txtContraseñaInSe.Text))
            {
                this.Hide();
                PantallaPrincipal pantallaPrincipal = new PantallaPrincipal(); 
                pantallaPrincipal.ShowDialog();  
            }
            else
            {
                // Muestra un mensaje de error si el usuario o la contraseña son incorrectos
                MessageBox.Show($"El usuario no existe o la contraseña es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el icono de ojo cerrado.
        /// Cambia la visibilidad de la contraseña a oculta y actualiza la visibilidad del icono.
        /// </summary>
        private void btnojoCerradoInSe_Click(object sender, EventArgs e)
        {
            txtContraseñaInSe.UseSystemPasswordChar = true; // Oculta la contraseña
            btnojo_abiertoInSe.Visible = true; 
            btnojoCerradoInSe.Visible = false; 
        }

        /// <summary>
        /// Maneja el evento de clic en el icono de ojo abierto.
        /// Cambia la visibilidad de la contraseña a visible y actualiza el estado del icono.
        /// </summary>
        private void btnojoAbiertoInSe_Click(object sender, EventArgs e)
        {
            txtContraseñaInSe.UseSystemPasswordChar = false; // Muestra la contraseña
            btnojo_abiertoInSe.Visible = false; 
            btnojoCerradoInSe.Visible = true; 
        }

        private void InicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciarSesionInSe_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            int borderRadius = 20; // Ajusta el radio del borde

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(btn.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(btn.Width - borderRadius, btn.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, btn.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);

            using (Pen pen = new Pen(Color.Gray, 1))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void btnRegistrarInSe_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            int borderRadius = 20; // Ajusta el radio del borde

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(btn.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(btn.Width - borderRadius, btn.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, btn.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);

            using (Pen pen = new Pen(Color.Gray, 1))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de registrar.
        /// Oculta la ventana de inicio de sesión y muestra la ventana de registro.
        /// </summary>
        private void brnRegistrarInSe_Click(object sender, EventArgs e)
        {
            this.Hide();  
            Registro registro = new Registro(); 
            registro.ShowDialog();  
        }

    }
}
