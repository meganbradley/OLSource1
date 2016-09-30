---
title: "_recalloc"
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
  - "_recalloc"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "api-ms-win-crt-heap-l1-1-0.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_recalloc"
  - "recalloc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_recalloc function"
  - "recalloc function"
ms.assetid: 1db8305a-3f03-418c-8844-bf9149f63046
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _recalloc
A combination of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Reallocates an array in memory and initializes its elements to 0.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to previously allocated memory block.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Number of elements.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Length in bytes of each element.  
  
## Return Value  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> pointer to the reallocated (and possibly moved) memory block.  
  
 If there is not enough available memory to expand the block to the given size, the original block is left unchanged, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is returned.  
  
 If the requested size is zero, then the block pointed to by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is freed; the return value is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is left pointing at a freed block.  
  
 The return value points to a storage space that is guaranteed to be suitably aligned for storage of any type of object. To get a pointer to a type other than <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, use a type cast on the return value.  
  
## Remarks  
 The _<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function changes the size of an allocated memory block. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> argument points to the beginning of the memory block. If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, \_<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> behaves the same way as [calloc](../vs140/calloc.md) and allocates a new block of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> * <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> bytes. Each element is initialized to 0. If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, it should be a pointer returned by a previous call to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, [malloc](../vs140/malloc.md), or [realloc](../vs140/realloc.md).  
  
 Because the new block can be in a new memory location, the pointer returned by _<CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is not guaranteed to be the pointer passed through the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> argument.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> sets <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> if the memory allocation fails or if the amount of memory requested exceeds <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. For information on this and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> in order to use the C++ [_set_new_mode](../vs140/_set_new_mode.md) function to set the new handler mode. The new handler mode indicates whether, on failure, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is to call the new handler routine as set by [_set_new_handler](../vs140/_set_new_handler.md). By default, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> does not call the new handler routine on failure to allocate memory. You can override this default behavior so that, when _<CodeContentPlaceHolder>34\</CodeContentPlaceHolder> fails to allocate memory, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> calls the new handler routine in the same way that the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> operator does when it fails for the same reason. To override the default, call  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 early in the program, or link with NEWMODE.OBJ.  
  
 When the application is linked with a debug version of the C run-time libraries, _<CodeContentPlaceHolder>37\</CodeContentPlaceHolder> resolves to [_recalloc_dbg](../vs140/_recalloc_dbg.md). For more information about how the heap is managed during the debugging process, see [The CRT Debug Heap](../vs140/crt-debug-heap-details.md).  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is marked <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, meaning that the function is guaranteed not to modify global variables, and that the pointer returned is not aliased. For more information, see [noalias](../vs140/noalias.md) and [restrict](../vs140/restrict.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|\<stdlib.h> and \<malloc.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)   
 [_recalloc_dbg](../vs140/_recalloc_dbg.md)   
 [_aligned_recalloc](../vs140/_aligned_recalloc.md)   
 [_aligned_offset_recalloc](../vs140/_aligned_offset_recalloc.md)   
 [free](../vs140/free.md)   
 [Link options](../vs140/link-options.md)