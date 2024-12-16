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
    /// <summary>
    /// Representa la ventana de valoración de una actividad.
    /// Permite al usuario seleccionar una valoración de estrellas para una actividad.
    /// </summary>
    public partial class ValorarAct : Form
    {
        /// <summary>
        /// Arreglo de controles PictureBox que representan las estrellas de valoración.
        /// </summary>
        private PictureBox[] estrellas;

        /// <summary>
        /// Valoración actual de la actividad (un valor entre 1 y 5).
        /// </summary>
        private int valoracion = 0;

        /// <summary>
        /// ID del usuario que está realizando la valoración.
        /// </summary>
        private int idUsuario;

        /// <summary>
        /// Objeto que representa la actividad a valorar.
        /// </summary>
        private ActividadesClientesDTO act;

        /// <summary>
        /// Lista de actividades asociadas al cliente.
        /// </summary>
        private BindingList<Negocio.EntitiesDTO.ActividadesClientesDTO> actividadesList;

        /// <summary>
        /// Indica si la actividad ya ha sido valorada por el usuario.
        /// </summary>
        private bool valorada;

        /// <summary>
        /// Constructor por defecto de la ventana de valoración.
        /// Inicializa los componentes de la interfaz y las estrellas de valoración.
        /// </summary>
        public ValorarAct()
        {
            InitializeComponent();
            InicializarEstrellas(); // Inicializa las estrellas en la interfaz
        }

        /// <summary>
        /// Constructor que recibe una actividad seleccionada y aplica los textos a los campos.
        /// También deshabilita los campos para evitar la edición y verifica si la actividad ya fue valorada.
        /// </summary>
        /// <param name="actividadSeleccionada">Actividad que se va a valorar</param>
        public ValorarAct(ActividadesClientesDTO actividadSeleccionada)
        {
            InitializeComponent();
            aplicarTextoCampos(actividadSeleccionada); // Aplica los datos de la actividad a los campos
            act = actividadSeleccionada;
            deshabilitarCampos(); // Deshabilita los campos para evitar su edición
            valorada = new Negocio.Management.UsuarioManagement().comprobarActividadValorada(DatosUsuario.Email, act.NombreActividad); // Verifica si ya fue valorada
            InicializarEstrellas(); // Inicializa las estrellas
        }

        /// <summary>
        /// Inicializa las estrellas de valoración, creando controles PictureBox para cada una.
        /// </summary>
        private void InicializarEstrellas()
        {
            estrellas = new PictureBox[5]; // Crea un arreglo de 5 PictureBox para las estrellas

            // Inicializa la ubicación y tamaño de cada estrella en la interfaz
            for (int i = 0; i < 5; i++)
            {
                estrellas[i] = new PictureBox();
                estrellas[i].Size = new Size(40, 40); // Define el tamaño de cada estrella
                estrellas[i].SizeMode = PictureBoxSizeMode.StretchImage;
                estrellas[i].Location = new Point(90 + (i * 45), 315); // Define la ubicación de cada estrella
                estrellas[i].Click += Estrella_Click; // Asocia el evento de clic para cambiar la valoración
                this.Controls.Add(estrellas[i]);
                ActualizarEstrella(i, false); // Inicialmente todas las estrellas están vacías
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en una estrella. Cambia la valoración basada en la estrella seleccionada.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void Estrella_Click(object sender, EventArgs e)
        {
            PictureBox clickedStar = sender as PictureBox;
            valoracion = Array.IndexOf(estrellas, clickedStar) + 1; // Obtiene la posición de la estrella seleccionada

            // Actualiza el estado de las estrellas para reflejar la valoración
            for (int i = 0; i < 5; i++)
            {
                ActualizarEstrella(i, i < valoracion); // Marca las estrellas hasta la posición seleccionada como llenas
            }
        }

        /// <summary>
        /// Actualiza el estado de una estrella (llena o vacía) según el índice y el valor de 'llena'.
        /// </summary>
        /// <param name="index">Índice de la estrella a actualizar</param>
        /// <param name="llena">Indica si la estrella debe estar llena o vacía</param>
        private void ActualizarEstrella(int index, bool llena)
        {
            // Obtiene el directorio base de la aplicación para construir la ruta de las imágenes
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            // Define las rutas relativas de las imágenes de las estrellas
            string rutaEstrellaLlena = Path.Combine(basePath, "Recursos", "star_filled.png");
            string rutaEstrellaVacia = Path.Combine(basePath, "Recursos", "star_empty.png");

            try
            {
                // Cambia la imagen de la estrella según si está llena o vacía
                if (llena)
                    estrellas[index].Image = Image.FromFile(rutaEstrellaLlena); // Carga la imagen de la estrella llena
                else
                    estrellas[index].Image = Image.FromFile(rutaEstrellaVacia); // Carga la imagen de la estrella vacía
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si no se puede cargar la imagen
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Aplica los textos correspondientes a los campos de la interfaz con los datos de la actividad.
        /// </summary>
        /// <param name="actividad">Actividad a la que se le aplican los textos</param>
        private void aplicarTextoCampos(ActividadesClientesDTO actividad)
        {
            txtNombreActividad.Text = actividad.NombreActividad;
            txtDescripActividad.Text = actividad.DescripActividad;
            txtMonitorAsociado.Text = actividad.NombreMonitor;
        }

        /// <summary>
        /// Deshabilita los campos de texto para evitar que el usuario edite los datos.
        /// </summary>
        private void deshabilitarCampos()
        {
            txtNombreActividad.Enabled = false;
            txtDescripActividad.Enabled = false;
            txtMonitorAsociado.Enabled = false;
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de "Volver atrás".
        /// Cierra la ventana actual.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void imgAtras_Re_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta la ventana
            this.Close(); // Cierra la ventana
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de valorar la actividad.
        /// Realiza la valoración de la actividad si no ha sido valorada antes.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void btnValorar_Click(object sender, EventArgs e)
        {
            if (!valorada)
            {
                if (valoracion > 0)
                {
                    // Realiza la valoración inicial
                    bool result = new Negocio.Management.ActividadManagement().ValorarActividad(DatosUsuario.Email, act.NombreActividad, valoracion);
                    MessageBox.Show($"Actividad valorada con {valoracion} estrellas.", "Valoración exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una valoración de estrellas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (valoracion > 0)
                {
                    // Actualiza la valoración existente
                    new Negocio.Management.ActividadManagement().actualizarValoracion(DatosUsuario.Email, act.NombreActividad, valoracion);
                    MessageBox.Show($"Actividad valorada con {valoracion} estrellas.", "Valoración exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una valoración de estrellas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Evento que se ejecuta cuando la ventana de valoración se carga.
        /// Configura el texto del botón dependiendo de si la actividad ya fue valorada o no.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void ValorarAct_Load(object sender, EventArgs e)
        {
            if (!valorada)
            {
                btnValorar.Text = "Valorar"; // Si no se ha valorado, el botón muestra "Valorar"
            }
            else
            {
                btnValorar.Text = "Actualizar valoracion"; // Si ya se ha valorado, el botón muestra "Actualizar valoración"
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de desapuntarse de la actividad.
        /// Permite al usuario desapuntarse de la actividad si está apuntado.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void Desapuntar_Click(object sender, EventArgs e)
        {
            // Comprueba si el usuario está apuntado a la actividad
            bool usuarioApuntado = new Negocio.Management.UsuarioManagement().comprobarUsuarioApuntado(DatosUsuario.Email, act.NombreActividad);

            if (usuarioApuntado)
            {
                // Muestra una confirmación antes de desapuntarse
                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de que desea desapuntarse de esta actividad?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    // Procede con la desapuntación
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

        /// <summary>
        /// Evento generado al cambiar el texto del campo de nombre de la actividad.
        /// Actualmente no tiene lógica asociada.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void txtNombreActividad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}