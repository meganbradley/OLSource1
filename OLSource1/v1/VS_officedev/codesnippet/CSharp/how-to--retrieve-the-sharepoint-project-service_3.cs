    [Export(typeof(ISharePointProjectItemTypeProvider))]
    [SharePointProjectItemType("Contoso.CustomAction")]
    internal class CustomActionProvider : ISharePointProjectItemTypeProvider
    {
        public void InitializeType(ISharePointProjectItemTypeDefinition projectItemTypeDefinition)
        {
            projectItemTypeDefinition.ProjectService.Logger.WriteLine("This message was written " +
                "by using the project service in the Custom Action project item type definition.",
                LogCategory.Message);
        }
    }