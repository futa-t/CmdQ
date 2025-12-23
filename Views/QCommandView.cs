using CmdQ.Models;

namespace CmdQ.Views;

public partial class QCommandView: UserControl
{
    private readonly QCommand model;
    public event EventHandler<TextBox>? OnFocus;
    public QCommandView(QCommand model)
    {
        this.model = model;
        this.InitializeComponent();
        this.label1.Text = this.model.Name;
        this.textBox1.Text = this.model.Template;
        this.textBox1.TextChanged += this.TextBox1_TextChanged;
        this.textBox1.Enter += (s, e) => this.OnFocus?.Invoke(s, this.textBox1);
    }

    private void TextBox1_TextChanged(object? sender, EventArgs e)
    {
        this.model.Template = this.textBox1.Text.Trim();
    }
}
