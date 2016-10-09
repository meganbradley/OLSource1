    Private Sub Application_PresentationNewSlide(ByVal Sld As PowerPoint.Slide) _
        Handles Application.PresentationNewSlide
        Dim textBox As PowerPoint.Shape = Sld.Shapes.AddTextbox( _
            Office.MsoTextOrientation.msoTextOrientationHorizontal, 0, 0, 500, 50)
        textBox.TextFrame.TextRange.InsertAfter("This text was added by using code.")
    End Sub