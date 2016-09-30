---
title: "quick_exit"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "cpp"
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "quick_exit"
apilocation: 
  - "api-ms-win-crt-runtime-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "quick_exit"
  - "process/quick_exit"
  - "stdlib/quick_exit"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "quick_exit function"
ms.assetid: ecfbdae6-01c4-45fa-aaeb-b368e1de2a9c
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# quick_exit
Causes normal program termination to occur.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 status  
 The status code to return to the host environment.  
  
## Return Value  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function cannot return to its caller.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function causes normal program termination. It calls no functions registered by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or signal handlers registered by the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function. Behavior is undefined if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is called more than once, or if the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function is also called.  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function calls, in last-in, first-out (LIFO) order, the functions registered by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, except for those functions already called when the function was registered.  Behavior is undefined if a [longjmp](../vs140/longjmp.md) call is made during a call to a registered function that would terminate the call to the  function.  
  
 After the registered functions have been called, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> invokes <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> by using the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> value to return control to the host environment.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|\<process.h> or \<stdlib.h>|  
  
 For more information about compatibility, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [abort](../vs140/abort.md)   
 [atexit](../vs140/atexit.md)   
 [_exec, _wexec Functions](../vs140/_exec--_wexec-functions.md)   
 [exit, _Exit, _exit](../vs140/exit--_exit--_exit.md)   
 [_onexit, _onexit_m](../vs140/_onexit--_onexit_m.md)   
 [_spawn, _wspawn Functions](../vs140/_spawn--_wspawn-functions.md)   
 [system, _wsystem](../vs140/system--_wsystem.md)