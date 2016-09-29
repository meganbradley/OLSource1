---
title: "Memory Allocation"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "c.memory"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "memory allocation, routines"
  - "memory, managing"
  - "memory, allocation"
ms.assetid: b4470556-a128-4782-9943-2ccf7a7d9979
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Memory Allocation
Use these routines to allocate, free, and reallocate memory.  
  
### Memory-Allocation Routines  
  
|Routine|Use|.NET Framework equivalent|  
|-------------|---------|-------------------------------|  
|[_alloca](../vs140/_alloca.md), [_alloca_s](../vs140/_malloca.md)|Allocate memory from stack|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[calloc](../vs140/calloc.md)|Allocate storage for array, initializing every byte in allocated block to 0|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_calloc_dbg](../vs140/_calloc_dbg.md)|Debug version of `calloc`; only available in the debug versions of the run-time libraries|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[operator delete](../vs140/operator-delete--crt-.md)|Free allocated block|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[operator delete&#91;&#93;](../vs140/operator-delete-crt-.md)|Free allocated block|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_expand](../vs140/_expand.md)|Expand or shrink block of memory without moving it|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_expand_dbg](../vs140/_expand_dbg.md)|Debug version of `_expand`; only available in the debug versions of the run-time libraries|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[free](../vs140/free.md)|Free allocated block|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_free_dbg](../vs140/_free_dbg.md)|Debug version of `free`; only available in the debug versions of the run-time libraries|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_freea_s](../vs140/_freea.md)|Free allocated block from stack|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_get_heap_handle](../vs140/_get_heap_handle.md)|Get Win32 HANDLE of the CRT heap.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_heapadd](../vs140/_heapadd.md)|Add memory to heap|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_heapchk](../vs140/_heapchk.md)|Check heap for consistency|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_heapmin](../vs140/_heapmin.md)|Release unused memory in heap|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_heapset](../vs140/_heapset.md)|Fill free heap entries with specified value|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_heapwalk](../vs140/_heapwalk.md)|Return information about each entry in heap|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[malloc](../vs140/malloc.md)|Allocate block of memory from heap|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_malloc_dbg](../vs140/_malloc_dbg.md)|Debug version of `malloc`; only available in the debug versions of the run-time libraries|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_msize](../vs140/_msize.md)|Return size of allocated block|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_msize_dbg](../vs140/_msize_dbg.md)|Debug version of `_msize`; only available in the debug versions of the run-time libraries|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[new](../vs140/operator-new--crt-.md)|Allocate block of memory from heap|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[new&#91;&#93;](../vs140/operator-new-crt-.md)|Allocate block of memory from heap|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_query_new_handler](../vs140/_query_new_handler.md)|Return address of current new handler routine as set by `_set_new_handler`|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_query_new_mode](../vs140/_query_new_mode.md)|Return integer indicating new handler mode set by `_set_new_mode` for `malloc`|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[realloc](../vs140/realloc.md)|Reallocate block to new size|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_realloc_dbg](../vs140/_realloc_dbg.md)|Debug version of `realloc`; only available in the debug versions of the run-time libraries|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_set_new_handler](../vs140/_set_new_handler.md)|Enable error-handling mechanism when `new` operator fails (to allocate memory) and enable compilation of Standard Template Libraries (STL)|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_set_new_mode](../vs140/_set_new_mode.md)|Set new handler mode for `malloc`|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
  
## See Also  
 [Run-Time Routines by Category](../vs140/run-time-routines-by-category.md)