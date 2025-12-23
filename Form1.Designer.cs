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
            this.groupBox3 = new GroupBox();
            this.BtnQSClear = new Button();
            this.BtnQClear = new Button();
            this.Gb_Items = new GroupBox();
            this.Flp_Items = new FlowLayoutPanel();
            this.groupBox2 = new GroupBox();
            this.Qlv = new CmdQ.Views.QLogView();
            this.groupBox1 = new GroupBox();
            this.button9 = new Button();
            this.button2 = new Button();
            this.button4 = new Button();
            this.button6 = new Button();
            this.button5 = new Button();
            this.button8 = new Button();
            this.button3 = new Button();
            this.Pnl_Cmd = new GroupBox();
            this.panel1 = new Panel();
            this.Btn_CmdAdd = new Button();
            this.Btn_Test = new Button();
            this.Btn_CmdReplace = new Button();
            this.Btn_CmdParallel = new Button();
            this.Btn_CmdExecute = new Button();
            this.Flp_Cmd = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Gb_Items.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Pnl_Cmd.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.Gb_Items);
            this.splitContainer1.Panel1.Padding = new Padding(2, 4, 2, 4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.Pnl_Cmd);
            this.splitContainer1.Panel2.Padding = new Padding(2, 4, 2, 4);
            this.splitContainer1.Size = new Size(1256, 677);
            this.splitContainer1.SplitterDistance = 720;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.groupBox3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.BtnQSClear);
            this.groupBox3.Controls.Add(this.BtnQClear);
            this.groupBox3.Location = new Point(0, 621);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(718, 53);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "キュー操作";
            // 
            // BtnQSClear
            // 
            this.BtnQSClear.Location = new Point(87, 19);
            this.BtnQSClear.Name = "BtnQSClear";
            this.BtnQSClear.Size = new Size(112, 23);
            this.BtnQSClear.TabIndex = 0;
            this.BtnQSClear.Text = "完了済みをクリア";
            this.BtnQSClear.UseVisualStyleBackColor = true;
            this.BtnQSClear.Click += this.BtnQSClear_Click;
            // 
            // BtnQClear
            // 
            this.BtnQClear.Location = new Point(6, 19);
            this.BtnQClear.Name = "BtnQClear";
            this.BtnQClear.Size = new Size(75, 23);
            this.BtnQClear.TabIndex = 0;
            this.BtnQClear.Text = "全クリア";
            this.BtnQClear.UseVisualStyleBackColor = true;
            this.BtnQClear.Click += this.BtnQClear_Click;
            // 
            // Gb_Items
            // 
            this.Gb_Items.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.Gb_Items.Controls.Add(this.Flp_Items);
            this.Gb_Items.Location = new Point(2, 4);
            this.Gb_Items.Margin = new Padding(3, 2, 3, 2);
            this.Gb_Items.Name = "Gb_Items";
            this.Gb_Items.Padding = new Padding(3, 2, 3, 2);
            this.Gb_Items.Size = new Size(716, 618);
            this.Gb_Items.TabIndex = 0;
            this.Gb_Items.TabStop = false;
            this.Gb_Items.Text = "キュー";
            // 
            // Flp_Items
            // 
            this.Flp_Items.AutoScroll = true;
            this.Flp_Items.Dock = DockStyle.Fill;
            this.Flp_Items.FlowDirection = FlowDirection.TopDown;
            this.Flp_Items.Location = new Point(3, 14);
            this.Flp_Items.Name = "Flp_Items";
            this.Flp_Items.Size = new Size(710, 602);
            this.Flp_Items.TabIndex = 0;
            this.Flp_Items.WrapContents = false;
            this.Flp_Items.DragDrop += this.Gb_Items_DragDrop;
            this.Flp_Items.DragEnter += this.Gb_Items_DragEnter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Qlv);
            this.groupBox2.Dock = DockStyle.Fill;
            this.groupBox2.Location = new Point(2, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new Padding(8, 4, 8, 4);
            this.groupBox2.Size = new Size(530, 341);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ログ";
            // 
            // Qlv
            // 
            this.Qlv.Dock = DockStyle.Fill;
            this.Qlv.Location = new Point(8, 16);
            this.Qlv.Name = "Qlv";
            this.Qlv.Size = new Size(514, 321);
            this.Qlv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Dock = DockStyle.Top;
            this.groupBox1.Location = new Point(2, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(530, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "テンプレート";
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.Location = new Point(266, 49);
            this.button9.Name = "button9";
            this.button9.Size = new Size(175, 25);
            this.button9.TabIndex = 5;
            this.button9.Tag = "{stem}";
            this.button9.Text = "ファイル名(拡張子なし)";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += this.InsertTemplate;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new Point(88, 49);
            this.button2.Name = "button2";
            this.button2.Size = new Size(172, 25);
            this.button2.TabIndex = 5;
            this.button2.Tag = "{fullstem}";
            this.button2.Text = "パス+ファイル名(拡張子なし)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.InsertTemplate;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new Point(7, 49);
            this.button4.Name = "button4";
            this.button4.Size = new Size(75, 25);
            this.button4.TabIndex = 4;
            this.button4.Tag = "{parent}";
            this.button4.Text = "親フォルダ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += this.InsertTemplate;
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new Point(7, 18);
            this.button6.Name = "button6";
            this.button6.Size = new Size(75, 25);
            this.button6.TabIndex = 4;
            this.button6.Tag = "{path}";
            this.button6.Text = "フルパス";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += this.InsertTemplate;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new Point(295, 18);
            this.button5.Name = "button5";
            this.button5.Size = new Size(75, 25);
            this.button5.TabIndex = 4;
            this.button5.Tag = "{ext}";
            this.button5.Text = "拡張子";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += this.InsertTemplate;
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.Location = new Point(196, 18);
            this.button8.Name = "button8";
            this.button8.Size = new Size(93, 25);
            this.button8.TabIndex = 4;
            this.button8.Tag = "{name}";
            this.button8.Text = "ファイル名";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += this.InsertTemplate;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new Point(88, 18);
            this.button3.Name = "button3";
            this.button3.Size = new Size(102, 25);
            this.button3.TabIndex = 4;
            this.button3.Tag = "{fullname}";
            this.button3.Text = "パス+ファイル名";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += this.InsertTemplate;
            // 
            // Pnl_Cmd
            // 
            this.Pnl_Cmd.Controls.Add(this.panel1);
            this.Pnl_Cmd.Controls.Add(this.Flp_Cmd);
            this.Pnl_Cmd.Dock = DockStyle.Top;
            this.Pnl_Cmd.Location = new Point(2, 4);
            this.Pnl_Cmd.Margin = new Padding(3, 2, 3, 2);
            this.Pnl_Cmd.Name = "Pnl_Cmd";
            this.Pnl_Cmd.Padding = new Padding(3, 2, 3, 2);
            this.Pnl_Cmd.Size = new Size(530, 242);
            this.Pnl_Cmd.TabIndex = 0;
            this.Pnl_Cmd.TabStop = false;
            this.Pnl_Cmd.Text = "コマンド";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_CmdAdd);
            this.panel1.Controls.Add(this.Btn_Test);
            this.panel1.Controls.Add(this.Btn_CmdReplace);
            this.panel1.Controls.Add(this.Btn_CmdParallel);
            this.panel1.Controls.Add(this.Btn_CmdExecute);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(3, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(524, 38);
            this.panel1.TabIndex = 5;
            // 
            // Btn_CmdAdd
            // 
            this.Btn_CmdAdd.AutoSize = true;
            this.Btn_CmdAdd.Location = new Point(4, 6);
            this.Btn_CmdAdd.Name = "Btn_CmdAdd";
            this.Btn_CmdAdd.Size = new Size(75, 25);
            this.Btn_CmdAdd.TabIndex = 1;
            this.Btn_CmdAdd.Text = "追加";
            this.Btn_CmdAdd.UseVisualStyleBackColor = true;
            this.Btn_CmdAdd.Click += this.BtnCmdAddClick;
            // 
            // Btn_Test
            // 
            this.Btn_Test.AutoSize = true;
            this.Btn_Test.Location = new Point(85, 6);
            this.Btn_Test.Name = "Btn_Test";
            this.Btn_Test.Size = new Size(75, 25);
            this.Btn_Test.TabIndex = 1;
            this.Btn_Test.Text = "テスト";
            this.Btn_Test.UseVisualStyleBackColor = true;
            this.Btn_Test.Click += this.BtnTestClick;
            // 
            // Btn_CmdReplace
            // 
            this.Btn_CmdReplace.AutoSize = true;
            this.Btn_CmdReplace.Location = new Point(166, 6);
            this.Btn_CmdReplace.Name = "Btn_CmdReplace";
            this.Btn_CmdReplace.Size = new Size(82, 25);
            this.Btn_CmdReplace.TabIndex = 3;
            this.Btn_CmdReplace.Text = "コマンド確認";
            this.Btn_CmdReplace.UseVisualStyleBackColor = true;
            this.Btn_CmdReplace.Click += this.BtnCmdReplaceClick;
            // 
            // Btn_CmdParallel
            // 
            this.Btn_CmdParallel.AutoSize = true;
            this.Btn_CmdParallel.Location = new Point(361, 6);
            this.Btn_CmdParallel.Name = "Btn_CmdParallel";
            this.Btn_CmdParallel.Size = new Size(75, 25);
            this.Btn_CmdParallel.TabIndex = 2;
            this.Btn_CmdParallel.Text = "並列実行";
            this.Btn_CmdParallel.UseVisualStyleBackColor = true;
            this.Btn_CmdParallel.Click += this.BtnCmdParallel_Click;
            // 
            // Btn_CmdExecute
            // 
            this.Btn_CmdExecute.AutoSize = true;
            this.Btn_CmdExecute.Location = new Point(442, 6);
            this.Btn_CmdExecute.Name = "Btn_CmdExecute";
            this.Btn_CmdExecute.Size = new Size(75, 25);
            this.Btn_CmdExecute.TabIndex = 2;
            this.Btn_CmdExecute.Text = "実行";
            this.Btn_CmdExecute.UseVisualStyleBackColor = true;
            this.Btn_CmdExecute.Click += this.BtnCmdExecuteClick;
            // 
            // Flp_Cmd
            // 
            this.Flp_Cmd.AutoScroll = true;
            this.Flp_Cmd.Dock = DockStyle.Top;
            this.Flp_Cmd.FlowDirection = FlowDirection.TopDown;
            this.Flp_Cmd.Location = new Point(3, 14);
            this.Flp_Cmd.Margin = new Padding(0);
            this.Flp_Cmd.Name = "Flp_Cmd";
            this.Flp_Cmd.Size = new Size(524, 185);
            this.Flp_Cmd.TabIndex = 4;
            this.Flp_Cmd.WrapContents = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = AutoScaleMode.None;
            this.ClientSize = new Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
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
            this.groupBox3.ResumeLayout(false);
            this.Gb_Items.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Pnl_Cmd.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox Pnl_Cmd;
        private GroupBox Gb_Items;
        private Button Btn_Test;
        private FlowLayoutPanel Flp_Items;
        private Button Btn_CmdReplace;
        private Button Btn_CmdExecute;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private Button button4;
        private Button button5;
        private GroupBox groupBox2;
        private Button button6;
        private Panel panel1;
        private FlowLayoutPanel Flp_Cmd;
        private Button Btn_CmdAdd;
        private Button button9;
        private Button button8;
        private GroupBox groupBox3;
        private Button BtnQClear;
        private Button BtnQSClear;
        private Button Btn_CmdParallel;
        private Views.QLogView Qlv;
    }
}
