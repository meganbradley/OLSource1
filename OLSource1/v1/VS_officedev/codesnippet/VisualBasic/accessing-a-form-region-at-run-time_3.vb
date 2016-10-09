    Friend Sub Access_All_Form_Regions()
        Dim formRegion As Microsoft.Office.Tools.Outlook.IFormRegion
        For Each formRegion In Globals.FormRegions
            If TypeOf formRegion Is FormRegion1 Then
                Dim formRegion1 As FormRegion1 = _
                    CType(formRegion, FormRegion1)
                formRegion1.textBox1.Text = "Hello World"
            End If
        Next formRegion
    End Sub