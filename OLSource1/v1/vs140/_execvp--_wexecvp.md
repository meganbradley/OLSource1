---
title: "_execvp, _wexecvp"
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
  - "_execvp"
  - "_wexecvp"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_execvp"
  - "wexecvp"
  - "_wexecvp"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_execvp function"
  - "_wexecvp function"
  - "wexecvp function"
  - "execvp function"
ms.assetid: a4db15df-b204-4987-be7c-de84c3414380
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _execvp, _wexecvp
Loads and executes new child processes.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Path of the file to execute.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Array of pointers to parameters.  
  
## Return Value  
 If successful, these functions do not return to the calling process. A return value of –1 indicates an error, in which case the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> global variable is set.  
  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> value|Description|  
|-------------------|-----------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The space required for the arguments and environment settings exceeds 32 KB.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The specified file has a locking or sharing violation.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Invalid parameter.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Too many files open (the specified file must be opened to determine whether it is executable).|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|The file or path not found.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|The specified file is not executable or has an invalid executable-file format.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Not enough memory is available to execute the new process; the available memory has been corrupted; or an invalid block exists, indicating that the calling process was not allocated properly.|  
  
 For more information about these and other return codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 Each of these functions loads and executes a new process, passing an array of pointers to command-line arguments and using the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> environment variable to find the file to execute.  
  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> functions validate their parameters. If the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is a null pointer, or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is a null pointer, pointer to an empty array, or if the array contains an empty string as the first argument, these functions invoke the invalid parameter handler as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and return -1. No process is launched.  
  
## Requirements  
  
|Function|Required header|Optional header|  
|--------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|\<process.h>|\<errno.h>|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|\<process.h> or \<wchar.h>|\<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
 See the example in [_exec, _wexec Functions](../vs140/_exec--_wexec-functions.md).  
  
## .NET Framework Equivalent  
  
-   [System::Diagnostics::Process Class](https://msdn.microsoft.com/en-us/library/system.diagnostics.process.aspx)  
  
-   [System::Diagnostics::ProcessStartInfo Class](https://msdn.microsoft.com/en-us/library/system.diagnostics.processstartinfo.aspx)  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [_exec, _wexec Functions](../vs140/_exec--_wexec-functions.md)   
 [abort](../vs140/abort.md)   
 [atexit](../vs140/atexit.md)   
 [exit, _Exit, _exit](../vs140/exit--_exit--_exit.md)   
 [_onexit, _onexit_m](../vs140/_onexit--_onexit_m.md)   
 [_spawn, _wspawn Functions](../vs140/_spawn--_wspawn-functions.md)   
 [system, _wsystem](../vs140/system--_wsystem.md)