using CmdQ.Models;
using CmdQ.Views;

namespace CmdQ;

public partial class Form1: Form
{
    private readonly List<QItem> items = [];

    public Form1()
    {
        this.InitializeComponent();
        this.Flp_items.AllowDrop = true;
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
        var view = new QItemView(item);
        this.Flp_items.Controls.Add(view);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        foreach (var item in this.items)
        {
            item.Path = item.Path.Split("\\").Last();
        }
    }
}
