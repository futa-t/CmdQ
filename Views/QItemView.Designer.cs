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
        this.Pb_FileType = new PictureBox();
        this.Lb_Item = new Label();
        ((System.ComponentModel.ISupportInitialize)this.Pb_FileType).BeginInit();
        this.SuspendLayout();
        // 
        // Pb_FileType
        // 
        this.Pb_FileType.InitialImage = null;
        this.Pb_FileType.Location = new Point(6, 4);
        this.Pb_FileType.Name = "Pb_FileType";
        this.Pb_FileType.Size = new Size(24, 24);
        this.Pb_FileType.SizeMode = PictureBoxSizeMode.Zoom;
        this.Pb_FileType.TabIndex = 0;
        this.Pb_FileType.TabStop = false;
        // 
        // Lb_Item
        // 
        this.Lb_Item.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        this.Lb_Item.BackColor = SystemColors.Control;
        this.Lb_Item.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
        this.Lb_Item.ForeColor = Color.FromArgb(51, 51, 51);
        this.Lb_Item.Location = new Point(34, 0);
        this.Lb_Item.Name = "Lb_Item";
        this.Lb_Item.Padding = new Padding(6, 2, 6, 2);
        this.Lb_Item.Size = new Size(627, 32);
        this.Lb_Item.TabIndex = 1;
        this.Lb_Item.Text = "item";
        this.Lb_Item.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // QItemView
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.Controls.Add(this.Lb_Item);
        this.Controls.Add(this.Pb_FileType);
        this.Name = "QItemView";
        this.Size = new Size(661, 32);
        ((System.ComponentModel.ISupportInitialize)this.Pb_FileType).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private PictureBox Pb_FileType;
    private Label Lb_Item;
}
