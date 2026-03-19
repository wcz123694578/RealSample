namespace RealSample.Presentations.Views
{
    partial class MainView
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniEditGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAboutGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstMaster = new RealSample.Controls.ItemsControl();
            this.cbDirectory = new System.Windows.Forms.ComboBox();
            this.tsLeft = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.detailView = new RealSample.Controls.DetailView();
            this.menuStrip1.SuspendLayout();
            this.pnlMainContainer.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tsLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniEditGroup,
            this.mniAboutGroup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(516, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniEditGroup
            // 
            this.mniEditGroup.Name = "mniEditGroup";
            this.mniEditGroup.Size = new System.Drawing.Size(59, 20);
            this.mniEditGroup.Text = "编辑(&E)";
            // 
            // mniAboutGroup
            // 
            this.mniAboutGroup.Name = "mniAboutGroup";
            this.mniAboutGroup.Size = new System.Drawing.Size(59, 20);
            this.mniAboutGroup.Text = "关于(&A)";
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Controls.Add(this.splitContainer1);
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 24);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(516, 300);
            this.pnlMainContainer.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstMaster);
            this.splitContainer1.Panel1.Controls.Add(this.cbDirectory);
            this.splitContainer1.Panel1.Controls.Add(this.tsLeft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.detailView);
            this.splitContainer1.Size = new System.Drawing.Size(516, 300);
            this.splitContainer1.SplitterDistance = 172;
            this.splitContainer1.TabIndex = 0;
            // 
            // lstMaster
            // 
            this.lstMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMaster.Location = new System.Drawing.Point(0, 20);
            this.lstMaster.Name = "lstMaster";
            this.lstMaster.Size = new System.Drawing.Size(172, 255);
            this.lstMaster.TabIndex = 1;
            this.lstMaster.SelectedIndexChanged += new System.EventHandler(this.lstMaster_SelectedIndexChanged);
            // 
            // cbDirectory
            // 
            this.cbDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDirectory.FormattingEnabled = true;
            this.cbDirectory.Location = new System.Drawing.Point(0, 0);
            this.cbDirectory.Name = "cbDirectory";
            this.cbDirectory.Size = new System.Drawing.Size(172, 20);
            this.cbDirectory.TabIndex = 0;
            // 
            // tsLeft
            // 
            this.tsLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsLeft.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd});
            this.tsLeft.Location = new System.Drawing.Point(0, 275);
            this.tsLeft.Name = "tsLeft";
            this.tsLeft.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsLeft.Size = new System.Drawing.Size(172, 25);
            this.tsLeft.TabIndex = 0;
            this.tsLeft.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Text = "toolStripButton1";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // detailView
            // 
            this.detailView.CategoryName = "label2";
            this.detailView.Commands = null;
            this.detailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailView.FilePath = "";
            this.detailView.Location = new System.Drawing.Point(0, 0);
            this.detailView.Name = "detailView";
            this.detailView.Size = new System.Drawing.Size(340, 300);
            this.detailView.TabIndex = 0;
            this.detailView.Title = "label1";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 324);
            this.Controls.Add(this.pnlMainContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMainContainer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tsLeft.ResumeLayout(false);
            this.tsLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlMainContainer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cbDirectory;
        private System.Windows.Forms.ToolStripMenuItem mniAboutGroup;
        private RealSample.Controls.ItemsControl lstMaster;
        private RealSample.Controls.DetailView detailView;
        private System.Windows.Forms.ToolStripMenuItem mniEditGroup;
        private System.Windows.Forms.ToolStrip tsLeft;
        private System.Windows.Forms.ToolStripButton tsbAdd;
    }
}

