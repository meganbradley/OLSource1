    Private Sub ConvertDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ConvertDate.Click

        Try
            Dim dbl As Double = Me.Range("A5").Value2
            Dim dt As System.DateTime = System.DateTime.FromOADate(dbl)
            Me.Range("A7").Value2 = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub