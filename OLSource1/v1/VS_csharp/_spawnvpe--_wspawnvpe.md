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
  
```  
intptr_t _spawnvpe(  
   int mode,  
   const char *cmdname,  
   const char *const *argv,  
   const char *const *envp   
);  
intptr_t _wspawnvpe(  
   int mode,  
   const wchar_t *cmdname,  
   const wchar_t *const *argv,  
   const wchar_t *const *envp   
);  
```  
  
#### Parameters  
 `mode`  
 Execution mode for calling process  
  
 `cmdname`  
 Path of file to be executed  
  
 `argv`  
 Array of pointers to arguments. The argument `argv`[0] is usually a pointer to a path in real mode or to the program name in protected mode, and `argv`[1] through `argv`[`n`] are pointers to the character strings forming the new argument list. The argument `argv`[`n` +1] must be a `NULL` pointer to mark the end of the argument list.  
  
 `envp`  
 Array of pointers to environment settings  
  
## Return Value  
 The return value from a synchronous `_spawnvpe` or `_wspawnvpe` (`_P_WAIT` specified for `mode`) is the exit status of the new process. The return value from an asynchronous `_spawnvpe` or `_wspawnvpe` (`_P_NOWAIT` or `_P_NOWAITO` specified for `mode`) is the process handle. The exit status is 0 if the process terminated normally. You can set the exit status to a nonzero value if the spawned process specifically calls the `exit` routine with a nonzero argument. If the new process did not explicitly set a positive exit status, a positive exit status indicates an abnormal exit with an abort or an interrupt. A return value of –1 indicates an error (the new process is not started). In this case, `errno` is set to one of the following values:  
  
 `E2BIG`  
 Argument list exceeds 1024 bytes  
  
 `EINVAL`  
 `mode` argument is invalid  
  
 `ENOENT`  
 File or path is not found  
  
 `ENOEXEC`  
 Specified file is not executable or has invalid executable-file format  
  
 `ENOMEM`  
 Not enough memory is available to execute new process  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../VS_csharp/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on these, and other, return codes.  
  
## Remarks  
 Each of these functions creates and executes a new process, passing an array of pointers to command-line arguments and an array of pointers to environment settings. These functions use the `PATH` environment variable to find the file to execute.  
  
 These functions validate their parameters. If either `cmdname` or `argv` is a null pointer, or if `argv` points to null pointer, or `argv[0]` is an empty string, the invalid parameter handler is invoked, as described in [Parameter Validation](../VS_csharp/parameter-validation.md) . If execution is allowed to continue, these functions set `errno` to `EINVAL`, and return -1. No new process is spawned.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_spawnvpe`|<stdio.h> or <process.h>|  
|`_wspawnvpe`|<stdio.h> or <wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../VS_csharp/compatibility.md).  
  
## Example  
 See the example in [_spawn, _wspawn Functions](../VS_csharp/_spawn--_wspawn-functions.md).  
  
## .NET Framework Equivalent  
  
-   [System::Diagnostics::Process Class](https://msdn.microsoft.com/en-us/library/system.diagnostics.process.aspx)  
  
-   [System::Diagnostics::ProcessStartInfo Class](https://msdn.microsoft.com/en-us/library/system.diagnostics.processstartinfo.aspx)  
  
## See Also  
 [abort](../VS_csharp/abort.md)   
 [atexit](../VS_csharp/atexit.md)   
 [_exec, _wexec Functions](../VS_csharp/_exec--_wexec-functions.md)   
 [exit, _Exit, _exit](../VS_csharp/exit--_exit--_exit.md)   
 [_flushall](../VS_csharp/_flushall.md)   
 [_getmbcp](../VS_csharp/_getmbcp.md)   
 [_onexit, _onexit_m](../VS_csharp/_onexit--_onexit_m.md)   
 [_setmbcp](../VS_csharp/_setmbcp.md)   
 [system, _wsystem](../VS_csharp/system--_wsystem.md)