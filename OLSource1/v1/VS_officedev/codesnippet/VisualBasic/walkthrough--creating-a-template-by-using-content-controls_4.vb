            Dim template1 As Word.Template = TryCast(Me.AttachedTemplate, Word.Template)
            If template1 IsNot Nothing Then

                template1.BuildingBlockEntries.Add("Employee Table", _
                    Word.WdBuildingBlockTypes.wdTypeCustom1, "Employee and Customer Information", _
                    Me.Tables(1).Range, InsertOptions:=Word.WdDocPartInsertOptions.wdInsertContent)
                template1.BuildingBlockEntries.Add("Customer Table", _
                    Word.WdBuildingBlockTypes.wdTypeCustom1, "Employee and Customer Information", _
                    Me.Tables(2).Range, InsertOptions:=Word.WdDocPartInsertOptions.wdInsertContent)
            End If