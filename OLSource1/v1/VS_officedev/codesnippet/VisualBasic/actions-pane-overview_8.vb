        If Me.CommandBars("Task Pane").Position = _
            Microsoft.Office.Core.MsoBarPosition.msoBarFloating Then

            Me.CommandBars("Task Pane").Top = 0
            Me.CommandBars("Task Pane").Left = 0

        End If