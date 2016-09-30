   CSimpleString str(_T("xxxxxxxxxxxxxxxxxxx"), 20, pMgr);
   TCHAR* pszSrc = _T("Hello world!");

   _tprintf_s(_T("%s\n"), str);

   str.CopyChars(str.GetBuffer(), pszSrc, 12);
   _tprintf_s(_T("%s\n"), str);