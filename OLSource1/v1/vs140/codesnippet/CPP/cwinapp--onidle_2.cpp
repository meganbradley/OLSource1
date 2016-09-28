// In this example, four idle loop tasks are given various 
// opportunities to run:
// Task1 is always given a chance to run during idle time, provided
//   that no message has queued up while the framework was processing
//   its own idle loop tasks (at lCount levels 0 and 1).
// Task2 is given a chance to run only if Task1 has already run,
//   provided that no message has queued up while Task1 was running.
// Task3 and Task4 are given a chance to run only if both Task1 and
//   Task2 have already run, and no message has queued up in the mean
//   time.  If Task3 gets its chance to run, then Task4 always gets
//   a chance to run immediately after Task3.

BOOL CMyWinApp::OnIdle(LONG lCount)
{
   // In this example, as in most applications, you should let the
   // base class CWinApp::OnIdle complete its processing before you
   // attempt any additional idle loop processing.
   if (CWinApp::OnIdle(lCount))
      return TRUE;   

   // The base class CWinApp::OnIdle reserves the lCount values 0 
   // and 1 for the framework's own idle processing.   If you wish to
   // share idle processing time at a peer level with the framework,
   // then replace the above if-statement with a straight call to
   // CWinApp::OnIdle; and then add a case statement for lCount value
   // 0 and/or 1. Study the base class implementation first to 
   // understand how your idle loop tasks will compete with the 
   // framework's idle loop processing.

   switch (lCount)
   {
      case 2:
         Task1();
         return TRUE; // next time give Task2 a chance
      case 3:
         Task2();
         return TRUE; // next time give Task3 and Task4 a chance
      case 4:
         Task3();
         Task4();
         return FALSE; // cycle through the idle loop tasks again
   }
   return TRUE;
}