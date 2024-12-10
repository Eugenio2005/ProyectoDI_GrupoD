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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VistaActividades = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nombreActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMonitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMonitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadesMonitoresDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipodDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.VistaActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesMonitoresDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipodDataSetBindingSource)).BeginInit();
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
            this.nombreActividadDataGridViewTextBoxColumn,
            this.nombreMonitorDataGridViewTextBoxColumn,
            this.apellidoMonitorDataGridViewTextBoxColumn,
            this.btnEliminar});
            this.VistaActividades.DataSource = this.actividadesMonitoresDTOBindingSource;
            this.VistaActividades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VistaActividades.Location = new System.Drawing.Point(0, 0);
            this.VistaActividades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VistaActividades.Name = "VistaActividades";
            this.VistaActividades.RowHeadersWidth = 51;
            this.VistaActividades.Size = new System.Drawing.Size(1067, 554);
            this.VistaActividades.TabIndex = 0;
            this.VistaActividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vistaActividades_ClicContenidoEliminarActividad);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.DefaultCellStyle = dataGridViewCellStyle4;
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.MinimumWidth = 6;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseColumnTextForButtonValue = true;
            this.btnEliminar.Width = 170;
            // 
            // nombreActividadDataGridViewTextBoxColumn
            // 
<<<<<<< HEAD
            this.nombreActividadDataGridViewTextBoxColumn.DataPropertyName = "NombreActividad";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.nombreActividadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.nombreActividadDataGridViewTextBoxColumn.HeaderText = "Nombre Actividad";
            this.nombreActividadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreActividadDataGridViewTextBoxColumn.Name = "nombreActividadDataGridViewTextBoxColumn";
=======
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(108)))), ((int)(((byte)(124)))));
            this.btnConsultar.Location = new System.Drawing.Point(37, 131);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(108, 41);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
>>>>>>> a7148f3358cc5e10aed54eebf13a3803ce1a5b00
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
            // actividadesMonitoresDTOBindingSource
            // 
            this.actividadesMonitoresDTOBindingSource.DataSource = typeof(Negocio.EntitiesDTO.ActividadesMonitoresDTO);
            // 
            // ListadoActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.VistaActividades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListadoActividades";
            this.Text = "ListadoActividades";
            this.Load += new System.EventHandler(this.ListadoActividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VistaActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesMonitoresDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipodDataSetBindingSource)).EndInit();
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