---
title: "calloc"
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
  - "calloc"
apilocation: 
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "calloc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "memory allocation, arrays"
  - "calloc function"
ms.assetid: 17bb79a1-98cf-4096-90cb-1f9365cd6829
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# calloc
Allocates an array in memory with elements initialized to 0.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Number of elements.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Length in bytes of each element.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns a pointer to the allocated space. The storage space pointed to by the return value is guaranteed to be suitably aligned for storage of any type of object. To get a pointer to a type other than <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, use a type cast on the return value.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function allocates storage space for an array of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> elements, each of length <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> bytes. Each element is initialized to 0.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> sets <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if a memory allocation fails or if the amount of memory requested exceeds <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. For information on this and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to use the C++ [_set_new_mode](../vs140/_set_new_mode.md) function to set the new handler mode. The new handler mode indicates whether, on failure, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is to call the new handler routine as set by [_set_new_handler](../vs140/_set_new_handler.md). By default, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> does not call the new handler routine on failure to allocate memory. You can override this default behavior so that, when <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> fails to allocate memory, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> calls the new handler routine in the same way that the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> operator does when it fails for the same reason. To override the default, call  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 early in your program, or link with NEWMODE.OBJ (see [Link Options](../vs140/link-options.md)).  
  
 When the application is linked with a debug version of the C run-time libraries, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> resolves to [_calloc_dbg](../vs140/_calloc_dbg.md). For more information about how the heap is managed during the debugging process, see [The CRT Debug Heap](../vs140/crt-debug-heap-details.md).  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is marked <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, meaning that the function is guaranteed not to modify global variables, and that the pointer returned is not aliased. For more information, see [noalias](../vs140/noalias.md) and [restrict](../vs140/restrict.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|\<stdlib.h> and \<malloc.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Allocated 40 long integers**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)   
 [free](../vs140/free.md)   
 [malloc](../vs140/malloc.md)   
 [realloc](../vs140/realloc.md)