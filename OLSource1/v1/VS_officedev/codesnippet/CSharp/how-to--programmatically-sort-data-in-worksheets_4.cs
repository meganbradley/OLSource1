            Excel.ListObject fruitList = 
                 ((Excel.Worksheet)Application.ActiveSheet).
                     ListObjects.Add(Microsoft.Office.Interop.Excel.XlListObjectSourceType.xlSrcRange,
                     Application.get_Range("A1", "B3"), 
                     missing, Microsoft.Office.Interop.Excel.XlYesNoGuess.xlNo); 
                fruitList.Range.Sort(
                    fruitList.ListColumns[1].Range, Excel.XlSortOrder.xlAscending,
                    fruitList.ListColumns[2].Range, missing, Excel.XlSortOrder.xlAscending,
                    missing, Excel.XlSortOrder.xlAscending,
                    Excel.XlYesNoGuess.xlYes, missing, missing,
                    Excel.XlSortOrientation.xlSortColumns,
                    Excel.XlSortMethod.xlPinYin,
                    Excel.XlSortDataOption.xlSortNormal,
                    Excel.XlSortDataOption.xlSortNormal,
                    Excel.XlSortDataOption.xlSortNormal);