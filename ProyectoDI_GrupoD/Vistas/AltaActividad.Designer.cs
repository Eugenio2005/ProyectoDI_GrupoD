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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescripActividad = new System.Windows.Forms.Label();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.btnRegistrar = new ProyectoDI_GrupoD.RoundedButton();
            this.txtNombreActividad = new ProyectoDI_GrupoD.TextBoxRedondeado();
            this.txtDescripActividad = new ProyectoDI_GrupoD.TextBoxRedondeado();
            this.btnBorrar = new ProyectoDI_GrupoD.RoundedButton();
            this.comBoxMonitores = new ProyectoDI_GrupoD.ComboBoxRedondeado();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(220, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre actividad";
            // 
            // lblDescripActividad
            // 
            this.lblDescripActividad.AutoSize = true;
            this.lblDescripActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripActividad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.lblDescripActividad.Location = new System.Drawing.Point(220, 182);
            this.lblDescripActividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripActividad.Name = "lblDescripActividad";
            this.lblDescripActividad.Size = new System.Drawing.Size(242, 29);
            this.lblDescripActividad.TabIndex = 7;
            this.lblDescripActividad.Text = "Descripción actividad";
            // 
            // lblMonitor
            // 
            this.lblMonitor.AutoSize = true;
            this.lblMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.lblMonitor.Location = new System.Drawing.Point(220, 286);
            this.lblMonitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.Size = new System.Drawing.Size(198, 29);
            this.lblMonitor.TabIndex = 8;
            this.lblMonitor.Text = "Monitor asociado";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.btnRegistrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.btnRegistrar.BorderRadius = 20;
            this.btnRegistrar.FillColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(206)))), ((int)(((byte)(164)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(206)))), ((int)(((byte)(164)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrar.Location = new System.Drawing.Point(133, 448);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(193, 53);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar Actividad";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNombreActividad
            // 
            this.txtNombreActividad.BackColor = System.Drawing.Color.White;
            this.txtNombreActividad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.txtNombreActividad.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtNombreActividad.BorderRadius = 15;
            this.txtNombreActividad.BorderSize = 2;
            this.txtNombreActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreActividad.Location = new System.Drawing.Point(224, 124);
            this.txtNombreActividad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreActividad.MaxLength = 32767;
            this.txtNombreActividad.Name = "txtNombreActividad";
            this.txtNombreActividad.OnlyAllowNumbers = false;
            this.txtNombreActividad.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtNombreActividad.Size = new System.Drawing.Size(339, 41);
            this.txtNombreActividad.TabIndex = 9;
            this.txtNombreActividad.UseSystemPasswordChar = false;
            // 
            // txtDescripActividad
            // 
            this.txtDescripActividad.BackColor = System.Drawing.Color.White;
            this.txtDescripActividad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.txtDescripActividad.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtDescripActividad.BorderRadius = 15;
            this.txtDescripActividad.BorderSize = 2;
            this.txtDescripActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripActividad.Location = new System.Drawing.Point(224, 228);
            this.txtDescripActividad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripActividad.MaxLength = 32767;
            this.txtDescripActividad.Name = "txtDescripActividad";
            this.txtDescripActividad.OnlyAllowNumbers = false;
            this.txtDescripActividad.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtDescripActividad.Size = new System.Drawing.Size(339, 41);
            this.txtDescripActividad.TabIndex = 10;
            this.txtDescripActividad.UseSystemPasswordChar = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.btnBorrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.btnBorrar.BorderRadius = 20;
            this.btnBorrar.FillColor = System.Drawing.Color.Transparent;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(206)))), ((int)(((byte)(164)))));
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(206)))), ((int)(((byte)(164)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBorrar.Location = new System.Drawing.Point(469, 448);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(163, 53);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // comBoxMonitores
            // 
            this.comBoxMonitores.BackColor = System.Drawing.Color.White;
            this.comBoxMonitores.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.comBoxMonitores.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.comBoxMonitores.BorderRadius = 15;
            this.comBoxMonitores.BorderSize = 2;
            this.comBoxMonitores.DataSource = null;
            this.comBoxMonitores.DisplayMember = "";
            this.comBoxMonitores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxMonitores.Location = new System.Drawing.Point(224, 332);
            this.comBoxMonitores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comBoxMonitores.Name = "comBoxMonitores";
            this.comBoxMonitores.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.comBoxMonitores.SelectedValue = null;
            this.comBoxMonitores.Size = new System.Drawing.Size(339, 49);
            this.comBoxMonitores.TabIndex = 12;
            this.comBoxMonitores.ValueMember = "";
            // 
            // AltaActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(772, 554);
            this.Controls.Add(this.comBoxMonitores);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtDescripActividad);
            this.Controls.Add(this.txtNombreActividad);
            this.Controls.Add(this.lblMonitor);
            this.Controls.Add(this.lblDescripActividad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AltaActividad";
            this.Text = "AltaActividad";
            this.Load += new System.EventHandler(this.AltaActividad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundedButton btnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescripActividad;
        private System.Windows.Forms.Label lblMonitor;
        private TextBoxRedondeado txtNombreActividad;
        private TextBoxRedondeado txtDescripActividad;
        private RoundedButton btnBorrar;
        private ComboBoxRedondeado comBoxMonitores;
    }
}