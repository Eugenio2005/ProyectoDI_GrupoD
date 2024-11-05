namespace ProyectoDI_GrupoD.Vistas
{
    partial class PantallaPrincipalAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipalAdmin));
            this.imgBtnUsuario = new ProyectoDI_GrupoD.ImageButton();
            this.SuspendLayout();
            // 
            // imgBtnUsuario
            // 
            this.imgBtnUsuario.BackColor = System.Drawing.Color.Sienna;
            this.imgBtnUsuario.ButtonImage = ((System.Drawing.Image)(resources.GetObject("imgBtnUsuario.ButtonImage")));
            this.imgBtnUsuario.ButtonText = "Nombre Usuario";
            this.imgBtnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgBtnUsuario.HoverBackColor = System.Drawing.Color.LightGray;
            this.imgBtnUsuario.Location = new System.Drawing.Point(0, 0);
            this.imgBtnUsuario.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.imgBtnUsuario.Name = "imgBtnUsuario";
            this.imgBtnUsuario.Size = new System.Drawing.Size(300, 50);
            this.imgBtnUsuario.TabIndex = 0;
            // 
            // PantallaPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1271, 594);
            this.Controls.Add(this.imgBtnUsuario);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaPrincipalAdmin";
            this.Text = "K A E GYM ADMIN";
            this.ResumeLayout(false);

        }

        #endregion

        private ImageButton imgBtnUsuario;
    }
}