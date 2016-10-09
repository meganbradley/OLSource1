
    Private Function CreateRibbonDropDownItem() As RibbonDropDownItem
        Return Me.Factory.CreateRibbonDropDownItem()
    End Function

    Private Function CreateRibbonMenu() As RibbonMenu
        Return Me.Factory.CreateRibbonMenu()
    End Function

    Private Function CreateRibbonButton() As RibbonButton
        Dim button As RibbonButton = Me.Factory.CreateRibbonButton()
        AddHandler (button.Click), AddressOf Button_Click
        Return button
    End Function