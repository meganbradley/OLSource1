        Me.Application.Workbooks.OpenText("C:\Test.txt", _
            StartRow:=3, _
            DataType:=Excel.XlTextParsingType.xlDelimited, _
            TextQualifier:=Excel.XlTextQualifier.xlTextQualifierNone, _
            Comma:=True)