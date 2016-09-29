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
  
```  
void *_realloc_dbg(  
   void *userData,  
   size_t newSize,  
   int blockType,  
   const char *filename,  
   int linenumber   
);  
```  
  
#### Parameters  
 `userData`  
 Pointer to the previously allocated memory block.  
  
 `newSize`  
 Requested size for the reallocated block (bytes).  
  
 `blockType`  
 Requested type for the reallocated block: `_CLIENT_BLOCK` or `_NORMAL_BLOCK`.  
  
 `filename`  
 Pointer to the name of the source file that requested the `realloc` operation or NULL.  
  
 `linenumber`  
 Line number in the source file where the `realloc` operation was requested or NULL.  
  
 The `filename` and `linenumber` parameters are only available when `_realloc_dbg` has been called explicitly or the [_CRTDBG_MAP_ALLOC](../vs140/_crtdbg_map_alloc.md) preprocessor constant has been defined.  
  
## Return Value  
 On successful completion, this function either returns a pointer to the user portion of the reallocated memory block, calls the new handler function, or returns NULL. For a complete description of the return behavior, see the following Remarks section. For more information about how the new handler function is used, see the [realloc](../vs140/realloc.md) function.  
  
## Remarks  
 `_realloc_dbg` is a debug version of the [realloc](../vs140/realloc.md) function. When [_DEBUG](../vs140/_debug.md) is not defined, each call to `_realloc_dbg` is reduced to a call to `realloc`. Both `realloc` and `_realloc_dbg` reallocate a memory block in the base heap, but `_realloc_dbg` accommodates several debugging features: buffers on either side of the user portion of the block to test for leaks, a block type parameter to track specific allocation types, and `filename`/`linenumber` information to determine the origin of allocation requests.  
  
 `_realloc_dbg` reallocates the specified memory block with slightly more space than the requested `newSize`. `newSize` might be greater or less than the size of the originally allocated memory block. The additional space is used by the debug heap manager to link the debug memory blocks and to provide the application with debug header information and overwrite buffers. The reallocation might result in moving the original memory block to a different location in the heap, as well as changing the size of the memory block. If the memory block is moved, the contents of the original block are overwritten.  
  
 `_realloc_dbg` sets `errno` to `ENOMEM` if a memory allocation fails or if the amount of memory needed (including the overhead mentioned previously) exceeds `_HEAP_MAXREQ`. For information about this and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 For information about how memory blocks are allocated, initialized, and managed in the debug version of the base heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md). For information about the allocation block types and how they are used, see [Types of blocks on the debug heap](../vs140/crt-debug-heap-details.md#BKMK_Types_of_blocks_on_the_debug_heap). For information about the differences between calling a standard heap function and its debug version in a debug build of an application, see [Debug Versions of Heap Allocation Functions](../vs140/debug-versions-of-heap-allocation-functions.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_realloc_dbg`|<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## Example  
 See the example in the [_msize_dbg](../vs140/_msize_dbg.md) topic.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)   
 [_malloc_dbg](../vs140/_malloc_dbg.md)