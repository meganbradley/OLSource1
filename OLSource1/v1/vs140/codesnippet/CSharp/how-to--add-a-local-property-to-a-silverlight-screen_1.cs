        partial void CityCode_Validate
            (ScreenValidationResultsBuilder results)
        {
            if (this.CityCode.Length < 3)
            {
                results.AddPropertyError("This string must have at least 3 letters.");
            }

        }