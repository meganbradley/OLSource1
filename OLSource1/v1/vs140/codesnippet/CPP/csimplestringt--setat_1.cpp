   CSimpleString s(_T("abcdef"), pMgr);

   s.SetAt(1, _T('a'));
   ASSERT(_tcscmp(s, _T("aacdef")) == 0);   