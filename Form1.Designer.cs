namespace miniclock
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hacker_styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.widthSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biggersizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.MinimumSize = new System.Drawing.Size(44, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "12:08";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.hacker_styleToolStripMenuItem,
            this.positionToolStripMenuItem,
            this.toolStripMenuItem2,
            this.widthSettingsToolStripMenuItem,
            this.biggersizeToolStripMenuItem,
            this.aDToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 197);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 24);
            this.toolStripMenuItem1.Text = "&next theme";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // hacker_styleToolStripMenuItem
            // 
            this.hacker_styleToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.hacker_styleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hacker_styleToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.AliceBlue;
            this.hacker_styleToolStripMenuItem.Name = "hacker_styleToolStripMenuItem";
            this.hacker_styleToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.hacker_styleToolStripMenuItem.Text = "&style";
            this.hacker_styleToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.hacker_styleToolStripMenuItem.Click += new System.EventHandler(this.hacker_styleToolStripMenuItem_Click);
            // 
            // positionToolStripMenuItem
            // 
            this.positionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topLeftToolStripMenuItem,
            this.topRightToolStripMenuItem});
            this.positionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.positionToolStripMenuItem.Text = "position";
            // 
            // topLeftToolStripMenuItem
            // 
            this.topLeftToolStripMenuItem.Name = "topLeftToolStripMenuItem";
            this.topLeftToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.topLeftToolStripMenuItem.Text = "top &left";
            this.topLeftToolStripMenuItem.Click += new System.EventHandler(this.topLeftToolStripMenuItem_Click);
            // 
            // topRightToolStripMenuItem
            // 
            this.topRightToolStripMenuItem.Name = "topRightToolStripMenuItem";
            this.topRightToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.topRightToolStripMenuItem.Text = "top &right";
            this.topRightToolStripMenuItem.Click += new System.EventHandler(this.topRightToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 24);
            this.toolStripMenuItem2.Text = "width + (&=)";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // widthSettingsToolStripMenuItem
            // 
            this.widthSettingsToolStripMenuItem.Name = "widthSettingsToolStripMenuItem";
            this.widthSettingsToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.widthSettingsToolStripMenuItem.Text = "width - (&-)";
            this.widthSettingsToolStripMenuItem.Click += new System.EventHandler(this.widthSettingsToolStripMenuItem_Click);
            // 
            // biggersizeToolStripMenuItem
            // 
            this.biggersizeToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.biggersizeToolStripMenuItem.Name = "biggersizeToolStripMenuItem";
            this.biggersizeToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.biggersizeToolStripMenuItem.Text = "help";
            this.biggersizeToolStripMenuItem.Click += new System.EventHandler(this.biggersizeToolStripMenuItem_Click);
            // 
            // aDToolStripMenuItem
            // 
            this.aDToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.aDToolStripMenuItem.Name = "aDToolStripMenuItem";
            this.aDToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.aDToolStripMenuItem.Text = "&close";
            this.aDToolStripMenuItem.Click += new System.EventHandler(this.aDToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(411, 93);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MINI clock";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hacker_styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biggersizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widthSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

