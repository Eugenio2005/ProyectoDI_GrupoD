using System.Windows.Forms;

namespace ProyectoDI_GrupoD
{
    partial class InicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox imgKAE_InSe;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            System.Windows.Forms.PictureBox imgMinimizar;
            System.Windows.Forms.PictureBox imgCerrar;
            this.lblUsuarioInSe = new System.Windows.Forms.Label();
            this.lblContraseñaInSe = new System.Windows.Forms.Label();
            this.btnojoCerradoInSe = new System.Windows.Forms.Button();
            this.btnojo_abiertoInSe = new System.Windows.Forms.Button();
            this.btnIniciarSesionInSe = new ProyectoDI_GrupoD.RoundedButton();
            this.imgAtras_Re = new System.Windows.Forms.PictureBox();
            this.txtUsuarioInSe = new ProyectoDI_GrupoD.TextBoxRedondeado();
            this.txtContraseñaInSe = new ProyectoDI_GrupoD.TextBoxRedondeado();
            imgKAE_InSe = new System.Windows.Forms.PictureBox();
            imgMinimizar = new System.Windows.Forms.PictureBox();
            imgCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(imgKAE_InSe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAtras_Re)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(imgMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(imgCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // imgKAE_InSe
            // 
            imgKAE_InSe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            imgKAE_InSe.Image = global::ProyectoDI_GrupoD.Properties.Resources.KAE_GYM_novo_re;
            imgKAE_InSe.Location = new System.Drawing.Point(54, 24);
            imgKAE_InSe.Name = "imgKAE_InSe";
            imgKAE_InSe.Size = new System.Drawing.Size(279, 195);
            imgKAE_InSe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            imgKAE_InSe.TabIndex = 0;
            imgKAE_InSe.TabStop = false;
            // 
            // lblUsuarioInSe
            // 
            this.lblUsuarioInSe.AutoSize = true;
            this.lblUsuarioInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.lblUsuarioInSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioInSe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.lblUsuarioInSe.Location = new System.Drawing.Point(50, 211);
            this.lblUsuarioInSe.Name = "lblUsuarioInSe";
            this.lblUsuarioInSe.Size = new System.Drawing.Size(166, 24);
            this.lblUsuarioInSe.TabIndex = 3;
            this.lblUsuarioInSe.Text = "Correo electrónico";
            // 
            // lblContraseñaInSe
            // 
            this.lblContraseñaInSe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContraseñaInSe.AutoSize = true;
            this.lblContraseñaInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.lblContraseñaInSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaInSe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.lblContraseñaInSe.Location = new System.Drawing.Point(50, 278);
            this.lblContraseñaInSe.Name = "lblContraseñaInSe";
            this.lblContraseñaInSe.Size = new System.Drawing.Size(106, 24);
            this.lblContraseñaInSe.TabIndex = 6;
            this.lblContraseñaInSe.Text = "Contraseña";
            // 
            // btnojoCerradoInSe
            // 
            this.btnojoCerradoInSe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnojoCerradoInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.btnojoCerradoInSe.FlatAppearance.BorderSize = 0;
            this.btnojoCerradoInSe.ForeColor = System.Drawing.Color.Transparent;
            this.btnojoCerradoInSe.Image = ((System.Drawing.Image)(resources.GetObject("btnojoCerradoInSe.Image")));
            this.btnojoCerradoInSe.Location = new System.Drawing.Point(337, 307);
            this.btnojoCerradoInSe.Name = "btnojoCerradoInSe";
            this.btnojoCerradoInSe.Size = new System.Drawing.Size(30, 30);
            this.btnojoCerradoInSe.TabIndex = 29;
            this.btnojoCerradoInSe.UseVisualStyleBackColor = false;
            this.btnojoCerradoInSe.Visible = false;
            this.btnojoCerradoInSe.Click += new System.EventHandler(this.btnojoCerradoInSe_Click);
            // 
            // btnojo_abiertoInSe
            // 
            this.btnojo_abiertoInSe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnojo_abiertoInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.btnojo_abiertoInSe.FlatAppearance.BorderSize = 0;
            this.btnojo_abiertoInSe.ForeColor = System.Drawing.Color.Transparent;
            this.btnojo_abiertoInSe.Image = ((System.Drawing.Image)(resources.GetObject("btnojo_abiertoInSe.Image")));
            this.btnojo_abiertoInSe.Location = new System.Drawing.Point(337, 307);
            this.btnojo_abiertoInSe.Name = "btnojo_abiertoInSe";
            this.btnojo_abiertoInSe.Size = new System.Drawing.Size(30, 30);
            this.btnojo_abiertoInSe.TabIndex = 28;
            this.btnojo_abiertoInSe.UseVisualStyleBackColor = false;
            this.btnojo_abiertoInSe.Click += new System.EventHandler(this.btnojoAbiertoInSe_Click);
            // 
            // btnIniciarSesionInSe
            // 
            this.btnIniciarSesionInSe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciarSesionInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.btnIniciarSesionInSe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.btnIniciarSesionInSe.BorderRadius = 20;
            this.btnIniciarSesionInSe.FillColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesionInSe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(206)))), ((int)(((byte)(164)))));
            this.btnIniciarSesionInSe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(206)))), ((int)(((byte)(164)))));
            this.btnIniciarSesionInSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesionInSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesionInSe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIniciarSesionInSe.Location = new System.Drawing.Point(140, 357);
            this.btnIniciarSesionInSe.Name = "btnIniciarSesionInSe";
            this.btnIniciarSesionInSe.Size = new System.Drawing.Size(128, 44);
            this.btnIniciarSesionInSe.TabIndex = 4;
            this.btnIniciarSesionInSe.Text = "Iniciar sesión";
            this.btnIniciarSesionInSe.UseVisualStyleBackColor = false;
            this.btnIniciarSesionInSe.Click += new System.EventHandler(this.btnIniciarSesionInSe_Click);
            this.btnIniciarSesionInSe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnIniciarSesionInSe_KeyDown);
            // 
            // imgAtras_Re
            // 
            this.imgAtras_Re.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAtras_Re.ErrorImage = global::ProyectoDI_GrupoD.Properties.Resources.atrasSinFondo;
            this.imgAtras_Re.ImageLocation = "0;0";
            this.imgAtras_Re.InitialImage = null;
            this.imgAtras_Re.Location = new System.Drawing.Point(1, 1);
            this.imgAtras_Re.Margin = new System.Windows.Forms.Padding(0);
            this.imgAtras_Re.Name = "imgAtras_Re";
            this.imgAtras_Re.Size = new System.Drawing.Size(70, 56);
            this.imgAtras_Re.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgAtras_Re.TabIndex = 31;
            this.imgAtras_Re.TabStop = false;
            this.imgAtras_Re.Click += new System.EventHandler(this.imgAtras_Re_Click_1);
            // 
            // txtUsuarioInSe
            // 
            this.txtUsuarioInSe.BackColor = System.Drawing.Color.White;
            this.txtUsuarioInSe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.txtUsuarioInSe.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtUsuarioInSe.BorderRadius = 15;
            this.txtUsuarioInSe.BorderSize = 2;
            this.txtUsuarioInSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioInSe.ForeColor = System.Drawing.Color.Black;
            this.txtUsuarioInSe.Location = new System.Drawing.Point(54, 242);
            this.txtUsuarioInSe.Name = "txtUsuarioInSe";
            this.txtUsuarioInSe.Padding = new System.Windows.Forms.Padding(10);
            this.txtUsuarioInSe.Size = new System.Drawing.Size(279, 33);
            this.txtUsuarioInSe.TabIndex = 32;
            this.txtUsuarioInSe.UseSystemPasswordChar = false;
            // 
            // txtContraseñaInSe
            // 
            this.txtContraseñaInSe.BackColor = System.Drawing.Color.White;
            this.txtContraseñaInSe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.txtContraseñaInSe.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtContraseñaInSe.BorderRadius = 15;
            this.txtContraseñaInSe.BorderSize = 2;
            this.txtContraseñaInSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaInSe.Location = new System.Drawing.Point(54, 304);
            this.txtContraseñaInSe.Name = "txtContraseñaInSe";
            this.txtContraseñaInSe.Padding = new System.Windows.Forms.Padding(10);
            this.txtContraseñaInSe.Size = new System.Drawing.Size(279, 33);
            this.txtContraseñaInSe.TabIndex = 33;
            this.txtContraseñaInSe.UseSystemPasswordChar = false;
            // 
            // imgMinimizar
            // 
            imgMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            imgMinimizar.ErrorImage = global::ProyectoDI_GrupoD.Properties.Resources.KAEGYM1;
            imgMinimizar.Image = global::ProyectoDI_GrupoD.Properties.Resources.Minimizar;
            imgMinimizar.Location = new System.Drawing.Point(315, 12);
            imgMinimizar.Name = "imgMinimizar";
            imgMinimizar.Size = new System.Drawing.Size(27, 26);
            imgMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imgMinimizar.TabIndex = 35;
            imgMinimizar.TabStop = false;
            imgMinimizar.Click += new System.EventHandler(this.imgMinimizar_Click_1);
            // 
            // imgCerrar
            // 
            imgCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            imgCerrar.ErrorImage = global::ProyectoDI_GrupoD.Properties.Resources.KAEGYM1;
            imgCerrar.Image = global::ProyectoDI_GrupoD.Properties.Resources.Cerrar;
            imgCerrar.Location = new System.Drawing.Point(359, 12);
            imgCerrar.Name = "imgCerrar";
            imgCerrar.Size = new System.Drawing.Size(27, 26);
            imgCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imgCerrar.TabIndex = 34;
            imgCerrar.TabStop = false;
            imgCerrar.Click += new System.EventHandler(this.imgCerrar_Click_1);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(398, 417);
            this.Controls.Add(imgMinimizar);
            this.Controls.Add(imgCerrar);
            this.Controls.Add(this.txtContraseñaInSe);
            this.Controls.Add(this.txtUsuarioInSe);
            this.Controls.Add(this.imgAtras_Re);
            this.Controls.Add(this.btnojoCerradoInSe);
            this.Controls.Add(this.btnojo_abiertoInSe);
            this.Controls.Add(this.lblContraseñaInSe);
            this.Controls.Add(this.btnIniciarSesionInSe);
            this.Controls.Add(this.lblUsuarioInSe);
            this.Controls.Add(imgKAE_InSe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(398, 417);
            this.MinimumSize = new System.Drawing.Size(398, 417);
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InicioSesion_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(imgKAE_InSe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAtras_Re)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(imgMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(imgCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblUsuarioInSe;
        private RoundedButton btnIniciarSesionInSe;
        private Label lblContraseñaInSe;
        private Button btnojoCerradoInSe;
        private Button btnojo_abiertoInSe;
        private PictureBox imgAtras_Re;
        private TextBoxRedondeado txtUsuarioInSe;
        private TextBoxRedondeado txtContraseñaInSe;
    }
}

