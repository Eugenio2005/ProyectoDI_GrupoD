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
            this.lblUsuarioInSe = new System.Windows.Forms.Label();
            this.lblContraseñaInSe = new System.Windows.Forms.Label();
            this.btnojoCerradoInSe = new System.Windows.Forms.Button();
            this.btnojo_abiertoInSe = new System.Windows.Forms.Button();
            this.btnRegistrarInSe = new ProyectoDI_GrupoD.RoundedButton();
            this.btnIniciarSesionInSe = new ProyectoDI_GrupoD.RoundedButton();
            this.txtContraseñaInSe = new ColorBorderTextBox();
            this.txtUsuarioInSe = new ColorBorderTextBox();
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
            imgKAE_InSe.Location = new System.Drawing.Point(170, 42);
            imgKAE_InSe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            imgKAE_InSe.Name = "imgKAE_InSe";
            imgKAE_InSe.Size = new System.Drawing.Size(426, 203);
            imgKAE_InSe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            imgKAE_InSe.TabIndex = 0;
            imgKAE_InSe.TabStop = false;
            // 
            // lblUsuarioInSe
            // 
            this.lblUsuarioInSe.AutoSize = true;
            this.lblUsuarioInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblUsuarioInSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioInSe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.lblUsuarioInSe.Location = new System.Drawing.Point(84, 273);
            this.lblUsuarioInSe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsuarioInSe.Name = "lblUsuarioInSe";
            this.lblUsuarioInSe.Size = new System.Drawing.Size(278, 37);
            this.lblUsuarioInSe.TabIndex = 3;
            this.lblUsuarioInSe.Text = "Correo electrónico";
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
            this.lblContraseñaInSe.Location = new System.Drawing.Point(84, 402);
            this.lblContraseñaInSe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblContraseñaInSe.Name = "lblContraseñaInSe";
            this.lblContraseñaInSe.Size = new System.Drawing.Size(183, 37);
            this.lblContraseñaInSe.TabIndex = 6;
            this.lblContraseñaInSe.Text = "Contraseña";
            // 
            // btnojoCerradoInSe
            // 
            this.btnojoCerradoInSe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnojoCerradoInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnojoCerradoInSe.FlatAppearance.BorderSize = 0;
            this.btnojoCerradoInSe.ForeColor = System.Drawing.Color.Transparent;
            this.btnojoCerradoInSe.Image = ((System.Drawing.Image)(resources.GetObject("btnojoCerradoInSe.Image")));
            this.btnojoCerradoInSe.Location = new System.Drawing.Point(664, 456);
            this.btnojoCerradoInSe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnojoCerradoInSe.Name = "btnojoCerradoInSe";
            this.btnojoCerradoInSe.Size = new System.Drawing.Size(48, 50);
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
            this.btnojo_abiertoInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnojo_abiertoInSe.FlatAppearance.BorderSize = 0;
            this.btnojo_abiertoInSe.ForeColor = System.Drawing.Color.Transparent;
            this.btnojo_abiertoInSe.Image = ((System.Drawing.Image)(resources.GetObject("btnojo_abiertoInSe.Image")));
            this.btnojo_abiertoInSe.Location = new System.Drawing.Point(664, 456);
            this.btnojo_abiertoInSe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnojo_abiertoInSe.Name = "btnojo_abiertoInSe";
            this.btnojo_abiertoInSe.Size = new System.Drawing.Size(48, 50);
            this.btnojo_abiertoInSe.TabIndex = 28;
            this.btnojo_abiertoInSe.UseVisualStyleBackColor = false;
            this.btnojo_abiertoInSe.Click += new System.EventHandler(this.btnojoAbiertoInSe_Click);
            // 
            // btnRegistrarInSe
            // 
            this.btnRegistrarInSe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.btnRegistrarInSe.BorderColor = System.Drawing.Color.Gray;
            this.btnRegistrarInSe.BorderRadius = 20;
            this.btnRegistrarInSe.FillColor = System.Drawing.Color.Transparent;
            this.btnRegistrarInSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarInSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarInSe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrarInSe.Location = new System.Drawing.Point(412, 591);
            this.btnRegistrarInSe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRegistrarInSe.Name = "btnRegistrarInSe";
            this.btnRegistrarInSe.Size = new System.Drawing.Size(184, 77);
            this.btnRegistrarInSe.TabIndex = 5;
            this.btnRegistrarInSe.Text = "Registrar";
            this.btnRegistrarInSe.UseVisualStyleBackColor = false;
            this.btnRegistrarInSe.Click += new System.EventHandler(this.brnRegistrarInSe_Click);
            // 
            // btnIniciarSesionInSe
            // 
            this.btnIniciarSesionInSe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciarSesionInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.btnIniciarSesionInSe.BorderColor = System.Drawing.Color.Gray;
            this.btnIniciarSesionInSe.BorderRadius = 20;
            this.btnIniciarSesionInSe.FillColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesionInSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesionInSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesionInSe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIniciarSesionInSe.Location = new System.Drawing.Point(170, 591);
            this.btnIniciarSesionInSe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnIniciarSesionInSe.Name = "btnIniciarSesionInSe";
            this.btnIniciarSesionInSe.Size = new System.Drawing.Size(184, 77);
            this.btnIniciarSesionInSe.TabIndex = 4;
            this.btnIniciarSesionInSe.Text = "Iniciar sesión";
            this.btnIniciarSesionInSe.UseVisualStyleBackColor = false;
            this.btnIniciarSesionInSe.Click += new System.EventHandler(this.btnIniciarSesionInSe_Click);
            this.btnIniciarSesionInSe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnIniciarSesionInSe_KeyDown);
            // 
            // txtContraseñaInSe
            // 
            this.txtContraseñaInSe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseñaInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.txtContraseñaInSe.BorderColor = System.Drawing.Color.White;
            this.txtContraseñaInSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaInSe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.txtContraseñaInSe.Location = new System.Drawing.Point(84, 459);
            this.txtContraseñaInSe.Margin = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.txtContraseñaInSe.MaxLength = 32767;
            this.txtContraseñaInSe.MinimumSize = new System.Drawing.Size(20, 19);
            this.txtContraseñaInSe.Name = "txtContraseñaInSe";
            this.txtContraseñaInSe.OnlyAllowNumbers = false;
            this.txtContraseñaInSe.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContraseñaInSe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContraseñaInSe.Size = new System.Drawing.Size(628, 47);
            this.txtContraseñaInSe.TabIndex = 2;
            this.txtContraseñaInSe.UseSystemPasswordChar = true;
            // 
            // txtUsuarioInSe
            // 
            this.txtUsuarioInSe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuarioInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.txtUsuarioInSe.BorderColor = System.Drawing.Color.White;
            this.txtUsuarioInSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioInSe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.txtUsuarioInSe.Location = new System.Drawing.Point(84, 323);
            this.txtUsuarioInSe.Margin = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.txtUsuarioInSe.MaxLength = 32767;
            this.txtUsuarioInSe.MinimumSize = new System.Drawing.Size(20, 19);
            this.txtUsuarioInSe.Name = "txtUsuarioInSe";
            this.txtUsuarioInSe.OnlyAllowNumbers = false;
            this.txtUsuarioInSe.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuarioInSe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsuarioInSe.Size = new System.Drawing.Size(628, 47);
            this.txtUsuarioInSe.TabIndex = 1;
            this.txtUsuarioInSe.UseSystemPasswordChar = false;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(750, 677);
            this.Controls.Add(this.btnojoCerradoInSe);
            this.Controls.Add(this.btnojo_abiertoInSe);
            this.Controls.Add(this.lblContraseñaInSe);
            this.Controls.Add(this.btnRegistrarInSe);
            this.Controls.Add(this.btnIniciarSesionInSe);
            this.Controls.Add(this.lblUsuarioInSe);
            this.Controls.Add(this.txtContraseñaInSe);
            this.Controls.Add(this.txtUsuarioInSe);
            this.Controls.Add(imgKAE_InSe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(776, 748);
            this.MinimumSize = new System.Drawing.Size(776, 748);
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InicioSesion_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(imgKAE_InSe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorBorderTextBox txtUsuarioInSe;
        private ColorBorderTextBox txtContraseñaInSe;
        private Label lblUsuarioInSe;
        private RoundedButton btnIniciarSesionInSe;
        private RoundedButton btnRegistrarInSe;
        private Label lblContraseñaInSe;
        private Button btnojoCerradoInSe;
        private Button btnojo_abiertoInSe;
    }
}

