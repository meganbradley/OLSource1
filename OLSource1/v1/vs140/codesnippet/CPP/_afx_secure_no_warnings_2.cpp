      CRichEditCtrl* pRichEdit = new CRichEditCtrl;
      pRichEdit->Create(WS_CHILD|WS_VISIBLE|WS_BORDER|ES_MULTILINE,
         CRect(10,10,100,200), pParentWnd, 1);
      char sz[256];
      pRichEdit->GetSelText(sz);