using System.Collections.Generic;
using System.ComponentModel.Composition;
using Microsoft.SharePoint.Client;
using Microsoft.VisualStudio.SharePoint;
using Microsoft.VisualStudio.SharePoint.Explorer;

namespace ServerExplorer.SharePointConnections.WebPartNode
{
    // Enables Visual Studio to discover and load this extension.
    [Export(typeof(IExplorerNodeTypeExtension))]        

    // Indicates that this class extends SharePoint site nodes in Server Explorer.
    [ExplorerNodeType(ExplorerNodeTypes.SiteNode)]

    // Represents an extension of SharePoint site nodes in Server Explorer.
    internal class SiteNodeExtension : IExplorerNodeTypeExtension
    {
        private System.Uri siteUrl = null;

        public void Initialize(IExplorerNodeType nodeType)
        {
            // The NodeChildrenRequested event is raised when the user expands the
            // SharePoint site node in Server Explorer.
            nodeType.NodeChildrenRequested += NodeChildrenRequested;
        }

        // Creates the new Web Part Gallery node with the specified icon.
        private void NodeChildrenRequested(object sender, ExplorerNodeEventArgs e)
        {
            // Get the site URL so that it can be used later to access the site
            // by using the SharePoint client object model.
            siteUrl = e.Node.Context.SiteUrl;

            // The CreateWebPartNodes argument is a delegate that Visual Studio calls 
            // to create the child nodes under the Web Part Gallery node.
            e.Node.ChildNodes.AddFolder("Web Part Gallery", Properties.Resources.WebPartsNode.ToBitmap(), 
                CreateWebPartNodes);
        }

        // Creates individual Web Part nodes under the new Web Part Gallery node.
        private void CreateWebPartNodes(IExplorerNode parentNode)
        {
            // Use the SharePoint client object model to get items from the Web Part gallery.
            ClientContext context = new ClientContext(siteUrl.AbsoluteUri);
            List webPartsGallery = context.Web.GetCatalog((int)ListTemplateType.WebPartCatalog);
            ListItemCollection webParts = webPartsGallery.GetItems(new CamlQuery());

            // Request the FieldValuesAsText property values with the Web Part items.
            context.Load(webParts, listItems => listItems.Include(i => i.FieldValuesAsText));
            context.ExecuteQuery();

            if (webParts != null)
            {
                foreach (ListItem webPart in webParts)
                {
                    // Create a new annotation object to store the current Web Part item with the new node.
                    var annotations = new Dictionary<object, object>() 
                    { 
                        { typeof(ListItem), webPart } 
                    };

                    // Create the new node for the current Web Part item.
                    parentNode.ChildNodes.Add(WebPartNodeTypeProvider.WebPartNodeTypeId,
                        webPart.FieldValuesAsText.FieldValues["Title"], annotations);
                }
            }
        }
    }
}