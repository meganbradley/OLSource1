                Word.Template template1 = this.AttachedTemplate as Word.Template;

                if (template1 != null)
                {
                    object description = null;
                    template1.BuildingBlockEntries.Add("Employee Table",
                        Word.WdBuildingBlockTypes.wdTypeCustom1, "Employee and Customer Information",
                        this.Tables[1].Range, ref description, Word.WdDocPartInsertOptions.wdInsertContent);
                    template1.BuildingBlockEntries.Add("Customer Table",
                        Word.WdBuildingBlockTypes.wdTypeCustom1, "Employee and Customer Information",
                        this.Tables[2].Range, ref description, Word.WdDocPartInsertOptions.wdInsertContent);
                }