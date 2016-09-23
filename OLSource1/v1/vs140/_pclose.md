---
title: "_pclose"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
apiname: 
  - _pclose
apilocation: 
  - msvcr80.dll
  - msvcrt.dll
  - msvcr100.dll
  - msvcr90.dll
  - msvcr110_clr0400.dll
  - msvcr110.dll
  - msvcr120.dll
apitype: DLLExport
f1_keywords: 
  - _pclose
  - pclose
dev_langs: 
  - C++
  - C
helpviewer_keywords: 
  - _pclose function
  - pclose function
  - pipes, closing
ms.assetid: e2e31a9e-ba3a-4124-bcbb-c4040110b3d3
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# _pclose
Waits for a new command processor and closes the stream on the associated pipe.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
```  
  
      int _pclose(  
FILE *stream   
);  
```  
  
#### Parameters  
 `stream`  
 Return value from the previous call to `_popen`.  
  
## Return Value  
 Returns the exit status of the terminating command processor, or –1 if an error occurs. The format of the return value is the same as that for `_cwait`, except the low-order and high-order bytes are swapped. If stream is **NULL**, `_pclose` sets `errno` to `EINVAL` and returns -1.  
  
 For information about these and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The `_pclose` function looks up the process ID of the command processor (Cmd.exe) started by the associated `_popen` call, executes a [_cwait](../vs140/_cwait.md) call on the new command processor, and closes the stream on the associated pipe.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_pclose`|<stdio.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [_pipe](../vs140/_pipe.md)   
 [_popen, _wpopen](../vs140/_popen--_wpopen.md)