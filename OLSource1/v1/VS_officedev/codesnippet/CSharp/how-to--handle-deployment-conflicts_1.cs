using Microsoft.VisualStudio.SharePoint;
using Microsoft.VisualStudio.SharePoint.Deployment;
using System.ComponentModel.Composition;

namespace Contoso.DeploymentConflictExtension
{
    [Export(typeof(ISharePointProjectItemTypeExtension))]
    [SharePointProjectItemType("Microsoft.VisualStudio.SharePoint.ListDefinition")]
    class DeploymentConflictExtension : ISharePointProjectItemTypeExtension
    {
        public void Initialize(ISharePointProjectItemType projectItemType)
        {
            projectItemType.DeploymentStepStarted += DeploymentStepStarted;
        }

        private void DeploymentStepStarted(object sender, DeploymentStepStartedEventArgs e)
        {
            if (e.DeploymentStepInfo.Id == DeploymentStepIds.AddSolution)
            {
                e.Conflicts.Add("This is an example conflict", this.Resolve, true);
                e.ProjectItem.Project.ProjectService.Logger.WriteLine("Added new example conflict.", LogCategory.Status);
            }
        }

        private bool Resolve(ISharePointProjectItem projectItem)
        {
            projectItem.Project.ProjectService.Logger.WriteLine("Returning 'true' from Resolve method for example conflict.", 
                LogCategory.Status);
            return true;
        }
    }
}