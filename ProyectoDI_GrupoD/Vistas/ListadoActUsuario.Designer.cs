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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VistaActividades = new System.Windows.Forms.DataGridView();
            this.NombreActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMonitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMonitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valoracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadesClientesDTOBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesClientesDTOBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesClientesDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesMonitoresDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesClientesDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VistaActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesMonitoresDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // VistaActividades
            // 
            this.VistaActividades.AllowUserToAddRows = false;
            this.VistaActividades.AllowUserToOrderColumns = true;
            this.VistaActividades.AutoGenerateColumns = false;
            this.VistaActividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VistaActividades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.VistaActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VistaActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreActividad,
            this.DescripActividad,
            this.NombreMonitor,
            this.ApellidoMonitor,
            this.Valoracion});
            this.VistaActividades.DataSource = this.actividadesClientesDTOBindingSource3;
            this.VistaActividades.Dock = System.Windows.Forms.DockStyle.Left;
            this.VistaActividades.Location = new System.Drawing.Point(0, 0);
            this.VistaActividades.Name = "VistaActividades";
            this.VistaActividades.ReadOnly = true;
            this.VistaActividades.RowHeadersWidth = 51;
            this.VistaActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VistaActividades.Size = new System.Drawing.Size(692, 450);
            this.VistaActividades.TabIndex = 0;
            this.VistaActividades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VistaActividades_CellDoubleClick);
            this.VistaActividades.Paint += new System.Windows.Forms.PaintEventHandler(this.VistaActividades_Paint);
            // 
            // NombreActividad
            // 
            this.NombreActividad.DataPropertyName = "NombreActividad";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.NombreActividad.DefaultCellStyle = dataGridViewCellStyle11;
            this.NombreActividad.HeaderText = "Nombre Actividad";
            this.NombreActividad.MinimumWidth = 6;
            this.NombreActividad.Name = "NombreActividad";
            this.NombreActividad.ReadOnly = true;
            // 
            // DescripActividad
            // 
            this.DescripActividad.DataPropertyName = "DescripActividad";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.DescripActividad.DefaultCellStyle = dataGridViewCellStyle12;
            this.DescripActividad.HeaderText = "Descripción Actividad";
            this.DescripActividad.Name = "DescripActividad";
            this.DescripActividad.ReadOnly = true;
            // 
            // NombreMonitor
            // 
            this.NombreMonitor.DataPropertyName = "NombreMonitor";
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.NombreMonitor.DefaultCellStyle = dataGridViewCellStyle13;
            this.NombreMonitor.HeaderText = "Nombre Monitor";
            this.NombreMonitor.MinimumWidth = 6;
            this.NombreMonitor.Name = "NombreMonitor";
            this.NombreMonitor.ReadOnly = true;
            // 
            // ApellidoMonitor
            // 
            this.ApellidoMonitor.DataPropertyName = "ApellidoMonitor";
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.ApellidoMonitor.DefaultCellStyle = dataGridViewCellStyle14;
            this.ApellidoMonitor.HeaderText = "Apellido Monitor";
            this.ApellidoMonitor.MinimumWidth = 6;
            this.ApellidoMonitor.Name = "ApellidoMonitor";
            this.ApellidoMonitor.ReadOnly = true;
            // 
            // Valoracion
            // 
            this.Valoracion.DataPropertyName = "Valoracion";
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.Valoracion.DefaultCellStyle = dataGridViewCellStyle15;
            this.Valoracion.HeaderText = "Valoracion";
            this.Valoracion.MinimumWidth = 6;
            this.Valoracion.Name = "Valoracion";
            this.Valoracion.ReadOnly = true;
            // 
            // actividadesClientesDTOBindingSource3
            // 
            this.actividadesClientesDTOBindingSource3.DataSource = typeof(Negocio.EntitiesDTO.ActividadesClientesDTO);
            // 
            // actividadesClientesDTOBindingSource2
            // 
            this.actividadesClientesDTOBindingSource2.DataSource = typeof(Negocio.EntitiesDTO.ActividadesClientesDTO);
            // 
            // actividadesMonitoresDTOBindingSource
            // 
            this.actividadesMonitoresDTOBindingSource.DataSource = typeof(Negocio.EntitiesDTO.ActividadesMonitoresDTO);
            // 
            // actividadesClientesDTOBindingSource1
            // 
            this.actividadesClientesDTOBindingSource1.DataSource = typeof(Negocio.EntitiesDTO.ActividadesClientesDTO);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(713, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puedes valorar y desapuntarte\r\nde la actividad \r\npulsando doble clic\r\n";
            // 
            // ListadoActUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VistaActividades);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoActUsuario";
            this.Text = "ListadoActUsuario";
            this.Load += new System.EventHandler(this.ListadoActUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VistaActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesMonitoresDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private BindingSource actividadesClientesDTOBindingSource;
        private BindingSource actividadesClientesDTOBindingSource1;
        private BindingSource actividadesClientesDTOBindingSource2;
        private BindingSource actividadesClientesDTOBindingSource3;
        private DataGridViewTextBoxColumn NombreActividad;
        private DataGridViewTextBoxColumn DescripActividad;
        private DataGridViewTextBoxColumn NombreMonitor;
        private DataGridViewTextBoxColumn ApellidoMonitor;
        private DataGridViewTextBoxColumn Valoracion;
        private Label label1;
    }

}