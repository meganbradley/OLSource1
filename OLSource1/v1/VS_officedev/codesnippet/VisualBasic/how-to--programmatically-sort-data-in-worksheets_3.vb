        Dim Fruits As Excel.Range = Me.Application.Range("A1", "B2")
        Fruits.Sort( _
            Key1:=Fruits.Columns(1), Order1:=Excel.XlSortOrder.xlAscending, _
            Key2:=Fruits.Columns(2), Order2:=Excel.XlSortOrder.xlAscending, _
            Orientation:=Excel.XlSortOrientation.xlSortColumns, _
            Header:=Excel.XlYesNoGuess.xlNo, _
            SortMethod:=Excel.XlSortMethod.xlPinYin, _
            DataOption1:=Excel.XlSortDataOption.xlSortNormal, _
            DataOption2:=Excel.XlSortDataOption.xlSortNormal, _
            DataOption3:=Excel.XlSortDataOption.xlSortNormal)