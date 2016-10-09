    <Export(GetType(IExplorerNodeTypeProvider))> _
    <ExplorerNodeType(ExampleNodeTypeProvider.NodeTypeId)> _
    Friend Class ExampleNodeTypeProvider
        Implements IExplorerNodeTypeProvider
        Friend Const NodeTypeId As String = "Contoso.ServerExplorerNodeExample"

        Private Sub InitializeType(ByVal typeDefinition As IExplorerNodeTypeDefinition) _
            Implements IExplorerNodeTypeProvider.InitializeType
            typeDefinition.DefaultIcon = _
                My.Resources.CustomChildNodeIcon.ToBitmap()
            typeDefinition.IsAlwaysLeaf = True
        End Sub
    End Class