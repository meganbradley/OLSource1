    Private Sub ShowOrHideComments(ByVal show As Boolean)
        Dim i As Integer
        For i = 1 To Me.Comments.Count
            Me.Comments(i).Visible = show
        Next
    End Sub