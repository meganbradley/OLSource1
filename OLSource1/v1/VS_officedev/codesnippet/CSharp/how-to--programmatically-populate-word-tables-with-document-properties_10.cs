            Word.Table tbl = document.Tables[1];
            tbl.Range.Font.Size = 12;
            tbl.Columns.DistributeWidth();

            object styleName = "Table Professional";
            tbl.set_Style(ref styleName);