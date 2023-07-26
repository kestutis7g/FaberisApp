using BrightIdeasSoftware;

namespace Faberis;

public partial class Form1 : Form
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

    private List<Node> data;
    private TreeListView treeListView;

    // constructor
    public Form1()
    {
        InitializeComponent();
        AddTree();
        InitializeData();
        FillTree();
    }

    private void FillTree()
    {
        // set the delegate that the tree uses to know if a node is expandable
        this.treeListView.CanExpandGetter = x => (x as Node).Children.Count > 0;
        // set the delegate that the tree uses to know the children of a node
        this.treeListView.ChildrenGetter = x => (x as Node).Children;


        // create the tree columns and set the delegates to print the desired object proerty
        var colItemNumber = new OLVColumn("ItemNumber", "ItemNumber");
        colItemNumber.AspectGetter = x => (x as Node).ItemNumber;
        colItemNumber.MinimumWidth = 130;

        var colComponentName = new OLVColumn("ComponentName", "ComponentName");
        colComponentName.AspectGetter = x => (x as Node).ComponentName;
        colComponentName.MinimumWidth = 300;

        var colReferencedConfiguration = new OLVColumn("ReferencedConfiguration", "ReferencedConfiguration");
        colReferencedConfiguration.AspectGetter = x => (x as Node).ReferencedConfiguration;
        colReferencedConfiguration.MinimumWidth = 220;

        var colComponentID = new OLVColumn("ComponentID", "ComponentID");
        colComponentID.AspectGetter = x => (x as Node).ComponentID;
        colComponentID.MinimumWidth = 100;

        var colComponentType = new OLVColumn("ComponentType", "ComponentType");
        colComponentType.AspectGetter = x => (x as Node).ComponentType;
        colComponentType.MinimumWidth = 100;

        var colChildNodeAssemblyDuration = new OLVColumn("ChildNodeAssemblyDuration", "ChildNodeAssemblyDuration");
        colChildNodeAssemblyDuration.AspectGetter = x => (x as Node).ChildNodeAssemblyDuration;
        colChildNodeAssemblyDuration.MinimumWidth = 100;

        var colIndividualComponentAssemblyDuration = new OLVColumn("IndividualComponentAssemblyDuration", "IndividualComponentAssemblyDuration");
        colIndividualComponentAssemblyDuration.AspectGetter = x => (x as Node).IndividualComponentAssemblyDuration;
        colIndividualComponentAssemblyDuration.MinimumWidth = 100;

        var colAssemblyToParentNodeDuration = new OLVColumn("AssemblyToParentNodeDuration", "AssemblyToParentNodeDuration");
        colAssemblyToParentNodeDuration.AspectGetter = x => (x as Node).AssemblyToParentNodeDuration;
        colAssemblyToParentNodeDuration.MinimumWidth = 100;

        var colCombinedAssemblyTime = new OLVColumn("CombinedAssemblyTime", "CombinedAssemblyTime");
        colCombinedAssemblyTime.AspectGetter = x => (x as Node).CombinedAssemblyTime;
        colCombinedAssemblyTime.MinimumWidth = 100;

        var colFileLocation = new OLVColumn("FileLocation", "FileLocation");
        colFileLocation.AspectGetter = x => (x as Node).FileLocation;
        colFileLocation.MinimumWidth = 100;

        // add the columns to the tree
        this.treeListView.Columns.Add(colItemNumber);
        this.treeListView.Columns.Add(colComponentName);
        this.treeListView.Columns.Add(colReferencedConfiguration);
        this.treeListView.Columns.Add(colComponentID);
        this.treeListView.Columns.Add(colComponentType);
        this.treeListView.Columns.Add(colChildNodeAssemblyDuration);
        this.treeListView.Columns.Add(colIndividualComponentAssemblyDuration);
        this.treeListView.Columns.Add(colAssemblyToParentNodeDuration);
        this.treeListView.Columns.Add(colCombinedAssemblyTime);
        this.treeListView.Columns.Add(colFileLocation);

        // set the tree roots
        this.treeListView.Roots = data;
    }

    /// <summary>
    /// Initialize data tree
    /// </summary>
    private void InitializeData()
    {
        data = new List<Node>();

        var text = File.ReadAllText("../../../Irenginio sudedamieji mazgai ir komponentai.csv");
        var parts = text.Split(Environment.NewLine);
        //skip header line
        parts = parts.Skip(1).ToArray();
        //remove empty lines
        parts = parts.Where(x => !string.IsNullOrEmpty(x)).ToArray();

        foreach (var partInfo in parts)
        {
            var info = partInfo.Split(';');
            double temp;

            if(info[0].Split('.').Length > 1)
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

        if(parentNode == null) 
        {
            return;
        }

        if(currentLevel + 1 == nodeNumber.Split('.').Count())
        {
            //parent was found
            AddNode(parentNode.Children, partInfo);
            return;
        }

        FindDataParent(nodeNumber, parentNode.Children, partInfo, currentLevel + 1);
    }

    /// <summary>
    /// Add node to List<Node>
    /// </summary>
    /// <param name="list">list of nodes</param>
    /// <param name="data">string data of the node</param>
    private void AddNode(List<Node> list, string data)
    {
        var info = data.Split(';');
        double temp;

        list.Add(new Node(info[0],
                          info[1],
                          info[2],
                          int.Parse(info[3]),
                          info[4],
                          double.TryParse(info[5], out temp) ? temp : null,
                          double.TryParse(info[6], out temp) ? temp : null,
                          double.TryParse(info[7], out temp) ? temp : null,
                          double.TryParse(info[8], out temp) ? temp : null,
                          info[9]
                          ));
    }

    private void CalculateChildNodeAssemblyDuration(List<Node> nodes)
    {
        nodes.ForEach(x => {
            if (x.ComponentType == "Assembly")
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
            if(node.ComponentType == "Assembly")
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
        treeListView = new BrightIdeasSoftware.TreeListView();
        treeListView.Dock = DockStyle.Fill;
        this.Controls.Add(treeListView);
    }



}
