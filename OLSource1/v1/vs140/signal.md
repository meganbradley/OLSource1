---
title: "signal"
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
  - "signal"
apilocation: 
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "signal"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "signal function"
ms.assetid: 094118de-d789-4063-b4f4-cffcc80bf29d
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# signal
Sets interrupt signal handling.  
  
> [!IMPORTANT]
>  Do not use this method to shut down a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app, except in testing or debugging scenarios. Programmatic or UI ways to close a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app are not permitted according to Section 3.6 of the [Windows 8 app certification requirements](http://go.microsoft.com/fwlink/?LinkId=262889). For more information, see [Application lifecycle (Windows Store apps)](http://go.microsoft.com/fwlink/?LinkId=262853).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Signal value.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Function to be executed. The first parameter is a signal value and the second parameter is a sub-code that can be used when the first parameter is SIGFPE.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns the previous value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> that's associated with the given signal. For example, if the previous value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> was <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the return value is also <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. A return value of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> indicates an error; in that case, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 See [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information about return codes.  
  
## Remarks  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function enables a process to choose one of several ways to handle an interrupt signal from the operating system. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> argument is the interrupt to which <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> responds; it must be one of the following manifest constants, which are defined in SIGNAL.H.  
  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> value|Description|  
|-----------------|-----------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Abnormal termination|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Floating-point error|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Illegal instruction|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|CTRL+C signal|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Illegal storage access|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Termination request|  
  
 If <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is not one of the above values, the invalid parameter handler is invoked, as defined in [Parameter Validation](../vs140/parameter-validation.md) . If execution is allowed to continue, this function sets <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 By default, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> terminates the calling program with exit code 3, regardless of the value of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is not supported for any Win32 application. When a CTRL+C interrupt occurs, Win32 operating systems generate a new thread to specifically handle that interrupt. This can cause a single-thread application, such as one in UNIX, to become multithreaded and cause unexpected behavior.  
  
 The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> argument is an address to a signal handler that you write, or to one of the predefined constants <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, which are also defined in SIGNAL.H. If <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is a function, it is installed as the signal handler for the given signal. The signal handler's prototype requires one formal argument, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, of type <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. The operating system provides the actual argument through <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> when an interrupt occurs; the argument is the signal that generated the interrupt. Therefore, you can use the six manifest constants (listed in the preceding table) in your signal handler to determine which interrupt occurred and take appropriate action. For example, you can call <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> twice to assign the same handler to two different signals, and then test the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> argument in the handler to take different actions based on the signal received.  
  
 If you are testing for floating-point exceptions (<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>), <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> points to a function that takes an optional second argument that is one of several manifest constants—defined in FLOAT.H—of the form <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>. When a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> signal occurs, you can test the value of the second argument to determine the kind of floating-point exception and then take appropriate action. This argument and its possible values are Microsoft extensions.  
  
 For floating-point exceptions, the value of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is not reset when the signal is received. To recover from floating-point exceptions, use try/except clauses to surround the floating point operations. It's also possible to recover by using [setjmp](../vs140/setjmp.md) with [longjmp](../vs140/longjmp.md). In either case, the calling process resumes execution and leaves the floating-point state of the process undefined.  
  
 If the signal handler returns, the calling process resumes execution immediately following the point at which it received the interrupt signal. This is true regardless of the kind of signal or operating mode.  
  
 Before the specified function is executed, the value of <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. The next interrupt signal is treated as described for <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, unless an intervening call to <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> specifies otherwise. You can use this feature to reset signals in the called function.  
  
 Because signal-handler routines are usually called asynchronously when an interrupt occurs, your signal-handler function may get control when a run-time operation is incomplete and in an unknown state. The following list summarizes the restrictions that determine which functions you can use in your signal-handler routine.  
  
-   Do not issue low-level or STDIO.H I/O routines (for example, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>).  
  
-   Do not call heap routines or any routine that uses the heap routines (for example, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>). See [malloc](../vs140/malloc.md) for more information.  
  
-   Do not use any function that generates a system call (for example, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>).  
  
-   Do not use <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> unless the interrupt is caused by a floating-point exception (that is, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>). In this case, first reinitialize the floating-point package by using a call to <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
-   Do not use any overlay routines.  
  
 A program must contain floating-point code if it is to trap the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> exception by using the function. If your program does not have floating-point code and requires the run-time library's signal-handling code, just declare a volatile double and initialize it to zero:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> signals are not generated under Windows. They are included for ANSI compatibility. Therefore, you can set signal handlers for these signals by using <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, and you can also explicitly generate these signals by calling [raise](../vs140/raise.md).  
  
 Signal settings are not preserved in spawned processes that are created by calls to <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> functions. The signal settings are reset to the default values in the new process.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|\<signal.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
 The following example shows how to use <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> to add some custom behavior to the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> signal. For additional information about abort behavior, see [_set_abort_behavior](../vs140/_set_abort_behavior.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **This application has requested the Runtime to terminate it in an unusual way.**  
**Please contact the application's support team for more information.**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [abort](../vs140/abort.md)   
 [_exec, _wexec Functions](../vs140/_exec--_wexec-functions.md)   
 [exit, _Exit, _exit](../vs140/exit--_exit--_exit.md)   
 [_fpreset](../vs140/_fpreset.md)   
 [_spawn, _wspawn Functions](../vs140/_spawn--_wspawn-functions.md)