using System.Collections.ObjectModel;
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

    public ObservableCollection<string> Logs { get; } = [];
    public ObservableCollection<string> Errors { get; } = [];
    public string Command
    {
        get => field; set
        {
            if (field == value) return;
            field =value;
            this.OnPropertyChanged(nameof(this.Command));
        }
    } = string.Empty;

    public string Log => this.Logs.LastOrDefault(string.Empty);
    public string Error => this.Errors.LastOrDefault(string.Empty);

    public string Path { get; } = path;

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged(string name) => this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

