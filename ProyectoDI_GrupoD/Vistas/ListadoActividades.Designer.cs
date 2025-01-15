using System.Windows.Forms;

namespace ProyectoDI_GrupoD.Vistas
{
    partial class ListadoActividades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VistaActividades = new System.Windows.Forms.DataGridView();
            this.btnExportar = new ProyectoDI_GrupoD.RoundedButton();
            this.actividadesMonitoresDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nombreActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMonitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMonitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuarios_apuntados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valoracion_media = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.VistaActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesMonitoresDTOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // VistaActividades
            // 
            this.VistaActividades.AllowUserToOrderColumns = true;
            this.VistaActividades.AutoGenerateColumns = false;
            this.VistaActividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VistaActividades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.VistaActividades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VistaActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VistaActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreActividadDataGridViewTextBoxColumn,
            this.nombreMonitorDataGridViewTextBoxColumn,
            this.apellidoMonitorDataGridViewTextBoxColumn,
            this.Usuarios_apuntados,
            this.Valoracion_media,
            this.btnEliminar});
            this.VistaActividades.DataSource = this.actividadesMonitoresDTOBindingSource1;
            this.VistaActividades.Location = new System.Drawing.Point(0, -1);
            this.VistaActividades.Name = "VistaActividades";
            this.VistaActividades.RowHeadersWidth = 51;
            this.VistaActividades.Size = new System.Drawing.Size(841, 452);
            this.VistaActividades.TabIndex = 0;
            this.VistaActividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vistaActividades_ClicContenidoEliminarActividad);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.btnExportar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.btnExportar.BorderRadius = 20;
            this.btnExportar.FillColor = System.Drawing.Color.Transparent;
            this.btnExportar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExportar.Location = new System.Drawing.Point(868, 204);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(125, 52);
            this.btnExportar.TabIndex = 1;
            this.btnExportar.Text = "Exportar a...";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // actividadesMonitoresDTOBindingSource1
            // 
            this.actividadesMonitoresDTOBindingSource1.DataSource = typeof(Negocio.EntitiesDTO.ActividadesMonitoresDTO);
            // 
            // nombreActividadDataGridViewTextBoxColumn
            // 
            this.nombreActividadDataGridViewTextBoxColumn.DataPropertyName = "NombreActividad";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.nombreActividadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.nombreActividadDataGridViewTextBoxColumn.HeaderText = "Nombre Actividad";
            this.nombreActividadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreActividadDataGridViewTextBoxColumn.Name = "nombreActividadDataGridViewTextBoxColumn";
            // 
            // nombreMonitorDataGridViewTextBoxColumn
            // 
            this.nombreMonitorDataGridViewTextBoxColumn.DataPropertyName = "NombreMonitor";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.nombreMonitorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nombreMonitorDataGridViewTextBoxColumn.HeaderText = "Nombre Monitor";
            this.nombreMonitorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreMonitorDataGridViewTextBoxColumn.Name = "nombreMonitorDataGridViewTextBoxColumn";
            // 
            // apellidoMonitorDataGridViewTextBoxColumn
            // 
            this.apellidoMonitorDataGridViewTextBoxColumn.DataPropertyName = "ApellidoMonitor";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.apellidoMonitorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.apellidoMonitorDataGridViewTextBoxColumn.HeaderText = "Apellido Monitor";
            this.apellidoMonitorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoMonitorDataGridViewTextBoxColumn.Name = "apellidoMonitorDataGridViewTextBoxColumn";
            // 
            // Usuarios_apuntados
            // 
            this.Usuarios_apuntados.DataPropertyName = "NombreActividad";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Usuarios_apuntados.DefaultCellStyle = dataGridViewCellStyle4;
            this.Usuarios_apuntados.HeaderText = "Usuarios apuntados";
            this.Usuarios_apuntados.Name = "Usuarios_apuntados";
            // 
            // Valoracion_media
            // 
            this.Valoracion_media.DataPropertyName = "NombreActividad";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.Valoracion_media.DefaultCellStyle = dataGridViewCellStyle5;
            this.Valoracion_media.HeaderText = "Valoración";
            this.Valoracion_media.Name = "Valoracion_media";
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.DefaultCellStyle = dataGridViewCellStyle6;
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.MinimumWidth = 6;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseColumnTextForButtonValue = true;
            this.btnEliminar.Width = 170;
            // 
            // ListadoActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.VistaActividades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoActividades";
            this.Text = "ListadoActividades";
            this.Load += new System.EventHandler(this.ListadoActividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VistaActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesMonitoresDTOBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.DataGridView VistaActividades;
        private RoundedButton btnExportar;
        private BindingSource actividadesMonitoresDTOBindingSource1;
        private DataGridViewTextBoxColumn nombreActividadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreMonitorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoMonitorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Usuarios_apuntados;
        private DataGridViewTextBoxColumn Valoracion_media;
        private DataGridViewButtonColumn btnEliminar;
    }
}