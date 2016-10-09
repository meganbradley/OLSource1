    [Export(typeof(IExplorerNodeTypeProvider))]
    [ExplorerNodeType(ExampleNodeTypeProvider.NodeTypeId)]
    internal class ExampleNodeTypeProvider : IExplorerNodeTypeProvider
    {
        internal const string NodeTypeId = "Contoso.ServerExplorerNodeExample";

        public void InitializeType(IExplorerNodeTypeDefinition typeDefinition)
        {
            typeDefinition.DefaultIcon =
                Properties.Resources.CustomChildNodeIcon.ToBitmap();
            typeDefinition.IsAlwaysLeaf = true;
        }
    }