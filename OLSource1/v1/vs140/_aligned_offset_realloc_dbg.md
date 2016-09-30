---
title: "_aligned_offset_realloc_dbg"
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
  - "_aligned_offset_realloc_dbg"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "aligned_offset_realloc_dbg"
  - "_aligned_offset_realloc_dbg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "aligned_offset_realloc_dbg function"
  - "_aligned_offset_realloc_dbg function"
ms.assetid: 64e30a12-887e-453b-aea8-aed793fca9d8
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _aligned_offset_realloc_dbg
Changes the size of a memory block that was allocated with [_aligned_malloc](../vs140/_aligned_malloc.md) or [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md) (debug version only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The current memory block pointer.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The size of the memory allocation.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The alignment value, which must be an integer power of 2.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The offset into the memory allocation to force the alignment.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to the name of the source file that requested the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> operation or NULL.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Line number in the source file where the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> operation was requested or NULL.  
  
## Return Value  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns a void pointer to the reallocated (and possibly moved) memory block. The return value is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if the size is zero and the buffer argument is not <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, or if there is not enough available memory to expand the block to the given size. In the first case, the original block is freed. In the second case, the original block is unchanged. The return value points to a storage space that is guaranteed to be suitably aligned for storage of any type of object. To get a pointer to a type other than void, use a type cast on the return value.  
  
## Remarks  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is a debug version of the [_aligned_offset_realloc](../vs140/_aligned_offset_realloc.md) function. When [_DEBUG](../vs140/_debug.md) is not defined, each call to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is reduced to a call to _<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. Both \_<CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> reallocate a memory block in the base heap, but <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> accommodates several debugging features: buffers on either side of the user portion of the block to test for leaks, a block type parameter to track specific allocation types, and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>19\</CodeContentPlaceHolder> information to determine the origin of allocation requests.  
  
 Like [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md), <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> allows a structure to be aligned at an offset within the structure.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> reallocates the specified memory block with slightly more space than the requested <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> might be greater or less than the size of the originally allocated memory block. The additional space is used by the debug heap manager to link the debug memory blocks and to provide the application with debug header information and overwrite buffers. The reallocation might result in moving the original memory block to a different location in the heap, as well as changing the size of the memory block. If the memory block is moved, the contents of the original block are overwritten.  
  
 This function sets <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> if the memory allocation failed or if the requested size was greater than <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. For more information about <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md). Also, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> validates its parameters. If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is not a power of 2 or if <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is greater than or equal to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and nonzero, this function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function returns <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
 For information about how memory blocks are allocated, initialized, and managed in the debug version of the base heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md). For information about the allocation block types and how they are used, see [Types of Blocks on the Debug Heap](../vs140/crt-debug-heap-details.md#BKMK_Types_of_blocks_on_the_debug_heap). For information about the differences between calling a standard heap function and its debug version in a debug build of an application, see [Debug Versions of Heap Allocation Functions](../vs140/debug-versions-of-heap-allocation-functions.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)