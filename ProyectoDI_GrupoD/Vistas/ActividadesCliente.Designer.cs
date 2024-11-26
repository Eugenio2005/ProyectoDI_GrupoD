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
            this.VistaActividadesClientes = new System.Windows.Forms.DataGridView();
            this.actividadDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesMonitoresDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesClientesDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDesapuntar = new ProyectoDI_GrupoD.RoundedButton();
            this.btnApuntar = new ProyectoDI_GrupoD.RoundedButton();
            this.nombreActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMonitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.VistaActividadesClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesMonitoresDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource)).BeginInit();
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
            this.DescripActividad,
            this.NombreMonitor});
            this.VistaActividadesClientes.DataSource = this.actividadesClientesDTOBindingSource;
            this.VistaActividadesClientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.VistaActividadesClientes.Location = new System.Drawing.Point(0, 0);
            this.VistaActividadesClientes.Name = "VistaActividadesClientes";
            this.VistaActividadesClientes.ReadOnly = true;
            this.VistaActividadesClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VistaActividadesClientes.Size = new System.Drawing.Size(656, 450);
            this.VistaActividadesClientes.TabIndex = 0;
            this.VistaActividadesClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VistaActividadesClientes_CellClick);
            // 
            // actividadDTOBindingSource
            // 
            this.actividadDTOBindingSource.DataSource = typeof(Negocio.EntitiesDTO.ActividadDTO);
            // 
            // actividadesMonitoresDTOBindingSource
            // 
            this.actividadesMonitoresDTOBindingSource.DataSource = typeof(Negocio.EntitiesDTO.ActividadesMonitoresDTO);
            // 
            // actividadesClientesDTOBindingSource
            // 
            this.actividadesClientesDTOBindingSource.DataSource = typeof(Negocio.EntitiesDTO.ActividadesClientesDTO);
            // 
            // btnDesapuntar
            // 
            this.btnDesapuntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(110)))), ((int)(((byte)(84)))));
            this.btnDesapuntar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(110)))), ((int)(((byte)(84)))));
            this.btnDesapuntar.BorderRadius = 20;
            this.btnDesapuntar.FillColor = System.Drawing.Color.Transparent;
            this.btnDesapuntar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDesapuntar.Image = global::ProyectoDI_GrupoD.Properties.Resources.borrar_usuario_1_;
            this.btnDesapuntar.Location = new System.Drawing.Point(690, 291);
            this.btnDesapuntar.Name = "btnDesapuntar";
            this.btnDesapuntar.Size = new System.Drawing.Size(77, 68);
            this.btnDesapuntar.TabIndex = 2;
            this.btnDesapuntar.UseVisualStyleBackColor = false;
            // 
            // btnApuntar
            // 
            this.btnApuntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(110)))), ((int)(((byte)(84)))));
            this.btnApuntar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(110)))), ((int)(((byte)(84)))));
            this.btnApuntar.BorderRadius = 20;
            this.btnApuntar.FillColor = System.Drawing.Color.Transparent;
            this.btnApuntar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnApuntar.Image = global::ProyectoDI_GrupoD.Properties.Resources.agregar_usuario_1_;
            this.btnApuntar.Location = new System.Drawing.Point(690, 92);
            this.btnApuntar.Name = "btnApuntar";
            this.btnApuntar.Size = new System.Drawing.Size(77, 68);
            this.btnApuntar.TabIndex = 1;
            this.btnApuntar.UseVisualStyleBackColor = false;
            this.btnApuntar.Click += new System.EventHandler(this.btnApuntar_Click);
            // 
            // nombreActividad
            // 
            this.nombreActividad.DataPropertyName = "NombreActividad";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            this.nombreActividad.DefaultCellStyle = dataGridViewCellStyle1;
            this.nombreActividad.HeaderText = "Nombre actividad";
            this.nombreActividad.Name = "nombreActividad";
            this.nombreActividad.ReadOnly = true;
            // 
            // DescripActividad
            // 
            this.DescripActividad.DataPropertyName = "DescripActividad";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            this.DescripActividad.DefaultCellStyle = dataGridViewCellStyle2;
            this.DescripActividad.HeaderText = "Descripción actividad";
            this.DescripActividad.Name = "DescripActividad";
            this.DescripActividad.ReadOnly = true;
            // 
            // NombreMonitor
            // 
            this.NombreMonitor.DataPropertyName = "NombreMonitor";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            this.NombreMonitor.DefaultCellStyle = dataGridViewCellStyle3;
            this.NombreMonitor.HeaderText = "NombreMonitor";
            this.NombreMonitor.Name = "NombreMonitor";
            this.NombreMonitor.ReadOnly = true;
            // 
            // ActividadesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDesapuntar);
            this.Controls.Add(this.btnApuntar);
            this.Controls.Add(this.VistaActividadesClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActividadesCliente";
            this.Text = "ActividadesCliente";
            this.Load += new System.EventHandler(this.ActividadesCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VistaActividadesClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesMonitoresDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesClientesDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView VistaActividadesClientes;
        private System.Windows.Forms.BindingSource actividadesMonitoresDTOBindingSource;
        private System.Windows.Forms.BindingSource actividadDTOBindingSource;
        private RoundedButton btnApuntar;
        private RoundedButton btnDesapuntar;
        private System.Windows.Forms.BindingSource actividadesClientesDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMonitor;
    }
}