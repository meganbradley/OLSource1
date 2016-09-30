---
title: "_aligned_offset_recalloc"
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
  - "_aligned_offset_recalloc"
apilocation: 
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "aligned_offset_recalloc"
  - "_aligned_offset_recalloc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "aligned_offset_recalloc function"
  - "_aligned_offset_recalloc function"
ms.assetid: a258f54e-eeb4-4853-96fc-007d710f98e9
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _aligned_offset_recalloc
Changes the size of a memory block that was allocated with [_aligned_malloc](../vs140/_aligned_malloc.md) or [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md) and initializes the memory to 0.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The current memory block pointer.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Number of elements.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Length in bytes of each element.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The alignment value, which must be an integer power of 2.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The offset into the memory allocation to force the alignment.  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns a void pointer to the reallocated (and possibly moved) memory block. The return value is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the size is zero and the buffer argument is not <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or if there is not enough available memory to expand the block to the given size. In the first case, the original block is freed. In the second case, the original block is unchanged. The return value points to a storage space that is guaranteed to be suitably aligned for storage of any type of object. To get a pointer to a type other than void, use a type cast on the return value.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is marked <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, meaning that the function is guaranteed not to modify global variables and that the pointer returned is not aliased. For more information, see [noalias](../vs140/noalias.md) and [restrict](../vs140/restrict.md).  
  
## Remarks  
 Like [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md), <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> allows a structure to be aligned at an offset within the structure.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is based on <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. For more information about using <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, see [malloc](../vs140/malloc.md). If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, the function calls <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> internally.  
  
 This function sets <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> if the memory allocation failed or if the requested size (<CodeContentPlaceHolder>21\</CodeContentPlaceHolder> * <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>) was greater than <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. For more information about <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md). Also, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> validates its parameters. If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is not a power of 2 or if <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is greater than or equal to the requested size and nonzero, this function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function returns <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|\<malloc.h>|  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Data Alignment](../vs140/data-alignment.md)   
 [_recalloc](../vs140/_recalloc.md)   
 [_aligned_recalloc](../vs140/_aligned_recalloc.md)