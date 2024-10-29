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
            this.btnRegistrarInSe = new System.Windows.Forms.Button();
            this.lblContraseñaInSe = new System.Windows.Forms.Label();
            this.btnojoCerradoInSe = new System.Windows.Forms.Button();
            this.btnojo_abiertoInSe = new System.Windows.Forms.Button();
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
            imgKAE_InSe.Location = new System.Drawing.Point(85, 22);
            imgKAE_InSe.Name = "imgKAE_InSe";
            imgKAE_InSe.Size = new System.Drawing.Size(213, 106);
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
            this.txtUsuarioInSe.Location = new System.Drawing.Point(42, 168);
            this.txtUsuarioInSe.Margin = new System.Windows.Forms.Padding(10);
            this.txtUsuarioInSe.MinimumSize = new System.Drawing.Size(10, 10);
            this.txtUsuarioInSe.Name = "txtUsuarioInSe";
            this.txtUsuarioInSe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsuarioInSe.Size = new System.Drawing.Size(314, 24);
            this.txtUsuarioInSe.TabIndex = 1;
            // 
            // txtContraseñaInSe
            // 
            this.txtContraseñaInSe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseñaInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.txtContraseñaInSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaInSe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.txtContraseñaInSe.Location = new System.Drawing.Point(42, 239);
            this.txtContraseñaInSe.Margin = new System.Windows.Forms.Padding(10);
            this.txtContraseñaInSe.MinimumSize = new System.Drawing.Size(10, 10);
            this.txtContraseñaInSe.Name = "txtContraseñaInSe";
            this.txtContraseñaInSe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContraseñaInSe.Size = new System.Drawing.Size(314, 24);
            this.txtContraseñaInSe.TabIndex = 2;
            this.txtContraseñaInSe.UseSystemPasswordChar = true;
            // 
            // lblUsuarioInSe
            // 
            this.lblUsuarioInSe.AutoSize = true;
            this.lblUsuarioInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblUsuarioInSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioInSe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.lblUsuarioInSe.Location = new System.Drawing.Point(42, 142);
            this.lblUsuarioInSe.Name = "lblUsuarioInSe";
            this.lblUsuarioInSe.Size = new System.Drawing.Size(64, 20);
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
            this.btnIniciarSesionInSe.Location = new System.Drawing.Point(85, 307);
            this.btnIniciarSesionInSe.Name = "btnIniciarSesionInSe";
            this.btnIniciarSesionInSe.Size = new System.Drawing.Size(92, 40);
            this.btnIniciarSesionInSe.TabIndex = 4;
            this.btnIniciarSesionInSe.Text = "Iniciar sesión";
            this.btnIniciarSesionInSe.UseVisualStyleBackColor = false;
            this.btnIniciarSesionInSe.Click += new System.EventHandler(this.btnIniciarSesionInSe_Click);
            // 
            // btnRegistrarInSe
            // 
            this.btnRegistrarInSe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.btnRegistrarInSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarInSe.Location = new System.Drawing.Point(206, 307);
            this.btnRegistrarInSe.Name = "btnRegistrarInSe";
            this.btnRegistrarInSe.Size = new System.Drawing.Size(92, 40);
            this.btnRegistrarInSe.TabIndex = 5;
            this.btnRegistrarInSe.Text = "Registrar";
            this.btnRegistrarInSe.UseVisualStyleBackColor = false;
            this.btnRegistrarInSe.Click += new System.EventHandler(this.brnRegistrarInSe_Click);
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
            this.lblContraseñaInSe.Location = new System.Drawing.Point(42, 209);
            this.lblContraseñaInSe.Name = "lblContraseñaInSe";
            this.lblContraseñaInSe.Size = new System.Drawing.Size(92, 20);
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
            this.btnojoCerradoInSe.Location = new System.Drawing.Point(332, 237);
            this.btnojoCerradoInSe.Name = "btnojoCerradoInSe";
            this.btnojoCerradoInSe.Size = new System.Drawing.Size(24, 26);
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
            this.btnojo_abiertoInSe.Location = new System.Drawing.Point(332, 237);
            this.btnojo_abiertoInSe.Name = "btnojo_abiertoInSe";
            this.btnojo_abiertoInSe.Size = new System.Drawing.Size(24, 26);
            this.btnojo_abiertoInSe.TabIndex = 28;
            this.btnojo_abiertoInSe.UseVisualStyleBackColor = false;
            this.btnojo_abiertoInSe.Click += new System.EventHandler(this.btnojoAbiertoInSe_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(383, 379);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(399, 418);
            this.MinimumSize = new System.Drawing.Size(399, 418);
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesion";
            ((System.ComponentModel.ISupportInitialize)(imgKAE_InSe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUsuarioInSe;
        private TextBox txtContraseñaInSe;
        private Label lblUsuarioInSe;
        private Button btnIniciarSesionInSe;
        private Button btnRegistrarInSe;
        private Label lblContraseñaInSe;
        private Button btnojoCerradoInSe;
        private Button btnojo_abiertoInSe;
    }
}

