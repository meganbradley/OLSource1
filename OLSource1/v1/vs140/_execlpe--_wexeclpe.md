---
title: "_execlpe, _wexeclpe"
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
  - "_execlpe"
  - "_wexeclpe"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_wexeclpe"
  - "execlpe"
  - "wexeclpe"
  - "_execlpe"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wexeclpe function"
  - "_wexeclpe function"
  - "_execlpe function"
  - "execlpe function"
ms.assetid: 07b861da-3e7e-4f1d-bb80-ad69b55e5162
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _execlpe, _wexeclpe
Loads and executes new child processes.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Path of the file to execute.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 List of pointers to parameters.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Array of pointers to environment settings.  
  
## Return Value  
 If successful, these functions do not return to the calling process. A return value of –1 indicates an error, in which case the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> global variable is set.  
  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> value|Description|  
|-------------------|-----------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The space required for the arguments and environment settings exceeds 32 KB.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The specified file has a locking or sharing violation.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Invalid parameter.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Too many files open (the specified file must be opened to determine whether it is executable).|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The file or path not found.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|The specified file is not executable or has an invalid executable-file format.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Not enough memory is available to execute the new process; the available memory has been corrupted; or an invalid block exists, indicating that the calling process was not allocated properly.|  
  
 For more information about these and other return codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 Each of these functions loads and executes a new process, passing each command-line argument as a separate parameter and also passing an array of pointers to environment settings. These functions use the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> environment variable to find the file to execute.  
  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> functions validate their parameters. If either <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is a null pointers or empty string, these functions invoke the invalid parameter handler as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and return -1. No new process is launched.  
  
## Requirements  
  
|Function|Required header|Optional header|  
|--------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|\<process.h>|\<errno.h>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|\<process.h> or \<wchar.h>|\<errno.h>|  
  
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