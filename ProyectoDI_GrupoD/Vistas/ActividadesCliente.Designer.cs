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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VistaActividadesClientes = new System.Windows.Forms.DataGridView();
            this.nombreActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMonitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMonitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadesClientesDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividadDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesMonitoresDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnApuntar = new ProyectoDI_GrupoD.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.VistaActividadesClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesMonitoresDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VistaActividadesClientes
            // 
            this.VistaActividadesClientes.AllowUserToAddRows = false;
            this.VistaActividadesClientes.AllowUserToDeleteRows = false;
            this.VistaActividadesClientes.AutoGenerateColumns = false;
            this.VistaActividadesClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VistaActividadesClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(108)))), ((int)(((byte)(124)))));
            this.VistaActividadesClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VistaActividadesClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreActividad,
            this.NombreMonitor,
            this.ApellidoMonitor,
            this.DescripActividad});
            this.VistaActividadesClientes.DataSource = this.actividadesClientesDTOBindingSource;
            this.VistaActividadesClientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.VistaActividadesClientes.Location = new System.Drawing.Point(0, 0);
            this.VistaActividadesClientes.Name = "VistaActividadesClientes";
            this.VistaActividadesClientes.ReadOnly = true;
            this.VistaActividadesClientes.RowHeadersWidth = 51;
            this.VistaActividadesClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VistaActividadesClientes.Size = new System.Drawing.Size(656, 450);
            this.VistaActividadesClientes.TabIndex = 0;
            this.VistaActividadesClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VistaActividadesClientes_CellClick);
            // 
            // nombreActividad
            // 
            this.nombreActividad.DataPropertyName = "NombreActividad";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.nombreActividad.DefaultCellStyle = dataGridViewCellStyle4;
            this.nombreActividad.HeaderText = "Nombre actividad";
            this.nombreActividad.MinimumWidth = 6;
            this.nombreActividad.Name = "nombreActividad";
            this.nombreActividad.ReadOnly = true;
            // 
            // NombreMonitor
            // 
            this.NombreMonitor.DataPropertyName = "NombreMonitor";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.NombreMonitor.DefaultCellStyle = dataGridViewCellStyle5;
            this.NombreMonitor.HeaderText = "Nombre monitor";
            this.NombreMonitor.MinimumWidth = 6;
            this.NombreMonitor.Name = "NombreMonitor";
            this.NombreMonitor.ReadOnly = true;
            // 
            // ApellidoMonitor
            // 
            this.ApellidoMonitor.DataPropertyName = "ApellidoMonitor";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.ApellidoMonitor.DefaultCellStyle = dataGridViewCellStyle6;
            this.ApellidoMonitor.HeaderText = "Apellido monitor";
            this.ApellidoMonitor.MinimumWidth = 6;
            this.ApellidoMonitor.Name = "ApellidoMonitor";
            this.ApellidoMonitor.ReadOnly = true;
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
            // actividadesClientesDTOBindingSource
            // 
            this.actividadesClientesDTOBindingSource.DataSource = typeof(Negocio.EntitiesDTO.ActividadesClientesDTO);
            // 
            // actividadDTOBindingSource
            // 
            this.actividadDTOBindingSource.DataSource = typeof(Negocio.EntitiesDTO.ActividadDTO);
            // 
            // actividadesMonitoresDTOBindingSource
            // 
            this.actividadesMonitoresDTOBindingSource.DataSource = typeof(Negocio.EntitiesDTO.ActividadesMonitoresDTO);
            // 
            // btnApuntar
            // 
            this.btnApuntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(110)))), ((int)(((byte)(84)))));
            this.btnApuntar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(110)))), ((int)(((byte)(84)))));
            this.btnApuntar.BorderRadius = 20;
            this.btnApuntar.FillColor = System.Drawing.Color.Transparent;
            this.btnApuntar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnApuntar.Image = global::ProyectoDI_GrupoD.Properties.Resources.agregar_usuario_1_;
            this.btnApuntar.Location = new System.Drawing.Point(694, 182);
            this.btnApuntar.Name = "btnApuntar";
            this.btnApuntar.Size = new System.Drawing.Size(77, 68);
            this.btnApuntar.TabIndex = 1;
            this.btnApuntar.UseVisualStyleBackColor = false;
            this.btnApuntar.Click += new System.EventHandler(this.btnApuntar_Click);
            // 
            // ActividadesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApuntar);
            this.Controls.Add(this.VistaActividadesClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActividadesCliente";
            this.Text = "ActividadesCliente";
            this.Load += new System.EventHandler(this.ActividadesCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VistaActividadesClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesMonitoresDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView VistaActividadesClientes;
        private System.Windows.Forms.BindingSource actividadesMonitoresDTOBindingSource;
        private System.Windows.Forms.BindingSource actividadDTOBindingSource;
        private RoundedButton btnApuntar;
        private System.Windows.Forms.BindingSource actividadesClientesDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMonitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMonitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripActividad;
    }
}