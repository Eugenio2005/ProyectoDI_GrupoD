using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoDI_GrupoD
{
    public partial class TextBoxRedondeado : UserControl
    {
        // Fields
        private Color borderColor = Color.MediumSlateBlue;
        private Color borderFocusColor = Color.HotPink;
        private int borderSize = 2;
        private int borderRadius = 15;
        private bool isFocused = false;
        private bool useSystemPasswordChar;
        private string placeholderText;


        // Constructor
        public TextBoxRedondeado()
        {
            textBox1 = new System.Windows.Forms.TextBox();
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.TextChanged += TextBox1_TextChanged;
            textBox1.Enter += TextBox1_Enter;
            textBox1.Leave += TextBox1_Leave;
            textBox1.MouseEnter += TextBox1_MouseEnter;
            textBox1.MouseLeave += TextBox1_MouseLeave;
            textBox1.KeyPress += TextBox1_KeyPress;

            Controls.Add(textBox1);
            this.Padding = new Padding(10);
            this.Size = new Size(150, 40);
            UpdateControlHeight();
        }

        // Properties
        [Category("Custom Properties")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        [Category("Custom Properties")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; this.Invalidate(); }
        }

        [Category("Custom Properties")]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }

        [Category("Custom Properties")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); }
        }

        [Category("Custom Properties")]
        public override string Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public bool UseSystemPasswordChar
        {
            get => useSystemPasswordChar;
            set
            {
                useSystemPasswordChar = value;
                UpdatePasswordChar(); // Actualiza el enmascarado del texto según la propiedad
            }
        }

        private void UpdatePasswordChar()
        {
            // Solo enmascara el texto si no está mostrando el placeholder
            textBox1.UseSystemPasswordChar = useSystemPasswordChar && textBox1.Text != placeholderText;
        }

        // Private Methods
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            // Asegurar que el radio no sea mayor que la mitad del ancho o la altura
            int adjustedRadius = Math.Min(radius, Math.Min(rect.Width, rect.Height) / 2);
            float curveSize = adjustedRadius * 2F;

            if (curveSize > 0)
            {
                path.StartFigure();
                path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
                path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
                path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
                path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
                path.CloseFigure();
            }
            else
            {
                // Si el rectángulo es muy pequeño, usar un camino rectangular
                path.AddRectangle(rect);
            }

            return path;
        }
        private void UpdateControlHeight()
        {
            if (!textBox1.Multiline)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustTextBoxPosition();
        }

        private void AdjustTextBoxPosition()
        {
            textBox1.Location = new Point(this.Padding.Left, this.Padding.Top);
            textBox1.Width = this.Width - this.Padding.Left - this.Padding.Right;
            textBox1.Height = this.Height - this.Padding.Top - this.Padding.Bottom;
        }

        // Overridden Paint Method
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            Rectangle rectBorderSmooth = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
            int smoothSize = borderSize > 0 ? borderSize : 1;

            using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
            using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
            using (Pen penBorder = new Pen(isFocused ? borderFocusColor : borderColor, borderSize))
            {
                this.Region = new Region(pathBorderSmooth);

                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.Alignment = PenAlignment.Center;
                graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                graph.DrawPath(penBorder, pathBorder);
            }
        }

        // Event Handlers
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.OnTextChanged(e);
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }

        private void TextBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void TextBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        internal void Clear()
        {
            textBox1.Text=String.Empty;
        }
    }
}
