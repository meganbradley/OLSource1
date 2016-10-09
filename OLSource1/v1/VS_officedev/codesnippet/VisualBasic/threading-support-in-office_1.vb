        Dim t As New System.Threading.Thread(AddressOf AnObject.aMethod)

        t.SetApartmentState(System.Threading.ApartmentState.STA)
        t.Start()