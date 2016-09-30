---
title: "_cwait"
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
  - "_cwait"
apilocation: 
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_cwait"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "cwait function"
  - "_cwait function"
ms.assetid: d9b596b5-45f4-4e03-9896-3f383cb922b8
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _cwait
Waits until another process terminates.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a buffer where the result code of the specified process will be stored, or NULL.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The handle to the process to wait on (that is, the process that has to terminate before <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> can return).  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 NULL: Ignored by Windows operating system applications; for other applications: action code to perform on <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Return Value  
 When the specified process has successfully completed, returns the handle of the specified process and sets <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to the result code that's returned by the specified process. Otherwise, returns –1 and sets <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> as follows.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|No specified process exists, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is invalid, or the call to the [GetExitCodeProcess](http://msdn.microsoft.com/library/windows/desktop/ms683189.aspx) or [WaitForSingleObject](http://msdn.microsoft.com/library/windows/desktop/ms687032.aspx) API failed.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is invalid.|  
  
 For more information about these and other return codes, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function waits for the termination of the process ID of the specified process that's provided by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. The value of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> that's passed to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> should be the value that's returned by the call to the [_spawn](../vs140/_spawn--_wspawn-functions.md) function that created the specified process. If the process ID terminates before <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is called, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> returns immediately. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> can be used by any process to wait for any other known process for which a valid handle (<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>) exists.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> points to a buffer where the return code of the specified process will be stored. The value of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> indicates whether the specified process terminated normally by calling the Windows [ExitProcess](http://msdn.microsoft.com/library/windows/desktop/ms682658.aspx) API. <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is called internally if the specified process calls <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, returns from <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, or reaches the end of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. For more information about the value that's passed back through <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, see [GetExitCodeProcess](http://msdn.microsoft.com/library/windows/desktop/ms683189.aspx). If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is called by using a NULL value for <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, the return code of the specified process is not stored.  
  
 The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> parameter is ignored by the Windows operating system because parent-child relationships are not implemented in these environments.  
  
 Unless <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is -1 or -2 (handles to the current process or thread), the handle will be closed. Therefore, in this situation, do not use the returned handle.  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<process.h>|\<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Hi, Dad. It's Ann.**  
**Come here, Ann.**  
**Thank you, Ann.**  
**Hi, Dad. It's Beth.**  
**Hi, Dad. It's Carl.**  
**Hi, Dad. It's Dave.**   
## .NET Framework Equivalent  
 [System::Diagnostics::Process::WaitForExit](https://msdn.microsoft.com/en-us/library/system.diagnostics.process.waitforexit.aspx)  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [_spawn, _wspawn Functions](../vs140/_spawn--_wspawn-functions.md)