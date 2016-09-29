   CSimpleString str(_T("Hello"), pMgr);
   TCHAR ch;

   str.LockBuffer();
   ch = str.GetAt(2);
   _tprintf_s(_T("%c"), ch);
   str.UnlockBuffer();