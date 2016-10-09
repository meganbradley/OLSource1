                buildingBlockControl1 = this.Controls.AddBuildingBlockGalleryContentControl(
                    this.Paragraphs[1].Range, "buildingBlockControl1");
                buildingBlockControl1.BuildingBlockCategory = "Employee and Customer Information";
                buildingBlockControl1.BuildingBlockType = Word.WdBuildingBlockTypes.wdTypeCustom1;
                buildingBlockControl1.PlaceholderText = "Choose your first building block";

                buildingBlockControl2 = this.Controls.AddBuildingBlockGalleryContentControl(
                    this.Paragraphs[2].Range, "buildingBlockControl2");
                buildingBlockControl2.BuildingBlockCategory = "Employee and Customer Information";
                buildingBlockControl2.BuildingBlockType = Word.WdBuildingBlockTypes.wdTypeCustom1;
                buildingBlockControl2.PlaceholderText = "Choose your second building block";