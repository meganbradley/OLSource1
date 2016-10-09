    [Export(typeof(IExplorerNodeTypeExtension))]
    [ExplorerNodeType(ExplorerNodeTypes.SiteNode)]
    internal class SiteNodeExtension : IExplorerNodeTypeExtension
    {
        public void Initialize(IExplorerNodeType nodeType)
        {
            nodeType.NodeChildrenRequested += NodeChildrenRequested;
        }

        private void NodeChildrenRequested(object sender, ExplorerNodeEventArgs e)
        {
            e.Node.ChildNodes.Add(ExampleNodeTypeProvider.NodeTypeId,
                "Custom Node", null);
        }
    }