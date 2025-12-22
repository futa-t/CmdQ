using CmdQ.Models;
using CmdQ.Views;

namespace CmdQ;

public partial class Form1: Form
{
    private readonly List<QItem> items = [];

    public Form1()
    {
        this.InitializeComponent();
        this.Flp_Items.AllowDrop = true;
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

    private void AddItem(QItem item)
    {
        this.items.Add(item);
        var view = new QItemView(item)
        {
        };
        //this.Flp_Items.SizeChanged += (s, e) =>
        //{
        //    view.Width = this.Flp_Items.ClientSize.Width;
        //};
        view.OnClick += (s, e) => item.Log = string.Empty;
        this.Flp_Items.Controls.Add(view);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        for (var i = 0; i < this.items.Count; i++)
        {
            var item = this.items[i];
            if (i % 2 == 0)
            {
                item.Log = $"{this.Tb_Cmd.Text} {item.Path}";
            }
            else
            {
                item.Error = $"Error {this.Tb_Cmd.Text} {item.Path}";
            }
        }
    }

    private void Btn_CmdReplace_Click(object sender, EventArgs e)
    {
        var cmd = this.Tb_Cmd.Text;
        foreach (var item in this.items)
        {
            item.Log = cmd.Replace("{input}", item.Path);
        }
    }
}
