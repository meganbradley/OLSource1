   CSimpleString str(_T("xxxxxxxxxxxxxxxxxxx"), 20, pMgr);

   TCHAR* pszSrc = NULL;
   pszSrc = new TCHAR[12];
   str.CopyChars(str.GetBuffer(), pszSrc, 12);