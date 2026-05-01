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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tsLeft = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.detailView = new RealSample.Controls.DetailView();
            this.menuStrip1.SuspendLayout();
            this.pnlMainContainer.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
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
            this.lstMaster.Location = new System.Drawing.Point(0, 24);
            this.lstMaster.Name = "lstMaster";
            this.lstMaster.Size = new System.Drawing.Size(172, 251);
            this.lstMaster.TabIndex = 1;
            this.lstMaster.SelectedIndexChanged += new System.EventHandler(this.lstMaster_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDirectory);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 24);
            this.panel1.TabIndex = 0;
            // 
            // txtDirectory
            // 
            this.txtDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDirectory.Location = new System.Drawing.Point(0, 0);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(99, 21);
            this.txtDirectory.TabIndex = 1;
            this.txtDirectory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDirectory_KeyUp);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBrowse.Location = new System.Drawing.Point(99, 0);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(73, 24);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "浏览(&B)...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tsLeft
            // 
            this.tsLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsLeft.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbDelete});
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
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Enabled = false;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "toolStripButton1";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tsLeft.ResumeLayout(false);
            this.tsLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlMainContainer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem mniAboutGroup;
        private RealSample.Controls.ItemsControl lstMaster;
        private RealSample.Controls.DetailView detailView;
        private System.Windows.Forms.ToolStripMenuItem mniEditGroup;
        private System.Windows.Forms.ToolStrip tsLeft;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.ToolStripButton tsbDelete;
    }
}

