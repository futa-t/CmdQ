using System.Diagnostics;

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
        var model = new QCommand($"コマンド{this.commands.Count + 1}");
        var view = new QCommandView(model)
        {
            Width = this.Flp_Cmd.ClientSize.Width
        };
        view.OnFocus += (s, e) => this.lastEnter = e;
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


    private void AddItem(QItem item)
    {
        this.items.Add(item);
        item.Logs.CollectionChanged += (s, e) => this.Qlv.Insert(item.Log);
        this.UpdateQueueView();
    }


    private void UpdateQueueView()
    {
        this.Flp_Items.Controls.Clear();
        var views = this.items.Select(i =>
        {
            var view = new QItemView(i);
            view.OnDelete += this.View_OnDelete;
            return view;
        }).ToArray();
        this.Flp_Items.Controls.AddRange(views);
    }

    private void View_OnDelete(object? sender, QItemEventArgs e)
    {
        if (sender is QItemView view)
        {
            if (this.items.Remove(e.Item))
            {
                this.Flp_Items.Controls.Remove(view);
                this.Qlv.Insert($"削除しました: {e.Item.Path}");
                view.Dispose();
            }
            else
            {
                this.Qlv.InsertError($"削除に失敗しました: {e.Item.Path}");
            }
        }
    }

    private void BtnTestClick(object sender, EventArgs e)
    {
        var cmd = this.commands[0].Build(this.items[0]);
        Debug.WriteLine(string.Join(Environment.NewLine, cmd));
    }

    private void BtnCmdReplaceClick(object sender, EventArgs e)
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

    private void BtnCmdAddClick(object sender, EventArgs e)
    {
        this.AddCommandList();
    }

    private async void BtnCmdExecuteClick(object sender, EventArgs e)
    {
        await this.CmdExecute();
    }

    private void SetExecuteStatus(bool state)
    {
        this.Btn_CmdExecute.Enabled = state;
        this.Btn_CmdParallel.Enabled = state;
    }


    private readonly AsyncLock LockRunning = new();

    private async Task CmdExecute()
    {
        using (await this.LockRunning.LockAsync())
        {
            try
            {
                this.SetExecuteStatus(false);
                foreach (var item in this.items)
                {
                    foreach (var cmd in this.commands)
                    {
                        await cmd.Run(item);
                    }
                }
            }
            finally
            {
                this.SetExecuteStatus(true);
            }
        }
    }

    private async Task CmdExecuteParallel()
    {
        using (await this.LockRunning.LockAsync())
        {
            try
            {
                this.SetExecuteStatus(false);
                var options = new ParallelOptions
                {
                    MaxDegreeOfParallelism = 2
                };

                await Parallel.ForEachAsync(this.items, options, async (item, ct) =>
                {
                    foreach (var cmd in this.commands)
                    {
                        await cmd.Run(item);
                    }
                });
            }
            finally
            {
                this.SetExecuteStatus(true);
            }
        }
    }

    private void BtnQClear_Click(object sender, EventArgs e)
    {
        this.items.Clear();
        this.UpdateQueueView();
        this.Qlv.Insert("キューをクリアしました");
    }

    private async void BtnCmdParallel_Click(object sender, EventArgs e)
    {
        await this.CmdExecuteParallel();
    }

    private void BtnQSClear_Click(object sender, EventArgs e)
    {
        var deleted = this.items.RemoveAll(i => i.Status == QItemStatus.Success);
        if (deleted == 0)
        {
            this.Qlv.Insert($"完了済みのキューが存在しません");
            return;
        }
        this.UpdateQueueView();
        this.Qlv.Insert($"{deleted}件の完了済みキューをクリアしました");
    }
}
