    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        'This call is required by the Component Designer.
        InitializeComponent()
        Dim MyButton As Microsoft.Office.Tools.Ribbon.RibbonButton = _
            Me.Factory.CreateRibbonButton()
        MyButton.Label = "New Button"
        If System.DateTime.Now.Hour > 16 Then
            Group1.Items.Add(MyButton)
        End If

    End Sub