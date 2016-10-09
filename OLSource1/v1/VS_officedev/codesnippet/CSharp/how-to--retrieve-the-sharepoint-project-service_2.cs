    [Export(typeof(ISharePointProjectItemTypeExtension))]
    [SharePointProjectItemType("Microsoft.VisualStudio.SharePoint.ListDefinition")]
    internal class GetServiceInProjectItem : ISharePointProjectItemTypeExtension
    {
        public void Initialize(ISharePointProjectItemType projectItemType)
        {
            projectItemType.ProjectService.Logger.WriteLine("This message was written " +
                "by using the project service in an extension for the ListDefinition project item.", 
                LogCategory.Message);
        }
    }