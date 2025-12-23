namespace CmdQ.Views;

partial class QItemView
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
        this.Pb_FileType = new PictureBox();
        this.Lb_Item = new Label();
        this.contextMenuStrip1 = new ContextMenuStrip(this.components);
        this.実行ToolStripMenuItem = new ToolStripMenuItem();
        this.ログを表示ToolStripMenuItem = new ToolStripMenuItem();
        this.削除ToolStripMenuItem = new ToolStripMenuItem();
        this.Pb_Status = new PictureBox();
        this.Lb_Log = new Label();
        ((System.ComponentModel.ISupportInitialize)this.Pb_FileType).BeginInit();
        this.contextMenuStrip1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.Pb_Status).BeginInit();
        this.SuspendLayout();
        // 
        // Pb_FileType
        // 
        this.Pb_FileType.InitialImage = null;
        this.Pb_FileType.Location = new Point(24, 2);
        this.Pb_FileType.Name = "Pb_FileType";
        this.Pb_FileType.Size = new Size(20, 20);
        this.Pb_FileType.SizeMode = PictureBoxSizeMode.Zoom;
        this.Pb_FileType.TabIndex = 0;
        this.Pb_FileType.TabStop = false;
        // 
        // Lb_Item
        // 
        this.Lb_Item.AutoSize = true;
        this.Lb_Item.BackColor = SystemColors.Control;
        this.Lb_Item.ContextMenuStrip = this.contextMenuStrip1;
        this.Lb_Item.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 128);
        this.Lb_Item.ForeColor = Color.FromArgb(51, 51, 51);
        this.Lb_Item.Location = new Point(46, 2);
        this.Lb_Item.Margin = new Padding(0);
        this.Lb_Item.Name = "Lb_Item";
        this.Lb_Item.Size = new Size(37, 19);
        this.Lb_Item.TabIndex = 1;
        this.Lb_Item.Text = "item";
        this.Lb_Item.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // contextMenuStrip1
        // 
        this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] { this.実行ToolStripMenuItem, this.ログを表示ToolStripMenuItem, this.削除ToolStripMenuItem });
        this.contextMenuStrip1.Name = "contextMenuStrip1";
        this.contextMenuStrip1.ShowImageMargin = false;
        this.contextMenuStrip1.ShowItemToolTips = false;
        this.contextMenuStrip1.Size = new Size(156, 92);
        // 
        // 実行ToolStripMenuItem
        // 
        this.実行ToolStripMenuItem.Name = "実行ToolStripMenuItem";
        this.実行ToolStripMenuItem.Size = new Size(155, 22);
        this.実行ToolStripMenuItem.Text = "実行";
        // 
        // ログを表示ToolStripMenuItem
        // 
        this.ログを表示ToolStripMenuItem.Name = "ログを表示ToolStripMenuItem";
        this.ログを表示ToolStripMenuItem.Size = new Size(155, 22);
        this.ログを表示ToolStripMenuItem.Text = "ログを表示";
        this.ログを表示ToolStripMenuItem.Click += this.OpenLogView;
        // 
        // 削除ToolStripMenuItem
        // 
        this.削除ToolStripMenuItem.Name = "削除ToolStripMenuItem";
        this.削除ToolStripMenuItem.Size = new Size(155, 22);
        this.削除ToolStripMenuItem.Text = "削除";
        this.削除ToolStripMenuItem.Click += this.MenuDeleteClick;
        // 
        // Pb_Status
        // 
        this.Pb_Status.InitialImage = null;
        this.Pb_Status.Location = new Point(2, 2);
        this.Pb_Status.Name = "Pb_Status";
        this.Pb_Status.Size = new Size(20, 20);
        this.Pb_Status.SizeMode = PictureBoxSizeMode.Zoom;
        this.Pb_Status.TabIndex = 0;
        this.Pb_Status.TabStop = false;
        // 
        // Lb_Log
        // 
        this.Lb_Log.AutoSize = true;
        this.Lb_Log.BackColor = SystemColors.Control;
        this.Lb_Log.ContextMenuStrip = this.contextMenuStrip1;
        this.Lb_Log.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
        this.Lb_Log.ForeColor = SystemColors.ControlDarkDark;
        this.Lb_Log.Location = new Point(46, 24);
        this.Lb_Log.Margin = new Padding(0);
        this.Lb_Log.Name = "Lb_Log";
        this.Lb_Log.Padding = new Padding(12, 0, 0, 0);
        this.Lb_Log.Size = new Size(39, 15);
        this.Lb_Log.TabIndex = 1;
        this.Lb_Log.Text = "Log";
        this.Lb_Log.TextAlign = ContentAlignment.MiddleLeft;
        this.Lb_Log.Visible = false;
        // 
        // QItemView
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.AutoSize = true;
        this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.BackColor = SystemColors.Control;
        this.Controls.Add(this.Lb_Log);
        this.Controls.Add(this.Lb_Item);
        this.Controls.Add(this.Pb_Status);
        this.Controls.Add(this.Pb_FileType);
        this.Margin = new Padding(4, 2, 4, 2);
        this.Name = "QItemView";
        this.Size = new Size(85, 39);
        ((System.ComponentModel.ISupportInitialize)this.Pb_FileType).EndInit();
        this.contextMenuStrip1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.Pb_Status).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private PictureBox Pb_FileType;
    private Label Lb_Item;
    private PictureBox Pb_Status;
    private Label Lb_Log;
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem ログを表示ToolStripMenuItem;
    private ToolStripMenuItem 実行ToolStripMenuItem;
    private ToolStripMenuItem 削除ToolStripMenuItem;
}
