            int pageIndex = 1;
            Visio.Pages visioDocPages = this.Application.ActiveDocument.Pages;
            if (pageIndex <= visioDocPages.Count)
                visioDocPages[pageIndex].Print();