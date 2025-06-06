namespace Clock
{
    partial class Clock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock));
            this.Time = new System.Windows.Forms.Label();
            this.run = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.皮肤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搪瓷白ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.草莓粉ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.炫酷坤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.展开菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.ExitApp = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NewForm = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.LinkLabel();
            this.Min1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Launch = new System.Windows.Forms.Timer(this.components);
            this.fold = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fold)).BeginInit();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Transparent;
            this.Time.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Time.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Time.Location = new System.Drawing.Point(2, 0);
            this.Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(346, 96);
            this.Time.TabIndex = 0;
            this.Time.Text = "00:00:00";
            this.Time.DoubleClick += new System.EventHandler(this.Time_DoubleClick);
            this.Time.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Time_MouseDown);
            this.Time.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Time_MouseMove);
            this.Time.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Time_MouseUp);
            // 
            // run
            // 
            this.run.Tick += new System.EventHandler(this.run_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "时钟校园版";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.皮肤ToolStripMenuItem,
            this.toolStripSeparator1,
            this.展开菜单ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 130);
            // 
            // 皮肤ToolStripMenuItem
            // 
            this.皮肤ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.搪瓷白ToolStripMenuItem,
            this.草莓粉ToolStripMenuItem,
            this.炫酷坤ToolStripMenuItem});
            this.皮肤ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("皮肤ToolStripMenuItem.Image")));
            this.皮肤ToolStripMenuItem.Name = "皮肤ToolStripMenuItem";
            this.皮肤ToolStripMenuItem.Size = new System.Drawing.Size(198, 40);
            this.皮肤ToolStripMenuItem.Text = "Skins";
            // 
            // 搪瓷白ToolStripMenuItem
            // 
            this.搪瓷白ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("搪瓷白ToolStripMenuItem.Image")));
            this.搪瓷白ToolStripMenuItem.Name = "搪瓷白ToolStripMenuItem";
            this.搪瓷白ToolStripMenuItem.Size = new System.Drawing.Size(270, 42);
            this.搪瓷白ToolStripMenuItem.Text = "White/Black";
            this.搪瓷白ToolStripMenuItem.Click += new System.EventHandler(this.搪瓷白ToolStripMenuItem_Click);
            // 
            // 草莓粉ToolStripMenuItem
            // 
            this.草莓粉ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("草莓粉ToolStripMenuItem.Image")));
            this.草莓粉ToolStripMenuItem.Name = "草莓粉ToolStripMenuItem";
            this.草莓粉ToolStripMenuItem.Size = new System.Drawing.Size(270, 42);
            this.草莓粉ToolStripMenuItem.Text = "Pink";
            this.草莓粉ToolStripMenuItem.Click += new System.EventHandler(this.草莓粉ToolStripMenuItem_Click);
            // 
            // 炫酷坤ToolStripMenuItem
            // 
            this.炫酷坤ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("炫酷坤ToolStripMenuItem.Image")));
            this.炫酷坤ToolStripMenuItem.Name = "炫酷坤ToolStripMenuItem";
            this.炫酷坤ToolStripMenuItem.Size = new System.Drawing.Size(270, 42);
            this.炫酷坤ToolStripMenuItem.Text = "Idol Producer";
            this.炫酷坤ToolStripMenuItem.Click += new System.EventHandler(this.炫酷坤ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);
            // 
            // 展开菜单ToolStripMenuItem
            // 
            this.展开菜单ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("展开菜单ToolStripMenuItem.Image")));
            this.展开菜单ToolStripMenuItem.Name = "展开菜单ToolStripMenuItem";
            this.展开菜单ToolStripMenuItem.Size = new System.Drawing.Size(198, 40);
            this.展开菜单ToolStripMenuItem.Text = "Open menu";
            this.展开菜单ToolStripMenuItem.Click += new System.EventHandler(this.展开菜单ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("退出ToolStripMenuItem.Image")));
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(198, 40);
            this.退出ToolStripMenuItem.Text = "Exit";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(18, 288);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Esc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitApp
            // 
            this.ExitApp.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExitApp.Location = new System.Drawing.Point(178, 140);
            this.ExitApp.Margin = new System.Windows.Forms.Padding(4);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(147, 62);
            this.ExitApp.TabIndex = 3;
            this.ExitApp.Text = "Exit";
            this.ExitApp.UseVisualStyleBackColor = true;
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(18, 140);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 62);
            this.button3.TabIndex = 4;
            this.button3.Text = "Full Scr.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(118, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "JJClock";
            // 
            // NewForm
            // 
            this.NewForm.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewForm.Location = new System.Drawing.Point(18, 210);
            this.NewForm.Margin = new System.Windows.Forms.Padding(4);
            this.NewForm.Name = "NewForm";
            this.NewForm.Size = new System.Drawing.Size(308, 62);
            this.NewForm.TabIndex = 7;
            this.NewForm.Text = "Clone";
            this.NewForm.UseVisualStyleBackColor = true;
            this.NewForm.Click += new System.EventHandler(this.NewForm_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.ActiveLinkColor = System.Drawing.Color.Blue;
            this.AboutButton.AutoSize = true;
            this.AboutButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutButton.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.LinkColor = System.Drawing.Color.Black;
            this.AboutButton.Location = new System.Drawing.Point(141, 81);
            this.AboutButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(47, 22);
            this.AboutButton.TabIndex = 8;
            this.AboutButton.TabStop = true;
            this.AboutButton.Text = "About";
            this.AboutButton.VisitedLinkColor = System.Drawing.Color.Black;
            this.AboutButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutButton_LinkClicked);
            // 
            // Min1
            // 
            this.Min1.Interval = 60000;
            this.Min1.Tick += new System.EventHandler(this.Min1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Maximum = 4000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(345, 8);
            this.progressBar1.TabIndex = 9;
            // 
            // Launch
            // 
            this.Launch.Interval = 1;
            this.Launch.Tick += new System.EventHandler(this.Launch_Tick);
            // 
            // fold
            // 
            this.fold.BackColor = System.Drawing.Color.Transparent;
            this.fold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fold.Image = global::Clock.Properties.Resources.时钟展开;
            this.fold.Location = new System.Drawing.Point(146, 81);
            this.fold.Margin = new System.Windows.Forms.Padding(4);
            this.fold.Name = "fold";
            this.fold.Size = new System.Drawing.Size(56, 18);
            this.fold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fold.TabIndex = 2;
            this.fold.TabStop = false;
            this.fold.Click += new System.EventHandler(this.fold_Click);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(344, 368);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ExitApp);
            this.Controls.Add(this.fold);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.NewForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Time);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Clock";
            this.ShowInTaskbar = false;
            this.Text = "JJClock";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Clock_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clock_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Clock_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Clock_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Clock_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer run;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox fold;
        private System.Windows.Forms.Button ExitApp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewForm;
        private System.Windows.Forms.LinkLabel AboutButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 皮肤ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 展开菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搪瓷白ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 草莓粉ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 炫酷坤ToolStripMenuItem;
        private System.Windows.Forms.Timer Min1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer Launch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

