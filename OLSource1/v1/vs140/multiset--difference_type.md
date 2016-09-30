---
title: "multiset::difference_type"
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
  - "std.multiset.difference_type"
  - "std::multiset::difference_type"
  - "multiset::difference_type"
  - "set/std::multiset::difference_type"
  - "difference_type"
  - "multiset.difference_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "difference_type typedef"
ms.assetid: 525d6b39-7ca0-40a9-80c0-da5942720eb1
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::difference_type
A signed integer type that can be used to represent the number of elements of a multiset in a range between elements pointed to by iterators.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is the type returned when subtracting or incrementing through iterators of the container. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is typically used to represent the number of elements in the range [<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) between the iterators <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, includes the element pointed to by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and the range of elements up to, but not including, the element pointed to by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 Note that although <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is available for all iterators that satisfy the requirements of an input iterator, which includes the class of bidirectional iterators supported by reversible containers like set, subtraction between iterators is only supported by random-access iterators provided by a random-access container like vector.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The number '5' occurs 0 times in multiset ms1.**  
**The number '10' occurs 1 times in multiset ms1.**  
**The number '20' occurs 2 times in multiset ms1.**  
**The number of elements in the multiset ms1 is: 3.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)