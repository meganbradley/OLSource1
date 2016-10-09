    Private Sub NamedRange_Click(ByVal sender As System.Object, _
        ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) _
            Handles NamedRange.Click

        Dim NativeWorksheet As Microsoft.Office.Interop.Excel.Worksheet =
            Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets(1)

        Dim worksheet As Microsoft.Office.Tools.Excel.Worksheet =
            Globals.Factory.GetVstoObject(NativeWorksheet)

        Dim rangeName As String = "MyNamedRange"

        If CType(sender, RibbonCheckBox).Checked Then
            Dim selection As Excel.Range = Globals.ThisAddIn.Application.Selection
            If Not (selection Is Nothing) Then
                Dim namedRange As NamedRange = _
                    worksheet.Controls.AddNamedRange(selection, rangeName)
            End If
        Else
            worksheet.Controls.Remove(rangeName)
        End If
    End Sub