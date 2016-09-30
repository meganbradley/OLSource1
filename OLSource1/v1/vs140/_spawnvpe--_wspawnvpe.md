---
title: "_spawnvpe, _wspawnvpe"
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
  - "_spawnvpe"
  - "_wspawnvpe"
apilocation: 
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_spawnvpe"
  - "wspawnvpe"
  - "spawnvpe"
  - "_wspawnvpe"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_wspawnvpe function"
  - "processes, creating"
  - "_spawnvpe function"
  - "processes, executing new"
  - "wspawnvpe function"
  - "process creation"
  - "spawnvpe function"
ms.assetid: 3db6394e-a955-4837-97a1-fab1db1e6092
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _spawnvpe, _wspawnvpe
Creates and executes a new process.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Execution mode for calling process  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Path of file to be executed  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Array of pointers to arguments. The argument <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[0] is usually a pointer to a path in real mode or to the program name in protected mode, and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>[1] through <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>] are pointers to the character strings forming the new argument list. The argument <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> +1] must be a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> pointer to mark the end of the argument list.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Array of pointers to environment settings  
  
## Return Value  
 The return value from a synchronous <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> specified for <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>) is the exit status of the new process. The return value from an asynchronous <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> specified for <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>) is the process handle. The exit status is 0 if the process terminated normally. You can set the exit status to a nonzero value if the spawned process specifically calls the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> routine with a nonzero argument. If the new process did not explicitly set a positive exit status, a positive exit status indicates an abnormal exit with an abort or an interrupt. A return value of –1 indicates an error (the new process is not started). In this case, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is set to one of the following values:  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Argument list exceeds 1024 bytes  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> argument is invalid  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 File or path is not found  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Specified file is not executable or has invalid executable-file format  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Not enough memory is available to execute new process  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on these, and other, return codes.  
  
## Remarks  
 Each of these functions creates and executes a new process, passing an array of pointers to command-line arguments and an array of pointers to environment settings. These functions use the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> environment variable to find the file to execute.  
  
 These functions validate their parameters. If either <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is a null pointer, or if <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> points to null pointer, or <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is an empty string, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md) . If execution is allowed to continue, these functions set <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, and return -1. No new process is spawned.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|\<stdio.h> or \<process.h>|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
 See the example in [_spawn, _wspawn Functions](../vs140/_spawn--_wspawn-functions.md).  
  
## .NET Framework Equivalent  
  
-   [System::Diagnostics::Process Class](https://msdn.microsoft.com/en-us/library/system.diagnostics.process.aspx)  
  
-   [System::Diagnostics::ProcessStartInfo Class](https://msdn.microsoft.com/en-us/library/system.diagnostics.processstartinfo.aspx)  
  
## See Also  
 [abort](../vs140/abort.md)   
 [atexit](../vs140/atexit.md)   
 [_exec, _wexec Functions](../vs140/_exec--_wexec-functions.md)   
 [exit, _Exit, _exit](../vs140/exit--_exit--_exit.md)   
 [_flushall](../vs140/_flushall.md)   
 [_getmbcp](../vs140/_getmbcp.md)   
 [_onexit, _onexit_m](../vs140/_onexit--_onexit_m.md)   
 [_setmbcp](../vs140/_setmbcp.md)   
 [system, _wsystem](../vs140/system--_wsystem.md)