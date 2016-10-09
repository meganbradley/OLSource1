        // Keep track of the previously bolded row.
        static int previousRow = 0;

        private void BoldCurrentRow(Excel.Worksheet ws)
        {
            // Work with the current active cell.
            Excel.Range currentCell = this.Application.ActiveCell;

            // Bold the current row.
            currentCell.EntireRow.Font.Bold = true; 

            // If a pass has been done previously, make the old row not bold.
            // Make sure previousRow is not 0 (otherwise this is your first pass through).
            if (previousRow != 0)
            
                // Make sure the current row is not the same as the previous row.
                if (currentCell.Row != previousRow)
                {
                    Excel.Range rng = (Excel.Range)ws.Rows[previousRow];
                    rng.EntireRow.Font.Bold = false;
                }

            // Store the new row number for the next pass.
            previousRow = currentCell.Row;
        }