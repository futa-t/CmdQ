namespace CmdQ.Views;

partial class QLogWindow
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLogWindow));
        this.Qlv = new QLogView();
        this.SuspendLayout();
        // 
        // Qlv
        // 
        this.Qlv.Dock = DockStyle.Fill;
        this.Qlv.Location = new Point(8, 8);
        this.Qlv.Name = "Qlv";
        this.Qlv.Size = new Size(688, 425);
        this.Qlv.TabIndex = 0;
        // 
        // QLogWindow
        // 
        this.AutoScaleMode = AutoScaleMode.None;
        this.AutoScroll = true;
        this.BackColor = SystemColors.Control;
        this.ClientSize = new Size(704, 441);
        this.Controls.Add(this.Qlv);
        this.Font = new Font("BIZ UDPゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
        this.Icon = (Icon)resources.GetObject("$this.Icon");
        this.Margin = new Padding(3, 2, 3, 2);
        this.Name = "QLogWindow";
        this.Padding = new Padding(8);
        this.Text = "QLogView";
        this.ResumeLayout(false);
    }

    #endregion

    private QLogView Qlv;
}