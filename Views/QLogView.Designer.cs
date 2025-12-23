namespace CmdQ.Views;

partial class QLogView
{
    /// <summary> 
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region コンポーネント デザイナーで生成されたコード

    /// <summary> 
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.TbLog = new RichTextBox();
        this.contextMenuStrip1 = new ContextMenuStrip(this.components);
        this.TmiClear = new ToolStripMenuItem();
        this.contextMenuStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // TbLog
        // 
        this.TbLog.BackColor = SystemColors.Control;
        this.TbLog.BorderStyle = BorderStyle.None;
        this.TbLog.ContextMenuStrip = this.contextMenuStrip1;
        this.TbLog.Dock = DockStyle.Fill;
        this.TbLog.Font = new Font("BIZ UDPゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
        this.TbLog.Location = new Point(0, 0);
        this.TbLog.Name = "TbLog";
        this.TbLog.ReadOnly = true;
        this.TbLog.Size = new Size(150, 150);
        this.TbLog.TabIndex = 0;
        this.TbLog.Text = "";
        // 
        // contextMenuStrip1
        // 
        this.contextMenuStrip1.AllowMerge = false;
        this.contextMenuStrip1.Font = new Font("BIZ UDPゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
        this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] { this.TmiClear });
        this.contextMenuStrip1.Name = "contextMenuStrip1";
        this.contextMenuStrip1.ShowImageMargin = false;
        this.contextMenuStrip1.Size = new Size(156, 48);
        // 
        // TmiClear
        // 
        this.TmiClear.Name = "TmiClear";
        this.TmiClear.Size = new Size(155, 22);
        this.TmiClear.Text = "クリア";
        this.TmiClear.Click += this.TmiClear_Click;
        // 
        // QLogView
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.Controls.Add(this.TbLog);
        this.Name = "QLogView";
        this.contextMenuStrip1.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private RichTextBox TbLog;
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem TmiClear;
}
