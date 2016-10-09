        Dim cell As Excel.Range = extendedWorksheet.Range("$A$1:$G$5", System.Type.Missing)
        Me.addressListObject = extendedWorksheet.Controls.AddListObject(cell, "list1")