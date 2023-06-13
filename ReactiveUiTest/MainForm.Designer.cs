namespace ReactiveUiTest
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            searchTextBox = new TextBox();
            searchResultsListBox = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(searchTextBox);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(searchResultsListBox);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 44;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(88, 17);
            label1.TabIndex = 0;
            label1.Text = "Search From: ";
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            searchTextBox.Location = new Point(107, 10);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(681, 23);
            searchTextBox.TabIndex = 1;
            // 
            // searchResultsListBox
            // 
            searchResultsListBox.ColumnCount = 1;
            searchResultsListBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            searchResultsListBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            searchResultsListBox.Dock = DockStyle.Fill;
            searchResultsListBox.Location = new Point(0, 0);
            searchResultsListBox.Name = "searchResultsListBox";
            searchResultsListBox.RowCount = 1;
            searchResultsListBox.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            searchResultsListBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            searchResultsListBox.Size = new Size(800, 402);
            searchResultsListBox.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "MainForm";
            Text = "MainForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private TextBox searchTextBox;
        private TableLayoutPanel searchResultsListBox;
    }
}