---
title: "array::array"
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
  - "std.tr1.array.array"
  - "array/std::tr1::array::array"
  - "array::array"
  - "array.array"
  - "std::tr1::array::array"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "array constructor [TR1]"
ms.assetid: b3907d5a-6053-483c-9e34-c55c647e68a9
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::array
Constructs an array object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Object or range to insert.  
  
## Remarks  
 The constructor:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 leaves the controlled sequence uninitialized (or default initialized). You use it to specify an uninitialized controlled sequence.  
  
 The constructor:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 initializes the controlled sequence with the sequence <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>[begin](../vs140/array--begin.md)<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>[end](../vs140/array--end.md)<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. You use it to specify an initial controlled sequence that is a copy of the sequence controlled by the array object <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **0 1 2 3**  
 **0 1 2 3**   
## Requirements  
 **Header:** \<array>  
  
 **Namespace:** std  
  
## See Also  
 [\<array>](../vs140/-array-.md)   
 [array](../vs140/array-class--stl-.md)   
 [assign](../vs140/array--assign.md)   
 [operator=](../vs140/array--operator=.md)