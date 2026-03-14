namespace RealSample.Controls {
    partial class DetailView {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.tcDetailInfo = new System.Windows.Forms.TabControl();
            this.tpAssetInfo = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpFileInfo = new System.Windows.Forms.TabPage();
            this.txtFileInfo = new System.Windows.Forms.TextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tcDetailInfo.SuspendLayout();
            this.tpAssetInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpFileInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 29);
            this.panel1.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategory.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCategory.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblCategory.Location = new System.Drawing.Point(364, 4);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 23);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "label2";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(9, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(47, 12);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlPreview);
            this.panel2.Controls.Add(this.tcDetailInfo);
            this.panel2.Controls.Add(this.toolStrip);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 344);
            this.panel2.TabIndex = 1;
            // 
            // pnlPreview
            // 
            this.pnlPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPreview.Location = new System.Drawing.Point(0, 25);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(466, 182);
            this.pnlPreview.TabIndex = 1;
            // 
            // tcDetailInfo
            // 
            this.tcDetailInfo.Controls.Add(this.tpAssetInfo);
            this.tcDetailInfo.Controls.Add(this.tpFileInfo);
            this.tcDetailInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tcDetailInfo.Location = new System.Drawing.Point(0, 207);
            this.tcDetailInfo.Name = "tcDetailInfo";
            this.tcDetailInfo.SelectedIndex = 0;
            this.tcDetailInfo.Size = new System.Drawing.Size(466, 137);
            this.tcDetailInfo.TabIndex = 2;
            // 
            // tpAssetInfo
            // 
            this.tpAssetInfo.Controls.Add(this.dataGridView1);
            this.tpAssetInfo.Location = new System.Drawing.Point(4, 21);
            this.tpAssetInfo.Name = "tpAssetInfo";
            this.tpAssetInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpAssetInfo.Size = new System.Drawing.Size(458, 112);
            this.tpAssetInfo.TabIndex = 0;
            this.tpAssetInfo.Text = "资源信息";
            this.tpAssetInfo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKey,
            this.colValue});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(452, 106);
            this.dataGridView1.TabIndex = 0;
            // 
            // colKey
            // 
            this.colKey.HeaderText = "键";
            this.colKey.Name = "colKey";
            // 
            // colValue
            // 
            this.colValue.HeaderText = "值";
            this.colValue.Name = "colValue";
            // 
            // tpFileInfo
            // 
            this.tpFileInfo.Controls.Add(this.txtFileInfo);
            this.tpFileInfo.Location = new System.Drawing.Point(4, 21);
            this.tpFileInfo.Name = "tpFileInfo";
            this.tpFileInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpFileInfo.Size = new System.Drawing.Size(458, 112);
            this.tpFileInfo.TabIndex = 1;
            this.tpFileInfo.Text = "文件信息";
            this.tpFileInfo.UseVisualStyleBackColor = true;
            // 
            // txtFileInfo
            // 
            this.txtFileInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFileInfo.Location = new System.Drawing.Point(3, 3);
            this.txtFileInfo.Multiline = true;
            this.txtFileInfo.Name = "txtFileInfo";
            this.txtFileInfo.ReadOnly = true;
            this.txtFileInfo.Size = new System.Drawing.Size(452, 106);
            this.txtFileInfo.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(466, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // DetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DetailView";
            this.Size = new System.Drawing.Size(466, 373);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tcDetailInfo.ResumeLayout(false);
            this.tpAssetInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpFileInfo.ResumeLayout(false);
            this.tpFileInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.TabControl tcDetailInfo;
        private System.Windows.Forms.TabPage tpAssetInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tpFileInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.TextBox txtFileInfo;
    }
}
