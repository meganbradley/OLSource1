        Private Sub CityCode_Validate(results As ScreenValidationResultsBuilder)
            If Me.CityCode.Length < 3 Then
                results.AddPropertyError("This string must have at least 3 letters.")
            End If
        End Sub