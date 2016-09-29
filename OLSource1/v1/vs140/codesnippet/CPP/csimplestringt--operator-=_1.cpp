   CSimpleString s1(pMgr), s2(pMgr);  // Empty CSimpleStringT objects

   s1 = _T("cat");            // s1 = "cat"
   ASSERT(_tcscmp(s1, _T("cat")) == 0);

   s2 = s1;               // s1 and s2 each = "cat"
   ASSERT(_tcscmp(s2, _T("cat")) == 0);

   s1 = _T("the ") + s1;      // Or expressions
   ASSERT(_tcscmp(s1, _T("the cat")) == 0);

   s1 = _T("x");              // Or just individual characters
   ASSERT(_tcscmp(s1, _T("x")) == 0);   