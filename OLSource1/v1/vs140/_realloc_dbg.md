---
title: "_realloc_dbg"
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
  - "_realloc_dbg"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_realloc_dbg"
  - "realloc_dbg"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "reallocating memory blocks"
  - "realloc_dbg function"
  - "memory blocks, reallocating"
  - "memory, reallocating"
  - "_realloc_dbg function"
ms.assetid: 7c3cb780-51ed-4d9c-9929-cdde606d846a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _realloc_dbg
Reallocates a specified block of memory in the heap by moving and/or resizing the block (debug version only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the previously allocated memory block.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Requested size for the reallocated block (bytes).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Requested type for the reallocated block: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to the name of the source file that requested the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> operation or NULL.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Line number in the source file where the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> operation was requested or NULL.  
  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameters are only available when <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> has been called explicitly or the [_CRTDBG_MAP_ALLOC](../vs140/_crtdbg_map_alloc.md) preprocessor constant has been defined.  
  
## Return Value  
 On successful completion, this function either returns a pointer to the user portion of the reallocated memory block, calls the new handler function, or returns NULL. For a complete description of the return behavior, see the following Remarks section. For more information about how the new handler function is used, see the [realloc](../vs140/realloc.md) function.  
  
## Remarks  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a debug version of the [realloc](../vs140/realloc.md) function. When [_DEBUG](../vs140/_debug.md) is not defined, each call to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is reduced to a call to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Both <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> reallocate a memory block in the base heap, but <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> accommodates several debugging features: buffers on either side of the user portion of the block to test for leaks, a block type parameter to track specific allocation types, and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>20\</CodeContentPlaceHolder> information to determine the origin of allocation requests.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> reallocates the specified memory block with slightly more space than the requested <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> might be greater or less than the size of the originally allocated memory block. The additional space is used by the debug heap manager to link the debug memory blocks and to provide the application with debug header information and overwrite buffers. The reallocation might result in moving the original memory block to a different location in the heap, as well as changing the size of the memory block. If the memory block is moved, the contents of the original block are overwritten.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> sets <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> if a memory allocation fails or if the amount of memory needed (including the overhead mentioned previously) exceeds <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. For information about this and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 For information about how memory blocks are allocated, initialized, and managed in the debug version of the base heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md). For information about the allocation block types and how they are used, see [Types of blocks on the debug heap](../vs140/crt-debug-heap-details.md#BKMK_Types_of_blocks_on_the_debug_heap). For information about the differences between calling a standard heap function and its debug version in a debug build of an application, see [Debug Versions of Heap Allocation Functions](../vs140/debug-versions-of-heap-allocation-functions.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## Example  
 See the example in the [_msize_dbg](../vs140/_msize_dbg.md) topic.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)   
 [_malloc_dbg](../vs140/_malloc_dbg.md)