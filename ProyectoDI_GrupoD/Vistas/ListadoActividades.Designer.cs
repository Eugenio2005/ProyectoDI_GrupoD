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
            this.VistaActividades = new System.Windows.Forms.DataGridView();
            this.equipodDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesMonitoresDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nombreActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMonitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMonitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.VistaActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipodDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesMonitoresDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VistaActividades
            // 
            this.VistaActividades.AllowUserToOrderColumns = true;
            this.VistaActividades.AutoGenerateColumns = false;
            this.VistaActividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VistaActividades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(108)))), ((int)(((byte)(124)))));
            this.VistaActividades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VistaActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VistaActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEliminar,
            this.nombreActividadDataGridViewTextBoxColumn,
            this.nombreMonitorDataGridViewTextBoxColumn,
            this.apellidoMonitorDataGridViewTextBoxColumn});
            this.VistaActividades.DataSource = this.actividadesMonitoresDTOBindingSource;
            this.VistaActividades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VistaActividades.Location = new System.Drawing.Point(0, 0);
            this.VistaActividades.Name = "VistaActividades";
            this.VistaActividades.RowHeadersWidth = 51;
            this.VistaActividades.Size = new System.Drawing.Size(800, 450);
            this.VistaActividades.TabIndex = 0;
            this.VistaActividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vistaActividades_ClicContenidoEliminarActividad);
            // 
            // actividadesMonitoresDTOBindingSource
            // 
            this.actividadesMonitoresDTOBindingSource.DataSource = typeof(Negocio.EntitiesDTO.ActividadesMonitoresDTO);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.DefaultCellStyle = dataGridViewCellStyle1;
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.MinimumWidth = 6;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseColumnTextForButtonValue = true;
            this.btnEliminar.Width = 170;
            // 
            // nombreActividadDataGridViewTextBoxColumn
            // 
            this.nombreActividadDataGridViewTextBoxColumn.DataPropertyName = "NombreActividad";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.nombreActividadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nombreActividadDataGridViewTextBoxColumn.HeaderText = "Nombre Actividad";
            this.nombreActividadDataGridViewTextBoxColumn.Name = "nombreActividadDataGridViewTextBoxColumn";
            // 
            // nombreMonitorDataGridViewTextBoxColumn
            // 
            this.nombreMonitorDataGridViewTextBoxColumn.DataPropertyName = "NombreMonitor";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.nombreMonitorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.nombreMonitorDataGridViewTextBoxColumn.HeaderText = "Nombre Monitor";
            this.nombreMonitorDataGridViewTextBoxColumn.Name = "nombreMonitorDataGridViewTextBoxColumn";
            // 
            // apellidoMonitorDataGridViewTextBoxColumn
            // 
            this.apellidoMonitorDataGridViewTextBoxColumn.DataPropertyName = "ApellidoMonitor";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.apellidoMonitorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.apellidoMonitorDataGridViewTextBoxColumn.HeaderText = "Apellido Monitor";
            this.apellidoMonitorDataGridViewTextBoxColumn.Name = "apellidoMonitorDataGridViewTextBoxColumn";
            // 
            // ListadoActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VistaActividades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoActividades";
            this.Text = "ListadoActividades";
            this.Load += new System.EventHandler(this.ListadoActividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VistaActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipodDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesMonitoresDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.DataGridView VistaActividades;
        private BindingSource equipodDataSetBindingSource;
        private BindingSource actividadesMonitoresDTOBindingSource;
        private DataGridViewButtonColumn btnEliminar;
        private DataGridViewTextBoxColumn nombreActividadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreMonitorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoMonitorDataGridViewTextBoxColumn;
    }
}