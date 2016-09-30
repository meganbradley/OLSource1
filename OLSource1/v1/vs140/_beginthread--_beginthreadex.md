---
title: "_beginthread, _beginthreadex"
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
  - "_beginthread"
  - "_beginthreadex"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "beginthread"
  - "_beginthread"
  - "beginthreadex"
  - "_beginthreadex"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_beginthread function"
  - "threading [C++], creating threads"
  - "beginthreadex function"
  - "_beginthreadex function"
  - "beginthread function"
ms.assetid: 0df64740-a978-4358-a88f-fb0702720091
caps.latest.revision: 38
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _beginthread, _beginthreadex
Creates a thread.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Start address of a routine that begins execution of a new thread. For <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the calling convention is either [__cdecl](../vs140/__cdecl.md) (for native code) or [__clrcall](../vs140/__clrcall.md) (for managed code); for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, it is either [__stdcall](../vs140/__stdcall.md) (for native code) or [__clrcall](../vs140/__clrcall.md) (for managed code).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Stack size for a new thread, or 0.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Argument list to be passed to a new thread, or NULL.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Pointer to a [SECURITY_ATTRIBUTES](http://msdn.microsoft.com/library/windows/desktop/aa379560) structure that determines whether the returned handle can be inherited by child processes. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is NULL, the handle cannot be inherited. Must be NULL for Windows 95 applications.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Flags that control the initial state of a new thread. Set <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to run immediately, or to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to create the thread in a suspended state; use [ResumeThread](http://msdn.microsoft.com/library/windows/desktop/ms685086.aspx) to execute the thread. Set <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> flag to use <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> as the initial reserve size of the stack in bytes; if this flag is not specified, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> specifies the commit size.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Points to a 32-bit variable that receives the thread identifier. If it's NULL, it's not used.  
  
## Return Value  
 If successful, each of these functions returns a handle to the newly created thread; however, if the newly created thread exits too quickly, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> might not return a valid handle. (See the discussion in the Remarks section.) On an error, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> returns -1L, and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> if there are too many threads, to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> if the argument is invalid or the stack size is incorrect, or to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> if there are insufficient resources (such as memory). On an error, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> returns 0, and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> are set.  
  
 If <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is NULL, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and return -1.  
  
 For more information about these and other return codes, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 For more information about <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, see [Standard Types](../vs140/standard-types.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> function creates a thread that begins execution of a routine at <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. The routine at <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> must use the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> (for native code) or <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> (for managed code) calling convention and should have no return value. When the thread returns from that routine, it is terminated automatically. For more information about threads, see [Multithreading Support for Older Code (Visual C++)](../vs140/multithreading-support-for-older-code--visual-c---.md).  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> resembles the Win32 [CreateThread](http://msdn.microsoft.com/library/windows/desktop/ms682453.aspx) API more closely than <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> does. <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> differs from <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> in the following ways:  
  
-   <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> has three additional parameters: <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>. The new thread can be created in a suspended state, with a specified security, and can be accessed by using <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, which is the thread identifier.  
  
-   The routine at <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> that's passed to <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> must use the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> (for native code) or <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> (for managed code) calling convention and must return a thread exit code.  
  
-   <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> returns 0 on failure, rather than -1L.  
  
-   A thread that's created by using <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is terminated by a call to [_endthreadex](../vs140/_endthread--_endthreadex.md).  
  
 The <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> function gives you more control over how the thread is created than <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> does. The <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> function is also more flexible. For example, with <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, you can use security information, set the initial state of the thread (running or suspended), and get the thread identifier of the newly created thread. You can also use the thread handle that's returned by <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> with the synchronization APIs, which you cannot do with <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
 It's safer to use <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> than <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>. If the thread that's generated by <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> exits quickly, the handle that's returned to the caller of <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> might be invalid or point to another thread. However, the handle that's returned by <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> has to be closed by the caller of <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, so it is guaranteed to be a valid handle if <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> did not return an error.  
  
 You can call [_endthread](../vs140/_endthread--_endthreadex.md) or <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> explicitly to terminate a thread; however, <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> is called automatically when the thread returns from the routine that's passed as a parameter. Terminating a thread with a call to <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> helps ensure correct recovery of resources that are allocated for the thread.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> automatically closes the thread handle, whereas <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> does not. Therefore, when you use <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, do not explicitly close the thread handle by calling the Win32 [CloseHandle](http://msdn.microsoft.com/library/windows/desktop/ms724211.aspx) API. This behavior differs from the Win32 [ExitThread](http://msdn.microsoft.com/library/windows/desktop/ms682659.aspx) API.  
  
> [!NOTE]
>  For an executable file linked with Libcmt.lib, do not call the Win32 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> API so that you don't prevent the run-time system from reclaiming allocated resources. <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> reclaim allocated thread resources and then call <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
 The operating system handles the allocation of the stack when either <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> is called; you don't have to pass the address of the thread stack to either of these functions. In addition, the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> argument can be 0, in which case the operating system uses the same value as the stack that's specified for the main thread.  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> is a parameter to be passed to the newly created thread. Typically, it is the address of a data item, such as a character string. <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> can be NULL if it is not needed, but <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> must be given some value to pass to the new thread. All threads are terminated if any thread calls <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.  
  
 The locale of the new thread is inherited from its parent thread. If per-thread locale is enabled by a call to [_configthreadlocale](../vs140/_configthreadlocale.md) (either globally or for new threads only), the thread can change its locale independently from its parent by calling <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>. For more information, see [Locale](../vs140/locale.md).  
  
 For mixed and pure code, <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> each have two overloads—one takes a native calling-convention function pointer, the other takes a <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> function pointer. The first overload is not application domain-safe and never will be. If you are writing mixed or pure code you must ensure that the new thread enters the correct application domain before it accesses managed resources. You can do this, for example, by using [call_in_domain](../vs140/call_in_appdomain-function.md). The second overload is application domain-safe; the newly created thread will always end up in the application domain of the caller of <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>|\<process.h>|  
|<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>|\<process.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 Multithreaded versions of the [C run-time libraries](../vs140/crt-library-features.md) only.  
  
 To use <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>, the application must link with one of the multithreaded C run-time libraries.  
  
## Example  
 The following example uses <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Press any key to end the sample application.  
  
## Example  
 The following sample code demonstrates how you can use the thread handle that's returned by <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> with the synchronization API [WaitForSingleObject](http://msdn.microsoft.com/library/windows/desktop/ms687032.aspx). The main thread waits for the second thread to terminate before it continues. When the second thread calls <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>, it causes its thread object to go to the signaled state. This allows the primary thread to continue running. This cannot be done with <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>, because <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>, which destroys the thread object before it can be set to the signaled state.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Creating second thread...**  
**In second thread...**  
**Counter should be 1000000; it is-> 1000000**   
## .NET Framework Equivalent  
 [System::Threading::Thread::Start](https://msdn.microsoft.com/en-us/library/system.threading.thread.start.aspx)  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [_endthread, _endthreadex](../vs140/_endthread--_endthreadex.md)   
 [abort](../vs140/abort.md)   
 [exit, _Exit, _exit](../vs140/exit--_exit--_exit.md)   
 [GetExitCodeThread](http://msdn.microsoft.com/library/windows/desktop/ms683190)