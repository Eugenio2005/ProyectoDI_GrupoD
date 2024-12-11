namespace ProyectoDI_GrupoD.Vistas
{
    partial class InformacionActividad
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
            this.components = new System.ComponentModel.Container();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.lblDescripActividad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgAtras_Re = new System.Windows.Forms.PictureBox();
            this.toolTipApuntarse = new System.Windows.Forms.ToolTip(this.components);
            this.btnApuntar = new ProyectoDI_GrupoD.RoundedButton();
            this.txtNombreActividad = new ProyectoDI_GrupoD.TextBoxRedondeado();
            this.txtDescripActividad = new ProyectoDI_GrupoD.TextBoxRedondeado();
            this.txtMonitorAsociado = new ProyectoDI_GrupoD.TextBoxRedondeado();
            ((System.ComponentModel.ISupportInitialize)(this.imgAtras_Re)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMonitor
            // 
            this.lblMonitor.AutoSize = true;
            this.lblMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.lblMonitor.Location = new System.Drawing.Point(83, 244);
            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.Size = new System.Drawing.Size(154, 24);
            this.lblMonitor.TabIndex = 14;
            this.lblMonitor.Text = "Monitor asociado";
            // 
            // lblDescripActividad
            // 
            this.lblDescripActividad.AutoSize = true;
            this.lblDescripActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripActividad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.lblDescripActividad.Location = new System.Drawing.Point(83, 160);
            this.lblDescripActividad.Name = "lblDescripActividad";
            this.lblDescripActividad.Size = new System.Drawing.Size(188, 24);
            this.lblDescripActividad.TabIndex = 13;
            this.lblDescripActividad.Text = "Descripción actividad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(83, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre actividad";
            // 
            // imgAtras_Re
            // 
            this.imgAtras_Re.ErrorImage = global::ProyectoDI_GrupoD.Properties.Resources.atrasSinFondo;
            this.imgAtras_Re.ImageLocation = "0;0";
            this.imgAtras_Re.InitialImage = null;
            this.imgAtras_Re.Location = new System.Drawing.Point(7, 7);
            this.imgAtras_Re.Margin = new System.Windows.Forms.Padding(0);
            this.imgAtras_Re.Name = "imgAtras_Re";
            this.imgAtras_Re.Size = new System.Drawing.Size(70, 56);
            this.imgAtras_Re.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgAtras_Re.TabIndex = 27;
            this.imgAtras_Re.TabStop = false;
            this.imgAtras_Re.Click += new System.EventHandler(this.imgAtras_Re_Click);
            // 
            // btnApuntar
            // 
            this.btnApuntar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApuntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.btnApuntar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.btnApuntar.BorderRadius = 20;
            this.btnApuntar.FillColor = System.Drawing.Color.Transparent;
            this.btnApuntar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(206)))), ((int)(((byte)(164)))));
            this.btnApuntar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(206)))), ((int)(((byte)(164)))));
            this.btnApuntar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApuntar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApuntar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnApuntar.Location = new System.Drawing.Point(143, 361);
            this.btnApuntar.Name = "btnApuntar";
            this.btnApuntar.Size = new System.Drawing.Size(134, 49);
            this.btnApuntar.TabIndex = 28;
            this.btnApuntar.Text = "Apuntarse";
            this.btnApuntar.UseVisualStyleBackColor = false;
            this.btnApuntar.Click += new System.EventHandler(this.btnApuntar_Click);
            // 
            // txtNombreActividad
            // 
            this.txtNombreActividad.BackColor = System.Drawing.Color.White;
            this.txtNombreActividad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.txtNombreActividad.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtNombreActividad.BorderRadius = 15;
            this.txtNombreActividad.BorderSize = 2;
            this.txtNombreActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreActividad.Location = new System.Drawing.Point(86, 113);
            this.txtNombreActividad.MaxLength = 32767;
            this.txtNombreActividad.Name = "txtNombreActividad";
            this.txtNombreActividad.OnlyAllowNumbers = false;
            this.txtNombreActividad.Padding = new System.Windows.Forms.Padding(10);
            this.txtNombreActividad.Size = new System.Drawing.Size(254, 33);
            this.txtNombreActividad.TabIndex = 1;
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
            this.txtDescripActividad.Location = new System.Drawing.Point(86, 198);
            this.txtDescripActividad.MaxLength = 32767;
            this.txtDescripActividad.Name = "txtDescripActividad";
            this.txtDescripActividad.OnlyAllowNumbers = false;
            this.txtDescripActividad.Padding = new System.Windows.Forms.Padding(10);
            this.txtDescripActividad.Size = new System.Drawing.Size(254, 33);
            this.txtDescripActividad.TabIndex = 2;
            this.txtDescripActividad.UseSystemPasswordChar = false;
            // 
            // txtMonitorAsociado
            // 
            this.txtMonitorAsociado.BackColor = System.Drawing.Color.White;
            this.txtMonitorAsociado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.txtMonitorAsociado.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtMonitorAsociado.BorderRadius = 15;
            this.txtMonitorAsociado.BorderSize = 2;
            this.txtMonitorAsociado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonitorAsociado.Location = new System.Drawing.Point(86, 287);
            this.txtMonitorAsociado.MaxLength = 32767;
            this.txtMonitorAsociado.Name = "txtMonitorAsociado";
            this.txtMonitorAsociado.OnlyAllowNumbers = false;
            this.txtMonitorAsociado.Padding = new System.Windows.Forms.Padding(10);
            this.txtMonitorAsociado.Size = new System.Drawing.Size(254, 33);
            this.txtMonitorAsociado.TabIndex = 3;
            this.txtMonitorAsociado.UseSystemPasswordChar = false;
            // 
            // InformacionActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(422, 448);
            this.Controls.Add(this.txtMonitorAsociado);
            this.Controls.Add(this.txtDescripActividad);
            this.Controls.Add(this.txtNombreActividad);
            this.Controls.Add(this.btnApuntar);
            this.Controls.Add(this.imgAtras_Re);
            this.Controls.Add(this.lblMonitor);
            this.Controls.Add(this.lblDescripActividad);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InformacionActividad";
            this.Text = "InformacionActividad";
            ((System.ComponentModel.ISupportInitialize)(this.imgAtras_Re)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMonitor;
        private System.Windows.Forms.Label lblDescripActividad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgAtras_Re;
        private System.Windows.Forms.ToolTip toolTipApuntarse;
        private RoundedButton btnApuntar;
        private TextBoxRedondeado txtNombreActividad;
        private TextBoxRedondeado txtDescripActividad;
        private TextBoxRedondeado txtMonitorAsociado;
    }
}