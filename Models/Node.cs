using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace Faberis.Models
{
    public class Node
    {
        [Category("General"),
        Description("Full item number")]
        public string ItemNumber { get; set; }

        [Category("General"),
        Description("Name of the component")]
        public string ComponentName { get; set; }

        [Category("General"),
        Description("Description of the component")]
        public string Description { get; set; }

        [Category("Other"),
        Description("Part reference configuration")]
        public string ReferencedConfiguration { get; set; }

        [Category("General"),
        Description("Component ID")]
        public int ComponentID { get; set; }

        [Category("General"),
        Description("Component Type")]
        public NodeType ComponentType { get; set; }

        [Category("Assembly duration"),
        Description("Assembly duration of all child nodes")]
        public double? ChildNodeAssemblyDuration { get; set; }

        [Category("Assembly duration"),
        Description("Assembly duration of individual component")]
        public double? IndividualComponentAssemblyDuration { get; set; }

        [Category("Assembly duration"),
        Description("Assembly duration into parent node")]
        public double? AssemblyToParentNodeDuration { get; set; }

        [Category("Assembly duration"),
        Description("Total assembly duration of this node")]
        public double? CombinedAssemblyTime { get; set; }

        [Category("Other"),
        Description("Location of the file")]
        public string FileLocation { get; set; }

        [Category("Image"),
        Description("Image of the part")]
        public Image Image { get; set; }



        [Category("Properties"),
        Description("Material")]
        public string Material { get; set; }

        [Category("Properties"),
        Description("Weight")]
        public double? Weight { get; set; }

        [Category("Properties"),
        Description("Surface area")]
        public double? SurfaceArea { get; set; }

        [Category("Properties"),
        Description("Sheet thickness")]
        public double? SheetThickness { get; set; }

        [Category("Properties"),
        Description("Coverage")]
        public string Coverage { get; set; }

        [Category("Price"),
        Description("Price")]
        public double? Price { get; set; }
        [Category("Price"),
        Description("Markup price of the part")]
        public double? Markup { get; set; }

        [Category("Price"),
        Description("Price to purchese")]
        public double? PurchasePrice { get; set; }

        [Category("Price"),
        Description("Metal price")]
        public double? MetalPrice { get; set; }

        [Category("Price"),
        Description("Cost of painting the part with powder paint")]
        public double? PaintingCost { get; set; }

        [Category("Price"),
        Description("Cost to cut the part")]
        public double? CuttingCost { get; set; }

        [Category("Price"),
        Description("Cost to punch the part")]
        public double? PunchingCost { get; set; }

        [Category("Price"),
        Description("Cost to bend the part")]
        public double? BendingCost { get; set; }

        [Category("Manufacturing"),
        Description("Length of the cut in meters")]
        public double? CutLength { get; set; }

        [Category("Manufacturing"),
        Description("Number of bends")]
        public int? NumberOfBends { get; set; }

        [Category("Manufacturing"),
        Description("Number of punches")]
        public int? NumberOfPunches { get; set; }

        [Category("Manufacturing"),
        Description("Does the part require welding")]
        public bool? Welded { get; set; }

        [Category("Manufacturing"),
        Description("Does the part require bending")]
        public bool? Bent { get; set; }

        [Category("General"),
        Description("Date properties was last updated")]
        public DateTime? UpdatedAt { get; set; }


        [Category("Other"),
        Description("All child nodes")]
        public List<Node> Children { get; set; }
        public Node(
            string itemNumber,
            string componentName,
            string referencedConfiguration,
            int componentID,
            NodeType componentType,
            double? childNodeAssemblyDuration,
            double? individualComponentAssemblyDuration,
            double? assemblyToParentNodeDuration,
            double? combinedAssemblyTime,
            string fileLocation
            )
        {
            this.ItemNumber = itemNumber;
            this.ComponentName = componentName;
            this.ReferencedConfiguration = referencedConfiguration;
            this.ComponentID = componentID;
            this.ComponentType = componentType;
            this.ChildNodeAssemblyDuration = childNodeAssemblyDuration;
            this.IndividualComponentAssemblyDuration = individualComponentAssemblyDuration;
            this.AssemblyToParentNodeDuration = assemblyToParentNodeDuration;
            this.CombinedAssemblyTime = combinedAssemblyTime;
            this.FileLocation = fileLocation;
            this.Children = new List<Node>();
        }
    }

    public enum NodeType
    {
        Part,
        Assembly,
    }
}
