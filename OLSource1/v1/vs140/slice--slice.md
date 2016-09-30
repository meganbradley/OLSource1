---
title: "slice::slice"
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
  - "slice::slice"
  - "valarray/std::slice::slice"
  - "std.slice.slice"
  - "std::slice::slice"
  - "slice"
  - "slice.slice"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "slice class, constructor"
  - "slice method"
ms.assetid: 8fd9c1be-623b-40c5-b029-99b668df061b
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# slice::slice
Defines a subset of a valarray that consists of a number of elements that are an equal distance apart and that start at a specified element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The valarray index of the first element in the subset.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of elements in the subset.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The distance between elements in the subset.  
  
## Return Value  
 The default constructor stores zeros for the starting index, total length, and stride. The second constructor stores <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> for the starting index, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for the total length, and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for the stride.  
  
## Remarks  
 The stride may be negative.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The operand valarray va is:**  
**( 2 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 ).**  
**The slice of valarray va is vaResult:**  
**va[slice( 1, 7, 3)] = ( 4 10 16 22 28 34 40 ).**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [slice Class](../vs140/slice-class.md)