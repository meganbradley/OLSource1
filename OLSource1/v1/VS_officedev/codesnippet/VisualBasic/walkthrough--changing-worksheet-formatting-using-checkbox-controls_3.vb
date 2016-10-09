    Private Sub applyUnderlineFont_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles applyUnderlineFont.Click

        If Me.applyUnderlineFont.Checked Then
            Me.textFont.Font.Underline = Excel.XlUnderlineStyle.xlUnderlineStyleSingle
        Else
            Me.textFont.Font.Underline = Excel.XlUnderlineStyle.xlUnderlineStyleNone
        End If
    End Sub