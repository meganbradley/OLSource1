---
title: "_expand_dbg"
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
  - "_expand_dbg"
apilocation: 
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "expand_dbg"
  - "_expand_dbg"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "memory blocks, changing size"
  - "expand_dbg function"
  - "_expand_dbg function"
ms.assetid: dc58c91f-72a8-48c6-b643-fe130fb6c1fd
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _expand_dbg
Resizes a specified block of memory in the heap by expanding or contracting the block (debug version only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the previously allocated memory block.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Requested new size for the block (in bytes).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Requested type for resized block: <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Pointer to the name of the source file that requested expand operation or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Line number in the source file where the expand operation was requested or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameters are only available when <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> has been called explicitly or the [_CRTDBG_MAP_ALLOC](../vs140/_crtdbg_map_alloc.md) preprocessor constant has been defined.  
  
## Return Value  
 On successful completion, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> returns a pointer to the resized memory block. Because the memory is not moved, the address is the same as the userData. If an error occurred or the block could not be expanded to the requested size, it returns <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. If a failure occurs, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is with information from the operating system about the nature of the failure. For more information about <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> function is a debug version of the _[expand](../vs140/_expand.md) function. When [_DEBUG](../vs140/_debug.md) is not defined, each call to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is reduced to a call to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. Both <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> resize a memory block in the base heap, but <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> accommodates several debugging features: buffers on either side of the user portion of the block to test for leaks, a block type parameter to track specific allocation types, and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> information to determine the origin of allocation requests.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> resizes the specified memory block with slightly more space than the requested <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> might be greater or less than the size of the originally allocated memory block. The additional space is used by the debug heap manager to link the debug memory blocks and to provide the application with debug header information and overwrite buffers. The resize is accomplished by either expanding or contracting the original memory block. <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> does not move the memory block, as does the [_realloc_dbg](../vs140/_realloc_dbg.md) function.  
  
 When <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is greater than the original block size, the memory block is expanded. During an expansion, if the memory block cannot be expanded to accommodate the requested size, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is returned. When <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is less than the original block size, the memory block is contracted until the new size is obtained.  
  
 For information about how memory blocks are allocated, initialized, and managed in the debug version of the base heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md). For information about the allocation block types and how they are used, see [Types of blocks on the debug heap](../vs140/crt-debug-heap-details.md#BKMK_Types_of_blocks_on_the_debug_heap). For information about the differences between calling a standard heap function and its debug version in a debug build of an application, see [Debug Versions of Heap Allocation Functions](../vs140/debug-versions-of-heap-allocation-functions.md).  
  
 This function validates its parameters. If <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is a null pointer, or if size is greater than <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, this function invokes an invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and the function returns <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Size of block after _malloc_dbg of 40 longs: 160**  
**Size of block after _expand_dbg of 1 more long: 164**   
## Comment  
 The output of this program depends on your computer's ability to expand all the sections. If all sections are expanded, the output is reflected in the Output section.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)   
 [_malloc_dbg](../vs140/_malloc_dbg.md)