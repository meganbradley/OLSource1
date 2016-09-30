   const int bufferSize = 1024;
   CSimpleString s(_T("abc"), pMgr);

   LPTSTR p = s.GetBuffer(bufferSize);
   _tcscpy_s(p, bufferSize , _T("abc"));   // use the buffer directly
   ASSERT(s.GetLength() == 3); // String length = 3
   s.ReleaseBuffer();  // Surplus memory released, p is now invalid.
   ASSERT(s.GetLength() == 3); // Length still 3