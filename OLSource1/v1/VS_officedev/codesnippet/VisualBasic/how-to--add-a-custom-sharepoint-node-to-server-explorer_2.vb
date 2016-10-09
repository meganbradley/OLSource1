    <Export(GetType(IExplorerNodeTypeExtension))> _
    <ExplorerNodeType(ExplorerNodeTypes.SiteNode)> _
    Friend Class SiteNodeExtension
        Implements IExplorerNodeTypeExtension

        Private Sub Initialize(ByVal nodeType As IExplorerNodeType) _
            Implements IExplorerNodeTypeExtension.Initialize
            AddHandler nodeType.NodeChildrenRequested, AddressOf NodeChildrenRequested
        End Sub

        Private Sub NodeChildrenRequested(ByVal Sender As Object, ByVal e As ExplorerNodeEventArgs)
            e.Node.ChildNodes.Add(ExampleNodeTypeProvider.NodeTypeId, _
                "Custom Node", Nothing)
        End Sub
    End Class