---
title: "_aligned_offset_malloc"
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
  - "_aligned_offset_malloc"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_aligned_offset_malloc"
  - "aligned_offset_malloc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_aligned_offset_malloc function"
  - "aligned_offset_malloc function"
ms.assetid: 447681a3-7c95-4655-86ba-fa3a4ca4c521
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _aligned_offset_malloc
Allocates memory on a specified alignment boundary.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The size of the requested memory allocation.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The alignment value, which must be an integer power of 2.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The offset into the memory allocation to force the alignment.  
  
## Return Value  
 A pointer to the memory block that was allocated or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the operation failed.  
  
## Remarks  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is useful in situations where alignment is needed on a nested element; for example, if alignment was needed on a nested class.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is based on <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; for more information, see [malloc](../vs140/malloc.md).  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is marked <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, meaning that the function is guaranteed not to modify global variables and that the pointer returned is not aliased. For more information, see [noalias](../vs140/noalias.md) and [restrict](../vs140/restrict.md).  
  
 This function sets <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if the memory allocation failed or if the requested size was greater than <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. For more information about <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md). Also, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> validates its parameters. If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is not a power of 2 or if <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is greater than or equal to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and nonzero, this function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function returns <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|\<malloc.h>|  
  
## Example  
 For more information, see [_aligned_malloc](../vs140/_aligned_malloc.md).  
  
## See Also  
 [Data Alignment](../vs140/data-alignment.md)