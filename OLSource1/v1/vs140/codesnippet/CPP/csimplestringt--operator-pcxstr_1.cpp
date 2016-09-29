   // If the prototype of a function is known to the compiler,
   // the PCXSTR cast operator may be invoked implicitly.

   CSimpleString strSports(L"Soccer is Best!", pMgr);
   WCHAR sz[1024];

   wcscpy_s(sz, strSports);

   // If the prototype isn't known or is a va_arg prototype,
   // you must invoke the cast operator explicitly. For example,
   // the va_arg part of a call to swprintf_s() needs the cast:

   swprintf_s(sz, 1024, L"I think that %s!\n", (PCWSTR)strSports);

   // While the format parameter is known to be an PCXSTR and
   // therefore doesn't need the cast:

   swprintf_s(sz, 1024, strSports);

   // Note that some situations are ambiguous. This line will
   // put the address of the strSports object to stdout:

   wcout << strSports;

   // while this line will put the content of the string out:

   wcout << (PCWSTR)strSports;   