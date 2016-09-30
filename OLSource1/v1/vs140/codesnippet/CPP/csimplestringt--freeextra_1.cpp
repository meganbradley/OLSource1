   CAtlString basestr;
   IAtlStringMgr* pMgr;

   pMgr= basestr.GetManager();
   ASSERT(pMgr != NULL);

   // Create a CSimpleString with 28 characters
   CSimpleString str(_T("Many sports are fun to play."), 28, pMgr);
   _tprintf_s(_T("Alloc length is %d, String length is %d\n"),
      str.GetAllocLength(), str.GetLength());

   // Assigning a smaller string won't cause CSimpleString to free its
   // memory, because it assumes the string will grow again anyway.
   str = _T("Soccer is best!");
   _tprintf_s(_T("Alloc length is %d, String length is %d\n"),
      str.GetAllocLength(), str.GetLength());

   // This call forces CSimpleString to release the extra
   // memory it doesn't need.
   str.FreeExtra();
   _tprintf_s(_T("Alloc length is %d, String length is %d\n"),
      str.GetAllocLength(), str.GetLength());