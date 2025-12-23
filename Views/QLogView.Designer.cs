namespace CmdQ.Views;

partial class QLogView
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLogView));
        this.TbLog = new RichTextBox();
        this.SuspendLayout();
        // 
        // TbLog
        // 
        this.TbLog.BackColor = SystemColors.ControlLightLight;
        this.TbLog.BorderStyle = BorderStyle.None;
        this.TbLog.Dock = DockStyle.Fill;
        this.TbLog.Font = new Font("BIZ UDPゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.TbLog.Location = new Point(8, 8);
        this.TbLog.Margin = new Padding(3, 2, 3, 2);
        this.TbLog.Name = "TbLog";
        this.TbLog.ReadOnly = true;
        this.TbLog.Size = new Size(688, 425);
        this.TbLog.TabIndex = 0;
        this.TbLog.Text = "";
        // 
        // QLogView
        // 
        this.AutoScaleMode = AutoScaleMode.None;
        this.AutoScroll = true;
        this.BackColor = SystemColors.ControlLightLight;
        this.ClientSize = new Size(704, 441);
        this.Controls.Add(this.TbLog);
        this.Font = new Font("BIZ UDPゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
        this.Icon = (Icon)resources.GetObject("$this.Icon");
        this.Margin = new Padding(3, 2, 3, 2);
        this.Name = "QLogView";
        this.Padding = new Padding(8);
        this.Text = "QLogView";
        this.ResumeLayout(false);
    }

    #endregion

    private RichTextBox TbLog;
}