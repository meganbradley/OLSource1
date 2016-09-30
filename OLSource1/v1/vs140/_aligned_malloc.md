---
title: "_aligned_malloc"
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
  - "_aligned_malloc"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_aligned_malloc"
  - "alligned_malloc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "aligned_malloc function"
  - "_aligned_malloc function"
ms.assetid: fb788d40-ee94-4039-aa4d-97d73dab1ca0
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _aligned_malloc
Allocates memory on a specified alignment boundary.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Size of the requested memory allocation.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The alignment value, which must be an integer power of 2.  
  
## Return Value  
 A pointer to the memory block that was allocated or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the operation failed. The pointer is a multiple of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is based on [malloc](../vs140/malloc.md).  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is marked <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, meaning that the function is guaranteed not to modify global variables and that the pointer returned is not aliased. For more information, see [noalias](../vs140/noalias.md) and [restrict](../vs140/restrict.md).  
  
 This function sets <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if the memory allocation failed or if the requested size was greater than <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. For more information about <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md). Also, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> validates its parameters. If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is not a power of 2 or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is zero, this function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function returns <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|\<malloc.h>|  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **This pointer, 3280880, is aligned on 16**  
**This pointer, 3280880, is aligned on 16**  
**This pointer, 3280891, is offset by 5 on alignment of 16**  
**This pointer, 3280891, is offset by 5 on alignment of 16**   
## See Also  
 [Data Alignment](../vs140/data-alignment.md)