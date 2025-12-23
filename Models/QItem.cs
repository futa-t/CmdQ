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

public enum QItemLogType
{
    StdOut,
    StdErr,
}
public record QItemLog(string Text, QItemLogType Type = QItemLogType.StdOut);

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

    public ObservableCollection<QItemLog> Logs { get; } = [];
    public string Command
    {
        get => field; set
        {
            if (field == value) return;
            field =value;
            this.OnPropertyChanged(nameof(this.Command));
        }
    } = string.Empty;

    public QItemLog? Log => this.Logs.LastOrDefault();
    public string Path { get; } = path;

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged(string name) => this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    private readonly object LogLock = new();
    public void AddLog(string text, QItemLogType type = QItemLogType.StdOut)
    {
        lock (this.LogLock)
        {
            this.Logs.Add(new(text, type));
        }
    }
}

