using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using Microsoft.SharePoint.Client;
using Microsoft.VisualStudio.SharePoint;
using Microsoft.VisualStudio.SharePoint.Explorer;

namespace ServerExplorer.SharePointConnections.WebPartNode
{
    // Enables Visual Studio to discover and load this extension.
    [Export(typeof(IExplorerNodeTypeProvider))]

    // Specifies the ID for this new node type.
    [ExplorerNodeType(WebPartNodeTypeProvider.WebPartNodeTypeId)]

    // Defines a new node type that represents a Web Part on a SharePoint site.
    internal class WebPartNodeTypeProvider : IExplorerNodeTypeProvider
    {
        internal const string WebPartNodeTypeId = "Contoso.WebPart";

        public void InitializeType(IExplorerNodeTypeDefinition typeDefinition)
        {
            typeDefinition.DefaultIcon = Properties.Resources.WebPart.ToBitmap();
            typeDefinition.IsAlwaysLeaf = true;

            typeDefinition.NodePropertiesRequested += NodePropertiesRequested;
            typeDefinition.NodeMenuItemsRequested += NodeMenuItemsRequested;
        }

        // Retrieves properties that are displayed in the Properties window when
        // a Web Part node is selected.
        private void NodePropertiesRequested(object sender,
            ExplorerNodePropertiesRequestedEventArgs e)
        {
            var webPart = e.Node.Annotations.GetValue<ListItem>();
            object propertySource = e.Node.Context.CreatePropertySourceObject(
                webPart.FieldValuesAsText.FieldValues);
            e.PropertySources.Add(propertySource);
        }

        private void NodeMenuItemsRequested(
            object sender, ExplorerNodeMenuItemsRequestedEventArgs e)
        {
            e.MenuItems.Add("Display Message").Click += MenuItemClick;
        }

        private void MenuItemClick(object sender, MenuItemEventArgs e)
        {
            IExplorerNode parentNode = e.Owner as IExplorerNode;

            if (parentNode != null)
            {
                var webPart = parentNode.Annotations.GetValue<ListItem>();
                MessageBox.Show("You clicked the context menu for the following Web part: " +
                    webPart.FieldValuesAsText.FieldValues["Title"] + ".", "Web Part Menu Command");
            }
        }
    }
}