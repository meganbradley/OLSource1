    Private document1 As Word.Document = Nothing

    Private Sub CreateDocument1()
        document1 = Me.Application.Documents.Add()
    End Sub

    Private Sub Application_DocumentBeforeSave(ByVal Doc As Word.Document, _
        ByRef SaveAsUI As Boolean, ByRef Cancel As Boolean) _
        Handles Application.DocumentBeforeSave
        If Type.ReferenceEquals(Doc, document1) Then
            Cancel = True
        End If
    End Sub