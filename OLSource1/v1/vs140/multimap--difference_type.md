---
title: "multimap::difference_type"
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
  - "multimap.difference_type"
  - "std::multimap::difference_type"
  - "std.multimap.difference_type"
  - "map/std::multimap::difference_type"
  - "difference_type"
  - "multimap::difference_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "difference_type typedef"
ms.assetid: 8766c8ca-2859-4ed1-ad04-c0649c4a55ce
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::difference_type
A signed integer type that can be used to represent the number of elements of a multimap in a range between elements pointed to by iterators.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is the type returned when subtracting or incrementing through iterators of the container. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is typically used to represent the number of elements in the range [*_First, _Last*) between the iterators <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, includes the element pointed to by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and the range of elements up to, but not including, the element pointed to by *_Last*.  
  
 Note that although <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is available for all iterators that satisfy the requirements of an input iterator, which includes the class of bidirectional iterators supported by reversible containers such as set, subtraction between iterators is only supported by random-access iterators provided by a random-access container such as vector.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The number of elements in the multimap m1 is: 4.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)