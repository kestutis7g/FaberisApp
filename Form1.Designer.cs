namespace Faberis
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.treeListView1 = new BrightIdeasSoftware.TreeListView();
            this.tabPageAssemblies = new System.Windows.Forms.TabPage();
            this.tabPageParts = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.treeListView2 = new BrightIdeasSoftware.TreeListView();
            this.treeListView3 = new BrightIdeasSoftware.TreeListView();
            this.tabControl1.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).BeginInit();
            this.tabPageAssemblies.SuspendLayout();
            this.tabPageParts.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageGeneral);
            this.tabControl1.Controls.Add(this.tabPageAssemblies);
            this.tabControl1.Controls.Add(this.tabPageParts);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1066, 621);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.treeListView1);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 29);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(1058, 588);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // treeListView1
            // 
            this.treeListView1.AllowCellEditorsToProcessMouseWheel = false;
            this.treeListView1.AllowColumnReorder = true;
            this.treeListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListView1.HideSelection = false;
            this.treeListView1.Location = new System.Drawing.Point(6, 6);
            this.treeListView1.Name = "treeListView1";
            this.treeListView1.SelectColumnsMenuStaysOpen = false;
            this.treeListView1.SelectColumnsOnRightClick = false;
            this.treeListView1.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.treeListView1.ShowFilterMenuOnRightClick = false;
            this.treeListView1.ShowGroups = false;
            this.treeListView1.ShowImagesOnSubItems = true;
            this.treeListView1.ShowItemToolTips = true;
            this.treeListView1.Size = new System.Drawing.Size(1046, 576);
            this.treeListView1.TabIndex = 3;
            this.treeListView1.UseCompatibleStateImageBehavior = false;
            this.treeListView1.UseFilterIndicator = true;
            this.treeListView1.UseFiltering = true;
            this.treeListView1.UseHotItem = true;
            this.treeListView1.View = System.Windows.Forms.View.Details;
            this.treeListView1.VirtualMode = true;
            this.treeListView1.ItemActivate += new System.EventHandler(this.treeListView1_ItemActivate);
            // 
            // tabPageAssemblies
            // 
            this.tabPageAssemblies.Controls.Add(this.treeListView2);
            this.tabPageAssemblies.Location = new System.Drawing.Point(4, 29);
            this.tabPageAssemblies.Name = "tabPageAssemblies";
            this.tabPageAssemblies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAssemblies.Size = new System.Drawing.Size(1058, 588);
            this.tabPageAssemblies.TabIndex = 1;
            this.tabPageAssemblies.Text = "Assemblies";
            this.tabPageAssemblies.UseVisualStyleBackColor = true;
            // 
            // tabPageParts
            // 
            this.tabPageParts.Controls.Add(this.treeListView3);
            this.tabPageParts.Location = new System.Drawing.Point(4, 29);
            this.tabPageParts.Name = "tabPageParts";
            this.tabPageParts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParts.Size = new System.Drawing.Size(1058, 588);
            this.tabPageParts.TabIndex = 2;
            this.tabPageParts.Text = "Parts";
            this.tabPageParts.UseVisualStyleBackColor = true;
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
            // treeListView2
            // 
            this.treeListView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListView2.HideSelection = false;
            this.treeListView2.Location = new System.Drawing.Point(3, 6);
            this.treeListView2.Name = "treeListView2";
            this.treeListView2.ShowGroups = false;
            this.treeListView2.Size = new System.Drawing.Size(1052, 576);
            this.treeListView2.TabIndex = 0;
            this.treeListView2.UseCompatibleStateImageBehavior = false;
            this.treeListView2.View = System.Windows.Forms.View.Details;
            this.treeListView2.VirtualMode = true;
            // 
            // treeListView3
            // 
            this.treeListView3.AllowCellEditorsToProcessMouseWheel = false;
            this.treeListView3.AllowColumnReorder = true;
            this.treeListView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListView3.HideSelection = false;
            this.treeListView3.Location = new System.Drawing.Point(6, 6);
            this.treeListView3.Name = "treeListView3";
            this.treeListView3.SelectColumnsMenuStaysOpen = false;
            this.treeListView3.SelectColumnsOnRightClick = false;
            this.treeListView3.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.treeListView3.ShowFilterMenuOnRightClick = false;
            this.treeListView3.ShowGroups = false;
            this.treeListView3.ShowImagesOnSubItems = true;
            this.treeListView3.ShowItemToolTips = true;
            this.treeListView3.Size = new System.Drawing.Size(1046, 576);
            this.treeListView3.TabIndex = 4;
            this.treeListView3.UseCompatibleStateImageBehavior = false;
            this.treeListView3.UseFilterIndicator = true;
            this.treeListView3.UseFiltering = true;
            this.treeListView3.UseHotItem = true;
            this.treeListView3.View = System.Windows.Forms.View.Details;
            this.treeListView3.VirtualMode = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 626);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).EndInit();
            this.tabPageAssemblies.ResumeLayout(false);
            this.tabPageParts.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPageAssemblies;
        private System.Windows.Forms.TabPage tabPageParts;
        private BrightIdeasSoftware.TreeListView treeListView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private BrightIdeasSoftware.TreeListView treeListView2;
        private BrightIdeasSoftware.TreeListView treeListView3;
    }
}

