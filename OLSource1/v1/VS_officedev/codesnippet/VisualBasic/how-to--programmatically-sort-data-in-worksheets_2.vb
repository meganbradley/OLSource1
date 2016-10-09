        Me.fruitList.Range.Sort( _
            Key1:=Me.fruitList.ListColumns(1).Range, Order1:=Excel.XlSortOrder.xlAscending, _
            Key2:=Me.fruitList.ListColumns(2).Range, Order2:=Excel.XlSortOrder.xlAscending, _
            Orientation:=Excel.XlSortOrientation.xlSortColumns, _
            Header:=Excel.XlYesNoGuess.xlYes)