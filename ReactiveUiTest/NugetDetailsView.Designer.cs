namespace ReactiveUiTest
{
    partial class NugetDetailsView
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            iconImage = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            titleRun = new LinkLabel();
            descriptionRun = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconImage).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(iconImage);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(559, 464);
            splitContainer1.SplitterDistance = 186;
            splitContainer1.TabIndex = 0;
            // 
            // iconImage
            // 
            iconImage.Dock = DockStyle.Fill;
            iconImage.Location = new Point(0, 0);
            iconImage.Name = "iconImage";
            iconImage.Size = new Size(186, 464);
            iconImage.SizeMode = PictureBoxSizeMode.AutoSize;
            iconImage.TabIndex = 0;
            iconImage.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(titleRun, 0, 0);
            tableLayoutPanel1.Controls.Add(descriptionRun, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.Size = new Size(369, 464);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // titleRun
            // 
            titleRun.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            titleRun.AutoSize = true;
            titleRun.Location = new Point(3, 4);
            titleRun.Name = "titleRun";
            titleRun.Size = new Size(363, 17);
            titleRun.TabIndex = 0;
            titleRun.TabStop = true;
            titleRun.Text = "linkLabel1";
            // 
            // descriptionRun
            // 
            descriptionRun.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            descriptionRun.AutoSize = true;
            descriptionRun.Location = new Point(3, 223);
            descriptionRun.Name = "descriptionRun";
            descriptionRun.Size = new Size(363, 17);
            descriptionRun.TabIndex = 1;
            descriptionRun.Text = "label1";
            // 
            // NugetDetailsView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "NugetDetailsView";
            Size = new Size(559, 464);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconImage).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox iconImage;
        private TableLayoutPanel tableLayoutPanel1;
        private LinkLabel titleRun;
        private Label descriptionRun;
    }
}
