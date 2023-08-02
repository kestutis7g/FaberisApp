namespace Faberis
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.seachTextBox1 = new System.Windows.Forms.TextBox();
            this.treeListView1 = new BrightIdeasSoftware.TreeListView();
            this.tabPageParts = new System.Windows.Forms.TabPage();
            this.seachTextBox2 = new System.Windows.Forms.TextBox();
            this.treeListView2 = new BrightIdeasSoftware.TreeListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).BeginInit();
            this.tabPageParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageGeneral);
            this.tabControl1.Controls.Add(this.tabPageParts);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1066, 598);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.seachTextBox1);
            this.tabPageGeneral.Controls.Add(this.treeListView1);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 29);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(1058, 565);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // seachTextBox1
            // 
            this.seachTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seachTextBox1.Location = new System.Drawing.Point(6, 15);
            this.seachTextBox1.Name = "seachTextBox1";
            this.seachTextBox1.Size = new System.Drawing.Size(1046, 26);
            this.seachTextBox1.TabIndex = 4;
            this.seachTextBox1.TextChanged += new System.EventHandler(this.seachTextBox1_TextChanged);
            // 
            // treeListView1
            // 
            this.treeListView1.AllowCellEditorsToProcessMouseWheel = false;
            this.treeListView1.AllowColumnReorder = true;
            this.treeListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListView1.HideSelection = false;
            this.treeListView1.Location = new System.Drawing.Point(6, 47);
            this.treeListView1.Name = "treeListView1";
            this.treeListView1.SelectColumnsMenuStaysOpen = false;
            this.treeListView1.SelectColumnsOnRightClick = false;
            this.treeListView1.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.treeListView1.ShowCommandMenuOnRightClick = true;
            this.treeListView1.ShowGroups = false;
            this.treeListView1.ShowImagesOnSubItems = true;
            this.treeListView1.ShowItemToolTips = true;
            this.treeListView1.Size = new System.Drawing.Size(1046, 512);
            this.treeListView1.TabIndex = 3;
            this.treeListView1.UseCompatibleStateImageBehavior = false;
            this.treeListView1.UseFilterIndicator = true;
            this.treeListView1.UseFiltering = true;
            this.treeListView1.UseHotItem = true;
            this.treeListView1.View = System.Windows.Forms.View.Details;
            this.treeListView1.VirtualMode = true;
            this.treeListView1.ItemActivate += new System.EventHandler(this.treeListView1_ItemActivate);
            // 
            // tabPageParts
            // 
            this.tabPageParts.Controls.Add(this.seachTextBox2);
            this.tabPageParts.Controls.Add(this.treeListView2);
            this.tabPageParts.Location = new System.Drawing.Point(4, 29);
            this.tabPageParts.Name = "tabPageParts";
            this.tabPageParts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParts.Size = new System.Drawing.Size(1058, 588);
            this.tabPageParts.TabIndex = 2;
            this.tabPageParts.Text = "Parts";
            this.tabPageParts.UseVisualStyleBackColor = true;
            // 
            // seachTextBox2
            // 
            this.seachTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seachTextBox2.Location = new System.Drawing.Point(6, 15);
            this.seachTextBox2.Name = "seachTextBox2";
            this.seachTextBox2.Size = new System.Drawing.Size(1046, 26);
            this.seachTextBox2.TabIndex = 5;
            // 
            // treeListView2
            // 
            this.treeListView2.AllowCellEditorsToProcessMouseWheel = false;
            this.treeListView2.AllowColumnReorder = true;
            this.treeListView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListView2.HideSelection = false;
            this.treeListView2.Location = new System.Drawing.Point(6, 47);
            this.treeListView2.Name = "treeListView2";
            this.treeListView2.SelectColumnsMenuStaysOpen = false;
            this.treeListView2.SelectColumnsOnRightClick = false;
            this.treeListView2.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.treeListView2.ShowCommandMenuOnRightClick = true;
            this.treeListView2.ShowGroups = false;
            this.treeListView2.ShowImagesOnSubItems = true;
            this.treeListView2.ShowItemToolTips = true;
            this.treeListView2.Size = new System.Drawing.Size(1046, 535);
            this.treeListView2.TabIndex = 4;
            this.treeListView2.UseCompatibleStateImageBehavior = false;
            this.treeListView2.UseFilterIndicator = true;
            this.treeListView2.UseFiltering = true;
            this.treeListView2.UseHotItem = true;
            this.treeListView2.View = System.Windows.Forms.View.Details;
            this.treeListView2.VirtualMode = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 36);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(128, 32);
            this.Open.Text = "Open";
            this.Open.Click += new System.EventHandler(this.contextMenuToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(877, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Do stuff";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "MainForm";
            this.Text = "Janitor";
            this.tabControl1.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).EndInit();
            this.tabPageParts.ResumeLayout(false);
            this.tabPageParts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPageParts;
        private BrightIdeasSoftware.TreeListView treeListView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private BrightIdeasSoftware.TreeListView treeListView2;
        private System.Windows.Forms.TextBox seachTextBox1;
        private System.Windows.Forms.TextBox seachTextBox2;
        private System.Windows.Forms.Button button1;
    }
}

