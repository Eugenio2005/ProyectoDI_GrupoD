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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            System.Windows.Forms.PictureBox imgKAE_InSe;
            this.lblUsuarioInSe = new System.Windows.Forms.Label();
            this.lblContraseñaInSe = new System.Windows.Forms.Label();
            this.btnojoCerradoInSe = new System.Windows.Forms.Button();
            this.btnojo_abiertoInSe = new System.Windows.Forms.Button();
            this.imgAtras_Re = new System.Windows.Forms.PictureBox();
            this.btnIniciarSesionInSe = new ProyectoDI_GrupoD.RoundedButton();
            this.txtContraseñaInSe = new ColorBorderTextBox();
            this.txtUsuarioInSe = new ColorBorderTextBox();
            imgKAE_InSe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(imgKAE_InSe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAtras_Re)).BeginInit();
            this.SuspendLayout();
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
            this.lblUsuarioInSe.Size = new System.Drawing.Size(171, 25);
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
            this.lblContraseñaInSe.Location = new System.Drawing.Point(56, 257);
            this.lblContraseñaInSe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseñaInSe.Name = "lblContraseñaInSe";
            this.lblContraseñaInSe.Size = new System.Drawing.Size(114, 25);
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
            this.btnojoCerradoInSe.Location = new System.Drawing.Point(443, 292);
            this.btnojoCerradoInSe.Margin = new System.Windows.Forms.Padding(4);
            this.btnojoCerradoInSe.Name = "btnojoCerradoInSe";
            this.btnojoCerradoInSe.Size = new System.Drawing.Size(32, 32);
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
            this.btnojo_abiertoInSe.Location = new System.Drawing.Point(443, 292);
            this.btnojo_abiertoInSe.Margin = new System.Windows.Forms.Padding(4);
            this.btnojo_abiertoInSe.Name = "btnojo_abiertoInSe";
            this.btnojo_abiertoInSe.Size = new System.Drawing.Size(32, 32);
            this.btnojo_abiertoInSe.TabIndex = 28;
            this.btnojo_abiertoInSe.UseVisualStyleBackColor = false;
            this.btnojo_abiertoInSe.Click += new System.EventHandler(this.btnojoAbiertoInSe_Click);
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
            imgKAE_InSe.Size = new System.Drawing.Size(284, 130);
            imgKAE_InSe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            imgKAE_InSe.TabIndex = 0;
            imgKAE_InSe.TabStop = false;
            // 
            // imgAtras_Re
            // 
            this.imgAtras_Re.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgAtras_Re.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgAtras_Re.ErrorImage")));
            this.imgAtras_Re.ImageLocation = "0;0";
            this.imgAtras_Re.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgAtras_Re.InitialImage")));
            this.imgAtras_Re.Location = new System.Drawing.Point(9, 9);
            this.imgAtras_Re.Margin = new System.Windows.Forms.Padding(0);
            this.imgAtras_Re.Name = "imgAtras_Re";
            this.imgAtras_Re.Size = new System.Drawing.Size(93, 69);
            this.imgAtras_Re.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgAtras_Re.TabIndex = 30;
            this.imgAtras_Re.TabStop = false;
            this.imgAtras_Re.Click += new System.EventHandler(this.imgAtras_Re_Click);
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
            this.btnIniciarSesionInSe.Location = new System.Drawing.Point(196, 365);
            this.btnIniciarSesionInSe.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciarSesionInSe.Name = "btnIniciarSesionInSe";
            this.btnIniciarSesionInSe.Size = new System.Drawing.Size(123, 49);
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
            this.txtContraseñaInSe.Location = new System.Drawing.Point(56, 294);
            this.txtContraseñaInSe.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtContraseñaInSe.MaxLength = 32767;
            this.txtContraseñaInSe.MinimumSize = new System.Drawing.Size(13, 12);
            this.txtContraseñaInSe.Name = "txtContraseñaInSe";
            this.txtContraseñaInSe.OnlyAllowNumbers = false;
            this.txtContraseñaInSe.Padding = new System.Windows.Forms.Padding(1);
            this.txtContraseñaInSe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContraseñaInSe.Size = new System.Drawing.Size(419, 30);
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
            this.txtUsuarioInSe.Location = new System.Drawing.Point(56, 207);
            this.txtUsuarioInSe.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtUsuarioInSe.MaxLength = 32767;
            this.txtUsuarioInSe.MinimumSize = new System.Drawing.Size(13, 12);
            this.txtUsuarioInSe.Name = "txtUsuarioInSe";
            this.txtUsuarioInSe.OnlyAllowNumbers = false;
            this.txtUsuarioInSe.Padding = new System.Windows.Forms.Padding(1);
            this.txtUsuarioInSe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsuarioInSe.Size = new System.Drawing.Size(419, 30);
            this.txtUsuarioInSe.TabIndex = 1;
            this.txtUsuarioInSe.UseSystemPasswordChar = false;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(508, 457);
            this.Controls.Add(this.imgAtras_Re);
            this.Controls.Add(this.btnojoCerradoInSe);
            this.Controls.Add(this.btnojo_abiertoInSe);
            this.Controls.Add(this.lblContraseñaInSe);
            this.Controls.Add(this.btnIniciarSesionInSe);
            this.Controls.Add(this.lblUsuarioInSe);
            this.Controls.Add(this.txtContraseñaInSe);
            this.Controls.Add(this.txtUsuarioInSe);
            this.Controls.Add(imgKAE_InSe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(526, 504);
            this.MinimumSize = new System.Drawing.Size(526, 504);
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InicioSesion_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(imgKAE_InSe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAtras_Re)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorBorderTextBox txtUsuarioInSe;
        private ColorBorderTextBox txtContraseñaInSe;
        private Label lblUsuarioInSe;
        private RoundedButton btnIniciarSesionInSe;
        private Label lblContraseñaInSe;
        private Button btnojoCerradoInSe;
        private Button btnojo_abiertoInSe;
        private PictureBox imgAtras_Re;
    }
}

