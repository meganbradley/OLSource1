    Private Sub ThisAddIn_Startup() Handles Me.Startup

        AddHandler Application.NewDocument, AddressOf WorkWithDocument

    End Sub

    Private Sub WorkWithDocument(ByVal Doc As Microsoft.Office.Interop.Word.Document) _
        Handles Application.DocumentOpen

        Dim rng As Word.Range = Doc.Range(Start:=0, End:=0)
        rng.Text = " New Text "
        rng.Select()

    End Sub