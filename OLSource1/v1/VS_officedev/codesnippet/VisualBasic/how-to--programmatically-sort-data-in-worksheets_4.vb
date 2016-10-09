        Dim fruitList As Excel.ListObject = CType(Application.ActiveSheet,  _
            Excel.Worksheet).ListObjects.AddEx(Excel.XlListObjectSourceType.xlSrcRange, _
            Application.Range("A1", "B2"))
        fruitList.Range.Sort( _
        Key1:=fruitList.ListColumns(1).Range, Order1:=Excel.XlSortOrder.xlAscending, _
        Key2:=fruitList.ListColumns(2).Range, Order2:=Excel.XlSortOrder.xlAscending, _
        Orientation:=Excel.XlSortOrientation.xlSortColumns, _
        Header:=Excel.XlYesNoGuess.xlYes)