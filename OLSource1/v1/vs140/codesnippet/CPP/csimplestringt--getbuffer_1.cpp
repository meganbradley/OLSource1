   CSimpleString s(_T("abcd"), pMgr);

   LPTSTR pBuffer = s.GetBuffer(10);
   int    sizeOfBuffer = s.GetAllocLength();

   // Directly access CSimpleString buffer
   _tcscpy_s(pBuffer, sizeOfBuffer, _T("Hello")); 
   ASSERT(_tcscmp(s, _T("Hello")) == 0);

   s.ReleaseBuffer();   