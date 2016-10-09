    Private Sub Button_Click(ByVal sender As System.Object, _
        ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) _
            Handles Button.Click

        Dim NativeWorksheet As Microsoft.Office.Interop.Excel.Worksheet =
            Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets(1)

        Dim worksheet As Microsoft.Office.Tools.Excel.Worksheet =
            Globals.Factory.GetVstoObject(NativeWorksheet)


        Dim buttonName As String = "MyButton"

        If CType(sender, RibbonCheckBox).Checked Then
            Dim selection As Excel.Range = Globals.ThisAddIn.Application.Selection
            If Not (selection Is Nothing) Then
                Dim button As New Microsoft.Office.Tools.Excel.Controls.Button()
                worksheet.Controls.AddControl(button, selection, buttonName)
            End If
        Else
            worksheet.Controls.Remove(buttonName)
        End If
    End Sub