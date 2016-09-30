---
title: "realloc"
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
  - "realloc"
apilocation: 
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_brealloc"
  - "_nrealloc"
  - "realloc"
  - "_frealloc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_brealloc function"
  - "realloc function"
  - "nrealloc function"
  - "frealloc function"
  - "_nrealloc function"
  - "memory blocks, reallocating"
  - "memory, reallocating"
  - "_frealloc function"
  - "reallocate memory blocks"
ms.assetid: 2b2239de-810b-4b11-9438-32ab0a244185
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# realloc
Reallocate memory blocks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to previously allocated memory block.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 New size in bytes.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> pointer to the reallocated (and possibly moved) memory block.  
  
 If there is not enough available memory to expand the block to the given size, the original block is left unchanged, and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is returned.  
  
 If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is zero, then the block pointed to by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is freed; the return value is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is left pointing at a freed block.  
  
 The return value points to a storage space that is guaranteed to be suitably aligned for storage of any type of object. To get a pointer to a type other than <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, use a type cast on the return value.  
  
## Remarks  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function changes the size of an allocated memory block. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> argument points to the beginning of the memory block. If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> behaves the same way as <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and allocates a new block of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> bytes. If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, it should be a pointer returned by a previous call to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> argument gives the new size of the block, in bytes. The contents of the block are unchanged up to the shorter of the new and old sizes, although the new block can be in a different location. Because the new block can be in a new memory location, the pointer returned by <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is not guaranteed to be the pointer passed through the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> argument. <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> does not zero newly allocated memory in the case of buffer growth.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> sets <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> if the memory allocation fails or if the amount of memory requested exceeds <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. For information on this and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>in order to use the C++ [_set_new_mode](../vs140/_set_new_mode.md) function to set the new handler mode. The new handler mode indicates whether, on failure, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is to call the new handler routine as set by [_set_new_handler](../vs140/_set_new_handler.md). By default, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> does not call the new handler routine on failure to allocate memory. You can override this default behavior so that, when <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> fails to allocate memory, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> calls the new handler routine in the same way that the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> operator does when it fails for the same reason. To override the default, call  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 early in ones program, or link with NEWMODE.OBJ (see [Link Options](../vs140/link-options.md)).  
  
 When the application is linked with a debug version of the C run-time libraries, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> resolves to [_realloc_dbg](../vs140/_realloc_dbg.md). For more information about how the heap is managed during the debugging process, see [The CRT Debug Heap](../vs140/crt-debug-heap-details.md).  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is marked <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, meaning that the function is guaranteed not to modify global variables, and that the pointer returned is not aliased. For more information, see [noalias](../vs140/noalias.md) and [restrict](../vs140/restrict.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|\<stdlib.h> and \<malloc.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Size of block after malloc of 1000 longs: 4000**  
**Size of block after realloc of 1000 more longs: 8000**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)   
 [calloc](../vs140/calloc.md)   
 [free](../vs140/free.md)   
 [malloc](../vs140/malloc.md)