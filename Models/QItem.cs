using System.ComponentModel;

namespace CmdQ.Models;

public enum QItemType
{
    File,
    Directory,
    Url,
}

public class QItem(string path, QItemType type): INotifyPropertyChanged
{
    public QItemType ItemType { get; } = type;
    public string Path
    {
        get => field;
        set
        {
            if (field == value) return;
            field = value;
            this.OnPropertyChanged(nameof(this.Path));
        }
    } = path;

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged(string name) => this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

