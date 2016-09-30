---
title: "_cexit, _c_exit"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_c_exit"
  - "_cexit"
apilocation: 
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_cexit"
  - "c_exit"
  - "_c_exit"
  - "cexit"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "cleanup operations during processes"
  - "cexit function"
  - "_c_exit function"
  - "_cexit function"
  - "c_exit function"
ms.assetid: f3072045-9924-4b1a-9fef-b0dcd6d12663
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _cexit, _c_exit
Performs cleanup operations and returns without terminating the process.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function calls, in last-in, first-out (LIFO) order, the functions registered by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Then <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> flushes all I/O buffers and closes all open streams before returning. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is the same as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> but returns to the calling process without processing <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or flushing stream buffers. The behavior of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is shown in the following table.  
  
|Function|Behavior|  
|--------------|--------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Performs complete C library termination procedures, terminates process, and exits with supplied status code.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Performs quick C library termination procedures, terminates process, and exits with supplied status code.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Performs complete C library termination procedures and returns to caller, but does not terminate process.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Performs quick C library termination procedures and returns to caller, but does not terminate process.|  
  
 When you call the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> functions, the destructors for any temporary or automatic objects that exist at the time of the call are not called. An automatic object is an object that is defined in a function where the object is not declared to be static. A temporary object is an object created by the compiler. To destroy an automatic object before calling <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, explicitly call the destructor for the object, as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|\<process.h>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|\<process.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 [System::Diagnostics::Process::CloseMainWindow](https://msdn.microsoft.com/en-us/library/system.diagnostics.process.closemainwindow.aspx)  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [abort](../vs140/abort.md)   
 [atexit](../vs140/atexit.md)   
 [_exec, _wexec Functions](../vs140/_exec--_wexec-functions.md)   
 [exit, _Exit, _exit](../vs140/exit--_exit--_exit.md)   
 [_onexit, _onexit_m](../vs140/_onexit--_onexit_m.md)   
 [_spawn, _wspawn Functions](../vs140/_spawn--_wspawn-functions.md)   
 [system, _wsystem](../vs140/system--_wsystem.md)