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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicio));
            this.btnInicioSesion = new ProyectoDI_GrupoD.RoundedButton();
            this.linklblRegistro = new System.Windows.Forms.LinkLabel();
            imgKAE_Re = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(imgKAE_Re)).BeginInit();
            this.SuspendLayout();
            // 
            // imgKAE_Re
            // 
            imgKAE_Re.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            imgKAE_Re.ErrorImage = global::ProyectoDI_GrupoD.Properties.Resources.KAEGYM1;
            imgKAE_Re.Image = global::ProyectoDI_GrupoD.Properties.Resources.KAEGYM;
            imgKAE_Re.Location = new System.Drawing.Point(25, 41);
            imgKAE_Re.Name = "imgKAE_Re";
            imgKAE_Re.Size = new System.Drawing.Size(170, 133);
            imgKAE_Re.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            imgKAE_Re.TabIndex = 2;
            imgKAE_Re.TabStop = false;
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.btnInicioSesion.BorderColor = System.Drawing.Color.Gray;
            this.btnInicioSesion.BorderRadius = 20;
            this.btnInicioSesion.FillColor = System.Drawing.Color.Transparent;
            this.btnInicioSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(108)))), ((int)(((byte)(124)))));
            this.btnInicioSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(108)))), ((int)(((byte)(124)))));
            this.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicioSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInicioSesion.Location = new System.Drawing.Point(232, 81);
            this.btnInicioSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(108, 41);
            this.btnInicioSesion.TabIndex = 3;
            this.btnInicioSesion.Text = "Iniciar sesión";
            this.btnInicioSesion.UseVisualStyleBackColor = false;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // linklblRegistro
            // 
            this.linklblRegistro.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))));
            this.linklblRegistro.AutoSize = true;
            this.linklblRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.linklblRegistro.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.linklblRegistro.Location = new System.Drawing.Point(227, 132);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(374, 226);
            this.Controls.Add(this.linklblRegistro);
            this.Controls.Add(this.btnInicioSesion);
            this.Controls.Add(imgKAE_Re);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 265);
            this.MinimumSize = new System.Drawing.Size(390, 265);
            this.Name = "MenuInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuInicio_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(imgKAE_Re)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedButton btnInicioSesion;
        private System.Windows.Forms.LinkLabel linklblRegistro;
    }
}