using System;
using System.Drawing;
using System.Windows.Forms;

public class ColorBorderTextBox : Panel
{
    private TextBox textBox;
    private string placeholderText; // Almacena el texto del placeholder

    private Color borderColor = Color.Red;
    public Color BorderColor
    {
        get => borderColor;
        set
        {
            borderColor = value;
            this.Invalidate(); // Redibuja el control al cambiar el color
        }
    }
    public int MaxLength
    {
        get => textBox.MaxLength;
        set => textBox.MaxLength = value; // Establece el MaxLength del TextBox interno
    }

    public ColorBorderTextBox()
    {
        this.Padding = new Padding(1);

        textBox = new TextBox
        {
            BorderStyle = BorderStyle.None,
            BackColor = Color.FromArgb(44, 36, 36),
            Dock = DockStyle.Fill,
            ForeColor = Color.FromArgb(202, 224, 212) // Color del placeholder
        };

        textBox.Enter += (sender, e) => { BorderColor = Color.White; };

        // Manejadores de eventos para el placeholder
        textBox.Enter += (sender, e) => { OnTextBoxEnter(); };
        textBox.Leave += (sender, e) => { OnTextBoxLeave(); };

        this.Controls.Add(textBox);

        // Inicializa el placeholder
        SetPlaceholder();
    }

    private void SetPlaceholder()
    {
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.FromArgb(202, 224, 212); // Color del texto para el placeholder
        }
    }

    private void OnTextBoxEnter()
    {
        if (textBox.Text == placeholderText)
        {
            textBox.Text = "";
            textBox.ForeColor = Color.FromArgb(202, 224, 212); // Color normal cuando el usuario escribe
        }
    }

    private void OnTextBoxLeave()
    {
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
            SetPlaceholder();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        using (Pen pen = new Pen(BorderColor, 2))
        {
            e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
        }
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        this.Invalidate();
    }

    public string Text
    {
        get => textBox.Text == placeholderText ? "" : textBox.Text; // Devuelve el texto real
        set
        {
            textBox.Text = value;
            if (string.IsNullOrWhiteSpace(value))
            {
                SetPlaceholder();
            }
            else
            {
                textBox.ForeColor = Color.Gray; // Color normal cuando se establece texto
            }
        }
    }
}

