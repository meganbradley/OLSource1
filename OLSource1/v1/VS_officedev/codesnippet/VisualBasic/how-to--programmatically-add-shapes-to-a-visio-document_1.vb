        Me.Application.Documents.Add("")

        Dim visioDocs As Visio.Documents = Me.Application.Documents
        Dim visioStencil As Visio.Document = visioDocs.OpenEx("Basic Shapes.vss", CShort(Microsoft.Office.Interop.Visio.VisOpenSaveArgs.visOpenDocked))

        Dim visioPage As Visio.Page = Me.Application.ActivePage

        Dim visioRectMaster As Visio.Master = visioStencil.Masters("Rectangle")
        Dim visioRectShape As Visio.Shape = visioPage.Drop(visioRectMaster, 4.25, 5.5)
        visioRectShape.Text = "Rectangle text."

        Dim visioStarMaster As Visio.Master = visioStencil.Masters("Star 7")
        Dim visioStarShape As Visio.Shape = visioPage.Drop(visioStarMaster, 2.0, 5.5)
        visioStarShape.Text = "Star text."

        Dim visioHexagonMaster As Visio.Master = visioStencil.Masters("Hexagon")
        Dim visioHexagonShape As Visio.Shape = visioPage.Drop(visioHexagonMaster, 7.0, 5.5)
        visioHexagonShape.Text = "Hexagon text."