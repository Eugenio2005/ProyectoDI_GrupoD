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
            this.NombreUsuario = new ProyectoDI_GrupoD.ImageButton();
            this.SuspendLayout();
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.BackColor = System.Drawing.Color.Sienna;
            this.NombreUsuario.ButtonImage = ((System.Drawing.Image)(resources.GetObject("NombreUsuario.ButtonImage")));
            this.NombreUsuario.ButtonText = "Nombre de usuario";
            this.NombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUsuario.ForeColor = System.Drawing.Color.White;
            this.NombreUsuario.HoverBackColor = System.Drawing.Color.LightGray;
            this.NombreUsuario.Location = new System.Drawing.Point(0, 0);
            this.NombreUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(300, 50);
            this.NombreUsuario.TabIndex = 2;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1305, 633);
            this.Controls.Add(this.NombreUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "K A E GYM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PantallaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ImageButton NombreUsuario;
    }
}