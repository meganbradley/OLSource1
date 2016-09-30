---
title: "_aligned_recalloc"
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
  - "_aligned_recalloc"
apilocation: 
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "aligned_recalloc"
  - "_aligned_recalloc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "aligned_recalloc function"
  - "_aligned_recalloc function"
ms.assetid: d3da3dcc-79ef-4273-8af5-ac7469420142
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _aligned_recalloc
Changes the size of a memory block that was allocated with [_aligned_malloc](../vs140/_aligned_malloc.md) or [_aligned_offset_malloc](../vs140/_aligned_offset_malloc.md) and initializes the memory to 0.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The current memory block pointer.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of elements.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The size in bytes of each element.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The alignment value, which must be an integer power of 2.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns a void pointer to the reallocated (and possibly moved) memory block. The return value is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the size is zero and the buffer argument is not <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or if there is not enough available memory to expand the block to the given size. In the first case, the original block is freed. In the second case, the original block is unchanged. The return value points to a storage space that is guaranteed to be suitably aligned for storage of any type of object. To get a pointer to a type other than void, use a type cast on the return value.  
  
 It is an error to reallocate memory and change the alignment of a block.  
  
## Remarks  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is based on <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. For more information about using <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, see [malloc](../vs140/malloc.md).  
  
 This function sets <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if the memory allocation failed or if the requested size was greater than <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. For more information about <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md). Also, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> validates its parameters. If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is not a power of 2, this function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function returns <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|\<malloc.h>|  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Data Alignment](../vs140/data-alignment.md)   
 [_recalloc](../vs140/_recalloc.md)   
 [_aligned_offset_recalloc](../vs140/_aligned_offset_recalloc.md)