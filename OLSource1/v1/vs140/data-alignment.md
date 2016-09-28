---
title: "Data Alignment"
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
  - "data.alignment"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "data alignment [C++]"
ms.assetid: 35ac3d2d-a4b3-421b-954f-b7372b1f18e1
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Data Alignment
The following C run-time functions support data alignment.  
  
### Data-Alignment Routines  
  
|Routine|Use|.NET Framework equivalent|  
|-------------|---------|-------------------------------|  
|[_aligned_free](../vs140/_aligned_free.md)|Frees a block of memory that was allocated with [_aligned_malloc](../vs140/_aligned_malloc.md)or [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md).|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_aligned_free_dbg](../vs140/_aligned_free_dbg.md)|Frees a block of memory that was allocated with [_aligned_malloc](../vs140/_aligned_malloc.md) or [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md) (debug only).|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_aligned_malloc](../vs140/_aligned_malloc.md)|Allocates memory on a specified alignment boundary.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_aligned_malloc_dbg](../vs140/_aligned_malloc_dbg.md)|Allocates memory on a specified alignment boundary with additional space for a debugging header and overwrite buffers (debug version only).|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_aligned_msize](../vs140/_aligned_msize.md)|Returns the size of a memory block allocated in the heap.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_aligned_msize_dbg](../vs140/_aligned_msize_dbg.md)|Returns the size of a memory block allocated in the heap (debug version only).|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md)|Allocates memory on a specified alignment boundary.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_aligned_offset_malloc_dbg](../vs140/_aligned_offset_malloc_dbg.md)|Allocates memory on a specified alignment boundary (debug version only).|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_aligned_offset_realloc](../vs140/_aligned_offset_realloc.md)|Changes the size of a memory block that was allocated with [_aligned_malloc](../vs140/_aligned_malloc.md) or [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md).|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_aligned_offset_realloc_dbg](../vs140/_aligned_offset_realloc_dbg.md)|Changes the size of a memory block that was allocated with [_aligned_malloc](../vs140/_aligned_malloc.md) or [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md) (debug version only).|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_aligned_offset_recalloc](../vs140/_aligned_offset_recalloc.md)|Changes the size of a memory block that was allocated with [_aligned_malloc](../vs140/_aligned_malloc.md) or [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md) and initializes the memory to 0.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_aligned_offset_recalloc_dbg](../vs140/_aligned_offset_recalloc_dbg.md)|Changes the size of a memory block that was allocated with [_aligned_malloc](../vs140/_aligned_malloc.md) or [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md) and initializes the memory to 0 (debug version only).|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_aligned_realloc](../vs140/_aligned_realloc.md)|Changes the size of a memory block that was allocated with [_aligned_malloc](../vs140/_aligned_malloc.md) or [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md).|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_aligned_realloc_dbg](../vs140/_aligned_realloc_dbg.md)|Changes the size of a memory block that was allocated with [_aligned_malloc](../vs140/_aligned_malloc.md) or [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md) (debug version only).|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_aligned_recalloc](../vs140/_aligned_recalloc.md)|Changes the size of a memory block that was allocated with [_aligned_malloc](../vs140/_aligned_malloc.md) or [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md) and initializes the memory to 0.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_aligned_recalloc_dbg](../vs140/_aligned_recalloc_dbg.md)|Changes the size of a memory block that was allocated with [_aligned_malloc](../vs140/_aligned_malloc.md) or [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md) and initializes the memory to 0 (debug version only).|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
  
## See Also  
 [Run-Time Routines by Category](../vs140/run-time-routines-by-category.md)