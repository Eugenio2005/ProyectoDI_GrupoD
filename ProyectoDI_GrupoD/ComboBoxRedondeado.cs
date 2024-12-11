using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProyectoDI_GrupoD
{
    public partial class ComboBoxRedondeado : UserControl
    {
        // Fields
        private Color borderColor = Color.FromArgb(203, 156, 99);
        private Color borderFocusColor = Color.FromArgb(44, 36, 36);
        private int borderSize = 2;
        private int borderRadius = 15;
        private bool isFocused = false;

        private ComboBox comboBox;

        // Constructor
        public ComboBoxRedondeado()
        {
            comboBox = new ComboBox();
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.ForeColor = Color.Black;
            comboBox.BackColor = Color.White;

            comboBox.Enter += (sender, e) => { isFocused = true; this.Invalidate(); };
            comboBox.Leave += (sender, e) => { isFocused = false; this.Invalidate(); };

            Controls.Add(comboBox);
            this.Padding = new Padding(10);
            this.Size = new Size(150, 40);
            AdjustComboBoxPosition();
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
        public object DataSource
        {
            get => comboBox.DataSource;
            set => comboBox.DataSource = value;
        }

        [Category("Custom Properties")]
        public ComboBox.ObjectCollection Items
        {
            get => comboBox.Items;
        }

        [Category("Custom Properties")]
        public string DisplayMember
        {
            get => comboBox.DisplayMember;
            set => comboBox.DisplayMember = value;
        }

        [Category("Custom Properties")]
        public string ValueMember
        {
            get => comboBox.ValueMember;
            set => comboBox.ValueMember = value;
        }

        [Category("Custom Properties")]
        public object SelectedValue
        {
            get => comboBox.SelectedValue;
            set => comboBox.SelectedValue = value;
        }

        [Category("Custom Properties")]
        public override string Text
        {
            get => comboBox.Text;
            set => comboBox.Text = value;
        }

        // Private Methods
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

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
                path.AddRectangle(rect);
            }

            return path;
        }

        private void AdjustComboBoxPosition()
        {
            comboBox.Location = new Point(this.Padding.Left, this.Padding.Top);
            comboBox.Width = this.Width - this.Padding.Left - this.Padding.Right;
            comboBox.Height = this.Height - this.Padding.Top - this.Padding.Bottom;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxPosition();
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
    }
}
