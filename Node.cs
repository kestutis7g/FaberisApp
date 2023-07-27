using System.Collections.Generic;

namespace Faberis
{
    class Node
    {
        public string ItemNumber { get; set; }
        public string ComponentName { get; set; }
        public string ReferencedConfiguration { get; set; }
        public int ComponentID { get; set; }
        public string ComponentType { get; set; }
        public double? ChildNodeAssemblyDuration { get; set; }
        public double? IndividualComponentAssemblyDuration { get; set; }
        public double? AssemblyToParentNodeDuration { get; set; }
        public double? CombinedAssemblyTime { get; set; }
        public string FileLocation { get; set; }

        public List<Node> Children { get; set; }
        public Node(
            string itemNumber,
            string componentName,
            string referencedConfiguration,
            int componentID,
            string componentType,
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
}
