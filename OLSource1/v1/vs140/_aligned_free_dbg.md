---
title: "_aligned_free_dbg"
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
  - "_aligned_free_dbg"
apilocation: 
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_aligned_free_dbg"
  - "aligned_free_dbg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_aligned_free_dbg function"
  - "aligned_free_dbg function"
ms.assetid: eb0cb3c8-0992-4db8-bac3-65f1b8311ca6
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _aligned_free_dbg
Frees a block of memory that was allocated with [_aligned_malloc](../vs140/_aligned_malloc.md) or [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md) (debug only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the memory block that was returned to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function is a debug version of the [_aligned_free](../vs140/_aligned_free.md) function. When [_DEBUG](../vs140/_debug.md) is not defined, each call to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is reduced to a call to _<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Both \_<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> free a memory block in the base heap, but <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> accommodates a debugging feature: the ability to keep freed blocks in the heap's linked list to simulate low memory conditions.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> performs a validity check on all specified files and block locations before performing the free operation. The application is not expected to provide this information. When a memory block is freed, the debug heap manager automatically checks the integrity of the buffers on either side of the user portion and issues an error report if overwriting has occurred. If the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> bit field of the [_crtDbgFlag](../vs140/_crtdbgflag.md) flag is set, the freed block is filled with the value 0xDD, assigned the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> block type, and kept in the heap's linked list of memory blocks.  
  
 If an error occurs in freeing the memory, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is set with information from the operating system on the nature of the failure. For more information, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 For information about how memory blocks are allocated, initialized, and managed in the debug version of the base heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md). For information about the allocation block types and how they are used, see [Types of Blocks on the Debug Heap](../vs140/crt-debug-heap-details.md#BKMK_Types_of_blocks_on_the_debug_heap). For information about the differences between calling a standard heap function and its debug version in a debug build of an application, see [Debug Versions of Heap Allocation Functions](../vs140/debug-versions-of-heap-allocation-functions.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)