namespace WindowsMedia_with_List
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileCodinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.thứToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nămToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.list_FileNhac = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.timer_ThoiGian = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lisl_codinh = new System.Windows.Forms.ListBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.càiĐătToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.thứToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openFileCodinhToolStripMenuItem,
            this.btSetting});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.openFileToolStripMenuItem.Text = "&Open File...";
            this.openFileToolStripMenuItem.Visible = false;
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openFileCodinhToolStripMenuItem
            // 
            this.openFileCodinhToolStripMenuItem.Name = "openFileCodinhToolStripMenuItem";
            this.openFileCodinhToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.openFileCodinhToolStripMenuItem.Text = "Open File codinh...";
            this.openFileCodinhToolStripMenuItem.Visible = false;
            this.openFileCodinhToolStripMenuItem.Click += new System.EventHandler(this.openFileCodinhToolStripMenuItem_Click);
            // 
            // btSetting
            // 
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(173, 22);
            this.btSetting.Text = "Setting";
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            // 
            // thứToolStripMenuItem
            // 
            this.thứToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.haiToolStripMenuItem,
            this.baToolStripMenuItem,
            this.tưToolStripMenuItem,
            this.nămToolStripMenuItem,
            this.sáuToolStripMenuItem,
            this.bảyToolStripMenuItem,
            this.codinhToolStripMenuItem});
            this.thứToolStripMenuItem.Name = "thứToolStripMenuItem";
            this.thứToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.thứToolStripMenuItem.Text = "Thứ";
            this.thứToolStripMenuItem.Visible = false;
            // 
            // haiToolStripMenuItem
            // 
            this.haiToolStripMenuItem.Name = "haiToolStripMenuItem";
            this.haiToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.haiToolStripMenuItem.Text = "hai";
            this.haiToolStripMenuItem.Click += new System.EventHandler(this.haiToolStripMenuItem_Click);
            // 
            // baToolStripMenuItem
            // 
            this.baToolStripMenuItem.Name = "baToolStripMenuItem";
            this.baToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.baToolStripMenuItem.Text = "ba";
            // 
            // tưToolStripMenuItem
            // 
            this.tưToolStripMenuItem.Name = "tưToolStripMenuItem";
            this.tưToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.tưToolStripMenuItem.Text = "tư";
            // 
            // nămToolStripMenuItem
            // 
            this.nămToolStripMenuItem.Name = "nămToolStripMenuItem";
            this.nămToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.nămToolStripMenuItem.Text = "năm";
            // 
            // sáuToolStripMenuItem
            // 
            this.sáuToolStripMenuItem.Name = "sáuToolStripMenuItem";
            this.sáuToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sáuToolStripMenuItem.Text = "sáu";
            // 
            // bảyToolStripMenuItem
            // 
            this.bảyToolStripMenuItem.Name = "bảyToolStripMenuItem";
            this.bảyToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.bảyToolStripMenuItem.Text = "bảy";
            // 
            // codinhToolStripMenuItem
            // 
            this.codinhToolStripMenuItem.Name = "codinhToolStripMenuItem";
            this.codinhToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.codinhToolStripMenuItem.Text = "Codinh";
            this.codinhToolStripMenuItem.Click += new System.EventHandler(this.codinhToolStripMenuItem_Click);
            // 
            // list_FileNhac
            // 
            this.list_FileNhac.FormattingEnabled = true;
            this.list_FileNhac.Location = new System.Drawing.Point(1076, 24);
            this.list_FileNhac.Name = "list_FileNhac";
            this.list_FileNhac.Size = new System.Drawing.Size(19, 524);
            this.list_FileNhac.TabIndex = 2;
            this.list_FileNhac.SelectedIndexChanged += new System.EventHandler(this.list_FileNhac_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(869, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 528);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Mp3|*.mp3|Wav|*wav|Mp4|*.mp4";
            this.openFileDialog1.Multiselect = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(285, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "start";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(353, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(113, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Auto start with Wd";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // timer_ThoiGian
            // 
            this.timer_ThoiGian.Interval = 1000;
            this.timer_ThoiGian.Tick += new System.EventHandler(this.timer_ThoiGian_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lisl_codinh
            // 
            this.lisl_codinh.FormattingEnabled = true;
            this.lisl_codinh.Location = new System.Drawing.Point(1101, 24);
            this.lisl_codinh.Name = "lisl_codinh";
            this.lisl_codinh.Size = new System.Drawing.Size(12, 524);
            this.lisl_codinh.TabIndex = 2;
            this.lisl_codinh.SelectedIndexChanged += new System.EventHandler(this.list_FileNhac_SelectedIndexChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AuTo_Music";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.càiĐătToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 48);
            // 
            // càiĐătToolStripMenuItem
            // 
            this.càiĐătToolStripMenuItem.Name = "càiĐătToolStripMenuItem";
            this.càiĐătToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.càiĐătToolStripMenuItem.Text = "Cài đăt";
            this.càiĐătToolStripMenuItem.Click += new System.EventHandler(this.càiĐătToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(565, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 24);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(869, 528);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 552);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lisl_codinh);
            this.Controls.Add(this.list_FileNhac);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ListBox list_FileNhac;
        private System.Windows.Forms.Splitter splitter1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem thứToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tưToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nămToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảyToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Timer timer_ThoiGian;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lisl_codinh;
        private System.Windows.Forms.ToolStripMenuItem openFileCodinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codinhToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem càiĐătToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem btSetting;
        private System.Windows.Forms.Timer timer3;
    }
}

