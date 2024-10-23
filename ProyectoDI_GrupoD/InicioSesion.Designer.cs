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
            this.txtContraseñaInSe.Location = new System.Drawing.Point(42, 239);
            this.txtContraseñaInSe.Margin = new System.Windows.Forms.Padding(10);
            this.txtContraseñaInSe.MinimumSize = new System.Drawing.Size(10, 10);
            this.txtContraseñaInSe.Name = "txtContraseñaInSe";
            this.txtContraseñaInSe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContraseñaInSe.Size = new System.Drawing.Size(314, 24);
            this.txtContraseñaInSe.TabIndex = 2;
            this.txtContraseñaInSe.TextChanged += new System.EventHandler(this.txtContraseñaInSe_TextChanged);
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
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(75, 275);
            this.btnPrueba.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(107, 19);
            this.btnPrueba.TabIndex = 7;
            this.btnPrueba.Text = "PruebaConexion";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // lblPrueba
            // 
            this.lblPrueba.AutoSize = true;
            this.lblPrueba.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrueba.Location = new System.Drawing.Point(206, 280);
            this.lblPrueba.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(35, 13);
            this.lblPrueba.TabIndex = 8;
            this.lblPrueba.Text = "label1";
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(384, 381);
            this.Controls.Add(this.lblPrueba);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.lblContraseñaInSe);
            this.Controls.Add(this.btnRegistrarInSe);
            this.Controls.Add(this.btnIniciarSesionInSe);
            this.Controls.Add(this.lblUsuarioInSe);
            this.Controls.Add(this.txtContraseñaInSe);
            this.Controls.Add(this.txtUsuarioInSe);
            this.Controls.Add(imgKAE_InSe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 420);
            this.MinimumSize = new System.Drawing.Size(400, 420);
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesion";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
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
        private Button btnRegistrarInSe;
        private Label lblContraseñaInSe;
        private Button btnPrueba;
        private Label lblPrueba;
    }
}

