---
title: "_freea"
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
  - "_freea"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "freea"
  - "_freea"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_freea function"
  - "freea function"
  - "memory deallocation"
ms.assetid: dcd30584-dd9d-443b-8c4c-13237a1cecac
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _freea
Deallocates or frees a memory block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Previously allocated memory block to be freed.  
  
## Return Value  
 None.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function deallocates a memory block (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) that was previously allocated by a call to [_malloca](../vs140/_malloca.md). <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> checks to see if the memory was allocated on the heap or the stack. If it was allocated on the stack, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> does nothing. If it was allocated on the heap, the number of freed bytes is equivalent to the number of bytes requested when the block was allocated. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the pointer is ignored and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> immediately returns. Attempting to free an invalid pointer (a pointer to a memory block that was not allocated by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) might affect subsequent allocation requests and cause errors.  
  
 _<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> internally if it finds that the memory is allocated on the heap. Whether the memory is on the heap or the stack is determined by a marker placed in memory at the address immediately preceding the allocated memory.  
  
 If an error occurs in freeing the memory, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is set with information from the operating system on the nature of the failure. For more information, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 After a memory block has been freed, [_heapmin](../vs140/_heapmin.md) minimizes the amount of free memory on the heap by coalescing the unused regions and releasing them back to the operating system. Freed memory that is not released to the operating system is restored to the free pool and is available for allocation again.  
  
 A call to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> must accompany all calls to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. It is also an error to call <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> twice on the same memory. When the application is linked with a debug version of the C run-time libraries, particularly with [_malloc_dbg](../vs140/_malloc_dbg.md) features enabled by defining <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, it is easier to find missing or duplicated calls to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. For more information about how the heap is managed during the debugging process, see [The CRT Debug Heap](../vs140/crt-debug-heap-details.md).  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is marked <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, meaning that the function is guaranteed not to modify global variables. For more information, see [noalias](../vs140/noalias.md).  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|\<stdlib.h> and \<malloc.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example for [_malloca](../vs140/_malloca.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)   
 [_malloca](../vs140/_malloca.md)   
 [calloc](../vs140/calloc.md)   
 [malloc](../vs140/malloc.md)   
 [_malloc_dbg](../vs140/_malloc_dbg.md)   
 [realloc](../vs140/realloc.md)   
 [_free_dbg](../vs140/_free_dbg.md)   
 [_heapmin](../vs140/_heapmin.md)