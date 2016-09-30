---
title: "slice::stride"
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
  - "stride"
  - "std.slice.stride"
  - "slice::stride"
  - "valarray/std::slice::stride"
  - "std::slice::stride"
  - "slice.stride"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stride method"
ms.assetid: 2c04b12a-4390-41fd-a51f-c3fc0eff2b82
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# slice::stride
Finds the distance between elements in a slice of a valarray.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The distance between elements in a slice of a valarray.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The operand valarray va is:**  
 **( 3 6 9 12 15 18 21 24 27 30 33 36 39 42 45 48 51 54 57 60 ).**  
**The slice of valarray va is vaResult = va[slice( 4, 5, 3)] =**  
 **( 15 24 33 42 51 ).**  
**The stride of slice vaSlice is: 3.**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [slice Class](../vs140/slice-class.md)