using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace CmdQ.Models;

public class QCommand(string name): INotifyPropertyChanged
{
    public string Name { get; } = name;
    public string Template
    {
        get => field; set
        {
            if (field == value) return;
            field = value;
            this.OnPropertyChanged(nameof(this.Template));
        }
    } = string.Empty;

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged(string name) => this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    public string[] Build(QItem item)
    {
        var parent = Path.GetDirectoryName(item.Path);
        var name = Path.GetFileName(item.Path);
        var stem = Path.GetFileNameWithoutExtension(item.Path);
        var ext = Path.GetExtension(item.Path);

        List<string> cmd = [];
        foreach (var t in this.Template.Split())
        {
            cmd.Add(t.Replace("{path}", item.Path)
                    .Replace("{parent}", parent)
                    .Replace("{fullname}", Path.Join(parent, name))
                    .Replace("{name}", name)
                    .Replace("{fullstem}", Path.Join(parent, stem))
                    .Replace("{stem}", stem)
                    .Replace("{ext}", ext));
        }
        return [.. cmd];
    }

    public async Task Run(QItem item)
    {
        var cmd = this.Build(item);
        var info = new ProcessStartInfo
        {
            FileName = cmd.First(),
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            CreateNoWindow = true,
            StandardOutputEncoding = Encoding.UTF8,
            StandardErrorEncoding = Encoding.UTF8
        };
        foreach (var c in cmd.Skip(1))
        {
            info.ArgumentList.Add(c);
        }

        using var process = new Process { StartInfo = info };

        item.Logs.Add(string.Join(" ", cmd));
        process.OutputDataReceived += (sender, e) =>
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                item.Logs.Add(e.Data);
            }
        };

        process.ErrorDataReceived += (sender, e) =>
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                item.Errors.Add(e.Data);
            }
        };

        item.Status = QItemStatus.Processing;
        process.Start();

        process.BeginOutputReadLine();
        process.BeginErrorReadLine();

        await process.WaitForExitAsync();
        item.Status = process.ExitCode == 0 ? QItemStatus.Success : QItemStatus.Failed;
    }
}
