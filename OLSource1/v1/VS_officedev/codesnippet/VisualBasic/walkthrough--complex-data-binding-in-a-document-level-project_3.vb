    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Button1.Click

        Try
            Me.EmployeesTableAdapter.Update(Me.NorthwindDataSet.Employees)

        Catch ex As System.Data.DataException
            MessageBox.Show(ex.Message)
        End Try
    End Sub