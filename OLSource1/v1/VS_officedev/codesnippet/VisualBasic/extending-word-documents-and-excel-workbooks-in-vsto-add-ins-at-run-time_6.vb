    Private document2 As Word.Document = Nothing
    Private WithEvents vstoDocument As Microsoft.Office.Tools.Word.Document = Nothing

    Private Sub CreateDocument2()
        document2 = Me.Application.Documents.Add()
        vstoDocument = Globals.Factory.GetVstoObject(document2)
    End Sub

    Private Sub vstoDocument_BeforeSave(ByVal sender As Object, _
        ByVal e As SaveEventArgs) Handles vstoDocument.BeforeSave
        e.Cancel = True
    End Sub