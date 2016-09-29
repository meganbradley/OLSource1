   CSimpleString str(_T("abcdefghi"), pMgr);

   _tprintf_s(_T("Allocated length: %d\n"), str.GetLength());
   _tprintf_s(_T("Contents: %s\n"), str);

   str.Truncate(4);
   _tprintf_s(_T("Allocated length: %d\n"), str.GetLength());
   _tprintf_s(_T("Contents: %s\n"), str);