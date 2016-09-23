   CSimpleString s(_T("abcdef"), pMgr);
   ASSERT(_tcscmp(s, _T("abcdef")) == 0);

   s.SetString(_T("Soccer"), 6);
   ASSERT(_tcscmp(s, _T("Soccer")) == 0);   