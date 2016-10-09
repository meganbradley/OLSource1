    Private Sub Application_DocumentOpen_ClearActiveXWrappers( _
        ByVal Doc As Word.Document) Handles Application.DocumentOpen

        Dim vstoDocument As Document = Globals.Factory.GetVstoObject(Doc)

    End Sub