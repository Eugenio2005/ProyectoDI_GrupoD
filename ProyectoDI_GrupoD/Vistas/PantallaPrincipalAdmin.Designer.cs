﻿using System;

namespace ProyectoDI_GrupoD
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipalAdmin));
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.ctxtmsCerrarSesion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSuperiorDarDeAltaMonitor = new System.Windows.Forms.Panel();
            this.lblTextoSuperior = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.imgAtras_Re = new System.Windows.Forms.PictureBox();
            this.imageButtonTop5 = new ProyectoDI_GrupoD.ImageButton();
            this.NombreUsuario = new ProyectoDI_GrupoD.ImageButton();
            this.imgButtonListarActividad = new ProyectoDI_GrupoD.ImageButton();
            this.imgButtonDarAltaActividad = new ProyectoDI_GrupoD.ImageButton();
            this.imgBtnDarAltaMonitor = new ProyectoDI_GrupoD.ImageButton();
            this.pnlBotones.SuspendLayout();
            this.ctxtmsCerrarSesion.SuspendLayout();
            this.pnlSuperiorDarDeAltaMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAtras_Re)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(216)))), ((int)(((byte)(207)))));
            this.pnlBotones.Controls.Add(this.imageButtonTop5);
            this.pnlBotones.Controls.Add(this.NombreUsuario);
            this.pnlBotones.Controls.Add(this.imgButtonListarActividad);
            this.pnlBotones.Controls.Add(this.imgButtonDarAltaActividad);
            this.pnlBotones.Controls.Add(this.imgBtnDarAltaMonitor);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(400, 674);
            this.pnlBotones.TabIndex = 6;
            // 
            // ctxtmsCerrarSesion
            // 
            this.ctxtmsCerrarSesion.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ctxtmsCerrarSesion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem});
            this.ctxtmsCerrarSesion.Name = "ctxtmsCerrarSesion";
            this.ctxtmsCerrarSesion.Size = new System.Drawing.Size(166, 28);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // pnlSuperiorDarDeAltaMonitor
            // 
            this.pnlSuperiorDarDeAltaMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(156)))), ((int)(((byte)(99)))));
            this.pnlSuperiorDarDeAltaMonitor.Controls.Add(this.imgAtras_Re);
            this.pnlSuperiorDarDeAltaMonitor.Controls.Add(this.lblTextoSuperior);
            this.pnlSuperiorDarDeAltaMonitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperiorDarDeAltaMonitor.Location = new System.Drawing.Point(400, 0);
            this.pnlSuperiorDarDeAltaMonitor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSuperiorDarDeAltaMonitor.Name = "pnlSuperiorDarDeAltaMonitor";
            this.pnlSuperiorDarDeAltaMonitor.Size = new System.Drawing.Size(883, 123);
            this.pnlSuperiorDarDeAltaMonitor.TabIndex = 8;
            // 
            // lblTextoSuperior
            // 
            this.lblTextoSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextoSuperior.AutoSize = true;
            this.lblTextoSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoSuperior.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTextoSuperior.Location = new System.Drawing.Point(397, 36);
            this.lblTextoSuperior.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextoSuperior.Name = "lblTextoSuperior";
            this.lblTextoSuperior.Size = new System.Drawing.Size(151, 54);
            this.lblTextoSuperior.TabIndex = 1;
            this.lblTextoSuperior.Text = "---  ---";
            this.lblTextoSuperior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(400, 123);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(883, 551);
            this.pnlPrincipal.TabIndex = 9;
            // 
            // imgAtras_Re
            // 
            this.imgAtras_Re.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAtras_Re.ErrorImage = global::ProyectoDI_GrupoD.Properties.Resources.atrasSinFondo;
            this.imgAtras_Re.ImageLocation = "0;0";
            this.imgAtras_Re.InitialImage = null;
            this.imgAtras_Re.Location = new System.Drawing.Point(31, 21);
            this.imgAtras_Re.Margin = new System.Windows.Forms.Padding(0);
            this.imgAtras_Re.Name = "imgAtras_Re";
            this.imgAtras_Re.Size = new System.Drawing.Size(93, 69);
            this.imgAtras_Re.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgAtras_Re.TabIndex = 26;
            this.imgAtras_Re.TabStop = false;
            this.imgAtras_Re.Click += new System.EventHandler(this.imgAtras_Re_Click);
            // 
            // imageButtonTop5
            // 
            this.imageButtonTop5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.imageButtonTop5.ButtonImage = global::ProyectoDI_GrupoD.Properties.Resources.icons8_gráfico_combinado_50__1_;
            this.imageButtonTop5.ButtonText = "TOP 5 ACTIVIDADES";
            this.imageButtonTop5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageButtonTop5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageButtonTop5.ForeColor = System.Drawing.Color.White;
            this.imageButtonTop5.HoverBackColor = System.Drawing.Color.LightGray;
            this.imageButtonTop5.Location = new System.Drawing.Point(0, 306);
            this.imageButtonTop5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.imageButtonTop5.Name = "imageButtonTop5";
            this.imageButtonTop5.Size = new System.Drawing.Size(400, 62);
            this.imageButtonTop5.TabIndex = 6;
            this.imageButtonTop5.Load += new System.EventHandler(this.imageButton1_Load);
            this.imageButtonTop5.Click += new System.EventHandler(this.imageButtonTop5_Click);
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(71)))), ((int)(((byte)(24)))));
            this.NombreUsuario.ButtonImage = ((System.Drawing.Image)(resources.GetObject("NombreUsuario.ButtonImage")));
            this.NombreUsuario.ButtonText = "Nombre de usuario";
            this.NombreUsuario.ContextMenuStrip = this.ctxtmsCerrarSesion;
            this.NombreUsuario.Cursor = System.Windows.Forms.Cursors.Cross;
            this.NombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUsuario.ForeColor = System.Drawing.Color.Yellow;
            this.NombreUsuario.HoverBackColor = System.Drawing.Color.LightGray;
            this.NombreUsuario.Location = new System.Drawing.Point(0, 17);
            this.NombreUsuario.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(400, 62);
            this.NombreUsuario.TabIndex = 2;
            // 
            // imgButtonListarActividad
            // 
            this.imgButtonListarActividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.imgButtonListarActividad.ButtonImage = global::ProyectoDI_GrupoD.Properties.Resources.ListarActividadesBlanco;
            this.imgButtonListarActividad.ButtonText = "LISTAR ACTIVIDADES DISPONIBLES";
            this.imgButtonListarActividad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgButtonListarActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgButtonListarActividad.ForeColor = System.Drawing.Color.White;
            this.imgButtonListarActividad.HoverBackColor = System.Drawing.Color.LightGray;
            this.imgButtonListarActividad.Location = new System.Drawing.Point(0, 239);
            this.imgButtonListarActividad.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.imgButtonListarActividad.Name = "imgButtonListarActividad";
            this.imgButtonListarActividad.Size = new System.Drawing.Size(400, 62);
            this.imgButtonListarActividad.TabIndex = 3;
            this.imgButtonListarActividad.Click += new System.EventHandler(this.imgButtonListarActividad_Click);
            // 
            // imgButtonDarAltaActividad
            // 
            this.imgButtonDarAltaActividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(71)))), ((int)(((byte)(24)))));
            this.imgButtonDarAltaActividad.ButtonImage = global::ProyectoDI_GrupoD.Properties.Resources.AltaUnaActividadBlanco;
            this.imgButtonDarAltaActividad.ButtonText = "DAR DE ALTA UNA ACTIVIDAD";
            this.imgButtonDarAltaActividad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgButtonDarAltaActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgButtonDarAltaActividad.ForeColor = System.Drawing.Color.White;
            this.imgButtonDarAltaActividad.HoverBackColor = System.Drawing.Color.LightGray;
            this.imgButtonDarAltaActividad.Location = new System.Drawing.Point(0, 165);
            this.imgButtonDarAltaActividad.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.imgButtonDarAltaActividad.Name = "imgButtonDarAltaActividad";
            this.imgButtonDarAltaActividad.Size = new System.Drawing.Size(400, 62);
            this.imgButtonDarAltaActividad.TabIndex = 4;
            this.imgButtonDarAltaActividad.Click += new System.EventHandler(this.imgButtonDarAltaActividad_Click);
            // 
            // imgBtnDarAltaMonitor
            // 
            this.imgBtnDarAltaMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(71)))), ((int)(((byte)(24)))));
            this.imgBtnDarAltaMonitor.ButtonImage = global::ProyectoDI_GrupoD.Properties.Resources.AltaMonitorBlanco;
            this.imgBtnDarAltaMonitor.ButtonText = "DAR DE ALTA UN MONITOR";
            this.imgBtnDarAltaMonitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgBtnDarAltaMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgBtnDarAltaMonitor.ForeColor = System.Drawing.Color.White;
            this.imgBtnDarAltaMonitor.HoverBackColor = System.Drawing.Color.LightGray;
            this.imgBtnDarAltaMonitor.Location = new System.Drawing.Point(0, 91);
            this.imgBtnDarAltaMonitor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.imgBtnDarAltaMonitor.Name = "imgBtnDarAltaMonitor";
            this.imgBtnDarAltaMonitor.Size = new System.Drawing.Size(400, 62);
            this.imgBtnDarAltaMonitor.TabIndex = 5;
            this.imgBtnDarAltaMonitor.Click += new System.EventHandler(this.imgBtnDarAltaMonitor_Click);
            // 
            // PantallaPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1283, 674);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlSuperiorDarDeAltaMonitor);
            this.Controls.Add(this.pnlBotones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PantallaPrincipalAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "K A E GYM ADMIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PantallaPrincipal_FormClosing);
            this.pnlBotones.ResumeLayout(false);
            this.ctxtmsCerrarSesion.ResumeLayout(false);
            this.pnlSuperiorDarDeAltaMonitor.ResumeLayout(false);
            this.pnlSuperiorDarDeAltaMonitor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAtras_Re)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ImageButton NombreUsuario;
        private ImageButton imgButtonListarActividad;
        private ImageButton imgButtonDarAltaActividad;
        private ImageButton imgBtnDarAltaMonitor;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Panel pnlSuperiorDarDeAltaMonitor;
        private System.Windows.Forms.Label lblTextoSuperior;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.PictureBox imgAtras_Re;
        private System.Windows.Forms.ContextMenuStrip ctxtmsCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ImageButton imageButtonTop5;
    }
}