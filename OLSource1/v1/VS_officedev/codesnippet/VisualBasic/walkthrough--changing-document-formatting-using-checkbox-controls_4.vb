    Private Sub applyUnderlineFont_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles applyUnderlineFont.Click

        If Me.applyUnderlineFont.Checked Then
            Me.fontText.Underline = Word.WdUnderline.wdUnderlineSingle
        Else
            Me.fontText.Underline = Word.WdUnderline.wdUnderlineNone
        End If
    End Sub