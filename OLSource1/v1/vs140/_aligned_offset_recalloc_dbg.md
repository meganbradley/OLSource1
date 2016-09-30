---
title: "_aligned_offset_recalloc_dbg"
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
  - "_aligned_offset_recalloc_dbg"
apilocation: 
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "aligned_offset_recalloc_dbg"
  - "_aligned_offset_recalloc_dbg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "aligned_offset_recalloc_dbg function"
  - "_aligned_offset_recalloc_dbg function"
ms.assetid: 7ab719c3-77e0-4d2e-934f-01529d062fbf
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _aligned_offset_recalloc_dbg
Changes the size of a memory block that was allocated with [_aligned_malloc](../vs140/_aligned_malloc.md) or [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md) and initializes the memory to 0 (debug version only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The current memory block pointer.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Number of elements.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Length in bytes of each element.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The alignment value, which must be an integer power of 2.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The offset into the memory allocation to force the alignment.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to the name of the source file that requested the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> operation or NULL.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Line number in the source file where the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> operation was requested or NULL.  
  
## Return Value  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returns a void pointer to the reallocated (and possibly moved) memory block. The return value is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if the size is zero and the buffer argument is not <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, or if there is not enough available memory to expand the block to the given size. In the first case, the original block is freed. In the second case, the original block is unchanged. The return value points to a storage space that is guaranteed to be suitably aligned for storage of any type of object. To get a pointer to a type other than void, use a type cast on the return value.  
  
## Remarks  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a debug version of the [_aligned_offset_recalloc](../vs140/_aligned_offset_recalloc.md) function. When [_DEBUG](../vs140/_debug.md) is not defined, each call to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is reduced to a call to _<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Both \_<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> reallocate a memory block in the base heap, but <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> accommodates several debugging features: buffers on either side of the user portion of the block to test for leaks, a block type parameter to track specific allocation types, and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>20\</CodeContentPlaceHolder> information to determine the origin of allocation requests.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> reallocates the specified memory block with slightly more space than the requested <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> might be greater or less than the size of the originally allocated memory block. The additional space is used by the debug heap manager to link the debug memory blocks and to provide the application with debug header information and overwrite buffers. The reallocation might result in moving the original memory block to a different location in the heap, as well as changing the size of the memory block. If the memory block is moved, the contents of the original block are overwritten.  
  
 This function sets <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> if the memory allocation failed or if the requested size (<CodeContentPlaceHolder>26\</CodeContentPlaceHolder> * <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>) was greater than <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. For more information about <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md). Also, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> validates its parameters. If <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is not a power of 2 or if <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is greater than or equal to the requested size and nonzero, this function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function returns <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
 For information about how memory blocks are allocated, initialized, and managed in the debug version of the base heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md). For information about the allocation block types and how they are used, see [Types of Blocks on the Debug Heap](../vs140/crt-debug-heap-details.md#BKMK_Types_of_blocks_on_the_debug_heap). For information about the differences between calling a standard heap function and its debug version in a debug build of an application, see [Debug Versions of Heap Allocation Functions](../vs140/debug-versions-of-heap-allocation-functions.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|\<malloc.h>|  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Data Alignment](../vs140/data-alignment.md)