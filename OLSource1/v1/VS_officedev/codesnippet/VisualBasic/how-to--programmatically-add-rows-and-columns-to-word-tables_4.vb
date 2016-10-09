        Me.Application.ActiveDocument.Tables.Item(1).Columns.Add( _
            BeforeColumn:=Me.Application.ActiveDocument.Tables.Item(1).Columns(1))
        Me.Application.ActiveDocument.Tables.Item(1).Columns.DistributeWidth()