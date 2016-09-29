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
|[_alloca](../VS_csharp/_alloca.md), [_alloca_s](../VS_csharp/_malloca.md)|Allocate memory from stack|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[calloc](../VS_csharp/calloc.md)|Allocate storage for array, initializing every byte in allocated block to 0|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_calloc_dbg](../VS_csharp/_calloc_dbg.md)|Debug version of `calloc`; only available in the debug versions of the run-time libraries|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[operator delete](../VS_csharp/operator-delete--crt-.md)|Free allocated block|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[operator delete&#91;&#93;](../VS_csharp/operator-delete-crt-.md)|Free allocated block|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_expand](../VS_csharp/_expand.md)|Expand or shrink block of memory without moving it|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_expand_dbg](../VS_csharp/_expand_dbg.md)|Debug version of `_expand`; only available in the debug versions of the run-time libraries|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[free](../VS_csharp/free.md)|Free allocated block|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_free_dbg](../VS_csharp/_free_dbg.md)|Debug version of `free`; only available in the debug versions of the run-time libraries|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_freea_s](../VS_csharp/_freea.md)|Free allocated block from stack|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_get_heap_handle](../VS_csharp/_get_heap_handle.md)|Get Win32 HANDLE of the CRT heap.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_heapadd](../VS_csharp/_heapadd.md)|Add memory to heap|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_heapchk](../VS_csharp/_heapchk.md)|Check heap for consistency|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_heapmin](../VS_csharp/_heapmin.md)|Release unused memory in heap|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_heapset](../VS_csharp/_heapset.md)|Fill free heap entries with specified value|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_heapwalk](../VS_csharp/_heapwalk.md)|Return information about each entry in heap|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[malloc](../VS_csharp/malloc.md)|Allocate block of memory from heap|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_malloc_dbg](../VS_csharp/_malloc_dbg.md)|Debug version of `malloc`; only available in the debug versions of the run-time libraries|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_msize](../VS_csharp/_msize.md)|Return size of allocated block|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_msize_dbg](../VS_csharp/_msize_dbg.md)|Debug version of `_msize`; only available in the debug versions of the run-time libraries|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[new](../VS_csharp/operator-new--crt-.md)|Allocate block of memory from heap|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[new&#91;&#93;](../VS_csharp/operator-new-crt-.md)|Allocate block of memory from heap|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_query_new_handler](../VS_csharp/_query_new_handler.md)|Return address of current new handler routine as set by `_set_new_handler`|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_query_new_mode](../VS_csharp/_query_new_mode.md)|Return integer indicating new handler mode set by `_set_new_mode` for `malloc`|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[realloc](../VS_csharp/realloc.md)|Reallocate block to new size|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_realloc_dbg](../VS_csharp/_realloc_dbg.md)|Debug version of `realloc`; only available in the debug versions of the run-time libraries|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_set_new_handler](../VS_csharp/_set_new_handler.md)|Enable error-handling mechanism when `new` operator fails (to allocate memory) and enable compilation of Standard Template Libraries (STL)|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_set_new_mode](../VS_csharp/_set_new_mode.md)|Set new handler mode for `malloc`|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
  
## See Also  
 [Run-Time Routines by Category](../VS_csharp/run-time-routines-by-category.md)