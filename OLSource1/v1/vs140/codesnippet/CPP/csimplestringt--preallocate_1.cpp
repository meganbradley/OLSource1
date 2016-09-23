   CSimpleString str(pMgr);

   _tprintf_s(_T("Allocated length: %d\n"), str.GetAllocLength());
   str.Preallocate(100);
   _tprintf_s(_T("Allocated length: %d\n"), str.GetAllocLength());