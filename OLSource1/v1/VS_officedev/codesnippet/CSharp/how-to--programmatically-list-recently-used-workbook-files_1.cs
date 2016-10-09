            Excel.Range rng = this.Application.get_Range("A1");
            for(int i=1; i<=this.Application.RecentFiles.Count; i++)
             {
                rng.get_Offset(i - 1,0).Value2 = this.Application.RecentFiles.get_Item(i).Name;
              }