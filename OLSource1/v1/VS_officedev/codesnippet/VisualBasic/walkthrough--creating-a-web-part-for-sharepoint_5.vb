    Public Overrides ReadOnly Property Verbs() As WebPartVerbCollection
        Get
            Dim customVerb As New WebPartVerb("Manager_Filter_Verb", _
                New WebPartEventHandler(AddressOf CustomVerbEventHandler))

            customVerb.Text = verbText
            customVerb.Description = "Shows only employees that are managers"

            Dim newVerbs() As WebPartVerb = {customVerb}

            Return New WebPartVerbCollection(MyBase.Verbs, newVerbs)
        End Get
    End Property

    Protected Sub CustomVerbEventHandler(ByVal sender As Object, ByVal args As WebPartEventArgs)
        Dim titleColumn As Integer = 2

        Dim item As DataGridItem
        For Each item In grid.Items
            If item.Cells(titleColumn).Text <> "Manager" Then
                If item.Visible = True Then
                    item.Visible = False
                Else
                    item.Visible = True
                End If
            End If
        Next item
        If verbText = "Show Managers Only" Then
            verbText = "Show All Employees"
        Else
            verbText = "Show Managers Only"
        End If
    End Sub