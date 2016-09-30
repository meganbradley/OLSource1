---
title: "operator&gt;= (&lt;iterator&gt;)"
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
  - "operator>="
  - "std::>="
  - "std.operator>="
  - ">="
  - "std.>="
  - "iterator/std::operator>="
  - "std::operator>="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - ">= operator, comparing specific objects"
  - "operator>=, iterators"
  - "operator >=, iterators"
ms.assetid: 04d8f78c-4395-4c47-a435-272d570f7f5d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt;= (&lt;iterator&gt;)
Tests if the iterator object on the left side of the operator is greater than or equal to the iterator object on the right side.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An object of type iterator.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An object of type iterator.  
  
## Return Value  
 **true** if the iterator on the left side of the expression is greater than or equal to the iterator on the right side of the expression; **false** if it is less than the iterator on the right.  
  
## Remarks  
 One iterator object is greater than or equal to another if it addresses the same element or an element that occurs later in the container than the element addressed by the other iterator object. One iterator object is less than another if it addresses an element that occurs earlier in the container than the element addressed by the other iterator object.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial vector vec is: ( 0 2 4 6 8 10 ).**  
**The iterator rVPOS1 initially points to the first element**  
 **in the reversed sequence: 10.**  
**The iterator rVPOS2 initially points to the second element**  
 **in the reversed sequence: 8.**  
**The iterator rVPOS1 is less than the iterator rVPOS2.**  
**The iterator rVPOS1 now points to the second element**  
 **in the reversed sequence: 8.**  
**The iterator rVPOS1 is greater than or equal to the iterator rVPOS2.**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)