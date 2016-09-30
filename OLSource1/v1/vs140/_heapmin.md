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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 If successful, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> returns 0; otherwise, the function returns –1 and sets <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 For more information about this and other return codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function minimizes the heap by releasing unused heap memory to the operating system. If the operating system does not support <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>(for example, Windows 98), the function returns –1 and sets <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|\<malloc.h>|\<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)   
 [free](../vs140/free.md)   
 [_heapadd](../vs140/_heapadd.md)   
 [_heapchk](../vs140/_heapchk.md)   
 [_heapset](../vs140/_heapset.md)   
 [_heapwalk](../vs140/_heapwalk.md)   
 [malloc](../vs140/malloc.md)