        Private Sub Execute(ByVal context As IDeploymentContext) _
            Implements IDeploymentStep.Execute
            context.Logger.WriteLine("Upgrading solution: " & solutionName, LogCategory.Status)
            context.Project.SharePointConnection.ExecuteCommand("Contoso.Commands.UpgradeSolution", _
                solutionFullPath)
        End Sub