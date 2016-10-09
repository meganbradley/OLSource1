<ToolboxItemAttribute(false)> _
Public Class VisualWebPart1
    Inherits WebPart

    Private Const _ascxPath As String = "~/_CONTROLTEMPLATES/VB/VisualWebPart1/VisualWebPart1UserControl.ascx"

    Public Sub New()
    End Sub

    Protected Overrides Sub CreateChildControls()
        Dim control As Control = Page.LoadControl(_ascxPath)
        Controls.Add(control)
        MyBase.CreateChildControls()
    End Sub

    Protected Overrides Sub RenderContents(ByVal writer As HtmlTextWriter)
        MyBase.RenderContents(writer)
    End Sub

End Class