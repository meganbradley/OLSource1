   CSimpleString str(_T("abc"), pMgr);
   ASSERT(_tcscmp((str += _T("def")), _T("abcdef")) == 0);   