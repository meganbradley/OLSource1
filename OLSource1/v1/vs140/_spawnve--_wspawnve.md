---
title: "_spawnve, _wspawnve"
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
  - "_spawnve"
  - "_wspawnve"
apilocation: 
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wspawnve"
  - "_spawnve"
  - "_wspawnve"
  - "spawnve"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_spawnve function"
  - "spawnve function"
  - "wspawnve function"
  - "processes, creating"
  - "_wspawnve function"
  - "processes, executing new"
  - "process creation"
ms.assetid: 26d1713d-b551-4f21-a07b-e9891a2ae6cf
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _spawnve, _wspawnve
Creates and executes a new process.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Execution mode for a calling process.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Path of the file to be executed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Array of pointers to arguments. The argument <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[0] is usually a pointer to a path in real mode or to the program name in protected mode, and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>[1] through <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>] are pointers to the character strings forming the new argument list. The argument <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> +1] must be a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> pointer to mark the end of the argument list.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Array of pointers to environment settings.  
  
## Return Value  
 The return value from a synchronous <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> specified for <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>) is the exit status of the new process. The return value from an asynchronous <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> specified for <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>) is the process handle. The exit status is 0 if the process terminated normally. You can set the exit status to a nonzero value if the spawned process specifically calls the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> routine with a nonzero argument. If the new process did not explicitly set a positive exit status, a positive exit status indicates an abnormal exit with an abort or an interrupt. A return value of –1 indicates an error (the new process is not started). In this case, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is set to one of the following values.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Argument list exceeds 1024 bytes.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> argument is invalid.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 File or path is not found.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Specified file is not executable or has invalid executable-file format.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Not enough memory is available to execute the new process.  
  
 For more information about these and other return codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 Each of these functions creates and executes a new process, passing an array of pointers to command-line arguments and an array of pointers to environment settings.  
  
 These functions validate their parameters. If either <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is a null pointer, or if <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> points to null pointer, or <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is an empty string, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, and return -1. No new process is spawned.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|\<stdio.h> or \<process.h>|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
 See the example in [_spawn, _wspawn Functions](../vs140/_spawn--_wspawn-functions.md).  
  
## .NET Framework Equivalent  
  
-   [System::Diagnostics::Process Class](https://msdn.microsoft.com/en-us/library/system.diagnostics.process.aspx)  
  
-   [System::Diagnostics::ProcessStartInfo Class](https://msdn.microsoft.com/en-us/library/system.diagnostics.processstartinfo.aspx)  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [_spawn, _wspawn Functions](../vs140/_spawn--_wspawn-functions.md)   
 [abort](../vs140/abort.md)   
 [atexit](../vs140/atexit.md)   
 [_exec, _wexec Functions](../vs140/_exec--_wexec-functions.md)   
 [exit, _Exit, _exit](../vs140/exit--_exit--_exit.md)   
 [_flushall](../vs140/_flushall.md)   
 [_getmbcp](../vs140/_getmbcp.md)   
 [_onexit, _onexit_m](../vs140/_onexit--_onexit_m.md)   
 [_setmbcp](../vs140/_setmbcp.md)   
 [system, _wsystem](../vs140/system--_wsystem.md)