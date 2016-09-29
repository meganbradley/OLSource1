---
title: "_heapmin"
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
  - "_heapmin"
apilocation: 
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_heapmin"
  - "heapmin"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "heap memory"
  - "minimizing heaps"
  - "memory, releasing"
  - "heaps, releasing unused memory"
  - "_heapmin function"
  - "heapmin function"
ms.assetid: c0bccdf6-2d14-4d7b-a7ff-d6a17bdb410f
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _heapmin
Releases unused heap memory to the operating system.  
  
## Syntax  
  
```  
int _heapmin( void );  
```  
  
## Return Value  
 If successful, `_heapmin` returns 0; otherwise, the function returns –1 and sets `errno` to `ENOSYS`.  
  
 For more information about this and other return codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../VS_csharp/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The `_heapmin` function minimizes the heap by releasing unused heap memory to the operating system. If the operating system does not support `_heapmin`(for example, Windows 98), the function returns –1 and sets `errno` to `ENOSYS`.  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|`_heapmin`|<malloc.h>|<errno.h>|  
  
 For more compatibility information, see [Compatibility](../VS_csharp/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../VS_csharp/memory-allocation.md)   
 [free](../VS_csharp/free.md)   
 [_heapadd](../VS_csharp/_heapadd.md)   
 [_heapchk](../VS_csharp/_heapchk.md)   
 [_heapset](../VS_csharp/_heapset.md)   
 [_heapwalk](../VS_csharp/_heapwalk.md)   
 [malloc](../VS_csharp/malloc.md)