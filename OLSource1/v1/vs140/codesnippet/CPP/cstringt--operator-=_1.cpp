   // typedef CStringT<TCHAR, StrTraitATL<TCHAR, ChTraitsCRT<TCHAR>>> CAtlString;

   CAtlString s1, s2;        // Empty CAtlString objects

   s1 = _T("cat");            // s1 = "cat"
   s2 = s1;                  // s1 and s2 each = "cat"
   s1 = _T("the ") + s1;      // Or expressions
   s1 = _T('x');              // Or just individual characters   