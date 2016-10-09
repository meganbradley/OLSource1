    Dim groupControl1 As Microsoft.Office.Tools.Word.GroupContentControl

    Private Sub ProtectFirstParagraph()

        Dim VstoDocument As Microsoft.Office.Tools.Word.Document = _
            Globals.Factory.GetVstoObject(Me.Application.ActiveDocument)

        VstoDocument.Paragraphs(1).Range.InsertParagraphBefore()

        Dim range1 As Word.Range = VstoDocument.Paragraphs(1).Range
        range1.Text = "You cannot edit or change the formatting of text " & _
                "in this paragraph, because this paragraph is in a GroupContentControl."
        range1.Select()

        groupControl1 = VstoDocument.Controls.AddGroupContentControl("groupControl1")
    End Sub