using System.Data.Entity.Infrastructure;
using System.Drawing;

namespace ProyectoDI_GrupoD
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.imgKAE_Re = new System.Windows.Forms.PictureBox();
            this.lblEmailRe = new System.Windows.Forms.Label();
            this.lblNombreRe = new System.Windows.Forms.Label();
            this.txtEmailRe = new ColorBorderTextBox();
            this.txtUsuarioRe = new System.Windows.Forms.TextBox();
            this.lblCuentaCorrienteRe = new System.Windows.Forms.Label();
            this.lblDNI_Re = new System.Windows.Forms.Label();
            this.txtCuentaCorrienteRe = new ColorBorderTextBox();
            this.txtDNI_Re = new ColorBorderTextBox();
            this.lblContraseñaRe = new System.Windows.Forms.Label();
            this.lblDirecciónRe = new System.Windows.Forms.Label();
            this.txtContraseñaRe = new ColorBorderTextBox();
            this.btnojoCerradoRe = new System.Windows.Forms.Button();
            this.txtDireccionRe = new ColorBorderTextBox();
            this.lblTelefonoRe = new System.Windows.Forms.Label();
            this.lblApellidosRe = new System.Windows.Forms.Label();
            this.txtTelefonoRe = new ColorBorderTextBox();
            this.txtApellidosRe = new System.Windows.Forms.TextBox();
            this.imgAtras_Re = new System.Windows.Forms.PictureBox();
            this.btnojo_abiertoRe = new System.Windows.Forms.Button();
            this.btnRegistrarRe = new ProyectoDI_GrupoD.RoundedButton();
            this.btnBorrarRe = new ProyectoDI_GrupoD.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgKAE_Re)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAtras_Re)).BeginInit();
            this.SuspendLayout();
            // 
            // imgKAE_Re
            // 
            this.imgKAE_Re.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgKAE_Re.ErrorImage = global::ProyectoDI_GrupoD.Properties.Resources.KAEGYM1;
            this.imgKAE_Re.Image = global::ProyectoDI_GrupoD.Properties.Resources.KAEGYM;
            this.imgKAE_Re.Location = new System.Drawing.Point(85, 12);
            this.imgKAE_Re.Name = "imgKAE_Re";
            this.imgKAE_Re.Size = new System.Drawing.Size(617, 136);
            this.imgKAE_Re.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgKAE_Re.TabIndex = 1;
            this.imgKAE_Re.TabStop = false;
            // 
            // lblEmailRe
            // 
            this.lblEmailRe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmailRe.AutoSize = true;
            this.lblEmailRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblEmailRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.lblEmailRe.Location = new System.Drawing.Point(51, 260);
            this.lblEmailRe.Name = "lblEmailRe";
            this.lblEmailRe.Size = new System.Drawing.Size(48, 20);
            this.lblEmailRe.TabIndex = 10;
            this.lblEmailRe.Text = "Email";
            // 
            // lblNombreRe
            // 
            this.lblNombreRe.AutoSize = true;
            this.lblNombreRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblNombreRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.lblNombreRe.Location = new System.Drawing.Point(47, 126);
            this.lblNombreRe.Name = "lblNombreRe";
            this.lblNombreRe.Size = new System.Drawing.Size(65, 20);
            this.lblNombreRe.TabIndex = 9;
            this.lblNombreRe.Text = "Nombre";
            // 
            // txtEmailRe
            // 
            this.txtEmailRe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtEmailRe.BorderColor = System.Drawing.Color.White;
            this.txtEmailRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.txtEmailRe.Location = new System.Drawing.Point(47, 290);
            this.txtEmailRe.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.txtEmailRe.MaxLength = 32767;
            this.txtEmailRe.MinimumSize = new System.Drawing.Size(10, 10);
            this.txtEmailRe.Name = "txtEmailRe";
            this.txtEmailRe.OnlyAllowNumbers = false;
            this.txtEmailRe.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtEmailRe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmailRe.Size = new System.Drawing.Size(322, 24);
            this.txtEmailRe.TabIndex = 5;
            this.txtEmailRe.UseSystemPasswordChar = false;
            this.txtEmailRe.TextChanged += new System.EventHandler(this.txtEmailRe_TextChanged);
            this.txtEmailRe.Enter += new System.EventHandler(this.txtBoxEmailEliminarPlaceHolder);
            this.txtEmailRe.Leave += new System.EventHandler(this.txtBoxEmailAplicarPlaceHolder);
            // 
            // txtUsuarioRe
            // 
            this.txtUsuarioRe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuarioRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtUsuarioRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.txtUsuarioRe.Location = new System.Drawing.Point(47, 152);
            this.txtUsuarioRe.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.txtUsuarioRe.MinimumSize = new System.Drawing.Size(10, 10);
            this.txtUsuarioRe.Name = "txtUsuarioRe";
            this.txtUsuarioRe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsuarioRe.Size = new System.Drawing.Size(322, 24);
            this.txtUsuarioRe.TabIndex = 1;
            // 
            // lblCuentaCorrienteRe
            // 
            this.lblCuentaCorrienteRe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCuentaCorrienteRe.AutoSize = true;
            this.lblCuentaCorrienteRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblCuentaCorrienteRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaCorrienteRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.lblCuentaCorrienteRe.Location = new System.Drawing.Point(47, 331);
            this.lblCuentaCorrienteRe.Name = "lblCuentaCorrienteRe";
            this.lblCuentaCorrienteRe.Size = new System.Drawing.Size(130, 20);
            this.lblCuentaCorrienteRe.TabIndex = 14;
            this.lblCuentaCorrienteRe.Text = "Cuenta Corriente";
            // 
            // lblDNI_Re
            // 
            this.lblDNI_Re.AutoSize = true;
            this.lblDNI_Re.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblDNI_Re.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI_Re.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.lblDNI_Re.Location = new System.Drawing.Point(47, 197);
            this.lblDNI_Re.Name = "lblDNI_Re";
            this.lblDNI_Re.Size = new System.Drawing.Size(37, 20);
            this.lblDNI_Re.TabIndex = 13;
            this.lblDNI_Re.Text = "DNI";
            // 
            // txtCuentaCorrienteRe
            // 
            this.txtCuentaCorrienteRe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCuentaCorrienteRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtCuentaCorrienteRe.BorderColor = System.Drawing.Color.White;
            this.txtCuentaCorrienteRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaCorrienteRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.txtCuentaCorrienteRe.Location = new System.Drawing.Point(47, 361);
            this.txtCuentaCorrienteRe.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.txtCuentaCorrienteRe.MaxLength = 22;
            this.txtCuentaCorrienteRe.MinimumSize = new System.Drawing.Size(10, 10);
            this.txtCuentaCorrienteRe.Name = "txtCuentaCorrienteRe";
            this.txtCuentaCorrienteRe.OnlyAllowNumbers = false;
            this.txtCuentaCorrienteRe.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtCuentaCorrienteRe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCuentaCorrienteRe.Size = new System.Drawing.Size(322, 24);
            this.txtCuentaCorrienteRe.TabIndex = 7;
            this.txtCuentaCorrienteRe.UseSystemPasswordChar = false;
            this.txtCuentaCorrienteRe.TextChanged += new System.EventHandler(this.txtCuentaCorrienteRe_TextChanged);
            this.txtCuentaCorrienteRe.Enter += new System.EventHandler(this.txtBoxCuentaCorrienteEliminarPlaceHolder);
            this.txtCuentaCorrienteRe.Leave += new System.EventHandler(this.txtBoxCuentaCorrienteAplicarPlaceHolder);
            // 
            // txtDNI_Re
            // 
            this.txtDNI_Re.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDNI_Re.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtDNI_Re.BorderColor = System.Drawing.Color.White;
            this.txtDNI_Re.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI_Re.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.txtDNI_Re.Location = new System.Drawing.Point(47, 223);
            this.txtDNI_Re.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.txtDNI_Re.MaxLength = 9;
            this.txtDNI_Re.MinimumSize = new System.Drawing.Size(10, 10);
            this.txtDNI_Re.Name = "txtDNI_Re";
            this.txtDNI_Re.OnlyAllowNumbers = false;
            this.txtDNI_Re.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtDNI_Re.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDNI_Re.Size = new System.Drawing.Size(322, 24);
            this.txtDNI_Re.TabIndex = 3;
            this.txtDNI_Re.UseSystemPasswordChar = false;
            // 
            // lblContraseñaRe
            // 
            this.lblContraseñaRe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContraseñaRe.AutoSize = true;
            this.lblContraseñaRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblContraseñaRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.lblContraseñaRe.Location = new System.Drawing.Point(413, 331);
            this.lblContraseñaRe.Name = "lblContraseñaRe";
            this.lblContraseñaRe.Size = new System.Drawing.Size(92, 20);
            this.lblContraseñaRe.TabIndex = 22;
            this.lblContraseñaRe.Text = "Contraseña";
            // 
            // lblDirecciónRe
            // 
            this.lblDirecciónRe.AutoSize = true;
            this.lblDirecciónRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblDirecciónRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirecciónRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.lblDirecciónRe.Location = new System.Drawing.Point(413, 264);
            this.lblDirecciónRe.Name = "lblDirecciónRe";
            this.lblDirecciónRe.Size = new System.Drawing.Size(75, 20);
            this.lblDirecciónRe.TabIndex = 21;
            this.lblDirecciónRe.Text = "Dirección";
            // 
            // txtContraseñaRe
            // 
            this.txtContraseñaRe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseñaRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtContraseñaRe.BorderColor = System.Drawing.Color.White;
            this.txtContraseñaRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.txtContraseñaRe.Location = new System.Drawing.Point(413, 361);
            this.txtContraseñaRe.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.txtContraseñaRe.MaxLength = 32767;
            this.txtContraseñaRe.MinimumSize = new System.Drawing.Size(10, 10);
            this.txtContraseñaRe.Name = "txtContraseñaRe";
            this.txtContraseñaRe.OnlyAllowNumbers = false;
            this.txtContraseñaRe.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtContraseñaRe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContraseñaRe.Size = new System.Drawing.Size(318, 24);
            this.txtContraseñaRe.TabIndex = 8;
            this.txtContraseñaRe.UseSystemPasswordChar = true;
            // 
            // btnojoCerradoRe
            // 
            this.btnojoCerradoRe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnojoCerradoRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnojoCerradoRe.FlatAppearance.BorderSize = 0;
            this.btnojoCerradoRe.ForeColor = System.Drawing.Color.Transparent;
            this.btnojoCerradoRe.Image = ((System.Drawing.Image)(resources.GetObject("btnojoCerradoRe.Image")));
            this.btnojoCerradoRe.Location = new System.Drawing.Point(740, 361);
            this.btnojoCerradoRe.Name = "btnojoCerradoRe";
            this.btnojoCerradoRe.Size = new System.Drawing.Size(29, 26);
            this.btnojoCerradoRe.TabIndex = 27;
            this.btnojoCerradoRe.UseVisualStyleBackColor = false;
            this.btnojoCerradoRe.Visible = false;
            this.btnojoCerradoRe.Click += new System.EventHandler(this.btnojoCerradoRe_Click);
            // 
            // txtDireccionRe
            // 
            this.txtDireccionRe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccionRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtDireccionRe.BorderColor = System.Drawing.Color.White;
            this.txtDireccionRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.txtDireccionRe.Location = new System.Drawing.Point(413, 290);
            this.txtDireccionRe.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.txtDireccionRe.MaxLength = 32767;
            this.txtDireccionRe.MinimumSize = new System.Drawing.Size(10, 10);
            this.txtDireccionRe.Name = "txtDireccionRe";
            this.txtDireccionRe.OnlyAllowNumbers = false;
            this.txtDireccionRe.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtDireccionRe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDireccionRe.Size = new System.Drawing.Size(318, 24);
            this.txtDireccionRe.TabIndex = 6;
            this.txtDireccionRe.UseSystemPasswordChar = false;
            // 
            // lblTelefonoRe
            // 
            this.lblTelefonoRe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefonoRe.AutoSize = true;
            this.lblTelefonoRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblTelefonoRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.lblTelefonoRe.Location = new System.Drawing.Point(413, 193);
            this.lblTelefonoRe.Name = "lblTelefonoRe";
            this.lblTelefonoRe.Size = new System.Drawing.Size(71, 20);
            this.lblTelefonoRe.TabIndex = 18;
            this.lblTelefonoRe.Text = "Telefono";
            // 
            // lblApellidosRe
            // 
            this.lblApellidosRe.AutoSize = true;
            this.lblApellidosRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblApellidosRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidosRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.lblApellidosRe.Location = new System.Drawing.Point(413, 126);
            this.lblApellidosRe.Name = "lblApellidosRe";
            this.lblApellidosRe.Size = new System.Drawing.Size(73, 20);
            this.lblApellidosRe.TabIndex = 17;
            this.lblApellidosRe.Text = "Apellidos";
            // 
            // txtTelefonoRe
            // 
            this.txtTelefonoRe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefonoRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtTelefonoRe.BorderColor = System.Drawing.Color.White;
            this.txtTelefonoRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.txtTelefonoRe.Location = new System.Drawing.Point(413, 223);
            this.txtTelefonoRe.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.txtTelefonoRe.MaxLength = 9;
            this.txtTelefonoRe.MinimumSize = new System.Drawing.Size(10, 10);
            this.txtTelefonoRe.Name = "txtTelefonoRe";
            this.txtTelefonoRe.OnlyAllowNumbers = true;
            this.txtTelefonoRe.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtTelefonoRe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelefonoRe.Size = new System.Drawing.Size(318, 24);
            this.txtTelefonoRe.TabIndex = 4;
            this.txtTelefonoRe.UseSystemPasswordChar = false;
            // 
            // txtApellidosRe
            // 
            this.txtApellidosRe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidosRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtApellidosRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.txtApellidosRe.Location = new System.Drawing.Point(413, 152);
            this.txtApellidosRe.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.txtApellidosRe.MinimumSize = new System.Drawing.Size(10, 10);
            this.txtApellidosRe.Name = "txtApellidosRe";
            this.txtApellidosRe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtApellidosRe.Size = new System.Drawing.Size(318, 24);
            this.txtApellidosRe.TabIndex = 2;
            // 
            // imgAtras_Re
            // 
            this.imgAtras_Re.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgAtras_Re.ErrorImage = null;
            this.imgAtras_Re.Image = ((System.Drawing.Image)(resources.GetObject("imgAtras_Re.Image")));
            this.imgAtras_Re.ImageLocation = "0;0";
            this.imgAtras_Re.InitialImage = null;
            this.imgAtras_Re.Location = new System.Drawing.Point(12, 12);
            this.imgAtras_Re.Margin = new System.Windows.Forms.Padding(0);
            this.imgAtras_Re.Name = "imgAtras_Re";
            this.imgAtras_Re.Size = new System.Drawing.Size(70, 56);
            this.imgAtras_Re.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgAtras_Re.TabIndex = 25;
            this.imgAtras_Re.TabStop = false;
            this.imgAtras_Re.Click += new System.EventHandler(this.volverAtras);
            // 
            // btnojo_abiertoRe
            // 
            this.btnojo_abiertoRe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnojo_abiertoRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnojo_abiertoRe.FlatAppearance.BorderSize = 0;
            this.btnojo_abiertoRe.ForeColor = System.Drawing.Color.Transparent;
            this.btnojo_abiertoRe.Image = ((System.Drawing.Image)(resources.GetObject("btnojo_abiertoRe.Image")));
            this.btnojo_abiertoRe.Location = new System.Drawing.Point(740, 361);
            this.btnojo_abiertoRe.Name = "btnojo_abiertoRe";
            this.btnojo_abiertoRe.Size = new System.Drawing.Size(29, 26);
            this.btnojo_abiertoRe.TabIndex = 26;
            this.btnojo_abiertoRe.UseVisualStyleBackColor = false;
            this.btnojo_abiertoRe.Click += new System.EventHandler(this.ojo_abiertoRe_Click);
            // 
            // btnRegistrarRe
            // 
            this.btnRegistrarRe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.btnRegistrarRe.BorderColor = System.Drawing.Color.Gray;
            this.btnRegistrarRe.BorderRadius = 20;
            this.btnRegistrarRe.FillColor = System.Drawing.Color.Transparent;
            this.btnRegistrarRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRegistrarRe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrarRe.Location = new System.Drawing.Point(277, 406);
            this.btnRegistrarRe.Name = "btnRegistrarRe";
            this.btnRegistrarRe.Size = new System.Drawing.Size(92, 40);
            this.btnRegistrarRe.TabIndex = 29;
            this.btnRegistrarRe.Text = "Registrar";
            this.btnRegistrarRe.UseVisualStyleBackColor = false;
            this.btnRegistrarRe.Click += new System.EventHandler(this.btnRegistrarRe_Click);
            this.btnRegistrarRe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnRegistrarRe_KeyDown);
            // 
            // btnBorrarRe
            // 
            this.btnBorrarRe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.btnBorrarRe.BorderColor = System.Drawing.Color.Gray;
            this.btnBorrarRe.BorderRadius = 20;
            this.btnBorrarRe.FillColor = System.Drawing.Color.Transparent;
            this.btnBorrarRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBorrarRe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBorrarRe.Location = new System.Drawing.Point(413, 406);
            this.btnBorrarRe.Name = "btnBorrarRe";
            this.btnBorrarRe.Size = new System.Drawing.Size(92, 40);
            this.btnBorrarRe.TabIndex = 28;
            this.btnBorrarRe.Text = "Borrar";
            this.btnBorrarRe.UseVisualStyleBackColor = false;
            this.btnBorrarRe.Click += new System.EventHandler(this.btnBorrarRe_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(781, 434);
            this.Controls.Add(this.btnRegistrarRe);
            this.Controls.Add(this.btnojo_abiertoRe);
            this.Controls.Add(this.btnojoCerradoRe);
            this.Controls.Add(this.btnBorrarRe);
            this.Controls.Add(this.imgAtras_Re);
            this.Controls.Add(this.lblContraseñaRe);
            this.Controls.Add(this.lblDirecciónRe);
            this.Controls.Add(this.txtContraseñaRe);
            this.Controls.Add(this.txtDireccionRe);
            this.Controls.Add(this.lblTelefonoRe);
            this.Controls.Add(this.lblApellidosRe);
            this.Controls.Add(this.txtTelefonoRe);
            this.Controls.Add(this.txtApellidosRe);
            this.Controls.Add(this.lblCuentaCorrienteRe);
            this.Controls.Add(this.lblDNI_Re);
            this.Controls.Add(this.txtCuentaCorrienteRe);
            this.Controls.Add(this.txtDNI_Re);
            this.Controls.Add(this.lblEmailRe);
            this.Controls.Add(this.lblNombreRe);
            this.Controls.Add(this.txtEmailRe);
            this.Controls.Add(this.txtUsuarioRe);
            this.Controls.Add(this.imgKAE_Re);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(797, 489);
            this.MinimumSize = new System.Drawing.Size(797, 473);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registro_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.imgKAE_Re)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAtras_Re)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmailRe;
        private System.Windows.Forms.Label lblNombreRe;
        private ColorBorderTextBox txtEmailRe;
        private System.Windows.Forms.TextBox txtUsuarioRe;
        private System.Windows.Forms.Label lblCuentaCorrienteRe;
        private System.Windows.Forms.Label lblDNI_Re;
        private ColorBorderTextBox txtCuentaCorrienteRe;
        private ColorBorderTextBox txtDNI_Re;
        private System.Windows.Forms.Label lblContraseñaRe;
        private System.Windows.Forms.Label lblDirecciónRe;
        private ColorBorderTextBox txtContraseñaRe;
        private ColorBorderTextBox txtDireccionRe;
        private System.Windows.Forms.Label lblTelefonoRe;
        private System.Windows.Forms.Label lblApellidosRe;
        private ColorBorderTextBox txtTelefonoRe;
        private System.Windows.Forms.TextBox txtApellidosRe;
        private RoundedButton btnBorrarRe;
        private System.Windows.Forms.PictureBox imgAtras_Re;
        private System.Windows.Forms.Button btnojo_abiertoRe;
        private System.Windows.Forms.Button btnojoCerradoRe;
        private RoundedButton btnRegistrarRe;
        private System.Windows.Forms.PictureBox imgKAE_Re;
    }
}