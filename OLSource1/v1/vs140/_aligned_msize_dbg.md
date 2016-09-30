---
title: "_aligned_msize_dbg"
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
  - "_aligned_msize_dbg"
apilocation: 
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_aligned_msize_dbg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_aligned_msize_dbg"
ms.assetid: f1c44af0-3f66-4033-81d1-d71d3afecba0
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _aligned_msize_dbg
Returns the size of a memory block allocated in the heap (debug version only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the memory block.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The alignment value, which must be an integer power of 2.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The offset into the memory allocation to force the alignment.  
  
## Return Value  
 Returns the size (in bytes) as an unsigned integer.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> values must be the same as the values passed to the function that allocated the block.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a debug version of the [_aligned_msize](../vs140/_aligned_msize.md) function. When [_DEBUG](../vs140/_debug.md) is not defined, each call to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is reduced to a call to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Both <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> calculate the size of a memory block in the base heap, but <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> adds a debugging feature: It includes the buffers on either side of the user portion of the memory block in the returned size.  
  
 This function validates its parameter. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is a null pointer or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is not a power of 2, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> invokes an invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If the error is handled, the function sets <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and returns -1.  
  
 For information about how memory blocks are allocated, initialized, and managed in the debug version of the base heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md). For information about the allocation block types and how they are used, see [Types of blocks on the debug heap](../vs140/crt-debug-heap-details.md#BKMK_Types_of_blocks_on_the_debug_heap). For information about the differences between calling a standard heap function and its debug version in a debug build of an application, see [Debug Versions of Heap Allocation Functions](../vs140/debug-versions-of-heap-allocation-functions.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)