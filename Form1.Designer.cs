namespace CmdQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new SplitContainer();
            this.Gb_Items = new GroupBox();
            this.Flp_items = new FlowLayoutPanel();
            this.button1 = new Button();
            this.Pnl_Cmd = new GroupBox();
            this.textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Gb_Items.SuspendLayout();
            this.Pnl_Cmd.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.CausesValidation = false;
            this.splitContainer1.Dock = DockStyle.Fill;
            this.splitContainer1.Location = new Point(4, 2);
            this.splitContainer1.Margin = new Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Gb_Items);
            this.splitContainer1.Panel1.Padding = new Padding(2, 4, 2, 4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.Pnl_Cmd);
            this.splitContainer1.Panel2.Padding = new Padding(2, 4, 2, 4);
            this.splitContainer1.Size = new Size(1256, 677);
            this.splitContainer1.SplitterDistance = 720;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // Gb_Items
            // 
            this.Gb_Items.Controls.Add(this.Flp_items);
            this.Gb_Items.Dock = DockStyle.Fill;
            this.Gb_Items.Location = new Point(2, 4);
            this.Gb_Items.Margin = new Padding(3, 2, 3, 2);
            this.Gb_Items.Name = "Gb_Items";
            this.Gb_Items.Padding = new Padding(3, 2, 3, 2);
            this.Gb_Items.Size = new Size(716, 669);
            this.Gb_Items.TabIndex = 0;
            this.Gb_Items.TabStop = false;
            this.Gb_Items.Text = "キュー";
            // 
            // Flp_items
            // 
            this.Flp_items.AutoScroll = true;
            this.Flp_items.Dock = DockStyle.Fill;
            this.Flp_items.FlowDirection = FlowDirection.TopDown;
            this.Flp_items.Location = new Point(3, 14);
            this.Flp_items.Name = "Flp_items";
            this.Flp_items.Size = new Size(710, 653);
            this.Flp_items.TabIndex = 0;
            this.Flp_items.WrapContents = false;
            this.Flp_items.DragDrop += this.Gb_Items_DragDrop;
            this.Flp_items.DragEnter += this.Gb_Items_DragEnter;
            // 
            // button1
            // 
            this.button1.Location = new Point(30, 629);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            // 
            // Pnl_Cmd
            // 
            this.Pnl_Cmd.Controls.Add(this.textBox1);
            this.Pnl_Cmd.Dock = DockStyle.Top;
            this.Pnl_Cmd.Location = new Point(2, 4);
            this.Pnl_Cmd.Margin = new Padding(3, 2, 3, 2);
            this.Pnl_Cmd.Name = "Pnl_Cmd";
            this.Pnl_Cmd.Padding = new Padding(4, 8, 4, 8);
            this.Pnl_Cmd.Size = new Size(530, 247);
            this.Pnl_Cmd.TabIndex = 0;
            this.Pnl_Cmd.TabStop = false;
            this.Pnl_Cmd.Text = "コマンド";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.textBox1.Location = new Point(7, 22);
            this.textBox1.Margin = new Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(516, 19);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = AutoScaleMode.None;
            this.ClientSize = new Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.Font = new Font("BIZ UDPゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.Margin = new Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Padding = new Padding(4, 2, 4, 2);
            this.Text = "CmdQ";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Gb_Items.ResumeLayout(false);
            this.Pnl_Cmd.ResumeLayout(false);
            this.Pnl_Cmd.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox Pnl_Cmd;
        private TextBox textBox1;
        private GroupBox Gb_Items;
        private FlowLayoutPanel Flp_items;
        private Button button1;
    }
}
