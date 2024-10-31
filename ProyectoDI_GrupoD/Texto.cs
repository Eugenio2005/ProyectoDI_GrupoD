using System;
using System.Drawing;
using System.Windows.Forms;


namespace ProyectoDI_GrupoD
{
    public class ColorBorderTextBox : TextBox
    {
        public Color BorderColor { get; set; } = Color.Red;

        protected override void OnPaint(PaintEventArgs e)
        {
            // Dibuja el borde
            using (Pen pen = new Pen(BorderColor, 2)) // 2 es el grosor del borde
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate(); // Redibuja el control cuando se redimensiona
        }
    }
}

