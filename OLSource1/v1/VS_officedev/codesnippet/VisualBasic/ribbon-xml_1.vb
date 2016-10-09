    Protected Overrides Function CreateRibbonExtensibilityObject() As  _
    Microsoft.Office.Core.IRibbonExtensibility
        Return New MyRibbon()
    End Function