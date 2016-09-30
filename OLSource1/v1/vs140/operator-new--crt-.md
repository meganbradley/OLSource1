---
title: "operator new (CRT)"
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
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "operator new"
  - "scalar new"
ms.assetid: 4ae51618-a4e6-4172-b324-b99d86d1bdca
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator new (CRT)
Allocates block of memory from heap  
  
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
 This form of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is known as scalar new, in contrast to the vector new form ([operator new&#91;&#93;](../vs140/operator-new-crt-.md)).  
  
 The first form of this operator is known as the nonplacement form. The second form of this operator is known as the placement form and the third form of this operator is the nonthrowing, placement form.  
  
 The first form of the operator is defined by the compiler and does not require new.h to be included in your program.  
  
 [operator delete](../vs140/operator-delete--crt-.md) frees memory allocated with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 You can configure whether operator new returns null or throws an exception on failure. See [The new and delete Operators](../vs140/new-and-delete-operators.md) for more information.  
  
 With the exception of throwing or no-throwing behavior, the CRT <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> behaves like [operator new](../vs140/operator-new---new--.md) in the Standard C++ Library.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|**new**|\<new.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
 The following shows how to use the scalar, nonplacement form of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following shows how to use the scalar, placement form of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following shows how to use the scalar, placement, no-throw form of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)