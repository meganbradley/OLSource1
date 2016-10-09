            this.fruitList.Range.Sort(
                this.fruitList.ListColumns[1].Range, Excel.XlSortOrder.xlAscending,
                this.fruitList.ListColumns[2].Range, missing, Excel.XlSortOrder.xlAscending,
                missing, Excel.XlSortOrder.xlAscending, 
                Excel.XlYesNoGuess.xlYes, missing, missing, 
                Excel.XlSortOrientation.xlSortColumns,
                Excel.XlSortMethod.xlPinYin, 
                Excel.XlSortDataOption.xlSortNormal,
                Excel.XlSortDataOption.xlSortNormal,
                Excel.XlSortDataOption.xlSortNormal);