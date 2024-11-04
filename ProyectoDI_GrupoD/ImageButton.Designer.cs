﻿using System.Drawing;
using System.Windows.Forms;
using System;

namespace ProyectoDI_GrupoD
{
    public partial class ImageButton : UserControl
    {
        // Propiedad para la imagen
        public Image ButtonImage
        {
            get => pictureBox.Image;
            set => pictureBox.Image = value;
        }

        // Propiedad para el texto
        public string ButtonText
        {
            get => label.Text;
            set => label.Text = value;
        }

        // Propiedad para el color de fondo cuando el mouse pasa por encima
        private Color _hoverBackColor = Color.LightGray;
        public Color HoverBackColor
        {
            get => _hoverBackColor;
            set => _hoverBackColor = value;
        }

        private void ImageButton_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = HoverBackColor;
        }

        private void ImageButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Sienna;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(54, 35);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Sienna;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(60, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(46, 17);
            this.label.TabIndex = 1;
            this.label.Text = "label1";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBox);
            this.Name = "ImageButton";
            this.Size = new System.Drawing.Size(229, 35);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private PictureBox pictureBox;
        private Label label;
    }
}
