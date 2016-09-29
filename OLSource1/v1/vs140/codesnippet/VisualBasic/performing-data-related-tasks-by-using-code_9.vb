        Private Sub CustomersListDetail_Saving(ByRef handled As Boolean)
            Try
                Me.DataWorkspace.SharePointData.SaveChanges()

            Catch ex As DataServiceOperationException

                If ex.ErrorInfo = "DTSException" Then
                    Me.ShowMessageBox(ex.Message)
                Else
                    Throw ex

                End If

            End Try

            handled = True


        End Sub