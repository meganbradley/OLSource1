        Private Sub MapItFactory_FormRegionInitializing(ByVal sender As Object, ByVal e As Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs) Handles Me.FormRegionInitializing

            Dim myItem As Outlook.ContactItem = CType(e.OutlookItem, Outlook.ContactItem)

            If Not (myItem Is Nothing) Then
                If Not (myItem.BusinessAddress Is Nothing) AndAlso myItem.BusinessAddress.Trim().Length > 0 Or (Not (myItem.HomeAddress Is Nothing) AndAlso myItem.HomeAddress.Trim().Length > 0) Or (Not (myItem.OtherAddress Is Nothing) AndAlso myItem.OtherAddress.Trim().Length > 0) Then
                    Return
                End If
            End If

            e.Cancel = True

        End Sub