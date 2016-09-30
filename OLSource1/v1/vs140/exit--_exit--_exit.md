---
title: "exit, _Exit, _exit"
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
  - "_exit"
  - "exit"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr120_clr0400.dll"
  - "api-ms-win-crt-runtime-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "Exit"
  - "_exit"
  - "process/exit"
  - "process/_Exit"
  - "stdlib/exit"
  - "stdlib/_Exit"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "exit function"
  - "_exit function"
  - "processes, terminating"
  - "function calls, terminating"
  - "process termination, calling"
ms.assetid: b1501fa6-27c2-478c-9e93-cc4fd802a01f
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# exit, _Exit, _exit
Terminates the calling process. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function terminates it after cleanup; <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> terminate it immediately.  
  
> [!NOTE]
>  Do not use this method to shut down a Universal Windows Platform (UWP) app or a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app, except in testing or debugging scenarios. Programmatic or UI ways to close a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app are not permitted. For more information about Windows 8 and 8.1 apps, see [App lifecycle](http://go.microsoft.com/fwlink/?LinkId=262853). For more information about Windows 10 apps, see [How-to guides for Windows 10 apps](http://go.microsoft.com/fwlink/p/?linkid=619133).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Exit status code.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> functions terminate the calling process. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function calls destructors for thread-local objects, then calls—in last-in-first-out (LIFO) order—the functions that are registered by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and then flushes all file buffers before it terminates the process. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> functions terminate the process without destroying thread-local objects or processing <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> functions, and without flushing stream buffers.  
  
 Although the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> calls do not return a value, the low-order byte of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is made available to the host environment or waiting calling process, if one exists, after the process exits. Typically, the caller sets the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> value to 0 to indicate a normal exit, or to some other value to indicate an error. The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> value is available to the operating-system batch command <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and is represented by one of two constants: <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, which represents a value of 0, or <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, which represents a value of 1.  
  
 The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> functions behave as follows.  
  
|Function|Description|  
|--------------|-----------------|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Performs complete C library termination procedures, terminates the process, and provides the supplied status code to the host environment.|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Performs minimal C library termination procedures, terminates the process, and provides the supplied status code to the host environment.|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|Performs minimal C library termination procedures, terminates the process, and provides the supplied status code to the host environment.|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Performs quick C library termination procedures, terminates the process, and provides the supplied status code to the host environment.|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|Performs complete C library termination procedures and returns to the caller. Does not terminate the process.|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|Performs minimal C library termination procedures and returns to the caller. Does not terminate the process.|  
  
 When you call the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>,  <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> function, the destructors for any temporary or automatic objects that exist at the time of the call are not called. An automatic object is defined in a function where the object is not declared to be static. A temporary object is an object that's created by the compiler. To destroy an automatic object before you call <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, explicitly call the destructor for the object, as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Do not use <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> to call <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> from <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>. If you want to exit the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> function, return <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> from <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|\<process.h> or \<stdlib.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 [System::Diagnostics::Process::Kill](https://msdn.microsoft.com/en-us/library/system.diagnostics.process.kill.aspx)  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [abort](../vs140/abort.md)   
 [atexit](../vs140/atexit.md)   
 [_cexit, _c_exit](../vs140/_cexit--_c_exit.md)   
 [_exec, _wexec Functions](../vs140/_exec--_wexec-functions.md)   
 [_onexit, _onexit_m](../vs140/_onexit--_onexit_m.md)   
 [quick_exit](../vs140/quick_exit.md)   
 [_spawn, _wspawn Functions](../vs140/_spawn--_wspawn-functions.md)   
 [system, _wsystem](../vs140/system--_wsystem.md)