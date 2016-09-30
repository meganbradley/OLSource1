---
title: "valarray::size"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "valarray.size"
  - "size"
  - "std::valarray::size"
  - "valarray::size"
  - "std.valarray.size"
  - "valarray/std::valarray::size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size method"
ms.assetid: 53cf762f-2132-46e4-bd75-87d9576aa1ef
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# valarray::size
Finds the number of elements in a valarray.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The number of elements in the operand valarray.  
  
## Example  
 The following example demonstrates the use of the valarray::size member function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The operand valarray va1(10) is: ( 0 1 2 3 4 5 6 7 8 9 ).**  
**The number of elements in the valarray va1 is: va1.size = 10.**  
**The operand valarray va2(12) is: ( 0 1 2 3 4 5 6 7 8 9 ).**  
**The number of elements in the valarray va2 is: va2.size = 12.**  
**After initializing two more elements,**  
 **the operand valarray va2(12) is now: ( 0 1 2 3 4 5 6 7 8 9 10 11 ).**  
**The number of elements in the valarray va2 is still: 12.**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)