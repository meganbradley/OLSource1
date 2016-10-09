        If Globals.ThisAddIn.Application.Documents.Count > 0 Then
            Dim NativeDocument As Microsoft.Office.Interop.Word.Document = _
                Globals.ThisAddIn.Application.ActiveDocument
            Dim VstoDocument As Microsoft.Office.Tools.Word.Document = _
                Globals.Factory.GetVstoObject(NativeDocument)
        End If