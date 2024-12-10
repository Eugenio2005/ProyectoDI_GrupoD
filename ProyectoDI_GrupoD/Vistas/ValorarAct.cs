using Negocio.EntitiesDTO;
using Negocio.Management;
using ProyectoDI_GrupoD.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ProyectoDI_GrupoD.Vistas
{
    public partial class ValorarAct : Form
    {
        // Declarar el arreglo de PictureBox para las estrellas
        private PictureBox[] estrellas;
        private int valoracion = 0; // Valoración actual (1-5)
        private int idUsuario;
        private ActividadesClientesDTO act;
        private BindingList<Negocio.EntitiesDTO.ActividadesClientesDTO> actividadesList;

        public ValorarAct()
        {
            InitializeComponent();
            InicializarEstrellas();
          
        }

        public ValorarAct(ActividadesClientesDTO actividadSeleccionada)
        {
            InitializeComponent();
            aplicarTextoCampos(actividadSeleccionada);
            act = actividadSeleccionada;
            deshabilitarCampos();
            bool valorada = new Negocio.Management.UsuarioManagement().comprobarActividadValorada(DatosUsuario.Email, act.NombreActividad);
            if (!valorada)
            {
                InicializarEstrellas();
            }



        }

        // Inicializa las estrellas
        private void InicializarEstrellas()
        {
            // Crear el arreglo de estrellas
            estrellas = new PictureBox[5];

            // Ubicación inicial de las estrellas
            for (int i = 0; i < 5; i++)
            {
                estrellas[i] = new PictureBox();
                estrellas[i].Size = new Size(40, 40); // Tamaño de la estrella
                estrellas[i].SizeMode = PictureBoxSizeMode.StretchImage;
                estrellas[i].Location = new Point(90 + (i * 45), 315); // Espaciado entre las estrellas
                estrellas[i].Click += Estrella_Click; // Evento de clic para cambiar la valoración
                this.Controls.Add(estrellas[i]);
                ActualizarEstrella(i, false); // Inicialmente, todas las estrellas están vacías
            }
        }

        // Este método se ejecuta al hacer clic en una estrella
        private void Estrella_Click(object sender, EventArgs e)
        {
            PictureBox clickedStar = sender as PictureBox;
            valoracion = Array.IndexOf(estrellas, clickedStar) + 1; // Obtener la posición de la estrella seleccionada

            // Actualizar el estado de todas las estrellas
            for (int i = 0; i < 5; i++)
            {
                ActualizarEstrella(i, i < valoracion); // Llenar las estrellas hasta la posición seleccionada
            }
        }

        // Método para actualizar el estado de la estrella (llena o vacía)
        private void ActualizarEstrella(int index, bool llena)
        {
            // Obtén el directorio base de la aplicación
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            // Construye las rutas relativas
            string rutaEstrellaLlena = Path.Combine(basePath, "Recursos", "star_filled.png");
            string rutaEstrellaVacia = Path.Combine(basePath, "Recursos", "star_empty.png");
            bool valorada = new Negocio.Management.UsuarioManagement().comprobarActividadValorada(DatosUsuario.Email, act.NombreActividad);
            if (!valorada)
            {
                try
                {
                    if (llena)
                        estrellas[index].Image = Image.FromFile(rutaEstrellaLlena); // Carga la estrella llena
                    else
                        estrellas[index].Image = Image.FromFile(rutaEstrellaVacia); // Carga la estrella vacía
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        // Método para aplicar los textos a los campos de actividad
        private void aplicarTextoCampos(ActividadesClientesDTO actividad)
        {
            txtNombreActividad.Text = actividad.NombreActividad;
            txtDescripActividad.Text = actividad.DescripActividad;
            txtMonitorAsociado.Text = actividad.NombreMonitor;
        }

        // Método para deshabilitar los campos de texto
        private void deshabilitarCampos()
        {
            txtNombreActividad.Enabled = false;
            txtDescripActividad.Enabled = false;
            txtMonitorAsociado.Enabled = false;
        }

        // Evento de la flecha para volver atrás
        private void imgAtras_Re_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        // Evento al hacer clic en el botón de valorar
        private void btnValorar_Click(object sender, EventArgs e)
        {
           bool valorada = new Negocio.Management.UsuarioManagement().comprobarActividadValorada(DatosUsuario.Email, act.NombreActividad);
            if (valoracion > 0)
            {
                
                new Negocio.Management.ActividadManagement().valorarActividad(DatosUsuario.Email,act.NombreActividad,valoracion);
               MessageBox.Show($"Actividad valorada con {valoracion} estrellas.", "Valoración exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una valoración de estrellas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ValorarAct_Load(object sender, EventArgs e)
        {
            bool valorada = new Negocio.Management.UsuarioManagement().comprobarActividadValorada(DatosUsuario.Email, act.NombreActividad);
            if (!valorada)
            {
                btnValorar.Visible = true;
            }
            else
            {
                btnValorar.Visible = false;
            }
        }

        private void Desapuntar_Click(object sender, EventArgs e)
        {

            // Comprobar si el usuario ya está apuntado a la actividad
            bool usuarioApuntado = new Negocio.Management.UsuarioManagement().comprobarUsuarioApuntado(DatosUsuario.Email, act.NombreActividad);

            if (usuarioApuntado)
            {
                // Preguntar al usuario si está seguro de desapuntarse
                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de que desea desapuntarse de esta actividad?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    // Proceder con la desapuntación
                    bool desapuntarUsuario = new Negocio.Management.UsuarioManagement().desapuntarUsuarioActividad(DatosUsuario.Email, act.NombreActividad);

                    if (desapuntarUsuario)
                    {
                        MessageBox.Show($"El usuario se desapuntó exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Error, el usuario no se pudo desapuntar de esta actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Si el usuario no está apuntado, muestra un mensaje de error
                MessageBox.Show($"El usuario no está apuntado a esta actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
