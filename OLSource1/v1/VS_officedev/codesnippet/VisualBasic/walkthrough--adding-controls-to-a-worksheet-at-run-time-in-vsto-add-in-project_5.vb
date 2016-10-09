    Sub Application_WorkbookBeforeSave _
        (ByVal workbook As Microsoft.Office.Interop.Excel.Workbook, _
         ByVal SaveAsUI As Boolean, ByRef Cancel As Boolean) _
         Handles Application.WorkbookBeforeSave

        Dim worksheet As Excel.Worksheet = workbook.Worksheets(1)

        If Globals.Factory.HasVstoObject(worksheet) And
            Globals.Factory.GetVstoObject(worksheet).Controls.Count > 0 Then
            Dim vstoWorksheet As Worksheet = Globals.Factory.GetVstoObject(worksheet)

            While vstoWorksheet.Controls.Count > 0
                Dim vstoControl As Object = vstoWorksheet.Controls(0)
                vstoWorksheet.Controls.Remove(vstoControl)
            End While
        End If
    End Sub