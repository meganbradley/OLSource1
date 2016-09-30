   CSimpleString str1(pMgr), str2(pMgr);

   str1.SetString(_T("Soccer is"));
   str2.SetString(_T(" an elegant game"));

   str1.Append(str2);
   ASSERT(_tcscmp(str1, _T("Soccer is an elegant game")) == 0);