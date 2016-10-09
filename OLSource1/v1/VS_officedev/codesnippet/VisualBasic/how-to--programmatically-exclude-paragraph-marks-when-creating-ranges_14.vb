    Private Sub ReplaceParagraphText()

        Dim document As Word.Document = Me.Application.ActiveDocument
        Dim firstRange As Word.Range = document.Paragraphs(1).Range
        Dim secondRange As Word.Range = document.Paragraphs(2).Range

        Dim firstString As String = firstRange.Text
        Dim secondString As String = secondRange.Text

        firstRange.Text = secondString
        secondRange.Text = firstString

        firstRange.Select()
        MessageBox.Show(firstRange.Text)
        secondRange.Select()
        MessageBox.Show(secondRange.Text)

        firstRange.MoveEnd(Unit:=Word.WdUnits.wdCharacter, Count:=-1)

        firstRange.Text = "New content for paragraph 1."
        secondRange.Text = "New content for paragraph 2."

        firstRange.Select()
        MessageBox.Show(firstRange.Text)
        secondRange.Select()
        MessageBox.Show(secondRange.Text)

        firstRange.MoveEnd(Unit:=Word.WdUnits.wdCharacter, Count:=1)

        secondRange.Delete()

        firstRange.Text = firstString

        firstRange.InsertAfter(secondString)
        firstRange.Select()
    End Sub