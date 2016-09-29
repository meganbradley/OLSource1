---
title: "_aligned_msize"
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
  - "_aligned_msize"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_aligned_msize"
  - "aligned_msize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "aligned_msize function"
  - "_aligned_msize function"
ms.assetid: 10995edc-2110-4212-9ca9-5e0220a464f4
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _aligned_msize
Returns the size of a memory block allocated in the heap.  
  
## Syntax  
  
```  
size_t _msize(  
   void *memblock,  
   size_t alignment,  
   size_t offset  
);  
```  
  
#### Parameters  
 [in] `memblock`  
 Pointer to the memory block.  
  
 [in] `alignment`  
 The alignment value, which must be an integer power of 2.  
  
 [in] `offset`  
 The offset into the memory allocation to force the alignment.  
  
## Return Value  
 Returns the size (in bytes) as an unsigned integer.  
  
## Remarks  
 The `_aligned_msize` function returns the size, in bytes, of the memory block allocated by a call to [_aligned_malloc](../vs140/_aligned_malloc.md) or [_aligned_realloc](../vs140/_aligned_realloc.md). The `alignment` and `offset` values must be the same as the values passed to the function that allocated the block.  
  
 When the application is linked with a debug version of the C run-time libraries, `_aligned_msize` resolves to [_aligned_msize_dbg](../vs140/_aligned_msize_dbg.md). For more information about how the heap is managed during the debugging process, see [The CRT Debug Heap](../vs140/crt-debug-heap-details.md).  
  
 This function validates its parameter. If `memblock` is a null pointer or `alignment` is not a power of 2, `_msize` invokes an invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If the error is handled, the function sets `errno` to `EINVAL` and returns -1.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_msize`|<malloc.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)