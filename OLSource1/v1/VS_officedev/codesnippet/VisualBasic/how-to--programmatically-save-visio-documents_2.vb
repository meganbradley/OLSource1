        Dim docPath As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\test\MyDrawing.vsd"
        Me.Application.ActiveDocument.SaveAs(docPath)