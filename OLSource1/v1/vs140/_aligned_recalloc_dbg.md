---
title: "_aligned_recalloc_dbg"
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
  - "_aligned_recalloc_dbg"
apilocation: 
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_aligned_recalloc_dbg"
  - "aligned_recalloc_dbg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "aligned_recalloc_dbg function"
  - "_aligned_recalloc_dbg function"
ms.assetid: 55c3c27e-561c-4d6b-9bf9-1e34cc556e4b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _aligned_recalloc_dbg
Changes the size of a memory block that was allocated with [_aligned_malloc](../vs140/_aligned_malloc.md) or [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md) and initializes the memory to 0 (debug version only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The current memory block pointer.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of elements.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The size in bytes of each element.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The alignment value, which must be an integer power of 2.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to name of the source file that requested allocation operation or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Line number in the source file where allocation operation was requested or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns a void pointer to the reallocated (and possibly moved) memory block. The return value is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if the size is zero and the buffer argument is not <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, or if there is not enough available memory to expand the block to the given size. In the first case, the original block is freed. In the second case, the original block is unchanged. The return value points to a storage space that is guaranteed to be suitably aligned for storage of any type of object. To get a pointer to a type other than void, use a type cast on the return value.  
  
 It is an error to reallocate memory and change the alignment of a block.  
  
## Remarks  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is a debug version of the [_aligned_recalloc](../vs140/_aligned_recalloc.md) function. When [_DEBUG](../vs140/_debug.md) is not defined, each call to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is reduced to a call to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. Both <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> reallocate a memory block in the base heap, but <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> accommodates several debugging features: buffers on either side of the user portion of the block to test for leaks, a block type parameter to track specific allocation types, and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>19\</CodeContentPlaceHolder> information to determine the origin of allocation requests.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> reallocates the specified memory block with slightly more space than the requested size (<CodeContentPlaceHolder>21\</CodeContentPlaceHolder> * <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>) which might be greater or less than the size of the originally allocated memory block. The additional space is used by the debug heap manager to link the debug memory blocks and to provide the application with debug header information and overwrite buffers. The reallocation might result in moving the original memory block to a different location in the heap, as well as changing the size of the memory block. The user portion of the block is filled with the value 0xCD and the overwrite buffers are filled with 0xFD.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> sets <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> if a memory allocation fails; <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is returned if the amount of memory needed (including the overhead mentioned previously) exceeds <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. For information about this and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 Also, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> validates its parameters. If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is not a power of 2, this function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function returns <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
 For information about how memory blocks are allocated, initialized, and managed in the debug version of the base heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md). For information about the allocation block types and how they are used, see [Types of Blocks on the Debug Heap](../vs140/crt-debug-heap-details.md#BKMK_Types_of_blocks_on_the_debug_heap). For information about the differences between calling a standard heap function and its debug version in a debug build of an application, see [Debug Versions of Heap Allocation Functions](../vs140/debug-versions-of-heap-allocation-functions.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)