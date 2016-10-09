    Private Sub AddData(ByVal row As System.Data.DataRow, ByVal companyName As String)

        ' Create a table if it doesn't already exist.
        If Globals.ThisDocument.Tables.Count = 0 Then

            Try
                ' Create a table. 
                Dim tbl As Word.Table = Globals.ThisDocument.Tables.Add( _
                    Globals.ThisDocument.Application.Selection.Range, 1, 4)

                ' Insert headings.
                SetHeadings(tbl.Cell(1, 1), "Company Name")
                SetHeadings(tbl.Cell(1, 2), "Product Name")
                SetHeadings(tbl.Cell(1, 3), "Quantity")
                SetHeadings(tbl.Cell(1, 4), "Unit Price")

            Catch ex As Exception
                MessageBox.Show("Problem creating Products table: " & ex.Message, _
                    "Actions Pane", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        ' Add data from data row to the table.
        Dim selection As Word.Selection = Globals.ThisDocument.Application.Selection

        If selection.Tables.Count > 0 Then

            Dim newRow As Word.Row = Globals.ThisDocument.Tables(1).Rows.Add()
            With newRow
                .Range.Font.Bold = False
                .Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                .Cells(4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                .Cells(1).Range.Text = companyName
                .Cells(2).Range.Text = row.Item("ProductName").ToString
                .Cells(3).Range.Text = row.Item("QuantityPerUnit").ToString
                .Cells(4).Range.Text = Math.Round(row.Item("UnitPrice"), 2)
            End With

        Else
            MessageBox.Show("Cursor must be within a table.", _
                "Actions Pane", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub