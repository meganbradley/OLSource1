---
title: "free"
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
  - "free"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "free"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "memory blocks, deallocating"
  - "free function"
ms.assetid: 74ded9cf-1863-432e-9306-327a42080bb8
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# free
Deallocates or frees a memory block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Previously allocated memory block to be freed.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function deallocates a memory block (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) that was previously allocated by a call to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The number of freed bytes is equivalent to the number of bytes requested when the block was allocated (or reallocated, in the case of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>). If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the pointer is ignored and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> immediately returns. Attempting to free an invalid pointer (a pointer to a memory block that was not allocated by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>) may affect subsequent allocation requests and cause errors.  
  
 If an error occurs in freeing the memory, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is set with information from the operating system on the nature of the failure. For more information, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 After a memory block has been freed, [_heapmin](../vs140/_heapmin.md) minimizes the amount of free memory on the heap by coalescing the unused regions and releasing them back to the operating system. Freed memory that is not released to the operating system is restored to the free pool and is available for allocation again.  
  
 When the application is linked with a debug version of the C run-time libraries, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> resolves to [_free_dbg](../vs140/_free_dbg.md). For more information about how the heap is managed during the debugging process, see [The CRT Debug Heap](../vs140/crt-debug-heap-details.md).  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is marked <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, meaning that the function is guaranteed not to modify global variables. For more information, see [noalias](../vs140/noalias.md).  
  
 To free memory allocated with [_alloca_s](../vs140/_malloca.md), use [_freea_s](../vs140/_freea.md).  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|\<stdlib.h> and \<malloc.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example for [malloc](../vs140/malloc.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)   
 [_alloca](../vs140/_alloca.md)   
 [calloc](../vs140/calloc.md)   
 [malloc](../vs140/malloc.md)   
 [realloc](../vs140/realloc.md)   
 [_free_dbg](../vs140/_free_dbg.md)   
 [_heapmin](../vs140/_heapmin.md)   
 [_freea_s](../vs140/_freea.md)