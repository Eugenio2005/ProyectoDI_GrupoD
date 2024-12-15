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
            this.ctxtmsCerrarSesion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblTextoSuperior = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.pnlActividadesDisponibles = new System.Windows.Forms.Panel();
            this.plMisActividades = new System.Windows.Forms.Panel();
            this.usuarioTimer = new System.Windows.Forms.Timer(this.components);
            this.imgAtras_Re = new System.Windows.Forms.PictureBox();
            this.CerrarSSesion = new ProyectoDI_GrupoD.ImageButton();
            this.EditarPerfil = new ProyectoDI_GrupoD.ImageButton();
            this.NombreUsuario = new ProyectoDI_GrupoD.ImageButton();
            this.ActividadDisponible = new ProyectoDI_GrupoD.ImageButton();
            this.MisActividades = new ProyectoDI_GrupoD.ImageButton();
            this.ctxtmsCerrarSesion.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.pnlActividadesDisponibles.SuspendLayout();
            this.plMisActividades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAtras_Re)).BeginInit();
            this.SuspendLayout();
            // 
            // ctxtmsCerrarSesion
            // 
            this.ctxtmsCerrarSesion.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ctxtmsCerrarSesion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem});
            this.ctxtmsCerrarSesion.Name = "ctxtmsCerrarSesion";
            this.ctxtmsCerrarSesion.Size = new System.Drawing.Size(166, 28);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.pnlSuperior.Controls.Add(this.imgAtras_Re);
            this.pnlSuperior.Controls.Add(this.lblTextoSuperior);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(401, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(882, 123);
            this.pnlSuperior.TabIndex = 2;
            // 
            // lblTextoSuperior
            // 
            this.lblTextoSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextoSuperior.AutoSize = true;
            this.lblTextoSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoSuperior.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTextoSuperior.Location = new System.Drawing.Point(533, 36);
            this.lblTextoSuperior.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextoSuperior.Name = "lblTextoSuperior";
            this.lblTextoSuperior.Size = new System.Drawing.Size(151, 54);
            this.lblTextoSuperior.TabIndex = 27;
            this.lblTextoSuperior.Text = "---  ---";
            this.lblTextoSuperior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(401, 123);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(882, 552);
            this.pnlPrincipal.TabIndex = 3;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            this.pnlBotones.Controls.Add(this.pnlUsuario);
            this.pnlBotones.Controls.Add(this.pnlActividadesDisponibles);
            this.pnlBotones.Controls.Add(this.plMisActividades);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(401, 675);
            this.pnlBotones.TabIndex = 1;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.CerrarSSesion);
            this.pnlUsuario.Controls.Add(this.EditarPerfil);
            this.pnlUsuario.Controls.Add(this.NombreUsuario);
            this.pnlUsuario.Location = new System.Drawing.Point(2, 2);
            this.pnlUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUsuario.MaximumSize = new System.Drawing.Size(400, 209);
            this.pnlUsuario.MinimumSize = new System.Drawing.Size(400, 73);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(400, 73);
            this.pnlUsuario.TabIndex = 0;
            // 
            // pnlActividadesDisponibles
            // 
            this.pnlActividadesDisponibles.Controls.Add(this.ActividadDisponible);
            this.pnlActividadesDisponibles.Location = new System.Drawing.Point(2, 79);
            this.pnlActividadesDisponibles.Margin = new System.Windows.Forms.Padding(2);
            this.pnlActividadesDisponibles.Name = "pnlActividadesDisponibles";
            this.pnlActividadesDisponibles.Size = new System.Drawing.Size(399, 76);
            this.pnlActividadesDisponibles.TabIndex = 1;
            // 
            // plMisActividades
            // 
            this.plMisActividades.Controls.Add(this.MisActividades);
            this.plMisActividades.Location = new System.Drawing.Point(2, 159);
            this.plMisActividades.Margin = new System.Windows.Forms.Padding(2);
            this.plMisActividades.Name = "plMisActividades";
            this.plMisActividades.Size = new System.Drawing.Size(399, 76);
            this.plMisActividades.TabIndex = 1;
            // 
            // usuarioTimer
            // 
            this.usuarioTimer.Interval = 10;
            this.usuarioTimer.Tick += new System.EventHandler(this.usuarioTimer_Tick);
            // 
            // imgAtras_Re
            // 
            this.imgAtras_Re.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAtras_Re.ErrorImage = global::ProyectoDI_GrupoD.Properties.Resources.atrasSinFondo;
            this.imgAtras_Re.ImageLocation = "0;0";
            this.imgAtras_Re.InitialImage = null;
            this.imgAtras_Re.Location = new System.Drawing.Point(28, 19);
            this.imgAtras_Re.Margin = new System.Windows.Forms.Padding(0);
            this.imgAtras_Re.Name = "imgAtras_Re";
            this.imgAtras_Re.Size = new System.Drawing.Size(93, 69);
            this.imgAtras_Re.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgAtras_Re.TabIndex = 28;
            this.imgAtras_Re.TabStop = false;
            this.imgAtras_Re.Click += new System.EventHandler(this.imgAtras_Re_Click);
            // 
            // CerrarSSesion
            // 
            this.CerrarSSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(71)))), ((int)(((byte)(24)))));
            this.CerrarSSesion.ButtonImage = global::ProyectoDI_GrupoD.Properties.Resources.cerrar_sesion1;
            this.CerrarSSesion.ButtonText = "CERRAR SESION";
            this.CerrarSSesion.ContextMenuStrip = this.ctxtmsCerrarSesion;
            this.CerrarSSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarSSesion.HoverBackColor = System.Drawing.Color.LightGray;
            this.CerrarSSesion.Location = new System.Drawing.Point(0, 143);
            this.CerrarSSesion.Margin = new System.Windows.Forms.Padding(8);
            this.CerrarSSesion.Name = "CerrarSSesion";
            this.CerrarSSesion.Size = new System.Drawing.Size(400, 61);
            this.CerrarSSesion.TabIndex = 2;
            this.CerrarSSesion.Click += new System.EventHandler(this.CerrarSSesion_Click);
            // 
            // EditarPerfil
            // 
            this.EditarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(71)))), ((int)(((byte)(24)))));
            this.EditarPerfil.ButtonImage = global::ProyectoDI_GrupoD.Properties.Resources.editar1;
            this.EditarPerfil.ButtonText = "EDITAR PERFIL";
            this.EditarPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditarPerfil.HoverBackColor = System.Drawing.Color.LightGray;
            this.EditarPerfil.Location = new System.Drawing.Point(-1, 74);
            this.EditarPerfil.Margin = new System.Windows.Forms.Padding(8);
            this.EditarPerfil.Name = "EditarPerfil";
            this.EditarPerfil.Size = new System.Drawing.Size(400, 61);
            this.EditarPerfil.TabIndex = 1;
            this.EditarPerfil.Click += new System.EventHandler(this.EditarPerfil_Click);
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(71)))), ((int)(((byte)(24)))));
            this.NombreUsuario.ButtonImage = global::ProyectoDI_GrupoD.Properties.Resources.usuario;
            this.NombreUsuario.ButtonText = "NOMBRE";
            this.NombreUsuario.ContextMenuStrip = this.ctxtmsCerrarSesion;
            this.NombreUsuario.Cursor = System.Windows.Forms.Cursors.Cross;
            this.NombreUsuario.HoverBackColor = System.Drawing.Color.LightGray;
            this.NombreUsuario.Location = new System.Drawing.Point(-1, 6);
            this.NombreUsuario.Margin = new System.Windows.Forms.Padding(8);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(400, 61);
            this.NombreUsuario.TabIndex = 0;
            this.NombreUsuario.Click += new System.EventHandler(this.NombreUsuario_Click);
            // 
            // ActividadDisponible
            // 
            this.ActividadDisponible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(71)))), ((int)(((byte)(24)))));
            this.ActividadDisponible.ButtonImage = global::ProyectoDI_GrupoD.Properties.Resources.AltaUnaActividadBlanco;
            this.ActividadDisponible.ButtonText = "ACTIVIDADES DISPONIBLES";
            this.ActividadDisponible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActividadDisponible.HoverBackColor = System.Drawing.Color.LightGray;
            this.ActividadDisponible.Location = new System.Drawing.Point(-1, 8);
            this.ActividadDisponible.Margin = new System.Windows.Forms.Padding(8);
            this.ActividadDisponible.Name = "ActividadDisponible";
            this.ActividadDisponible.Size = new System.Drawing.Size(400, 61);
            this.ActividadDisponible.TabIndex = 1;
            this.ActividadDisponible.Click += new System.EventHandler(this.ActividadDisponible_Click);
            // 
            // MisActividades
            // 
            this.MisActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(71)))), ((int)(((byte)(24)))));
            this.MisActividades.ButtonImage = global::ProyectoDI_GrupoD.Properties.Resources.ListarActividadesBlanco;
            this.MisActividades.ButtonText = "MIS ACTIVIDADES";
            this.MisActividades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MisActividades.HoverBackColor = System.Drawing.Color.LightGray;
            this.MisActividades.Location = new System.Drawing.Point(0, 8);
            this.MisActividades.Margin = new System.Windows.Forms.Padding(8);
            this.MisActividades.Name = "MisActividades";
            this.MisActividades.Size = new System.Drawing.Size(400, 61);
            this.MisActividades.TabIndex = 2;
            this.MisActividades.Click += new System.EventHandler(this.MisActividades_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pnlBotones);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PantallaPrincipal";
            this.Text = "K A E GYM ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PantallaPrincipal_FormClosing);
            this.ctxtmsCerrarSesion.ResumeLayout(false);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlActividadesDisponibles.ResumeLayout(false);
            this.plMisActividades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAtras_Re)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.PictureBox imgAtras_Re;
        private System.Windows.Forms.Label lblTextoSuperior;
        private ImageButton MisActividades;
        private ImageButton ActividadDisponible;
        private ImageButton NombreUsuario;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.ContextMenuStrip ctxtmsCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel pnlBotones;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Panel pnlActividadesDisponibles;
        private System.Windows.Forms.Panel plMisActividades;
        private System.Windows.Forms.Timer usuarioTimer;
        private ImageButton CerrarSSesion;
        private ImageButton EditarPerfil;
    }
}