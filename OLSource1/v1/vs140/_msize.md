---
title: "_msize"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
apiname: 
  - _msize
apilocation: 
  - msvcr90.dll
  - msvcr110_clr0400.dll
  - msvcr80.dll
  - msvcr100.dll
  - msvcr120.dll
  - msvcrt.dll
  - msvcr110.dll
apitype: DLLExport
f1_keywords: 
  - msize
  - _msize
dev_langs: 
  - C++
  - C
helpviewer_keywords: 
  - memory blocks
  - msize function
  - _msize function
ms.assetid: 02b1f89e-d0d7-4f12-938a-9eeba48a0f88
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# _msize
Returns the size of a memory block allocated in the heap.  
  
## Syntax  
  
```  
  
      size_t _msize(  
   void *memblock   
);  
```  
  
#### Parameters  
 `memblock`  
 Pointer to the memory block.  
  
## Return Value  
 `_msize` returns the size (in bytes) as an unsigned integer.  
  
## Remarks  
 The `_msize` function returns the size, in bytes, of the memory block allocated by a call to `calloc`, `malloc`, or `realloc`.  
  
 When the application is linked with a debug version of the C run-time libraries, `_msize` resolves to [_msize_dbg](../vs140/_msize_dbg.md). For more information about how the heap is managed during the debugging process, see [The CRT Debug Heap](../vs140/crt-debug-heap-details.md).  
  
 This function validates its parameter. If `memblock` is a null pointer, `_msize` invokes an invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If the error is handled, the function sets `errno` to `EINVAL` and returns -1.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_msize`|<malloc.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
 See the example for [realloc](../vs140/realloc.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)   
 [calloc](../vs140/calloc.md)   
 [_expand](../vs140/_expand.md)   
 [malloc](../vs140/malloc.md)   
 [realloc](../vs140/realloc.md)