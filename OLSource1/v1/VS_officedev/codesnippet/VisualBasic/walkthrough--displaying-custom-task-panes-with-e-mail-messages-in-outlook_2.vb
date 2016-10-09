Public Class InspectorWrapper
    Private inspector As Outlook.Inspector
    Private WithEvents inspectorEvents As Outlook.InspectorEvents_Event
    Private WithEvents taskPane As CustomTaskPane