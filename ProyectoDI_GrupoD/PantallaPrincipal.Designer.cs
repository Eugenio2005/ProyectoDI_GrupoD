namespace ProyectoDI_GrupoD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.lblNombreUsuarioP1 = new System.Windows.Forms.Label();
            this.NombreUsuario = new ProyectoDI_GrupoD.ImageButton();
            this.SuspendLayout();
            // 
            // lblNombreUsuarioP1
            // 
            this.lblNombreUsuarioP1.AutoSize = true;
            this.lblNombreUsuarioP1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombreUsuarioP1.Image = ((System.Drawing.Image)(resources.GetObject("lblNombreUsuarioP1.Image")));
            this.lblNombreUsuarioP1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNombreUsuarioP1.Location = new System.Drawing.Point(317, 200);
            this.lblNombreUsuarioP1.Name = "lblNombreUsuarioP1";
            this.lblNombreUsuarioP1.Size = new System.Drawing.Size(13, 13);
            this.lblNombreUsuarioP1.TabIndex = 1;
            this.lblNombreUsuarioP1.Text = "k";
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NombreUsuario.BackColor = System.Drawing.Color.Navy;
            this.NombreUsuario.ButtonImage = ((System.Drawing.Image)(resources.GetObject("NombreUsuario.ButtonImage")));
            this.NombreUsuario.ButtonText = "Nombre de usuario";
            this.NombreUsuario.ForeColor = System.Drawing.Color.White;
            this.NombreUsuario.HoverBackColor = System.Drawing.Color.LightGray;
            this.NombreUsuario.Location = new System.Drawing.Point(0, 0);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(229, 35);
            this.NombreUsuario.TabIndex = 2;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1684, 661);
            this.Controls.Add(this.NombreUsuario);
            this.Controls.Add(this.lblNombreUsuarioP1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "K A E GYM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PantallaPrincipal_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreUsuarioP1;
        private ImageButton NombreUsuario;
    }
}