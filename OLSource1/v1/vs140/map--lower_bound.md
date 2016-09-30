---
title: "map::lower_bound"
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
  - "std.map.lower_bound"
  - "std::map::lower_bound"
  - "lower_bound"
  - "map.lower_bound"
  - "map/std::map::lower_bound"
  - "map::lower_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lower_bound function"
ms.assetid: 8336b17c-36c2-4382-883b-3fb1db0f99a3
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::lower_bound
Returns an iterator to the first element in a map with a key value that is equal to or greater than that of a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The argument key value to be compared with the sort key of an element from the map being searched.  
  
## Return Value  
 An **iterator** or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that addresses the location of an element in a map that with a key that is equal to or greater than the argument key, or that addresses the location succeeding the last element in the map if no match is found for the key.  
  
 If the return value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the map object cannot be modified. If the return value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is assigned to an **iterator**, the map object can be modified.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first element of map m1 with a key of 2 is: 20.**  
**The map m1 doesn't have an element with a key of 4.**  
**The element of m1 with a key matching that of the last element is: 30.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)