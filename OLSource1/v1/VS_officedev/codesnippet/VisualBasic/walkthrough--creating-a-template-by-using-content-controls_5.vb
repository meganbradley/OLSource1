            If Me.FormsDesign = False Then
                Me.ToggleFormsDesign()
            End If
            Me.Tables(2).Delete()
            Me.Tables(1).Delete()
            Me.ToggleFormsDesign()