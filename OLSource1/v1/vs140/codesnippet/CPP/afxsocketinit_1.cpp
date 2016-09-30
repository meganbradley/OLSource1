      if (!AfxSocketInit())
      {
         AfxMessageBox(_T("Failed to Initialize Sockets"), MB_OK | MB_ICONSTOP);
         return FALSE;
      }