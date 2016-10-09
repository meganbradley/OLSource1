            object fileName = "NewWorkbook.xlsx";
            Excel.Workbook workbook = this.Application.Workbooks.get_Item(fileName);
            workbook.Close(false);