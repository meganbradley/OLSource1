using System.ComponentModel.Composition;
using Microsoft.VisualStudio.SharePoint;
using Microsoft.VisualStudio.SharePoint.Explorer;

namespace Contoso.ServerExplorerExtension
{
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
}