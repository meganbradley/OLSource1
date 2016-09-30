---
title: "valarray::operator-=2"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "valarray::operator-="
f1_keywords: 
  - "operator-="
  - "-="
  - "valarray/std::valarray::operator-="
  - "valarray.operator-="
  - "std::valarray::operator-="
  - "std.valarray.operator-="
  - "valarray::operator-="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator-="
  - "-= operator"
ms.assetid: 486bbe9b-f42e-4503-ba2d-6c7286c04433
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray::operator-=2
Subtracts the elements of a specified valarray or a value of the element type, element-wise, from an operand valarray.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The valarray or value of an element type identical to that of the operand valarray that is to be subtracted, element-wise, from the operand valarray.  
  
## Return Value  
 A valarray whose elements are the element-wise difference of the operand valarray and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial valarray is: ( 10 0 10 0 10 0 10 0 ).**  
**The initial _Right valarray is: ( 0 1 2 3 4 5 6 7 ).**  
**The element-by-element result of the difference is the**  
 **valarray: ( 10 -1 8 -3 6 -5 4 -7 ).**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)