   IBug* pBug = NULL;
   hr = p->QueryInterface(&pBug);
   ATLASSERT(SUCCEEDED(hr));
   IBug* pBug2 = NULL;
   hr = p->QueryInterface(&pBug2);
   ATLASSERT(SUCCEEDED(hr));
   pBug->Release();
   pBug->Release();    // Mismatched - should be pBug2->Release();   