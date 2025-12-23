using System.Collections.Specialized;

using CmdQ.Models;

namespace CmdQ.Views;

public partial class QLogWindow: Form
{
    private readonly QItem model;
    private readonly NotifyCollectionChangedEventHandler handler;
    public QLogWindow(QItem model)
    {
        this.model = model;
        this.InitializeComponent();
        this.Text = model.Path;

        this.handler = (s, e) => this.Qlv.Insert(this.model.Log);

        this.model.Logs.CollectionChanged += this.handler;

        this.Qlv.Insert(this.model.Logs);
    }
    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        this.model.Logs.CollectionChanged -= this.handler;
        base.OnFormClosed(e);
    }
}
