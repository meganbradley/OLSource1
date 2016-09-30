---
title: "valarray::operator="
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
  - "valarray::operator="
  - "std::valarray::operator="
  - "="
  - "operator="
  - "valarray/std::valarray::operator="
  - "std.valarray.operator="
  - "valarray.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator=, valarrays"
  - "= operator, with specific standard C++ library objects"
  - "operator =, valarrays"
ms.assetid: b29af906-f22d-4423-84a5-9374b4a31804
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray::operator=
Assigns elements to a valarray whose values are specified either directly or as part of some other valarray or by a slice_array, gslice_array, mask_array, or indirect_array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The valarray to be copied into the operand valarray.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value to be assigned to the elements of the operand valarray.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The slice_array to be copied into the operand valarray.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The gslice_array to be copied into the operand valarray.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The mask_array to be copied into the operand valarray.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The indirect_array to be copied into the operand valarray.  
  
## Return Value  
 The first member operator replaces the controlled sequence with a copy of the sequence controlled by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 The second member operator is the same as the first, but with an [rvalue reference](../vs140/rvalue-reference-declarator----.md).  
  
 The third member operator replaces each element of the controlled sequence with a copy of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 The remaining member operators replace those elements of the controlled sequence selected by their arguments, which are generated only by [operator&#91;&#93;](../vs140/valarray--operator.md).  
  
 If the value of a member in the replacement controlled sequence depends on a member in the initial controlled sequence, the result is undefined.  
  
## Remarks  
 If the length of the controlled sequence changes, the result is generally undefined. In this implementation, however, the effect is merely to invalidate any pointers or references to elements in the controlled sequence.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The operand valarray va is: 0 1 2 3 4 5 6 7 8 9**  
**The operand valarray vaR is: 10 9 8 7 6 5 4 3 2 1**  
**The reassigned valarray va is: 10 9 8 7 6 5 4 3 2 1**  
**The reassigned valarray va is: 10 10 10 10 10 10 10 10 10 10**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)