---
title: "_spawnl, _wspawnl"
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
  - "_wspawnl"
  - "_spawnl"
apilocation: 
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "spawnl"
  - "wspawnl"
  - "_wspawnl"
  - "_spawnl"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "spawnl function"
  - "processes, creating"
  - "_spawnl function"
  - "processes, executing new"
  - "_wspawnl function"
  - "wspawnl function"
  - "process creation"
ms.assetid: dd4584c9-7173-4fc5-b93a-6e7d3c2316d7
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _spawnl, _wspawnl
Creates and executes a new process.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Execution mode for the calling process.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Path of the file to be executed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 List of pointers to arguments. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> argument is usually a pointer to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The arguments <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> through <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> are pointers to the character strings forming the new argument list. Following <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, there must be a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> pointer to mark the end of the argument list.  
  
## Return Value  
 The return value from a synchronous <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> specified for <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>) is the exit status of the new process. The return value from an asynchronous <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> specified for <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>) is the process handle. The exit status is 0 if the process terminated normally. You can set the exit status to a nonzero value if the spawned process specifically calls the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> routine with a nonzero argument. If the new process did not explicitly set a positive exit status, a positive exit status indicates an abnormal exit with an abort or an interrupt. A return value of –1 indicates an error (the new process is not started). In this case, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is set to one of the following values.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Argument list exceeds 1024 bytes.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> argument is invalid.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 File or path is not found.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Specified file is not executable or has invalid executable-file format.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Not enough memory is available to execute the new process.  
  
 For more information about these and other return codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 These functions validate their parameters. If either <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is an empty string or a null pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, and return -1. No new process is spawned.  
  
## Remarks  
 Each of these functions creates and executes a new process, passing each command-line argument as a separate parameter.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|\<process.h>|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
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