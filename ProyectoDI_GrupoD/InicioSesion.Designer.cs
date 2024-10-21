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
            System.Windows.Forms.PictureBox imgKAE;
            this.txtUsuarioInSe = new System.Windows.Forms.TextBox();
            imgKAE = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(imgKAE)).BeginInit();
            this.SuspendLayout();
            // 
            // imgKAE
            // 
            imgKAE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            imgKAE.ErrorImage = global::ProyectoDI_GrupoD.Properties.Resources.KAEGYM1;
            imgKAE.Image = global::ProyectoDI_GrupoD.Properties.Resources.KAEGYM;
            imgKAE.Location = new System.Drawing.Point(85, 24);
            imgKAE.Name = "imgKAE";
            imgKAE.Size = new System.Drawing.Size(199, 97);
            imgKAE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            imgKAE.TabIndex = 0;
            imgKAE.TabStop = false;
            imgKAE.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtUsuarioInSe
            // 
            this.txtUsuarioInSe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuarioInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtUsuarioInSe.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUsuarioInSe.Location = new System.Drawing.Point(42, 168);
            this.txtUsuarioInSe.Margin = new System.Windows.Forms.Padding(10);
            this.txtUsuarioInSe.MinimumSize = new System.Drawing.Size(10, 10);
            this.txtUsuarioInSe.Name = "txtUsuarioInSe";
            this.txtUsuarioInSe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsuarioInSe.Size = new System.Drawing.Size(294, 20);
            this.txtUsuarioInSe.TabIndex = 1;
            this.txtUsuarioInSe.Text = "nombre de usuario";
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(371, 374);
            this.Controls.Add(this.txtUsuarioInSe);
            this.Controls.Add(imgKAE);
            this.Name = "InicioSesion";
            this.Text = "Inicio Sesion";
            ((System.ComponentModel.ISupportInitialize)(imgKAE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtUsuarioInSe;
    }
}

