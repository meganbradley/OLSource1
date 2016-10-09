    Private Sub ShowOrHideComments(ByVal show As Boolean)
        Dim worksheet As Excel.Worksheet = CType(Application.ActiveSheet, Excel.Worksheet)
        Dim i As Integer
        For i = 1 To worksheet.Comments.Count
            worksheet.Comments(i).Visible = show
        Next
    End Sub