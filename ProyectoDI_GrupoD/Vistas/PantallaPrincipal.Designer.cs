namespace ProyectoDI_GrupoD.Vistas
{
    partial class PantallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.MisActividades = new ProyectoDI_GrupoD.ImageButton();
            this.ActividadDisponible = new ProyectoDI_GrupoD.ImageButton();
            this.NombreUsuario = new ProyectoDI_GrupoD.ImageButton();
            this.ctxtmsCerrarSesion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.imgAtras_Re = new System.Windows.Forms.PictureBox();
            this.lblTextoSuperior = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.editarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBotones.SuspendLayout();
            this.ctxtmsCerrarSesion.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAtras_Re)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            this.pnlBotones.Controls.Add(this.MisActividades);
            this.pnlBotones.Controls.Add(this.ActividadDisponible);
            this.pnlBotones.Controls.Add(this.NombreUsuario);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(301, 594);
            this.pnlBotones.TabIndex = 1;
            // 
            // MisActividades
            // 
            this.MisActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(71)))), ((int)(((byte)(24)))));
            this.MisActividades.ButtonImage = global::ProyectoDI_GrupoD.Properties.Resources.ListarActividadesBlanco;
            this.MisActividades.ButtonText = "MIS ACTIVIDADES";
            this.MisActividades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MisActividades.HoverBackColor = System.Drawing.Color.LightGray;
            this.MisActividades.Location = new System.Drawing.Point(0, 144);
            this.MisActividades.Name = "MisActividades";
            this.MisActividades.Size = new System.Drawing.Size(300, 50);
            this.MisActividades.TabIndex = 2;
            this.MisActividades.Click += new System.EventHandler(this.MisActividades_Click);
            // 
            // ActividadDisponible
            // 
            this.ActividadDisponible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(71)))), ((int)(((byte)(24)))));
            this.ActividadDisponible.ButtonImage = global::ProyectoDI_GrupoD.Properties.Resources.AltaUnaActividadBlanco;
            this.ActividadDisponible.ButtonText = "ACTIVIDADES DISPONIBLES";
            this.ActividadDisponible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActividadDisponible.HoverBackColor = System.Drawing.Color.LightGray;
            this.ActividadDisponible.Location = new System.Drawing.Point(0, 78);
            this.ActividadDisponible.Name = "ActividadDisponible";
            this.ActividadDisponible.Size = new System.Drawing.Size(300, 50);
            this.ActividadDisponible.TabIndex = 1;
            this.ActividadDisponible.Click += new System.EventHandler(this.ActividadDisponible_Click);
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(71)))), ((int)(((byte)(24)))));
            this.NombreUsuario.ButtonImage = global::ProyectoDI_GrupoD.Properties.Resources.usuario;
            this.NombreUsuario.ButtonText = "NOMBRE";
            this.NombreUsuario.ContextMenuStrip = this.ctxtmsCerrarSesion;
            this.NombreUsuario.Cursor = System.Windows.Forms.Cursors.Help;
            this.NombreUsuario.HoverBackColor = System.Drawing.Color.LightGray;
            this.NombreUsuario.Location = new System.Drawing.Point(0, 12);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(300, 50);
            this.NombreUsuario.TabIndex = 0;
            // 
            // ctxtmsCerrarSesion
            // 
            this.ctxtmsCerrarSesion.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ctxtmsCerrarSesion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.editarPerfilToolStripMenuItem});
            this.ctxtmsCerrarSesion.Name = "ctxtmsCerrarSesion";
            this.ctxtmsCerrarSesion.Size = new System.Drawing.Size(144, 48);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.pnlSuperior.Controls.Add(this.imgAtras_Re);
            this.pnlSuperior.Controls.Add(this.lblTextoSuperior);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(301, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(970, 100);
            this.pnlSuperior.TabIndex = 2;
            // 
            // imgAtras_Re
            // 
            this.imgAtras_Re.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAtras_Re.ErrorImage = global::ProyectoDI_GrupoD.Properties.Resources.atrasSinFondo;
            this.imgAtras_Re.ImageLocation = "0;0";
            this.imgAtras_Re.InitialImage = null;
            this.imgAtras_Re.Location = new System.Drawing.Point(21, 15);
            this.imgAtras_Re.Margin = new System.Windows.Forms.Padding(0);
            this.imgAtras_Re.Name = "imgAtras_Re";
            this.imgAtras_Re.Size = new System.Drawing.Size(70, 56);
            this.imgAtras_Re.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgAtras_Re.TabIndex = 28;
            this.imgAtras_Re.TabStop = false;
            this.imgAtras_Re.Click += new System.EventHandler(this.imgAtras_Re_Click);
            // 
            // lblTextoSuperior
            // 
            this.lblTextoSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextoSuperior.AutoSize = true;
            this.lblTextoSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoSuperior.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTextoSuperior.Location = new System.Drawing.Point(400, 29);
            this.lblTextoSuperior.Name = "lblTextoSuperior";
            this.lblTextoSuperior.Size = new System.Drawing.Size(118, 42);
            this.lblTextoSuperior.TabIndex = 27;
            this.lblTextoSuperior.Text = "---  ---";
            this.lblTextoSuperior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(301, 100);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(970, 494);
            this.pnlPrincipal.TabIndex = 3;
            // 
            // editarPerfilToolStripMenuItem
            // 
            this.editarPerfilToolStripMenuItem.Name = "editarPerfilToolStripMenuItem";
            this.editarPerfilToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.editarPerfilToolStripMenuItem.Text = "Editar perfil";
            this.editarPerfilToolStripMenuItem.Click += new System.EventHandler(this.editarPerfilToolStripMenuItem_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1271, 594);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pnlBotones);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaPrincipal";
            this.Text = "K A E GYM ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PantallaPrincipal_FormClosing);
            this.pnlBotones.ResumeLayout(false);
            this.ctxtmsCerrarSesion.ResumeLayout(false);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAtras_Re)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.PictureBox imgAtras_Re;
        private System.Windows.Forms.Label lblTextoSuperior;
        private ImageButton MisActividades;
        private ImageButton ActividadDisponible;
        private ImageButton NombreUsuario;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.ContextMenuStrip ctxtmsCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPerfilToolStripMenuItem;
    }
}