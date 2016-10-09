        Dim document As Word.Document = Me.Application.ActiveDocument
        Dim firstRange As Word.Range = document.Paragraphs(1).Range
        Dim secondRange As Word.Range = document.Paragraphs(2).Range

        Dim firstString As String = firstRange.Text
        Dim secondString As String = secondRange.Text