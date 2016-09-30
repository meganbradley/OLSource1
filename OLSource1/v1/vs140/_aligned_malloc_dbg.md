---
title: "_aligned_malloc_dbg"
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
  - "_aligned_malloc_dbg"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_aligned_malloc_dbg"
  - "aligned_malloc_dbg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "aligned_malloc_dbg function"
  - "_aligned_malloc_dbg function"
ms.assetid: fb0429c3-685d-4826-9075-2515c5bdc5c6
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _aligned_malloc_dbg
Allocates memory on a specified alignment boundary with additional space for a debugging header and overwrite buffers (debug version only).  
  
## Syntax  
  
```  
void * _aligned_malloc_dbg(  
    size_t size,   
    size_t alignment,  
   const char *filename,  
   int linenumber   
);  
```  
  
#### Parameters  
 [in] `size`  
 Size of the requested memory allocation.  
  
 [in] `alignment`  
 The alignment value, which must be an integer power of 2.  
  
 [in] `filename`  
 Pointer to the name of the source file that requested the allocation operation or NULL.  
  
 [in] `linenumber`  
 Line number in the source file where the allocation operation was requested or NULL.  
  
## Return Value  
 A pointer to the memory block that was allocated or `NULL` if the operation failed.  
  
## Remarks  
 `_aligned_malloc_dbg` is a debug version of the [_aligned_malloc](../vs140/_aligned_malloc.md) function. When [_DEBUG](../vs140/_debug.md) is not defined, each call to `_aligned_malloc_dbg` is reduced to a call to `_aligned_malloc`. Both `_aligned_malloc` and `_aligned_malloc_dbg` allocate a block of memory in the base heap, but `_aligned_malloc_dbg` offers several debugging features: buffers on either side of the user portion of the block to test for leaks, and `filename`/`linenumber` information to determine the origin of allocation requests.  
  
 `_aligned_malloc_dbg` allocates the memory block with slightly more space than the requested `size`. The additional space is used by the debug heap manager to link the debug memory blocks and to provide the application with debug header information and overwrite buffers. When the block is allocated, the user portion of the block is filled with the value 0xCD and each of the overwrite buffers are filled with 0xFD.  
  
 `_aligned_malloc_dbg` sets `errno` to `ENOMEM` if a memory allocation fails or if the amount of memory needed (including the overhead mentioned previously) exceeds `_HEAP_MAXREQ`. For information about this and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md). Also, `_aligned_malloc_dbg` validates its parameters. If `alignment` is not a power of 2 or `size` is zero, this function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function returns `NULL` and sets `errno` to `EINVAL`.  
  
 For information about how memory blocks are allocated, initialized, and managed in the debug version of the base heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md). For information about the allocation block types and how they are used, see [Types of Blocks on the Debug Heap](../vs140/crt-debug-heap-details.md#BKMK_Types_of_blocks_on_the_debug_heap). For information about the differences between calling a standard heap function and its debug version in a debug build of an application, see [Debug Versions of Heap Allocation Functions](../vs140/debug-versions-of-heap-allocation-functions.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_aligned_malloc_dbg`|\<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)