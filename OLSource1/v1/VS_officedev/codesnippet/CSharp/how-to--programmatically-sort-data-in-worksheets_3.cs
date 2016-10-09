            Excel.Range Fruits = Application.get_Range("A1", "B3");
                Fruits.Sort(
                Fruits.Columns[1], Excel.XlSortOrder.xlAscending,
                Fruits.Columns[2], missing, Excel.XlSortOrder.xlAscending,
                missing, Excel.XlSortOrder.xlAscending,
                Excel.XlYesNoGuess.xlNo, missing, missing,
                Excel.XlSortOrientation.xlSortColumns,
                Excel.XlSortMethod.xlPinYin,
                Excel.XlSortDataOption.xlSortNormal,
                Excel.XlSortDataOption.xlSortNormal,
                Excel.XlSortDataOption.xlSortNormal); 