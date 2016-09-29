   // Starts and locks control's (Microsoft Calendar) class factory. 
   // Control will remain in memory for lifetime of
   // application or until AfxOleUnlockControl() is called.
   
   AfxOleLockControl(_T("MSCAL.Calendar"));