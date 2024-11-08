namespace ProyectoDI_GrupoD.Vistas
{
    partial class AltaActividad
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
            this.lblAltaActividad = new System.Windows.Forms.Label();
            this.comBoxMonitores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescripActividad = new System.Windows.Forms.Label();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.btnBorrar = new ProyectoDI_GrupoD.RoundedButton();
            this.btnRegistrar = new ProyectoDI_GrupoD.RoundedButton();
            this.txtDescripActividad = new ColorBorderTextBox();
            this.txtNombreActividad = new ColorBorderTextBox();
            this.SuspendLayout();
            // 
            // lblAltaActividad
            // 
            this.lblAltaActividad.AutoSize = true;
            this.lblAltaActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaActividad.ForeColor = System.Drawing.Color.White;
            this.lblAltaActividad.Location = new System.Drawing.Point(152, 29);
            this.lblAltaActividad.Name = "lblAltaActividad";
            this.lblAltaActividad.Size = new System.Drawing.Size(270, 37);
            this.lblAltaActividad.TabIndex = 0;
            this.lblAltaActividad.Text = "-- Alta Actividad --";
            // 
            // comBoxMonitores
            // 
            this.comBoxMonitores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxMonitores.FormattingEnabled = true;
            this.comBoxMonitores.Items.AddRange(new object[] {
            "Sin monitor"});
            this.comBoxMonitores.Location = new System.Drawing.Point(168, 289);
            this.comBoxMonitores.Name = "comBoxMonitores";
            this.comBoxMonitores.Size = new System.Drawing.Size(254, 26);
            this.comBoxMonitores.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(165, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre actividad";
            // 
            // lblDescripActividad
            // 
            this.lblDescripActividad.AutoSize = true;
            this.lblDescripActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripActividad.ForeColor = System.Drawing.Color.White;
            this.lblDescripActividad.Location = new System.Drawing.Point(165, 168);
            this.lblDescripActividad.Name = "lblDescripActividad";
            this.lblDescripActividad.Size = new System.Drawing.Size(148, 18);
            this.lblDescripActividad.TabIndex = 7;
            this.lblDescripActividad.Text = "Descripción actividad";
            // 
            // lblMonitor
            // 
            this.lblMonitor.AutoSize = true;
            this.lblMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonitor.ForeColor = System.Drawing.Color.White;
            this.lblMonitor.Location = new System.Drawing.Point(165, 252);
            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.Size = new System.Drawing.Size(124, 18);
            this.lblMonitor.TabIndex = 8;
            this.lblMonitor.Text = "Monitor asociado";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.btnBorrar.BorderColor = System.Drawing.Color.Gray;
            this.btnBorrar.BorderRadius = 20;
            this.btnBorrar.FillColor = System.Drawing.Color.Transparent;
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBorrar.Location = new System.Drawing.Point(348, 364);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(122, 43);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.btnRegistrar.BorderColor = System.Drawing.Color.Gray;
            this.btnRegistrar.BorderRadius = 20;
            this.btnRegistrar.FillColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrar.Location = new System.Drawing.Point(119, 364);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(122, 43);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar Actividad";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // txtDescripActividad
            // 
            this.txtDescripActividad.BorderColor = System.Drawing.Color.White;
            this.txtDescripActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripActividad.Location = new System.Drawing.Point(168, 198);
            this.txtDescripActividad.MaxLength = 32767;
            this.txtDescripActividad.Name = "txtDescripActividad";
            this.txtDescripActividad.OnlyAllowNumbers = false;
            this.txtDescripActividad.Padding = new System.Windows.Forms.Padding(1);
            this.txtDescripActividad.Size = new System.Drawing.Size(254, 31);
            this.txtDescripActividad.TabIndex = 2;
            this.txtDescripActividad.UseSystemPasswordChar = false;
            // 
            // txtNombreActividad
            // 
            this.txtNombreActividad.BorderColor = System.Drawing.Color.White;
            this.txtNombreActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreActividad.Location = new System.Drawing.Point(168, 118);
            this.txtNombreActividad.MaxLength = 32767;
            this.txtNombreActividad.Name = "txtNombreActividad";
            this.txtNombreActividad.OnlyAllowNumbers = false;
            this.txtNombreActividad.Padding = new System.Windows.Forms.Padding(1);
            this.txtNombreActividad.Size = new System.Drawing.Size(254, 31);
            this.txtNombreActividad.TabIndex = 1;
            this.txtNombreActividad.UseSystemPasswordChar = false;
            // 
            // AltaActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.lblMonitor);
            this.Controls.Add(this.lblDescripActividad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.comBoxMonitores);
            this.Controls.Add(this.txtDescripActividad);
            this.Controls.Add(this.txtNombreActividad);
            this.Controls.Add(this.lblAltaActividad);
            this.Name = "AltaActividad";
            this.Text = "AltaActividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltaActividad;
        private ColorBorderTextBox txtNombreActividad;
        private ColorBorderTextBox txtDescripActividad;
        private System.Windows.Forms.ComboBox comBoxMonitores;
        private RoundedButton btnRegistrar;
        private RoundedButton btnBorrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescripActividad;
        private System.Windows.Forms.Label lblMonitor;
    }
}