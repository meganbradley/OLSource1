    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button1.Click
        Me.customerBindingSource.MovePrevious()
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button2.Click
        Me.customerBindingSource.MoveNext()
    End Sub