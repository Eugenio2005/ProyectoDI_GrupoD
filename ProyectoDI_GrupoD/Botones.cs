using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProyectoDI_GrupoD
{
    public class RoundedButton : Button
    {
        private int borderRadius = 20;  // Radio del borde redondeado
        private Color borderColor = Color.Gray;  // Color del borde
        private Color fillColor = Color.Transparent;  // Fondo transparente

        public RoundedButton()
        {
            this.ForeColor = SystemColors.ControlText;
            this.BackColor = Color.FromArgb(202, 224, 212);
        }

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();  // Redibuja el botón
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public Color FillColor
        {
            get { return fillColor; }
            set
            {
                fillColor = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Creamos el boton y sus caracteristicas que va a tener y hemos implementado 
        /// </summary>
        /// <param name="pevent"></param>
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Crear el borde redondeado
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -1, -1);

            int smoothSize = 2; // Ajusta el suavizado

            using (GraphicsPath pathSurface = GetRoundedPath(rectSurface, borderRadius))
            using (GraphicsPath pathBorder = GetRoundedPath(rectBorder, borderRadius - smoothSize))
            using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
            using (Pen penBorder = new Pen(borderColor, 1.75f))  // Borde sutil
            {
                // Relleno del botón con transparencia
                this.Region = new Region(pathSurface);
                pevent.Graphics.FillPath(new SolidBrush(fillColor), pathSurface);

                // Dibujar el borde suave
                pevent.Graphics.DrawPath(penSurface, pathSurface);
                pevent.Graphics.DrawPath(penBorder, pathBorder);
            }
        }
        /// <summary>
        /// hacemos que el boton se haga redondeado
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
