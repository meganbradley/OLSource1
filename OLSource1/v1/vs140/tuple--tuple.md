---
title: "tuple::tuple"
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
  - "tuple.tuple"
  - "tr1.tuple.tuple"
  - "tuple/std::tr1::tuple::tuple"
  - "std::tr1::tuple::tuple"
  - "tuple"
  - "std.tr1.tuple.tuple"
  - "tuple::tuple"
  - "tr1::tuple::tuple"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tuple constructor [TR1]"
  - "tuple method"
ms.assetid: b3e2f5a0-96a4-475e-860d-f4ba2fc4c6c6
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tuple::tuple
Constructs a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of the Nth copied tuple element.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The tuple to copy from.  
  
## Remarks  
 The first constructor constructs an object whose elements are default constructed.  
  
 The second constructor constructs an object whose elements are copy constructed from the arguments <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, ..., <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> with each <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> initializing the element at index <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 The third and fourth constructors construct an object whose elements are copy constructed from the corresponding element of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 The fifth constructor constructs an object whose element at index 0 is copy constructed from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and whose element at index 1 is copy constructed from <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 The remaining constructors are analogs to earlier ones, but with [rvalue references](../vs140/rvalue-reference-declarator----.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **0 1 2 3**  
 **0 1 2 3**  
 **x 4**  
 **0 1 2 3**  
 **4 5 6 7**   
## Requirements  
 **Header:** \<tuple>  
  
 **Namespace:** std  
  
## See Also  
 [\<tuple>](../vs140/-tuple-.md)   
 [tuple](../vs140/tuple-class.md)