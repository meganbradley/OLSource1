using System;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.SharePoint;

namespace Contoso.Examples.ProjectItemTypeWithMenu
{
    [Export(typeof(ISharePointProjectItemTypeProvider))]
    [SharePointProjectItemType("Contoso.ExampleProjectItemType")]
    [SharePointProjectItemIcon("ExampleProjectItemType.ProjectItemIcon.ico")]
    internal class ExampleProjectItemTypeWithMenu : ISharePointProjectItemTypeProvider
    {
        public void InitializeType(ISharePointProjectItemTypeDefinition projectItemTypeDefinition)
        {
            projectItemTypeDefinition.Name = "ExampleProjectItemType";
            projectItemTypeDefinition.SupportedDeploymentScopes =
                SupportedDeploymentScopes.Site | SupportedDeploymentScopes.Web;
            projectItemTypeDefinition.SupportedTrustLevels = SupportedTrustLevels.All;

            projectItemTypeDefinition.ProjectItemMenuItemsRequested += 
                projectItemTypeDefinition_ProjectItemMenuItemsRequested;
        }

        void projectItemTypeDefinition_ProjectItemMenuItemsRequested(object sender,
            SharePointProjectItemMenuItemsRequestedEventArgs e)
        {
            IMenuItem menuItem = e.ViewMenuItems.Add("Write Message to Output Window");
            menuItem.Click += MenuItemExtension_Click;
        }

        void MenuItemExtension_Click(object sender, MenuItemEventArgs e)
        {
            ISharePointProjectItem projectItem = (ISharePointProjectItem)e.Owner;
            projectItem.Project.ProjectService.Logger.WriteLine(
                String.Format("This message was written from a shortcut menu for {0}.", projectItem.Name),
                LogCategory.Status);
        }
    }
}