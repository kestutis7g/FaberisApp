using Faberis.Models;
using Faberis.Utils;
using System.Windows.Forms;

namespace Faberis
{
    public partial class DetailsForm : Form
    {
        public Node data { set; get; }
        public DetailsForm()
        {
            InitializeComponent();
        }

        private void DetailsForm_Load(object sender, System.EventArgs e)
        {
            InitializeData();
        }

        private void InitializeData()
        {

            DynamicTypeDescriptor dt = new DynamicTypeDescriptor(typeof(Node));
 
            //hide unwanted properties
            if (data.ComponentType.ToString() == "Assembly")
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
            if(data.ComponentType.ToString() == "Part")
            {
                dt.RemoveProperty("ChildNodeAssemblyDuration");
                dt.RemoveProperty("IndividualComponentAssemblyDuration");
                dt.RemoveProperty("AssemblyToParentNodeDuration");
                dt.RemoveProperty("CombinedAssemblyTime");
            }

            propertyGrid1.SelectedObject = dt.FromComponent(data);
        }
    }
}
