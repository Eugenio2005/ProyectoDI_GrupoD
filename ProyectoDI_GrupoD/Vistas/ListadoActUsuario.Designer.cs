using System.Drawing;
using System.Windows.Forms;

namespace ProyectoDI_GrupoD.Vistas
{
    partial class ListadoActUsuario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VistaActividades = new System.Windows.Forms.DataGridView();
            this.DescripActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valoracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnValorar = new ProyectoDI_GrupoD.RoundedButton();
            this.btnDesapuntar = new ProyectoDI_GrupoD.RoundedButton();
            this.NombreActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMonitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMonitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadesClientesDTOBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesClientesDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesMonitoresDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesClientesDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesClientesDTOBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.VistaActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesMonitoresDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // VistaActividades
            // 
            this.VistaActividades.AllowUserToAddRows = false;
            this.VistaActividades.AllowUserToOrderColumns = true;
            this.VistaActividades.AutoGenerateColumns = false;
            this.VistaActividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VistaActividades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(108)))), ((int)(((byte)(124)))));
            this.VistaActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VistaActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreActividad,
            this.NombreMonitor,
            this.ApellidoMonitor,
            this.DescripActividad,
            this.Valoracion});
            this.VistaActividades.DataSource = this.actividadesClientesDTOBindingSource3;
            this.VistaActividades.Dock = System.Windows.Forms.DockStyle.Left;
            this.VistaActividades.Location = new System.Drawing.Point(0, 0);
            this.VistaActividades.Margin = new System.Windows.Forms.Padding(4);
            this.VistaActividades.Name = "VistaActividades";
            this.VistaActividades.ReadOnly = true;
            this.VistaActividades.RowHeadersWidth = 51;
            this.VistaActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VistaActividades.Size = new System.Drawing.Size(884, 554);
            this.VistaActividades.TabIndex = 0;
            this.VistaActividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VistaActividades_CellContentClick);
            this.VistaActividades.Paint += new System.Windows.Forms.PaintEventHandler(this.VistaActividades_Paint);
            // 
            // DescripActividad
            // 
            this.DescripActividad.DataPropertyName = "DescripActividad";
            this.DescripActividad.HeaderText = "DescripActividad";
            this.DescripActividad.MinimumWidth = 6;
            this.DescripActividad.Name = "DescripActividad";
            this.DescripActividad.ReadOnly = true;
            this.DescripActividad.Visible = false;
            // 
            // Valoracion
            // 
            this.Valoracion.DataPropertyName = "Valoracion";
            this.Valoracion.HeaderText = "Valoracion";
            this.Valoracion.MinimumWidth = 6;
            this.Valoracion.Name = "Valoracion";
            this.Valoracion.ReadOnly = true;
            // 
            // btnValorar
            // 
            this.btnValorar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(110)))), ((int)(((byte)(84)))));
            this.btnValorar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(110)))), ((int)(((byte)(84)))));
            this.btnValorar.BorderRadius = 20;
            this.btnValorar.FillColor = System.Drawing.Color.Transparent;
            this.btnValorar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnValorar.Image = global::ProyectoDI_GrupoD.Properties.Resources.positivo;
            this.btnValorar.Location = new System.Drawing.Point(929, 154);
            this.btnValorar.Margin = new System.Windows.Forms.Padding(4);
            this.btnValorar.Name = "btnValorar";
            this.btnValorar.Size = new System.Drawing.Size(105, 92);
            this.btnValorar.TabIndex = 4;
            this.btnValorar.UseVisualStyleBackColor = false;
            this.btnValorar.Click += new System.EventHandler(this.btnValorar_Click);
            // 
            // btnDesapuntar
            // 
            this.btnDesapuntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(110)))), ((int)(((byte)(84)))));
            this.btnDesapuntar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(110)))), ((int)(((byte)(84)))));
            this.btnDesapuntar.BorderRadius = 20;
            this.btnDesapuntar.FillColor = System.Drawing.Color.Transparent;
            this.btnDesapuntar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDesapuntar.Image = global::ProyectoDI_GrupoD.Properties.Resources.borrar_usuario_1_;
            this.btnDesapuntar.Location = new System.Drawing.Point(929, 292);
            this.btnDesapuntar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesapuntar.Name = "btnDesapuntar";
            this.btnDesapuntar.Size = new System.Drawing.Size(105, 92);
            this.btnDesapuntar.TabIndex = 3;
            this.btnDesapuntar.UseVisualStyleBackColor = false;
            this.btnDesapuntar.Click += new System.EventHandler(this.btnDesapuntar_Click);
            // 
            // NombreActividad
            // 
            this.NombreActividad.DataPropertyName = "NombreActividad";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.NombreActividad.DefaultCellStyle = dataGridViewCellStyle1;
            this.NombreActividad.HeaderText = "Nombre Actividad";
            this.NombreActividad.MinimumWidth = 6;
            this.NombreActividad.Name = "NombreActividad";
            this.NombreActividad.ReadOnly = true;
            // 
            // NombreMonitor
            // 
            this.NombreMonitor.DataPropertyName = "NombreMonitor";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.NombreMonitor.DefaultCellStyle = dataGridViewCellStyle2;
            this.NombreMonitor.HeaderText = "Nombre Monitor";
            this.NombreMonitor.MinimumWidth = 6;
            this.NombreMonitor.Name = "NombreMonitor";
            this.NombreMonitor.ReadOnly = true;
            // 
            // ApellidoMonitor
            // 
            this.ApellidoMonitor.DataPropertyName = "ApellidoMonitor";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.ApellidoMonitor.DefaultCellStyle = dataGridViewCellStyle3;
            this.ApellidoMonitor.HeaderText = "Apellido Monitor";
            this.ApellidoMonitor.MinimumWidth = 6;
            this.ApellidoMonitor.Name = "ApellidoMonitor";
            this.ApellidoMonitor.ReadOnly = true;
            // 
            // actividadesClientesDTOBindingSource2
            // 
            this.actividadesClientesDTOBindingSource2.DataSource = typeof(Negocio.EntitiesDTO.ActividadesClientesDTO);
            // 
            // actividadesClientesDTOBindingSource
            // 
            this.actividadesClientesDTOBindingSource.DataSource = typeof(Negocio.EntitiesDTO.ActividadesClientesDTO);
            // 
            // actividadesMonitoresDTOBindingSource
            // 
            this.actividadesMonitoresDTOBindingSource.DataSource = typeof(Negocio.EntitiesDTO.ActividadesMonitoresDTO);
            // 
            // actividadesClientesDTOBindingSource1
            // 
            this.actividadesClientesDTOBindingSource1.DataSource = typeof(Negocio.EntitiesDTO.ActividadesClientesDTO);
            // 
            // actividadesClientesDTOBindingSource3
            // 
            this.actividadesClientesDTOBindingSource3.DataSource = typeof(Negocio.EntitiesDTO.ActividadesClientesDTO);
            // 
            // ListadoActUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnValorar);
            this.Controls.Add(this.btnDesapuntar);
            this.Controls.Add(this.VistaActividades);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListadoActUsuario";
            this.Text = "ListadoActUsuario";
            this.Load += new System.EventHandler(this.ListadoActUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VistaActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesMonitoresDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        // Redondear las esquinas del DataGridView
        private void VistaActividades_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 20; // Radio del redondeo
            path.AddArc(0, 0, radius, radius, 180, 90); // esquina superior izquierda
            path.AddArc(VistaActividades.Width - radius - 1, 0, radius, radius, 270, 90); // esquina superior derecha
            path.AddArc(VistaActividades.Width - radius - 1, VistaActividades.Height - radius - 1, radius, radius, 0, 90); // esquina inferior derecha
            path.AddArc(0, VistaActividades.Height - radius - 1, radius, radius, 90, 90); // esquina inferior izquierda
            path.CloseFigure();

            // Aplicar la forma al DataGridView
            VistaActividades.Region = new System.Drawing.Region(path);

            // Optional: Ajustar el borde (si deseas un borde personalizado)
            Pen pen = new Pen(Color.Black, 2);
            e.Graphics.DrawPath(pen, path);
        }
    




private System.Windows.Forms.DataGridView VistaActividades;
        private System.Windows.Forms.BindingSource actividadesMonitoresDTOBindingSource;
        private RoundedButton btnDesapuntar;
        private BindingSource actividadesClientesDTOBindingSource;
        private RoundedButton btnValorar;
        private BindingSource actividadesClientesDTOBindingSource1;
        private BindingSource actividadesClientesDTOBindingSource2;
        private DataGridViewTextBoxColumn NombreActividad;
        private DataGridViewTextBoxColumn NombreMonitor;
        private DataGridViewTextBoxColumn ApellidoMonitor;
        private DataGridViewTextBoxColumn DescripActividad;
        private DataGridViewTextBoxColumn Valoracion;
        private BindingSource actividadesClientesDTOBindingSource3;
    }

}