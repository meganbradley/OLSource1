---
title: "multimap::equal_range"
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
  - "multimap::equal_range"
  - "map/std::multimap::equal_range"
  - "multimap.equal_range"
  - "equal_range"
  - "std.multimap.equal_range"
  - "std::multimap::equal_range"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_range method"
ms.assetid: 8868e0e8-7b90-439a-98e2-4d4016303b3c
caps.latest.revision: 18
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# multimap::equal_range
Finds the range of elements where the key of the element matches a specified value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the multimap being searched.  
  
## Return Value  
 A pair of iterators such that the first is the [lower_bound](../vs140/multimap--lower_bound.md) of the key and the second is the [upper_bound](../vs140/multimap--upper_bound.md) of the key.  
  
 To access the first iterator of a pair <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.**first** and to dereference the lower bound iterator, use \*(<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.**first**). To access the second iterator of a pair <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.**second** and to dereference the upper bound iterator, use \*(<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.**second**).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The lower bound of the element with a key of 2 in the multimap m1 is: 20.**  
**The upper bound of the element with a key of 2 in the multimap m1 is: 30.**  
**A direct call of upper_bound( 2 ) gives 30,**  
 **matching the 2nd element of the pair returned by equal_range( 2 ).**  
**The multimap m1 doesn't have an element with a key less than 4.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)