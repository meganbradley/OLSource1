---
title: "valarray::shift"
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
  - "valarray::shift"
  - "valarray/std::valarray::shift"
  - "valarray.shift"
  - "shift"
  - "std.valarray.shift"
  - "std::valarray::shift"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "shift method"
ms.assetid: 50546b9c-b62b-474a-9069-63a9a1d7e939
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray::shift
Shifts all the elements in a valarray by a specified number of places.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of places the elements are to be shifted forward.  
  
## Return Value  
 A new valarray in which all the elements have been moved <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> positions toward the front of the valarray, left with respect to their positions in the operand valarray.  
  
## Remarks  
 A positive value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> shifts the elements left <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> places, with zero fill.  
  
 A negative value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> shifts the elements right <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> places, with zero fill.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The operand valarray va1(10) is: ( 0 1 2 3 4 5 6 7 8 9 ).**  
**The shifted valarray va1 is: va1.shift (4) = ( 4 5 6 7 8 9 0 0 0 0 ).**  
**The operand valarray va2(10) is: ( 10 9 8 7 6 5 4 3 2 1 ).**  
**The shifted valarray va2 is: va2.shift (-4) = ( 0 0 0 0 10 9 8 7 6 5 ).**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)