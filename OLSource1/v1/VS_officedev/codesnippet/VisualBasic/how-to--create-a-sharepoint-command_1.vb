        <SharePointCommand("Contoso.Commands.UpgradeSolution")> _
        Private Sub UpgradeSolution(ByVal context As ISharePointCommandContext, ByVal fullWspPath As String)
            Dim solution As SPSolution = SPFarm.Local.Solutions(Path.GetFileName(fullWspPath))
            If solution Is Nothing Then
                Throw New InvalidOperationException("The solution has not been deployed.")
            End If
            solution.Upgrade(fullWspPath)
        End Sub