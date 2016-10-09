        Dim dateComment As Excel.Range = Me.Application.Range("A1")
        If Not dateComment.Comment Is Nothing Then
            dateComment.Comment.Delete()
        End If