    Private Sub Sheet1_Startup(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Startup

        Dim salesButton As Microsoft.Office.Tools.Excel.Controls.Button
        salesButton = Me.Controls.AddButton(Me.Range("C5"), "salesButton")
        salesButton.Text = "Calculate Total Sales"
    End Sub