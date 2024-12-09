namespace ProyectoDI_GrupoD.Vistas
{
    partial class MenuInicio
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
            System.Windows.Forms.PictureBox imgKAE_Re;
            System.Windows.Forms.PictureBox imgCerrar;
            System.Windows.Forms.PictureBox imgMinimizar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicio));
            this.btnInicioSesion = new ProyectoDI_GrupoD.RoundedButton();
            this.linklblRegistro = new System.Windows.Forms.LinkLabel();
            imgKAE_Re = new System.Windows.Forms.PictureBox();
            imgCerrar = new System.Windows.Forms.PictureBox();
            imgMinimizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(imgKAE_Re)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(imgCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(imgMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // imgKAE_Re
            // 
            imgKAE_Re.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            imgKAE_Re.ErrorImage = global::ProyectoDI_GrupoD.Properties.Resources.KAEGYM1;
            imgKAE_Re.Image = global::ProyectoDI_GrupoD.Properties.Resources.KAE_GYM_novo_re;
            imgKAE_Re.Location = new System.Drawing.Point(60, 44);
            imgKAE_Re.Name = "imgKAE_Re";
            imgKAE_Re.Size = new System.Drawing.Size(255, 157);
            imgKAE_Re.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imgKAE_Re.TabIndex = 2;
            imgKAE_Re.TabStop = false;
            // 
            // imgCerrar
            // 
            imgCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            imgCerrar.ErrorImage = global::ProyectoDI_GrupoD.Properties.Resources.KAEGYM1;
            imgCerrar.Image = global::ProyectoDI_GrupoD.Properties.Resources.Cerrar;
            imgCerrar.Location = new System.Drawing.Point(335, 12);
            imgCerrar.Name = "imgCerrar";
            imgCerrar.Size = new System.Drawing.Size(27, 26);
            imgCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imgCerrar.TabIndex = 5;
            imgCerrar.TabStop = false;
            imgCerrar.Click += new System.EventHandler(this.imgCerrar_Click);
            // 
            // imgMinimizar
            // 
            imgMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            imgMinimizar.ErrorImage = global::ProyectoDI_GrupoD.Properties.Resources.KAEGYM1;
            imgMinimizar.Image = global::ProyectoDI_GrupoD.Properties.Resources.Minimizar;
            imgMinimizar.Location = new System.Drawing.Point(291, 12);
            imgMinimizar.Name = "imgMinimizar";
            imgMinimizar.Size = new System.Drawing.Size(27, 26);
            imgMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imgMinimizar.TabIndex = 6;
            imgMinimizar.TabStop = false;
            imgMinimizar.Click += new System.EventHandler(this.imgMinimizar_Click);
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.btnInicioSesion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.btnInicioSesion.BorderRadius = 20;
            this.btnInicioSesion.FillColor = System.Drawing.Color.Transparent;
            this.btnInicioSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(206)))), ((int)(((byte)(164)))));
            this.btnInicioSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(206)))), ((int)(((byte)(164)))));
            this.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicioSesion.ForeColor = System.Drawing.Color.Black;
            this.btnInicioSesion.Location = new System.Drawing.Point(128, 217);
            this.btnInicioSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(118, 41);
            this.btnInicioSesion.TabIndex = 3;
            this.btnInicioSesion.Text = "Iniciar sesión";
            this.btnInicioSesion.UseVisualStyleBackColor = false;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // linklblRegistro
            // 
            this.linklblRegistro.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.linklblRegistro.AutoSize = true;
            this.linklblRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(125)))), ((int)(((byte)(68)))));
            this.linklblRegistro.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(125)))), ((int)(((byte)(68)))));
            this.linklblRegistro.Location = new System.Drawing.Point(125, 277);
            this.linklblRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linklblRegistro.Name = "linklblRegistro";
            this.linklblRegistro.Size = new System.Drawing.Size(121, 26);
            this.linklblRegistro.TabIndex = 4;
            this.linklblRegistro.TabStop = true;
            this.linklblRegistro.Text = "¿No tienes una cuenta?\r\nRegistrate aquí";
            this.linklblRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linklblRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblRegistro_LinkClicked);
            // 
            // MenuInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(374, 328);
            this.Controls.Add(imgMinimizar);
            this.Controls.Add(imgCerrar);
            this.Controls.Add(this.linklblRegistro);
            this.Controls.Add(this.btnInicioSesion);
            this.Controls.Add(imgKAE_Re);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MenuInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuInicio_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(imgKAE_Re)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(imgCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(imgMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedButton btnInicioSesion;
        private System.Windows.Forms.LinkLabel linklblRegistro;
    }
}