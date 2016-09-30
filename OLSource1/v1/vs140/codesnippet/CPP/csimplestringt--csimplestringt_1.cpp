   CSimpleString s1(pMgr);                   // Empty string
   CSimpleString s2(_T("cat"), pMgr);        // From a C string literal

   CSimpleString s3(s2);                     // Copy constructor
   CSimpleString s4(s2 + _T(" ") + s3);      // From a string expression

   CSimpleString s5(_T("xxxxxx"), 6, pMgr);  // s5 = "xxxxxx"   