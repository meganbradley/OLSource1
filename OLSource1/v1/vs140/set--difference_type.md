---
title: "set::difference_type"
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
  - "set::difference_type"
  - "std.set.difference_type"
  - "set.difference_type"
  - "std::set::difference_type"
  - "difference_type"
  - "set/std::set::difference_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "difference_type typedef"
ms.assetid: 7cefcf60-1b85-45cd-9922-b7be2ea0f0c2
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::difference_type
A signed integer type that can be used to represent the number of elements of a set in a range between elements pointed to by iterators.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is the type returned when subtracting or incrementing through iterators of the container. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is typically used to represent the number of elements in the range *[_First, _Last)* between the iterators <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, includes the element pointed to by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and the range of elements up to, but not including, the element pointed to by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 Note that although <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is available for all iterators that satisfy the requirements of an input iterator, which includes the class of bidirectional iterators supported by reversible containers such as set, subtraction between iterators is only supported by random-access iterators provided by a random-access container such as vector.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The number '5' occurs 0 times in set s1.**  
**The number '10' occurs 1 times in set s1.**  
**The number '20' occurs 1 times in set s1.**  
**The number of elements in the set s1 is: 2.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)