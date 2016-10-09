    Dim groupControl1 As Microsoft.Office.Tools.Word.GroupContentControl

    Private Sub ProtectFirstParagraph()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        Dim range1 As Word.Range = Me.Paragraphs(1).Range
        range1.Text = "You cannot edit or change the formatting of text " & _
                "in this paragraph, because this paragraph is in a GroupContentControl."
        range1.Select()

        groupControl1 = Me.Controls.AddGroupContentControl("groupControl1")
    End Sub