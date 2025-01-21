namespace ProyectoDI_GrupoD.Vistas
{
    partial class ActividadesCliente
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
            this.VistaActividadesClientes = new System.Windows.Forms.DataGridView();
            this.nombreActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMonitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMonitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valoracion_media = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesClientesDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesMonitoresDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VistaActividadesClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesMonitoresDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VistaActividadesClientes
            // 
            this.VistaActividadesClientes.AllowUserToAddRows = false;
            this.VistaActividadesClientes.AllowUserToDeleteRows = false;
            this.VistaActividadesClientes.AutoGenerateColumns = false;
            this.VistaActividadesClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VistaActividadesClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.VistaActividadesClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VistaActividadesClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreActividad,
            this.DescripActividad,
            this.NombreMonitor,
            this.ApellidoMonitor,
            this.Valoracion_media});
            this.VistaActividadesClientes.DataSource = this.actividadDTOBindingSource;
            this.VistaActividadesClientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.VistaActividadesClientes.Location = new System.Drawing.Point(0, 0);
            this.VistaActividadesClientes.Name = "VistaActividadesClientes";
            this.VistaActividadesClientes.ReadOnly = true;
            this.VistaActividadesClientes.RowHeadersWidth = 51;
            this.VistaActividadesClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VistaActividadesClientes.Size = new System.Drawing.Size(758, 450);
            this.VistaActividadesClientes.TabIndex = 0;
            this.VistaActividadesClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VistaActividadesClientes_CellDoubleClick);
            // 
            // nombreActividad
            // 
            this.nombreActividad.DataPropertyName = "NombreActividad";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.nombreActividad.DefaultCellStyle = dataGridViewCellStyle1;
            this.nombreActividad.HeaderText = "Nombre actividad";
            this.nombreActividad.MinimumWidth = 6;
            this.nombreActividad.Name = "nombreActividad";
            this.nombreActividad.ReadOnly = true;
            // 
            // DescripActividad
            // 
            this.DescripActividad.DataPropertyName = "DescripActividad";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.DescripActividad.DefaultCellStyle = dataGridViewCellStyle2;
            this.DescripActividad.HeaderText = "Descripción Actividad";
            this.DescripActividad.Name = "DescripActividad";
            this.DescripActividad.ReadOnly = true;
            // 
            // NombreMonitor
            // 
            this.NombreMonitor.DataPropertyName = "NombreMonitor";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.NombreMonitor.DefaultCellStyle = dataGridViewCellStyle3;
            this.NombreMonitor.HeaderText = "Nombre monitor";
            this.NombreMonitor.MinimumWidth = 6;
            this.NombreMonitor.Name = "NombreMonitor";
            this.NombreMonitor.ReadOnly = true;
            // 
            // ApellidoMonitor
            // 
            this.ApellidoMonitor.DataPropertyName = "ApellidoMonitor";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.ApellidoMonitor.DefaultCellStyle = dataGridViewCellStyle4;
            this.ApellidoMonitor.HeaderText = "Apellido monitor";
            this.ApellidoMonitor.MinimumWidth = 6;
            this.ApellidoMonitor.Name = "ApellidoMonitor";
            this.ApellidoMonitor.ReadOnly = true;
            // 
            // Valoracion_media
            // 
            this.Valoracion_media.DataPropertyName = "Valoracion_media";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.Valoracion_media.DefaultCellStyle = dataGridViewCellStyle5;
            this.Valoracion_media.HeaderText = "Valoracion media";
            this.Valoracion_media.MinimumWidth = 6;
            this.Valoracion_media.Name = "Valoracion_media";
            this.Valoracion_media.ReadOnly = true;
            // 
            // actividadDTOBindingSource
            // 
            this.actividadDTOBindingSource.DataSource = typeof(Negocio.EntitiesDTO.ActividadDTO);
            // 
            // actividadesClientesDTOBindingSource
            // 
            this.actividadesClientesDTOBindingSource.DataSource = typeof(Negocio.EntitiesDTO.ActividadesClientesDTO);
            // 
            // actividadesMonitoresDTOBindingSource
            // 
            this.actividadesMonitoresDTOBindingSource.DataSource = typeof(Negocio.EntitiesDTO.ActividadesMonitoresDTO);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(779, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Puedes apuntarte a \r\nla actividad \r\npulsando doble clic\r\n";
            // 
            // ActividadesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1044, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VistaActividadesClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActividadesCliente";
            this.Text = "ActividadesCliente";
            this.Load += new System.EventHandler(this.ActividadesCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VistaActividadesClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesMonitoresDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VistaActividadesClientes;
        private System.Windows.Forms.BindingSource actividadesMonitoresDTOBindingSource;
        private System.Windows.Forms.BindingSource actividadDTOBindingSource;
        private System.Windows.Forms.BindingSource actividadesClientesDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMonitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMonitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valoracion_media;
        private System.Windows.Forms.Label label1;
    }
}