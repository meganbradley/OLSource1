---
title: "_calloc_dbg"
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
  - "_calloc_dbg"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_calloc_dbg"
  - "calloc_dbg"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_calloc_dbg function"
  - "calloc_dbg function"
ms.assetid: 7f62c42b-eb9f-4de5-87d0-df57036c87de
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _calloc_dbg
Allocates a number of memory blocks in the heap with additional space for a debugging header and overwrite buffers (debug version only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Requested number of memory blocks.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Requested size of each memory block (bytes).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Requested type of memory block: <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 For information about the allocation block types and how they are used, see[Types of blocks on the debug heap](../vs140/crt-debug-heap-details.md#BKMK_Types_of_blocks_on_the_debug_heap).  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Pointer to name of the source file that requested allocation operation or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Line number in the source file where allocation operation was requested or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameters are only available when <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> has been called explicitly or the [_CRTDBG_MAP_ALLOC](../vs140/_crtdbg_map_alloc.md) preprocessor constant has been defined.  
  
## Return Value  
 On successful completion, this function returns a pointer to the user portion of the last allocated memory block, calls the new handler function, or returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. For a complete description of the return behavior, see the Remarks section. For more information about how the new handler function is used, see the [calloc](../vs140/calloc.md) function.  
  
## Remarks  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is a debug version of the [calloc](../vs140/calloc.md) function. When [_DEBUG](../vs140/_debug.md) is not defined, each call to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is reduced to a call to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. Both <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> allocate <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> memory blocks in the base heap, but <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> offers several debugging features:  
  
-   Buffers on either side of the user portion of the block to test for leaks.  
  
-   A block type parameter to track specific allocation types.  
  
-   <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>23\</CodeContentPlaceHolder> information to determine the origin of allocation requests.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> allocates each memory block with slightly more space than the requested <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. The additional space is used by the debug heap manager to link the debug memory blocks and to provide the application with debug header information and overwrite buffers. When the block is allocated, the user portion of the block is filled with the value 0xCD and each of the overwrite buffers are filled with 0xFD.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> sets <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> if a memory allocation fails; <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is returned if the amount of memory needed (including the overhead mentioned previously) exceeds <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. For information about this and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 For information about how memory blocks are allocated, initialized, and managed in the debug version of the base heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md). For information about the differences between calling a standard heap function versus its debug version in a debug build of an application, see [Debug Versions of Heap Allocation Functions](../vs140/debug-versions-of-heap-allocation-functions.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Allocated memory successfully**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)   
 [calloc](../vs140/calloc.md)   
 [_malloc_dbg](../vs140/_malloc_dbg.md)   
 [_DEBUG](../vs140/_debug.md)