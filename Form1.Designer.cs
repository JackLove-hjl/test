namespace 菜单
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wenjianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xinjianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dakaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baocunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lingcunAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tuichutoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bianjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chexiaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.jianqieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuzhiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zhantieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.全选AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riqiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geshiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zidongWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zitiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gongjuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zhuangtaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.shouqi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wenjianToolStripMenuItem,
            this.bianjiToolStripMenuItem,
            this.geshiToolStripMenuItem,
            this.查看VToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wenjianToolStripMenuItem
            // 
            this.wenjianToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xinjianToolStripMenuItem,
            this.dakaiToolStripMenuItem,
            this.baocunToolStripMenuItem,
            this.lingcunAToolStripMenuItem,
            this.toolStripSeparator2,
            this.tuichutoolStripMenuItem2});
            this.wenjianToolStripMenuItem.Name = "wenjianToolStripMenuItem";
            this.wenjianToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.wenjianToolStripMenuItem.Text = "文件(&F)";
            // 
            // xinjianToolStripMenuItem
            // 
            this.xinjianToolStripMenuItem.Name = "xinjianToolStripMenuItem";
            this.xinjianToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.xinjianToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.xinjianToolStripMenuItem.Text = "新建(N)";
            this.xinjianToolStripMenuItem.Click += new System.EventHandler(this.新建NToolStripMenuItem_Click);
            // 
            // dakaiToolStripMenuItem
            // 
            this.dakaiToolStripMenuItem.Name = "dakaiToolStripMenuItem";
            this.dakaiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.dakaiToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.dakaiToolStripMenuItem.Text = "打开(O)";
            this.dakaiToolStripMenuItem.Click += new System.EventHandler(this.dakaiToolStripMenuItem_Click);
            // 
            // baocunToolStripMenuItem
            // 
            this.baocunToolStripMenuItem.Name = "baocunToolStripMenuItem";
            this.baocunToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.baocunToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.baocunToolStripMenuItem.Text = "保存";
            this.baocunToolStripMenuItem.Click += new System.EventHandler(this.baocunToolStripMenuItem_Click);
            // 
            // lingcunAToolStripMenuItem
            // 
            this.lingcunAToolStripMenuItem.Name = "lingcunAToolStripMenuItem";
            this.lingcunAToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.lingcunAToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.lingcunAToolStripMenuItem.Text = "另存为(A)";
            this.lingcunAToolStripMenuItem.Click += new System.EventHandler(this.lingcunAToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(254, 6);
            // 
            // tuichutoolStripMenuItem2
            // 
            this.tuichutoolStripMenuItem2.Name = "tuichutoolStripMenuItem2";
            this.tuichutoolStripMenuItem2.Size = new System.Drawing.Size(257, 26);
            this.tuichutoolStripMenuItem2.Text = "退出(&X)";
            this.tuichutoolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // bianjiToolStripMenuItem
            // 
            this.bianjiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chexiaoToolStripMenuItem,
            this.toolStripSeparator3,
            this.jianqieToolStripMenuItem,
            this.fuzhiToolStripMenuItem,
            this.zhantieToolStripMenuItem,
            this.toolStripSeparator4,
            this.全选AToolStripMenuItem,
            this.riqiToolStripMenuItem});
            this.bianjiToolStripMenuItem.Name = "bianjiToolStripMenuItem";
            this.bianjiToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.bianjiToolStripMenuItem.Text = "编辑(E)";
            // 
            // chexiaoToolStripMenuItem
            // 
            this.chexiaoToolStripMenuItem.Enabled = false;
            this.chexiaoToolStripMenuItem.Name = "chexiaoToolStripMenuItem";
            this.chexiaoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.chexiaoToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.chexiaoToolStripMenuItem.Text = "撤销(U)";
            this.chexiaoToolStripMenuItem.Click += new System.EventHandler(this.chexiaoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(202, 6);
            // 
            // jianqieToolStripMenuItem
            // 
            this.jianqieToolStripMenuItem.Enabled = false;
            this.jianqieToolStripMenuItem.Name = "jianqieToolStripMenuItem";
            this.jianqieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.jianqieToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.jianqieToolStripMenuItem.Text = "剪切(T)";
            this.jianqieToolStripMenuItem.Click += new System.EventHandler(this.jianqieToolStripMenuItem_Click);
            // 
            // fuzhiToolStripMenuItem
            // 
            this.fuzhiToolStripMenuItem.Enabled = false;
            this.fuzhiToolStripMenuItem.Name = "fuzhiToolStripMenuItem";
            this.fuzhiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.fuzhiToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.fuzhiToolStripMenuItem.Text = "复制(C)";
            this.fuzhiToolStripMenuItem.Click += new System.EventHandler(this.fuzhiToolStripMenuItem_Click);
            // 
            // zhantieToolStripMenuItem
            // 
            this.zhantieToolStripMenuItem.Enabled = false;
            this.zhantieToolStripMenuItem.Name = "zhantieToolStripMenuItem";
            this.zhantieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.zhantieToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.zhantieToolStripMenuItem.Text = "粘贴(P)";
            this.zhantieToolStripMenuItem.Click += new System.EventHandler(this.zhantieToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(202, 6);
            // 
            // 全选AToolStripMenuItem
            // 
            this.全选AToolStripMenuItem.Name = "全选AToolStripMenuItem";
            this.全选AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.全选AToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.全选AToolStripMenuItem.Text = "全选(A)";
            this.全选AToolStripMenuItem.Click += new System.EventHandler(this.全选AToolStripMenuItem_Click);
            // 
            // riqiToolStripMenuItem
            // 
            this.riqiToolStripMenuItem.Name = "riqiToolStripMenuItem";
            this.riqiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.riqiToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.riqiToolStripMenuItem.Text = "时间/日期(D)";
            this.riqiToolStripMenuItem.Click += new System.EventHandler(this.riqiToolStripMenuItem_Click);
            // 
            // geshiToolStripMenuItem
            // 
            this.geshiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zidongWToolStripMenuItem,
            this.zitiToolStripMenuItem});
            this.geshiToolStripMenuItem.Name = "geshiToolStripMenuItem";
            this.geshiToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.geshiToolStripMenuItem.Text = "格式(O)";
            // 
            // zidongWToolStripMenuItem
            // 
            this.zidongWToolStripMenuItem.Checked = true;
            this.zidongWToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zidongWToolStripMenuItem.Name = "zidongWToolStripMenuItem";
            this.zidongWToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.zidongWToolStripMenuItem.Text = "自动换行(W)";
            this.zidongWToolStripMenuItem.Click += new System.EventHandler(this.zidongToolStripMenuItem_Click);
            // 
            // zitiToolStripMenuItem
            // 
            this.zitiToolStripMenuItem.Name = "zitiToolStripMenuItem";
            this.zitiToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.zitiToolStripMenuItem.Text = "字体(F)";
            this.zitiToolStripMenuItem.Click += new System.EventHandler(this.zitiToolStripMenuItem_Click);
            // 
            // 查看VToolStripMenuItem
            // 
            this.查看VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gongjuToolStripMenuItem,
            this.zhuangtaiToolStripMenuItem});
            this.查看VToolStripMenuItem.Name = "查看VToolStripMenuItem";
            this.查看VToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.查看VToolStripMenuItem.Text = "查看(V)";
            // 
            // gongjuToolStripMenuItem
            // 
            this.gongjuToolStripMenuItem.Checked = true;
            this.gongjuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gongjuToolStripMenuItem.Name = "gongjuToolStripMenuItem";
            this.gongjuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.gongjuToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.gongjuToolStripMenuItem.Text = "工具栏(Z)";
            this.gongjuToolStripMenuItem.Click += new System.EventHandler(this.gongjuToolStripMenuItem_Click);
            // 
            // zhuangtaiToolStripMenuItem
            // 
            this.zhuangtaiToolStripMenuItem.Checked = true;
            this.zhuangtaiToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zhuangtaiToolStripMenuItem.Name = "zhuangtaiToolStripMenuItem";
            this.zhuangtaiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.zhuangtaiToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.zhuangtaiToolStripMenuItem.Text = "状态栏(S)";
            this.zhuangtaiToolStripMenuItem.Click += new System.EventHandler(this.zhuangtaiToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.帮助HToolStripMenuItem.Text = "帮助(H)";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.aboutToolStripMenuItem.Text = "关于记事本(A)";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(158, 72);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(499, 334);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(657, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(0, 4, 60, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel1.Text = "字数：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(0, 4, 60, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(102, 20);
            this.toolStripStatusLabel2.Text = "第1行，第1列";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(52, 20);
            this.toolStripStatusLabel3.Text = "UTF-8";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "无标题";
            this.openFileDialog1.Multiselect = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "无标题";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator7,
            this.shouqi,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator5,
            this.toolStripButton3,
            this.toolStripSeparator6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(657, 32);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 32);
            // 
            // shouqi
            // 
            this.shouqi.Checked = true;
            this.shouqi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shouqi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shouqi.Image = ((System.Drawing.Image)(resources.GetObject("shouqi.Image")));
            this.shouqi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.shouqi.Name = "shouqi";
            this.shouqi.Size = new System.Drawing.Size(29, 29);
            this.shouqi.Text = "收起侧栏";
            this.shouqi.Click += new System.EventHandler(this.shouqi_Click);
            this.shouqi.MouseHover += new System.EventHandler(this.toolStripButton1_MouseHover);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton2.Text = "打开";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton3.Text = "另存为";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 32);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(0, 72);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(159, 333);
            this.treeView1.TabIndex = 4;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "shouqi.png");
            this.imageList1.Images.SetKeyName(1, "zhankai.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(657, 437);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "记事本";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wenjianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xinjianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dakaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baocunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lingcunAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bianjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geshiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tuichutoolStripMenuItem2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem chexiaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem jianqieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuzhiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zhantieToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 全选AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riqiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zidongWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gongjuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zhuangtaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem zitiToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton shouqi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

