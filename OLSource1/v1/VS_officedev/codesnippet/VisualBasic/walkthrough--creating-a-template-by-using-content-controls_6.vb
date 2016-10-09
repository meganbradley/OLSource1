            BuildingBlockControl1 = Me.Controls.AddBuildingBlockGalleryContentControl( _
                Me.Paragraphs(1).Range, "buildingBlockControl1")
            BuildingBlockControl1.BuildingBlockCategory = "Employee and Customer Information"
            BuildingBlockControl1.BuildingBlockType = Word.WdBuildingBlockTypes.wdTypeCustom1
            BuildingBlockControl1.PlaceholderText = "Choose your first building block"

            BuildingBlockControl2 = Me.Controls.AddBuildingBlockGalleryContentControl( _
                Me.Paragraphs(2).Range, "buildingBlockControl2")
            BuildingBlockControl2.BuildingBlockCategory = "Employee and Customer Information"
            BuildingBlockControl2.BuildingBlockType = Word.WdBuildingBlockTypes.wdTypeCustom1
            BuildingBlockControl2.PlaceholderText = "Choose your second building block"