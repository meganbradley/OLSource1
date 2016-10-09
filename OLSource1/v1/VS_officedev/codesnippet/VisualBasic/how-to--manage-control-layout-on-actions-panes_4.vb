    Private Sub ActionsPane_OrientationChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ActionsPane.OrientationChanged

        If Me.ActionsPane.Orientation = Orientation.Horizontal Then

            Me.ActionsPane.StackOrder = Microsoft.Office.Tools.StackStyle.FromLeft
        Else
            Me.ActionsPane.StackOrder = Microsoft.Office.Tools.StackStyle.FromTop
        End If
    End Sub