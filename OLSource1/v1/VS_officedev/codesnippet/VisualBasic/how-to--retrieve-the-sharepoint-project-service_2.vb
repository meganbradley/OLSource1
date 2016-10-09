    <Export(GetType(ISharePointProjectItemTypeExtension))> _
    <SharePointProjectItemType("Microsoft.VisualStudio.SharePoint.ListDefinition")> _
    Friend Class GetServiceInProjectItem
        Implements ISharePointProjectItemTypeExtension

        Private Sub Initialize(ByVal projectItemType As ISharePointProjectItemType) _
            Implements ISharePointProjectItemTypeExtension.Initialize
            projectItemType.ProjectService.Logger.WriteLine("This message was written " & _
                "by using the project service in an extension for the ListDefinition project item.", _
                LogCategory.Message)
        End Sub
    End Class