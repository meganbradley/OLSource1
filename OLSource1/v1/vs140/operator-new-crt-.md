---
title: "operator new(CRT)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "new[]"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "operator new[]"
  - "vector new"
ms.assetid: 79682f85-6889-40f6-b8f7-9eed5176ea35
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator new(CRT)
Allocate block of memory from heap  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *count*  
 The size of the allocation.  
  
 *object*  
 A pointer to a block of memory in which the object will be created.  
  
## Return Value  
 A pointer to the lowest byte address of the newly allocated storage.  
  
## Remarks  
 This form of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is known as vector new, in contrast to the scalar new form ([operator new](../vs140/operator-new--crt-.md)).  
  
 The first form of this operator is known as the nonplacement form. The second form of this operator is known as the placement form and the third form of this operator is the nonthrowing placement form.  
  
 The first form of the operator is defined by the compiler and does not require new.h to be included in your program.  
  
 [operator delete&#91;&#93;](../vs140/operator-delete--new--.md) frees memory allocated with operator new.  
  
 You can configure whether <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns null or throws an exception on failure. See [The new and delete Operators](../vs140/new-and-delete-operators.md) for more information.  
  
 With the exception of throwing or no-throwing behavior, the CRT <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> behaves like [operator new&#91;&#93;](../vs140/operator-new--new--.md) in the Standard C++ Library.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|\<new.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
 The following shows how to use the vector, nonplacement form of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following shows how to use the vector, placement form of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following shows how to use the vector, placement, no-throw form of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)