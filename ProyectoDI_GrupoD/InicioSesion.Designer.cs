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
            this.txtUsuarioInSe = new System.Windows.Forms.TextBox();
            this.txtContraseñaInSe = new System.Windows.Forms.TextBox();
            this.lblUsuarioInSe = new System.Windows.Forms.Label();
            this.btnIniciarSesionInSe = new System.Windows.Forms.Button();
            this.brnRegistrarInSe = new System.Windows.Forms.Button();
            this.lblContraseñaInSe = new System.Windows.Forms.Label();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.lblPrueba = new System.Windows.Forms.Label();
            imgKAE_InSe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(imgKAE_InSe)).BeginInit();
            this.SuspendLayout();
            // 
            // imgKAE_InSe
            // 
            imgKAE_InSe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            imgKAE_InSe.Image = global::ProyectoDI_GrupoD.Properties.Resources.KAEGYM1;
            imgKAE_InSe.Location = new System.Drawing.Point(113, 27);
            imgKAE_InSe.Margin = new System.Windows.Forms.Padding(4);
            imgKAE_InSe.Name = "imgKAE_InSe";
            imgKAE_InSe.Size = new System.Drawing.Size(283, 128);
            imgKAE_InSe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            imgKAE_InSe.TabIndex = 0;
            imgKAE_InSe.TabStop = false;
            // 
            // txtUsuarioInSe
            // 
            this.txtUsuarioInSe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuarioInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.txtUsuarioInSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioInSe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.txtUsuarioInSe.Location = new System.Drawing.Point(56, 207);
            this.txtUsuarioInSe.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtUsuarioInSe.MinimumSize = new System.Drawing.Size(12, 10);
            this.txtUsuarioInSe.Name = "txtUsuarioInSe";
            this.txtUsuarioInSe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsuarioInSe.Size = new System.Drawing.Size(416, 29);
            this.txtUsuarioInSe.TabIndex = 1;
            this.txtUsuarioInSe.Text = "Nombre de usuario";
            this.txtUsuarioInSe.TextChanged += new System.EventHandler(this.txtUsuarioInSe_TextChanged);
            // 
            // txtContraseñaInSe
            // 
            this.txtContraseñaInSe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseñaInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.txtContraseñaInSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaInSe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.txtContraseñaInSe.Location = new System.Drawing.Point(56, 294);
            this.txtContraseñaInSe.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtContraseñaInSe.MinimumSize = new System.Drawing.Size(12, 10);
            this.txtContraseñaInSe.Name = "txtContraseñaInSe";
            this.txtContraseñaInSe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContraseñaInSe.Size = new System.Drawing.Size(416, 29);
            this.txtContraseñaInSe.TabIndex = 2;
            this.txtContraseñaInSe.Text = "Contraseña";
            this.txtContraseñaInSe.TextChanged += new System.EventHandler(this.txtContraseñaInSe_TextChanged);
            // 
            // lblUsuarioInSe
            // 
            this.lblUsuarioInSe.AutoSize = true;
            this.lblUsuarioInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblUsuarioInSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioInSe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.lblUsuarioInSe.Location = new System.Drawing.Point(56, 175);
            this.lblUsuarioInSe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioInSe.Name = "lblUsuarioInSe";
            this.lblUsuarioInSe.Size = new System.Drawing.Size(79, 25);
            this.lblUsuarioInSe.TabIndex = 3;
            this.lblUsuarioInSe.Text = "Usuario";
            // 
            // btnIniciarSesionInSe
            // 
            this.btnIniciarSesionInSe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciarSesionInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.btnIniciarSesionInSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesionInSe.Location = new System.Drawing.Point(113, 378);
            this.btnIniciarSesionInSe.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciarSesionInSe.Name = "btnIniciarSesionInSe";
            this.btnIniciarSesionInSe.Size = new System.Drawing.Size(121, 47);
            this.btnIniciarSesionInSe.TabIndex = 4;
            this.btnIniciarSesionInSe.Text = "Iniciar sesión";
            this.btnIniciarSesionInSe.UseVisualStyleBackColor = false;
            this.btnIniciarSesionInSe.Click += new System.EventHandler(this.btnIniciarSesionInSe_Click);
            // 
            // brnRegistrarInSe
            // 
            this.brnRegistrarInSe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brnRegistrarInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.brnRegistrarInSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnRegistrarInSe.Location = new System.Drawing.Point(275, 378);
            this.brnRegistrarInSe.Margin = new System.Windows.Forms.Padding(4);
            this.brnRegistrarInSe.Name = "brnRegistrarInSe";
            this.brnRegistrarInSe.Size = new System.Drawing.Size(121, 47);
            this.brnRegistrarInSe.TabIndex = 5;
            this.brnRegistrarInSe.Text = "Registrar";
            this.brnRegistrarInSe.UseVisualStyleBackColor = false;
            this.brnRegistrarInSe.Click += new System.EventHandler(this.brnRegistrarInSe_Click);
            // 
            // lblContraseñaInSe
            // 
            this.lblContraseñaInSe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContraseñaInSe.AutoSize = true;
            this.lblContraseñaInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblContraseñaInSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaInSe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.lblContraseñaInSe.Location = new System.Drawing.Point(56, 257);
            this.lblContraseñaInSe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseñaInSe.Name = "lblContraseñaInSe";
            this.lblContraseñaInSe.Size = new System.Drawing.Size(114, 25);
            this.lblContraseñaInSe.TabIndex = 6;
            this.lblContraseñaInSe.Text = "Contraseña";
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(100, 339);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(143, 23);
            this.btnPrueba.TabIndex = 7;
            this.btnPrueba.Text = "PruebaConexion";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // lblPrueba
            // 
            this.lblPrueba.AutoSize = true;
            this.lblPrueba.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrueba.Location = new System.Drawing.Point(275, 345);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(44, 16);
            this.lblPrueba.TabIndex = 8;
            this.lblPrueba.Text = "label1";
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(509, 459);
            this.Controls.Add(this.lblPrueba);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.lblContraseñaInSe);
            this.Controls.Add(this.brnRegistrarInSe);
            this.Controls.Add(this.btnIniciarSesionInSe);
            this.Controls.Add(this.lblUsuarioInSe);
            this.Controls.Add(this.txtContraseñaInSe);
            this.Controls.Add(this.txtUsuarioInSe);
            this.Controls.Add(imgKAE_InSe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(527, 506);
            this.MinimumSize = new System.Drawing.Size(527, 506);
            this.Name = "InicioSesion";
            this.Text = "Inicio Sesion";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(imgKAE_InSe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarioRe;
        private System.Windows.Forms.TextBox txtContraseñaRe;
        private System.Windows.Forms.Label label1Re;
        private System.Windows.Forms.Button btnAceptarRe;
        private System.Windows.Forms.Button brnRegistrarInSeRe;
        private System.Windows.Forms.Label lblContraseñaInSeRe;
        private TextBox txtUsuarioInSe;
        private TextBox txtContraseñaInSe;
        private Label lblUsuarioInSe;
        private Button btnIniciarSesionInSe;
        private Button brnRegistrarInSe;
        private Label lblContraseñaInSe;
        private Button btnPrueba;
        private Label lblPrueba;
    }
}

