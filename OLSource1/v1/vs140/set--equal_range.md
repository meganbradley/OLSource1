---
title: "set::equal_range"
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
  - "equal_range"
  - "std::set::equal_range"
  - "set/std::set::equal_range"
  - "set::equal_range"
  - "set.equal_range"
  - "std.set.equal_range"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_range method"
ms.assetid: dd80381e-5b10-4c84-932f-688eeeb5c77c
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::equal_range
Returns a pair of iterators respectively to the first element in a set with a key that is greater than or equal to a specified key and to the first element in the set with a key that is greater than the key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the set being searched.  
  
## Return Value  
 A pair of iterators where the first is the [lower_bound](../vs140/set--lower_bound.md) of the key and the second is the [upper_bound](../vs140/set--upper_bound.md) of the key.  
  
 To access the first iterator of a pair <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.**first**, and to dereference the lower bound iterator, use \*(<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.**first**). To access the second iterator of a pair <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.**second**, and to dereference the upper bound iterator, use \*(<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.**second**).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The upper bound of the element with a key of 20 in the set s1 is: 30.**  
**The lower bound of the element with a key of 20 in the set s1 is: 20.**  
**A direct call of upper_bound( 20 ) gives 30,**  
**matching the 2nd element of the pair returned by equal_range( 20 ).**  
**The set s1 doesn't have an element with a key less than 40.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [set::lower_bound, set::upper_bound, and set::equal_range](../vs140/set--lower_bound--set--upper_bound--and-set--equal_range.md)   
 [Standard Template Library](../vs140/standard-template-library.md)