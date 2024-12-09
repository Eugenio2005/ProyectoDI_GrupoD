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
            this.lblCuentaCorrienteRe = new System.Windows.Forms.Label();
            this.lblDNI_Re = new System.Windows.Forms.Label();
            this.lblContraseñaRe = new System.Windows.Forms.Label();
            this.lblDirecciónRe = new System.Windows.Forms.Label();
            this.lblTelefonoRe = new System.Windows.Forms.Label();
            this.lblApellidosRe = new System.Windows.Forms.Label();
            this.btnojo_abiertoRe = new System.Windows.Forms.Button();
            this.btnojoCerradoRe = new System.Windows.Forms.Button();
            this.imgAtras_Re = new System.Windows.Forms.PictureBox();
            this.txtApellidosRe = new ProyectoDI_GrupoD.TextBoxRedondeado();
            this.txtUsuarioRe = new ProyectoDI_GrupoD.TextBoxRedondeado();
            this.btnRegistrarRe = new ProyectoDI_GrupoD.RoundedButton();
            this.btnBorrarRe = new ProyectoDI_GrupoD.RoundedButton();
            this.txtDNI_Re = new ProyectoDI_GrupoD.TextBoxRedondeado();
            this.txtTelefonoRe = new ProyectoDI_GrupoD.TextBoxRedondeado();
            this.txtEmailRe = new ProyectoDI_GrupoD.TextBoxRedondeado();
            this.txtDireccionRe = new ProyectoDI_GrupoD.TextBoxRedondeado();
            this.txtCuentaCorrienteRe = new ProyectoDI_GrupoD.TextBoxRedondeado();
            this.txtContraseñaRe = new ProyectoDI_GrupoD.TextBoxRedondeado();
            this.textBoxRedondeado1 = new ProyectoDI_GrupoD.TextBoxRedondeado();
            this.lblVolverContraseña = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgKAE_Re)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAtras_Re)).BeginInit();
            this.SuspendLayout();
            // 
            // imgKAE_Re
            // 
            this.imgKAE_Re.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgKAE_Re.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.imgKAE_Re.ErrorImage = global::ProyectoDI_GrupoD.Properties.Resources.KAEGYM1;
            this.imgKAE_Re.Image = global::ProyectoDI_GrupoD.Properties.Resources.KAE_GYM_novo_re;
            this.imgKAE_Re.Location = new System.Drawing.Point(221, -11);
            this.imgKAE_Re.Name = "imgKAE_Re";
            this.imgKAE_Re.Size = new System.Drawing.Size(660, 161);
            this.imgKAE_Re.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgKAE_Re.TabIndex = 1;
            this.imgKAE_Re.TabStop = false;
            // 
            // lblEmailRe
            // 
            this.lblEmailRe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmailRe.AutoSize = true;
            this.lblEmailRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.lblEmailRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(125)))), ((int)(((byte)(68)))));
            this.lblEmailRe.Location = new System.Drawing.Point(37, 218);
            this.lblEmailRe.Name = "lblEmailRe";
            this.lblEmailRe.Size = new System.Drawing.Size(57, 24);
            this.lblEmailRe.TabIndex = 10;
            this.lblEmailRe.Text = "Email";
            // 
            // lblNombreRe
            // 
            this.lblNombreRe.AutoSize = true;
            this.lblNombreRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.lblNombreRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(125)))), ((int)(((byte)(68)))));
            this.lblNombreRe.Location = new System.Drawing.Point(29, 144);
            this.lblNombreRe.Name = "lblNombreRe";
            this.lblNombreRe.Size = new System.Drawing.Size(79, 24);
            this.lblNombreRe.TabIndex = 9;
            this.lblNombreRe.Text = "Nombre";
            // 
            // lblCuentaCorrienteRe
            // 
            this.lblCuentaCorrienteRe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCuentaCorrienteRe.AutoSize = true;
            this.lblCuentaCorrienteRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.lblCuentaCorrienteRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaCorrienteRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(125)))), ((int)(((byte)(68)))));
            this.lblCuentaCorrienteRe.Location = new System.Drawing.Point(29, 295);
            this.lblCuentaCorrienteRe.Name = "lblCuentaCorrienteRe";
            this.lblCuentaCorrienteRe.Size = new System.Drawing.Size(152, 24);
            this.lblCuentaCorrienteRe.TabIndex = 14;
            this.lblCuentaCorrienteRe.Text = "Cuenta Corriente";
            // 
            // lblDNI_Re
            // 
            this.lblDNI_Re.AutoSize = true;
            this.lblDNI_Re.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.lblDNI_Re.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI_Re.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(125)))), ((int)(((byte)(68)))));
            this.lblDNI_Re.Location = new System.Drawing.Point(759, 144);
            this.lblDNI_Re.Name = "lblDNI_Re";
            this.lblDNI_Re.Size = new System.Drawing.Size(41, 24);
            this.lblDNI_Re.TabIndex = 13;
            this.lblDNI_Re.Text = "DNI";
            // 
            // lblContraseñaRe
            // 
            this.lblContraseñaRe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContraseñaRe.AutoSize = true;
            this.lblContraseñaRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.lblContraseñaRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(125)))), ((int)(((byte)(68)))));
            this.lblContraseñaRe.Location = new System.Drawing.Point(395, 295);
            this.lblContraseñaRe.Name = "lblContraseñaRe";
            this.lblContraseñaRe.Size = new System.Drawing.Size(106, 24);
            this.lblContraseñaRe.TabIndex = 22;
            this.lblContraseñaRe.Text = "Contraseña";
            // 
            // lblDirecciónRe
            // 
            this.lblDirecciónRe.AutoSize = true;
            this.lblDirecciónRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.lblDirecciónRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirecciónRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(125)))), ((int)(((byte)(68)))));
            this.lblDirecciónRe.Location = new System.Drawing.Point(759, 221);
            this.lblDirecciónRe.Name = "lblDirecciónRe";
            this.lblDirecciónRe.Size = new System.Drawing.Size(90, 24);
            this.lblDirecciónRe.TabIndex = 21;
            this.lblDirecciónRe.Text = "Dirección";
            // 
            // lblTelefonoRe
            // 
            this.lblTelefonoRe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefonoRe.AutoSize = true;
            this.lblTelefonoRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.lblTelefonoRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(125)))), ((int)(((byte)(68)))));
            this.lblTelefonoRe.Location = new System.Drawing.Point(395, 217);
            this.lblTelefonoRe.Name = "lblTelefonoRe";
            this.lblTelefonoRe.Size = new System.Drawing.Size(85, 24);
            this.lblTelefonoRe.TabIndex = 18;
            this.lblTelefonoRe.Text = "Telefono";
            // 
            // lblApellidosRe
            // 
            this.lblApellidosRe.AutoSize = true;
            this.lblApellidosRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.lblApellidosRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidosRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(125)))), ((int)(((byte)(68)))));
            this.lblApellidosRe.Location = new System.Drawing.Point(395, 144);
            this.lblApellidosRe.Name = "lblApellidosRe";
            this.lblApellidosRe.Size = new System.Drawing.Size(88, 24);
            this.lblApellidosRe.TabIndex = 17;
            this.lblApellidosRe.Text = "Apellidos";
            // 
            // btnojo_abiertoRe
            // 
            this.btnojo_abiertoRe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnojo_abiertoRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.btnojo_abiertoRe.FlatAppearance.BorderSize = 0;
            this.btnojo_abiertoRe.ForeColor = System.Drawing.Color.Transparent;
            this.btnojo_abiertoRe.Image = ((System.Drawing.Image)(resources.GetObject("btnojo_abiertoRe.Image")));
            this.btnojo_abiertoRe.Location = new System.Drawing.Point(681, 327);
            this.btnojo_abiertoRe.Name = "btnojo_abiertoRe";
            this.btnojo_abiertoRe.Size = new System.Drawing.Size(30, 26);
            this.btnojo_abiertoRe.TabIndex = 26;
            this.btnojo_abiertoRe.UseVisualStyleBackColor = false;
            this.btnojo_abiertoRe.Click += new System.EventHandler(this.ojo_abiertoRe_Click);
            // 
            // btnojoCerradoRe
            // 
            this.btnojoCerradoRe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnojoCerradoRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.btnojoCerradoRe.FlatAppearance.BorderSize = 0;
            this.btnojoCerradoRe.ForeColor = System.Drawing.Color.Transparent;
            this.btnojoCerradoRe.Image = ((System.Drawing.Image)(resources.GetObject("btnojoCerradoRe.Image")));
            this.btnojoCerradoRe.Location = new System.Drawing.Point(681, 327);
            this.btnojoCerradoRe.Name = "btnojoCerradoRe";
            this.btnojoCerradoRe.Size = new System.Drawing.Size(30, 26);
            this.btnojoCerradoRe.TabIndex = 27;
            this.btnojoCerradoRe.UseVisualStyleBackColor = false;
            this.btnojoCerradoRe.Visible = false;
            this.btnojoCerradoRe.Click += new System.EventHandler(this.btnojoCerradoRe_Click);
            // 
            // imgAtras_Re
            // 
            this.imgAtras_Re.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAtras_Re.ErrorImage = global::ProyectoDI_GrupoD.Properties.Resources.atrasSinFondo;
            this.imgAtras_Re.ImageLocation = "0;0";
            this.imgAtras_Re.InitialImage = null;
            this.imgAtras_Re.Location = new System.Drawing.Point(9, 12);
            this.imgAtras_Re.Margin = new System.Windows.Forms.Padding(0);
            this.imgAtras_Re.Name = "imgAtras_Re";
            this.imgAtras_Re.Size = new System.Drawing.Size(70, 56);
            this.imgAtras_Re.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgAtras_Re.TabIndex = 30;
            this.imgAtras_Re.TabStop = false;
            this.imgAtras_Re.Click += new System.EventHandler(this.volverAtras);
            // 
            // txtApellidosRe
            // 
            this.txtApellidosRe.BackColor = System.Drawing.Color.White;
            this.txtApellidosRe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.txtApellidosRe.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtApellidosRe.BorderRadius = 15;
            this.txtApellidosRe.BorderSize = 2;
            this.txtApellidosRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosRe.Location = new System.Drawing.Point(399, 171);
            this.txtApellidosRe.Name = "txtApellidosRe";
            this.txtApellidosRe.Padding = new System.Windows.Forms.Padding(10);
            this.txtApellidosRe.Size = new System.Drawing.Size(322, 33);
            this.txtApellidosRe.TabIndex = 32;
            // 
            // txtUsuarioRe
            // 
            this.txtUsuarioRe.BackColor = System.Drawing.Color.White;
            this.txtUsuarioRe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.txtUsuarioRe.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtUsuarioRe.BorderRadius = 15;
            this.txtUsuarioRe.BorderSize = 2;
            this.txtUsuarioRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioRe.Location = new System.Drawing.Point(33, 171);
            this.txtUsuarioRe.Name = "txtUsuarioRe";
            this.txtUsuarioRe.Padding = new System.Windows.Forms.Padding(10);
            this.txtUsuarioRe.Size = new System.Drawing.Size(322, 33);
            this.txtUsuarioRe.TabIndex = 31;
            // 
            // btnRegistrarRe
            // 
            this.btnRegistrarRe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrarRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.btnRegistrarRe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.btnRegistrarRe.BorderRadius = 20;
            this.btnRegistrarRe.FillColor = System.Drawing.Color.Transparent;
            this.btnRegistrarRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegistrarRe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrarRe.Location = new System.Drawing.Point(438, 405);
            this.btnRegistrarRe.Name = "btnRegistrarRe";
            this.btnRegistrarRe.Size = new System.Drawing.Size(100, 40);
            this.btnRegistrarRe.TabIndex = 29;
            this.btnRegistrarRe.Text = "Registrar";
            this.btnRegistrarRe.UseVisualStyleBackColor = false;
            this.btnRegistrarRe.Click += new System.EventHandler(this.btnRegistrarRe_Click);
            this.btnRegistrarRe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnRegistrarRe_KeyDown);
            // 
            // btnBorrarRe
            // 
            this.btnBorrarRe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrarRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.btnBorrarRe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.btnBorrarRe.BorderRadius = 20;
            this.btnBorrarRe.FillColor = System.Drawing.Color.Transparent;
            this.btnBorrarRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBorrarRe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBorrarRe.Location = new System.Drawing.Point(581, 405);
            this.btnBorrarRe.Name = "btnBorrarRe";
            this.btnBorrarRe.Size = new System.Drawing.Size(102, 40);
            this.btnBorrarRe.TabIndex = 28;
            this.btnBorrarRe.Text = "Borrar";
            this.btnBorrarRe.UseVisualStyleBackColor = false;
            this.btnBorrarRe.Click += new System.EventHandler(this.btnBorrarRe_Click);
            // 
            // txtDNI_Re
            // 
            this.txtDNI_Re.BackColor = System.Drawing.Color.White;
            this.txtDNI_Re.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.txtDNI_Re.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtDNI_Re.BorderRadius = 15;
            this.txtDNI_Re.BorderSize = 2;
            this.txtDNI_Re.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI_Re.Location = new System.Drawing.Point(759, 171);
            this.txtDNI_Re.Name = "txtDNI_Re";
            this.txtDNI_Re.Padding = new System.Windows.Forms.Padding(10);
            this.txtDNI_Re.Size = new System.Drawing.Size(322, 33);
            this.txtDNI_Re.TabIndex = 33;
            this.txtDNI_Re.UseSystemPasswordChar = false;
            // 
            // txtTelefonoRe
            // 
            this.txtTelefonoRe.BackColor = System.Drawing.Color.White;
            this.txtTelefonoRe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.txtTelefonoRe.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtTelefonoRe.BorderRadius = 15;
            this.txtTelefonoRe.BorderSize = 2;
            this.txtTelefonoRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoRe.Location = new System.Drawing.Point(399, 248);
            this.txtTelefonoRe.Name = "txtTelefonoRe";
            this.txtTelefonoRe.Padding = new System.Windows.Forms.Padding(10);
            this.txtTelefonoRe.Size = new System.Drawing.Size(322, 33);
            this.txtTelefonoRe.TabIndex = 34;
            this.txtTelefonoRe.UseSystemPasswordChar = false;
            // 
            // txtEmailRe
            // 
            this.txtEmailRe.BackColor = System.Drawing.Color.White;
            this.txtEmailRe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.txtEmailRe.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtEmailRe.BorderRadius = 15;
            this.txtEmailRe.BorderSize = 2;
            this.txtEmailRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailRe.Location = new System.Drawing.Point(33, 248);
            this.txtEmailRe.Name = "txtEmailRe";
            this.txtEmailRe.Padding = new System.Windows.Forms.Padding(10);
            this.txtEmailRe.Size = new System.Drawing.Size(322, 33);
            this.txtEmailRe.TabIndex = 35;
            this.txtEmailRe.UseSystemPasswordChar = false;
            // 
            // txtDireccionRe
            // 
            this.txtDireccionRe.BackColor = System.Drawing.Color.White;
            this.txtDireccionRe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.txtDireccionRe.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtDireccionRe.BorderRadius = 15;
            this.txtDireccionRe.BorderSize = 2;
            this.txtDireccionRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionRe.Location = new System.Drawing.Point(759, 248);
            this.txtDireccionRe.Name = "txtDireccionRe";
            this.txtDireccionRe.Padding = new System.Windows.Forms.Padding(10);
            this.txtDireccionRe.Size = new System.Drawing.Size(322, 33);
            this.txtDireccionRe.TabIndex = 36;
            this.txtDireccionRe.UseSystemPasswordChar = false;
            // 
            // txtCuentaCorrienteRe
            // 
            this.txtCuentaCorrienteRe.BackColor = System.Drawing.Color.White;
            this.txtCuentaCorrienteRe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.txtCuentaCorrienteRe.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtCuentaCorrienteRe.BorderRadius = 15;
            this.txtCuentaCorrienteRe.BorderSize = 2;
            this.txtCuentaCorrienteRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaCorrienteRe.Location = new System.Drawing.Point(33, 323);
            this.txtCuentaCorrienteRe.Name = "txtCuentaCorrienteRe";
            this.txtCuentaCorrienteRe.Padding = new System.Windows.Forms.Padding(10);
            this.txtCuentaCorrienteRe.Size = new System.Drawing.Size(322, 33);
            this.txtCuentaCorrienteRe.TabIndex = 37;
            this.txtCuentaCorrienteRe.UseSystemPasswordChar = false;
            // 
            // txtContraseñaRe
            // 
            this.txtContraseñaRe.BackColor = System.Drawing.Color.White;
            this.txtContraseñaRe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.txtContraseñaRe.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtContraseñaRe.BorderRadius = 15;
            this.txtContraseñaRe.BorderSize = 2;
            this.txtContraseñaRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaRe.Location = new System.Drawing.Point(399, 323);
            this.txtContraseñaRe.Name = "txtContraseñaRe";
            this.txtContraseñaRe.Padding = new System.Windows.Forms.Padding(10);
            this.txtContraseñaRe.Size = new System.Drawing.Size(322, 33);
            this.txtContraseñaRe.TabIndex = 38;
            this.txtContraseñaRe.UseSystemPasswordChar = false;
            // 
            // textBoxRedondeado1
            // 
            this.textBoxRedondeado1.BackColor = System.Drawing.Color.White;
            this.textBoxRedondeado1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.textBoxRedondeado1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.textBoxRedondeado1.BorderRadius = 15;
            this.textBoxRedondeado1.BorderSize = 2;
            this.textBoxRedondeado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRedondeado1.Location = new System.Drawing.Point(759, 323);
            this.textBoxRedondeado1.Name = "textBoxRedondeado1";
            this.textBoxRedondeado1.Padding = new System.Windows.Forms.Padding(10);
            this.textBoxRedondeado1.Size = new System.Drawing.Size(322, 33);
            this.textBoxRedondeado1.TabIndex = 39;
            this.textBoxRedondeado1.UseSystemPasswordChar = false;
            // 
            // lblVolverContraseña
            // 
            this.lblVolverContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVolverContraseña.AutoSize = true;
            this.lblVolverContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.lblVolverContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolverContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(125)))), ((int)(((byte)(68)))));
            this.lblVolverContraseña.Location = new System.Drawing.Point(759, 296);
            this.lblVolverContraseña.Name = "lblVolverContraseña";
            this.lblVolverContraseña.Size = new System.Drawing.Size(166, 24);
            this.lblVolverContraseña.TabIndex = 40;
            this.lblVolverContraseña.Text = "Validar contraseña";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1121, 460);
            this.Controls.Add(this.btnojo_abiertoRe);
            this.Controls.Add(this.btnojoCerradoRe);
            this.Controls.Add(this.lblVolverContraseña);
            this.Controls.Add(this.textBoxRedondeado1);
            this.Controls.Add(this.txtContraseñaRe);
            this.Controls.Add(this.txtCuentaCorrienteRe);
            this.Controls.Add(this.txtDireccionRe);
            this.Controls.Add(this.txtEmailRe);
            this.Controls.Add(this.txtTelefonoRe);
            this.Controls.Add(this.txtDNI_Re);
            this.Controls.Add(this.txtApellidosRe);
            this.Controls.Add(this.txtUsuarioRe);
            this.Controls.Add(this.imgAtras_Re);
            this.Controls.Add(this.btnRegistrarRe);
            this.Controls.Add(this.btnBorrarRe);
            this.Controls.Add(this.lblContraseñaRe);
            this.Controls.Add(this.lblDirecciónRe);
            this.Controls.Add(this.lblTelefonoRe);
            this.Controls.Add(this.lblApellidosRe);
            this.Controls.Add(this.lblCuentaCorrienteRe);
            this.Controls.Add(this.lblDNI_Re);
            this.Controls.Add(this.lblEmailRe);
            this.Controls.Add(this.lblNombreRe);
            this.Controls.Add(this.imgKAE_Re);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label lblCuentaCorrienteRe;
        private System.Windows.Forms.Label lblDNI_Re;
        private System.Windows.Forms.Label lblContraseñaRe;
        private System.Windows.Forms.Label lblDirecciónRe;
        private System.Windows.Forms.Label lblTelefonoRe;
        private System.Windows.Forms.Label lblApellidosRe;
        private RoundedButton btnBorrarRe;
        private System.Windows.Forms.Button btnojo_abiertoRe;
        private System.Windows.Forms.Button btnojoCerradoRe;
        private RoundedButton btnRegistrarRe;
        private System.Windows.Forms.PictureBox imgKAE_Re;
        private System.Windows.Forms.PictureBox imgAtras_Re;
        private TextBoxRedondeado txtUsuarioRe;
        private TextBoxRedondeado txtApellidosRe;
        private TextBoxRedondeado txtDNI_Re;
        private TextBoxRedondeado txtTelefonoRe;
        private TextBoxRedondeado txtEmailRe;
        private TextBoxRedondeado txtDireccionRe;
        private TextBoxRedondeado txtCuentaCorrienteRe;
        private TextBoxRedondeado txtContraseñaRe;
        private TextBoxRedondeado textBoxRedondeado1;
        private System.Windows.Forms.Label lblVolverContraseña;
    }
}