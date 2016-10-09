    Protected Overrides Function CreateRibbonExtensibilityObject() _
        As Microsoft.Office.Core.IRibbonExtensibility
        Dim myCondition As Boolean = True
        If myCondition = True Then
            Dim tempRibbon As New Ribbon1()
            tempRibbon.Tab1.ControlId.ControlIdType = _
                Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
            tempRibbon.Tab1.ControlId.OfficeId = "TabHome"
            Return Globals.Factory.GetRibbonFactory.CreateRibbonManager _
                (New Microsoft.Office.Tools.Ribbon.IRibbonExtension() {tempRibbon})
        Else
            Dim tempRibbon As New Ribbon2()
            tempRibbon.Tab1.ControlId.ControlIdType = _
                Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
            tempRibbon.Tab1.ControlId.OfficeId = "TabInsert"
            Return Globals.Factory.GetRibbonFactory.CreateRibbonManager _
                (New Microsoft.Office.Tools.Ribbon.IRibbonExtension() {tempRibbon})
        End If
    End Function