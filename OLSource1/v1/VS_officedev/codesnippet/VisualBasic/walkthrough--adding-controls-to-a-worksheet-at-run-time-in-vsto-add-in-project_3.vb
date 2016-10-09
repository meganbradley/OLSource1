    Private Sub ListObject_Click(ByVal sender As System.Object, _
        ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) _
            Handles ListObject.Click

        Dim NativeWorksheet As Microsoft.Office.Interop.Excel.Worksheet =
            Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets(1)

        Dim worksheet As Microsoft.Office.Tools.Excel.Worksheet =
            Globals.Factory.GetVstoObject(NativeWorksheet)


        Dim listObjectName As String = "MyListObject"

        If CType(sender, RibbonCheckBox).Checked Then
            Dim selection As Excel.Range = _
                Globals.ThisAddIn.Application.Selection
            If Not (selection Is Nothing) Then
                worksheet.Controls.AddListObject(selection, listObjectName)
            End If
        Else
            worksheet.Controls.Remove(listObjectName)
        End If
    End Sub