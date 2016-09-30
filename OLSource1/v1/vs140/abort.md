---
title: "abort"
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
  - "abort"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "Abort"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "aborting current process"
  - "abort function"
  - "processes, aborting"
ms.assetid: a797783b-40ed-4bdb-a2cd-14ffede39e8a
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# abort
Aborts the current process and returns an error code.  
  
> [!NOTE]
>  Do not use this method to shut down a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app, except in testing or debugging scenarios. Programmatic or UI ways to close a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app are not permitted according to the [Windows 8 app certification requirements](http://go.microsoft.com/fwlink/?LinkId=262889). For more information, see [Application lifecycle (Windows Store apps)](http://go.microsoft.com/fwlink/?LinkId=262853).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> does not return control to the calling process. By default, it checks for an abort signal handler and raises <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if one is set. Then <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> terminates the current process and returns an exit code to the parent process.  
  
## Remarks  
 **Microsoft Specific**  
  
 By default, when an app is built with the debug runtime library, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> routine displays an error message before <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is raised. For console apps running in console mode, the message is sent to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Windows desktop apps and console apps running in windowed mode display the message in a message box. To suppress the message, use [_set_abort_behavior](../vs140/_set_abort_behavior.md) to clear the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> flag. The message displayed depends on the version of the runtime environment used. For applications built by using the most recent version of Visual C++, the message resembles this:  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 In previous versions of the C runtime library, this message was displayed:  
  
 "<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>"  
  
 When the program is compiled in debug mode, the message box displays options to **Abort**, **Retry**, or **Ignore**. If the user chooses **Abort**, the program terminates immediately and returns an exit code of 3. If the user chooses **Retry**, a debugger is invoked for just-in-time debugging, if available. If the user chooses **Ignore**, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> continues normal processing.  
  
 In both retail and debug builds, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> then checks whether an abort signal handler is set. If a non-default signal handler is set, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Use the [signal](../vs140/signal.md) function to associate an abort signal handler function with the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> signal. You can perform custom actions—for example, clean up resources or log information—and terminate the app with your own error code in the handler function. If no custom signal handler is defined, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> does not raise the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> signal.  
  
 By default, in non-debug builds of desktop or console apps, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> then invokes the Windows error reporting mechanism (Dr. Watson) to report failures to Microsoft. This behavior can be enabled or disabled by calling <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and setting or masking the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> flag. When the flag is set, Windows displays a message box that has text something like "A problem caused the program to stop working correctly." The user can choose to invoke a debugger with a **Debug** button, or choose the **Close program** button to terminate the app with an error code that's defined by the operating system.  
  
 If the Windows error reporting handler is not invoked, then <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> calls [_exit](../vs140/exit--_exit--_exit.md) to terminate the process with exit code 3 and returns control to the parent process or the operating system. <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> does not flush stream buffers or do <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> processing.  
  
 For more information about CRT debugging, see [CRT Debugging Techniques](../vs140/crt-debugging-techniques.md).  
  
 **End Microsoft Specific**  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|\<process.h> or \<stdlib.h>|  
  
## Example  
 The following program tries to open a file and aborts if the attempt fails.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **File could not be opened: No such file or directory**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Using abort](../vs140/using-abort.md)   
 [abort Function](../vs140/abort-function--c-.md)   
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [_exec, _wexec Functions](../vs140/_exec--_wexec-functions.md)   
 [exit, _Exit, _exit](../vs140/exit--_exit--_exit.md)   
 [raise](../vs140/raise.md)   
 [signal](../vs140/signal.md)   
 [_spawn, _wspawn Functions](../vs140/_spawn--_wspawn-functions.md)   
 [_DEBUG](../vs140/_debug.md)   
 [_set_abort_behavior](../vs140/_set_abort_behavior.md)