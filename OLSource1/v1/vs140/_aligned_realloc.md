---
title: "_aligned_realloc"
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
  - "_aligned_realloc"
apilocation: 
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_aligned_realloc"
  - "aligned_realloc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "aligned_realloc function"
  - "_aligned_realloc function"
ms.assetid: 80ce96e8-6087-416f-88aa-4dbb8cb1d218
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _aligned_realloc
Changes the size of a memory block that was allocated with [_aligned_malloc](../vs140/_aligned_malloc.md) or [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The current memory block pointer.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The size of the requested memory allocation.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The alignment value, which must be an integer power of 2.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns a void pointer to the reallocated (and possibly moved) memory block. The return value is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the size is zero and the buffer argument is not <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or if there is not enough available memory to expand the block to the given size. In the first case, the original block is freed. In the second, the original block is unchanged. The return value points to a storage space that is guaranteed to be suitably aligned for storage of any type of object. To get a pointer to a type other than void, use a type cast on the return value.  
  
 It is an error to reallocate memory and change the alignment of a block.  
  
## Remarks  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is based on <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. For more information about using <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, see [malloc](../vs140/malloc.md).  
  
 This function sets <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if the memory allocation failed or if the requested size was greater than <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. For more information about <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md). Also, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> validates its parameters. If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is not a power of 2, this function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function returns <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|\<malloc.h>|  
  
## Example  
 For more information, see [_aligned_malloc](../vs140/_aligned_malloc.md).  
  
## See Also  
 [Data Alignment](../vs140/data-alignment.md)