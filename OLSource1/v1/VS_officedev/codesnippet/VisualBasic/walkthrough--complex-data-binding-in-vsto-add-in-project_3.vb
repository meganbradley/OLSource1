        Dim worksheet As Excel.Worksheet = DirectCast(Me.Application.ActiveWorkbook.Worksheets(1), Excel.Worksheet)

        ' Create a workhseet host item.
        Dim extendedWorksheet As Worksheet = Globals.Factory.GetVstoObject(worksheet)
