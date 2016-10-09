    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Startup

        inspectors = Me.Application.Inspectors
        Dim inspector As Outlook.Inspector
        For Each inspector In inspectors
            Inspectors_NewInspector(inspector)
        Next inspector
    End Sub