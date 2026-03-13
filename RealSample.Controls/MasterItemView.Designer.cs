namespace RealSample.Controls
{
    partial class MasterItemView
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pnlCreatedAt = new System.Windows.Forms.Panel();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.pnlCreatedAt.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(206, 24);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(4, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(47, 12);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlSummary
            // 
            this.pnlSummary.Controls.Add(this.pnlCategory);
            this.pnlSummary.Controls.Add(this.pnlCreatedAt);
            this.pnlSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSummary.Location = new System.Drawing.Point(0, 24);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(206, 14);
            this.pnlSummary.TabIndex = 1;
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.lblCategory);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategory.Location = new System.Drawing.Point(69, 0);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(137, 14);
            this.pnlCategory.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblCategory.Location = new System.Drawing.Point(6, 1);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(128, 12);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "label1";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlCreatedAt
            // 
            this.pnlCreatedAt.Controls.Add(this.lblCreatedAt);
            this.pnlCreatedAt.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCreatedAt.Location = new System.Drawing.Point(0, 0);
            this.pnlCreatedAt.Name = "pnlCreatedAt";
            this.pnlCreatedAt.Size = new System.Drawing.Size(69, 14);
            this.pnlCreatedAt.TabIndex = 0;
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCreatedAt.Location = new System.Drawing.Point(4, 1);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(41, 12);
            this.lblCreatedAt.TabIndex = 0;
            this.lblCreatedAt.Text = "label2";
            // 
            // MasterItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlTitle);
            this.Name = "MasterItemView";
            this.Size = new System.Drawing.Size(206, 38);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            this.pnlCategory.ResumeLayout(false);
            this.pnlCreatedAt.ResumeLayout(false);
            this.pnlCreatedAt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Panel pnlCreatedAt;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label lblCategory;

    }
}
