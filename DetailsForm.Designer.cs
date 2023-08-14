namespace Faberis
{
    partial class DetailsForm
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
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.manufacturingTabPage = new System.Windows.Forms.TabPage();
            this.labelsTabPage = new System.Windows.Forms.TabPage();
            this.purchasesTabPage = new System.Windows.Forms.TabPage();
            this.propertiesTabPage = new System.Windows.Forms.TabPage();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.partDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.partDescriptionLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.manufacturingTabPage.SuspendLayout();
            this.propertiesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(698, 779);
            this.propertyGrid1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.manufacturingTabPage);
            this.tabControl1.Controls.Add(this.labelsTabPage);
            this.tabControl1.Controls.Add(this.purchasesTabPage);
            this.tabControl1.Controls.Add(this.propertiesTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 818);
            this.tabControl1.TabIndex = 1;
            // 
            // manufacturingTabPage
            // 
            this.manufacturingTabPage.Controls.Add(this.partDescriptionLabel);
            this.manufacturingTabPage.Controls.Add(this.partDescriptionTextBox);
            this.manufacturingTabPage.Location = new System.Drawing.Point(4, 29);
            this.manufacturingTabPage.Name = "manufacturingTabPage";
            this.manufacturingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.manufacturingTabPage.Size = new System.Drawing.Size(704, 785);
            this.manufacturingTabPage.TabIndex = 0;
            this.manufacturingTabPage.Text = "Manufacturing";
            this.manufacturingTabPage.UseVisualStyleBackColor = true;
            // 
            // labelsTabPage
            // 
            this.labelsTabPage.Location = new System.Drawing.Point(4, 29);
            this.labelsTabPage.Name = "labelsTabPage";
            this.labelsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.labelsTabPage.Size = new System.Drawing.Size(704, 785);
            this.labelsTabPage.TabIndex = 2;
            this.labelsTabPage.Text = "Labels";
            this.labelsTabPage.UseVisualStyleBackColor = true;
            // 
            // purchasesTabPage
            // 
            this.purchasesTabPage.Location = new System.Drawing.Point(4, 29);
            this.purchasesTabPage.Name = "purchasesTabPage";
            this.purchasesTabPage.Size = new System.Drawing.Size(704, 785);
            this.purchasesTabPage.TabIndex = 3;
            this.purchasesTabPage.Text = "Purchases";
            this.purchasesTabPage.UseVisualStyleBackColor = true;
            // 
            // propertiesTabPage
            // 
            this.propertiesTabPage.Controls.Add(this.propertyGrid1);
            this.propertiesTabPage.Location = new System.Drawing.Point(4, 29);
            this.propertiesTabPage.Name = "propertiesTabPage";
            this.propertiesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.propertiesTabPage.Size = new System.Drawing.Size(704, 785);
            this.propertiesTabPage.TabIndex = 1;
            this.propertiesTabPage.Text = "Properties";
            this.propertiesTabPage.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(583, 820);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(125, 40);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next >";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(4, 820);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(125, 40);
            this.previousButton.TabIndex = 3;
            this.previousButton.Text = "< Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // partDescriptionTextBox
            // 
            this.partDescriptionTextBox.Location = new System.Drawing.Point(8, 46);
            this.partDescriptionTextBox.Multiline = true;
            this.partDescriptionTextBox.Name = "partDescriptionTextBox";
            this.partDescriptionTextBox.Size = new System.Drawing.Size(688, 73);
            this.partDescriptionTextBox.TabIndex = 0;
            // 
            // partDescriptionLabel
            // 
            this.partDescriptionLabel.AutoSize = true;
            this.partDescriptionLabel.Location = new System.Drawing.Point(8, 23);
            this.partDescriptionLabel.Name = "partDescriptionLabel";
            this.partDescriptionLabel.Size = new System.Drawing.Size(93, 20);
            this.partDescriptionLabel.TabIndex = 1;
            this.partDescriptionLabel.Text = "Description:";
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 863);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "DetailsForm";
            this.Text = "DetailsForm";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.manufacturingTabPage.ResumeLayout(false);
            this.manufacturingTabPage.PerformLayout();
            this.propertiesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage manufacturingTabPage;
        private System.Windows.Forms.TabPage labelsTabPage;
        private System.Windows.Forms.TabPage purchasesTabPage;
        private System.Windows.Forms.TabPage propertiesTabPage;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Label partDescriptionLabel;
        private System.Windows.Forms.TextBox partDescriptionTextBox;
    }
}