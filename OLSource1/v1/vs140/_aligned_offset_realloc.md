---
title: "_aligned_offset_realloc"
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
  - "_aligned_offset_realloc"
apilocation: 
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "aligned_offset_realloc"
  - "_aligned_offset_realloc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "aligned_offset_realloc function"
  - "_aligned_offset_realloc function"
ms.assetid: e0263533-991e-41b0-acc9-1b8a51ab9ecd
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _aligned_offset_realloc
Changes the size of a memory block that was allocated with [_aligned_malloc](../vs140/_aligned_malloc.md) or [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The current memory block pointer.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The size of the memory allocation.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The alignment value, which must be an integer power of 2.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The offset into the memory allocation to force the alignment.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns a void pointer to the reallocated (and possibly moved) memory block. The return value is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the size is zero and the buffer argument is not <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or if there is not enough available memory to expand the block to the given size. In the first case, the original block is freed. In the second case, the original block is unchanged. The return value points to a storage space that is guaranteed to be suitably aligned for storage of any type of object. To get a pointer to a type other than void, use a type cast on the return value.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is marked <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, meaning that the function is guaranteed not to modify global variables and that the pointer returned is not aliased. For more information, see [noalias](../vs140/noalias.md) and [restrict](../vs140/restrict.md).  
  
## Remarks  
 Like [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md), <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> allows a structure to be aligned at an offset within the structure.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is based on <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. For more information about using <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, see [malloc](../vs140/malloc.md). If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the function calls <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> internally.  
  
 This function sets <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> if the memory allocation failed or if the requested size was greater than <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. For more information about <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md). Also, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> validates its parameters. If <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is not a power of 2 or if <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is greater than or equal to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and nonzero, this function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function returns <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|\<malloc.h>|  
  
## Example  
 For more information, see [_aligned_malloc](../vs140/_aligned_malloc.md).  
  
## See Also  
 [Data Alignment](../vs140/data-alignment.md)