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
        this.Lb_Item.Click += this.Lb_Item_Click;
        this.UpdateView();
    }

    private void UpdateView()
    {
        this.Lb_Item.Text  = this.Item.Path;
        this.Pb_FileType.Image = this.Item.ItemType switch
        {
            QItemType.File => Properties.Resources.icon_file_24,
            QItemType.Directory => Properties.Resources.icon_folder_24,
            QItemType.Url => Properties.Resources.icon_link_24,
            _ => null
        };
    }

    private void Item_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        this.UpdateView();
    }

    private void Lb_Item_Click(object? sender, EventArgs e)
    {
        this.OnClick?.Invoke(sender, this.Item);
    }

}
