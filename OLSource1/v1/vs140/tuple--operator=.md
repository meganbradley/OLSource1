---
title: "tuple::operator="
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
  - "std::tr1::tuple::operator="
  - "tr1.tuple.operator="
  - "std.tr1.tuple.operator="
  - "tr1::tuple::operator="
  - "operator="
  - "tuple::operator="
  - "tuple/std::tr1::tuple::operator="
  - "tuple.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator= operator [TR1]"
  - "operator="
ms.assetid: 525a086d-7987-4a93-8a2a-314fc40ad0b0
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tuple::operator=
Assigns a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of the Nth copied tuple element.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The tuple to copy from.  
  
## Remarks  
 The first two member operators assign the elements of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to the corresponding elements of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The third member operator assigns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to the element at index 0 of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to the element at index 1. All three member operators return <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 The remaining member operators are analogs to earlier ones, but with [rvalue references](../vs140/rvalue-reference-declarator----.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **0 1 2 3**  
 **0 1 2 3**  
 **x 4**   
## Requirements  
 **Header:** \<tuple>  
  
 **Namespace:** std  
  
## See Also  
 [\<tuple>](../vs140/-tuple-.md)   
 [tuple](../vs140/tuple-class.md)