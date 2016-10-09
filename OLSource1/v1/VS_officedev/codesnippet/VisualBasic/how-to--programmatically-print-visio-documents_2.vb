        Dim pageIndex As Integer = 1
        Dim visioDocPages As Visio.Pages = Me.Application.ActiveDocument.Pages
        If pageIndex <= visioDocPages.Count Then
            visioDocPages(pageIndex).Print()
        End If