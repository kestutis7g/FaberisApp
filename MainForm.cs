using BrightIdeasSoftware;
using Faberis.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Faberis
{
    public partial class MainForm : Form
    {
        private List<Node> data;
        private List<Node> partsData;

        // constructor
        public MainForm()
        {
            InitializeComponent();
            AddTree();
            InitializeData();

            FillTree();
            FillPartsTree();

            this.ContextMenuStrip = contextMenuStrip1;

            //this.splitContainer1.SplitterDistance = (80 * this.splitContainer1.Size.Width / 100);
            //this.splitContainer2.SplitterDistance = (80 * this.splitContainer2.Size.Width / 100);
        }

        private void FillTree()
        {
            // set the delegate that the tree uses to know if a node is expandable
            this.treeListView1.CanExpandGetter = x => (x as Node).Children.Count > 0;
            // set the delegate that the tree uses to know the children of a node
            this.treeListView1.ChildrenGetter = x => (x as Node).Children;

            // create the tree columns and set the delegates to print the desired object proerty
            var colItemNumber = new OLVColumn("ItemNumber", "ItemNumber");
            colItemNumber.AspectGetter = x => (x as Node).ItemNumber;
            colItemNumber.MinimumWidth = 80;

            var colComponentName = new OLVColumn("ComponentName", "ComponentName");
            colComponentName.AspectGetter = x => (x as Node).ComponentName;
            colComponentName.Width = 100;

            var colReferencedConfiguration = new OLVColumn("ReferencedConfiguration", "ReferencedConfiguration");
            colReferencedConfiguration.AspectGetter = x => (x as Node).ReferencedConfiguration;
            colReferencedConfiguration.Width = 100;

            //var colComponentID = new OLVColumn("ComponentID", "ComponentID");
            //colComponentID.AspectGetter = x => (x as Node).ComponentID;
            //colComponentID.Width = 100;

            var colComponentType = new OLVColumn("ComponentType", "ComponentType");
            colComponentType.AspectGetter = x => (x as Node).ComponentType;
            colComponentType.Width = 100;

            var colChildNodeAssemblyDuration = new OLVColumn("ChildNodeAssemblyDuration", "ChildNodeAssemblyDuration");
            colChildNodeAssemblyDuration.AspectGetter = x => (x as Node).ChildNodeAssemblyDuration;
            colChildNodeAssemblyDuration.Width = 100;

            var colIndividualComponentAssemblyDuration = new OLVColumn("IndividualComponentAssemblyDuration", "IndividualComponentAssemblyDuration");
            colIndividualComponentAssemblyDuration.AspectGetter = x => (x as Node).IndividualComponentAssemblyDuration;
            colIndividualComponentAssemblyDuration.Width = 100;

            var colAssemblyToParentNodeDuration = new OLVColumn("AssemblyToParentNodeDuration", "AssemblyToParentNodeDuration");
            colAssemblyToParentNodeDuration.AspectGetter = x => (x as Node).AssemblyToParentNodeDuration;
            colAssemblyToParentNodeDuration.Width = 100;

            var colCombinedAssemblyTime = new OLVColumn("CombinedAssemblyTime", "CombinedAssemblyTime");
            colCombinedAssemblyTime.AspectGetter = x => (x as Node).CombinedAssemblyTime;
            colCombinedAssemblyTime.Width = 100;

            //var colFileLocation = new OLVColumn("FileLocation", "FileLocation");
            //colFileLocation.AspectGetter = x => (x as Node).FileLocation;
            //colFileLocation.MinimumWidth = 100;


            // add the columns to the tree
            this.treeListView1.Columns.Add(colItemNumber);
            this.treeListView1.Columns.Add(colComponentName);
            this.treeListView1.Columns.Add(colReferencedConfiguration);
            //this.treeListView1.Columns.Add(colComponentID);
            this.treeListView1.Columns.Add(colComponentType);
            this.treeListView1.Columns.Add(colChildNodeAssemblyDuration);
            this.treeListView1.Columns.Add(colIndividualComponentAssemblyDuration);
            this.treeListView1.Columns.Add(colAssemblyToParentNodeDuration);
            this.treeListView1.Columns.Add(colCombinedAssemblyTime);
            //this.treeListView1.Columns.Add(colFileLocation);

            // set the tree roots
            this.treeListView1.Roots = data;
            this.treeListView1.CheckBoxes = true;
        }

        private void FillPartsTree()
        {
            // set the delegate that the tree uses to know if a node is expandable
            this.treeListView2.CanExpandGetter = x => (x as Node).Children.Count > 0;
            // set the delegate that the tree uses to know the children of a node
            this.treeListView2.ChildrenGetter = x => (x as Node).Children;


            // create the tree columns and set the delegates to print the desired object proerty
            var colItemNumber = new OLVColumn("ItemNumber", "ItemNumber");
            colItemNumber.AspectGetter = x => (x as Node).ItemNumber;
            colItemNumber.MinimumWidth = 80;

            var colComponentName = new OLVColumn("ComponentName", "ComponentName");
            colComponentName.AspectGetter = x => (x as Node).ComponentName;
            colComponentName.Width = 100;

            var colReferencedConfiguration = new OLVColumn("ReferencedConfiguration", "ReferencedConfiguration");
            colReferencedConfiguration.AspectGetter = x => (x as Node).ReferencedConfiguration;
            colReferencedConfiguration.Width = 100;

            var colDescription = new OLVColumn("Description", "Description");
            colDescription.AspectGetter = x => (x as Node).Description;
            colDescription.Width = 100;

            //var colComponentID = new OLVColumn("ComponentID", "ComponentID");
            //colComponentID.AspectGetter = x => (x as Node).ComponentID;
            //colComponentID.Width = 100;

            var colSurfaceArea = new OLVColumn("SurfaceArea", "SurfaceArea");
            colSurfaceArea.AspectGetter = x => (x as Node).SurfaceArea;
            colSurfaceArea.Width = 100;

            var colWeight = new OLVColumn("Weight", "Weight");
            colWeight.AspectGetter = x => (x as Node).Weight;
            colWeight.Width = 100;

            var colWelded = new OLVColumn("Welded", "Welded");
            colWelded.AspectGetter = x => (x as Node).Welded;
            colWelded.Width = 100;

            var colBent = new OLVColumn("Bent", "Bent");
            colBent.AspectGetter = x => (x as Node).Bent;
            colBent.Width = 100;

            var colMaterial = new OLVColumn("Material", "Material");
            colMaterial.AspectGetter = x => (x as Node).Material;
            colMaterial.Width = 100;

            var colCoverage = new OLVColumn("Coverage", "Coverage");
            colCoverage.AspectGetter = x => (x as Node).Coverage;
            colCoverage.Width = 100;

            var colPrice = new OLVColumn("Price", "Price");
            colPrice.AspectGetter = x => (x as Node).Price;
            colPrice.MinimumWidth = 100;

            var colSheetThickness = new OLVColumn("SheetThickness", "SheetThickness");
            colSheetThickness.AspectGetter = x => (x as Node).SheetThickness;
            colSheetThickness.MinimumWidth = 100;


            // add the columns to the tree
            this.treeListView2.Columns.Add(colItemNumber);
            this.treeListView2.Columns.Add(colComponentName);
            this.treeListView2.Columns.Add(colReferencedConfiguration);
            this.treeListView2.Columns.Add(colDescription);
            //this.treeListView3.Columns.Add(colComponentID);
            this.treeListView2.Columns.Add(colSurfaceArea);
            this.treeListView2.Columns.Add(colWeight);
            this.treeListView2.Columns.Add(colWelded);
            this.treeListView2.Columns.Add(colBent);
            this.treeListView2.Columns.Add(colMaterial);
            this.treeListView2.Columns.Add(colCoverage);
            this.treeListView2.Columns.Add(colPrice);
            this.treeListView2.Columns.Add(colSheetThickness);

            // set the tree roots
            this.treeListView2.Roots = partsData;
            this.treeListView2.CheckBoxes = true;
        }

        /// <summary>
        /// Initialize data tree
        /// </summary>
        private void InitializeData()
        {
            data = new List<Node>(); 
            partsData = new List<Node>(); 

            var text = File.ReadAllText("..\\..\\Data.csv");

            var parts = text.Split('\n');
            //skip header line
            parts = parts.Skip(1).ToArray();
            //remove empty lines
            parts = parts.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            foreach (var partInfo in parts)
            {
                var info = partInfo.Split(';');

                if (info[0].Split('.').Length > 1)
                {
                    //child node
                    FindDataParent(info[0], data, partInfo);
                    continue;
                }
                //root node
                AddNode(data, partInfo);
            }
            CalculateChildNodeAssemblyDuration(data);
        }

        /// <summary>
        /// Find parent of the node recursively
        /// </summary>
        /// <param name="nodeNumber">node number</param>
        /// <param name="nodes">current level nodes</param>
        /// <param name="partInfo">child node data</param>
        /// <param name="currentLevel">parent search level</param>
        private void FindDataParent(string nodeNumber, List<Node> nodes, string partInfo, int currentLevel = 1)
        {
            var parent = String.Join(".", nodeNumber.Split('.').Take(currentLevel));

            var parentNode = nodes.FirstOrDefault(x => x.ItemNumber == parent);

            if (parentNode == null)
            {
                return;
            }

            if (currentLevel + 1 == nodeNumber.Split('.').Count())
            {
                //parent was found
                AddNode(parentNode.Children, partInfo);
                return;
            }
            FindDataParent(nodeNumber, parentNode.Children, partInfo, currentLevel + 1);
        }

        private Node FormatNode(string data)
        {
            var info = data.Split(';');
            double temp1, temp2, temp3, temp4;
            NodeType type;

            Enum.TryParse(info[4], out type);
            double.TryParse(info[5], out temp1);
            double.TryParse(info[6], out temp2);
            double.TryParse(info[7], out temp3);
            double.TryParse(info[8], out temp4);

            return new Node(info[0],
                                info[1],
                                info[2],
                                int.Parse(info[3]),
                                type,
                                temp1,
                                temp2,
                                temp3,
                                temp4,
                                info[9]
                                );
        }

        /// <summary>
        /// Add node to List<Node>
        /// </summary>
        /// <param name="list">list of nodes</param>
        /// <param name="data">string data of the node</param>
        private void AddNode(List<Node> list, string data)
        {
            var node = FormatNode(data);
            list.Add(node);

            if(node.ComponentType.ToString() == "Part")
            {
                partsData.Add(node);
            }
        }

        private void CalculateChildNodeAssemblyDuration(List<Node> nodes)
        {
            nodes.ForEach(x => {
                if (x.ComponentType.ToString() == "Assembly")
                {
                    x.ChildNodeAssemblyDuration = GetChildrenAssemblyDuration(x.Children);
                    x.CombinedAssemblyTime = (double)(x.ChildNodeAssemblyDuration ?? 0) +
                                             (double)(x.IndividualComponentAssemblyDuration ?? 0) +
                                             (double)(x.AssemblyToParentNodeDuration ?? 0);
                }
            });
        }

        private double GetChildrenAssemblyDuration(List<Node> nodes)
        {
            double assemblyDuration = 0;
            foreach (var node in nodes)//jei vaiku nera taj 0
            {
                if (node.ComponentType.ToString() == "Assembly")
                {
                    node.ChildNodeAssemblyDuration = GetChildrenAssemblyDuration(node.Children);
                    node.CombinedAssemblyTime = (double)(node.ChildNodeAssemblyDuration ?? 0) +
                                                (double)(node.IndividualComponentAssemblyDuration ?? 0) +
                                                (double)(node.AssemblyToParentNodeDuration ?? 0);
                    assemblyDuration += (double)node.CombinedAssemblyTime;
                }
            }

            return assemblyDuration;
        }

        private void AddTree()
        {
            //treeListView1 = new TreeListView();
            //treeListView1.Dock = DockStyle.Fill;
            //this.Controls.Add(treeListView1);
        }

        private void treeListView1_ItemActivate(object sender, EventArgs e)
        {
            foreach (Node item in treeListView1.SelectedObjects)
            {
                OpenItemDetailedView(item);
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (treeListView1.SelectedObjects.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void contextMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toolStripMenuItem = (ToolStripMenuItem)sender;
            if (toolStripMenuItem.Name == "Open")
            {
                foreach (Node item in treeListView1.SelectedObjects)
                {
                    OpenItemDetailedView(item);
                }
            }
        }

        private void OpenItemDetailedView(Node item)
        {
            var detailsForm = new DetailsForm();
            detailsForm.data = item;
            detailsForm.Show();
        }

        private void seachTextBox1_TextChanged(object sender, EventArgs e)
        {
            var filter = TextMatchFilter.Contains(this.treeListView1, seachTextBox1.Text);
            this.treeListView1.AdditionalFilter = filter;
            this.treeListView1.DefaultRenderer = new HighlightTextRenderer(filter);
        }

        private void seachTextBox2_TextChanged(object sender, EventArgs e)
        {
            var filter = TextMatchFilter.Contains(this.treeListView2, seachTextBox2.Text);
            this.treeListView2.AdditionalFilter = filter;
            this.treeListView2.DefaultRenderer = new HighlightTextRenderer(filter);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var checkedItems = treeListView1.CheckedObjects;

            foreach (Node item in checkedItems)
            {
                item.ReferencedConfiguration = "TESTAS";
                item.ComponentName = "TESTAS";
            }
            int g = 0;
        }
    }
}