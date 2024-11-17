using System;
using System.Drawing;
using System.Windows.Forms;

public class ColorBorderTextBox : Panel
{
    private TextBox textBox;
    private string placeholderText; // Almacena el texto del placeholder
    private bool useSystemPasswordChar; // Campo privado para gestionar el uso del enmascarado

    private Color borderColor = Color.White;

    public event EventHandler TextChanged;

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

    public bool UseSystemPasswordChar
    {
        get => useSystemPasswordChar;
        set
        {
            useSystemPasswordChar = value;
            UpdatePasswordChar(); // Actualiza el enmascarado del texto según la propiedad
        }
    }

    // Propiedad para habilitar la validación de solo números
    public bool OnlyAllowNumbers { get; set; } = false;
    /// <summary>
    /// Creamos el boton y sus caracteristicas que va a tener y hemos implementado 
    /// </summary>
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

        textBox.KeyPress += (sender, e) => { OnTextBoxKeyPressOnlyNumber(e); }; // Event for KeyPress validation
        textBox.TextChanged += (sender, e) => { OnTextChanged(e); };

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
            textBox.UseSystemPasswordChar = false; // Asegura que el placeholder no esté enmascarado
        }
    }

    private void OnTextBoxEnter()
    {
        if (textBox.Text == placeholderText)
        {
            textBox.Text = "";
            textBox.ForeColor = Color.FromArgb(202, 224, 212); // Color normal cuando el usuario escribe
            UpdatePasswordChar(); // Activa el enmascarado si corresponde
        }
    }

    private void OnTextBoxLeave()
    {
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
            SetPlaceholder();
        }
    }

    private void UpdatePasswordChar()
    {
        // Solo enmascara el texto si no está mostrando el placeholder
        textBox.UseSystemPasswordChar = useSystemPasswordChar && textBox.Text != placeholderText;
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
    /// <summary>
    /// Simulamos un textbox que va dentro de nuestro panel
    /// </summary>
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
                UpdatePasswordChar();
            }
        }
    }
    public void Clear()
    {
        textBox.Text = "";
        SetPlaceholder();
    }
    private void OnTextChanged (EventArgs e)
    {
        TextChanged?.Invoke(this, e);
    }
    private void OnTextBoxKeyPressOnlyNumber(KeyPressEventArgs e)
    {
        if (OnlyAllowNumbers && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true; // Cancelar el evento si no es un número ni una tecla de control
        }
    }
}

