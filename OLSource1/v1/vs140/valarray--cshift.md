---
title: "valarray::cshift"
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
  - "std::valarray::cshift"
  - "valarray/std::valarray::cshift"
  - "cshift"
  - "std.valarray.cshift"
  - "valarray.cshift"
  - "valarray::cshift"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cshift method"
ms.assetid: 9e26038d-66ff-4c5b-bac0-d70747c7572f
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray::cshift
Cyclically shifts all the elements in a valarray by a specified number of positions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of places the elements are to be shifted forward.  
  
## Return Value  
 A new valarray in which all the elements have been moved <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> positions cyclically toward the front of the valarray, left with respect to their positions in the operand valarray.  
  
## Remarks  
 A positive value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> shifts the elements cyclically left <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> places.  
  
 A negative value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> shifts the elements cyclically right <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> places.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The operand valarray va1 is: ( 0 1 2 3 4 5 6 7 8 9)**  
**The cyclically shifted valarray va1 is:**  
**va1.cshift (4) = ( 4 5 6 7 8 9 0 1 2 3)**  
**The operand valarray va2 is: ( 10 9 8 7 6 5 4 3 2 1)**  
**The cyclically shifted valarray va2 is:**  
**va2.shift (-4) = ( 4 3 2 1 10 9 8 7 6 5)**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)