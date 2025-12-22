using System.ComponentModel;

namespace CmdQ.Models;

public enum QItemType
{
    File,
    Directory,
    Url,
}

public enum QItemStatus
{
    Pending,
    Processing,
    Success,
    Failed
}

public class QItem(string path, QItemType type): INotifyPropertyChanged
{
    public QItemType ItemType { get; } = type;
    public QItemStatus Status
    {
        get => field;
        set
        {
            if (field == value) return;
            field = value;
            this.OnPropertyChanged(nameof(this.Status));
        }
    } = QItemStatus.Pending;
    public string Log
    {
        get => field;
        set
        {
            if (field == value) return;
            field = value;
            this.OnPropertyChanged(nameof(this.Log));
        }
    } = string.Empty;
    public string Error
    {
        get => field;
        set
        {
            if (field == value) return;
            field = value;
            this.OnPropertyChanged(nameof(this.Error));
        }
    } = string.Empty;


    public string Path { get; } = path;

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged(string name) => this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

