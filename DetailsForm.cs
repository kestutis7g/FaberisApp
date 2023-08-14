using Faberis.Models;
using Faberis.Utils;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Faberis
{
    public partial class DetailsForm : Form
    {
        public Node Data { set; get; }
        public List<Node> List { set; get; }
        public bool ShowControls { set; get; }
        int index;

        public DetailsForm(Node data, List<Node> list, bool showControls)
        {
            InitializeComponent();
            this.Data = data;
            this.List = list;
            this.ShowControls = showControls;

            if(!ShowControls)
            {
                previousButton.Visible = false;
                nextButton.Visible = false;
                tabControl1.Dock = DockStyle.Fill;
            }

            this.tabControl1.TabPages.Remove(this.tabControl1.TabPages[1]);

        }

        private void DetailsForm_Load(object sender, System.EventArgs e)
        {
            InitializeData();
        }

        private void InitializeData()
        {
            this.index = this.List.IndexOf(Data);
            UpdateControls();

            DynamicTypeDescriptor dt = new DynamicTypeDescriptor(typeof(Node));
            //hide unwanted properties
            if (Data.ComponentType.ToString() == "Assembly")
            {
                dt.RemoveProperty("Material");
                dt.RemoveProperty("Weight");
                dt.RemoveProperty("SurfaceArea");
                dt.RemoveProperty("SheetThickness");
                dt.RemoveProperty("Coverage");
                dt.RemoveProperty("Price");
                dt.RemoveProperty("Markup");
                dt.RemoveProperty("PurchasePrice");
                dt.RemoveProperty("MetalPrice");
                dt.RemoveProperty("PaintingCost");
                dt.RemoveProperty("CuttingCost");
                dt.RemoveProperty("PunchingCost");
                dt.RemoveProperty("BendingCost");
                dt.RemoveProperty("CutLength");
                dt.RemoveProperty("NumberOfBends");
                dt.RemoveProperty("NumberOfPunches");
                dt.RemoveProperty("Welded");
                dt.RemoveProperty("Bent");
            }
            if(Data.ComponentType.ToString() == "Part")
            {
                dt.RemoveProperty("ChildNodeAssemblyDuration");
                dt.RemoveProperty("IndividualComponentAssemblyDuration");
                dt.RemoveProperty("AssemblyToParentNodeDuration");
                dt.RemoveProperty("CombinedAssemblyTime");
            }

            propertyGrid1.SelectedObject = dt.FromComponent(Data);
        }

        private void nextButton_Click(object sender, System.EventArgs e)
        {
            Data = List[this.index + 1];
            InitializeData();
        }

        private void previousButton_Click(object sender, System.EventArgs e)
        {
            Data = List[index - 1];
            InitializeData();
        }

        private void UpdateControls()
        {
            if (index == 0)
            {
                previousButton.Enabled = false;
            }
            else
            {
                previousButton.Enabled = true;
            }

            if (index == List.Count - 1)
            {
                nextButton.Enabled = false;
            }
            else
            {
                nextButton.Enabled = true;
            }
        }
    }
}
