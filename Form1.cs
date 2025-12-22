using CmdQ.Models;
using CmdQ.Views;

namespace CmdQ;

public partial class Form1: Form
{
    private readonly List<QItem> items = [];
    private readonly List<QCommand> commands = [];

    private TextBox? lastEnter = null;

    public Form1()
    {
        this.InitializeComponent();
        this.Flp_Items.AllowDrop = true;
        this.AddCommandList();
        this.Flp_Cmd.SizeChanged += this.Flp_Cmd_SizeChanged;
    }

    private void Flp_Cmd_SizeChanged(object? sender, EventArgs e)
    {
        foreach (Control c in this.Flp_Cmd.Controls)
        {
            c.Width= this.Flp_Cmd.ClientSize.Width;
        }
    }

    private void AddCommandList()
    {
        var model = new QCommand($"ƒRƒ}ƒ“ƒh{this.commands.Count + 1}");
        var view = new QCommandView(model)
        {
            Width = this.Flp_Cmd.ClientSize.Width
        };
        view.OnEnter += (s, e) => this.lastEnter = e;
        this.commands.Add(model);
        this.Flp_Cmd.Controls.Add(view);
    }

    private void Gb_Items_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data == null)
        {
            e.Effect = DragDropEffects.None;
            return;
        }


        if (e.Data.GetDataPresent(DataFormats.FileDrop) ||
            e.Data.GetDataPresent(DataFormats.Text) ||
            e.Data.GetDataPresent(DataFormats.UnicodeText))
        {
            e.Effect = DragDropEffects.Copy;
        }
        else
        {
            e.Effect = DragDropEffects.None;
        }
    }

    private void Gb_Items_DragDrop(object sender, DragEventArgs e)
    {
        if (e.Data == null)
            return;

        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            var paths = (string[])e.Data.GetData(DataFormats.FileDrop)!;

            foreach (var path in paths)
            {
                if (File.Exists(path))
                {
                    this.AddItem(new QItem(path, QItemType.File));
                }
                else if (Directory.Exists(path))
                {
                    this.AddItem(new QItem(path, QItemType.Directory));
                }
            }
        }
        else if (e.Data.GetDataPresent(DataFormats.UnicodeText))
        {
            var text = ((string)e.Data.GetData(DataFormats.UnicodeText)!).Trim();

            if (Uri.TryCreate(text, UriKind.Absolute, out var uri))
            {
                this.AddItem(new QItem(uri.ToString(), QItemType.Url));
            }
        }
    }

    private void AddLog(string text, bool error = false)
    {
        if (string.IsNullOrWhiteSpace(text)) return;
        if (this.InvokeRequired)
        {
            this.Invoke(() => this.AddLog(text, error));
            return;
        }

        int startIndex = this.TbLog.TextLength;

        this.TbLog.AppendText(text + Environment.NewLine);

        if (error)
        {
            this.TbLog.Select(startIndex, text.Length);
            this.TbLog.SelectionColor = Color.Red;

            this.TbLog.SelectionStart = this.TbLog.TextLength;
            this.TbLog.SelectionLength = 0;
            this.TbLog.SelectionColor = this.TbLog.ForeColor;
        }

        this.TbLog.ScrollToCaret();
    }
    private void AddItem(QItem item)
    {
        this.items.Add(item);
        item.Logs.CollectionChanged += (s, e) => this.AddLog(item.Log);
        item.Errors.CollectionChanged += (s, e) => this.AddLog(item.Error, true);
        var view = new QItemView(item);
        this.Flp_Items.Controls.Add(view);
    }

    private void BtnTestClick(object sender, EventArgs e)
    {
        for (var i = 0; i < this.items.Count; i++)
        {
            var item = this.items[i];
            var cmd = string.Empty;
            foreach (var command in this.commands)
            {
                cmd += string.Join(" ", command.Build(item)) + Environment.NewLine;
            }
            item.Command = cmd.Trim();
        }
    }

    private void Btn_CmdReplace_Click(object sender, EventArgs e)
    {
        for (var i = 0; i < this.items.Count; i++)
        {
            var item = this.items[i];
            var cmd = string.Empty;
            foreach (var command in this.commands)
            {
                cmd += string.Join(" ", command.Build(item)) + Environment.NewLine;
            }
            item.Command = cmd.Trim();
        }
    }

    private void InsertTemplate(object sender, EventArgs e)
    {
        if (sender is Button b && b.Tag is string tag)
        {
            var textBox = this.lastEnter;

            if (textBox != null)
            {
                int cursorPos = textBox.SelectionStart;
                textBox.SelectedText = tag;
                textBox.SelectionStart = cursorPos + tag.Length;
                textBox.SelectionLength = 0;
                textBox.Focus();
            }
        }
    }

    private void Btn_CmdAdd_Click(object sender, EventArgs e)
    {
        this.AddCommandList();
    }

    private async void Btn_CmdExecute_Click(object sender, EventArgs e)
    {
        foreach (var item in this.items)
        {
            foreach (var cmd in this.commands)
            {
                await cmd.Run(item);
            }
        }

    }
}
