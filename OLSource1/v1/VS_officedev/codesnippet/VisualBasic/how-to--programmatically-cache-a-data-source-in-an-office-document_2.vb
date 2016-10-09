        dataSet1 = New DataSet()

        If Not (Me.IsCached("dataSet1")) Then
            Me.StartCaching("dataSet1")
        End If