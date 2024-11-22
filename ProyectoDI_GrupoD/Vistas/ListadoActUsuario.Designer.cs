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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VistaActividades = new System.Windows.Forms.DataGridView();
            this.nombreActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMonitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMonitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadesMonitoresDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.VistaActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesMonitoresDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VistaActividades
            // 
            this.VistaActividades.AutoGenerateColumns = false;
            this.VistaActividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VistaActividades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(108)))), ((int)(((byte)(124)))));
            this.VistaActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VistaActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreActividadDataGridViewTextBoxColumn,
            this.nombreMonitorDataGridViewTextBoxColumn,
            this.apellidoMonitorDataGridViewTextBoxColumn});
            this.VistaActividades.DataSource = this.actividadesMonitoresDTOBindingSource;
            this.VistaActividades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VistaActividades.Location = new System.Drawing.Point(0, 0);
            this.VistaActividades.Name = "VistaActividades";
            this.VistaActividades.Size = new System.Drawing.Size(800, 450);
            this.VistaActividades.TabIndex = 0;
            this.VistaActividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VistaActividades_CellContentClick);
            this.VistaActividades.Paint += new System.Windows.Forms.PaintEventHandler(this.VistaActividades_Paint);
            // 
            // nombreActividadDataGridViewTextBoxColumn
            // 
            this.nombreActividadDataGridViewTextBoxColumn.DataPropertyName = "NombreActividad";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.nombreActividadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.nombreActividadDataGridViewTextBoxColumn.HeaderText = "Nombre Actividad";
            this.nombreActividadDataGridViewTextBoxColumn.Name = "nombreActividadDataGridViewTextBoxColumn";
            // 
            // nombreMonitorDataGridViewTextBoxColumn
            // 
            this.nombreMonitorDataGridViewTextBoxColumn.DataPropertyName = "NombreMonitor";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.nombreMonitorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.nombreMonitorDataGridViewTextBoxColumn.HeaderText = "Nombre Monitor";
            this.nombreMonitorDataGridViewTextBoxColumn.Name = "nombreMonitorDataGridViewTextBoxColumn";
            // 
            // apellidoMonitorDataGridViewTextBoxColumn
            // 
            this.apellidoMonitorDataGridViewTextBoxColumn.DataPropertyName = "ApellidoMonitor";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.apellidoMonitorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.apellidoMonitorDataGridViewTextBoxColumn.HeaderText = "Apellido Monitor";
            this.apellidoMonitorDataGridViewTextBoxColumn.Name = "apellidoMonitorDataGridViewTextBoxColumn";
            // 
            // actividadesMonitoresDTOBindingSource
            // 
            this.actividadesMonitoresDTOBindingSource.DataSource = typeof(Negocio.EntitiesDTO.ActividadesMonitoresDTO);
            // 
            // ListadoActUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VistaActividades);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoActUsuario";
            this.Text = "ListadoActUsuario";
            this.Load += new System.EventHandler(this.ListadoActUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VistaActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesMonitoresDTOBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMonitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMonitorDataGridViewTextBoxColumn;
    }

}