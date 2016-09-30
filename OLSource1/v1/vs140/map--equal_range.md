---
title: "map::equal_range"
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
  - "map.equal_range"
  - "equal_range"
  - "std.map.equal_range"
  - "map::equal_range"
  - "map/std::map::equal_range"
  - "std::map::equal_range"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_range method"
ms.assetid: 815ef7ac-3b84-4ec1-8b35-1d9f99e854a0
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::equal_range
Returns a pair of iterators that represent the [lower_bound](../vs140/map--lower_bound.md) of the key and the [upper_bound](../vs140/map--upper_bound.md) of the key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The argument key value to be compared with the sort key of an element from the map being searched.  
  
## Return Value  
 To access the first iterator of a pair <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.**first**, and to dereference the lower bound iterator, use \*(<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.**first**). To access the second iterator of a pair <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.**second**, and to dereference the upper bound iterator, use \*(<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.**second**).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The lower bound of the element with a key of 2 in the map m1 is: 20.**  
**The upper bound of the element with a key of 2 in the map m1 is: 30.**  
**A direct call of upper_bound( 2 ) gives 30,**  
 **matching the 2nd element of the pair returned by equal_range( 2 ).**  
**The map m1 doesn't have an element with a key less than 40.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)