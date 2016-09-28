   CSimpleString str(pMgr);
   LPTSTR pstr = str.GetBufferSetLength(3);
   pstr[0] = _T('C');
   pstr[1] = _T('u');
   pstr[2] = _T('p');

   // No need for trailing zero or call to ReleaseBuffer()
   // because GetBufferSetLength() set it for us.

   str += _T(" soccer is best!");
   ASSERT(_tcscmp(str, _T("Cup soccer is best!")) == 0);   