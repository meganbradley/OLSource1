    <Export(GetType(ISharePointProjectItemTypeProvider))> _
    <SharePointProjectItemType("Contoso.CustomAction")> _
    Friend Class CustomActionProvider
        Implements ISharePointProjectItemTypeProvider

        Private Sub InitializeType(ByVal projectItemTypeDefinition As ISharePointProjectItemTypeDefinition) _
            Implements ISharePointProjectItemTypeProvider.InitializeType
            projectItemTypeDefinition.ProjectService.Logger.WriteLine("This message was written " & _
                "by using the project service in the Custom Action project item type.", _
                LogCategory.Message)
        End Sub
    End Class