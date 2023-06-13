using System.Windows.Forms;

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
            iconImage = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            titleRun = new LinkLabel();
            descriptionRun = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)iconImage).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // iconImage
            // 
            iconImage.Dock = DockStyle.Fill;
            iconImage.Location = new Point(3, 3);
            iconImage.Name = "iconImage";
            iconImage.Size = new Size(94, 94);
            iconImage.SizeMode = PictureBoxSizeMode.Zoom;
            iconImage.TabIndex = 0;
            iconImage.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(titleRun, 0, 0);
            tableLayoutPanel1.Controls.Add(descriptionRun, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(103, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(453, 94);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // titleRun
            // 
            titleRun.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            titleRun.AutoSize = true;
            titleRun.Location = new Point(3, 4);
            titleRun.Name = "titleRun";
            titleRun.Size = new Size(447, 17);
            titleRun.TabIndex = 0;
            titleRun.TabStop = true;
            titleRun.Text = "linkLabel1";
            // 
            // descriptionRun
            // 
            descriptionRun.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            descriptionRun.AutoSize = true;
            descriptionRun.Location = new Point(3, 51);
            descriptionRun.Name = "descriptionRun";
            descriptionRun.Size = new Size(447, 17);
            descriptionRun.TabIndex = 1;
            descriptionRun.Text = "label1";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 1, 0);
            tableLayoutPanel2.Controls.Add(iconImage, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(559, 100);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // NugetDetailsView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "NugetDetailsView";
            Size = new Size(559, 100);
            ((System.ComponentModel.ISupportInitialize)iconImage).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox iconImage;
        private TableLayoutPanel tableLayoutPanel1;
        private LinkLabel titleRun;
        private Label descriptionRun;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
