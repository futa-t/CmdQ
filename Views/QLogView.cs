using CmdQ.Models;

namespace CmdQ.Views;

public partial class QLogView: UserControl
{
    public QLogView()
    {
        this.InitializeComponent();
    }

    public void Insert(string log) => this.Insert(new QItemLog(log));
    public void InsertError(string log) => this.Insert(new QItemLog(log, QItemLogType.StdErr));

    public void Insert(IEnumerable<QItemLog> logs)
    {
        foreach (var log in logs)
        {
            this.Insert(log);
        }
    }
    public void Insert(QItemLog? log)
    {
        if (this.IsDisposed) return;

        var text = log?.Text;
        var error = log?.Type == QItemLogType.StdErr;
        if (string.IsNullOrWhiteSpace(text)) return;
        if (this.InvokeRequired)
        {
            this.BeginInvoke(() => this.Insert(log));
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

    private void TmiClear_Click(object sender, EventArgs e)
    {
        this.TbLog.Clear();
    }
}
