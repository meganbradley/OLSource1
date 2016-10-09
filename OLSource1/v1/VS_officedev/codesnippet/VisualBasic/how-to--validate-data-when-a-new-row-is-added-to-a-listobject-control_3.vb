    Private Sub list1_BeforeAddDataBoundRow(ByVal sender As Object, ByVal e As  _
        Microsoft.Office.Tools.Excel.BeforeAddDataBoundRowEventArgs) _
        Handles list1.BeforeAddDataBoundRow

        Dim row As System.Data.DataRow = (CType(e.Item, System.Data.DataRowView)).Row

        If Not row("Age") Is Nothing And Not row("Age") Is Convert.DBNull Then

            Dim ageEntered As Integer = CType(row("Age"), Int32)

            If ageEntered < 21 Or ageEntered > 65 Then
                System.Windows.Forms.MessageBox.Show _
                    ("Age must be between 21 and 65. The row cannot be added.")
                e.Cancel = True
                Return
            End If

            row("ID") = id
            id += 1

        Else
            System.Windows.Forms.MessageBox.Show("You must enter an age.")
            e.Cancel = True
        End If
    End Sub