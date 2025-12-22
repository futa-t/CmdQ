namespace CmdQ.Views;

partial class QCommandView
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
        this.label1 = new Label();
        this.textBox1 = new TextBox();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
        this.label1.Location = new Point(3, 7);
        this.label1.Name = "label1";
        this.label1.Size = new Size(48, 15);
        this.label1.TabIndex = 0;
        this.label1.Text = "コマンド1";
        // 
        // textBox1
        // 
        this.textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        this.textBox1.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
        this.textBox1.Location = new Point(57, 2);
        this.textBox1.Margin = new Padding(3, 0, 3, 0);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new Size(438, 25);
        this.textBox1.TabIndex = 1;
        // 
        // QCommandView
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.BackColor = SystemColors.Control;
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.label1);
        this.Margin = new Padding(0);
        this.Name = "QCommandView";
        this.Size = new Size(498, 28);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textBox1;
}
