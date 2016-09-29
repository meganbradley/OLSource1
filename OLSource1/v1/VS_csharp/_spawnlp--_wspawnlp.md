---
title: "_spawnlp, _wspawnlp"
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
  - "_wspawnlp"
  - "_spawnlp"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_wspawnlp"
  - "wspawnlp"
  - "_spawnlp"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wspawnlp function"
  - "_spawnlp function"
  - "processes, creating"
  - "processes, executing new"
  - "_wspawnlp function"
  - "process creation"
  - "spawnlp function"
ms.assetid: 74fc6e7a-4f24-4103-9387-7177875875e6
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _spawnlp, _wspawnlp
Creates and executes a new process.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
```  
intptr_t _spawnlp(  
   int mode,  
   const char *cmdname,  
   const char *arg0,  
   const char *arg1,  
   ... const char *argn,  
   NULL   
);  
intptr_t _wspawnlp(  
   int mode,  
   const wchar_t *cmdname,  
   const wchar_t *arg0,  
   const wchar_t *arg1,  
   ... const wchar_t *argn,  
   NULL   
);  
```  
  
#### Parameters  
 `mode`  
 Execution mode for the calling process.  
  
 `cmdname`  
 Path of the file to be executed.  
  
 `arg0, arg1, ... argn`  
 List of pointers to arguments. The `arg0` argument is usually a pointer to `cmdname`. The arguments `arg1` through `argn` are pointers to the character strings forming the new argument list. Following `argn`, there must be a `NULL` pointer to mark the end of the argument list.  
  
## Return Value  
 The return value from a synchronous `_spawnlp` or `_wspawnlp` (`_P_WAIT` specified for `mode`) is the exit status of the new process. The return value from an asynchronous `_spawnlp` or `_wspawnlp` (`_P_NOWAIT` or `_P_NOWAITO` specified for `mode`) is the process handle. The exit status is 0 if the process terminated normally. You can set the exit status to a nonzero value if the spawned process specifically calls the `exit` routine with a nonzero argument. If the new process did not explicitly set a positive exit status, a positive exit status indicates an abnormal exit with an abort or an interrupt. A return value of –1 indicates an error (the new process is not started). In this case, `errno` is set to one of the following values.  
  
 `E2BIG`  
 Argument list exceeds 1024 bytes.  
  
 `EINVAL`  
 `mode` argument is invalid.  
  
 `ENOENT`  
 File or path is not found.  
  
 `ENOEXEC`  
 Specified file is not executable or has invalid executable-file format.  
  
 `ENOMEM`  
 Not enough memory is available to execute the new process.  
  
 For more information about these and other return codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../VS_csharp/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 Each of these functions creates and executes a new process, passing each command-line argument as a separate parameter and using the `PATH` environment variable to find the file to execute.  
  
 These functions validate their parameters. If either `cmdname` or `arg0` is an empty string or a null pointer, these functions generate an invalid parameter exception, as described in [Parameter Validation](../VS_csharp/parameter-validation.md). If execution is allowed to continue, these functions set `errno` to `EINVAL`, and return -1. No new process is spawned.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_spawnlp`|<process.h>|  
|`_wspawnlp`|<stdio.h> or <wchar.h>|  
  
 For more compatibility information, see [Compatibility](../VS_csharp/compatibility.md).  
  
## Example  
 See the example in [_spawn, _wspawn Functions](../VS_csharp/_spawn--_wspawn-functions.md).  
  
## .NET Framework Equivalent  
  
-   [System::Diagnostics::Process Class](https://msdn.microsoft.com/en-us/library/system.diagnostics.process.aspx)  
  
-   [System::Diagnostics::ProcessStartInfo Class](https://msdn.microsoft.com/en-us/library/system.diagnostics.processstartinfo.aspx)  
  
## See Also  
 [Process and Environment Control](../VS_csharp/process-and-environment-control.md)   
 [_spawn, _wspawn Functions](../VS_csharp/_spawn--_wspawn-functions.md)   
 [abort](../VS_csharp/abort.md)   
 [atexit](../VS_csharp/atexit.md)   
 [_exec, _wexec Functions](../VS_csharp/_exec--_wexec-functions.md)   
 [exit, _Exit, _exit](../VS_csharp/exit--_exit--_exit.md)   
 [_flushall](../VS_csharp/_flushall.md)   
 [_getmbcp](../VS_csharp/_getmbcp.md)   
 [_onexit, _onexit_m](../VS_csharp/_onexit--_onexit_m.md)   
 [_setmbcp](../VS_csharp/_setmbcp.md)   
 [system, _wsystem](../VS_csharp/system--_wsystem.md)