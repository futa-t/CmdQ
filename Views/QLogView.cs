using System.Collections.Specialized;

using CmdQ.Models;

namespace CmdQ.Views;

public partial class QLogView: Form
{
    private readonly QItem model;
    private readonly NotifyCollectionChangedEventHandler handler;
    public QLogView(QItem model)
    {
        this.model = model;
        this.InitializeComponent();
        this.Text = model.Path;

        this.handler = (s, e) =>
        {
            this.AddLog(this.model.Log);
        };

        this.model.Logs.CollectionChanged += this.handler;

        foreach (var log in this.model.Logs)
        {
            this.AddLog(log);
        }
    }
    private void AddLog(QItemLog? log)
    {
        if (this.IsDisposed) return;

        var text = log?.Text;
        var error = log?.Type == QItemLogType.StdErr;
        if (string.IsNullOrWhiteSpace(text)) return;
        if (this.InvokeRequired)
        {
            this.BeginInvoke(() => this.AddLog(log));
            return;
        }

        int startIndex = this.TbLog.TextLength;

        this.TbLog.AppendText(text + Environment.NewLine);

        if (error)
        {
            this.TbLog.Select(startIndex, text.Length);
            this.TbLog.SelectionColor = Color.Red;

            this.TbLog.SelectionStart = this.TbLog.TextLength;
            this.TbLog.SelectionLength = 0;
            this.TbLog.SelectionColor = this.TbLog.ForeColor;
        }

        this.TbLog.ScrollToCaret();
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        this.model.Logs.CollectionChanged -= this.handler;
        base.OnFormClosed(e);
    }
}
