    Protected Overrides Function CreateRibbonExtensibilityObject() As  _
        Microsoft.Office.Core.IRibbonExtensibility
        If myCondition = True Then
            Return Globals.Factory.GetRibbonFactory().CreateRibbonManager _
                (New Microsoft.Office.Tools.Ribbon.IRibbonExtension() _
                     {New Ribbon1()})
        Else
            Return Globals.Factory.GetRibbonFactory().CreateRibbonManager _
                (New Microsoft.Office.Tools.Ribbon.IRibbonExtension() _
                     {New Ribbon2()})
        End If
    End Function