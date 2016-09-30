---
title: "map::find"
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
  - "find"
  - "std::map::find"
  - "std.map.find"
  - "map::find"
  - "map.find"
  - "map/std::map::find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find method"
ms.assetid: c4fa43ca-21a0-4bf5-ba71-e757a6e8bdca
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# map::find
Returns an iterator that refers to the location of an element in a map that has a key equivalent to a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The key value to be matched by the sort key of an element from the map being searched.  
  
## Return Value  
 An iterator that refers to the location of an element with a specified key, or the location succeeding the last element in the map (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) if no match is found for the key.  
  
## Remarks  
 The member function returns an iterator that refers to an element in the map whose sort key is equivalent to the argument key under a binary predicate that induces an ordering based on a less than comparability relation.  
  
 If the return value of **find** is assigned to a **const_iterator**, the map object cannot be modified. If the return value of **find** is assigned to an **iterator**, the map object can be modified  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
 **The starting map m1 is (key, value):2 elements: (40, Zr) (45, Rh)Inserting the following vector data into m1:6 elements: (43, Tc) (41, Nb) (46, Pd) (42, Mo) (44, Ru) (44, Ru)The modified map m1 is (key, value):7 elements: (40, Zr) (41, Nb) (42, Mo) (43, Tc) (44, Ru) (45, Rh) (46, Pd)Trying find() on value 45Element found: (45, Rh)Trying find() on value 6Element not found.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [map::insert, map::find, and map::end](../vs140/map--insert--map--find--and-map--end.md)   
 [Standard Template Library](../vs140/standard-template-library.md)