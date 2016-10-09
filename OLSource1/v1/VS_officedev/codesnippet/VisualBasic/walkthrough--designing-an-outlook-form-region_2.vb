    Private Sub MapIt_FormRegionShowing(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles MyBase.FormRegionShowing
        Dim tempLoc As String = ""
        Dim defaultAddress As String = ""
        Dim scratchPadAddress As String = ""

        Dim myItem As Outlook.ContactItem = _
            CType(Me.OutlookItem, Outlook.ContactItem)

        If Not (myItem Is Nothing) Then
            If Not (myItem.HomeAddress Is Nothing) And _
                myItem.HomeAddress.Trim().Length > 0 Then
                tempLoc = myItem.HomeAddressStreet.Trim() + " " _
                    + myItem.HomeAddressCity + " " + myItem.HomeAddressState + _
                        " " + myItem.HomeAddressPostalCode
                If myItem.HomeAddress = myItem.MailingAddress Then
                    defaultAddress = tempLoc + "_Home"
                Else
                    scratchPadAddress += "adr." + tempLoc + "_Home~"
                End If
            End If
            If Not (myItem.BusinessAddress Is Nothing) And _
                myItem.BusinessAddress.Trim().Length > 0 Then
                tempLoc = myItem.BusinessAddressStreet.Trim() + " " _
                    + myItem.BusinessAddressCity + " " + _
                        myItem.BusinessAddressState + " " + _
                            myItem.BusinessAddressPostalCode
                If myItem.BusinessAddress = myItem.MailingAddress Then
                    defaultAddress = tempLoc + "_Business"
                Else
                    scratchPadAddress += "adr." + tempLoc + "_Business~"
                End If
            End If
            If Not (myItem.OtherAddress Is Nothing) And _
                myItem.OtherAddress.Trim().Length > 0 Then
                tempLoc = myItem.OtherAddressStreet.Trim() + " " + _
                    myItem.OtherAddressCity + " " + myItem.OtherAddressState + _
                        " " + myItem.OtherAddressPostalCode
                If myItem.OtherAddress = myItem.MailingAddress Then
                    defaultAddress = tempLoc + "_Other"
                Else
                    scratchPadAddress += "adr." + tempLoc + "_Other~"
                End If
            End If
        End If

        WebBrowser1.Navigate(("http://local.live.com/default.aspx?style=r&where1=" _
            + defaultAddress + "&sp=" + scratchPadAddress))

    End Sub