---
title: "system, _wsystem"
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
  - "system"
  - "_wsystem"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tsystem"
  - "_wsystem"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_wsystem function"
  - "wsystem function"
  - "tsystem function"
  - "_tsystem function"
  - "system function"
  - "commands, executing"
  - "command interpreter"
ms.assetid: 7d3df2b6-f742-49ce-bf52-012b0aee3df5
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# system, _wsystem
Executes a command.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The command to be executed.  
  
## Return Value  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and the command interpreter is found, returns a nonzero value. If the command interpreter is not found, returns 0 and sets <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> returns the value that is returned by the command interpreter. It returns the value 0 only if the command interpreter returns the value 0. A return value of – 1 indicates an error, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is set to one of the following values:  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The argument list (which is system-dependent) is too big.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The command interpreter cannot be found.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The command-interpreter file cannot be executed because the format is not valid.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Not enough memory is available to execute command; or available memory has been corrupted; or a non-valid block exists, which indicates that the process that's making the call was not allocated correctly.  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information about these return codes.  
  
## Remarks  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function passes <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to the command interpreter, which executes the string as an operating-system command. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> uses the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> environment variables to locate the command-interpreter file CMD.exe. If <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, the function just checks whether the command interpreter exists.  
  
 You must explicitly flush—by using <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>—or close any stream before you call <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is a wide-character string. These functions behave identically otherwise.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|\<process.h> or \<stdlib.h>|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|\<process.h> or \<stdlib.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
 This example uses <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> to TYPE a text file.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input: crt_system.txt  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
  
-   [System::Diagnostics::ProcessStartInfo Class](https://msdn.microsoft.com/en-us/library/system.diagnostics.processstartinfo.aspx)  
  
-   [System::Diagnostics::Process Class](https://msdn.microsoft.com/en-us/library/system.diagnostics.process.aspx)  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [_exec, _wexec Functions](../vs140/_exec--_wexec-functions.md)   
 [exit, _Exit, _exit](../vs140/exit--_exit--_exit.md)   
 [_flushall](../vs140/_flushall.md)   
 [_spawn, _wspawn Functions](../vs140/_spawn--_wspawn-functions.md)