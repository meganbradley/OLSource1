---
title: "_aligned_realloc_dbg"
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
  - "_aligned_realloc_dbg"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "aligned_realloc_dbg"
  - "_aligned_realloc_dbg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_aligned_realloc_dbg function"
  - "aligned_realloc_dbg function"
ms.assetid: 8aede920-991e-44cd-867f-83dc2165db47
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _aligned_realloc_dbg
Changes the size of a memory block that was allocated with [_aligned_malloc](../vs140/_aligned_malloc.md) or [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md) (debug version only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The current memory block pointer.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The size of the requested memory allocation.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The alignment value, which must be an integer power of 2.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to the name of the source file that requested the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> operation or NULL.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Line number in the source file where the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> operation was requested or NULL.  
  
## Return Value  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns a void pointer to the reallocated (and possibly moved) memory block. The return value is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if the size is zero and the buffer argument is not <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, or if there is not enough available memory to expand the block to the given size. In the first case, the original block is freed. In the second, the original block is unchanged. The return value points to a storage space that is guaranteed to be suitably aligned for storage of any type of object. To get a pointer to a type other than void, use a type cast on the return value.  
  
 It is an error to reallocate memory and change the alignment of a block.  
  
## Remarks  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a debug version of the [_aligned_realloc](../vs140/_aligned_realloc.md) function. When [_DEBUG](../vs140/_debug.md) is not defined, each call to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is reduced to a call to _<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Both \_<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> reallocate a memory block in the base heap, but <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> accommodates several debugging features: buffers on either side of the user portion of the block to test for leaks, a block type parameter to track specific allocation types, and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> information to determine the origin of allocation requests.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> reallocates the specified memory block with slightly more space than the requested <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> might be greater or less than the size of the originally allocated memory block. The additional space is used by the debug heap manager to link the debug memory blocks and to provide the application with debug header information and overwrite buffers. The reallocation might result in moving the original memory block to a different location in the heap, as well as changing the size of the memory block. If the memory block is moved, the contents of the original block are overwritten.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> sets <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> if a memory allocation fails or if the amount of memory needed (including the overhead mentioned previously) exceeds <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. For information about this and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 Also, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> validates its parameters. If <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is not a power of 2, this function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function returns <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
 For information about how memory blocks are allocated, initialized, and managed in the debug version of the base heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md). For information about the allocation block types and how they are used, see [Types of Blocks on the Debug Heap](../vs140/crt-debug-heap-details.md#BKMK_Types_of_blocks_on_the_debug_heap). For information about the differences between calling a standard heap function and its debug version in a debug build of an application, see [Debug Versions of Heap Allocation Functions](../vs140/debug-versions-of-heap-allocation-functions.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)