        Private Sub FindControlInList()
            Dim index As Integer = 0

            For Each cust As Customer In Customers

                If cust.CompanyName = "Great Lakes Food Market" Then
                    With FindControlInCollection("CompanyName", Customers(index))
                        .IsVisible = False
                        .IsReadOnly = True
                    End With

                End If
                index = index + 1
            Next
        End Sub