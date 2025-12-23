using CmdQ.Models;

namespace CmdQ.Views;

public partial class QItemView: UserControl
{
    private QItem Item { get; }
    public event EventHandler<QItem>? OnClick;
    public QItemView(QItem item)
    {
        this.InitializeComponent();
        this.Item = item;
        this.Item.PropertyChanged +=this.Item_PropertyChanged;
        this.Item.Logs.CollectionChanged += (s, e) => this.UpdateView();
        this.Lb_Item.Click += this.Lb_Item_Click;
        this.UpdateView();
    }


    private void UpdateView()
    {
        if (this.InvokeRequired)
        {
            this.Invoke(new Action(this.UpdateView));
            return;
        }

        this.Lb_Item.Text  = this.Item.Path;
        this.Pb_Status.Image = this.Item.Status switch
        {
            QItemStatus.Pending => null,
            QItemStatus.Processing => Properties.Resources.icon_progress_24,
            QItemStatus.Success => Properties.Resources.icon_check_24,
            QItemStatus.Failed => Properties.Resources.icon_failed_24,
            _ => null
        };
        this.Pb_FileType.Image = this.Item.ItemType switch
        {
            QItemType.File => Properties.Resources.icon_file_24,
            QItemType.Directory => Properties.Resources.icon_folder_24,
            QItemType.Url => Properties.Resources.icon_link_24,
            _ => null
        };
        this.UpdateLog();
    }

    private void UpdateLog()
    {
        var log = this.Item.Log;
        if (log is null)
        {
            this.Lb_Log.Visible = false;
            return;
        }

        this.Lb_Log.ForeColor = log.Type switch
        {
            QItemLogType.StdErr => Color.Crimson,
            _ => SystemColors.ControlDarkDark,
        };

        this.Lb_Log.Text = log.Text;
        this.Lb_Log.Visible = true;
    }

    private void Item_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(this.Item.Command))
        {
            this.Lb_Log.ForeColor = SystemColors.ControlDarkDark;
            this.Lb_Log.Text = this.Item.Command;
            this.Lb_Log.Visible = !string.IsNullOrWhiteSpace(this.Item.Command);
        }
        else
        {
            this.UpdateView();

        }
    }

    private void Lb_Item_Click(object? sender, EventArgs e)
    {
        this.OnClick?.Invoke(sender, this.Item);
    }

}
