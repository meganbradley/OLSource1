        Dim dateComment As Excel.Range = Me.Application.Range("A1")
        dateComment.AddComment("Comment added " & DateTime.Now)